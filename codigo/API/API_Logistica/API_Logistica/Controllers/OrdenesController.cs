using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.Odbc;
using Capa_Controlador_Ventas;
using Capa_Modelo_Seguridad;
using API_Logistica.Models;

namespace API_Logistica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdenesController : ControllerBase
    {
        private readonly Cls_Ventas_Controlador _controlador =
            new Cls_Ventas_Controlador();

        // =========================
        // POST RECIBIR ORDEN DE MRP
        // =========================
        [HttpPost]
        public IActionResult RecibirOrdenMRP([FromBody] OrdenMaterialMRPDTO orden)
        {
            try
            {
                if (orden == null || orden.detalle == null || orden.detalle.Count == 0)
                    return BadRequest("La orden no tiene detalles.");

                DataTable inventario = _controlador.ObtenerInventarioGrid();

                DataTable dtDetalle = new DataTable();
                dtDetalle.Columns.Add("IdProducto", typeof(int));
                dtDetalle.Columns.Add("IdBodega", typeof(int));
                dtDetalle.Columns.Add("Cantidad", typeof(float));
                dtDetalle.Columns.Add("IdUnidad", typeof(int));
                dtDetalle.Columns.Add("Subtotal", typeof(float));

                foreach (var item in orden.detalle)
                {
                    DataRow productoEncontrado = null;

                    foreach (DataRow row in inventario.Rows)
                    {
                        string nombreBD = row["nombre_prod"].ToString().Trim();
                        string nombreJSON = item.nombreMaterial.Trim();

                        if (nombreBD.Equals(nombreJSON, StringComparison.OrdinalIgnoreCase))
                        {
                            productoEncontrado = row;
                            break;
                        }
                    }

                    if (productoEncontrado == null)
                        return BadRequest($"Producto no encontrado: {item.nombreMaterial}");

                    int idProducto = Convert.ToInt32(productoEncontrado["pk_inventario_id"]);
                    float precio = Convert.ToSingle(productoEncontrado["precio_unitario"]);
                    float subtotal = precio * item.cantidadSolicitada;

                    DataTable bodegas = _controlador.ObtenerBodegasPorProducto(idProducto);

                    if (bodegas.Rows.Count == 0)
                        return BadRequest($"No hay bodega para: {item.nombreMaterial}");

                    int idBodega = Convert.ToInt32(bodegas.Rows[0]["Pk_Id_Bodega"]);

                    DataTable unidades = _controlador.ObtenerUnidadPorProducto(idProducto);

                    if (unidades.Rows.Count == 0)
                        return BadRequest($"No hay unidad para: {item.nombreMaterial}");

                    int idUnidad = Convert.ToInt32(unidades.Rows[0]["ID_Unidad"]);

                    DataRow detalleRow = dtDetalle.NewRow();
                    detalleRow["IdProducto"] = idProducto;
                    detalleRow["IdBodega"] = idBodega;
                    detalleRow["Cantidad"] = item.cantidadSolicitada;
                    detalleRow["IdUnidad"] = idUnidad;
                    detalleRow["Subtotal"] = subtotal;

                    dtDetalle.Rows.Add(detalleRow);
                }

                float total = _controlador.CalcularTotal(dtDetalle);

                int idVentaGenerada = _controlador.ObtenerSiguienteIdVenta();

                bool resultado = _controlador.GuardarVenta(
                    orden.fechaSolicitud,
                    1,
                    1,
                    "Activo",
                    "Pedido",
                    total,
                    dtDetalle,
                    orden.fechaSolicitud,
                    orden.fechaSolicitud,
                    false
                );

                if (!resultado)
                    return StatusCode(500, "No se pudo guardar el pedido.");

                Cls_Conexion conexion = new Cls_Conexion();

                using (OdbcConnection conn = conexion.conexion())
                {
                    string sql = @"
                        UPDATE tbl_ventas
                        SET Fk_Id_Orden_Material_MRP = ?
                        WHERE Pk_Id_Ventas = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", orden.idOrdenMaterial);
                        cmd.Parameters.AddWithValue("?", idVentaGenerada);
                        cmd.ExecuteNonQuery();
                    }

                    conexion.desconexion(conn);
                }

                return Ok(new
                {
                    mensaje = "Pedido recibido y guardado correctamente",
                    idOrdenMaterial = orden.idOrdenMaterial,
                    idVentaLogistica = idVentaGenerada,
                    total = total
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno API: " + ex.Message);
            }
        }

        // =========================
        // GET CONSULTAR PEDIDO PARA MRP
        // =========================
        [HttpGet("{idOrdenMaterial}")]
        public IActionResult ObtenerPedido(int idOrdenMaterial)
        {
            try
            {
                Cls_Conexion conexion = new Cls_Conexion();

                using (OdbcConnection conn = conexion.conexion())
                {
                    string sql = @"
                        SELECT 
                            v.Pk_Id_Ventas,
                            v.Cmp_Fecha_Entrega,
                            v.Cmp_Saldo_Total,
                            i.nombre_prod,
                            d.Cmp_Cantidad_Producto,
                            d.Cmp_Precio_Subtotal
                        FROM tbl_ventas v
                        INNER JOIN tbl_detalle_ventas d
                            ON v.Pk_Id_Ventas = d.Fk_Id_Ventas
                        INNER JOIN tbl_inventario i
                            ON d.Fk_Id_Inventario = i.pk_inventario_id
                        WHERE v.Fk_Id_Orden_Material_MRP = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("?", idOrdenMaterial);

                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                            return NotFound("Pedido no encontrado.");

                        var detalle = new List<object>();

                        foreach (DataRow row in dt.Rows)
                        {
                            detalle.Add(new
                            {
                                nombreMaterial = row["nombre_prod"].ToString(),

                                cantidadEnviada = Convert.ToSingle(
                                    row["Cmp_Cantidad_Producto"]),

                                precioSubtotalMateria = Convert.ToSingle(
                                    row["Cmp_Precio_Subtotal"])
                            });
                        }

                        return Ok(new
                        {
                            idOrdenMaterial = idOrdenMaterial,

                            fechaEntrega = dt.Rows[0]["Cmp_Fecha_Entrega"]
                                .ToString(),

                            precioTotalVenta = Convert.ToSingle(
                                dt.Rows[0]["Cmp_Saldo_Total"]),

                            detalle = detalle
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno API: " + ex.Message);
            }
        }
    }
}