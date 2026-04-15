using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Pasaporte
{
    public class Sentencias_Ver_Pasaporte
    {
        Cls_Conexion_Pasaporte conexion = new Cls_Conexion_Pasaporte();

        // =========================================================
        // OBTENER PASAPORTE POR NUMERO
        // =========================================================
        public DataTable ObtenerPasaportePorNumero(int numeroPasaporte)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"
                SELECT 
                    p.Pk_Numero_Pasaporte,
                    p.Cmp_Fecha_Emision,
                    p.Cmp_Fecha_Expiracion,
                    p.Cmp_Fotografia,
                    c.Cmp_Dpi_Ciudadano,
                    c.Cmp_Nombres_Ciudadano,
                    c.Cmp_Apellidos_Ciudadano,
                    c.Cmp_Nacionalidad_Ciudadano,
                    c.Cmp_Fecha_Nacimiento_Ciudadano,
                    c.Cmp_Sexo_Ciudadano,
                    c.Cmp_Lugar_Nacimiento_Ciudadano,
                    tp.Cmp_Tipo_Pasaporte,
                    pe.Cmp_Nombre_Pais
                FROM Tbl_Pasaporte p
                INNER JOIN Tbl_Cita ci ON p.Fk_Id_Cita = ci.Pk_Id_Cita
                INNER JOIN Tbl_Generar_Boleta b ON ci.Fk_Id_Boleta = b.Pk_Id_Boleta
                INNER JOIN Tbl_Ciudadano c ON b.Fk_Id_Ciudadano = c.Pk_Id_Ciudadano
                INNER JOIN Tbl_Tipo_Pasaporte tp ON b.Fk_Id_Tipo_Pasaporte = tp.Pk_Id_Tipo_Pasaporte
                INNER JOIN Tbl_Pais_Emisor pe ON p.Fk_Id_Pais_Emisor = pe.Pk_Id_Pais_Emisor
                WHERE p.Pk_Numero_Pasaporte = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", numeroPasaporte);

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}