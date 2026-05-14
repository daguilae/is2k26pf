using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Factura;

namespace Capa_Controlador_Factura
{
    public class Cls_Controlador_Detalle
    {
        Cls_Sentencias_Detalle detalle = new Cls_Sentencias_Detalle();

        public DataTable fun_DatosDetalle(int iCodigoFactura)
        {
            return detalle.fun_ObtenerDatosFactura(iCodigoFactura);
        }

    }
}
