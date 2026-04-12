using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
namespace Capa_Modelo_CheckList_Entrevista
{
    public class Cls_Sentencias_Preguntas
    {
        Cls_ConexionMYSQL conexion = new Cls_ConexionMYSQL();

        // ==========================================================================================
        // Cargar Datos Preguntas DGV
        public DataTable fn_obtener_preguntas()
        {
            DataTable dt_preguntas = new DataTable();

            OdbcConnection conn = conexion.oConexion();

            try
            {
                string sSql = @"SELECT 
                                pk_pregunta_id, 
                                Cmp_Enunciado_Pregunta, 
                                Cmp_Nivel 
                                FROM tbl_preguntas;";

                OdbcDataAdapter da = new OdbcDataAdapter(sSql, conn);

                da.Fill(dt_preguntas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener preguntas: " + ex.Message);
            }
            finally
            {
                conexion.oDesconexion(conn);
            }

            return dt_preguntas;
        }

        // ==========================================================================================
        // Obtener IDs de pregunta
        public DataTable fun_ObtenerIdsPregunta()
        {
            DataTable dtResultado = new DataTable();
            string sQuery = @"SELECT 
                    pk_pregunta_id,
                    CONCAT(pk_pregunta_id, ' - ', Cmp_Enunciado_Pregunta) AS PreguntaCompleta
                    FROM tbl_preguntas; ";

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
                Console.WriteLine("Error al obtener los IDs de Pregunta: " + ex.Message);
            }

            return dtResultado;
        }

        // ==========================================================================================
        // Obtener Filtrar Pregunta
        public DataTable fun_ObtenerPreguntaPorID(int iIdPregunta)
        {
            DataTable dtResultado = new DataTable();

            string sQuery = @"SELECT *
                      FROM tbl_preguntas
                      WHERE pk_pregunta_id = ? ;";

            using (OdbcConnection oConn = conexion.oConexion())
            {
                oConn.Open();

                using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                {
                    oCmd.Parameters.AddWithValue("@id1", iIdPregunta);

                    OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd);
                    oDa.Fill(dtResultado);
                }
            }

            return dtResultado;
        }

        // ==========================================================================================
        // Obtener Filtrar Pregunta por NV
        public DataTable fun_ObtenerPreguntaPorNV(int iPreguntaNV)
        {
            DataTable dtResultado = new DataTable();

            string sQuery = @"SELECT *
                      FROM tbl_preguntas
                      WHERE Cmp_Nivel = ? ;";

            using (OdbcConnection oConn = conexion.oConexion())
            {
                oConn.Open();

                using (OdbcCommand oCmd = new OdbcCommand(sQuery, oConn))
                {
                    oCmd.Parameters.AddWithValue("@nivel", iPreguntaNV);

                    OdbcDataAdapter oDa = new OdbcDataAdapter(oCmd);
                    oDa.Fill(dtResultado);
                }
            }

            return dtResultado;
        }
    }
}
