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
    public partial class Frm_Pago_Cheque : Form
    {

        private int iIdPago;
        private decimal gMonto;
        private int iIdCXC;
        private int iIdCliente;
        Cls_CXCDetalle_Controlador controlador = new Cls_CXCDetalle_Controlador(); 
       
        public Frm_Pago_Cheque(int idPago, decimal monto,int _idCXC)
        {
            InitializeComponent();
            iIdPago = idPago;
            gMonto = monto;
            iIdCXC = _idCXC;
            iIdCliente = controlador.ObtenerIdClientePorCXC(iIdCXC);

            if (iIdCliente == 0)
            {
                MessageBox.Show("No se encontró el cliente para esta CXC.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        
        fun_PrecargarDatos();
            fun_precargarBancos();
            fun_CargarEstadosCheque();
        }
        private void fun_precargarBancos()
        {
            try
            {
                Cbo_Bancos.Items.Clear();
                Cbo_Bancos.Items.Add("Banco Industrial");
                Cbo_Bancos.Items.Add("Banrural");
                Cbo_Bancos.Items.Add("Bantrab");
                Cbo_Bancos.Items.Add("BAM");
                Cbo_Bancos.Items.Add("Banco G&T Continental");
                Cbo_Bancos.Items.Add("BAC Credomatic");
                Cbo_Bancos.Items.Add("Banco Promerica");
                Cbo_Bancos.Items.Add("Banco Ficohsa");
                Cbo_Bancos.Items.Add("Banco Internacional");
                Cbo_Bancos.Items.Add("Banco Azteca");
                Cbo_Bancos.Items.Add("Banco de Antigua");
                Cbo_Bancos.Items.Add("Banco Inmobiliario");
                Cbo_Bancos.Items.Add("Vivibanco");
                Cbo_Bancos.Items.Add("Banco Credicorp");
                Cbo_Bancos.Items.Add("Crédito Hipotecario Nacional (CHN)");
                Cbo_Bancos.Items.Add("Banco INV");
                Cbo_Bancos.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error al cargar banco: ");
            }
        }
        private void fun_CargarEstadosCheque()
        {
            Cbo_Estado_Cheque.Items.Add("Pendiente");
            Cbo_Estado_Cheque.Items.Add("Cobrado");
            Cbo_Estado_Cheque.Items.Add("Rechazado");
            Cbo_Estado_Cheque.SelectedIndex = 0; // Por defecto: Pendiente
        }
        private void fun_PrecargarDatos()
        {
            Txt_Monto_Total.Text = $"Q { gMonto.ToString("F2")}";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(Txt_Numero_Cheque.Text))
                {
                    MessageBox.Show("Ingrese el número de cheque.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Numero_Cheque.Focus();
                    return;
                }

                if (Cbo_Bancos.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un banco.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Bancos.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(Txt_Nombre_Titular.Text))
                {
                    MessageBox.Show("Ingrese el nombre del titular.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Nombre_Titular.Focus();
                    return;
                }

                if (Dtp_Fecha_Emision.Value > DateTime.Now)
                {
                    MessageBox.Show("La fecha de emisión no puede ser futura.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Dtp_Fecha_Emision.Focus();
                    return;
                }

                if (Dtp_Fecha_Cobro.Value <= Dtp_Fecha_Emision.Value)
                {
                    MessageBox.Show("La fecha de cobro debe ser posterior a la de emisión.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Dtp_Fecha_Cobro.Focus();
                    return;
                }

                if (Cbo_Estado_Cheque.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un estado de cheque.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Estado_Cheque.Focus();
                    return;
                }

                if (!decimal.TryParse(Txt_Monto_Pagar.Text.Replace("Q ", ""), out decimal montoPago) || montoPago <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Monto_Pagar.Focus();
                    return;
                }

                //GENERAR NÚMERO DE RECIBO
                string numeroCheque = controlador.GenerarCheque();

                decimal saldoPendiente = gMonto - montoPago;
                string banco = Cbo_Bancos.SelectedItem.ToString();
                string estadoCheque = Cbo_Estado_Cheque.SelectedItem.ToString();
                // REGISTRAR PAGO
                bool resultado = controlador.RegistrarPago(
                    idCuentaPorCobrar: iIdCXC,
                    idCliente: iIdCliente,
                    numeroDocumento: numeroCheque,
                    tipoPago: "Cheque",
                    montoPagado: montoPago,
                    saldoPendiente: saldoPendiente
                );

                if (resultado)
                {
                    if (saldoPendiente > 0)
                    {
                        MessageBox.Show(
                            $"No. Recibo: {numeroCheque}\n" +
                            $"Cheque: {Txt_Numero_Cheque.Text}\n" +
                            $"Banco: {banco}\n" +
                            $"Titular: {Txt_Nombre_Titular.Text}\n" +
                            $"Estado: {estadoCheque}\n" +
                            $"Fecha Emisión: {Dtp_Fecha_Emision.Value:dd/MM/yyyy}\n" +
                            $"Fecha Cobro: {Dtp_Fecha_Cobro.Value:dd/MM/yyyy}\n" +
                            $"Pago recibido: Q {montoPago:F2}\n" +
                            $"Saldo pendiente: Q {saldoPendiente:F2}",
                            "Pago Parcial",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"No. Recibo: {numeroCheque}\n" +
                            $"Cheque: {Txt_Numero_Cheque.Text}\n" +
                            $"Banco: {banco}\n" +
                            $"Titular: {Txt_Nombre_Titular.Text}\n" +
                            $"Estado: {estadoCheque}\n" +
                            $"Fecha Emisión: {Dtp_Fecha_Emision.Value:dd/MM/yyyy}\n" +
                            $"Fecha Cobro: {Dtp_Fecha_Cobro.Value:dd/MM/yyyy}\n" +
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
    }
    }

