using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Contsancias
{
    class Cls_datos
    {

        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int IdTramite { get; set; }
        public string NombreTramite { get; set; }

        public string CodigoConstancia { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
    }
}
