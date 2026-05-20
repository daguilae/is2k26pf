// Arón Ricardo Esquit Silva 0901-22-13036 07/05/2026
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Seguridad
using Capa_Modelo_Seguridad;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Orden_Material
{
    public class Cls_Dao_Encabezado_Orden_Material
    {

        //Conexión de Seguridad
        Cls_Conexion conexion = new Cls_Conexion();

        // Consultar todas las órdenes materiales
        public DataTable Fun_Mostrar_Encabezado_Orden_Material()
        {


            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
                    SELECT 
                        eom.Pk_Id_Orden_Material AS ID_Orden,
                        eom.Fk_Id_Orden_Recibida AS Orden_Recibida,
                        eom.Fk_Id_Estado_Orden_Material AS ID_Estado,
                        teom.Nombre_Estado AS Estado,
                        eom.Fecha_Solicitud AS Fecha_Solicitud,
                        eom.Fecha_Recibida AS Fecha_Recibida
                    FROM Tbl_Encabezado_Orden_Material eom
                    INNER JOIN Tbl_Tipo_Estado_Orden_Material teom
                        ON eom.Fk_Id_Estado_Orden_Material = teom.Pk_Id_Estado_Orden_Material
                    ORDER BY eom.Pk_Id_Orden_Material DESC;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt;
        }

        // Filtrar por ID de orden material
        public DataTable Fun_Buscar_Encabezado_Orden_Material(int iIdOrdenMaterial)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
                    SELECT 
                        eom.Pk_Id_Orden_Material AS ID_Orden,
                        eom.Fk_Id_Orden_Recibida AS Orden_Recibida,
                        eom.Fk_Id_Estado_Orden_Material AS ID_Estado,
                        teom.Nombre_Estado AS Estado,
                        eom.Fecha_Solicitud AS Fecha_Solicitud,
                        eom.Fecha_Recibida AS Fecha_Recibida
                    FROM Tbl_Encabezado_Orden_Material eom
                    INNER JOIN Tbl_Tipo_Estado_Orden_Material teom
                        ON eom.Fk_Id_Estado_Orden_Material = teom.Pk_Id_Estado_Orden_Material
                    WHERE eom.Pk_Id_Orden_Material = ?;
                ";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", iIdOrdenMaterial);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // Filtrar por orden de producción
        public DataTable Fun_Filtrar_Por_Orden_Recibida(int iIdOrdenRecibida)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
                    SELECT 
                        eom.Pk_Id_Orden_Material AS ID_Orden,
                        eom.Fk_Id_Orden_Recibida AS Orden_Recibida,
                        eom.Fk_Id_Estado_Orden_Material AS ID_Estado,
                        teom.Nombre_Estado AS Estado,
                        eom.Fecha_Solicitud AS Fecha_Solicitud,
                        eom.Fecha_Recibida AS Fecha_Recibida
                    FROM Tbl_Encabezado_Orden_Material eom
                    INNER JOIN Tbl_Tipo_Estado_Orden_Material teom
                        ON eom.Fk_Id_Estado_Orden_Material = teom.Pk_Id_Estado_Orden_Material
                    WHERE eom.Fk_Id_Orden_Recibida = ?;
                ";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ordenRecibida", iIdOrdenRecibida);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // Filtrar por estado
        public DataTable Fun_Filtrar_Por_Estado(int iIdEstado)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
                    SELECT 
                        eom.Pk_Id_Orden_Material AS ID_Orden,
                        eom.Fk_Id_Orden_Recibida AS Orden_Recibida,
                        eom.Fk_Id_Estado_Orden_Material AS ID_Estado,
                        teom.Nombre_Estado AS Estado,
                        eom.Fecha_Solicitud AS Fecha_Solicitud,
                        eom.Fecha_Recibida AS Fecha_Recibida
                    FROM Tbl_Encabezado_Orden_Material eom
                    INNER JOIN Tbl_Tipo_Estado_Orden_Material teom
                        ON eom.Fk_Id_Estado_Orden_Material = teom.Pk_Id_Estado_Orden_Material
                    WHERE eom.Fk_Id_Estado_Orden_Material = ?;
                ";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@estado", iIdEstado);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        // Combo de estados
        public DataTable Fun_Obtener_Estados_Orden_Material()
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
                    SELECT 
                        Pk_Id_Estado_Orden_Material,
                        Nombre_Estado
                    FROM Tbl_Tipo_Estado_Orden_Material;
                ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt;
        }

        // Combo de órdenes de producción
        // Combo de órdenes recibidas
        public DataTable Fun_Obtener_Ordenes_Recibidas()
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
            SELECT 
                Pk_Id_Orden_Recibida,
                Pk_Id_Orden_Recibida AS Orden_Recibida
            FROM Tbl_Orden_Recibida
            ORDER BY Pk_Id_Orden_Recibida DESC;
        ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt;
        }

        // Marcar como enviada a logística
        public bool Fun_Enviar_Logistica(int iIdOrdenMaterial)
        {
            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
                    UPDATE Tbl_Encabezado_Orden_Material
                    SET Fk_Id_Estado_Orden_Material = 1
                    WHERE Pk_Id_Orden_Material = ?;
                ";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", iIdOrdenMaterial);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable Fun_Obtener_Id_Ordenes_Material()
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
            SELECT 
                Pk_Id_Orden_Material AS ID_Orden
            FROM Tbl_Encabezado_Orden_Material
            ORDER BY Pk_Id_Orden_Material DESC;
        ";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable Fun_Filtrar_Por_Fechas(string sFechaInicio, string sFechaFin)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = conexion.conexion())
            {
                string sql = @"
            SELECT 
                eom.Pk_Id_Orden_Material AS ID_Orden,
                eom.Fk_Id_Orden_Recibida AS Orden_Recibida,
                eom.Fk_Id_Estado_Orden_Material AS ID_Estado,
                teom.Nombre_Estado AS Estado,
                eom.Fecha_Solicitud AS Fecha_Solicitud,
                eom.Fecha_Recibida AS Fecha_Recibida
            FROM Tbl_Encabezado_Orden_Material eom
            INNER JOIN Tbl_Tipo_Estado_Orden_Material teom
                ON eom.Fk_Id_Estado_Orden_Material =
                   teom.Pk_Id_Estado_Orden_Material
            WHERE DATE(eom.Fecha_Solicitud)
                  BETWEEN ? AND ?
            ORDER BY eom.Fecha_Solicitud DESC;
        ";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fechaInicio", sFechaInicio);
                cmd.Parameters.AddWithValue("@fechaFin", sFechaFin);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);

                da.Fill(dt);
            }

            return dt;
        }
    }
}
