using System;
using System.Data.Odbc;

namespace Capa_Modelo_CXP
{
    public class Cls_Conexion
    {
        public string ObtenerCadenaConexion()
        {
            return "Dsn=bd_SIG";
        }

        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection(ObtenerCadenaConexion());

            try
            {
                conn.Open();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No conectó: " + ex.Message);
            }

            return conn;
        }

        public OdbcConnection AbrirConexion()
        {
            OdbcConnection conn = new OdbcConnection(ObtenerCadenaConexion());
            conn.Open();
            return conn;
        }

        public void desconexion(OdbcConnection conn)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No se pudo cerrar la conexión: " + ex.Message);
            }
        }
    }
}