using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;

namespace Capa_modelo_factura
{
    public class Cls_Sentencias
    {


        // Instancia de tu clase de conexión (suponiendo que se llama Cls_Conexion)
        Cls_Conexion cn = new Cls_Conexion();

        public DataTable obtenerDetalles()
        {
            DataTable dt = new DataTable();
            // MODIFICADO: Agregamos JOIN con tbl_unidad_de_medida para traer el nombre
            string sql = @"SELECT  
                C.pk_id_compra AS Compra,
                C.cmp_fecha AS Fecha,
                PR.cmp_Nombre_Proveedor AS Proveedor,
                C.cmp_tipo_compra AS TipoPago, 
                C.cmp_estado AS Estado,
                I.nombre_prod AS Producto, 
                D.cmp_cantidad AS Cantidad, 
                U.Nombre_Unidad AS Unidad, -- Ahora traemos el nombre de la unidad
                D.cmp_precio AS Precio,
                (D.cmp_cantidad * D.cmp_precio) AS Total
            FROM tbl_detalle_compra D
            INNER JOIN tbl_compra C ON D.fk_id_compra = C.pk_id_compra
            INNER JOIN tbl_inventario I ON D.fk_inventario_id = I.pk_inventario_id
            INNER JOIN tbl_proveedores PR ON C.fk_id_proveedor = PR.pk_id_proveedor
            INNER JOIN tbl_unidad_de_medida U ON D.fk_id_unidad = U.ID_Unidad -- Nuevo JOIN
            ORDER BY C.cmp_fecha DESC;";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
                dataTable.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en sentencia: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }



        //proveedores
        public DataTable obtenerProveedores()
        {
            string sql = @"SELECT pk_id_proveedor, cmp_Nombre_Proveedor 
                   FROM tbl_proveedores
                   WHERE cmp_Estado = 'activo'";

            return cn.ObtenerDatos(sql);
        }

        // Orden de compra


        public DataTable obtenerOrdenesCompra()
        {
            string sql = @"SELECT pk_id_orden_compra, cmp_numero 
                   FROM tbl_orden_compra
                   WHERE cmp_estado = 'pendiente'";

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




        public DataTable obtenerProductos()
        {
            string sql = @"SELECT pk_inventario_id, nombre_prod 
                   FROM tbl_inventario 
                   WHERE estado_producto = 'ACTIVO'";
            return cn.ObtenerDatos(sql);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------//



        // Guardar compra principal

        
        public int guardarCompra(int idProveedor, int idOrdenCompra, int idBodega, string serie,
                           string numero, DateTime fecha, string tipoPago,
                           decimal subtotal, decimal total,
                           int diasCredito, DateTime? fechaVencimiento)
        {
            string pagoLimpio = tipoPago.Trim().ToLower();

            
            string fechaStr = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string subtotalStr = subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string totalStr = total.ToString(System.Globalization.CultureInfo.InvariantCulture);
            string diasStr = (pagoLimpio == "credito" && diasCredito > 0)
                                  ? diasCredito.ToString() : "NULL";
            string fechaVencStr = (pagoLimpio == "credito" && fechaVencimiento.HasValue)
                                  ? $"'{fechaVencimiento.Value.ToString("yyyy-MM-dd HH:mm:ss")}'"
                                  : "NULL";

            string sql = $@"INSERT INTO tbl_compra 
           (fk_id_proveedor, fk_id_orden_compra, fk_id_bodega, cmp_serie_factura, 
            cmp_numero_factura, cmp_fecha, cmp_tipo_compra, 
            cmp_subtotal, cmp_total, cmp_estado,
            cmp_dias_credito, cmp_fecha_vencimiento) 
           VALUES ({idProveedor}, {idOrdenCompra}, {idBodega}, '{serie}', '{numero}', 
                   '{fechaStr}', '{pagoLimpio}', 
                   {subtotalStr}, {totalStr}, 'pendiente', 
                   {diasStr}, {fechaVencStr})";

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
                throw new Exception("Error al insertar cabecera: " + ex.Message + " | SQL: " + sql);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return idGenerado;
        }

        // Guardar cada fila del detalle


        
        public void guardarDetalleCompra(int idCompra, int idInventario, float cantidad, int idUnidad, decimal precio)
        {
            string precioStr = precio.ToString(System.Globalization.CultureInfo.InvariantCulture);

            
            string sql = $@"INSERT INTO tbl_detalle_compra 
                           (fk_id_compra, fk_inventario_id, fk_id_unidad, cmp_cantidad, cmp_precio) 
                           VALUES ({idCompra}, {idInventario}, {idUnidad}, {cantidad}, {precioStr})";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar detalle de compra: " + ex.Message + " | SQL: " + sql);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }


        // Obtener ID del inventario por nombre de producto
        public int obtenerIdInventario(string nombreProducto)
{
    string sql = "SELECT pk_inventario_id FROM tbl_inventario WHERE nombre_prod = ?";
    OdbcConnection conn = cn.conexion();
    int id = 0;

    try
    {
        OdbcCommand cmd = new OdbcCommand(sql, conn);
        cmd.Parameters.AddWithValue("?", nombreProducto);
        object result = cmd.ExecuteScalar();

        if (result == null)
            throw new Exception($"El producto '{nombreProducto}' no existe en la base de datos.");

        id = Convert.ToInt32(result);
    }
    catch (Exception ex)
    {
        throw new Exception("Error en búsqueda de inventario: " + ex.Message);
    }
    finally
    {
        cn.desconexion(conn);
    }

    return id;
}





        public DataTable buscarCompraPorNumero(string numeroFactura)
        {
            DataTable dt = new DataTable();
            // Buscamos en la tabla de compras filtrando por el número de factura
            string sql = @"SELECT * FROM tbl_compra WHERE cmp_numero_factura = ?";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", numeroFactura);
                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar compra: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }


        /*-----------------------------------Buscar por detallle de comra-------------------------------*/


        public DataTable obtenerDetallePorCompra(int idCompra)
        {
            DataTable dt = new DataTable();
            // MODIFICADO: JOIN con la tabla de unidades
            string sql = @"SELECT 
                        I.nombre_prod AS Producto, 
                        D.cmp_cantidad AS Cantidad, 
                        U.Nombre_Unidad AS Unidad, -- Nombre en lugar de ID
                        D.cmp_precio AS Precio,
                        (D.cmp_cantidad * D.cmp_precio) AS Subtotal
                   FROM tbl_detalle_compra D
                   INNER JOIN tbl_inventario I ON D.fk_inventario_id = I.pk_inventario_id
                   INNER JOIN tbl_unidad_de_medida U ON D.fk_id_unidad = U.ID_Unidad
                   WHERE D.fk_id_compra = ?";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", idCompra);
                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalle: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }

