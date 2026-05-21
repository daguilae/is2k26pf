using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo__DispoInve
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public string CodigoMaterial { get; set; }
        public string NombreMaterial { get; set; }
        public string TipoInventario { get; set; }
        public string NombreAlmacen { get; set; }
        public string UnidadMedida { get; set; }
        public decimal CantidadDisponible { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal CostoUnitario { get; set; }
        public DateTime FechaActualizacion { get; set; }

        // Calculado en memoria, no viene de BD
        public bool BajoStock => CantidadDisponible < StockMinimo;
    }
}
