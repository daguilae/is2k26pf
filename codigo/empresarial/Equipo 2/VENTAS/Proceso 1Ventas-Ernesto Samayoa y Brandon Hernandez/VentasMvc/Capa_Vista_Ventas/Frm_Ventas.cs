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
    public partial class Frm_Ventas : Form
    {
        private int _idVenta = 0;
        private int _idCliente = 0;
        private decimal _montoTotal = 0;
        public Frm_Ventas()
        {
            InitializeComponent();
     
    }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            /*if (_idVenta == 0)
            {
                MessageBox.Show("Primero guarde la venta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            using (var frmPagos = new Frm_Pagos(
                tipo: Cls_TipoOperacion.Pago,
                idCuentaPorCobrar: _idVenta,
                monto: _montoTotal,
                motivo: string.Empty
            ))
            {
                frmPagos.ShowDialog();
            }
        }
    }
}
