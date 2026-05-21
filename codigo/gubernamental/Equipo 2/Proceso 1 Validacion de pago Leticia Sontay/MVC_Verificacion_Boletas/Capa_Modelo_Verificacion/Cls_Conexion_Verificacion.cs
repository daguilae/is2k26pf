using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Verificacion
{
    class Cls_Conexion_Verificacion
    {
        // Método para abrir conexión vía ODBC
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=Bd_boletas;");
            try
            {
                conn.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("No conectó: " + ex.Message);
            }
            return conn;
        }

        // Método para cerrar conexión
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al cerrar conexión: " + ex.Message);
            }
        }
    }
}
