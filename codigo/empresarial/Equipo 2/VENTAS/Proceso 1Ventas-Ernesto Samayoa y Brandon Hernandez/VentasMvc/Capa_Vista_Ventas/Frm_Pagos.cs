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
    public partial class Frm_Pagos : Form
    {
        private Cls_TipoOperacion _tipo;
        private int _idCuentaPorCobrar;
        private decimal _monto;
        private decimal _saldoPendiente;
        private string _motivo;
        private string _nombreCliente;
        private DateTime _fechaVencimiento;
        private readonly Cls_CXCDetalle_Controlador _cxcControlador = new Cls_CXCDetalle_Controlador();
        private DataTable _dtCxc = null;

        public Frm_Pagos(int idCuentaPorCobrar, decimal monto)
        {
            InitializeComponent();
            _tipo = Cls_TipoOperacion.Pago;  // ← Automáticamente es PAGO
            _idCuentaPorCobrar = idCuentaPorCobrar;
            _monto = monto;
            _motivo = string.Empty;

            fun_CargarMetodosPago();
            fun_CargarEstadosPago();
           fun_PrecargarDesdVentas();
           
        }
        public Frm_Pagos()
        {
            InitializeComponent();
            _tipo = Cls_TipoOperacion.Pago;
            _idCuentaPorCobrar = 0;
            _monto = 0;
            _motivo = string.Empty;

            fun_CargarMetodosPago();
            fun_CargarEstadosPago();
            fun_CargarCXC();
        }

        private void fun_CargarCXC()
        {
            _dtCxc = _cxcControlador.ListarCxcActivasConSaldo();

            // Agregamos una columna de display para mostrar: CXC #id - Cliente - Saldo
            if (!_dtCxc.Columns.Contains("Display"))
                _dtCxc.Columns.Add("Display", typeof(string));

            foreach (DataRow row in _dtCxc.Rows)
            {
                int idCxc = Convert.ToInt32(row["IdCxc"]);
                string cliente = row["Cliente"].ToString();
                decimal saldo = Convert.ToDecimal(row["SaldoPendiente"]);

                row["Display"] = $"CXC #{idCxc} - Cliente: {cliente} - Saldo Q {saldo:F2}";
            }

            Cbo_CXC.DataSource = _dtCxc;
            Cbo_CXC.DisplayMember = "Display";
            Cbo_CXC.ValueMember = "IdCxc";
            Cbo_CXC.SelectedIndex = -1;

            Cbo_CXC.Enabled = true;
            Txt_Monto.ReadOnly = false;   // para abonos
            Txt_Monto.Clear();
        }
        private void fun_PrecargarDesdVentas()
        {
            // Precargar CXC
            Cbo_CXC.Text = _idCuentaPorCobrar.ToString();
            Cbo_CXC.Enabled = false;

            // Precargar Monto
            Txt_Monto.Text = _monto.ToString("F2");
            Txt_Monto.ReadOnly = true;

            // Fecha por defecto
            Dtp_Fecha_Pago.Value = DateTime.Now;

            // Estado por defecto = Pendiente
            Cbo_Estado.SelectedIndex = 0;

            Cbo_MetodoPago.Focus();
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

            Txt_Monto.Text = $"Q:{_monto.ToString("F2")}";
            Txt_Monto.ReadOnly = true;

           

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

        private void AbrirSubformulario(string sMetodo, int idCxc, decimal saldoPendienteActual)
        {
            switch (sMetodo)
            {
                case "Tarjeta":
                    new Frm_Pago_Tarjeta(idCxc, saldoPendienteActual, idCxc).ShowDialog();
                    fun_LimpiarCampos();
                    break;
                 
                case "Efectivo":
                    new Frm_pago_efectivo(idCxc, saldoPendienteActual, idCxc).ShowDialog();
                    fun_LimpiarCampos();
                    break;
                case "Transferencia":
                    new Frm_Pago_Transferencia(idCxc, saldoPendienteActual, idCxc).ShowDialog();
                    fun_LimpiarCampos();
                    break;
                case "Cheque":
                    new Frm_Pago_Cheque(idCxc, saldoPendienteActual, idCxc).ShowDialog();
                    fun_LimpiarCampos();
                    break;
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Txt_Monto.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (_idCuentaPorCobrar <= 0)
            {
                MessageBox.Show("Seleccione una CXC.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Txt_Monto.ReadOnly)
            {
                if (!decimal.TryParse(Txt_Monto.Text, out decimal abono) || abono <= 0)
                {
                    MessageBox.Show("Ingrese un monto (abono) válido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_saldoPendiente <= 0)
                {
                    MessageBox.Show("La CXC seleccionada no tiene saldo pendiente.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (abono > _saldoPendiente)
                {
                    MessageBox.Show(
                        $"El abono (Q {abono:F2}) no puede ser mayor al saldo pendiente (Q {_saldoPendiente:F2}).",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                AbrirSubformulario(sMet, _idCuentaPorCobrar, _saldoPendiente);
                return;
            }
            AbrirSubformulario(sMet, _idCuentaPorCobrar, _saldoPendiente);
        }

    

        private void Cbo_CXC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_CXC.SelectedIndex == -1 || Cbo_CXC.SelectedValue == null)
                    return;

                if (Cbo_CXC.SelectedValue is DataRowView) // protección típica
                    return;

                int idCxc = Convert.ToInt32(Cbo_CXC.SelectedValue);
                _idCuentaPorCobrar = idCxc;

                // saldo actual real (para que gMonto sea saldo pendiente)
                decimal saldo = _cxcControlador.ObtenerSaldoPendienteActual(idCxc);
                _saldoPendiente = saldo;

                // Dejá el textbox vacío para escribir el abono
                Txt_Monto.Text = saldo.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar CXC: " + ex.Message);
            }
        }
    }
}
