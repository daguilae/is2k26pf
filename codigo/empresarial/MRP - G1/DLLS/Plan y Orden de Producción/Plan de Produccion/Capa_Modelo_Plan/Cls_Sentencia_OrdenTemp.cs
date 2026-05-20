using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Plan
{
    public class Cls_Sentencia_OrdenTemp
    {
        public int NoOrden { get; set; }
        public int IdMaterial { get; set; }

        public string Material { get; set; }

        public int IdEstado { get; set; }

        public string Estado { get; set; }

        public decimal Cantidad { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
    }
}
