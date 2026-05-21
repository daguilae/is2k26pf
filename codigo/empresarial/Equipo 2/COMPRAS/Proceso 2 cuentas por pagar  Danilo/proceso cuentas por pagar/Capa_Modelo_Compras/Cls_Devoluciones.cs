using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Compras
{
    public class Cls_Devoluciones
    {
        public int IdCompra { get; set; }
        public int IdProveedor { get; set; }
        public int? IdCuentaPorPagar { get; set; }

        public DateTime FechaDevolucion { get; set; }
        public string Motivo { get; set; }
        public string TipoDevolucion { get; set; }
        public decimal ValorMonetario { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    }
}
