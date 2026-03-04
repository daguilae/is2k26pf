using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Citas
{
    public class Cls_Modelo_Citas
    {
        public DateTime FechaCita { get; set; }
        public int IdTipoCita { get; set; }
        public int IdHorario { get; set; }
        public int IdSede { get; set; }
        public int IdEstadoCita { get; set; }
        public int IdBoleta { get; set; }
    }
}
