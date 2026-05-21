using System;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Seguridad; // Referencia a la capa de seguridad

namespace Capa_Modelo_Banrural //Paula Leonardo 0901-22-9580
{
    public class Cls_Sentencias
    {
        // Instancia de la conexión de seguridad
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        // 1. BUSCAR CIUDADANO POR DPI
        public DataTable BuscarCiudadanoPorDpi(long dpi)
        {
            const string sql = @"
                SELECT 
                    Pk_Id_Ciudadano,
                    Cmp_Dpi_Ciudadano,
                    Cmp_Nombres_Ciudadano,
                    Cmp_Apellidos_Ciudadano,
                    Cmp_Fecha_Nacimiento_Ciudadano
                FROM Tbl_Ciudadano
                WHERE Cmp_Dpi_Ciudadano = ?;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("dpi", OdbcType.BigInt).Value = dpi;

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 2. OBTENER TIPOS DE PASAPORTE (ComboBox)
        public DataTable ObtenerTiposPasaporte()
        {
            const string sql = @"
                SELECT DISTINCT Cmp_Tipo_Pasaporte
                FROM Tbl_Tipo_Pasaporte
                ORDER BY Cmp_Tipo_Pasaporte;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 3) OBTENER DURACIÓN POR TIPO (ComboBox)
        public DataTable ObtenerDuracionesPorTipo(string tipoPasaporte)
        {
            const string sql = @"
                SELECT DISTINCT Cmp_Duracion_Pasaporte
                FROM Tbl_Tipo_Pasaporte
                WHERE Cmp_Tipo_Pasaporte = ?
                ORDER BY Cmp_Duracion_Pasaporte;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("tipo", OdbcType.VarChar).Value = tipoPasaporte;

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 4. OBTENER PRECIO POR TIPO
        public decimal ObtenerPrecio(string tipoPasaporte, int duracion)
        {
            const string sql = @"
                SELECT Precio
                FROM Tbl_Tipo_Pasaporte
                WHERE Cmp_Tipo_Pasaporte = ?
                  AND Cmp_Duracion_Pasaporte = ?
                LIMIT 1;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("tipo", OdbcType.VarChar).Value = tipoPasaporte;
                cmd.Parameters.Add("dur", OdbcType.Int).Value = duracion;

                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return 0m;

                return Convert.ToDecimal(result);
            }
        }

        // 5) INSERTAR BOLETA (GUARDAR PAGO)
        public int InsertarBoleta(int numeroBoleta, int idCiudadano, int idTipoPasaporte)
        {
            const string sql = @"
                INSERT INTO Tbl_Generar_Boleta
                    (Cmp_Numero_Boleta, Fk_Id_Ciudadano, Fk_Id_Tipo_Pasaporte)
                VALUES (?, ?, ?);";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("noBoleta", OdbcType.Int).Value = numeroBoleta;
                cmd.Parameters.Add("idCiudadano", OdbcType.Int).Value = idCiudadano;
                cmd.Parameters.Add("idTipo", OdbcType.Int).Value = idTipoPasaporte;

                return cmd.ExecuteNonQuery(); // 1 si insertó bien
            }
        }

        // 6. VALIDAR SI YA EXISTE NÚMERO DE BOLETA
        public bool ExisteNumeroBoleta(int numeroBoleta)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM Tbl_Generar_Boleta
                WHERE Cmp_Numero_Boleta = ?;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("noBoleta", OdbcType.Int).Value = numeroBoleta;

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // 7. OBTENER ID REAL SEGÚN TIPO + DURACIÓN
        public int ObtenerIdTipoPasaporte(string tipoPasaporte, int duracion)
        {
            const string sql = @"
                SELECT Pk_Id_Tipo_Pasaporte
                FROM Tbl_Tipo_Pasaporte
                WHERE Cmp_Tipo_Pasaporte = ?
                  AND Cmp_Duracion_Pasaporte = ?
                LIMIT 1;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("tipo", OdbcType.VarChar).Value = tipoPasaporte;
                cmd.Parameters.Add("dur", OdbcType.Int).Value = duracion;

                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return 0;

                return Convert.ToInt32(result);
            }
        }

