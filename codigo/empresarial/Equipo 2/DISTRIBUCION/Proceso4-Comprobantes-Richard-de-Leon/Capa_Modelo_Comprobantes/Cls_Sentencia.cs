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
            int fkIdProveedor,
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
                    Fk_ID_Proveedor,
                    Cmp_Nombre_Receptor,
                    Cmp_Fecha_Hora_Entrega,
                    Cmp_Observaciones,
                    Cmp_Estado
                )
                VALUES (?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaCompra);
                cmd.Parameters.AddWithValue("?", fkIdProveedor);
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
            int fkIdProveedor,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            try
            {
                string sql = @"UPDATE tbl_comprobante_compra SET
                    Fk_ID_Entrega_Compra = ?,
                    Fk_ID_Proveedor = ?,
                    Cmp_Nombre_Receptor = ?,
                    Cmp_Fecha_Hora_Entrega = ?,
                    Cmp_Observaciones = ?,
                    Cmp_Estado = ?
                WHERE Pk_ID_Comprobante_Compra = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conexion.fun_AbrirConexion());

                cmd.Parameters.AddWithValue("?", fkIdEntregaCompra);
                cmd.Parameters.AddWithValue("?", fkIdProveedor);
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
                        cc.Fk_ID_Proveedor,
                        p.cmp_Nombre_Proveedor AS Proveedor,
                        cc.Cmp_Nombre_Receptor,
                        cc.Cmp_Fecha_Hora_Entrega,
                        cc.Cmp_Observaciones,
                        cc.Cmp_Estado
                    FROM tbl_comprobante_compra cc
                    INNER JOIN tbl_proveedores p
                        ON cc.Fk_ID_Proveedor = p.pk_id_proveedor;
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
                    Fk_ID_Proveedor,
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
                string sql = @"SELECT Pk_Id_Entrega_Compra 
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

        public DataTable fun_ObtenerIdProveedor()
        {
            DataTable tabla = new DataTable();

            try
            {
                string sql = @"SELECT 
                                pk_id_proveedor,
                                cmp_Nombre_Proveedor
                               FROM tbl_proveedores";

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
                        e.Pk_Id_Entrega_Compra AS No_Entrega,
                        e.Fk_Id_Compra AS Compra,
                        i.nombre_prod AS Producto,
                        dc.cmp_cantidad AS Cantidad,
                        e.Fk_Id_Transporte AS Transporte,
                        e.Cmp_Direccion AS Direccion,
                        e.Cmp_Fecha AS Fecha,
                        e.Cmp_Estado_Entrega AS Estado
                    FROM tbl_entrega_compra e
                    INNER JOIN tbl_detalle_compra dc 
                        ON e.Fk_Id_Compra = dc.fk_id_compra
                    INNER JOIN tbl_inventario i 
                        ON dc.fk_inventario_id = i.pk_inventario_id
                    WHERE e.Pk_Id_Entrega_Compra = ?;
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

        //Cambiar de estado en entrega compra
        public bool Fun_Actualizar_Estado_Entrega_Compra(int I_Id_Entrega_Compra, string S_Estado)
        {
            OdbcConnection Cn = conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
            UPDATE tbl_entrega_compra
            SET Cmp_Estado_Entrega = ?
            WHERE Pk_Id_Entrega_Compra = ?;
        ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);
                Cmd.Parameters.AddWithValue("?", S_Estado);
                Cmd.Parameters.AddWithValue("?", I_Id_Entrega_Compra);

                int filas = Cmd.ExecuteNonQuery();
                return filas > 0;
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al actualizar estado de entrega compra: " + Ex.Message);
            }
            finally
            {
                conexion.fun_CerrarConexion();
            }
        }
    }
}