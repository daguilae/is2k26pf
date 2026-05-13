using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Capa_controlador_orden_compra;

namespace Capa_modelo_orden_compra
{
    public class Cls_Sentencias
    {


        // Instancia de tu clase de conexión (suponiendo que se llama Cls_Conexion)
        Cls_Conexion cn = new Cls_Conexion();


        public DataTable obtenerDetalles()
        {
            DataTable dt = new DataTable();

            string sql = @"SELECT 
    O.pk_id_orden_compra AS Orden,
    O.cmp_numero AS NumeroOrden,
    O.cmp_fecha AS Fecha,
    O.cmp_fecha_entrega AS FechaEntrega,
    PR.cmp_Nombre_Proveedor AS Proveedor,
    O.cmp_tipo_pago AS TipoPago,
    O.cmp_estado AS Estado,
    I.nombre_prod AS Producto,
    U.Nombre_Unidad AS Unidad,
    D.cmp_cantidad AS Cantidad,
    D.cmp_precio AS Precio,
    (D.cmp_cantidad * D.cmp_precio) AS Total
FROM tbl_detalle_compra D
INNER JOIN tbl_orden_compra O
    ON D.fk_id_compra = O.pk_id_orden_compra
INNER JOIN tbl_inventario I
    ON D.fk_inventario_id = I.pk_inventario_id
INNER JOIN tbl_unidad_de_medida U
    ON D.fk_id_unidad = U.ID_Unidad
INNER JOIN tbl_proveedores PR
    ON O.fk_id_proveedor = PR.pk_id_proveedor
ORDER BY O.cmp_fecha DESC";

            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return dt;
        }




        public DataTable obtenerProductos()
        {
            string sql = @"SELECT pk_inventario_id, nombre_prod
                   FROM tbl_inventario 
                   WHERE estado_producto = 'ACTIVO'";
            return cn.ObtenerDatos(sql);
        }



        //proveedores
        public DataTable obtenerProveedores()
        {
            string sql = @"SELECT pk_id_proveedor, cmp_Nombre_Proveedor 
                   FROM tbl_proveedores
                   WHERE cmp_Estado = 'activo'";

            return cn.ObtenerDatos(sql);
        }



        public DataTable obtenerUnidadMedida()
        {
            string sql = @"SELECT ID_Unidad, 
                          CONCAT(ID_Unidad, '_', Abreviacion_Medida) AS Nombre_Unidad
                   FROM tbl_unidad_de_medida
                   WHERE Estado_Medida = 'Activo'";
            return cn.ObtenerDatos(sql);
        }


        public DataTable obtenerBodegas()
        {
            DataTable dt = new DataTable();
            // Seleccionamos el ID para el valor interno y el Nombre para mostrar al usuario
            string sql = "SELECT Pk_Id_Bodega, Cmp_Nombre_Bodega FROM tbl_bodega WHERE Cmp_Estado_Bodega = 'Activo';";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener bodegas para combo: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }




        /*--------------------Generar Oden de Compra Automatico y Guardar-----------------*/





        // 1. Generar número de orden
        public string generarNumeroOrden()
        {
            string sql = "SELECT MAX(cmp_numero) FROM tbl_orden_compra";
            OdbcConnection conn = cn.conexion();
            string nuevoNumero = "";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                object resultado = cmd.ExecuteScalar();

                int ultimoNumero = 0;

                if (resultado != null && resultado != DBNull.Value)
                {
                    string ultimo = resultado.ToString(); // ej: "OC-004"
                    string[] partes = ultimo.Split('-');
                    if (partes.Length == 2)
                        int.TryParse(partes[1], out ultimoNumero);
                }

                ultimoNumero++;
                nuevoNumero = "OC-" + ultimoNumero.ToString("D3"); // OC-001, OC-002...
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar número de orden: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return nuevoNumero;
        }

