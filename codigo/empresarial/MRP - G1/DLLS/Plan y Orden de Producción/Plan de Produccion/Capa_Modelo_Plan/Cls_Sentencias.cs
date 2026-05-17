using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Plan
{
    public class Cls_Sentencias
    {
        Cls_Conexion conexion = new Cls_Conexion();
        // Método para crear guardar el proceso completo de plan y ordenes de producción
        public int creaciónCompleta(int iNoPedido, string sDescripcion, int iEstadoPlan, DateTime fechaPlan, List<Cls_Sentencia_OrdenTemp> listaOrdenes)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    OdbcTransaction transaccion = con.BeginTransaction();
                    try
                    {
                        //Código para crear el Plan
                        string sql = @"INSERT INTO Tbl_Plan_Produccion
                                       (Fk_Id_Orden_Recibida,  Fk_Id_Estado_Plan_Produccion, Fecha_Plan_Produccion, Descripcion_Plan_Produccion)
                                       VALUES (?, ?, ?, ?)";
                        OdbcCommand cmd = new OdbcCommand(sql, con, transaccion);
                        cmd.Parameters.AddWithValue("", iNoPedido);
                        cmd.Parameters.AddWithValue("", iEstadoPlan);
                        cmd.Parameters.AddWithValue("", fechaPlan);
                        cmd.Parameters.AddWithValue("", sDescripcion);
                        cmd.ExecuteNonQuery();

                        //Obtener el id del BOM
                        OdbcCommand cmdLastId = new OdbcCommand("SELECT LAST_INSERT_ID();", con, transaccion);
                        int idPlan = Convert.ToInt32(cmdLastId.ExecuteScalar());

                        // Ingresar ordenes de producción

                        string sIngresarOrdenes = @"INSERT INTO Tbl_Orden_Produccion
                                                    (Fk_Id_Plan_Produccion, Fk_Id_Material, Fk_Id_Estado_Orden_Produccion,
                                                     Cantidad_Programada_Orden_Produccion,  Fecha_Inicio_Orden_Produccion, Fecha_Fin_Orden_Produccion)
                                                    VALUES (?, ?, ?, ?, ?, ?)";
                        OdbcCommand cmdGuardar = new OdbcCommand(sIngresarOrdenes, con, transaccion);
                        foreach (Cls_Sentencia_OrdenTemp orden in listaOrdenes)
                        {
                            cmdGuardar.Parameters.Clear();

                            cmdGuardar.Parameters.AddWithValue("", idPlan);
                            cmdGuardar.Parameters.AddWithValue("", orden.IdMaterial);
                            cmdGuardar.Parameters.AddWithValue("", orden.IdEstado);
                            cmdGuardar.Parameters.AddWithValue("", orden.Cantidad);
                            cmdGuardar.Parameters.AddWithValue("", orden.FechaInicio);
                            cmdGuardar.Parameters.AddWithValue("", orden.FechaFin);

                            cmdGuardar.ExecuteNonQuery();
                        }
                        transaccion.Commit();
                        return idPlan;

                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar plan y orden de producción: " + ex.Message);
            }
        }



        /* --------------------------------------------- Métodos para el encabezado --------------------------------------------*/
        public DataTable funCodigosPlan()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaPlan = @"SELECT p.Pk_Id_Plan_Produccion AS CodigoPlan
                                            FROM Tbl_Plan_Produccion p";
                    OdbcCommand cmd = new OdbcCommand(sConsultaPlan, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los planes" + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerDatosPlan(
            int? iCodigoPlan = null,
            int? iEstadoPlan = null,
            DateTime? fechaInicio = null,
            DateTime? fechaFin = null)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaPlan = @"SELECT 
                                    p.Pk_Id_Plan_Produccion AS CodigoPlan,
                                    p.Fk_Id_Orden_Recibida AS NoOrdenRecibida,
                                    p.Descripcion_Plan_Produccion AS Descripcion,
                                    p.Fecha_Plan_Produccion AS Fecha,
                                    e.Nombre_Estado_Plan_Produccion AS EstadoPlan
                                    FROM Tbl_Plan_Produccion p
                                    JOIN Tbl_Estado_Plan_Produccion e 
                                    ON p.Fk_Id_Estado_Plan_Produccion = e.Pk_Id_Estado_Plan_Produccion
                                    WHERE 1=1";

                    OdbcCommand cmd = new OdbcCommand();

                    // Filtro por ID
                    if (iCodigoPlan.HasValue)
                    {
                        sConsultaPlan += " AND p.Pk_Id_Plan_Produccion = ?";
                        cmd.Parameters.AddWithValue("", iCodigoPlan.Value);
                    }

                    // Filtro por estado
                    if (iEstadoPlan.HasValue && iEstadoPlan.Value > 0)
                    {
                        sConsultaPlan += " AND p.Fk_Id_Estado_Plan_Produccion = ?";
                        cmd.Parameters.AddWithValue("", iEstadoPlan.Value);
                    }

                    // Filtro por rango de fechas
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        sConsultaPlan += " AND p.Fecha_Plan_Produccion BETWEEN ? AND ?";
                        cmd.Parameters.AddWithValue("", fechaInicio.Value);
                        cmd.Parameters.AddWithValue("", fechaFin.Value);
                    }

                    cmd.Connection = con;
                    cmd.CommandText = sConsultaPlan;

                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del plan: " + ex.Message, ex);
            }

            return tabla;
        }

        public void pro_ModificarPlan(int iCodigoPlan, string sDescripcion, int iEstado, DateTime fechaPlan)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sActualizar = @"UPDATE Tbl_Plan_Produccion
                                   SET Fk_Id_Estado_Plan_Produccion = ?,
                                       Fecha_Plan_Produccion = ?,
                                       Descripcion_Plan_Produccion = ?
                                   WHERE Pk_Id_Plan_Produccion = ?";
                    OdbcCommand cmd = new OdbcCommand(sActualizar, con);
                    cmd.Parameters.AddWithValue("", iEstado);
                    cmd.Parameters.AddWithValue("", fechaPlan);
                    cmd.Parameters.AddWithValue("", sDescripcion);
                    cmd.Parameters.AddWithValue("", iCodigoPlan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el plan: " + ex.Message);
            }
        }


    }
}
