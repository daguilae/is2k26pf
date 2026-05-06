using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_RO
{
    // ------ LETICIA SONTAY - 9959-21-9664, 28/04/2026 --------
    public class Cls_Sentencias_Detalle
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                m.Pk_Id_Materiales                AS Id_Material,
                m.Nombre_Material               AS Nombre_Material,
                u.Abreviatura_Unidad_Medida     AS UnidadMedida,
                d.Cantidad_Solicitada           AS CantidadSolicitada
            FROM Tbl_Orden_Recibida_Detalle d
            INNER JOIN Tbl_Materiales m 
                ON d.Fk_Id_Material = m.Pk_Id_Materiales
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            WHERE d.Fk_Id_Orden_Recibida = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerOrdenesCombo()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                
                string query = @"
                    SELECT 
                        o.Pk_Id_Orden_Recibida  AS IdOrden,
                        o.Id_Externo_Logistica  AS Orden
                    FROM Tbl_Orden_Recibida o
                    ORDER BY o.Id_Externo_Logistica";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerOrdenPorId(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                
                string query = @"
                    SELECT 
                        o.Pk_Id_Orden_Recibida              AS IdOrden,
                        o.Id_Externo_Logistica              AS Orden,
                        o.Fk_Id_Estado_Orden_Recibida       AS IdEstado,
                        o.Fecha_Recepcion                   AS FechaRecepcion,
                        o.Fecha_Requerida                   AS FechaRequerida,
                        o.Observacion                       AS Observacion
                    FROM Tbl_Orden_Recibida o
                    WHERE o.Pk_Id_Orden_Recibida = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden); 
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        
        public DataTable ObtenerEstadosOrden()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT 
                        e.Pk_Id_Estado_Orden_Recibida   AS IdEstado,
                        e.Nombre_Estado_Orden_Recibida  AS NombreEstado
                    FROM Tbl_Estado_Orden_Recibida e
                    ORDER BY e.Nombre_Estado_Orden_Recibida";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }
    
    // ------ LETICIA SONTAY - 9959-21-9664, 28/04/2026 --------



    // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------

    // Obtener todos los materiales para los ComboBox (ID y Nombre)
    public DataTable ObtenerMateriales()
    {
        DataTable dt = new DataTable();
        using (OdbcConnection conn = conexion.AbrirConexion())
        {
            string query = @"
            SELECT 
                m.Pk_Id_Materiales              AS Id_Material,
                m.Codigo_Material               AS Codigo_Material,
                m.Nombre_Material               AS Nombre_Material,
                u.Abreviatura_Unidad_Medida     AS UnidadMedida
            FROM Tbl_Materiales m
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            ORDER BY m.Codigo_Material";

            OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
            da.Fill(dt);
        }
        return dt;
    }

    // Obtener un material específico por su ID interno (Pk)
    public DataTable ObtenerMaterialPorId(int idMaterial)
    {
        DataTable dt = new DataTable();
        using (OdbcConnection conn = conexion.AbrirConexion())
        {
            string query = @"
            SELECT 
                m.Pk_Id_Materiales              AS Id_Material,
                m.Codigo_Material               AS Codigo_Material,
                m.Nombre_Material               AS Nombre_Material,
                u.Abreviatura_Unidad_Medida     AS UnidadMedida
            FROM Tbl_Materiales m
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            WHERE m.Pk_Id_Materiales = ?";

            OdbcCommand cmd = new OdbcCommand(query, conn);
            cmd.Parameters.AddWithValue("?", idMaterial);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }

    // Obtener un material específico por su Código (Codigo_Material)
    public DataTable ObtenerMaterialPorCodigo(string codigoMaterial)
    {
        DataTable dt = new DataTable();
        using (OdbcConnection conn = conexion.AbrirConexion())
        {
            string query = @"
            SELECT 
                m.Pk_Id_Materiales              AS Id_Material,
                m.Codigo_Material               AS Codigo_Material,
                m.Nombre_Material               AS Nombre_Material,
                u.Abreviatura_Unidad_Medida     AS UnidadMedida
            FROM Tbl_Materiales m
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            WHERE m.Codigo_Material = ?";

            OdbcCommand cmd = new OdbcCommand(query, conn);
            cmd.Parameters.AddWithValue("?", codigoMaterial);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }

    // Obtener un material específico por su Nombre
    public DataTable ObtenerMaterialPorNombre(string nombreMaterial)
    {
        DataTable dt = new DataTable();
        using (OdbcConnection conn = conexion.AbrirConexion())
        {
            string query = @"
            SELECT 
                m.Pk_Id_Materiales              AS Id_Material,
                m.Codigo_Material               AS Codigo_Material,
                m.Nombre_Material               AS Nombre_Material,
                u.Abreviatura_Unidad_Medida     AS UnidadMedida
            FROM Tbl_Materiales m
            INNER JOIN Tbl_Unidad_Medida u
                ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
            WHERE m.Nombre_Material = ?";

            OdbcCommand cmd = new OdbcCommand(query, conn);
            cmd.Parameters.AddWithValue("?", nombreMaterial);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
        }
        return dt;
    }
        // ------ PAULA DANIELA LEONARDO - 0901-22-9580, 28/04/2026 --------

    }
}