using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Sentencias_Comprobante_Venta
    {
        Cls_Conexion conexion = new Cls_Conexion();

        // INSERTAR
        public bool InsertarComprobanteVenta(
            int fkIdEntregaVenta,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"INSERT INTO tbl_comprobante_venta
                (
                    Fk_ID_Entrega_Venta,
                    Fk_ID_Cliente,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                )
                VALUES (?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaVenta);
                cmd.Parameters.AddWithValue("?", fkIdCliente);
                cmd.Parameters.AddWithValue("?", nombreReceptor);
                cmd.Parameters.AddWithValue("?", fechaHoraEntrega);
                cmd.Parameters.AddWithValue("?", observaciones);
                cmd.Parameters.AddWithValue("?", estado);

                cmd.ExecuteNonQuery();
                conexion.fun_CerrarConexion();

                return true;
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                return false;
            }
        }

        // ACTUALIZAR
        public bool ActualizarComprobanteVenta(
            int pkIdComprobanteVenta,
            int fkIdEntregaVenta,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"UPDATE tbl_comprobante_venta SET
                    Fk_ID_Entrega_Venta = ?,
                    Fk_ID_Cliente = ?,
                    Cmp_Nombre_Receptor = ?,
                    Cmp_Fecha_Hora_Entrega = ?,
                    Cmp_Observaciones = ?,
                    Cmp_Estado = ?
                WHERE Pk_ID_Comprobante_Venta = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaVenta);
                cmd.Parameters.AddWithValue("?", fkIdCliente);
                cmd.Parameters.AddWithValue("?", nombreReceptor);
                cmd.Parameters.AddWithValue("?", fechaHoraEntrega);
                cmd.Parameters.AddWithValue("?", observaciones);
                cmd.Parameters.AddWithValue("?", estado);
                cmd.Parameters.AddWithValue("?", pkIdComprobanteVenta);

                cmd.ExecuteNonQuery();
                conexion.fun_CerrarConexion();

                return true;
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                return false;
            }
        }

        // ELIMINAR
        public bool EliminarComprobanteVenta(int pkIdComprobanteVenta)
        {
            try
            {
                string sql = @"DELETE FROM tbl_comprobante_venta 
                               WHERE Pk_ID_Comprobante_Venta = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());
                cmd.Parameters.AddWithValue("?", pkIdComprobanteVenta);

                cmd.ExecuteNonQuery();
                conexion.fun_CerrarConexion();

                return true;
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                return false;
            }
        }

        // MOSTRAR
        public DataTable MostrarComprobantesVenta()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"
        SELECT 
            cv.Pk_ID_Comprobante_Venta,
            cv.Fk_ID_Entrega_Venta,
            cv.Fk_ID_Cliente,              
            c.Cmp_Nombre AS Cliente,       
            cv.Cmp_Nombre_Receptor,
            cv.Cmp_Fecha_Hora_Entrega,
            cv.Cmp_Observaciones,
            cv.Cmp_Estado
        FROM tbl_comprobante_venta cv
        INNER JOIN tbl_clientes c
            ON cv.Fk_ID_Cliente = c.Pk_Id_Cliente;
        ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conexion.fun_AbrirConexion());
                da.Fill(tabla);

                conexion.fun_CerrarConexion();
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                tabla = null;
            }

            return tabla;
        }

        // BUSCAR
        public DataTable BuscarComprobanteVenta(int pkIdComprobanteVenta)
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT 
                    Pk_ID_Comprobante_Venta,
                    Fk_ID_Entrega_Venta,
                    Fk_ID_Cliente,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                FROM tbl_comprobante_venta
                WHERE Pk_ID_Comprobante_Venta = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());
                cmd.Parameters.AddWithValue("?", pkIdComprobanteVenta);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);

                conexion.fun_CerrarConexion();
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                tabla = null;
            }

            return tabla;
        }

        // COMBO ID COMPROBANTE
        public DataTable fun_ObtenerIdComprobanteVenta()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_ID_Comprobante_Venta 
                               FROM tbl_comprobante_venta";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conexion.fun_AbrirConexion());
                da.Fill(tabla);

                conexion.fun_CerrarConexion();
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                tabla = null;
            }

            return tabla;
        }

        // COMBO ENTREGA
        public DataTable fun_ObtenerIdEntregaVenta()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_ID_Entrega_Venta 
                               FROM tbl_entrega_venta";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conexion.fun_AbrirConexion());
                da.Fill(tabla);

                conexion.fun_CerrarConexion();
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                tabla = null;
            }

            return tabla;
        }

        public DataTable fun_ObtenerIdCliente()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_Id_Cliente 
                       FROM tbl_clientes";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conexion.fun_AbrirConexion());
                da.Fill(tabla);

                conexion.fun_CerrarConexion();
            }
            catch (Exception)
            {
                conexion.fun_CerrarConexion();
                tabla = null;
            }

            return tabla;
        }
        // DETALLE ENTREGA
        public DataTable Fun_Obtener_Detalle_Entrega_Venta(int I_Id_Entrega_Venta)
        {
            DataTable Dt_Datos = new DataTable();
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
            SELECT 
                v.Pk_Id_Entrega_Venta AS No_Entrega,
                v.Fk_Id_Venta AS Venta,
                i.nombre_prod AS Producto,
                dv.Cmp_Cantidad_Producto AS Cantidad,
                v.Fk_Id_Transporte AS Transporte,
                v.Cmp_Direccion AS Direccion,
                v.Cmp_Fecha AS Fecha,
                v.Cmp_Estado_Entrega AS Estado
            FROM tbl_entrega_venta v
            INNER JOIN tbl_detalle_ventas dv 
                ON v.Fk_Id_Venta = dv.Fk_Id_Ventas
            INNER JOIN tbl_inventario i 
                ON dv.Fk_Id_Inventario = i.pk_inventario_id
            WHERE v.Pk_Id_Entrega_Venta = ?;
        ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("@Pk_Id_Entrega_Venta", I_Id_Entrega_Venta);

                OdbcDataAdapter Da = new OdbcDataAdapter(Cmd);
                Da.Fill(Dt_Datos);
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al obtener detalle de entrega venta: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }

            return Dt_Datos;
        }

        public bool Fun_Actualizar_Estado_Entrega_Venta(int I_Id_Entrega_Venta, string S_Estado)
        {
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
            UPDATE tbl_entrega_venta
            SET Cmp_Estado_Entrega = ?
            WHERE Pk_Id_Entrega_Venta = ?;
        ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("?", S_Estado);
                Cmd.Parameters.AddWithValue("?", I_Id_Entrega_Venta);

                int filas = Cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al actualizar estado de entrega venta: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }
        }
    }
}