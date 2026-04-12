using System;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Sentencias
    {
        private Cls_Conexion gObjConexion = new Cls_Conexion();

        public bool funInsertarSolicitante(
            string sDpi,
            string sNombre,
            string sApellido,
            string sSexo,
            string sDepartamento,
            string sEstadoCivil,
            DateTime dtFechaNacimiento,
            out string sMensaje)
        {
            sMensaje = "";

            if (!gObjConexion.funAbrirConexion(out sMensaje))
                return false;

            try
            {
                string sSql = @"INSERT INTO tbl_solicitante
                                (Cmp_DPI, Cmp_Nombre, Cmp_Apellido, 
                                 Cmp_Sexo, Cmp_Departamento, 
                                 Cmp_Estado_Civil, Cmp_Fecha_Nacimiento)
                                VALUES (?, ?, ?, ?, ?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(sSql, gObjConexion.funObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("p1", sDpi);
                    cmd.Parameters.AddWithValue("p2", sNombre);
                    cmd.Parameters.AddWithValue("p3", sApellido);
                    cmd.Parameters.AddWithValue("p4", sSexo);
                    cmd.Parameters.AddWithValue("p5", sDepartamento);
                    cmd.Parameters.AddWithValue("p6", sEstadoCivil);
                    cmd.Parameters.AddWithValue("p7", dtFechaNacimiento);

                    int iFilas = cmd.ExecuteNonQuery();

                    if (iFilas > 0)
                    {
                        sMensaje = "Datos guardados correctamente.";
                        return true;
                    }
                }

                sMensaje = "No se pudo insertar el registro.";
                return false;
            }
            catch (Exception ex)
            {
                sMensaje = "Error al insertar: " + ex.Message;
                return false;
            }
            finally
            {
                gObjConexion.funCerrarConexion(out _);
            }
        }
    }
}