        /*--------------------Editar Compras------*/




        /*-----------------------Acutaliar Tablas-------------------*/





        public void actualizarCompra(int idCompra, int idProveedor, int idOrdenCompra, string serie,
                               string numero, DateTime fecha, string tipoPago,
                               decimal subtotal, decimal total,
                               int diasCredito, DateTime? fechaVencimiento)
        {
            string sql = @"UPDATE tbl_compra SET 
                   fk_id_proveedor = ?, 
                   fk_id_orden_compra = ?, 
                   cmp_serie_factura = ?, 
                   cmp_numero_factura = ?, 
                   cmp_fecha = ?, 
                   cmp_tipo_compra = ?, 
                   cmp_subtotal = ?, 
                   cmp_total = ?, 
                   cmp_dias_credito = ?, 
                   cmp_fecha_vencimiento = ? 
                   WHERE pk_id_compra = ?";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.Add("?", OdbcType.Int).Value = idProveedor;
                cmd.Parameters.Add("?", OdbcType.Int).Value = idOrdenCompra;
                cmd.Parameters.Add("?", OdbcType.VarChar, 20).Value = serie;
                cmd.Parameters.Add("?", OdbcType.VarChar, 50).Value = numero;
                cmd.Parameters.Add("?", OdbcType.DateTime).Value = fecha;
                cmd.Parameters.Add("?", OdbcType.VarChar, 10).Value = tipoPago.Trim().ToLower(); // Validar ENUM
                cmd.Parameters.Add("?", OdbcType.Decimal).Value = subtotal;
                cmd.Parameters.Add("?", OdbcType.Decimal).Value = total;

                // Manejo de nulos para crédito
                cmd.Parameters.Add("?", OdbcType.Int).Value = (diasCredito > 0) ? (object)diasCredito : DBNull.Value;
                cmd.Parameters.Add("?", OdbcType.DateTime).Value = fechaVencimiento.HasValue ? (object)fechaVencimiento.Value : DBNull.Value;

                // El ID de la compra para el WHERE
                cmd.Parameters.Add("?", OdbcType.Int).Value = idCompra;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cabecera: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }



        /*---------------------------------------------------------*/


        public void eliminarDetalleCompra(int idCompra)
        {
            string sql = "DELETE FROM tbl_detalle_compra WHERE fk_id_compra = ?";
            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idCompra;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al limpiar detalles anteriores: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }



        /*---------------------Buscar Bodega---------------*/



        public DataTable obtenerBodegas()
        {
            DataTable dt = new DataTable();
            
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




    }
}
