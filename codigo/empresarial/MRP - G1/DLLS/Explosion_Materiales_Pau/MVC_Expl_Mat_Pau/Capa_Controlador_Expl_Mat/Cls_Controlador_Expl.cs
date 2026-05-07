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

        private readonly Cls_Sentencias_Expl sentenciasDetalle
                       = new Cls_Sentencias_Expl();

        public DataTable ObtenerOrdenesRecibidas()
        {
            return sentenciasDetalle.ObtenerOrdenesRecibidas();
        }

        public DataTable ObtenerInfoOrdenRecibida(int idOrden)
        {
            return sentenciasDetalle.ObtenerInfoOrdenRecibida(idOrden);
        }

        public DataTable ObtenerProductosOrdenRecibida(int idOrden)
        {
            return sentenciasDetalle.ObtenerProductosOrdenRecibida(idOrden);
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
        public DataTable ObtenerImplosion(int idOrden)
        {
            return sentencias.ObtenerDetalleExplosion(idOrden);
        }

        public bool GenerarOrdenMaterial(int idOrden, DataTable faltantes)
        {
            return sentencias.GuardarOrdenMaterial(idOrden, faltantes);
        }

        public bool OrdenYaGenerada(int idOrden)
        {
            return sentencias.OrdenYaGenerada(idOrden);
        }

        //DANIELA SALGUERO
    }
}