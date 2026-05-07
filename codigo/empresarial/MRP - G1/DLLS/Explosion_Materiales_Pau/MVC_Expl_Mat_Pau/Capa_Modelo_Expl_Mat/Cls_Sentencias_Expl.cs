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

        // Combo — carga órdenes RECIBIDAS
        public DataTable ObtenerOrdenesRecibidas()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                o.Pk_Id_Orden_Recibida,
                CONCAT(o.Id_Externo_Logistica, ' | ', 
                       DATE_FORMAT(o.Fecha_Requerida, '%Y-%m-%d')) AS Descripcion
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            ORDER BY o.Fecha_Recepcion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Info de la orden recibida (para Dgv_InformacionOrden)
        public DataTable ObtenerInfoOrdenRecibida(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                o.Id_Externo_Logistica          AS No_Orden,
                e.Nombre_Estado_Orden_Recibida  AS Estado,
                DATE_FORMAT(o.Fecha_Recepcion, '%Y-%m-%d')  AS Fecha_Recepcion,
                DATE_FORMAT(o.Fecha_Requerida, '%Y-%m-%d')  AS Fecha_Requerida,
                o.Observacion
            FROM Tbl_Orden_Recibida o
            INNER JOIN Tbl_Estado_Orden_Recibida e
                ON o.Fk_Id_Estado_Orden_Recibida = e.Pk_Id_Estado_Orden_Recibida
            WHERE o.Pk_Id_Orden_Recibida = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // Productos a fabricar (detalle de la orden recibida)
        public DataTable ObtenerProductosOrdenRecibida(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                m.Codigo_Material                   AS Codigo,
                m.Nombre_Material                   AS Producto,
                d.Cantidad_Solicitada               AS Cantidad,
                um.Abreviatura_Unidad_Medida        AS Unidad,
                m.Lead_Time_Produccion_Dias         AS Lead_Time_Dias
            FROM Tbl_Orden_Recibida_Detalle d
            INNER JOIN Tbl_Materiales m 
                ON d.Fk_Id_Material = m.Pk_Id_Materiales
            INNER JOIN Tbl_Unidad_Medida um 
                ON m.Fk_Id_Unidad_Medida = um.Pk_Id_Unidad_Medida
            WHERE d.Fk_Id_Orden_Recibida = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // BOM para explosión — parte del detalle de la orden recibida
        public DataTable ObtenerBOMParaExplosion(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                mp.Nombre_Material                              AS Producto,
                d.Cantidad_Solicitada                          AS Cantidad_Solicitada,
                mh.Pk_Id_Materiales                            AS Id_Material,
                mh.Codigo_Material                             AS Codigo_MP,
                mh.Nombre_Material                             AS Material,
                um.Abreviatura_Unidad_Medida                   AS Unidad,
                bd.Cantidad_Requerida_BOM_Detalle              AS Cant_Por_Unidad,
                bd.Porcentaje_Merma_BOM_Detalle                AS Pct_Merma
            FROM Tbl_Orden_Recibida_Detalle d
            INNER JOIN Tbl_Materiales mp 
                ON d.Fk_Id_Material = mp.Pk_Id_Materiales
            INNER JOIN Tbl_BOM b 
                ON b.Fk_Id_Material = d.Fk_Id_Material
            INNER JOIN Tbl_Estado_BOM eb 
                ON b.Fk_Id_Estado_BOM = eb.Pk_Id_Estado_BOM
               AND eb.Nombre_Estado_BOM = 'Activo'
            INNER JOIN Tbl_BOM_Detalle bd 
                ON bd.Fk_Id_BOM = b.Pk_Id_BOM
            INNER JOIN Tbl_Materiales mh 
                ON bd.Fk_Id_Materiales = mh.Pk_Id_Materiales
            INNER JOIN Tbl_Unidad_Medida um 
                ON bd.Fk_Id_Unidad_Medida = um.Pk_Id_Unidad_Medida
            WHERE d.Fk_Id_Orden_Recibida = ?";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // Guardar cabecera
        public int GuardarExplosion(int idOrdenRecibida)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(
                    @"INSERT INTO Tbl_Explosion_Materiales 
              (Fk_Id_Orden_Recibida, Fecha_Explosion) 
              VALUES (?, NOW())", conn);

                cmd.Parameters.Add("?", OdbcType.Int).Value = idOrdenRecibida;
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