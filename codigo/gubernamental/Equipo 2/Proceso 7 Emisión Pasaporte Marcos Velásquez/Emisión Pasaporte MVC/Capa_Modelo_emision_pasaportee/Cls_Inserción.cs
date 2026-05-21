using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_emision_pasaporte
{
    public class Cls_Inserción
    {


        Cls_Conexion con = new Cls_Conexion();

        public void InsertarTodo(
    string dpi,
    string nombre,
    string apellido,
    string sexo,
    DateTime fechaNacimiento,
    string numeroPasaporte,
    DateTime fechaEmision,
    DateTime fechaVencimiento,
    byte[] fotografia, // Parámetro agregado
    byte[] firma      // Parámetro agregado
)
        {
            using (OdbcConnection conn = con.AbrirConexion())
            {
                OdbcTransaction trans = conn.BeginTransaction();

                try
                {
                    // 1. Insertar en tbl_solicitante
                    string sql1 = @"INSERT INTO tbl_solicitante 
                            (Cmp_DPI, Cmp_Nombre, Cmp_Apellido, Cmp_Sexo, Cmp_Fecha_Nacimiento) 
                            VALUES (?, ?, ?, ?, ?)";

                    OdbcCommand cmd1 = new OdbcCommand(sql1, conn, trans);
                    cmd1.Parameters.AddWithValue("?", dpi);
                    cmd1.Parameters.AddWithValue("?", nombre);
                    cmd1.Parameters.AddWithValue("?", apellido);
                    cmd1.Parameters.AddWithValue("?", sexo);
                    cmd1.Parameters.AddWithValue("?", fechaNacimiento.ToString("yyyy-MM-dd"));

                    cmd1.ExecuteNonQuery();

                    // 2. Obtener el ID generado (pk_solicitante_id)
                    cmd1.CommandText = "SELECT LAST_INSERT_ID()";
                    int idSolicitante = Convert.ToInt32(cmd1.ExecuteScalar());

                    // 3. Insertar en tbl_pasaporte
                    string sql2 = @"INSERT INTO tbl_pasaporte 
                            (fk_solicitante_id, fk_tipo_pasaporte, numero_pasaporte, fecha_emision, fecha_vencimiento, estado) 
                            VALUES (?, ?, ?, ?, ?, ?)";

                    OdbcCommand cmd2 = new OdbcCommand(sql2, conn, trans);
                    cmd2.Parameters.AddWithValue("?", idSolicitante);
                    cmd2.Parameters.AddWithValue("?", 1);
                    cmd2.Parameters.AddWithValue("?", numeroPasaporte);
                    cmd2.Parameters.AddWithValue("?", fechaEmision.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("?", fechaVencimiento.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("?", "ACTIVO");

                    cmd2.ExecuteNonQuery();

                    // 4. NUEVO: Insertar en tbl_biometricos
                    string sql3 = @"INSERT INTO tbl_biometricos 
                            (fk_solicitante_id, fotografia, firma, fecha_registro) 
                            VALUES (?, ?, ?, NOW())";

                    OdbcCommand cmd3 = new OdbcCommand(sql3, conn, trans);
                    cmd3.Parameters.AddWithValue("?", idSolicitante);

                    // Se usa OdbcType.Binary para asegurar que el LONGBLOB se guarde correctamente
                    cmd3.Parameters.Add("?", OdbcType.Binary).Value = (object)fotografia ?? DBNull.Value;
                    cmd3.Parameters.Add("?", OdbcType.Binary).Value = (object)firma ?? DBNull.Value;

                    cmd3.ExecuteNonQuery();

                    // Si todo salió bien, guardamos los cambios
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("Error en la base de datos: " + ex.Message);
                }
            }
        }














        public DataTable BuscarPorDPI(string dpi)
        {
            using (OdbcConnection conn = con.AbrirConexion())
            {
                // Usamos nombres completos de tabla para evitar el error "no pertenece a la tabla"
                string sql = @"SELECT 
                        s.Cmp_Nombre, 
                        s.Cmp_Apellido, 
                        s.Cmp_Sexo, 
                        s.Cmp_Fecha_Nacimiento, 
                        b.fotografia, 
                        b.firma 
                       FROM tbl_solicitante s
                       LEFT JOIN tbl_biometricos b ON s.pk_solicitante_id = b.fk_solicitante_id
                       WHERE s.Cmp_DPI = ?";

                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.AddWithValue("?", dpi);

                OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }








    }
}

