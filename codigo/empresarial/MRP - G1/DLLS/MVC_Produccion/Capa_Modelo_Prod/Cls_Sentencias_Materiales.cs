using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Prod
{
    public class Cls_Sentencias_Materiales
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();
        public DataTable ObtenerMaterialesConsumidos(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                        SELECT 
                m.Pk_Id_Materiales              AS Id_Material,
                m.Nombre_Material               AS Material,
                u.Abreviatura_Unidad_Medida     AS Unidad,
                SUM(emd.Cantidad_Total)         AS Cantidad_Necesaria,
                SUM(emd.Cantidad_Real_Con_Merma) AS Cantidad_Con_Merma,
                i.Costo_Unitario                AS Costo_Unitario,
                SUM(emd.Cantidad_Real_Con_Merma * i.Costo_Unitario) AS Subtotal
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
            INNER JOIN Tbl_Materiales m 
                ON emd.Fk_Id_Material = m.Pk_Id_Materiales
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            INNER JOIN Tbl_Inventario i
                ON emd.Fk_Id_Material = i.Fk_Id_Material
            WHERE op.Pk_Id_Orden_Produccion = ?
            GROUP BY m.Pk_Id_Materiales, m.Nombre_Material, u.Abreviatura_Unidad_Medida, i.Costo_Unitario
            ORDER BY m.Nombre_Material";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue(" ? ", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool DescontarMateriales(int idOrden)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Primero verificamos que haya stock suficiente
                    string queryVerificar = @"
                SELECT 
                    m.Nombre_Material,
                    i.Cantidad_Disponible,
                    emd.Cantidad_Real_Con_Merma
                FROM Tbl_Orden_Produccion op
                INNER JOIN Tbl_Plan_Produccion pp 
                    ON op.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
                INNER JOIN Tbl_Explosion_Materiales em 
                    ON pp.Fk_Id_Orden_Recibida = em.Fk_Id_Orden_Recibida
                INNER JOIN Tbl_Explosion_Materiales_Detalle emd 
                    ON em.Pk_Id_Explosion = emd.Fk_Id_Explosion
                INNER JOIN Tbl_Materiales m 
                    ON emd.Fk_Id_Material = m.Pk_Id_Materiales
                INNER JOIN Tbl_Inventario i
                    ON emd.Fk_Id_Material = i.Fk_Id_Material
                WHERE op.Pk_Id_Orden_Produccion = ?";

                    OdbcCommand cmdVerificar = new OdbcCommand(queryVerificar, conn, transaction);
                    cmdVerificar.Parameters.AddWithValue("?", idOrden);

                    OdbcDataAdapter da = new OdbcDataAdapter(cmdVerificar);
                    DataTable dtVerificar = new DataTable();
                    da.Fill(dtVerificar);

                    // Revisamos si algún material no tiene stock suficiente
                    foreach (DataRow row in dtVerificar.Rows)
                    {
                        decimal disponible = Convert.ToDecimal(row["Cantidad_Disponible"]);
                        decimal necesaria = Convert.ToDecimal(row["Cantidad_Real_Con_Merma"]);
                        string nombre = row["Nombre_Material"].ToString();

                        if (disponible < necesaria)
                            throw new Exception($"Stock insuficiente para: {nombre}\n" +
                                                $"Disponible: {disponible}  |  Necesario: {necesaria}");
                    }

                    // Todo OK → descontamos
                    string queryDescontar = @"
                UPDATE Tbl_Inventario i
                INNER JOIN Tbl_Explosion_Materiales_Detalle emd
                    ON i.Fk_Id_Material = emd.Fk_Id_Material
                INNER JOIN Tbl_Explosion_Materiales em
                    ON emd.Fk_Id_Explosion = em.Pk_Id_Explosion
                INNER JOIN Tbl_Plan_Produccion pp
                    ON em.Fk_Id_Orden_Recibida = pp.Fk_Id_Orden_Recibida
                INNER JOIN Tbl_Orden_Produccion op
                    ON pp.Pk_Id_Plan_Produccion = op.Fk_Id_Plan_Produccion
                SET i.Cantidad_Disponible = i.Cantidad_Disponible - emd.Cantidad_Real_Con_Merma
                WHERE op.Pk_Id_Orden_Produccion = ?";

                    OdbcCommand cmdDescontar = new OdbcCommand(queryDescontar, conn, transaction);
                    cmdDescontar.Parameters.AddWithValue("?", idOrden);
                    cmdDescontar.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message); // lo relanzamos para mostrarlo en la vista
                }
            }
        }
    }
}
