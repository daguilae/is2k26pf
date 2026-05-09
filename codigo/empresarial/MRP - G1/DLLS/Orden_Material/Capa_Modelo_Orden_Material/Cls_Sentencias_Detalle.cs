using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad;

namespace Capa_Modelo_Orden_Material
{
    // ------ LETICIA SONTAY - 9959-21-9664, 07/05/2026 --------
    public class Cls_Sentencias_Detalle_Orden_Material
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable ObtenerOrdenesCombo()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion()) // ✅ CORREGIDO
            {
                string query = @"
                    SELECT 
                        e.Pk_Id_Orden_Material              AS IdOrden,
                        e.Pk_Id_Orden_Material              AS IdOrdenDisplay,
                        t.Nombre_Estado                     AS NombreEstado,
                        e.Fecha_Solicitud                   AS FechaSolicitud,
                        e.Fecha_Recibida                    AS FechaRecibida,
                        CONCAT(
                            'OM-', e.Pk_Id_Orden_Material,
                            ' | ', t.Nombre_Estado,
                            ' | Sol: ', DATE_FORMAT(e.Fecha_Solicitud, '%d/%m/%Y')
                        )                                   AS OrdenDescripcion
                    FROM Encabezado_Orden_Material e
                    INNER JOIN Tipo_Estado_Orden_Material t
                        ON e.Fk_Id_Estado_Orden_Material = t.Pk_Id_Estado_Orden_Material
                    ORDER BY e.Pk_Id_Orden_Material DESC";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerOrdenPorId(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion()) // ✅ CORREGIDO
            {
                string query = @"
                    SELECT 
                        e.Pk_Id_Orden_Material              AS IdOrden,
                        e.Fk_Id_Orden_Produccion            AS IdOrdenProduccion,
                        e.Fk_Id_Estado_Orden_Material       AS IdEstado,
                        t.Nombre_Estado                     AS NombreEstado,
                        e.Fecha_Solicitud                   AS FechaSolicitud,
                        e.Fecha_Recibida                    AS FechaRecibida
                    FROM Encabezado_Orden_Material e
                    INNER JOIN Tipo_Estado_Orden_Material t
                        ON e.Fk_Id_Estado_Orden_Material = t.Pk_Id_Estado_Orden_Material
                    WHERE e.Pk_Id_Orden_Material = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idOrden);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            DataTable dt = new DataTable();
            using (OdbcConnection conn = conexion.AbrirConexion()) // ✅ CORREGIDO
            {
                string query = @"
                    SELECT 
                        d.Pk_Id_Detalle_Orden_Material      AS IdDetalle,
                        m.Pk_Id_Materiales                  AS IdMaterial,
                        m.Codigo_Material                   AS CodigoMaterial,
                        m.Nombre_Material                   AS NombreMaterial,
                        u.Abreviatura_Unidad_Medida         AS UnidadMedida,
                        d.Cantidad_Solicitada               AS CantidadSolicitada,
                        d.Cantidad_Entregada                AS CantidadEntregada,
                        d.Cantidad_Pendiente                AS CantidadPendiente
                    FROM Detalle_Orden_Material d
                    INNER JOIN Tbl_Materiales m
                        ON d.Fk_Id_Materiales = m.Pk_Id_Materiales
                    INNER JOIN Tbl_Unidad_Medida u
                        ON m.Fk_Id_Unidad_Medida = u.Pk_Id_Unidad_Medida
                    WHERE d.Fk_Id_Orden_Material = ?
                    ORDER BY m.Codigo_Material";

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
            using (OdbcConnection conn = conexion.AbrirConexion()) // ✅ CORREGIDO
            {
                string query = @"
                    SELECT 
                        t.Pk_Id_Estado_Orden_Material       AS IdEstado,
                        t.Nombre_Estado                     AS NombreEstado
                    FROM Tipo_Estado_Orden_Material t
                    ORDER BY t.Nombre_Estado";

                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                da.Fill(dt);
            }
            return dt;
        }

        public bool ModificarOrden(int idOrden, int idEstado, DateTime? fechaRecibida)
        {
            using (OdbcConnection conn = conexion.AbrirConexion()) // ✅ CORREGIDO
            {
                conn.Open(); // ✅ AGREGADO — obligatorio para ExecuteNonQuery

                string query = @"
                    UPDATE Encabezado_Orden_Material
                    SET 
                        Fk_Id_Estado_Orden_Material = ?,
                        Fecha_Recibida              = ?
                    WHERE Pk_Id_Orden_Material = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", idEstado);
                cmd.Parameters.AddWithValue("?",
                    fechaRecibida.HasValue ? (object)fechaRecibida.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("?", idOrden);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
    // ------ LETICIA SONTAY - 9959-21-9664, 07/05/2026 --------
}