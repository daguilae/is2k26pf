using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo_Ventas
{
    public class Cls_Asignacion_Clientes
    {
        public int FkIdVendedor { get; set; }
        public int FkIdCliente { get; set; }
        public Cls_Asignacion_Clientes() { }
        public Cls_Asignacion_Clientes(int iFkIdVendedor, int iFkIdCliente)
        {
            FkIdVendedor = iFkIdVendedor;
            FkIdCliente = iFkIdCliente;
        }
    }
}
