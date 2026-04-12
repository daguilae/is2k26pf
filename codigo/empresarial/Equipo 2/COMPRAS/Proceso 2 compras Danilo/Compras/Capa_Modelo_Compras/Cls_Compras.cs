using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Compras
{
    public class Cls_Compras
    {
        public int Pk_Id_Factura { get; set; }
        public string Cmp_Numero_Factura { get; set; }
        public DateTime Cmp_Fecha_Factura { get; set; }
        public int Fk_Id_Proveedor { get; set; }
        public int Cmp_Id_Orden_Compra { get; set; }
        public float Cmp_Total_Compra { get; set; }
        public float Cmp_Adelanto { get; set; }
        public float Cmp_Saldo_Pendiente { get; set; }
        public string Cmp_Estado_Pago { get; set; }
    }
}