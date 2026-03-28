using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Asignacion
{
    public class Cls_Sentencias_Asignacion
    {
        public Cls_Datos_Empleado fun_ObtenerEmpleado(int idUsuario)
        {
            Cls_Conexion conexion = new Cls_Conexion();
            Cls_Datos_Empleado Empleado = null; 
            try
            {
                using (OdbcConnection con = conexion.conexion())
                {
                    string sConsultaEmpleado = @"SELECT e.Pk_Id_Empleado AS Codigo, 
                                                e.Cmp_Nombres_Empleado AS Nombres, 
                                                e.Cmp_Apellidos_Empleado AS Apellidos 
                                                FROM Tbl_Usuario u 
                                                JOIN Tbl_Empleado e ON u.Fk_Id_Empleado = e.Pk_Id_Empleado
                                                WHERE u.Pk_Id_Usuario = ?";

                    OdbcCommand cmd = new OdbcCommand(sConsultaEmpleado, con);
                    cmd.Parameters.AddWithValue("", idUsuario);

                    using (OdbcDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Empleado = new Cls_Datos_Empleado()
                            {
                                iIdEmpleado = Convert.ToInt32(reader["Codigo"]),
                                sNombres = reader["Nombres"].ToString(),
                                sApellidos = reader["Apellidos"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el empleado: " + ex.Message, ex);
            }
            return Empleado;
        }
    }
}
