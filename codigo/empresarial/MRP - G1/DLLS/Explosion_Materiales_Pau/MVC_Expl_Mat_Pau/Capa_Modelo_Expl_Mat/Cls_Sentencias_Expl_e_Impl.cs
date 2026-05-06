using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

// Paula Daniela Leonardo Paredes - 0901-22-9580 - [fecha]
namespace Capa_Modelo_Expl_Mat
{
    public class Cls_Sentencias_Expl_e_Impl
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // Obtener todas las explosiones para el grid del encabezado
        public DataTable ObtenerExplosiones()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                // El SELECT queda así en los 3 métodos:
                string query = @"
            SELECT 
                e.Pk_Id_Explosion                                AS No_Explosion,
                e.Fk_Id_Orden_Produccion                         AS No_Orden,
                DATE_FORMAT(e.Fecha_Explosion, '%Y-%m-%d %H:%i') AS Fecha_Explosion
                FROM Tbl_Explosion_Materiales e
                ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Filtrar por ID de explosión
        public DataTable FiltrarPorId(string idExplosion)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                e.Pk_Id_Explosion                                AS No_Explosion,
                e.Fk_Id_Orden_Produccion                         AS No_Orden,
                DATE_FORMAT(e.Fecha_Explosion, '%Y-%m-%d %H:%i') AS Fecha_Explosion
            FROM Tbl_Explosion_Materiales e
            WHERE CAST(e.Pk_Id_Explosion AS CHAR) LIKE ?
            ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", "%" + idExplosion + "%");
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable FiltrarPorFechas(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                e.Pk_Id_Explosion                                AS No_Explosion,
                e.Fk_Id_Orden_Produccion                         AS No_Orden,
                DATE_FORMAT(e.Fecha_Explosion, '%Y-%m-%d %H:%i') AS Fecha_Explosion
            FROM Tbl_Explosion_Materiales e
            WHERE DATE(e.Fecha_Explosion) BETWEEN ? AND ?
            ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("?", fechaFin);
                da.Fill(dt);
            }
            return dt;
        }
    }
}