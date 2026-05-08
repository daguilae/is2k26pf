using System;
using System.Collections.Generic;
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
    }
}
