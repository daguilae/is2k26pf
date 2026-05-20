using System;
using System.Data;
using Capa_Modelo_Factura;

// Paula Daniela Leonardo Paredes - 0901-22-9580
namespace Capa_Controlador_Factura
{
    public class Cls_Controlador_Fac
    {
        private readonly Cls_Sentencias_Encabezado sentencias
                       = new Cls_Sentencias_Encabezado();

        public DataTable ObtenerFacturas()
        {
            return sentencias.ObtenerFacturas();
        }

        public DataTable FiltrarPorNumero(string noFactura)
        {
            return sentencias.FiltrarPorNumero(noFactura);
        }

        public DataTable FiltrarPorFecha(string fecha)
        {
            return sentencias.FiltrarPorFecha(fecha);
        }

        public DataTable FiltrarPorOrden(string idOrden)
        {
            return sentencias.FiltrarPorOrden(idOrden);
        }

        public DataTable ObtenerOrdenesRecibidas()
        {
            return sentencias.ObtenerOrdenesRecibidas();
        }
    }
}