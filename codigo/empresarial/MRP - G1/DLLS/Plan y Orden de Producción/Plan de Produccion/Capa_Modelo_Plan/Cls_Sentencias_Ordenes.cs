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

        public DataTable obtenerOrdenesProduccionPorOrden(int idOrdenRecibida)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (OdbcConnection conn =
                    conexion.AbrirConexion())
                {
                    string sql = @"
                SELECT
                op.Pk_Id_Orden_Produccion AS NoOrden,op.Fk_Id_Material AS IdMaterial,
                m.Nombre_Material AS Material, op.Fk_Id_Estado_Orden_Produccion AS IdEstado,
                eo.Nombre_Estado_Orden_Produccion AS Estado,  op.Cantidad_Programada_Orden_Produccion AS Cantidad,
                op.Fecha_Inicio_Orden_Produccion AS FechaInicio, op.Fecha_Fin_Orden_Produccion AS FechaFin
                FROM Tbl_Orden_Produccion op
                INNER JOIN Tbl_Plan_Produccion pp
                 ON op.Fk_Id_Plan_Produccion = pp.Pk_Id_Plan_Produccion
                INNER JOIN Tbl_Materiales m
                ON op.Fk_Id_Material = m.Pk_Id_Materiales
                INNER JOIN Tbl_Estado_Orden_Produccion eo
                ON op.Fk_Id_Estado_Orden_Produccion = eo.Pk_Id_Estado_Orden_Produccion
                WHERE pp.Fk_Id_Orden_Recibida = ?";

                    OdbcCommand cmd =
                        new OdbcCommand(sql, conn);

                    cmd.Parameters.AddWithValue(
                        "@plan",
                        idOrdenRecibida);

                    OdbcDataAdapter da =
                        new OdbcDataAdapter(cmd);

                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener órdenes: " +
                    ex.Message);
            }

            return tabla;
        }
    }
}
