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

        public DataTable ObtenerExplosiones()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                e.Pk_Id_Explosion                                AS No_Explosion,
                o.Id_Externo_Logistica                           AS No_Orden,
                DATE_FORMAT(e.Fecha_Explosion, '%Y-%m-%d %H:%i') AS Fecha_Explosion
            FROM Tbl_Explosion_Materiales e
            INNER JOIN Tbl_Orden_Recibida o
                ON e.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
            ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
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
                o.Id_Externo_Logistica                           AS No_Orden,
                DATE_FORMAT(e.Fecha_Explosion, '%Y-%m-%d %H:%i') AS Fecha_Explosion
            FROM Tbl_Explosion_Materiales e
            INNER JOIN Tbl_Orden_Recibida o
                ON e.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
            WHERE DATE(e.Fecha_Explosion) BETWEEN ? AND ?
            ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("?", fechaFin);
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
                e.Fk_Id_Orden_Recibida                         AS No_Orden,
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

        // Filtrar por nombre de orden
        public DataTable FiltrarPorNombre(string nombreOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                e.Pk_Id_Explosion                                AS No_Explosion,
                o.Id_Externo_Logistica                           AS No_Orden,
                DATE_FORMAT(e.Fecha_Explosion, '%Y-%m-%d %H:%i') AS Fecha_Explosion
            FROM Tbl_Explosion_Materiales e
            INNER JOIN Tbl_Orden_Recibida o
                ON e.Fk_Id_Orden_Recibida = o.Pk_Id_Orden_Recibida
            WHERE o.Id_Externo_Logistica LIKE ?
            ORDER BY e.Fecha_Explosion DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", "%" + nombreOrden + "%");
                da.Fill(dt);
            }
            return dt;
        }

        // Eliminar explosión
        public bool EliminarExplosion(int idExplosion)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();
                try
                {
                    OdbcCommand cmdDetalle = new OdbcCommand(
                        "DELETE FROM Tbl_Explosion_Materiales_Detalle WHERE Fk_Id_Explosion = ?", conn);
                    cmdDetalle.Transaction = trans;
                    cmdDetalle.Parameters.Add("?", OdbcType.Int).Value = idExplosion;
                    cmdDetalle.ExecuteNonQuery();

                    OdbcCommand cmdCabecera = new OdbcCommand(
                        "DELETE FROM Tbl_Explosion_Materiales WHERE Pk_Id_Explosion = ?", conn);
                    cmdCabecera.Transaction = trans;
                    cmdCabecera.Parameters.Add("?", OdbcType.Int).Value = idExplosion;
                    cmdCabecera.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    Console.WriteLine("Error eliminando: " + ex.Message);
                    return false;
                }
            }
        }


        //DANIELA SALGUERO

        // Obtiene el detalle de explosión de una orden
        public DataTable ObtenerDetalleExplosion(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                emd.Fk_Id_Material                  AS Id_Material,
                m.Nombre_Material                   AS Material,
                emd.Cantidad_Real_Con_Merma         AS Cantidad_Requerida,
                COALESCE(SUM(inv.Cantidad_Disponible), 0) AS Stock_Actual,
                (emd.Cantidad_Real_Con_Merma - COALESCE(SUM(inv.Cantidad_Disponible), 0)) 
                                                    AS Faltante
            FROM Tbl_Explosion_Materiales em
            INNER JOIN Tbl_Explosion_Materiales_Detalle emd 
                    ON em.Pk_Id_Explosion = emd.Fk_Id_Explosion
            INNER JOIN Tbl_Materiales m 
                    ON emd.Fk_Id_Material = m.Pk_Id_Materiales
            LEFT JOIN Tbl_Inventario inv 
                    ON emd.Fk_Id_Material = inv.Fk_Id_Material
            WHERE em.Fk_Id_Orden_Recibida = ?
            GROUP BY emd.Fk_Id_Material, m.Nombre_Material, emd.Cantidad_Real_Con_Merma
            ORDER BY m.Nombre_Material";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idOrden);
                da.Fill(dt);
            }
            return dt;
        }

        // Guarda encabezado + detalle de orden de material
        public bool GuardarOrdenMaterial(int idOrden, DataTable faltantes)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcTransaction tx = conn.BeginTransaction();
                try
                {
                    string qEncabezado = @"
                INSERT INTO Encabezado_Orden_Material 
                    (Fk_Id_Orden_Recibida, Fk_Id_Estado_Orden_Material, Fecha_Solicitud)
                VALUES (?, 2, NOW())";

                    OdbcCommand cmdEnc = new OdbcCommand(qEncabezado, conn, tx);
                    cmdEnc.Parameters.AddWithValue("?", idOrden);
                    cmdEnc.ExecuteNonQuery();

                    OdbcCommand cmdId = new OdbcCommand(
                        "SELECT LAST_INSERT_ID()", conn, tx);
                    int idOrdenMaterial = Convert.ToInt32(cmdId.ExecuteScalar());

                    string qDetalle = @"
                INSERT INTO Detalle_Orden_Material 
                    (Fk_Id_Orden_Material, Fk_Id_Materiales, Cantidad_Solicitada)
                VALUES (?, ?, ?)";

                    foreach (DataRow row in faltantes.Rows)
                    {
                        decimal faltante = Convert.ToDecimal(row["Faltante"]);
                        if (faltante <= 0) continue;

                        OdbcCommand cmdDet = new OdbcCommand(qDetalle, conn, tx);
                        cmdDet.Parameters.AddWithValue("?", idOrdenMaterial);
                        cmdDet.Parameters.AddWithValue("?", Convert.ToInt32(row["Id_Material"]));
                        cmdDet.Parameters.AddWithValue("?", faltante);
                        cmdDet.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    return false;
                }
            }
        }

        public bool OrdenYaGenerada(int idOrden)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT COUNT(*) 
            FROM Encabezado_Orden_Material 
            WHERE Fk_Id_Orden_Recibida = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        //DANIELA SALGUERO

        // Arón Ricardo Esquit Silva 0901-22-13036 11/05/2026
        public int GuardarOrdenMaterialApi(int idOrden, DataTable faltantes)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcTransaction tx = conn.BeginTransaction();
                try
                {
                    string qEncabezado = @"
                INSERT INTO Encabezado_Orden_Material 
                    (Fk_Id_Orden_Recibida, Fk_Id_Estado_Orden_Material, Fecha_Solicitud)
                VALUES (?, 2, NOW())";

                    OdbcCommand cmdEnc = new OdbcCommand(qEncabezado, conn, tx);
                    cmdEnc.Parameters.AddWithValue("?", idOrden);
                    cmdEnc.ExecuteNonQuery();

                    OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID()", conn, tx);
                    int idOrdenMaterial = Convert.ToInt32(cmdId.ExecuteScalar());

                    string qDetalle = @"
                INSERT INTO Detalle_Orden_Material 
                    (Fk_Id_Orden_Material, Fk_Id_Materiales, Cantidad_Solicitada)
                VALUES (?, ?, ?)";

                    foreach (DataRow row in faltantes.Rows)
                    {
                        decimal faltante = Convert.ToDecimal(row["Faltante"]);
                        if (faltante <= 0) continue;

                        OdbcCommand cmdDet = new OdbcCommand(qDetalle, conn, tx);
                        cmdDet.Parameters.AddWithValue("?", idOrdenMaterial);
                        cmdDet.Parameters.AddWithValue("?", Convert.ToInt32(row["Id_Material"]));
                        cmdDet.Parameters.AddWithValue("?", faltante);
                        cmdDet.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return idOrdenMaterial;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }

        public bool ActualizarEstadoOrdenMaterialEnviado(int idOrdenMaterial)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            UPDATE Encabezado_Orden_Material 
            SET Fk_Id_Estado_Orden_Material = 1
            WHERE Pk_Id_Orden_Material = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrdenMaterial);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }



    }
}
