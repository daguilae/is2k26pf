using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Mov_Inv
{
    public class Cls_Constructor_Encabezado
    {
        public int ID { get; set; }
        public int IdTipoMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
