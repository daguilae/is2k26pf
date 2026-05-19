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
                e.Nombre_Estado_Orden_Recibida AS Estado,
                CASE WHEN f.Pk_Id_Factura IS NOT NULL 
                     THEN 'Facturada' 
                     ELSE 'Pendiente' 
                END AS Estado_Factura
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e 
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            LEFT JOIN Tbl_Factura_Produccion f
                ON o.Pk_Id_Orden_Recibida = f.Fk_Id_Orden_Recibida";

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
                e.Nombre_Estado_Orden_Recibida AS Estado,
                CASE WHEN f.Pk_Id_Factura IS NOT NULL 
                     THEN 'Facturada' 
                     ELSE 'Pendiente' 
                END AS Estado_Factura
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e 
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            LEFT JOIN Tbl_Factura_Produccion f
                ON o.Pk_Id_Orden_Recibida = f.Fk_Id_Orden_Recibida
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

        // ------ KEVIN NATARENO - 0901-21-635, 30/04/2026 --------
        public bool GenerarFactura(int idOrdenRecibida)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            OdbcTransaction transaccion = conn.BeginTransaction();

            try
            {
                // 1. Obtener órdenes de producción
                OdbcCommand cmdOrdenes = new OdbcCommand(@"
            SELECT op.Pk_Id_Orden_Produccion
            FROM Tbl_Orden_Produccion op
            INNER JOIN Tbl_Plan_Produccion pp 
                ON op.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
            WHERE pp.Fk_Id_Orden_Recibida = ?", conn);

                cmdOrdenes.Transaction = transaccion;
                cmdOrdenes.Parameters.Add("?", OdbcType.Int).Value = idOrdenRecibida;

                OdbcDataAdapter da = new OdbcDataAdapter(cmdOrdenes);
                DataTable dtOrdenes = new DataTable();
                da.Fill(dtOrdenes);

                if (dtOrdenes.Rows.Count == 0)
                    throw new Exception("No hay órdenes de producción para esta orden recibida.");

                decimal totalFactura = 0;
                DataTable dtCostos = new DataTable();
                dtCostos.Columns.Add("IdOrden", typeof(int));
                dtCostos.Columns.Add("Materiales", typeof(decimal));
                dtCostos.Columns.Add("ManoObra", typeof(decimal));
                dtCostos.Columns.Add("Indirectos", typeof(decimal));
                dtCostos.Columns.Add("Mermas", typeof(decimal));
                dtCostos.Columns.Add("Fases", typeof(decimal));
                dtCostos.Columns.Add("Subtotal", typeof(decimal));

                // 2. Calcular costos
                foreach (DataRow orden in dtOrdenes.Rows)
                {
                    int idOrden = Convert.ToInt32(orden["Pk_Id_Orden_Produccion"]);

                    OdbcCommand cmdCostos = new OdbcCommand(@"
                SELECT
                    COALESCE((SELECT SUM(i.Costo_Unitario) FROM Tbl_Inventario i),0) AS CostoMateriales,
                    COALESCE((SELECT SUM(mo.Hora_Trabajada_Mano_Obra * mo.Costo_Hora_Mano_Obra)
                              FROM Tbl_Mano_Obra mo WHERE mo.Fk_Id_Orden_Produccion = ?),0) AS CostoManoObra,
                    COALESCE((SELECT SUM(ci.Monto_Costo_Indirecto_Produccion)
                              FROM Tbl_Costo_Indirecto_Produccion ci WHERE ci.Fk_Id_Orden_Produccion = ?),0) AS CostoIndirecto,
                    COALESCE((SELECT SUM(me.Cantidad_Merma)
                              FROM Tbl_Merma me WHERE me.Fk_Id_Orden_Produccion = ?),0) AS CostoMermas,
                    COALESCE((SELECT SUM(cf.Costo)
                              FROM Tbl_Costo_Fase cf),0) AS CostoFases", conn);

                    cmdCostos.Transaction = transaccion;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;

                    OdbcDataAdapter daCostos = new OdbcDataAdapter(cmdCostos);
                    DataTable dtCosto = new DataTable();
                    daCostos.Fill(dtCosto);

                    if (dtCosto.Rows.Count > 0)
                    {
                        DataRow r = dtCosto.Rows[0];

                        decimal mat = r["CostoMateriales"] != DBNull.Value ? Convert.ToDecimal(r["CostoMateriales"]) : 0;
                        decimal mo = r["CostoManoObra"] != DBNull.Value ? Convert.ToDecimal(r["CostoManoObra"]) : 0;
                        decimal ind = r["CostoIndirecto"] != DBNull.Value ? Convert.ToDecimal(r["CostoIndirecto"]) : 0;
                        decimal mer = r["CostoMermas"] != DBNull.Value ? Convert.ToDecimal(r["CostoMermas"]) : 0;
                        decimal fas = r["CostoFases"] != DBNull.Value ? Convert.ToDecimal(r["CostoFases"]) : 0;

                        decimal sub = mat + mo + ind + mer + fas;
                        totalFactura += sub;

                        dtCostos.Rows.Add(idOrden, mat, mo, ind, mer, fas, sub);
                    }
                }

                // 3. Insertar encabezado factura
                OdbcCommand cmdEncabezado = new OdbcCommand(
                    "INSERT INTO Tbl_Factura_Produccion (Fk_Id_Orden_Recibida, Total_Factura) VALUES (?, ?)",
                    conn);

                cmdEncabezado.Transaction = transaccion;
                cmdEncabezado.Parameters.Add("?", OdbcType.Int).Value = idOrdenRecibida;
                cmdEncabezado.Parameters.Add("?", OdbcType.Decimal).Value = totalFactura;
                cmdEncabezado.ExecuteNonQuery();

                // 4. Obtener ID de la factura (CORREGIDO)
                OdbcCommand cmdId = new OdbcCommand(
                    "SELECT MAX(Pk_Id_Factura) FROM Tbl_Factura_Produccion", conn);

                cmdId.Transaction = transaccion;

                object result = cmdId.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    throw new Exception("No se pudo obtener el ID de la factura.");

                int idFactura = Convert.ToInt32(result);

                // 5. Insertar detalle
                foreach (DataRow costo in dtCostos.Rows)
                {
                    OdbcCommand cmdDetalle = new OdbcCommand(@"
                INSERT INTO Tbl_Factura_Produccion_Detalle 
                (Fk_Id_Factura, Fk_Id_Orden_Produccion, Total_Materiales, 
                 Total_Mano_Obra, Total_Costos_Indirectos, Total_Mermas, Total_Fases, Subtotal)
                VALUES (?, ?, ?, ?, ?, ?, ?, ?)", conn);

                    cmdDetalle.Transaction = transaccion;
                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = idFactura;
                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = Convert.ToInt32(costo["IdOrden"]);
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = costo["Materiales"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = costo["ManoObra"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = costo["Indirectos"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = costo["Mermas"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = costo["Fases"];
                    cmdDetalle.Parameters.Add("?", OdbcType.Decimal).Value = costo["Subtotal"];

                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();

                
                throw new Exception("Error al generar factura: " + ex.Message);

                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool ExisteFactura(int idOrdenRecibida)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(
                    "SELECT COUNT(*) FROM Tbl_Factura_Produccion WHERE Fk_Id_Orden_Recibida = ?", conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idOrdenRecibida;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        // ------ KEVIN NATARENO - 0901-21-635, 30/04/2026 --------

        public bool CambiarEstadoOrden(int idOrden, int idEstado)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand(
                        "UPDATE Tbl_Orden_Recibida SET Fk_Id_Estado_Orden_Recibida = ? WHERE Pk_Id_Orden_Recibida = ?",
                        conn);
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idEstado;
                    cmd.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (CambiarEstadoOrden): " + ex.Message);
                    return false;
                }
            }
        }

    }
}
