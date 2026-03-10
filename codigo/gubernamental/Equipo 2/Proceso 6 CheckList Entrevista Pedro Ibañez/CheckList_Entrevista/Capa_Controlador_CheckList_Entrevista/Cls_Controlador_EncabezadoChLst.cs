using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_CheckList_Entrevista;

namespace Capa_Controlador_CheckList_Entrevista
{
    public class Cls_Controlador_EncabezadoChLst
    {
        Cls_Dao_Encabezado_ChLst Dao = new Cls_Dao_Encabezado_ChLst();

        public string sMensaje = "";

        public DataTable fun_CargarIdsEncabezado()
        {
            DataTable dtIdChLst = Dao.fun_ObtenerIdsCheckList();
            return dtIdChLst;
        }

        public DataTable fun_CargarIdsSolicitante()
        {
            DataTable dtIdSolt = Dao.fun_ObtenerDPI();
            return dtIdSolt;
        }

        public bool fun_InsertarEncabezado(int fkSolicitante,
    DateTime fechaEntrevista,
    int cantidadPreguntas,
    bool estadoEntrevista)
        {
            // Validar solicitante
            if (fkSolicitante <= 0)
            {
                sMensaje = "Debe seleccionar un solicitante.";
                return false;
            }

            // Validar fecha
            //if (fechaEntrevista == DateTime.MinValue)
            //{
            //   sMensaje = "Debe ingresar una fecha válida.";
            //    return false;
            //}

            // Validar cantidad de preguntas
            if (cantidadPreguntas <= 0)
            {
                sMensaje = "La cantidad de preguntas debe ser mayor a 0.";
                return false;
            }

            sMensaje = "";
            return true;
        }
    }
}
