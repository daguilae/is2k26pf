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
    public partial class Frm_Devolucion : Form
    {
        private int _idCxC = 0;
    
      
        public Frm_Devolucion()
        {
            InitializeComponent();

        }
    
        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            /*if (_idCxC == 0)
            {
                MessageBox.Show("Seleccione una venta válida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } */

            if (!decimal.TryParse(Txt_Devolucion.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Motivo.Text))
            {
                MessageBox.Show("Ingrese el motivo de la devolución.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var frmPagos = new Frm_Pagos(
            tipo: Cls_TipoOperacion.Devolucion,
            idCuentaPorCobrar: _idCxC,
                 monto: monto,
             motivo: Txt_Motivo.Text.Trim()
))
            {
                frmPagos.ShowDialog();
            }
        }
    }
}
