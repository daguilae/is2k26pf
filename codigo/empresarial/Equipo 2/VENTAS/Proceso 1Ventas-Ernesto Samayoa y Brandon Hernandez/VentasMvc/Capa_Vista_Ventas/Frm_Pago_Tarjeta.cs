using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Pago_Tarjeta : Form
    {
        private int gIdPago;
        private decimal gMonto;
        Cls_CXCDetalle_Controlador controlador = new Cls_CXCDetalle_Controlador();
        private int iIdCXC;
        private int iIdcliente;
        public Frm_Pago_Tarjeta(int iIdPago, decimal monto,int _idCXC)
        {
            InitializeComponent();
            gIdPago = iIdPago;
            gMonto = monto;
            iIdCXC = _idCXC;
            fun_PrecargarDatos();
            iIdcliente = controlador.ObtenerIdClientePorCXC(iIdCXC);

            if (iIdcliente == 0)
            {
                MessageBox.Show("No se encontró el cliente para esta CXC.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
        private void fun_PrecargarDatos()
        {
            Txt_Monto_Total.Text = $"Q { gMonto.ToString("F2")}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Ventas_Click(object sender, EventArgs e)
        {
            try { 
            if (string.IsNullOrWhiteSpace(Txt_Nombre_Titular.Text))
            {
                MessageBox.Show("Ingrese el nombre del titular.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Nombre_Titular.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Numero_Tarjeta.Text) || Txt_Numero_Tarjeta.Text.Length < 13)
            {
                MessageBox.Show("Ingrese un número de tarjeta válido (mínimo 13 dígitos).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Numero_Tarjeta.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Fecha_Vencimiento.Text))
            {
                MessageBox.Show("Ingrese la fecha de vencimiento.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Fecha_Vencimiento.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_Cvc.Text) || Txt_Cvc.Text.Length < 3)
            {
                MessageBox.Show("Ingrese un CVC válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Cvc.Focus();
                return;
            }

            if (!decimal.TryParse(Txt_Monto_Pagar.Text.Replace("Q ", ""), out decimal montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Monto_Pagar.Focus();
                return;
            }
            string numerovoucher=controlador.GenerarVoucher();

            decimal saldoPendiente = gMonto - montoPago;
            bool resultado = controlador.RegistrarPago(
                    idCuentaPorCobrar: iIdCXC,
                    idCliente: iIdcliente,
                    numeroDocumento: numerovoucher,
                    tipoPago: "Pago Tarjeta",
                    montoPagado: montoPago,
                    saldoPendiente: saldoPendiente
                );
            if (resultado)
            {
                if (saldoPendiente > 0)
                {
                    MessageBox.Show(
                        $"No. Recibo: {numerovoucher}\n" +
                        $"Titular: {Txt_Nombre_Titular.Text}\n" +
                        $"Tarjeta: ****{Txt_Numero_Tarjeta.Text.Substring(Txt_Numero_Tarjeta.Text.Length - 4)}\n" +
                        $"Pago recibido: Q {montoPago:F2}\n" +
                        $"Saldo pendiente: Q {saldoPendiente:F2}",
                        "Pago Parcial",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        $"No. Recibo: {numerovoucher}\n" +
                        $"Titular: {Txt_Nombre_Titular.Text}\n" +
                        $"Tarjeta: ****{Txt_Numero_Tarjeta.Text.Substring(Txt_Numero_Tarjeta.Text.Length - 4)}\n" +
                        $"Pago recibido: Q {montoPago:F2}",
                        "Pago Completo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.Close();
            }
        }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
            

        private void Txt_Numero_Tarjeta_TextChanged(object sender, EventArgs e)
        {
            // Validar que solo sean números
            string texto = Txt_Numero_Tarjeta.Text;
            if (!string.IsNullOrEmpty(texto) && !texto.All(char.IsDigit))
            {
                MessageBox.Show("Solo ingrese números en el número de tarjeta.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Numero_Tarjeta.Clear();
            }
        }

        private void Txt_Cvc_TextChanged(object sender, EventArgs e)
        {
            string texto = Txt_Cvc.Text;
            if (!string.IsNullOrEmpty(texto))
            {
                if (!texto.All(char.IsDigit) || texto.Length > 4)
                {
                    MessageBox.Show("CVC debe contener 3 o 4 dígitos.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Cvc.Clear();
                }
            }
            }
    }
}
