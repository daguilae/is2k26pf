using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Plan;
using System.Data;
using Capa_Controlador_Seguridad;

namespace Capa_Controlador_Plan
{
    public class Cls_Controlador_Ordenes
    {
        Cls_Sentencias_Ordenes modelo = new Cls_Sentencias_Ordenes();

        //Arón Ricardo Esquit Silva 0901-22-13036  17/5/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();



        public DataTable listarOrdenes()
        {
            return modelo.obtenerOrdenesRecibidas();
        }


        public DataTable listarEstados()
        {
            return modelo.obtenerEstados();
        }


        public DataTable filtrarMateriales(
            int idOrden)
        {
            return modelo.obtenerMaterialPorOrden(
                idOrden);
        }

        public DataTable obtenerOrdenesProduccionPorOrden(int idOrden)
        {
            return modelo.obtenerOrdenesProduccionPorOrden(
                idOrden);
        }

        public void modificarOrdenProduccion(
            int idOrden,
            int idMaterial,
            int idEstado,
            decimal cantidad,
            DateTime fechaInicio,
            DateTime fechaFin)
        {
            modelo.modificarOrdenProduccion(
                idOrden,
                idMaterial,
                idEstado,
                cantidad,
                fechaInicio,
                fechaFin);

            gCtrlBitacora.RegistrarAccion(
                Cls_Usuario_Conectado.iIdUsuario,
                719,
                $"Modificó la orden de producción '{idOrden}' del material '{idMaterial}' con cantidad '{cantidad}'",
                true
            );
        }


    }
}
