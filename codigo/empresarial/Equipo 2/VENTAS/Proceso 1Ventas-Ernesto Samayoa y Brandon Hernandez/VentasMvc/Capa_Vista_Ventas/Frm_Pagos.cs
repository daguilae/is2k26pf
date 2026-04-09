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
    public partial class Frm_Pagos : Form
    {
        public Frm_Pagos()
        {
            InitializeComponent();
            fun_CargarMetodosPago();
        }
        private void fun_CargarMetodosPago()
        {
            Cbo_MetodoPago.Items.Clear();
            Cbo_MetodoPago.Items.Add("Tarjeta");
            Cbo_MetodoPago.Items.Add("Efectivo");
            Cbo_MetodoPago.Items.Add("Transferencia");
            Cbo_MetodoPago.Items.Add("Cheque");
            Cbo_MetodoPago.SelectedIndex = -1;
        }

        private void fun_CargarEstadosPago()
        {
            Cbo_Estado.Items.Clear();
            Cbo_Estado.Items.Add("Pendiente");
            Cbo_Estado.Items.Add("Pagado");
            Cbo_Estado.Items.Add("Cancelado");
            Cbo_Estado.SelectedIndex = -1;
        }

        private void fun_LimpiarCampos()
        {
            Cbo_Folio.SelectedIndex = -1;
            Cbo_MetodoPago.SelectedIndex = -1;
            Cbo_Estado.SelectedIndex = -1;
            Txt_Monto.Clear();
            Dtp_Fecha_Pago.Value = DateTime.Now;
        }

        private void Cbo_MetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AbrirSubformulario(string sMetodo, int iIdPago, decimal deMonto)
        {
            switch (sMetodo)
            {
                case "Tarjeta":
                    new Frm_Pago_Tarjeta(iIdPago, deMonto).ShowDialog();
                    break;
                case "Efectivo":
                    new Frm_pago_efectivo(iIdPago, deMonto).ShowDialog();
                    break;
                case "Transferencia":
                    new Frm_Pago_Transferencia(iIdPago, deMonto).ShowDialog();
                    break;
                case "Cheque":
                    new Frm_Pago_Cheque(iIdPago, deMonto).ShowDialog();
                    break;
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)

        {
            string sMet = Cbo_MetodoPago.SelectedItem?.ToString();
            AbrirSubformulario(sMet, 1, 100);
        }
    }

}
