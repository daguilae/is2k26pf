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
    public class Cls_Sentencias_CI
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();
        public DataTable ObtenerCostosIndirectos(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                Pk_Id_Costo_Indirecto_Produccion        AS Id,
                Concepto_Costo_Indirecto_Produccion     AS Concepto,
                Monto_Costo_Indirecto_Produccion        AS Monto,
                Descripcion_Costo_Indirecto_Produccion  AS Descripcion
            FROM Tbl_Costo_Indirecto_Produccion
            WHERE Fk_Id_Orden_Produccion = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public bool GuardarCostoIndirecto(int idOrden, string concepto, decimal monto, string descripcion)
        {
            OdbcConnection conn = conexion.AbrirConexion();
            try
            {
                OdbcCommand cmd = new OdbcCommand(
                    "INSERT INTO Tbl_Costo_Indirecto_Produccion (Fk_Id_Orden_Produccion, Concepto_Costo_Indirecto_Produccion, Monto_Costo_Indirecto_Produccion, Descripcion_Costo_Indirecto_Produccion) VALUES (?, ?, ?, ?)",
                    conn);
                cmd.Parameters.Add("?", OdbcType.Int).Value = idOrden;
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = concepto;
                cmd.Parameters.Add("?", OdbcType.Double).Value = monto;
                cmd.Parameters.Add("?", OdbcType.VarChar).Value = descripcion ?? "";
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool EliminarCostoIndirecto(int idCosto)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                try
                {
                    OdbcCommand cmd = new OdbcCommand(
                        "DELETE FROM Tbl_Costo_Indirecto_Produccion WHERE Pk_Id_Costo_Indirecto_Produccion = ?", conn);
                    cmd.Parameters.AddWithValue("?", idCosto);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (EliminarCostoIndirecto): " + ex.Message);
                    return false;
                }
            }
        }
    }
}
