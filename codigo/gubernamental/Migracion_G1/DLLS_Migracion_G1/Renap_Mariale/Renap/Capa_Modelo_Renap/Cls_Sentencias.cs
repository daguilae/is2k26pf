using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


// EMPIEZA CODIGO HECHO POR: MARIA MORALES 0901-22-1226 EN LA FECHA DE: 04/03/2026
namespace Capa_Modelo_Renap
{
    public class Cls_Sentencias
    {
        Cls_Conexion cn = new Cls_Conexion();


        public OdbcDataAdapter llenarTbl(string tabla)
        {
            OdbcConnection conn = cn.AbrirConexion();

            string sql = "SELECT * FROM " + tabla;

            OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);

            return da;
        }


        public bool GuardarCiudadano(long dpi, string nombres, string apellidos,
                                      int sexo, string nacionalidad,
                                      string lugarNacimiento, DateTime fechaNacimiento)
        {
            try
            {
                OdbcConnection conn = cn.AbrirConexion();

                string sql = @"INSERT INTO Tbl_Ciudadano
                (Cmp_Dpi_Ciudadano,
                 Cmp_Nombres_Ciudadano,
                 Cmp_Apellidos_Ciudadano,
                 Cmp_Sexo_Ciudadano,
                 Cmp_Nacionalidad_Ciudadano,
                 Cmp_Lugar_Nacimiento_Ciudadano,
                 Cmp_Fecha_Nacimiento_Ciudadano)
                 VALUES (?,?,?,?,?,?,?)";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

               
                cmd.Parameters.AddWithValue("", dpi);
                cmd.Parameters.AddWithValue("", nombres);
                cmd.Parameters.AddWithValue("", apellidos);
                cmd.Parameters.AddWithValue("", sexo); // 1 o 0
                cmd.Parameters.AddWithValue("", nacionalidad);
                cmd.Parameters.AddWithValue("", lugarNacimiento);
                cmd.Parameters.AddWithValue("", fechaNacimiento);

                cmd.ExecuteNonQuery();

                cn.desconexion(conn);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool EliminarCiudadano(int idCiudadano)
        {
            try
            {
                OdbcConnection conn = cn.AbrirConexion();

                string sql = "DELETE FROM Tbl_Ciudadano WHERE Pk_Id_Ciudadano = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("", idCiudadano);

                cmd.ExecuteNonQuery();

                cn.desconexion(conn);

                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool ModificarCiudadano(int idCiudadano, long dpi, string nombres, string apellidos,
                                int sexo, string nacionalidad,
                                string lugarNacimiento, DateTime fechaNacimiento)
        {
            try
            {
                OdbcConnection conn = cn.AbrirConexion();

                string sql = @"UPDATE Tbl_Ciudadano SET
                        Cmp_Dpi_Ciudadano = ?,
                        Cmp_Nombres_Ciudadano = ?,
                        Cmp_Apellidos_Ciudadano = ?,
                        Cmp_Sexo_Ciudadano = ?,
                        Cmp_Nacionalidad_Ciudadano = ?,
                        Cmp_Lugar_Nacimiento_Ciudadano = ?,
                        Cmp_Fecha_Nacimiento_Ciudadano = ?
                       WHERE Pk_Id_Ciudadano = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("", dpi);
                cmd.Parameters.AddWithValue("", nombres);
                cmd.Parameters.AddWithValue("", apellidos);
                cmd.Parameters.AddWithValue("", sexo);
                cmd.Parameters.AddWithValue("", nacionalidad);
                cmd.Parameters.AddWithValue("", lugarNacimiento);
                cmd.Parameters.AddWithValue("", fechaNacimiento);
                cmd.Parameters.AddWithValue("", idCiudadano);

                cmd.ExecuteNonQuery();
                cn.desconexion(conn);

                return true;
            }
            catch
            {
                return false;
            }
        }




        public DataTable MostrarCiudadanos()
        {
            DataTable tabla = new DataTable();

            try
            {
                OdbcConnection conn = cn.AbrirConexion();

                string sql = "SELECT * FROM Tbl_Ciudadano";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);

                cn.desconexion(conn);
            }
            catch
            {
                return null;
            }

            return tabla;
        }


    }
}
// FINALIZA CODIGO HECHO POR: MARIA MORALES 0901-22-1226 EN LA FECHA DE: 04/03/2026