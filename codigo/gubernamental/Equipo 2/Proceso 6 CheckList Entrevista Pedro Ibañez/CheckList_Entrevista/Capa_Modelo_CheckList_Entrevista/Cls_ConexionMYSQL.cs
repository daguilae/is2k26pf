using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_CheckList_Entrevista
{
    public class Cls_ConexionMYSQL
    {
        private readonly string ConexionODBC = "Dsn=bd_migracion"; // DSN de odbc

        //retorna conexion cerrada para que el DAO la abra y cierre cuando sea necesario
        public OdbcConnection conexion()
        {
            return new OdbcConnection(ConexionODBC); // crea una nueva conexión
        }

        // Cierra la conexión si está abierta
        public void desconexion(OdbcConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }


    }
}
