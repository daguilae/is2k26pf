using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

// Paula Daniela Leonardo Paredes - 0901-22-9580
namespace Capa_Modelo_Factura
{
    public class Cls_Sentencias_Encabezado
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // Obtener todas las facturas
        public DataTable ObtenerFacturas()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        f.Pk_Id_Factura                                  AS No_Factura,
                        f.Fk_Id_Orden_Recibida                           AS ID_Orden,
                        o.Id_Externo_Logistica                           AS Nombre_Orden,
                        DATE_FORMAT(f.Fecha_Factura, '%Y-%m-%d %H:%i')  AS Fecha_Emision,
                        f.Total_Factura                                  AS Total
                    FROM Tbl_Factura_Produccion f
                    INNER JOIN Tbl_Orden_Recibida o
                        ON f.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
                    ORDER BY f.Fecha_Factura DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Filtrar por No. de Factura
        public DataTable FiltrarPorNumero(string noFactura)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        f.Pk_Id_Factura                                  AS No_Factura,
                        f.Fk_Id_Orden_Recibida                           AS ID_Orden,
                        o.Id_Externo_Logistica                           AS Nombre_Orden,
                        DATE_FORMAT(f.Fecha_Factura, '%Y-%m-%d %H:%i')  AS Fecha_Emision,
                        f.Total_Factura                                  AS Total
                    FROM Tbl_Factura_Produccion f
                    INNER JOIN Tbl_Orden_Recibida o
                        ON f.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
                    WHERE CAST(f.Pk_Id_Factura AS CHAR) LIKE ?
                    ORDER BY f.Fecha_Factura DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", "%" + noFactura + "%");
                da.Fill(dt);
            }
            return dt;
        }

        // Filtrar por fecha de emisión
        public DataTable FiltrarPorFecha(string fecha)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        f.Pk_Id_Factura                                  AS No_Factura,
                        f.Fk_Id_Orden_Recibida                           AS ID_Orden,
                        o.Id_Externo_Logistica                           AS Nombre_Orden,
                        DATE_FORMAT(f.Fecha_Factura, '%Y-%m-%d %H:%i')  AS Fecha_Emision,
                        f.Total_Factura                                  AS Total
                    FROM Tbl_Factura_Produccion f
                    INNER JOIN Tbl_Orden_Recibida o
                        ON f.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
                    WHERE DATE(f.Fecha_Factura) = ?
                    ORDER BY f.Fecha_Factura DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", fecha);
                da.Fill(dt);
            }
            return dt;
        }

        // Filtrar por ID orden recibida
        public DataTable FiltrarPorOrden(string idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        f.Pk_Id_Factura                                  AS No_Factura,
                        f.Fk_Id_Orden_Recibida                           AS ID_Orden,
                        o.Id_Externo_Logistica                           AS Nombre_Orden,
                        DATE_FORMAT(f.Fecha_Factura, '%Y-%m-%d %H:%i')  AS Fecha_Emision,
                        f.Total_Factura                                  AS Total
                    FROM Tbl_Factura_Produccion f
                    INNER JOIN Tbl_Orden_Recibida o
                        ON f.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
                    WHERE o.Id_Externo_Logistica LIKE ?
                    ORDER BY f.Fecha_Factura DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", "%" + idOrden + "%");
                da.Fill(dt);
            }
            return dt;
        }

        // Obtener combo de órdenes recibidas
        public DataTable ObtenerOrdenesRecibidas()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        Pk_Id_Orden_Recibida,
                        Id_Externo_Logistica AS Nombre_Orden
                    FROM Tbl_Orden_Recibida
                    ORDER BY Id_Externo_Logistica";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}