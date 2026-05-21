using System;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Sentencias
    {
        private Cls_Conexion Obj_Conexion = new Cls_Conexion();

        public bool Fun_Insertar_Comprobante_Venta(
            int I_Id_Venta,
            int I_Id_Entrega_Venta,
            int I_Id_Cliente,
            string S_Nombre_Receptor,
            DateTime Dt_Fecha_Venta,
            string S_Observaciones,
            string S_Estado
        )
        {
            OdbcConnection Cn = Obj_Conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
                    INSERT INTO tbl_comprobante_venta
                    (
                        Fk_Id_Ventas,
                        Fk_Id_Entrega_Venta,
                        Fk_Id_Cliente,
                        Cmp_Nombre_Receptor,
                        Cmp_Fecha_Hora_Entrega,
                        Cmp_Observaciones,
                        Cmp_Estado
                    )
                    VALUES (?, ?, ?, ?, ?, ?, ?);
                ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);

                Cmd.Parameters.AddWithValue("?", I_Id_Venta);
                Cmd.Parameters.AddWithValue("?", I_Id_Entrega_Venta);
                Cmd.Parameters.AddWithValue("?", I_Id_Cliente);
                Cmd.Parameters.AddWithValue("?", S_Nombre_Receptor);
                Cmd.Parameters.AddWithValue("?", Dt_Fecha_Venta);
                Cmd.Parameters.AddWithValue("?", S_Observaciones);
                Cmd.Parameters.AddWithValue("?", S_Estado);

                return Cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al insertar comprobante de venta: " + Ex.Message);
            }
            finally
            {
                Obj_Conexion.fun_CerrarConexion();
            }
        }

        public bool Fun_Modificar_Comprobante_Venta(
            int I_Id_Comprobante_Venta,
            int I_Id_Venta,
            int I_Id_Entrega_Venta,
            int I_Id_Cliente,
            string S_Nombre_Receptor,
            DateTime Dt_Fecha_Venta,
            string S_Observaciones,
            string S_Estado
        )
        {
            OdbcConnection Cn = Obj_Conexion.fun_AbrirConexion();

            try
            {
                string S_Query = @"
                    UPDATE tbl_comprobante_venta
                    SET
                        Fk_Id_Ventas = ?,
                        Fk_Id_Entrega_Venta = ?,
                        Fk_Id_Cliente = ?,
                        Cmp_Nombre_Receptor = ?,
                        Cmp_Fecha_Hora_Entrega = ?,
                        Cmp_Observaciones = ?,
                        Cmp_Estado = ?
                    WHERE Pk_Id_Comprobante_Venta = ?;
                ";

                OdbcCommand Cmd = new OdbcCommand(S_Query, Cn);

                Cmd.Parameters.AddWithValue("?", I_Id_Venta);
                Cmd.Parameters.AddWithValue("?", I_Id_Entrega_Venta);
                Cmd.Parameters.AddWithValue("?", I_Id_Cliente);
                Cmd.Parameters.AddWithValue("?", S_Nombre_Receptor);
                Cmd.Parameters.AddWithValue("?", Dt_Fecha_Venta);
                Cmd.Parameters.AddWithValue("?", S_Observaciones);
                Cmd.Parameters.AddWithValue("?", S_Estado);
                Cmd.Parameters.AddWithValue("?", I_Id_Comprobante_Venta);

                return Cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception Ex)
            {
                throw new Exception("Error al modificar comprobante de venta: " + Ex.Message);
            }
            finally
            {
                Obj_Conexion.fun_CerrarConexion();
            }
        }
    }
}