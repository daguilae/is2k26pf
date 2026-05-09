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
    public class Cls_Sentencias_Cronograma
    {
        Cls_Conexion conexion = new Cls_Conexion();
        public DataTable fun_ObtenerDatosPlan(int iCodigoPlan)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaPlan = @"SELECT p.Fk_Id_Orden_Recibida AS NoOrdenRecibida, p.Descripcion_Plan_Produccion AS Descripcion,
                                            p.Fecha_Plan_Produccion AS Fecha,  e.Nombre_Estado_Plan_Produccion AS EstadoPlan
                                            FROM Tbl_Plan_Produccion p
                                            JOIN Tbl_Estado_Plan_Produccion e ON p.Fk_Id_Estado_Plan_Produccion = e.Pk_Id_Estado_Plan_Produccion
                                            WHERE p.Pk_Id_Plan_Produccion = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaPlan, con);
                    cmd.Parameters.AddWithValue("", iCodigoPlan);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del plan " + ex.Message, ex);
            }
            return tabla;
        }


        public DataTable fun_ObtenerOrdenesRecibidas()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaPedidos = @"SELECT o.Pk_Id_Orden_Recibida AS NoOrdenRecibida,
                                                       o.Id_Externo_Logistica AS CodigoOrden
                                                FROM Tbl_Orden_Recibida o
                                                WHERE NOT EXISTS
                                                (
                                                    SELECT 1
                                                    FROM Tbl_Plan_Produccion p
                                                    WHERE p.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
                                                )";
                    OdbcCommand cmd = new OdbcCommand(sConsultaPedidos, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las órdenes recibidas " + ex.Message, ex);
            }

            return tabla;
        }
        public DataTable fun_EstadosPlan()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaEstadoPlan = @"SELECT e.Pk_Id_Estado_Plan_Produccion AS CodigoEstado, 
                                            e.Nombre_Estado_Plan_Produccion AS EstadoPlan
                                            FROM Tbl_Estado_Plan_Produccion e";
                    OdbcCommand cmd = new OdbcCommand(sConsultaEstadoPlan, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los estados: " + ex.Message, ex);
            }
            return tabla;
        }


        public DataTable fun_ObtenerOrdenesProduccion(int iCodigoPlan)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaFase = @"SELECT op.Pk_Id_Orden_Produccion AS NoOrden, m.Nombre_Material as Producto,
                                            op.Fecha_Inicio_Orden_Produccion AS FechaInicio, op.Fecha_Fin_Orden_Produccion AS FechaFin
                                            FROM Tbl_Orden_Produccion op
                                            JOIN Tbl_Materiales m ON op.Fk_Id_Material = m.Pk_Id_Materiales
                                            WHERE op.Fk_Id_Plan_Produccion = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaFase, con);
                    cmd.Parameters.AddWithValue("", iCodigoPlan);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las :ordenes de producción " + ex.Message, ex);
            }
            return tabla;
        }


        public DataTable fun_ObtenerFasesProducción(int iCodigoOrden)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaFase = @"SELECT f.Pk_Id_Fase_Producto AS CodigoFase, f.Nombre_Fase_Produccion AS Fase
                                            FROM Tbl_Orden_Produccion op
                                            JOIN Tbl_BOM b ON op.Fk_Id_Material = b.Fk_Id_Material
                                            JOIN Tbl_Fases_Produccion f ON f.Fk_Id_BOM = b.Pk_Id_BOM
                                            WHERE op.Pk_Id_Orden_Produccion = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaFase, con);
                    cmd.Parameters.AddWithValue("", iCodigoOrden);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las fases del producto: " + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerEmpleados()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaEmpleado = @"SELECT e.Pk_Id_Empleado AS CodigoEmpleado, 
                                            CONCAT(e.Cmp_Nombres_Empleado, ' ', e.Cmp_Apellidos_Empleado) AS Empleado
                                            FROM tbl_empleado e";
                    OdbcCommand cmd = new OdbcCommand(sConsultaEmpleado, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los empleados: " + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerEstados()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaEstado = @"SELECT e.Pk_Id_Estado_Fase AS CodigoEstado, 
                                            e.Nombre_Estado_Fase AS EstadoFase
                                            FROM Tbl_Estado_Fase_Produccion e";
                    OdbcCommand cmd = new OdbcCommand(sConsultaEstado, con);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los estados: " + ex.Message, ex);
            }
            return tabla;
        }

        public DataTable fun_ObtenerCronograma(int iCodigoOrden)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaCronograma = @"SELECT c.Pk_Id_Cronograma_Fase AS CodigoCronograma, f.Nombre_Fase_Produccion AS Fase,
                                            c.Fecha_Inicio_Fase as FechaInicio, c.Fecha_Fin_Fase as FechaFin, c.Horas_Hombres as Cantidad, 
                                            CONCAT(e.Cmp_Nombres_Empleado, ' ', e.Cmp_Apellidos_Empleado) AS Encargado, 
                                            es.Nombre_Estado_Fase as Estado
                                            FROM Tbl_Cronograma_Fases_Produccion c
                                            JOIN Tbl_Fases_Produccion f ON c.Fk_Id_Fase_Producto = f.Pk_Id_Fase_Producto
                                            JOIN tbl_empleado e ON c.Fk_Id_Encargado = e.Pk_Id_Empleado
                                            JOIN Tbl_Estado_Fase_Produccion es ON c.Fk_Id_Estado_Fase = es.Pk_Id_Estado_Fase
                                            WHERE c.Fk_Id_Orden_Produccion = ?";
                    OdbcCommand cmd = new OdbcCommand(sConsultaCronograma, con);
                    cmd.Parameters.AddWithValue("", iCodigoOrden);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cronograma: " + ex.Message, ex);
            }
            return tabla;
        }

        public void pro_GuardarCronograma(int iCodigoOrden, List<(int iCodigoFase, int iEmpleado, DateTime FechaInicio,
            DateTime FechaFin, int iCantidadPersonal, int iEstadoFase)> cronogramaFases)
        {
            using (OdbcConnection con = conexion.conexion())
            {
                using (OdbcTransaction transaccion = con.BeginTransaction())
                {
                    try
                    {
                        // Guardar nuevas fases
                        if (cronogramaFases != null && cronogramaFases.Count > 0)
                        {
                            string sIngresarCronograma = @"INSERT INTO Tbl_Cronograma_Fases_Produccion
                                                     (Fk_Id_Orden_Produccion, Fk_Id_Fase_Producto, Fecha_Inicio_Fase, Fecha_Fin_Fase,
                                                     Horas_Hombres, Fk_Id_Encargado, Fk_Id_Estado_Fase) 
                                                     VALUES (?, ?, ?, ?, ?, ?, ?)";

                            OdbcCommand cmdGuardar = new OdbcCommand(sIngresarCronograma, con, transaccion);

                            foreach (var fase in cronogramaFases)
                            {
                                cmdGuardar.Parameters.Clear();

                                cmdGuardar.Parameters.AddWithValue("", iCodigoOrden);
                                cmdGuardar.Parameters.AddWithValue("", fase.iCodigoFase);
                                cmdGuardar.Parameters.AddWithValue("", fase.FechaInicio);
                                cmdGuardar.Parameters.AddWithValue("", fase.FechaFin);
                                cmdGuardar.Parameters.AddWithValue("", fase.iCantidadPersonal);
                                cmdGuardar.Parameters.AddWithValue("", fase.iEmpleado);
                                cmdGuardar.Parameters.AddWithValue("", fase.iEstadoFase);

                                cmdGuardar.ExecuteNonQuery();
                            }
                        }
                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }

                }
            }
        }

        public void pro_ActualizarCronograma(int iCodigoCronograma, DateTime fechaInicio, DateTime fechaFin, int iCantidadPersonal, int iEncargado, int iEstado)
        {
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sActualizar = @"UPDATE Tbl_Cronograma_Fases_Produccion
                                   SET Fecha_Inicio_Fase = ?,
                                       Fecha_Fin_Fase = ?,
                                       Horas_Hombres = ?,
                                       Fk_Id_Encargado = ?,
                                       Fk_Id_Estado_Fase = ?
                                   WHERE Pk_Id_Cronograma_Fase = ?";

                    OdbcCommand cmd = new OdbcCommand(sActualizar, con);

                    cmd.Parameters.AddWithValue("", fechaInicio);
                    cmd.Parameters.AddWithValue("", fechaFin);
                    cmd.Parameters.AddWithValue("", iCantidadPersonal);
                    cmd.Parameters.AddWithValue("", iEncargado);
                    cmd.Parameters.AddWithValue("", iEstado);
                    cmd.Parameters.AddWithValue("", iCodigoCronograma);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cronograma: " + ex.Message);
            }
        }
    }
}
