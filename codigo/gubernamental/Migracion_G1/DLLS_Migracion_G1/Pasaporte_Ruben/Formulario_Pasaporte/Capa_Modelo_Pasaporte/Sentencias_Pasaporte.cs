using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Pasaporte
{
    public class Sentencias_Pasaporte
    {
        Cls_Conexion_Pasaporte conexion = new Cls_Conexion_Pasaporte();

        // =========================================================
        // OBTENER DATOS POR BOLETA
        // =========================================================
        public DataTable ObtenerDatosPorBoleta(int numeroBoleta)
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = @"SELECT 
                                tp.Cmp_Tipo_Pasaporte,
                                tp.Cmp_Duracion_Pasaporte,
                                c.Cmp_Dpi_Ciudadano,
                                c.Cmp_Nombres_Ciudadano,
                                c.Cmp_Apellidos_Ciudadano,
                                c.Cmp_Nacionalidad_Ciudadano,
                                c.Cmp_Fecha_Nacimiento_Ciudadano,
                                c.Cmp_Sexo_Ciudadano,
                                e.Cmp_Nombre_Estado,
                                ci.Pk_Id_Cita
                                FROM Tbl_Generar_Boleta b
                                INNER JOIN Tbl_Tipo_Pasaporte tp 
                                    ON b.Fk_Id_Tipo_Pasaporte = tp.Pk_Id_Tipo_Pasaporte
                                INNER JOIN Tbl_Ciudadano c 
                                    ON b.Fk_Id_Ciudadano = c.Pk_Id_Ciudadano
                                INNER JOIN Tbl_Cita ci
                                    ON ci.Fk_Id_Boleta = b.Pk_Id_Boleta
                                INNER JOIN Tbl_Estado_Cita e
                                    ON ci.Fk_Id_Estado_Cita = e.Pk_Id_Estado_Cita
                                WHERE b.Cmp_Numero_Boleta = ?";

                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", numeroBoleta);

                OdbcDataAdapter adaptador = new OdbcDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        // =========================================================
        // OBTENER SIGUIENTE NÚMERO DE PASAPORTE
        // =========================================================
        public int ObtenerSiguienteNumeroPasaporte()
        {
            int siguiente = 1;

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string sql = "SELECT IFNULL(MAX(Pk_Numero_Pasaporte),0) + 1 FROM Tbl_Pasaporte";
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                    siguiente = Convert.ToInt32(resultado);
            }

            return siguiente;
        }

        // =========================================================
        // INSERTAR PASAPORTE COMPLETO
        // =========================================================
        public void InsertarPasaporteCompleto(
            int numeroPasaporte,
            DateTime fechaEmision,
            DateTime fechaExpiracion,
            int idCita,
            int idPais,
            bool huellas,
            bool firma,
            byte[] fotografia,
            int estatura,
            bool menor,
            bool certificadoNacimiento,
            bool ambosPadres,
            bool dpiAmbosPadres,
            bool cartaNotariada,
            bool autorizacionJudicial,
            bool dpiPadreRep)
        {
            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();

                try
                {
                    string insert = @"INSERT INTO Tbl_Pasaporte
                    (Pk_Numero_Pasaporte,
                     Cmp_Fotografia,
                     Cmp_Huellas_Biometricas,
                     Cmp_Firma_Digital,
                     Fk_Id_Pais_Emisor,
                     Fk_Id_Cita,
                     Cmp_Fecha_Emision,
                     Cmp_Fecha_Expiracion,
                     Cmp_Estatura,
                     Cmp_Menor,
                     Cmp_Certificado_Nacimiento,
                     Cmp_Ambos_Padres,
                     Cmp_Dpi_Ambos_Padres,
                     Cmp_Carta_Notariada,
                     Cmp_Autorizacion_Judicial,
                     Cmp_Dpi_Padre_o_Rep)
                     VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

                    OdbcCommand cmd = new OdbcCommand(insert, conn, trans);

                    cmd.Parameters.AddWithValue("?", numeroPasaporte);
                    cmd.Parameters.AddWithValue("?", fotografia);
                    cmd.Parameters.AddWithValue("?", huellas);
                    cmd.Parameters.AddWithValue("?", firma);
                    cmd.Parameters.AddWithValue("?", idPais);
                    cmd.Parameters.AddWithValue("?", idCita);
                    cmd.Parameters.AddWithValue("?", fechaEmision);
                    cmd.Parameters.AddWithValue("?", fechaExpiracion);
                    cmd.Parameters.AddWithValue("?", estatura);
                    cmd.Parameters.AddWithValue("?", menor);
                    cmd.Parameters.AddWithValue("?", certificadoNacimiento);
                    cmd.Parameters.AddWithValue("?", ambosPadres);
                    cmd.Parameters.AddWithValue("?", dpiAmbosPadres);
                    cmd.Parameters.AddWithValue("?", cartaNotariada);
                    cmd.Parameters.AddWithValue("?", autorizacionJudicial);
                    cmd.Parameters.AddWithValue("?", dpiPadreRep);

                    cmd.ExecuteNonQuery();

                    // ACTUALIZAR ESTADO A "EMITIDO"
                    string update = "UPDATE Tbl_Cita SET Fk_Id_Estado_Cita = 2 WHERE Pk_Id_Cita = ?";
                    OdbcCommand cmdUpdate = new OdbcCommand(update, conn, trans);
                    cmdUpdate.Parameters.AddWithValue("?", idCita);
                    cmdUpdate.ExecuteNonQuery();

                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // =========================================================
        // OBTENER LISTA DE PAISES
        // =========================================================
        public DataTable ObtenerPaises()
        {
            DataTable tabla = new DataTable();

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                string query = "SELECT Pk_Id_Pais_Emisor, Cmp_Nombre_Pais FROM Tbl_Pais_Emisor";
                OdbcDataAdapter adaptador = new OdbcDataAdapter(query, conn);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        // =========================================================
        // VALIDAR SI EXISTE NÚMERO
        // =========================================================
        public bool ExisteNumeroPasaporte(int numeroPasaporte)
        {
            string query = "SELECT COUNT(*) FROM Tbl_Pasaporte WHERE Pk_Numero_Pasaporte = ?";

            using (OdbcConnection conn = conexion.AbrirConexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", numeroPasaporte);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }







    }
}