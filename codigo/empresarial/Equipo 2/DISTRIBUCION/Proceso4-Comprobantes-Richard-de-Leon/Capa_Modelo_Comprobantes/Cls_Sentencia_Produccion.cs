using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Sentencias_Comprobante_Produccion
    {
        Cls_Conexion conexion = new Cls_Conexion();

        public bool InsertarComprobanteProduccion(
            int fkIdEntregaProduccion,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"INSERT INTO tbl_comprobante_produccion
                (
                    Fk_ID_Entrega_Produccion,
                    Fk_ID_Cliente,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                )
                VALUES (?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaProduccion);
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

        public bool ActualizarComprobanteProduccion(
            int pkIdComprobanteProduccion,
            int fkIdEntregaProduccion,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"UPDATE tbl_comprobante_produccion SET
                    Fk_ID_Entrega_Produccion = ?,
                    Fk_ID_Cliente = ?,
                    Cmp_Nombre_Receptor = ?,
                    Cmp_Fecha_Hora_Entrega = ?,
                    Cmp_Observaciones = ?,
                    Cmp_Estado = ?
                WHERE Pk_ID_Comprobante_Produccion = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaProduccion);
                cmd.Parameters.AddWithValue("?", fkIdCliente);
                cmd.Parameters.AddWithValue("?", nombreReceptor);
                cmd.Parameters.AddWithValue("?", fechaHoraEntrega);
                cmd.Parameters.AddWithValue("?", observaciones);
                cmd.Parameters.AddWithValue("?", estado);
                cmd.Parameters.AddWithValue("?", pkIdComprobanteProduccion);

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

        public bool EliminarComprobanteProduccion(int pkIdComprobanteProduccion)
        {
            try
            {
                string sql = @"DELETE FROM tbl_comprobante_produccion 
                               WHERE Pk_ID_Comprobante_Produccion = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());
                cmd.Parameters.AddWithValue("?", pkIdComprobanteProduccion);

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

        public DataTable MostrarComprobantesProduccion()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"
                            SELECT 
                                cp.Pk_ID_Comprobante_Produccion,
                                cp.Fk_ID_Entrega_Produccion,
                                cp.Fk_ID_Cliente,                
                                c.Cmp_Nombre AS Cliente,         
                                cp.Cmp_Nombre_Receptor,
                                cp.Cmp_Fecha_Hora_Entrega,
                                cp.Cmp_Observaciones,
                                cp.Cmp_Estado
                            FROM tbl_comprobante_produccion cp
                            INNER JOIN tbl_clientes c 
                                ON cp.Fk_ID_Cliente = c.Pk_Id_Cliente;
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

        public DataTable BuscarComprobanteProduccion(int pkIdComprobanteProduccion)
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT 
                    Pk_ID_Comprobante_Produccion,
                    Fk_ID_Entrega_Produccion,
                    Fk_ID_Cliente,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                FROM tbl_comprobante_produccion
                WHERE Pk_ID_Comprobante_Produccion = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());
                cmd.Parameters.AddWithValue("?", pkIdComprobanteProduccion);

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

        public DataTable fun_ObtenerIdComprobanteProduccion()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_ID_Comprobante_Produccion 
                               FROM tbl_comprobante_produccion";

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

        public DataTable fun_ObtenerIdEntregaProduccion()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_ID_Entrega_Produccion 
                               FROM tbl_entrega_produccion";

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

        public DataTable Fun_Obtener_Detalle_Entrega_Produccion(int I_Id_Entrega_Produccion)
        {
            DataTable Dt_Datos = new DataTable();
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
            SELECT 
                p.Pk_Id_Entrega_Produccion AS No_Entrega,
                p.Fk_Id_OrdenP AS Produccion,
                i.nombre_prod AS Producto,
                dp.Cmp_Cantidad_Solicitada AS Cantidad,
                p.Fk_Id_Transporte AS Transporte,
                p.Cmp_Direccion AS Direccion,
                p.Cmp_Fecha AS Fecha,
                p.Cmp_Estado_Entrega AS Estado
            FROM tbl_entrega_produccion p
            INNER JOIN tbl_orden_produccion_detalle dp 
                ON p.Fk_Id_OrdenP = dp.Fk_ID_OrdenProduccion
            INNER JOIN tbl_inventario i 
                ON dp.Fk_ID_Producto = i.pk_inventario_id
            WHERE p.Pk_Id_Entrega_Produccion = ?;
        ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("@Pk_Id_Entrega_Produccion", I_Id_Entrega_Produccion);

                OdbcDataAdapter Da = new OdbcDataAdapter(Cmd);
                Da.Fill(Dt_Datos);
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al obtener detalle de entrega producción: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }

            return Dt_Datos;
        }

        public bool Fun_Actualizar_Estado_Entrega_Produccion(int I_Id_Entrega_Produccion, string S_Estado)
        {
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
            UPDATE tbl_entrega_produccion
            SET Cmp_Estado_Entrega = ?
            WHERE Pk_Id_Entrega_Produccion = ?;
        ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("?", S_Estado);
                Cmd.Parameters.AddWithValue("?", I_Id_Entrega_Produccion);

                int filas = Cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al actualizar estado de entrega producción: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }
        }
    }
}