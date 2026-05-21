using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Capa_Controlador_Compras;

namespace Capa_Vista_Compras
{
    public partial class Frm_Compras_CXP : Form
    {
        private readonly Cls_Compras_Controlador cm = new Cls_Compras_Controlador();

        public Frm_Compras_CXP()
        {
            InitializeComponent();

            this.Load -= Frm_Compras_CXP_Load;
            this.Load += Frm_Compras_CXP_Load;

            this.Btn_guardar.Click -= Btn_guardar_Click;
            this.Btn_guardar.Click += Btn_guardar_Click;

            this.Btn_nuevo.Click -= Btn_nuevo_Click;
            this.Btn_nuevo.Click += Btn_nuevo_Click;

            this.Txt_total.TextChanged -= Txt_total_TextChanged;
            this.Txt_total.TextChanged += Txt_total_TextChanged;

            this.Txt_adelanto.TextChanged -= Txt_adelanto_TextChanged;
            this.Txt_adelanto.TextChanged += Txt_adelanto_TextChanged;

            this.Dgv_compras.CellClick -= Dgv_compras_CellClick;
            this.Dgv_compras.CellClick += Dgv_compras_CellClick;
        }

        private void Frm_Compras_CXP_Load(object sender, EventArgs e)
        {
            fun_CargarComboBox();
            fun_CargarCompras();

            Txt_id.ReadOnly = true;
            Txt_saldo.ReadOnly = true;
            Txt_estado.ReadOnly = true;

            Txt_total.Text = "0";
            Txt_adelanto.Text = "0";
            Txt_saldo.Text = "0";
            Txt_estado.Text = "pendiente";
        }

        private void fun_CargarComboBox()
        {
            Cbo_proveedor.Items.Clear();
            var items = cm.ItemsProveedores();

            if (items != null && items.Length > 0)
                Cbo_proveedor.Items.AddRange(items);
        }

        private void fun_CargarCompras()
        {
            Dgv_compras.DataSource = cm.ObtenerCompras();

            if (Dgv_compras.Columns.Count > 0)
            {
                Dgv_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_compras.ReadOnly = true;
                Dgv_compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_compras.MultiSelect = false;
                Dgv_compras.AllowUserToAddRows = false;
                Dgv_compras.RowHeadersVisible = false;
            }
        }

        private float fun_ConvertirAFloat(string texto)
        {
            float valor;
            if (!float.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                float.TryParse(texto, out valor);
            return valor;
        }

        private void fun_Calcular()
        {
            float total = fun_ConvertirAFloat(Txt_total.Text);
            float adelanto = fun_ConvertirAFloat(Txt_adelanto.Text);

            if (adelanto > total)
            {
                MessageBox.Show("El adelanto no puede ser mayor al total");
                Txt_adelanto.Text = "0";
                adelanto = 0;
            }

            Txt_saldo.Text = cm.CalcularSaldo(total, adelanto).ToString("0.00");
            Txt_estado.Text = cm.ObtenerEstado(total, adelanto);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            var resultado = cm.GuardarCompra(
                Txt_numero.Text,
                Dtp_fecha.Value,
                Cbo_proveedor.SelectedItem?.ToString(),
                Txt_orden.Text,
                Txt_total.Text,
                Txt_adelanto.Text
            );

            MessageBox.Show(resultado.Message);

            if (resultado.Success)
            {
                fun_LimpiarCampos();
                fun_CargarCompras();
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            fun_LimpiarCampos();
            MessageBox.Show("Campos listos para nuevo registro");
        }

        private void Txt_total_TextChanged(object sender, EventArgs e)
        {
            fun_Calcular();
        }

        private void Txt_adelanto_TextChanged(object sender, EventArgs e)
        {
            fun_Calcular();
        }

        private void Dgv_compras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = Dgv_compras.Rows[e.RowIndex];

                Txt_id.Text = fila.Cells["IdFactura"].Value?.ToString() ?? "";
                Txt_numero.Text = fila.Cells["NumeroFactura"].Value?.ToString() ?? "";
                Txt_orden.Text = fila.Cells["IdOrdenCompra"].Value?.ToString() ?? "";
                Txt_total.Text = fila.Cells["TotalCompra"].Value?.ToString() ?? "0";
                Txt_estado.Text = fila.Cells["EstadoPago"].Value?.ToString() ?? "pendiente";

                if (fila.Cells["FechaFactura"].Value != null)
                {
                    DateTime fecha;
                    if (DateTime.TryParse(fila.Cells["FechaFactura"].Value.ToString(), out fecha))
                    {
                        Dtp_fecha.Value = fecha;
                    }
                }

                Txt_adelanto.Text = "0";

                if (Txt_estado.Text.ToLower() == "pagado")
                    Txt_saldo.Text = "0";
                else
                    Txt_saldo.Text = Txt_total.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del grid: " + ex.Message);
            }
        }

        private void fun_LimpiarCampos()
        {
            Txt_id.Clear();
            Txt_numero.Clear();
            Txt_orden.Clear();
            Txt_total.Text = "0";
            Txt_adelanto.Text = "0";
            Txt_saldo.Text = "0";
            Txt_estado.Text = "pendiente";
            Cbo_proveedor.SelectedIndex = -1;
            Dtp_fecha.Value = DateTime.Now;
        }
    }
}