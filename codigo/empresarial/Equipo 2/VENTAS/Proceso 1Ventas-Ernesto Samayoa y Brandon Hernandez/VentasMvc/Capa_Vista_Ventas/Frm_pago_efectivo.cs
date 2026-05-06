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
        private decimal gMonto;

        public Frm_pago_efectivo(int idPagoPrincipal, decimal monto)
        {
            InitializeComponent();
            gIdPago = idPagoPrincipal;
            gMonto = monto;
            fun_PrecargarDatos();
        }
        private void fun_PrecargarDatos()
        {
            Txt_Monto_Total.Text = $"Q { gMonto.ToString("F2")}";

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Dinero_Recibido_TextChanged(object sender, EventArgs e)
        {
            
            if (decimal.TryParse(Txt_Dinero_Recibido.Text, out decimal efectivoIngresado))
            {
                if (efectivoIngresado < gMonto)
                {
                    Txt_Vuelto.Text = "";

                }
                else
                {
                    Txt_Vuelto.Text= (efectivoIngresado - gMonto).ToString("F2");
                }
                
                
            }




        }

        private void Btn_Guardar_Ventas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Dinero_Recibido.Text))
            {
                MessageBox.Show("El campo Dinero Recibido está vacío.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Dinero_Recibido.Focus();
                return;
            }
        }
    }
    }

