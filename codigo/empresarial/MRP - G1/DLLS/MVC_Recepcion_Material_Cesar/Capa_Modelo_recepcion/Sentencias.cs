using System;
using System.Data;
using Capa_Modelo_Seguridad;
using System.Data.Odbc;

namespace Capa_Modelo_recepcion
{
    public class Sentencias
    {
        //cesar santizo 0901-22-5215
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        //cesar santizo 0901-22-5215
        public DataTable obtenerMateriales()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"SELECT 
                        Pk_Id_Materiales, 
                        Nombre_Material 
                       FROM Tbl_Materiales
                       WHERE Activo = 1;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        //cesar santizo 0901-22-5215
        public DataTable obtenerUbi()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            Pk_Id_Almacen,
            Nombre_Almacen
        FROM Tbl_Almacen
        WHERE Estado_Almacen = 1;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        //cesar santizo 0901-22-5215
        public DataTable estado()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            Pk_Id_Estado_Recepcion_Material,
            Nombre_Estado_Recepcion_Material
        FROM Tbl_Estado_Recepcion_Material;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        //Diego Monterroso 0901-22-1369
        public DataTable obtenerListadoRecepciones()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            SELECT 
                re.Pk_Id_Recepcion AS ID,
                re.Id_Externo_Logistica AS Codigo_Logistica,
                a.Nombre_Almacen AS Almacen_Destino,
                er.Nombre_Estado_Recepcion_Material AS Estado,
                re.Fecha_Notificacion,
                re.Fecha_Ingreso_Almacen,
                re.Observacion
            FROM Tbl_Recepcion_Encabezado re
            INNER JOIN Tbl_Almacen a
                ON re.Fk_Id_Almacen_Destino = a.Pk_Id_Almacen
            INNER JOIN Tbl_Estado_Recepcion_Material er
                ON re.Fk_Id_Estado_Recepcion = er.Pk_Id_Estado_Recepcion_Material
            ORDER BY re.Pk_Id_Recepcion DESC;";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                da.Fill(tabla);
            }

