using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CV_730_DSH_BRD
{
    public partial class CNTS_INV_FRM : Form
    {
        private CNTS_INV_CNT _controlador = new CNTS_INV_CNT();

        public CNTS_INV_FRM()
        {
            InitializeComponent();
            CargarCombos();
            BuscarInventario();
        }

        // ── CARGAR COMBOS ────────────────────────────────────
        private void CargarCombos()
        {
            try
            {
                // ── ComboBox Bodega ──
                DataTable dtBodega = _controlador.ObtenerBodegas();
                DataRow filaTodos = dtBodega.NewRow();
                filaTodos["Id"] = 0;
                filaTodos["Bodega"] = "-- TODAS --";
                dtBodega.Rows.InsertAt(filaTodos, 0);  // ← inserta al inicio

                cmbBodega.DataSource = dtBodega;
                cmbBodega.DisplayMember = "Bodega";
                cmbBodega.ValueMember = "Id";
                cmbBodega.SelectedIndex = 0;

                // ── ComboBox Tipo Producto ──
                DataTable dtProducto = _controlador.ObtenerProductos();
                cmbProducto.DataSource = dtProducto;
                cmbProducto.DisplayMember = "Producto";
                cmbProducto.ValueMember = "Id";
                cmbProducto.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Combos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarInventario()
        {
            try
            {
                int idBodega = 0;
                if (cmbBodega.SelectedValue != null && cmbBodega.SelectedValue is int)
                    idBodega = (int)cmbBodega.SelectedValue;

                // ── Tipo producto ahora es string ──
                string tipoProducto = cmbProducto.SelectedValue?.ToString() ?? "";

                string orden = rbDescendente.Checked ? "DESC" : "ASC";
                string codigo = txtCodigo.Text.Trim();
                string nombre = txtNombre.Text.Trim();

                dgvInventario.DataSource = _controlador.ObtenerInventario(
                    idBodega, tipoProducto, orden, codigo, nombre);

                dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInventario.RowHeadersVisible = false;
                dgvInventario.AllowUserToAddRows = false;
                dgvInventario.ReadOnly = true;
                dgvInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Inventario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── FILTRO EN TIEMPO REAL - COMBOS ───────────────────
        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarInventario();
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarInventario();
        }
        // ── ORDEN ASCENDENTE / DESCENDENTE ───────────────────
        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            BuscarInventario();
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            BuscarInventario();
        }
        // ── FILTRO EN TIEMPO REAL - TEXTBOX ──────────────────
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscarInventario();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarInventario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarInventario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "BÚSQUEDA: Filtre por Bodega y/o Producto.\n" +
                "BÚSQUEDA INTELIGENTE: Escriba el Código o Nombre para filtrar en tiempo real.\n" +
                "ORDEN: Seleccione Ascendente o Descendente.\n" +
                "Sin selección muestra todo el inventario.",
                "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de impresión próximamente.",
                "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}