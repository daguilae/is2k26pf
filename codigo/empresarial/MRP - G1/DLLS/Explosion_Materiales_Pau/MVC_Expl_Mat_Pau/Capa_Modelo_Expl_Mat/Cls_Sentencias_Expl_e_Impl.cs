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
                string query = @"
                    SELECT 
                        e.Pk_Id_Explosion,
                        op.Pk_Id_Orden_Produccion       AS Orden,
                        m.Nombre_Material                AS Producto,
                        e.Fecha_Explosion,
                        CASE WHEN e.Es_Factible = 1 
                             THEN 'Factible' 
                             ELSE 'No Factible' END      AS Factibilidad
                    FROM Tbl_Explosion_Materiales e
                    INNER JOIN Tbl_Orden_Produccion op 
                        ON e.Fk_Id_Orden_Produccion = op.Pk_Id_Orden_Produccion
                    INNER JOIN Tbl_Materiales m 
                        ON op.Fk_Id_Material = m.Pk_Id_Materiales
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
                        e.Pk_Id_Explosion,
                        op.Pk_Id_Orden_Produccion       AS Orden,
                        m.Nombre_Material                AS Producto,
                        e.Fecha_Explosion,
                        CASE WHEN e.Es_Factible = 1 
                             THEN 'Factible' 
                             ELSE 'No Factible' END      AS Factibilidad
                    FROM Tbl_Explosion_Materiales e
                    INNER JOIN Tbl_Orden_Produccion op 
                        ON e.Fk_Id_Orden_Produccion = op.Pk_Id_Orden_Produccion
                    INNER JOIN Tbl_Materiales m 
                        ON op.Fk_Id_Material = m.Pk_Id_Materiales
                    WHERE CAST(e.Pk_Id_Explosion AS CHAR) LIKE ?
                    ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", "%" + idExplosion + "%");
                da.Fill(dt);
            }
            return dt;
        }

        // Filtrar por rango de fechas
        public DataTable FiltrarPorFechas(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        e.Pk_Id_Explosion,
                        op.Pk_Id_Orden_Produccion       AS Orden,
                        m.Nombre_Material                AS Producto,
                        e.Fecha_Explosion,
                        CASE WHEN e.Es_Factible = 1 
                             THEN 'Factible' 
                             ELSE 'No Factible' END      AS Factibilidad
                    FROM Tbl_Explosion_Materiales e
                    INNER JOIN Tbl_Orden_Produccion op 
                        ON e.Fk_Id_Orden_Produccion = op.Pk_Id_Orden_Produccion
                    INNER JOIN Tbl_Materiales m 
                        ON op.Fk_Id_Material = m.Pk_Id_Materiales
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