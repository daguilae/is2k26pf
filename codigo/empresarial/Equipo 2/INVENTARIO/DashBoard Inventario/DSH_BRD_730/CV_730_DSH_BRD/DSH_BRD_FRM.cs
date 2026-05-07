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

        public DSH_BRD_FRM()
        {
            InitializeComponent();
        }

        // ── AL CARGAR EL FORMULARIO ──────────────────────────
        private void DSH_BRD_FRM_Load(object sender, EventArgs e)
        {
            CargarDatos();  
        }

        // ── CARGA AMBAS PESTAÑAS ─────────────────────────────
        private void CargarDatos()
        {
            CargarMovimientos();
            CargarStockCritico();
        }

        // ── ULTIMOS MOVIMIENTOS ──────────────────────────────
        private void CargarMovimientos()
        {
            try
            {
                dgvMovimientos.DataSource = _controlador.ObtenerUltimosMovimientos();
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
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210); // Rosa suave
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(183, 28, 28);  // Rojo oscuro
                        break;
                    case "CRÍTICO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178); // Naranja suave
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(230, 81, 0);   // Naranja oscuro
                        break;
                    case "BAJO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196); // Amarillo suave
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(130, 100, 0);  // Dorado oscuro
                        break;
                    case "MEDIO":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201); // Verde suave
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(27, 94, 32);   // Verde oscuro
                        break;
                }
            }
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

        
    }
}