            return tabla;
        }

        //Diego Monterroso 0901-22-1369
        public DataTable filtrarListadoRecepciones(string id, string estado, DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            SELECT 
                re.Pk_Id_Recepcion AS ID,
                re.Id_Externo_Logistica AS Codigo_Logistica,
                a.Nombre_Almacen AS Almacen_Destino,
                er.Nombre_Estado_Recepcion_Material AS Estado,
                re.Fecha_Notificacion,
                re.Fecha_Ingreso_Almacen,
                re.Observacion
            FROM Tbl_Recepcion_Encabezado re
            INNER JOIN Tbl_Almacen a
                ON re.Fk_Id_Almacen_Destino = a.Pk_Id_Almacen
            INNER JOIN Tbl_Estado_Recepcion_Material er
                ON re.Fk_Id_Estado_Recepcion = er.Pk_Id_Estado_Recepcion_Material
            WHERE 
                (? = '' OR re.Pk_Id_Recepcion = ?)
                AND (? = '' OR er.Nombre_Estado_Recepcion_Material = ?)
                AND re.Fecha_Notificacion BETWEEN ? AND ?
            ORDER BY re.Pk_Id_Recepcion DESC;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id1", id);
                cmd.Parameters.AddWithValue("@id2", id);

                cmd.Parameters.AddWithValue("@estado1", estado);
                cmd.Parameters.AddWithValue("@estado2", estado);

                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        //Diego Monterroso 0901-22-1369
        public void eliminarRecepcion(int idRecepcion)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            DELETE FROM Tbl_Recepcion_Encabezado
            WHERE Pk_Id_Recepcion = ?;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", idRecepcion);

                cmd.ExecuteNonQuery();
            }
        }

        //Diego Monterroso 0901-22-1369
        public int guardarRecepcionEncabezado(string idExterno, int almacen, int estado, DateTime notificacion, DateTime ingreso, string observacion)
        {
            int idGenerado = 0;

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            INSERT INTO Tbl_Recepcion_Encabezado
            (
                Id_Externo_Logistica,
                Fk_Id_Almacen_Destino,
                Fk_Id_Estado_Recepcion,
                Fecha_Notificacion,
                Fecha_Ingreso_Almacen,
                Observacion
            )
            VALUES (?, ?, ?, ?, ?, ?);";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idExterno", idExterno);
                cmd.Parameters.AddWithValue("@almacen", almacen);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@notificacion", notificacion);
                cmd.Parameters.AddWithValue("@ingreso", ingreso);
                cmd.Parameters.AddWithValue("@observacion", observacion);

                cmd.ExecuteNonQuery();

                OdbcCommand cmdId = new OdbcCommand("SELECT LAST_INSERT_ID();", conn);
                idGenerado = Convert.ToInt32(cmdId.ExecuteScalar());
            }

            return idGenerado;
        }

        //Diego Monterroso 0901-22-1369
        public void guardarRecepcionDetalle(int idRecepcion, int idMaterial, decimal cantidad, decimal costo)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            INSERT INTO Tbl_Recepcion_Detalle
            (
                Fk_Id_Recepcion,
                Fk_Id_Material,
                Cantidad_Recibida,
                Costo_Unitario_Recibido
            )
            VALUES (?, ?, ?, ?);";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idRecepcion", idRecepcion);
                cmd.Parameters.AddWithValue("@idMaterial", idMaterial);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@costo", costo);

                cmd.ExecuteNonQuery();
            }
        }

        //Diego Monterroso 0901-22-1369
        public void modificarRecepcionEncabezado(int idRecepcion, string idExterno, int almacen, int estado, DateTime notificacion, DateTime ingreso, string observacion)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            UPDATE Tbl_Recepcion_Encabezado
            SET 
                Id_Externo_Logistica = ?,
                Fk_Id_Almacen_Destino = ?,
                Fk_Id_Estado_Recepcion = ?,
                Fecha_Notificacion = ?,
                Fecha_Ingreso_Almacen = ?,
                Observacion = ?
            WHERE Pk_Id_Recepcion = ?;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idExterno", idExterno);
                cmd.Parameters.AddWithValue("@almacen", almacen);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@notificacion", notificacion);
                cmd.Parameters.AddWithValue("@ingreso", ingreso);
                cmd.Parameters.AddWithValue("@observacion", observacion);
                cmd.Parameters.AddWithValue("@idRecepcion", idRecepcion);

                cmd.ExecuteNonQuery();
            }
        }

        //Diego Monterroso 0901-22-1369
        public void eliminarDetalleRecepcion(int idRecepcion)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            DELETE FROM Tbl_Recepcion_Detalle
            WHERE Fk_Id_Recepcion = ?;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idRecepcion", idRecepcion);
                cmd.ExecuteNonQuery();
            }
        }

        //Diego Monterroso 0901-22-1369
        public void eliminarRecepcionCompleta(int idRecepcion)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
            DELETE FROM Tbl_Recepcion_Encabezado
            WHERE Pk_Id_Recepcion = ?;";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idRecepcion", idRecepcion);
                cmd.ExecuteNonQuery();
            }

        }

        //cesar santizo 0901-22-5215

        public DataTable obtenerRecepcionPorId(int id)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            re.Id_Externo_Logistica,
            re.Fk_Id_Almacen_Destino,
            re.Fk_Id_Estado_Recepcion,
            re.Fecha_Notificacion,
            re.Fecha_Ingreso_Almacen,
            re.Observacion
        FROM Tbl_Recepcion_Encabezado re
        WHERE re.Pk_Id_Recepcion = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }

        //cesar santizo 0901-22-5215

        public DataTable obtenerDetalleRecepcion(int id)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = @"
        SELECT 
            rd.Fk_Id_Material,
            m.Nombre_Material,
            rd.Cantidad_Recibida,
            rd.Costo_Unitario_Recibido
        FROM Tbl_Recepcion_Detalle rd
        INNER JOIN Tbl_Materiales m
            ON rd.Fk_Id_Material = m.Pk_Id_Materiales
        WHERE rd.Fk_Id_Recepcion = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}