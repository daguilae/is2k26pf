using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Sentencias_Comprobante_Compra
    {
        Cls_Conexion conexion = new Cls_Conexion();

        public bool InsertarComprobanteCompra(
            int fkIdEntregaCompra,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"INSERT INTO tbl_comprobante_compra
                (
                    Fk_ID_Entrega_Compra,
                    Fk_ID_Cliente,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                )
                VALUES (?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaCompra);
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

        public bool ActualizarComprobanteCompra(
            int pkIdComprobanteCompra,
            int fkIdEntregaCompra,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"UPDATE tbl_comprobante_compra SET
                    Fk_ID_Entrega_Compra = ?,
                    Fk_ID_Cliente = ?,
                    Cmp_Nombre_Receptor = ?,
                    Cmp_Fecha_Hora_Entrega = ?,
                    Cmp_Observaciones = ?,
                    Cmp_Estado = ?
                WHERE Pk_ID_Comprobante_Compra = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaCompra);
                cmd.Parameters.AddWithValue("?", fkIdCliente);
                cmd.Parameters.AddWithValue("?", nombreReceptor);
                cmd.Parameters.AddWithValue("?", fechaHoraEntrega);
                cmd.Parameters.AddWithValue("?", observaciones);
                cmd.Parameters.AddWithValue("?", estado);
                cmd.Parameters.AddWithValue("?", pkIdComprobanteCompra);

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

        public bool EliminarComprobanteCompra(int pkIdComprobanteCompra)
        {
            try
            {
                string sql = @"DELETE FROM tbl_comprobante_compra 
                               WHERE Pk_ID_Comprobante_Compra = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());
                cmd.Parameters.AddWithValue("?", pkIdComprobanteCompra);

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

        public DataTable MostrarComprobantesCompra()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"
                        SELECT 
                            cc.Pk_ID_Comprobante_Compra,
                            cc.Fk_ID_Entrega_Compra,
                            cc.Fk_ID_Cliente,
                            c.Cmp_Nombre AS Cliente,
                            cc.Cmp_Nombre_Receptor,
                            cc.Cmp_Fecha_Hora_Entrega,
                            cc.Cmp_Observaciones,
                            cc.Cmp_Estado
                        FROM tbl_comprobante_compra cc
                        INNER JOIN tbl_clientes c
                            ON cc.Fk_ID_Cliente = c.Pk_Id_Cliente;
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

        public DataTable BuscarComprobanteCompra(int pkIdComprobanteCompra)
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT 
                    Pk_ID_Comprobante_Compra,
                    Fk_ID_Entrega_Compra,
                    Fk_ID_Cliente,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                FROM tbl_comprobante_compra
                WHERE Pk_ID_Comprobante_Compra = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());
                cmd.Parameters.AddWithValue("?", pkIdComprobanteCompra);

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

        public DataTable fun_ObtenerIdComprobanteCompra()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_ID_Comprobante_Compra 
                               FROM tbl_comprobante_compra";

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

        public DataTable fun_ObtenerIdEntregaCompra()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT Pk_ID_Entrega_Compra 
                               FROM tbl_entrega_compra";

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

        public DataTable Fun_Obtener_Detalle_Entrega_Compra(int I_Id_Entrega_Compra)
        {
            DataTable Dt_Datos = new DataTable();
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
                    SELECT 
                        Pk_ID_Entrega_Compra,
                        Fk_Id_Compra,
                        Fk_Id_Transporte,
                        Cmp_Direccion,
                        Cmp_Fecha,
                        Cmp_Estado_Entrega
                    FROM tbl_entrega_compra
                    WHERE Pk_ID_Entrega_Compra = ?;
                ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("?", I_Id_Entrega_Compra);

                OdbcDataAdapter Da = new OdbcDataAdapter(Cmd);
                Da.Fill(Dt_Datos);
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al obtener detalle de entrega compra: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }

            return Dt_Datos;
        }

        public bool Fun_Eliminar_Comprobante_Compra(int I_Id_Comprobante_Compra)
        {
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
            DELETE FROM tbl_comprobante_compra
            WHERE Pk_ID_Comprobante_Compra = ?;
        ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("?", I_Id_Comprobante_Compra);

                return Cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al eliminar comprobante de compra: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }
        }
    }
}