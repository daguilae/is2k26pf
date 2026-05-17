using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Plan;

namespace Capa_Controlador_Plan
{
    public class Cls_Controlador_General
    {
        Cls_Sentencias sentencias = new Cls_Sentencias();

        public int pro_GuardarPlanCompleto(int iNoPedido, string sDescripcion, int iEstadoPlan, DateTime fechaPlan,
            List<Cls_Sentencia_OrdenTemp> listaOrdenes)
        {
            return sentencias.creaciónCompleta(iNoPedido, sDescripcion, iEstadoPlan, fechaPlan, listaOrdenes);
        }

        public DataTable fun_ObtenerCodigosPlan()
        {
            return sentencias.funCodigosPlan();
        }

        public DataTable fun_DatosPlan(int? iCodigoPlan = null, int? iEstadoPlan = null, DateTime? fechaInicio = null,
            DateTime? fechaFin = null)
        {
            return sentencias.fun_ObtenerDatosPlan(iCodigoPlan, iEstadoPlan, fechaInicio, fechaFin);
        }

        public void pro_ModificarPlan(int iCodigoPlan, string sDescripcion, int iEstado, DateTime fechaPlan)
        {
            sentencias.pro_ModificarPlan(iCodigoPlan, sDescripcion, iEstado, fechaPlan);
        }
    }
}
