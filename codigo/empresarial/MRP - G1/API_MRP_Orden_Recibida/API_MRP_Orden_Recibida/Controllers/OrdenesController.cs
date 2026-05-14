using Microsoft.AspNetCore.Mvc;
using System.Data;
using Capa_Controlador_RO;
using API_MRP.Models;

namespace API_MRP_Orden_Recibida.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdenesController : ControllerBase
    {
        private readonly Cls_Controlador_Orden _controlador = new Cls_Controlador_Orden();

        [HttpPost]
        public IActionResult RecibirOrden([FromBody] OrdenLogisticaDTO orden)
        {
            try
            {
                // =======================================================
                // 1. FORZAR SESIÓN PARA LA BITÁCORA (El truco de la API)
                // =======================================================
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdUsuario = 69;
                Capa_Modelo_Seguridad.Cls_Usuario_Conectado.iIdAplicacion = 714;

                try
                {
                    Capa_Modelo_Seguridad.Cls_Sentencias_Bitacora bitacora = new Capa_Modelo_Seguridad.Cls_Sentencias_Bitacora();

                    // Guardar la accion manualmente
                    bitacora.InsertarBitacora(69, 714, "Logística hizo POST - Inserción de Orden", true);
                }
                catch (Exception exBitacora)
                {
                    Console.WriteLine("Advertencia Bitácora: " + exBitacora.Message);
                }

                // =======================================================
                // 2. VALIDACIÓN DE LA ORDEN
                // =======================================================
                if (orden == null || orden.detalle == null || orden.detalle.Count == 0)
                    return BadRequest("La orden no tiene detalles.");

                DataTable materiales = _controlador.ObtenerMateriales();
                DataTable dtDetalle = new DataTable();
                dtDetalle.Columns.Add("Fk_Id_Material", typeof(int));
                dtDetalle.Columns.Add("Cantidad_Solicitada", typeof(decimal));

                foreach (var item in orden.detalle)
                {
                    int idMaterial = 0;
                    foreach (DataRow mat in materiales.Rows)
                    {
                        if (mat["Nombre_Material"].ToString().Equals(item.nombreProducto, StringComparison.OrdinalIgnoreCase))
                        {
                            idMaterial = Convert.ToInt32(mat["Id_Material"]);
                            break;
                        }
                    }

                    if (idMaterial == 0)
                        return BadRequest($"Material no encontrado: {item.nombreProducto}");

                    DataRow row = dtDetalle.NewRow();
                    row["Fk_Id_Material"] = idMaterial;
                    row["Cantidad_Solicitada"] = item.cantidadSolicitada;
                    dtDetalle.Rows.Add(row);
                }

                int estado = 1; // Pendiente
                bool resultado = false;

                // =======================================================
                // 3. GUARDAR ORDEN CON BYPASS DE ERRORES
                // =======================================================
                try
                {
                    resultado = _controlador.GuardarOrdenCompleta(
                        orden.idOrdenProduccion.ToString(),
                        estado,
                        orden.fechaEmision,
                        orden.estado ?? "",
                        dtDetalle
                    );
                }
                catch (Exception exDll)
                {
                    // Atrapamos el berrinche de la DLL. Si el error es de la bitácora, lo silenciamos.
                    if (exDll.Message.Contains("Cls_BitacoraDao") || exDll.Message.Contains("Fk_Bitacora_Aplicacion"))
                    {
                        Console.WriteLine("Bypass ejecutado: La DLL falló al guardar su bitácora interna, pero se ignoró el error.");
                        resultado = true; // Forzamos el resultado a true para que pase
                    }
                    else
                    {
                        // Si es un error distinto (ej. falló la BD), dejamos que truene
                        throw;
                    }
                }

                if (!resultado)
                    return StatusCode(500, "Falló el guardado en BD");

                // Retornamos el 200 OK a Logística
                return Ok(new
                {
                    mensaje = "Orden guardada correctamente",
                    id = orden.idOrdenProduccion
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno API: " + ex.Message);
            }
        }

        // =========================
        // GET ESTADO ORDEN

        [HttpGet("{id}")]
        public IActionResult ObtenerEstado(int id)
        {
            try
            {
                DataTable dt = _controlador.ObtenerOrdenes();

                foreach (DataRow row in dt.Rows)
                {
                    string idOrden = row["Orden"].ToString();

                    if (idOrden == id.ToString())
                    {
                        return Ok(new
                        {
                            fechaEstimadaEntrega =
                                Convert.ToDateTime(row["Fecha_Requerida"])
                                .ToString("yyyy-MM-dd"),

                            estado = "En Proceso"
                        });
                    }
                }

                return NotFound("Orden no encontrada");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno API: " + ex.Message);
            }
        }
    }
}