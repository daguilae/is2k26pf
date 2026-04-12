using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaControlador;
using CapaModelo;

namespace Capa_Vista
{
    public partial class Frm_Disponibilidad_Inventario : Form
    {

        private readonly CRL_Inventario _crl = new CRL_Inventario();

        public Frm_Disponibilidad_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Disponibilidad_Inventario_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarCombos();
            Consultar();
        }

        private void ConfigurarGrid()
        {
            dgvInventario.AutoGenerateColumns = false;
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.ReadOnly = true;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.RowHeadersVisible = false;

            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Código", DataPropertyName = "CodigoMaterial", Width = 100 });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Material", DataPropertyName = "NombreMaterial", Width = 200 });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Tipo", DataPropertyName = "TipoInventario", Width = 110 });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Almacén", DataPropertyName = "NombreAlmacen", Width = 130 });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Disponible",
                DataPropertyName = "CantidadDisponible",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                { Format = "N4", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock mín.",
                DataPropertyName = "StockMinimo",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                { Format = "N4", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "UM", DataPropertyName = "UnidadMedida", Width = 55 });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Costo unit.",
                DataPropertyName = "CostoUnitario",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                { Format = "N4", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvInventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Actualización",
                DataPropertyName = "FechaActualizacion",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
        }

        private void CargarCombos()
        {
            // Tipo inventario
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add(new ComboItem(0, "— Todos —"));
            cmbTipo.Items.Add(new ComboItem(1, "Materia Prima"));
            cmbTipo.Items.Add(new ComboItem(2, "En Produccion"));
            cmbTipo.Items.Add(new ComboItem(3, "Producto Final"));
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.SelectedIndex = 0;

            // Almacenes desde BD
            cmbAlmacen.Items.Clear();
            cmbAlmacen.Items.Add(new ComboItem(0, "— Todos —"));
            var dt = _crl.ObtenerAlmacenes();
            foreach (System.Data.DataRow row in dt.Rows)
                cmbAlmacen.Items.Add(new ComboItem(Convert.ToInt32(row[0]), row[1].ToString()));
            cmbAlmacen.DisplayMember = "Nombre";
            cmbAlmacen.SelectedIndex = 0;
        }

        private void Consultar()
        {
            try
            {
                int tipo = ((ComboItem)cmbTipo.SelectedItem).Id;
                int almacen = ((ComboItem)cmbAlmacen.SelectedItem).Id;
                string busqueda = txtBusqueda.Text.Trim();

                var lista = _crl.ConsultarDisponibilidad(tipo, almacen, busqueda);

                dgvInventario.DataSource = null;
                dgvInventario.DataSource = lista;

                // Marcar en rojo filas con stock bajo mínimo
                foreach (DataGridViewRow fila in dgvInventario.Rows)
                {
                    var item = (Inventario)fila.DataBoundItem;
                    if (item != null && item.BajoStock)
                    {
                        fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                        fila.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }

                lblTotal.Text = $"Registros encontrados: {lista.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e) => Consultar();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Clear();
            cmbTipo.SelectedIndex = 0;
            cmbAlmacen.SelectedIndex = 0;
            Consultar();
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Consultar();
        }
    }

    internal class ComboItem
    {
        public int Id { get; }
        public string Nombre { get; }
        public ComboItem(int id, string nombre) { Id = id; Nombre = nombre; }
        public override string ToString() => Nombre;
    }
}