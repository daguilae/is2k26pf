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
    public partial class Frm_Pago_Cheque : Form
    {

        private int iIdPago;
        private decimal gMonto;
        public Frm_Pago_Cheque(int idPago, decimal monto)
        {
            InitializeComponent();
            iIdPago = idPago;
            gMonto = monto;
            fun_PrecargarDatos();

        }
        private void fun_PrecargarDatos()
        {
            Txt_Monto_Total.Text = $"Q { gMonto.ToString("F2")}";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
