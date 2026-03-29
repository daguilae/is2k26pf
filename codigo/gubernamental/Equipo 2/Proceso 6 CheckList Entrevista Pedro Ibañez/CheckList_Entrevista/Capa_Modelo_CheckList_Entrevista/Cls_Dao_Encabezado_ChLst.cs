using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
namespace Capa_Modelo_CheckList_Entrevista
{
    public class Cls_Dao_Encabezado_ChLst
    {
        Cls_ConexionMYSQL conexion = new Cls_ConexionMYSQL();
        // Obtener IDs de CheckList
        public DataTable fun_ObtenerIdsCheckList()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_checklist_id FROM tbl_checklist_entrevista; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los IDs de CheckList: " + ex.Message);
            }

            return dtResultado;
        }

        //================================================
        // Obtener DPI
        public DataTable fun_ObtenerDPI()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_solicitante_id,
                    CONCAT(pk_solicitante_id, ' - ', Cmp_Nombre,Cmp_Apellido) AS Solicitante
                    FROM tbl_solicitante; ";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();
                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    using (OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd))
                    {
                        oDa.Fill(dtResultado);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los Solicitantes: " + ex.Message);
            }

            return dtResultado;
        }

        //================================================
        // Insertar Encabezado
        public bool fun_InsertarCheckList(
    int fkSolicitante,
    DateTime fechaEntrevista,
    int cantidadPreguntas,
    bool estadoEntrevista)
        {
            bool bResultado = false;

            string sQuery = @"INSERT INTO tbl_checklist_entrevista
                      (fk_solicitante_id,
                       Cmp_Fecha_Entrevista,
                       Cmp_Cantidad_Preguntas,
                       Cmp_Estado_Entrevista)
                      VALUES (?, ?, ?, ?);";

            try
            {
                using (OdbcConnection oConn = conexion.oConexion())
                {
                    oConn.Open();

                    using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                    {
                        // IMPORTANTE: ODBC usa parámetros por orden
                        oCmd.Parameters.AddWithValue("@fk", fkSolicitante);
                        oCmd.Parameters.AddWithValue("@fecha", fechaEntrevista);
                        oCmd.Parameters.AddWithValue("@cantidad", cantidadPreguntas);
                        oCmd.Parameters.AddWithValue("@estado", estadoEntrevista ? 1 : 0);

                        int filasAfectadas = oCmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                            bResultado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar CheckList: " + ex.Message);
            }

            return bResultado;
        }
        //================================================

    }
}
