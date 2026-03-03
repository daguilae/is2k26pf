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

        // 7) OBTENER ID REAL SEGÚN TIPO + DURACIÓN
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
    }
}