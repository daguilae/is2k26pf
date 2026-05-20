using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Prod
{
    public class Cls_Sentencias_Merma
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // Cargar tipos de merma para el combo
        public DataTable ObtenerTiposMerma()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        Pk_Id_Tipo_Merma    AS IdTipo,
                        Nombre_Tipo_Merma   AS Nombre
                    FROM Tbl_Tipo_Merma
                    ORDER BY Nombre_Tipo_Merma";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        // Cargar materiales de la orden para el combo
        public DataTable ObtenerMaterialesPorOrden(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        m.Pk_Id_Materiales  AS IdMaterial,
                        m.Nombre_Material   AS Nombre
                    FROM Tbl_Orden_Produccion op
                    INNER JOIN Tbl_Plan_Produccion pp 
                        ON op.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
                    INNER JOIN Tbl_Explosion_Materiales em 
                        ON pp.Fk_Id_Orden_Recibida = em.Fk_Id_Orden_Recibida
                    INNER JOIN Tbl_Explosion_Materiales_Detalle emd 
                        ON em.Pk_Id_Explosion = emd.Fk_Id_Explosion
                    INNER JOIN Tbl_Materiales m 
                        ON emd.Fk_Id_Material = m.Pk_Id_Materiales
                    WHERE op.Pk_Id_Orden_Produccion = ?
                    ORDER BY m.Nombre_Material";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Obtener mermas registradas de la orden
        public DataTable ObtenerMermas(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT
                        me.Pk_Id_Merma                          AS Id,
                        m.Nombre_Material                       AS Material,
                        tm.Nombre_Tipo_Merma                    AS Tipo,
                        me.Cantidad_Merma                       AS Cantidad,
                        i.Costo_Unitario                        AS CostoUnitario,
                        (me.Cantidad_Merma * i.Costo_Unitario)  AS Subtotal,
                        me.Motivo_Merma                         AS Motivo,
                        me.Fecha                                AS Fecha
                    FROM Tbl_Merma me
                    INNER JOIN Tbl_Materiales m 
                        ON me.Fk_Id_Materiales = m.Pk_Id_Materiales
                    INNER JOIN Tbl_Tipo_Merma tm 
                        ON me.Fk_Tipo_Merma = tm.Pk_Id_Tipo_Merma
                    INNER JOIN Tbl_Inventario i 
                        ON me.Fk_Id_Materiales = i.Fk_Id_Material
                    WHERE me.Fk_Id_Orden_Produccion = ?
                    ORDER BY me.Fecha DESC";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Guardar una merma
        public bool GuardarMerma(int idOrden, int idMaterial, int idTipo,
                                  decimal cantidad, string motivo)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    string query = @"
                        INSERT INTO Tbl_Merma 
                            (Fk_Id_Orden_Produccion, Fk_Id_Materiales, 
                             Fk_Tipo_Merma, Cantidad_Merma, Motivo_Merma)
                        VALUES (?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", idOrden);
                    cmd.Parameters.AddWithValue("?", idMaterial);
                    cmd.Parameters.AddWithValue("?", idTipo);
                    cmd.Parameters.AddWithValue("?", cantidad);
                    cmd.Parameters.AddWithValue("?", motivo);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (GuardarMerma): " + ex.Message);
                    return false;
                }
            }
        }

        // Eliminar una merma
        public bool EliminarMerma(int idMerma)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand(
                        "DELETE FROM Tbl_Merma WHERE Pk_Id_Merma = ?", conn);
                    cmd.Parameters.AddWithValue("?", idMerma);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (EliminarMerma): " + ex.Message);
                    return false;
                }
            }
        }
    }
}
