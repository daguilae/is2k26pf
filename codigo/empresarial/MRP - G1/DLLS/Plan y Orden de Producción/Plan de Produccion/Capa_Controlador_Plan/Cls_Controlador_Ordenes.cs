using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Plan;
using System.Data;

namespace Capa_Controlador_Plan
{
    public class Cls_Controlador_Ordenes
    {
        Cls_Sentencias_Ordenes modelo = new Cls_Sentencias_Ordenes();


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
        }


    }
}
