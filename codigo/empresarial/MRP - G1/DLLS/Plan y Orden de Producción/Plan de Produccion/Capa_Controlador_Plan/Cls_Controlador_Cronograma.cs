using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Plan;

namespace Capa_Controlador_Plan
{
    public class Cls_Controlador_Cronograma
    {
        Cls_Sentencias_Cronograma sentenciasCronograma = new Cls_Sentencias_Cronograma();

        public DataTable fun_OrdenesPlan(int iCodigoPlan)
        {
            return sentenciasCronograma.fun_ObtenerDatosPlan(iCodigoPlan);
        }


        public DataTable fun_OrdenesRecibidas()
        {
            return sentenciasCronograma.fun_ObtenerOrdenesRecibidas();
        }

        public DataTable fun_EstadosPlan()
        {
            return sentenciasCronograma.fun_EstadosPlan();
        }

        public DataTable fun_NoOrden(int iCodigoPlan)
        {
            return sentenciasCronograma.fun_ObtenerOrdenesProduccion(iCodigoPlan);
        }

        public DataTable fun_DatosFase(int iCodigoOrden)
        {
            return sentenciasCronograma.fun_ObtenerFasesProducción(iCodigoOrden);
        }

        public DataTable fun_DatosEmpleado()
        {
            return sentenciasCronograma.fun_ObtenerEmpleados();
        }

        public DataTable fun_DatosEstados()
        {
            return sentenciasCronograma.fun_ObtenerEstados();
        }

        public DataTable fun_ObtenerCronograma(int iCodigoOrden)
        {
            return sentenciasCronograma.fun_ObtenerCronograma(iCodigoOrden);
        }

        public void proGuardarCronograma(int iCodigoOrden, List<(int iCodigoFase, int iEmpleado, DateTime FechaInicio,
                    DateTime FechaFin, int iCantidadPersonal, int iEstadoFase)> cronogramaFases)
        {
            sentenciasCronograma.pro_GuardarCronograma(iCodigoOrden, cronogramaFases);
        }
    }
}
