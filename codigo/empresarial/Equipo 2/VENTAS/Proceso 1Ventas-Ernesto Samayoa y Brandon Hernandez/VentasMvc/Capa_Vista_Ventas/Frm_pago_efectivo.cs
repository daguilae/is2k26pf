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
    public partial class Frm_pago_efectivo : Form
    {
        private int gIdPago;
        private decimal gMonto;
        Cls_CXCDetalle_Controlador controlador = new Cls_CXCDetalle_Controlador();
        private int _idCuentaPorCobrar;
        private int _idCliente;
      
        public Frm_pago_efectivo(int idPagoPrincipal, decimal monto,int _idCXC)
        {
            InitializeComponent();
            gIdPago = idPagoPrincipal;
            gMonto = monto;
            _idCuentaPorCobrar = _idCXC;
            _idCliente = controlador.ObtenerIdClientePorCXC(_idCXC);
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
            Cls_CXCDetalle_Controlador controlador = new Cls_CXCDetalle_Controlador();

            try
            {
                if (!decimal.TryParse(Txt_Dinero_Recibido.Text, out decimal efectivoIngresado) || efectivoIngresado <= 0)
                {
                    MessageBox.Show("Ingrese un monto válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_Dinero_Recibido.Focus();
                    return;
                }

                decimal montoPago = Math.Min(efectivoIngresado, gMonto);
                decimal saldoPendiente = gMonto - montoPago;
                decimal vuelto = efectivoIngresado -gMonto;
                string numeroRecibo = controlador.GenerarIdRecibo();
                // ✅ Guardar pago
                bool resultado = controlador.RegistrarPago(
                        idCuentaPorCobrar: _idCuentaPorCobrar,
                        idCliente: _idCliente,  // ✅ AGREGAR ESTO
                        numeroDocumento:numeroRecibo,
                        tipoPago: "Efectivo",
                        montoPagado: montoPago,
                        saldoPendiente: saldoPendiente
                    ) ;
               

                if (resultado)
                {
                    if (saldoPendiente > 0)
                    {
                        MessageBox.Show(
                         $"No. Recibo: {numeroRecibo}\n" +
                         $"Pago recibido: Q {montoPago:F2}\n" +
                         $"Saldo pendiente: Q {saldoPendiente:F2}\n" +
                         $"Vuelto: Q {(vuelto > 0 ? vuelto : 0):F2}",
                         "Pago Parcial",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"No. Recibo: {numeroRecibo}\n" +
                            $"Pago recibido: Q {montoPago:F2}\n" +
                            $"Vuelto: Q {vuelto:F2}",
                            "Pago Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" EXCEPCIÓN: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
    }


