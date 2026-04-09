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
    public partial class Frm_pago_efectivo : Form
    {
        private int gIdPago;
        private decimal gMontoPago;
        public Frm_pago_efectivo(int idPagoPrincipal, decimal monto)
        {
            InitializeComponent();
            gIdPago = idPagoPrincipal;
            gMontoPago = monto;
        }
    }
}
