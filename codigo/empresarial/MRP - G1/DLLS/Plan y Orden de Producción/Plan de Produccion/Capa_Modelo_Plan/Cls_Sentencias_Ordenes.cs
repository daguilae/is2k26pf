using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Plan
{
    public class Cls_Sentencias_Ordenes
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();


        public DataTable obtenerOrdenesRecibidas()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn =
                conexion.AbrirConexion())
            {
                string sql = @"
                SELECT Pk_Id_Orden_Recibida
                FROM Tbl_Orden_Recibida";

                OdbcDataAdapter da =
                    new OdbcDataAdapter(sql, conn);

                da.Fill(tabla);
            }

            return tabla;
        }


        public DataTable obtenerMaterialPorOrden(int idOrden)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn =
                conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            M.Pk_Id_Materiales,
            M.Nombre_Material,
            M.Lead_Time_Produccion_Dias AS DiasFabricacion,
            D.Cantidad_Solicitada
        FROM Tbl_Orden_Recibida_Detalle D
        INNER JOIN Tbl_Materiales M
            ON D.Fk_Id_Material =
               M.Pk_Id_Materiales
        WHERE D.Fk_Id_Orden_Recibida = ?";

                OdbcCommand cmd =
                    new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue(
                    "@orden",
                    idOrden);

                OdbcDataAdapter da =
                    new OdbcDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }


        public DataTable obtenerEstados()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn =
                conexion.AbrirConexion())
            {
                string sql = @"
                SELECT
                    Pk_Id_Estado_Plan_Produccion,
                    Nombre_Estado_Plan_Produccion
                FROM tbl_estado_plan_produccion";

                OdbcDataAdapter da =
                    new OdbcDataAdapter(sql, conn);

                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
