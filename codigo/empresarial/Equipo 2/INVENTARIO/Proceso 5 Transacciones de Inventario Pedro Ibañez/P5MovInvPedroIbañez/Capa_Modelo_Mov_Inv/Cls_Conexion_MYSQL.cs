using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Mov_Inv
{
    public class Cls_Conexion_MYSQL
    {
        private readonly string ConexionODBC = "Dsn=bd_SIG"; // DSN de odbc

        //retorna conexion cerrada para que el DAO la abra y cierre cuando sea necesario
        public OdbcConnection oConexion()
        {
            return new OdbcConnection(ConexionODBC); // crea una nueva conexión
        }

        // Cierra la conexión si está abierta
        public void oDesconexion(OdbcConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
