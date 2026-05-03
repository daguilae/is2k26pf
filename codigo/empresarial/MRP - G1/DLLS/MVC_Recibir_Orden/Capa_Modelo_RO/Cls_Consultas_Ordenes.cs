using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_RO
{
    public class Cls_Consultas_Ordenes
    {
        private Cls_Conexion conexion = new Cls_Conexion();

        //GUARDAR 
        public bool GuardarOrden(string idLog, int estado, DateTime requerida, string obs, DataTable detalle)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            OdbcTransaction transaccion = conn.BeginTransaction();

            try
            {
                // INSERT directo en lugar del stored procedure
                OdbcCommand cmdMaestro = new OdbcCommand(
                    "INSERT INTO Tbl_Orden_Recibida (Id_Externo_Logistica, Fk_Id_Estado_Orden_Recibida, Fecha_Requerida, Observacion) VALUES (?, ?, ?, ?)",
                    conn);
                cmdMaestro.Transaction = transaccion;

                cmdMaestro.Parameters.Add("?", OdbcType.VarChar).Value = idLog;
                cmdMaestro.Parameters.Add("?", OdbcType.Int).Value = estado;
                cmdMaestro.Parameters.Add("?", OdbcType.Date).Value = requerida.ToString("yyyy-MM-dd");
                cmdMaestro.Parameters.Add("?", OdbcType.VarChar).Value = obs;

                cmdMaestro.ExecuteNonQuery();

                // Obtener el ID generado
                OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn);
                cmdId.Transaction = transaccion;
                int idGenerado = Convert.ToInt32(cmdId.ExecuteScalar());

                // Insertar detalle
                foreach (DataRow fila in detalle.Rows)
                {
                    OdbcCommand cmdDetalle = new OdbcCommand(
                        "INSERT INTO Tbl_Orden_Recibida_Detalle (Fk_Id_Orden_Recibida, Fk_Id_Material, Cantidad_Solicitada) VALUES (?, ?, ?)",
                        conn);
                    cmdDetalle.Transaction = transaccion;

                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = idGenerado;
                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = fila["Fk_Id_Material"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = fila["Cantidad_Solicitada"];

                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine("Error ODBC (Guardar): " + ex.Message);
                return false;
            }
        }

        // MODIFICAR
        public bool ModificarOrden(int pk, string idLog, int estado, DateTime requerida, string obs)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(
                    "UPDATE Tbl_Orden_Recibida SET Id_Externo_Logistica = ?, Fk_Id_Estado_Orden_Recibida = ?, Fecha_Requerida = ?, Observacion = ? WHERE Pk_Id_Orden_Recibida = ?",
                    conn);

                cmd.Parameters.Add("?", OdbcType.VarChar).Value = idLog;
                cmd.Parameters.Add("?", OdbcType.Int).Value = estado;
                cmd.Parameters.Add("?", OdbcType.Date).Value = requerida.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = obs;
                cmd.Parameters.Add("?", OdbcType.Int).Value = pk;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ODBC (Modificar): " + ex.Message);
                return false;
            }
        }

        // ELIMINAR
        public bool EliminarOrden(int pk)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(
                    "DELETE FROM Tbl_Orden_Recibida WHERE Pk_Id_Orden_Recibida = ?",
                    conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = pk;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ODBC (Eliminar): " + ex.Message);
                return false;
            }
        }

        // ACTUALIZAR GRID 
        public DataTable ObtenerDetalles(int pk)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = conexion.AbrirConexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(@"
            SELECT 
                m.Pk_Id_Materiales              AS Id_Material,
                m.Nombre_Material               AS Nombre_Material,
                u.Abreviatura_Unidad_Medida     AS UnidadMedida,
                d.Cantidad_Solicitada           AS CantidadSolicitada
            FROM Tbl_Orden_Recibida_Detalle d
            INNER JOIN Tbl_Materiales m 
                ON d.Fk_Id_Material = m.Pk_Id_Materiales
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            WHERE d.Fk_Id_Orden_Recibida = ?", conn);

                cmd.Parameters.Add("?", OdbcType.Int).Value = pk;

                OdbcDataAdapter adp = new OdbcDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ODBC (Leer): " + ex.Message);
            }
            return dt;
        }

        // Arón Ricardo Esquit - 0901-22-13036 - 30/04/26
        public bool GuardarDetalleOrden(int idOrden, DataTable detalle)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            OdbcTransaction transaccion = conn.BeginTransaction();

            try
            {
                foreach (DataRow fila in detalle.Rows)
                {
                    OdbcCommand cmdDetalle = new OdbcCommand(
                        "INSERT INTO Tbl_Orden_Recibida_Detalle (Fk_Id_Orden_Recibida, Fk_Id_Material, Cantidad_Solicitada) VALUES (?, ?, ?)",
                        conn
                    );

                    cmdDetalle.Transaction = transaccion;

                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = fila["Fk_Id_Material"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = fila["Cantidad_Solicitada"];

                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine("Error ODBC (Guardar Detalle): " + ex.Message);
                return false;
            }
        }
    }
}