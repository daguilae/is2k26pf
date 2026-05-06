using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Expl_Mat;

namespace Capa_Controlador_Expl_Mat
{
    public class Cls_Controlador_Expl
    {
        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580
        private readonly Cls_Sentencias_Expl_e_Impl sentencias
                       = new Cls_Sentencias_Expl_e_Impl();

        public DataTable ObtenerExplosiones()
        {
            return sentencias.ObtenerExplosiones();
        }

        public DataTable FiltrarPorId(string idExplosion)
        {
            return sentencias.FiltrarPorId(idExplosion);
        }

        public DataTable FiltrarPorFechas(string fechaInicio, string fechaFin)
        {
            return sentencias.FiltrarPorFechas(fechaInicio, fechaFin);
        }

        // Agrega esto dentro de la clase Cls_Controlador_Expl
        // (después de los métodos del encabezado)

        private readonly Cls_Sentencias_Expl sentenciasDetalle
                       = new Cls_Sentencias_Expl();

        public DataTable ObtenerOrdenesProduccion()
        {
            return sentenciasDetalle.ObtenerOrdenesProduccion();
        }

        public DataTable ObtenerInfoOrden(int idOrden)
        {
            return sentenciasDetalle.ObtenerInfoOrden(idOrden);
        }

        public DataTable ObtenerProductosOrden(int idOrden)
        {
            return sentenciasDetalle.ObtenerProductosOrden(idOrden);
        }

        public DataTable ObtenerBOMParaExplosion(int idOrden)
        {
            return sentenciasDetalle.ObtenerBOMParaExplosion(idOrden);
        }

        public int GuardarExplosion(int idOrden)
        {
            return sentenciasDetalle.GuardarExplosion(idOrden);
        }

        public bool GuardarDetalleExplosion(int idExplosion, DataTable detalle)
        {
            return sentenciasDetalle.GuardarDetalleExplosion(idExplosion, detalle);
        }

        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580






        //DANIELA SALGUERO

        //DANIELA SALGUERO


    }
}