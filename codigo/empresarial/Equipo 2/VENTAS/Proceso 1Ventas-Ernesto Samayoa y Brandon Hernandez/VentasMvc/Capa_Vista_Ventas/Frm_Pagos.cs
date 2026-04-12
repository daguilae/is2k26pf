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
        private Cls_TipoOperacion _tipo;
        private int _idCuentaPorCobrar;
        private decimal _monto;
        private string _motivo;

        // Constructor normal — desde ventas
        public Frm_Pagos()
        {
            InitializeComponent();
            _tipo = Cls_TipoOperacion.Pago;
            fun_CargarMetodosPago();
            fun_CargarEstadosPago();
            fun_CargarCXC();
        }

        // Constructor desde devolución
        public Frm_Pagos(Cls_TipoOperacion tipo, int idCuentaPorCobrar, decimal monto, string motivo)
        {
            InitializeComponent();
            _tipo = tipo;
            _idCuentaPorCobrar = idCuentaPorCobrar;
            _monto = monto;
            _motivo = motivo;
            fun_CargarMetodosPago();
            fun_CargarEstadosPago();
            fun_PrecargarDesdDevolucion();
        }

        private void fun_PrecargarDesdDevolucion()
        {
            // Precargar y bloquear campos que vienen de devolución
            Cbo_CXC.Text = _idCuentaPorCobrar.ToString();
            Cbo_CXC.Enabled = false;

            Txt_Monto.Text = _monto.ToString("F2");
            Txt_Monto.ReadOnly = true;

           

        }

        private void fun_CargarCXC()
        {
            // Solo se carga en modo Pago normal
            // Aquí va tu lógica de cargar CxC desde BD
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
            Cbo_Estado.Items.Add("Devolucion");
            Cbo_Estado.SelectedIndex = -1;
        }

        private void fun_LimpiarCampos()
        {
            // Solo limpiar si es modo Pago normal
            if (_tipo == Cls_TipoOperacion.Pago)
            {
                Cbo_CXC.SelectedIndex = -1;
                Cbo_MetodoPago.SelectedIndex = -1;
                Cbo_Estado.SelectedIndex = -1;
                Txt_Monto.Clear();
                Dtp_Fecha_Pago.Value = DateTime.Now;
            }
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
            Txt_Monto.Enabled = true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string sMet = Cbo_MetodoPago.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(sMet))
            {
                MessageBox.Show("Seleccione un método de pago.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_Monto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AbrirSubformulario(sMet, _idCuentaPorCobrar, monto);
        }
    }
}
