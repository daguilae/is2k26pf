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

        // ------ KEVIN NATARENO - 0901-21-635, 30/04/2026 --------
        public bool GenerarFactura(int idOrdenRecibida)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            OdbcTransaction transaccion = conn.BeginTransaction();
            try
            {
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

                foreach (DataRow orden in dtOrdenes.Rows)
                {
                    int idOrden = Convert.ToInt32(orden["Pk_Id_Orden_Produccion"]);

                    OdbcCommand cmdCostos = new OdbcCommand(@"
                SELECT
                    COALESCE((
                        SELECT SUM(sub.monto)
                        FROM (
                            SELECT emd.Cantidad_Real_Con_Merma * i.Costo_Unitario AS monto
                            FROM Tbl_Orden_Produccion op
                            INNER JOIN Tbl_Plan_Produccion pp 
                                ON op.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
                            INNER JOIN Tbl_Explosion_Materiales em 
                                ON em.Pk_Id_Explosion = (
                                    SELECT MAX(Pk_Id_Explosion) 
                                    FROM Tbl_Explosion_Materiales 
                                    WHERE Fk_Id_Orden_Recibida = pp.Fk_Id_Orden_Recibida)
                            INNER JOIN Tbl_Explosion_Materiales_Detalle emd 
                                ON em.Pk_Id_Explosion = emd.Fk_Id_Explosion
                            INNER JOIN Tbl_BOM b 
                                ON b.Fk_Id_Material = op.Fk_Id_Material
                            INNER JOIN Tbl_BOM_Detalle bd 
                                ON bd.Fk_Id_BOM = b.Pk_Id_BOM 
                                AND bd.Fk_Id_Materiales = emd.Fk_Id_Material
                            INNER JOIN Tbl_Inventario i 
                                ON emd.Fk_Id_Material = i.Fk_Id_Material
                            WHERE op.Pk_Id_Orden_Produccion = ?
                            GROUP BY emd.Fk_Id_Material, i.Costo_Unitario
                        ) sub
                    ), 0) AS CostoMateriales,

                    COALESCE((
                        SELECT SUM(mo.Hora_Trabajada_Mano_Obra * mo.Costo_Hora_Mano_Obra)
                        FROM Tbl_Mano_Obra mo
                        WHERE mo.Fk_Id_Orden_Produccion = ?
                    ), 0) AS CostoManoObra,

                    COALESCE((
                        SELECT SUM(ci.Monto_Costo_Indirecto_Produccion)
                        FROM Tbl_Costo_Indirecto_Produccion ci
                        WHERE ci.Fk_Id_Orden_Produccion = ?
                    ), 0) AS CostoIndirecto,

                    COALESCE((
                        SELECT SUM(me.Cantidad_Merma * i.Costo_Unitario)
                        FROM Tbl_Merma me
                        INNER JOIN Tbl_Inventario i ON me.Fk_Id_Materiales = i.Fk_Id_Material
                        WHERE me.Fk_Id_Orden_Produccion = ?
                    ), 0) AS CostoMermas,

                    COALESCE((
                        SELECT SUM(cf.Costo)
                        FROM Tbl_Orden_Produccion op2
                        INNER JOIN Tbl_Plan_Produccion pp 
                            ON op2.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
                        INNER JOIN Tbl_Orden_Recibida_Detalle ord
                            ON pp.Fk_Id_Orden_Recibida = ord.Fk_Id_Orden_Recibida
                        INNER JOIN Tbl_BOM b ON b.Fk_Id_Material = ord.Fk_Id_Material
                        INNER JOIN Tbl_Fases_Produccion fp ON fp.Fk_Id_BOM = b.Pk_Id_BOM
                        INNER JOIN Tbl_Costo_Fase cf ON cf.Fk_Id_Fase_Producto = fp.Pk_Id_Fase_Producto
                        WHERE op2.Pk_Id_Orden_Produccion = ?
                    ), 0) AS CostoFases", conn);

                    cmdCostos.Transaction = transaccion;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                    cmdCostos.Parameters.Add("?", OdbcType.Int).Value = idOrden;

                    OdbcDataAdapter daCostos = new OdbcDataAdapter(cmdCostos);
                    DataTable dtCosto = new DataTable();
                    daCostos.Fill(dtCosto);

                    if (dtCosto.Rows.Count > 0)
                    {
                        DataRow r = dtCosto.Rows[0];
                        decimal mat = Convert.ToDecimal(r["CostoMateriales"]);
                        decimal mo = Convert.ToDecimal(r["CostoManoObra"]);
                        decimal ind = Convert.ToDecimal(r["CostoIndirecto"]);
                        decimal mer = Convert.ToDecimal(r["CostoMermas"]);
                        decimal fas = Convert.ToDecimal(r["CostoFases"]);
                        decimal sub = mat + mo + ind + mer + fas;
                        totalFactura += sub;

                        dtCostos.Rows.Add(idOrden, mat, mo, ind, mer, fas, sub);
                    }
                }

                // Insertar encabezado
                OdbcCommand cmdEncabezado = new OdbcCommand(
                    "INSERT INTO Tbl_Factura_Produccion (Fk_Id_Orden_Recibida, Total_Factura) VALUES (?, ?)",
                    conn);
                cmdEncabezado.Transaction = transaccion;
                cmdEncabezado.Parameters.Add("?", OdbcType.Int).Value = idOrdenRecibida;
                cmdEncabezado.Parameters.Add("?", OdbcType.Double).Value = totalFactura;
                cmdEncabezado.ExecuteNonQuery();

                OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn);
                cmdId.Transaction = transaccion;
                int idFactura = Convert.ToInt32(cmdId.ExecuteScalar());

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
                    cmdDetalle.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDecimal(costo["Materiales"]);
                    cmdDetalle.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDecimal(costo["ManoObra"]);
                    cmdDetalle.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDecimal(costo["Indirectos"]);
                    cmdDetalle.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDecimal(costo["Mermas"]);
                    cmdDetalle.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDecimal(costo["Fases"]);
                    cmdDetalle.Parameters.Add("?", OdbcType.Double).Value = Convert.ToDecimal(costo["Subtotal"]);
                    cmdDetalle.ExecuteNonQuery();
                }

                transaccion.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine("Error (GenerarFactura): " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        // ------ KEVIN NATARENO - 0901-21-635, 30/04/2026 --------


    }
}
