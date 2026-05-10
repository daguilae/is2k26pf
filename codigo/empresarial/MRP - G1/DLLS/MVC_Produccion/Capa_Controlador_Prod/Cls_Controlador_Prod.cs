using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Prod;

namespace Capa_Controlador_Prod
{
    public class Cls_Controlador_Prod
    {
        private readonly Cls_Sentencias_Prod sentencias = new Cls_Sentencias_Prod();
        private readonly Cls_Sentencias_Prod sentenciasDetalle = new Cls_Sentencias_Prod();
        private readonly Cls_Sentencias_CI sentenciasCI = new Cls_Sentencias_CI();


        public DataTable ObtenerOrdenesProduccion()
        {
            return sentencias.ObtenerOrdenesProduccion();
        }

       /* public DataTable ObtenerInfoOrdenRecibida(int idOrden)
        {
            return sentenciasDetalle.ObtenerInfoOrdenRecibida(idOrden);
        }

        public DataTable ObtenerProductosOrdenRecibida(int idOrden)
        {
            return sentenciasDetalle.ObtenerProductosOrdenRecibida(idOrden);
        }*/

        public DataTable ObtenerManoObra(int idOrden)
        {
            return sentencias.ObtenerManoObra(idOrden);
        }

        public bool GuardarManoObra(int idOrden, int idEmpleado, decimal horas, decimal costoHora)
        {
            return sentencias.GuardarManoObra(idOrden, idEmpleado, horas, costoHora);
        }

        public bool EliminarManoObra(int idManoObra)
        {
            return sentencias.EliminarManoObra(idManoObra);
        }

        public DataTable ObtenerCostosProduccion(int idOrden)
        {
            return sentencias.ObtenerCostosProduccion(idOrden);
        }
        public DataTable ObtenerEmpleados()
        {
            return sentencias.ObtenerEmpleados();
        }

        public DataTable ObtenerCostosIndirectos(int idOrden)
        {
            return sentenciasCI.ObtenerCostosIndirectos(idOrden);
        }

        public bool GuardarCostoIndirecto(int idOrden, string concepto, decimal monto, string descripcion)
        {
            return sentenciasCI.GuardarCostoIndirecto(idOrden, concepto, monto, descripcion);
        }

        public bool EliminarCostoIndirecto(int idCosto)
        {
            return sentenciasCI.EliminarCostoIndirecto(idCosto);
        }
    }
}
