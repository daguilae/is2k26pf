using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Verificacion
{
    public class Cls_Sentencias_Verificacion
    {
        private Cls_Conexion_Verificacion conexion = new Cls_Conexion_Verificacion();

        // Método para buscar boleta y retornar DataTable
        public DataTable BuscarBoleta(string numeroBoleta)
        {
            DataTable dt = new DataTable();
            OdbcConnection conn = conexion.conexion();

            try
            {
                string query = "SELECT id_boleta, numero_boleta, estado_boleta " +
                              "FROM Tbl_boletas WHERE numero_boleta = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@numero", numeroBoleta);

                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return dt;
        }
    }
}