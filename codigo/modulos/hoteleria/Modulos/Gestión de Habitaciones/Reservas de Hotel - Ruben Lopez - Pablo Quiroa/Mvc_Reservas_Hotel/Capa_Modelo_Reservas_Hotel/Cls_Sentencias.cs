using Capa_Modelo_Seguridad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

// ------ KEVIN NATARENO - 0901-21-635, 28/04/2026 --------
namespace Capa_Modelo_RO
{
    public class Cls_Sentencias
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable ObtenerOrdenes()
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        o.Pk_Id_Orden_Recibida,
                        o.Id_Externo_Logistica AS Orden,
                        o.Fecha_Recepcion,
                        o.Fecha_Requerida,
                        e.Nombre_Estado_Orden_Recibida AS Estado
                    FROM Tbl_Orden_Recibida o
                    INNER JOIN Tbl_Estado_Orden_Recibida e 
                        ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }

            return dt;
        }
        public DataTable ObtenerEstados()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT Pk_Id_Estado_Orden_Recibida, Nombre_Estado_Orden_Recibida
            FROM Tbl_Estado_Orden_Recibida";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable FiltrarOrdenes(string idExterno, int idEstado)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                o.Pk_Id_Orden_Recibida,
                o.Id_Externo_Logistica AS Orden,
                o.Fecha_Recepcion,
                o.Fecha_Requerida,
                e.Nombre_Estado_Orden_Recibida AS Estado
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e 
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            WHERE (o.Id_Externo_Logistica LIKE ? OR ? = '')
              AND (o.Fk_Id_Estado_Orden_Recibida = ? OR ? = 0)";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", "%" + idExterno + "%");
                da.SelectCommand.Parameters.AddWithValue("?", idExterno);
                da.SelectCommand.Parameters.AddWithValue("?", idEstado);
                da.SelectCommand.Parameters.AddWithValue("?", idEstado);
                da.Fill(dt);
            }
            return dt;
        }


        // Arón Ricardo Esquit - 0901-22-13036 - 01/05/26
        public DataTable FiltrarOrdenesPorFecha(string fechaInicio, string fechaFin)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                o.Pk_Id_Orden_Recibida,
                o.Id_Externo_Logistica AS Orden,
                DATE_FORMAT(o.Fecha_Recepcion, '%Y-%m-%d %H:%i:%s') AS Fecha_Recepcion,
                DATE_FORMAT(o.Fecha_Requerida, '%Y-%m-%d') AS Fecha_Requerida,
                e.Nombre_Estado_Orden_Recibida AS Estado
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e 
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            WHERE o.Fecha_Requerida BETWEEN ? AND ?
            ORDER BY o.Fecha_Requerida DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("?", fechaFin);
                da.Fill(dt);
            }
            return dt;
        }


        // ------ KEVIN NATARENO - 0901-21-635, 28/04/2026 --------



    }
}
