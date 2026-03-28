using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModelo_Citas
{
    public class Cls_CitasDAO
    //Brandon Hernandez 0901-22-9663 21/02/2025 
    //Funcion de insertar  citas 
    {
        private readonly Cls_Conexion prConexion = new Cls_Conexion();
        private static readonly string SQL_SELECT = @"
            SELECT 
                Pk_Id_cita, 
                Fk_Id_sede,
                Cmp_fecha_hora
                Cmp_estado_cita
            FROM Tbl_Cita";
        private static readonly string SQL_INSERT = @"
            INSERT INTO Tbl_Cita 
                (Fk_Id_sede, Fk_Id_sede, Cmp_fecha_hora, Cmp_estado_cita)
            VALUES (?, ?, ?, ?)";



        public DataTable fun_Obtener_sedes()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"
            SELECT 
            Pk_Id_sede,
            Cmp_Direccion
            FROM Tbl_sede;";
            using (OdbcConnection conn = prConexion.conexion())
            using (OdbcCommand cmd = new OdbcCommand(sQuery, conn))
            using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
            {
                da.Fill(dtResultado);
            }
            return dtResultado;
        }
        private const string SQL_INSERT_CITA_DEFAULT_ESTADO =
    "INSERT INTO Tbl_Cita (Fk_Id_sede, Cmp__fecha_hora) VALUES (?, ?)";
        public bool bInsertar_Citas(Cls_Citas ClsCitas)
        {
            using (OdbcConnection conn = prConexion.conexion())
            {
                try
                {
                    using (OdbcCommand cmd = new OdbcCommand(SQL_INSERT_CITA_DEFAULT_ESTADO, conn))
                    {
                        // ODBC usa parámetros posicionales con '?', el orden es CRÍTICO.
                        cmd.Parameters.AddWithValue("", ClsCitas.iFk_Id_Sede);
                        cmd.Parameters.AddWithValue("", ClsCitas.dCmp_Fecha_Hora); // DateTime

                        int iFilas = cmd.ExecuteNonQuery();
                        return iFilas > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar Cita: " + ex.Message,
                        "Error de Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }



    }
}

