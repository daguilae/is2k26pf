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

            string sql = @"SELECT  
                C.pk_id_compra AS Compra,
                C.cmp_fecha AS Fecha,
                C.cmp_serie_factura AS Serie,
                C.cmp_numero_factura AS NoFactura,
                PR.cmp_Nombre_Proveedor AS Proveedor,
                C.cmp_tipo_compra AS TipoPago, 
                C.cmp_estado AS Estado,
                C.cmp_total AS Total -- Usamos el total acumulado en el encabezado
            FROM tbl_compra C
            INNER JOIN tbl_proveedores PR ON C.fk_id_proveedor = PR.pk_id_proveedor
            ORDER BY C.pk_id_compra DESC;";
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

        public DataTable buscarOrdenCompletaPorNumero(string numeroOrden)
        {
            throw new NotImplementedException();
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





        // buscar compra
        public DataTable buscarCompraCompletaPorNumero(string numeroFactura)
        {
            DataTable dt = new DataTable();

            string sql = $@"
        SELECT 
            c.pk_id_compra,
            c.cmp_serie_factura,
            c.cmp_numero_factura,
            c.cmp_fecha,
            c.cmp_fecha_vencimiento,
            c.fk_id_proveedor,
            c.fk_id_bodega,
            c.fk_id_orden_compra,
            c.cmp_tipo_compra,
            c.cmp_dias_credito,
            c.cmp_subtotal,
            c.cmp_total,
            c.cmp_estado,
            dc.fk_inventario_id,
            dc.fk_id_unidad,
            dc.cmp_cantidad,
            dc.cmp_precio,
            (dc.cmp_cantidad * dc.cmp_precio) AS cmp_subtotal_linea,
            i.nombre_prod,
            CONCAT(u.ID_Unidad, '_', u.Abreviacion_Medida) AS Nombre_Unidad,
            p.cmp_Nombre_Proveedor,
            b.Cmp_Nombre_Bodega,
            oc.cmp_numero AS numero_orden
        FROM tbl_compra c
        LEFT JOIN tbl_detalle_compra dc
            ON c.pk_id_compra = dc.fk_id_compra
        LEFT JOIN tbl_inventario i
            ON dc.fk_inventario_id = i.pk_inventario_id
        LEFT JOIN tbl_unidad_de_medida u
            ON dc.fk_id_unidad = u.ID_Unidad
        LEFT JOIN tbl_proveedores p
            ON c.fk_id_proveedor = p.pk_id_proveedor
        LEFT JOIN tbl_bodega b
            ON c.fk_id_bodega = b.Pk_Id_Bodega
        LEFT JOIN tbl_orden_compra oc
            ON c.fk_id_orden_compra = oc.pk_id_orden_compra
        WHERE c.cmp_numero_factura LIKE '%{numeroFactura}%'
        ORDER BY dc.pk_id_detalle_compra ASC";

            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar compra: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return dt;
        }

        // eliminar compra
        public void eliminarCompra(string numeroFactura)
        {
            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcCommand cmdId = new OdbcCommand(
                    $"SELECT pk_id_compra FROM tbl_compra " +
                    $"WHERE cmp_numero_factura = '{numeroFactura}'", conn);

                object resultado = cmdId.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                    throw new Exception("No se encontró la compra para eliminar.");

                int idCompra = Convert.ToInt32(resultado);

                // Primero eliminar detalle
                OdbcCommand cmdDetalle = new OdbcCommand(
                    $"DELETE FROM tbl_detalle_compra WHERE fk_id_compra = {idCompra}", conn);
                cmdDetalle.ExecuteNonQuery();

                // Luego eliminar encabezado
                OdbcCommand cmdEncabezado = new OdbcCommand(
                    $"DELETE FROM tbl_compra WHERE pk_id_compra = {idCompra}", conn);
                cmdEncabezado.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar compra: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

        // editar solo encabezado 
        public void editarSoloEncabezadoCompra(string numeroFactura, int idProveedor,
                                                int idBodega, int idOrdenCompra,
                                                string serieFactura, DateTime fecha,
                                                DateTime fechaVencimiento, string tipoCompra,
                                                int diasCredito, decimal subtotal, decimal total)
        {
            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcCommand cmdId = new OdbcCommand(
                    $"SELECT pk_id_compra FROM tbl_compra " +
                    $"WHERE cmp_numero_factura = '{numeroFactura}'", conn);

                object resultado = cmdId.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                    throw new Exception("No se encontró la compra.");

                int idCompra = Convert.ToInt32(resultado);
                string fechaStr = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaVencStr = fechaVencimiento.ToString("yyyy-MM-dd HH:mm:ss");
                string pagoLimpio = tipoCompra.Trim().ToLower();
                string subtotalStr = subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string totalStr = total.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string diasStr = (pagoLimpio == "credito" && diasCredito > 0)
                                         ? diasCredito.ToString() : "0";

                string sqlUpdate = $@"UPDATE tbl_compra 
            SET
                fk_id_proveedor      = {idProveedor},
                fk_id_bodega         = {idBodega},
                fk_id_orden_compra   = {idOrdenCompra},
                cmp_serie_factura    = '{serieFactura}',
                cmp_fecha            = '{fechaStr}',
                cmp_fecha_vencimiento = '{fechaVencStr}',
                cmp_tipo_compra      = '{pagoLimpio}',
                cmp_dias_credito     = {diasStr},
                cmp_subtotal         = {subtotalStr},
                cmp_total            = {totalStr}
            WHERE pk_id_compra = {idCompra}";

                OdbcCommand cmdUpdate = new OdbcCommand(sqlUpdate, conn);
                int filasAfectadas = cmdUpdate.ExecuteNonQuery();

                if (filasAfectadas == 0)
                    throw new Exception($"El UPDATE no afectó ninguna fila. ID: {idCompra}");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar encabezado compra: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }

        //  Editar toda la compra
        public void editarCompra(string numeroFactura, int idProveedor,
                                  int idBodega, int idOrdenCompra,
                                  string serieFactura, DateTime fecha,
                                  DateTime fechaVencimiento, string tipoCompra,
                                  int diasCredito, decimal subtotal, decimal total,
                                  List<(int idInventario, int idUnidad, float cantidad, decimal precio)> detalles)
        {
            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcCommand cmdId = new OdbcCommand(
                    $"SELECT pk_id_compra FROM tbl_compra " +
                    $"WHERE cmp_numero_factura = '{numeroFactura}'", conn);

                object resultado = cmdId.ExecuteScalar();

                if (resultado == null || resultado == DBNull.Value)
                    throw new Exception("No se encontró la compra para editar.");

                int idCompra = Convert.ToInt32(resultado);
                string fechaStr = fecha.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaVencStr = fechaVencimiento.ToString("yyyy-MM-dd HH:mm:ss");
                string pagoLimpio = tipoCompra.Trim().ToLower();
                string subtotalStr = subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string totalStr = total.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string diasStr = (pagoLimpio == "credito" && diasCredito > 0)
                                         ? diasCredito.ToString() : "0";

                // ── Actualizar encabezado ──
                string sqlUpdate = $@"UPDATE tbl_compra 
            SET
                fk_id_proveedor       = {idProveedor},
                fk_id_bodega          = {idBodega},
                fk_id_orden_compra    = {idOrdenCompra},
                cmp_serie_factura     = '{serieFactura}',
                cmp_fecha             = '{fechaStr}',
                cmp_fecha_vencimiento = '{fechaVencStr}',
                cmp_tipo_compra       = '{pagoLimpio}',
                cmp_dias_credito      = {diasStr},
                cmp_subtotal          = {subtotalStr},
                cmp_total             = {totalStr}
            WHERE pk_id_compra = {idCompra}";

                OdbcCommand cmdUpdate = new OdbcCommand(sqlUpdate, conn);
                int filasAfectadas = cmdUpdate.ExecuteNonQuery();

                if (filasAfectadas == 0)
                    throw new Exception($"El UPDATE no afectó ninguna fila. ID: {idCompra}");

                // ── Eliminar detalle anterior ──
                OdbcCommand cmdBorrar = new OdbcCommand(
                    $"DELETE FROM tbl_detalle_compra WHERE fk_id_compra = {idCompra}", conn);
                cmdBorrar.ExecuteNonQuery();

                // ── Insertar nuevo detalle ──
                foreach (var item in detalles)
                {
                    string cantidadStr = item.cantidad.ToString(
                        System.Globalization.CultureInfo.InvariantCulture);
                    string precioStr = item.precio.ToString(
                        System.Globalization.CultureInfo.InvariantCulture);

                    string sqlDetalle = $@"INSERT INTO tbl_detalle_compra
                (fk_id_compra, fk_inventario_id, fk_id_unidad,
                 cmp_cantidad, cmp_precio)
                VALUES ({idCompra}, {item.idInventario}, {item.idUnidad},
                        {cantidadStr}, {precioStr})";

                    OdbcCommand cmdDetalle = new OdbcCommand(sqlDetalle, conn);
                    cmdDetalle.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar compra: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }



    }
}