        //  Guardar encabezado 
        public int guardarOrdenCompra(int idProveedor, int idBodega, string numero,
                                       DateTime fecha, DateTime fechaEntrega,
                                       string tipoPago, int diasCredito,
                                       decimal subtotal, decimal total)
        {
            string pagoLimpio = tipoPago.Trim().ToLower();
            string fechaStr = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaEntregaStr = fechaEntrega.ToString("yyyy-MM-dd HH:mm:ss");
            string subtotalStr = subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string totalStr = total.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string diasStr = (pagoLimpio == "credito" && diasCredito > 0)
                             ? diasCredito.ToString() : "0";

            string sql = $@"INSERT INTO tbl_orden_compra
        (fk_id_proveedor, fk_id_bodega, cmp_numero, cmp_fecha,
         cmp_fecha_entrega, cmp_tipo_pago, cmp_dias_credito,
         cmp_subtotal, cmp_total, cmp_estado)
        VALUES ({idProveedor}, {idBodega}, '{numero}', '{fechaStr}',
                '{fechaEntregaStr}', '{pagoLimpio}', {diasStr},
                {subtotalStr}, {totalStr}, 'pendiente')";

            OdbcConnection conn = cn.conexion();
            int idGenerado = 0;

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();

                OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn);
                idGenerado = Convert.ToInt32(cmdId.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar orden: " + ex.Message + " | SQL: " + sql);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return idGenerado;
        }

        //  Guardar  detalle
        public void guardarDetalleOrdenCompra(int idOrden,
                                       int idInventario,
                                       int idUnidad,
                                       float cantidad,
                                       decimal precio)
        {
            string cantidadStr = cantidad.ToString(System.Globalization.CultureInfo.InvariantCulture);

            string precioStr = precio.ToString(System.Globalization.CultureInfo.InvariantCulture);

            string sql = $@"INSERT INTO tbl_detalle_orden_compra
(fk_id_orden_compra, fk_inventario_id, fk_id_unidad, cmp_cantidad, cmp_precio) VALUES ({idOrden},{idInventario},{idUnidad},{cantidadStr},{precioStr})";

            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar detalle: " + ex.Message
                                    + " | SQL: " + sql);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

        public DataTable ObtenerDetalleOrden()
        {
            DataTable tabla = new DataTable();
            string sql = @"
    SELECT 
        oc.pk_id_orden_compra AS id_orden,
        oc.cmp_fecha AS fecha,
        p.cmp_Nombre_Proveedor AS proveedor,
        oc.cmp_tipo_pago AS tipo_pago,
        oc.cmp_estado AS estado,
        i.nombre_prod AS producto,
        doc.cmp_cantidad AS cantidad,
        doc.cmp_precio AS precio,
        (doc.cmp_cantidad * doc.cmp_precio) AS total
    FROM tbl_orden_compra oc
    INNER JOIN tbl_detalle_orden_compra doc
        ON oc.pk_id_orden_compra = doc.fk_id_orden_compra
    INNER JOIN tbl_proveedores p
        ON oc.fk_id_proveedor = p.pk_id_proveedor
    INNER JOIN tbl_inventario i
        ON doc.fk_inventario_id = i.pk_inventario_id";

            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener detalle orden compra: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return tabla;
        }


        /*-----------Buscar--------------------*/


        public DataTable buscarOrdenPorNumero(string numeroOrden)
        {
            DataTable dt = new DataTable();
            string sql = $@"SELECT 
        O.pk_id_orden_compra AS Orden,
        O.cmp_numero AS NumeroOrden,
        O.cmp_fecha AS Fecha,
        O.cmp_fecha_entrega AS FechaEntrega,
        PR.cmp_Nombre_Proveedor AS Proveedor,
        O.cmp_tipo_pago AS TipoPago,
        O.cmp_estado AS Estado,
        I.nombre_prod AS Producto,
        D.cmp_cantidad AS Cantidad,
        D.cmp_precio AS Precio,
        (D.cmp_cantidad * D.cmp_precio) AS Total
    FROM tbl_detalle_orden_compra D
    INNER JOIN tbl_orden_compra O
        ON D.fk_id_orden_compra = O.pk_id_orden_compra
    INNER JOIN tbl_inventario I
        ON D.fk_inventario_id = I.pk_inventario_id
    INNER JOIN tbl_proveedores PR
        ON O.fk_id_proveedor = PR.pk_id_proveedor
    WHERE O.cmp_numero LIKE '%{numeroOrden}%'
    ORDER BY O.cmp_fecha DESC";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar orden: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }


        public string obtenerUltimoNumeroMRP()
        {
            string numero = "";

            string consulta = @"
        SELECT cmp_numero
        FROM tbl_orden_compra
        WHERE cmp_numero LIKE 'MRP-%'
        ORDER BY pk_id_orden_compra DESC
        LIMIT 1
    ";

            OdbcCommand cmd = new OdbcCommand(consulta, cn.conexion());

            object resultado = cmd.ExecuteScalar();

            if (resultado != null)
            {
                numero = resultado.ToString();
            }

            return numero;
        }










    }
}
