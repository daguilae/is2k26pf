using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

// Paula Daniela Leonardo Paredes - 0901-22-9580 - [fecha]
namespace Capa_Modelo_Expl_Mat
{
    public class Cls_Sentencias_Expl
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // Cargar combo de órdenes de producción
        public DataTable ObtenerOrdenesProduccion()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        op.Pk_Id_Orden_Produccion,
                        CONCAT('OP-', op.Pk_Id_Orden_Produccion, ' | ', m.Nombre_Material) AS Descripcion
                    FROM Tbl_Orden_Produccion op
                    INNER JOIN Tbl_Materiales m 
                        ON op.Fk_Id_Material = m.Pk_Id_Materiales
                    INNER JOIN Tbl_Estado_Orden_Produccion ep
                        ON op.Fk_Id_Estado_Orden_Produccion = ep.Pk_Id_Estado_Orden_Produccion
                    ORDER BY op.Pk_Id_Orden_Produccion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Información de la orden seleccionada (para los labels)
        public DataTable ObtenerInfoOrden(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        op.Pk_Id_Orden_Produccion                       AS No_Orden,
                        pp.Descripcion_Plan_Produccion                  AS Plan,
                        eo.Nombre_Estado_Orden_Produccion               AS Estado,
                        op.Fecha_Inicio_Orden_Produccion                AS Fecha_Inicio,
                        op.Fecha_Fin_Orden_Produccion                   AS Fecha_Fin,
                        orec.Fecha_Requerida                            AS Fecha_Requerida,
                        m.Lead_Time_Produccion_Dias                     AS Lead_Time
                    FROM Tbl_Orden_Produccion op
                    INNER JOIN Tbl_Plan_Produccion pp 
                        ON op.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
                    INNER JOIN Tbl_Estado_Orden_Produccion eo 
                        ON op.Fk_Id_Estado_Orden_Produccion = eo.Pk_Id_Estado_Orden_Produccion
                    INNER JOIN Tbl_Orden_Recibida orec 
                        ON pp.Fk_Id_Orden_Recibida = orec.Pk_Id_Orden_Recibida
                    INNER JOIN Tbl_Materiales m 
                        ON op.Fk_Id_Material = m.Pk_Id_Materiales
                    WHERE op.Pk_Id_Orden_Produccion = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // Productos a fabricar de la orden (para Dgv_ProductosAFabricar)
        public DataTable ObtenerProductosOrden(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        m.Codigo_Material                               AS Codigo,
                        m.Nombre_Material                               AS Producto,
                        op.Cantidad_Programada_Orden_Produccion         AS Cantidad,
                        um.Abreviatura_Unidad_Medida                    AS Unidad,
                        m.Lead_Time_Produccion_Dias                     AS Lead_Time_Dias
                    FROM Tbl_Orden_Produccion op
                    INNER JOIN Tbl_Materiales m 
                        ON op.Fk_Id_Material = m.Pk_Id_Materiales
                    INNER JOIN Tbl_Unidad_Medida um 
                        ON m.Fk_Id_Unidad_Medida = um.Pk_Id_Unidad_Medida
                    WHERE op.Pk_Id_Orden_Produccion = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // BOM + inventario para hacer la explosión
        public DataTable ObtenerBOMParaExplosion(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        op.Pk_Id_Orden_Produccion,
                        mp.Nombre_Material                              AS Producto,
                        op.Cantidad_Programada_Orden_Produccion         AS Cantidad_Solicitada,
                        b.Pk_Id_BOM,
                        b.Version_BOM,
                        mh.Pk_Id_Materiales                            AS Id_Material,
                        mh.Codigo_Material                             AS Codigo_MP,
                        mh.Nombre_Material                             AS Material,
                        um.Abreviatura_Unidad_Medida                   AS Unidad,
                        bd.Cantidad_Requerida_BOM_Detalle               AS Cant_Por_Unidad,
                        bd.Porcentaje_Merma_BOM_Detalle                 AS Pct_Merma,
                        mh.Stock_Minimo                                AS Stock_Seguridad,
                        mh.Lote_Minimo_Compra,
                        IFNULL(SUM(inv.Cantidad_Disponible), 0)        AS Stock_Actual
                    FROM Tbl_Orden_Produccion op
                    INNER JOIN Tbl_Materiales mp 
                        ON op.Fk_Id_Material = mp.Pk_Id_Materiales
                    INNER JOIN Tbl_BOM b 
                        ON b.Fk_Id_Material = op.Fk_Id_Material
                    INNER JOIN Tbl_Estado_BOM eb 
                        ON b.Fk_Id_Estado_BOM = eb.Pk_Id_Estado_BOM
                       AND eb.Nombre_Estado_BOM = 'Activo'
                    INNER JOIN Tbl_BOM_Detalle bd 
                        ON bd.Fk_Id_BOM = b.Pk_Id_BOM
                    INNER JOIN Tbl_Materiales mh 
                        ON bd.Fk_Id_Materiales = mh.Pk_Id_Materiales
                    INNER JOIN Tbl_Unidad_Medida um 
                        ON bd.Fk_Id_Unidad_Medida = um.Pk_Id_Unidad_Medida
                    LEFT JOIN Tbl_Inventario inv 
                        ON inv.Fk_Id_Material = mh.Pk_Id_Materiales
                    WHERE op.Pk_Id_Orden_Produccion = ?
                    GROUP BY 
                        op.Pk_Id_Orden_Produccion, mp.Nombre_Material,
                        op.Cantidad_Programada_Orden_Produccion,
                        b.Pk_Id_BOM, b.Version_BOM,
                        mh.Pk_Id_Materiales, mh.Codigo_Material,
                        mh.Nombre_Material, um.Abreviatura_Unidad_Medida,
                        bd.Cantidad_Requerida_BOM_Detalle,
                        bd.Porcentaje_Merma_BOM_Detalle,
                        mh.Stock_Minimo, mh.Lote_Minimo_Compra";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // Guardar cabecera de la explosión
        // Guardar cabecera (sin Es_Factible)
        public int GuardarExplosion(int idOrden)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(
                    @"INSERT INTO Tbl_Explosion_Materiales 
              (Fk_Id_Orden_Produccion, Fecha_Explosion) 
              VALUES (?, NOW())", conn);

                cmd.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                cmd.ExecuteNonQuery();

                OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn);
                return Convert.ToInt32(cmdId.ExecuteScalar());
            }
        }

        // Guardar detalle (solo Cantidad_Total y Cantidad_Real_Con_Merma)
        public bool GuardarDetalleExplosion(int idExplosion, DataTable detalle)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();
                try
                {
                    foreach (DataRow fila in detalle.Rows)
                    {
                        OdbcCommand cmd = new OdbcCommand(
                            @"INSERT INTO Tbl_Explosion_Materiales_Detalle
                      (Fk_Id_Explosion, Fk_Id_Material, 
                       Cantidad_Total, Cantidad_Real_Con_Merma)
                      VALUES (?, ?, ?, ?)", conn);

                        cmd.Transaction = trans;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = idExplosion;
                        cmd.Parameters.Add("?", OdbcType.Int).Value = fila["Id_Material"];
                        cmd.Parameters.Add("?", OdbcType.Decimal).Value = fila["Cant_Total"];
                        cmd.Parameters.Add("?", OdbcType.Decimal).Value = fila["Cant_Real"];
                        cmd.ExecuteNonQuery();
                    }
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Console.WriteLine("Error guardando detalle: " + ex.Message);
                    return false;
                }
            }
        }
    }
}