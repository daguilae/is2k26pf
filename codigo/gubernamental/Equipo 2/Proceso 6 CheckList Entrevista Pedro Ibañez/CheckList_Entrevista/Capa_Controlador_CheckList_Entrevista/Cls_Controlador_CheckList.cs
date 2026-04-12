using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_CheckList_Entrevista;
namespace Capa_Controlador_CheckList_Entrevista
{
    public class Cls_Controlador_CheckList
    {
        Cls_Sentencias_Preguntas Dao = new Cls_Sentencias_Preguntas();

        public string sMensaje = "";

        public DataTable fun_datos_pregunta()
        {
            DataTable dtPreguntas = Dao.fn_obtener_preguntas();

            return dtPreguntas;
        }

        public DataTable fun_CargarIdsPreguntas()
        {
            DataTable dtIdPreg = Dao.fun_ObtenerIdsPregunta();
            return dtIdPreg;
        }

        public DataTable fun_ConsultarPorIdPreguntas(int iIdPregunta)
        {

            DataTable dtPreguntasFiltradas = Dao.fun_ObtenerPreguntaPorID(iIdPregunta);

            if (dtPreguntasFiltradas.Rows.Count == 0)
            {
                sMensaje = "No se encontraron resultados";
                return null;
            }

            return dtPreguntasFiltradas;
        }

        public DataTable fun_ConsultarPorNVPreguntas(int iPreguntaNV)
        {

            DataTable dtPreguntasFiltradasNV = Dao.fun_ObtenerPreguntaPorNV(iPreguntaNV);

            if (dtPreguntasFiltradasNV.Rows.Count == 0)
            {
                sMensaje = "No se encontraron resultados";
                return null;
            }

            return dtPreguntasFiltradasNV;
        }
    }
}
