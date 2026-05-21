using System;
using System.Data.Odbc;

namespace Capa_Modelo
{
    public class Cls_Conexion
    {
        private OdbcConnection conn;

        public OdbcConnection fun_AbrirConexion()
        {
            try
            {
                conn = new OdbcConnection("Dsn=bd_SIG;");
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error conexión: " + ex.Message);
            }

            return conn;
        }

        public void fun_CerrarConexion()
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error cerrar conexión: " + ex.Message);
            }
        }
    }
}