using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Pago_Transferencia : Form
    {
        private int gIdPago;
        private decimal gMonto;
        private int iIdCXC;
        private int iIdCliente;
        Cls_CXCDetalle_Controlador controlador = new Cls_CXCDetalle_Controlador();
        public Frm_Pago_Transferencia(int idPagoPrincipal, decimal monto, int _IdCXC)
        {
            InitializeComponent();
            gIdPago = idPagoPrincipal;
            gMonto = monto;
            iIdCXC = _IdCXC;
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
        private void fun_PrecargarDatos()
        {
            Txt_Monto_Total.Text = $"Q { gMonto.ToString("F2")}";

        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (string.IsNullOrWhiteSpace(Txt_Numero_Transferencia.Text))
                {
                    MessageBox.Show("Ingrese el número de transferencia.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Numero_Transferencia.Focus();
                    return;
                }

                if (Cbo_Bancos.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un banco origen.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cbo_Bancos.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(Txt_Cuenta_Origen.Text))
                {
                    MessageBox.Show("Ingrese la cuenta de origen.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Cuenta_Origen.Focus();
                    return;
                }

                if (!decimal.TryParse(Txt_Monto_Pagar.Text.Replace("Q ", ""), out decimal montoPago) || montoPago <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Monto_Pagar.Focus();
                    return;
                }

                // ✅ GENERAR NÚMERO DE RECIBO
                string numeroTransferencia = controlador.GenerarTransferencia();

                decimal saldoPendiente = gMonto - montoPago;
                string banco = Cbo_Bancos.SelectedItem.ToString();
                // ✅ REGISTRAR PAGO
                bool resultado = controlador.RegistrarPago(
                    idCuentaPorCobrar: iIdCXC,
                    idCliente: iIdCliente,
                    numeroDocumento: numeroTransferencia,
                    tipoPago: "Transferencia",
                    montoPagado: montoPago,
                    saldoPendiente: saldoPendiente
                );

                if (resultado)
                {
                    if (saldoPendiente > 0)
                    {
                        MessageBox.Show(
                            $"No. Recibo: {numeroTransferencia}\n" +
                            $"Transferencia: {Txt_Numero_Transferencia.Text}\n" +
                            $"Banco Origen: {banco}\n" +
                            $"Cuenta Origen: {Txt_Cuenta_Origen.Text}\n" +
                            $"Pago recibido: Q {montoPago:F2}\n" +
                            $"Saldo pendiente: Q {saldoPendiente:F2}",
                            "Pago Parcial",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"No. Recibo: {numeroTransferencia}\n" +
                            $"Transferencia: {Txt_Numero_Transferencia.Text}\n" +
                            $"Banco Origen: {banco}\n" +
                            $"Cuenta Origen: {Txt_Cuenta_Origen.Text}\n" +
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
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta relativa donde está tu archivo CHM (igual que tu compañero)
                const string subRutaAyuda = @"ayuda\Empresarial\Equipo 2\Ventas\pagos\pagos.chm";

                string rutaEncontrada = null;
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                // Busca la carpeta hacia arriba (10 niveles)
                for (int i = 0; i < 10 && dir != null; i++, dir = dir.Parent)
                {
                    string candidata = Path.Combine(dir.FullName, subRutaAyuda);
                    if (File.Exists(candidata))
                    {
                        rutaEncontrada = candidata;
                        break;
                    }
                }
                if (rutaEncontrada != null)

                {
                    // Esta es la ruta INTERNA del archivo dentro del CHM
                    string rutaInterna = @"pagos_transferencia.html";

                    Help.ShowHelp(this, rutaEncontrada, HelpNavigator.Topic, rutaInterna);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de ayuda.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ayuda:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

   
