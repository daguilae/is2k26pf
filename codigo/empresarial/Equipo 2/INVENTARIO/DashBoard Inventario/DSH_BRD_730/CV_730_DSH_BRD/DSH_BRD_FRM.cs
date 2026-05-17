using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_730_DSH_BRD
{
    public partial class DSH_BRD_FRM : Form
    {
        // La Vista solo habla con el Controlador
        private DSH_BRD_CNT _controlador = new DSH_BRD_CNT();

        // Bandera Cargar Todo Inicio
        private bool _filtrarFechas = false;

        public DSH_BRD_FRM()
        {
            InitializeComponent();
        }

        // ── AL CARGAR EL FORMULARIO ──────────────────────────
        private void DSH_BRD_FRM_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarComboBoxes();
        }

        // ── CARGA AMBAS PESTAÑAS ─────────────────────────────
        private void CargarDatos()
        {
            CargarMovimientos();
            CargarStockCritico();
        }

        // ── CARGA COMBOBOXES ─────────────────────────────────
        private void CargarComboBoxes()
        {
            cmbNombre.Items.Clear();
            cmbNombre.Items.Add("-- Todos --");
            foreach (DataRow row in _controlador.ObtenerNombresProductos().Rows)
                cmbNombre.Items.Add(row["nombre_prod"].ToString());
            cmbNombre.SelectedIndex = 0;

            cmbTipoMov.Items.Clear();
            cmbTipoMov.Items.Add("-- Todos --");
            foreach (DataRow row in _controlador.ObtenerTiposMovimiento().Rows)
                cmbTipoMov.Items.Add(row["nombre_tipo_inv"].ToString());
            cmbTipoMov.SelectedIndex = 0;
        }

        // ── ULTIMOS MOVIMIENTOS ──────────────────────────────
        private void CargarMovimientos()
        {
            try
            {
                string nombre = cmbNombre.SelectedIndex > 0 ? cmbNombre.SelectedItem.ToString() : null;
                string tipoMov = cmbTipoMov.SelectedIndex > 0 ? cmbTipoMov.SelectedItem.ToString() : null;

                DateTime desde = _filtrarFechas ? dtpDesde.Value : DateTime.MinValue;
                DateTime hasta = _filtrarFechas ? dtpHasta.Value : DateTime.MaxValue;

                DataTable dt = _controlador.ObtenerUltimosMovimientos(desde, hasta, nombre, tipoMov);

                dgvMovimientos.DataSource = dt;
                dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMovimientos.RowHeadersVisible = false;
                dgvMovimientos.AllowUserToAddRows = false;
                dgvMovimientos.ReadOnly = true;
                dgvMovimientos.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Movimientos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // ── STOCK CRITICO ────────────────────────────────────
        private void CargarStockCritico()
        {
            try
            {
                dgvStockCritico.DataSource = _controlador.ObtenerStockCritico();
                dgvStockCritico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStockCritico.RowHeadersVisible = false;
                dgvStockCritico.AllowUserToAddRows = false;
                dgvStockCritico.ReadOnly = true;

                // Conecta el evento de coloreado
                dgvStockCritico.CellFormatting += dgvStockCritico_CellFormatting;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Stock Crítico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── EVENTO DE COLOREADO ──────────────────────────────
        private void dgvStockCritico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvStockCritico.Rows[e.RowIndex];

            if (row.Cells["Nivel"].Value != null)
            {
                switch (row.Cells["Nivel"].Value.ToString())
                {
                    case "SIN STOCK":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(183, 28, 28);
                        break;
                    case "CRÍTICO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(230, 81, 0);
                        break;
                    case "BAJO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(130, 100, 0);
                        break;
                    case "MEDIO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(27, 94, 32);
                        break;
                    case "ALTO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(187, 222, 251);
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(13, 71, 161);
                        break;
                }
            }
        }

        private void cmbFiltro_Changed(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        // ── BOTONES ──────────────────────────────────────────

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de impresión próximamente.",
                            "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            CNTS_INV_FRM frmConsulta = new CNTS_INV_FRM();
            frmConsulta.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── DATEPICKERS - FILTRO MANUAL ──────────────────────
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            _filtrarFechas = true; // Regresa a personalizado
            CargarMovimientos();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            _filtrarFechas = true; // Regresa a personalizado
            CargarMovimientos();
        }
    }
}