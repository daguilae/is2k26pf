using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Pago_Tarjeta : Form
    {
        private int gIdPago;
        private decimal gMonto;

        public Frm_Pago_Tarjeta(int iIdPago, decimal deMonto)
        {
            InitializeComponent();
            gIdPago = iIdPago;
            gMonto = deMonto;
        }
    }
}