        // 8. OBTENER BOLETAS POR CIUDADANO (Para DataGridView)
        public DataTable ObtenerBoletasPorCiudadano(int idCiudadano)
        {
            const string sql = @"
        SELECT 
            b.Pk_Id_Boleta,
            b.Cmp_Numero_Boleta,
            tp.Cmp_Tipo_Pasaporte,
            tp.Cmp_Duracion_Pasaporte,
            tp.Precio
        FROM Tbl_Generar_Boleta b
        INNER JOIN Tbl_Tipo_Pasaporte tp
            ON b.Fk_Id_Tipo_Pasaporte = tp.Pk_Id_Tipo_Pasaporte
        WHERE b.Fk_Id_Ciudadano = ?
        ORDER BY b.Pk_Id_Boleta DESC;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("idCiudadano", OdbcType.Int).Value = idCiudadano;

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 8B) Obtener TODAS las boletas (con datos del ciudadano)
        public DataTable ObtenerTodasLasBoletasConCiudadano()
        {
            const string sql = @"
        SELECT 
            b.Pk_Id_Boleta,
            b.Cmp_Numero_Boleta,
            c.Cmp_Dpi_Ciudadano,
            c.Cmp_Nombres_Ciudadano,
            c.Cmp_Apellidos_Ciudadano,
            tp.Cmp_Tipo_Pasaporte,
            tp.Cmp_Duracion_Pasaporte,
            tp.Precio
        FROM Tbl_Generar_Boleta b
        INNER JOIN Tbl_Ciudadano c
            ON c.Pk_Id_Ciudadano = b.Fk_Id_Ciudadano
        INNER JOIN Tbl_Tipo_Pasaporte tp
            ON tp.Pk_Id_Tipo_Pasaporte = b.Fk_Id_Tipo_Pasaporte
        ORDER BY b.Pk_Id_Boleta DESC;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcDataAdapter da = new OdbcDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 8C) Obtener boletas filtradas por DPI (para el botón Buscar)
        public DataTable ObtenerBoletasPorDpi(long dpi)
        {
            const string sql = @"
        SELECT 
            b.Pk_Id_Boleta,
            b.Cmp_Numero_Boleta,
            c.Cmp_Dpi_Ciudadano,
            c.Cmp_Nombres_Ciudadano,
            c.Cmp_Apellidos_Ciudadano,
            tp.Cmp_Tipo_Pasaporte,
            tp.Cmp_Duracion_Pasaporte,
            tp.Precio
        FROM Tbl_Generar_Boleta b
        INNER JOIN Tbl_Ciudadano c
            ON c.Pk_Id_Ciudadano = b.Fk_Id_Ciudadano
        INNER JOIN Tbl_Tipo_Pasaporte tp
            ON tp.Pk_Id_Tipo_Pasaporte = b.Fk_Id_Tipo_Pasaporte
        WHERE c.Cmp_Dpi_Ciudadano = ?
        ORDER BY b.Pk_Id_Boleta DESC;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("dpi", OdbcType.BigInt).Value = dpi;

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 9. ELIMINAR BOLETA
        public int EliminarBoleta(int idBoleta)
        {
            const string sql = @"
        DELETE FROM Tbl_Generar_Boleta
        WHERE Pk_Id_Boleta = ?;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("idBoleta", OdbcType.Int).Value = idBoleta;

                return cmd.ExecuteNonQuery();
            }
        }

        // 10. ACTUALIZAR BOLETA
        public int ActualizarBoleta(int idBoleta, int idTipoPasaporte)
        {
            const string sql = @"
        UPDATE Tbl_Generar_Boleta
        SET Fk_Id_Tipo_Pasaporte = ?
        WHERE Pk_Id_Boleta = ?;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("idTipo", OdbcType.Int).Value = idTipoPasaporte;
                cmd.Parameters.Add("idBoleta", OdbcType.Int).Value = idBoleta;

                return cmd.ExecuteNonQuery();
            }
        }

        // 11. OBTENER DETALLE DE BOLETA PARA EDITAR
        public DataTable ObtenerBoletaPorId(int idBoleta)
        {
            const string sql = @"
        SELECT 
            b.Pk_Id_Boleta,
            b.Cmp_Numero_Boleta,
            c.Pk_Id_Ciudadano,
            c.Cmp_Dpi_Ciudadano,
            c.Cmp_Nombres_Ciudadano,
            c.Cmp_Apellidos_Ciudadano,
            c.Cmp_Fecha_Nacimiento_Ciudadano,
            tp.Cmp_Tipo_Pasaporte,
            tp.Cmp_Duracion_Pasaporte,
            tp.Precio
        FROM Tbl_Generar_Boleta b
        INNER JOIN Tbl_Ciudadano c
            ON c.Pk_Id_Ciudadano = b.Fk_Id_Ciudadano
        INNER JOIN Tbl_Tipo_Pasaporte tp
            ON tp.Pk_Id_Tipo_Pasaporte = b.Fk_Id_Tipo_Pasaporte
        WHERE b.Pk_Id_Boleta = ?;";

            using (OdbcConnection conn = conexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sql, conn))
            {
                cmd.Parameters.Add("idBoleta", OdbcType.Int).Value = idBoleta;

                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}