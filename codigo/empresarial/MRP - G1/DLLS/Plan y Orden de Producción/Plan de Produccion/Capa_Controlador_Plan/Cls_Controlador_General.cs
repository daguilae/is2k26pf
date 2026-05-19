using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Plan;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_Plan
{
    public class Cls_Controlador_General
    {
        Cls_Sentencias sentencias = new Cls_Sentencias();
        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();


        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public int pro_GuardarPlanCompleto(int iNoPedido, string sDescripcion, int iEstadoPlan, DateTime fechaPlan,
            List<Cls_Sentencia_OrdenTemp> listaOrdenes)
        {
            int idPlan = sentencias.creaciónCompleta(
                iNoPedido,
                sDescripcion,
                iEstadoPlan,
                fechaPlan,
                listaOrdenes);

            if (idPlan > 0)
            {
                gCtrlBitacora.RegistrarAccion(
                    Cls_Usuario_Conectado.iIdUsuario,
                    718,
                    $"Registró un nuevo plan maestro '{idPlan}' para el pedido '{iNoPedido}'",
                    true
                );
            }

            return idPlan;
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

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        public void pro_ModificarPlan(int iCodigoPlan, string sDescripcion, int iEstado, DateTime fechaPlan)
        {
            sentencias.pro_ModificarPlan(iCodigoPlan, sDescripcion, iEstado, fechaPlan);

            gCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                718,
                $"Modificó el plan maestro '{iCodigoPlan}'",
                true
            );
        }
    }
}
