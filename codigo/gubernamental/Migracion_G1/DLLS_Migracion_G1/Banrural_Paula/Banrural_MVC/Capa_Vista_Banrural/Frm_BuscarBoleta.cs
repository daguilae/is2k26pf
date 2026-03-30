using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Banrural;

namespace Capa_Vista_Banrural
{
    public partial class Frm_BuscarBoleta : Form
    {
        private readonly Cls_Controlador ctrl = new Cls_Controlador();

        private int _idBoletaSeleccionada = 0;

        public Frm_BuscarBoleta()
        {
            InitializeComponent();

            // DPI validaciones
            Txt_Dpi.KeyPress += Txt_Dpi_KeyPress;
            Txt_Dpi.TextChanged += Txt_Dpi_TextChanged;
            Txt_Dpi.Leave += Txt_Dpi_Leave;
            Txt_Dpi.MaxLength = 13;

            Txt_Nombres.ReadOnly = true;
            Txt_Apellidos.ReadOnly = true;

            Txt_Nombres.CharacterCasing = CharacterCasing.Upper;
            Txt_Apellidos.CharacterCasing = CharacterCasing.Upper;

            this.Shown += (s, e) => CargarTodasLasBoletas();
        }

        private void Frm_BuscarBoleta_Load(object sender, EventArgs e)
        {
            CargarTodasLasBoletas();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ===============================
        // CARGA INICIAL
        // ===============================
        private void CargarTodasLasBoletas()
        {
            _idBoletaSeleccionada = 0;

            DataTable dt = ctrl.ObtenerTodasLasBoletasConCiudadano();
            Dgv_Boletas.DataSource = dt;

            // Ocultar PK
            if (Dgv_Boletas.Columns.Contains("Pk_Id_Boleta"))
                Dgv_Boletas.Columns["Pk_Id_Boleta"].Visible = false;

            // Opcional: que se vea mejor
            Dgv_Boletas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Boletas.MultiSelect = false;
            Dgv_Boletas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ===============================
        // DPI VALIDACIONES
        // ===============================
        private void Txt_Dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Txt_Dpi_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Dpi.Text.Length > 13)
            {
                Txt_Dpi.Text = Txt_Dpi.Text.Substring(0, 13);
                Txt_Dpi.SelectionStart = Txt_Dpi.Text.Length;
            }
        }

        private void Txt_Dpi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Dpi.Text))
                return;

            if (Txt_Dpi.Text.Length != 13)
            {
                MessageBox.Show(
                    "El DPI debe contener exactamente 13 dígitos.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Txt_Dpi.Focus();
            }
        }

        // ===============================
        // BUSCAR POR DPI (FILTRAR GRID)
        // ===============================
        private void Btn_BuscarDpi_Click(object sender, EventArgs e)
        {
            if (Txt_Dpi.Text.Length != 13)
            {
                MessageBox.Show("Ingrese un DPI válido (13 dígitos).");
                return;
            }

            long dpi = long.Parse(Txt_Dpi.Text);

            // Filtrar boletas por DPI
            DataTable dtBoletas = ctrl.ObtenerBoletasPorDpi(dpi);

            if (dtBoletas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron boletas para ese DPI.");
                return;
            }

            Dgv_Boletas.DataSource = dtBoletas;

            if (Dgv_Boletas.Columns.Contains("Pk_Id_Boleta"))
                Dgv_Boletas.Columns["Pk_Id_Boleta"].Visible = false;

            // Si quieres, carga nombre/apellido desde la primera fila
            Txt_Nombres.Text = dtBoletas.Rows[0]["Cmp_Nombres_Ciudadano"].ToString();
            Txt_Apellidos.Text = dtBoletas.Rows[0]["Cmp_Apellidos_Ciudadano"].ToString();
        }

        // ===============================
        // CLICK EN GRID: CARGAR DPI/NOMBRE/APELLIDO
        // ===============================
        private void Dgv_Boletas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = Dgv_Boletas.Rows[e.RowIndex];

            _idBoletaSeleccionada = Convert.ToInt32(row.Cells["Pk_Id_Boleta"].Value);

            Txt_Dpi.Text = row.Cells["Cmp_Dpi_Ciudadano"].Value.ToString();
            Txt_Nombres.Text = row.Cells["Cmp_Nombres_Ciudadano"].Value.ToString();
            Txt_Apellidos.Text = row.Cells["Cmp_Apellidos_Ciudadano"].Value.ToString();
        }

        // ===============================
        // ELIMINAR BOLETA
        // ===============================
        private void Btn_EliminarBoleta_Click(object sender, EventArgs e)
        {
            if (Dgv_Boletas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una boleta en el listado.");
                return;
            }

            object val = Dgv_Boletas.CurrentRow.Cells["Pk_Id_Boleta"].Value;

            if (val == null || val == DBNull.Value)
            {
                MessageBox.Show("Seleccione una boleta válida.");
                return;
            }

            int idBoleta = Convert.ToInt32(val);

            // ✅ Pregunta de confirmación
            DialogResult resp = MessageBox.Show(
                "¿Desea eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.No)
                return;

            int ok = ctrl.EliminarBoleta(idBoleta);

            if (ok == 1)
            {
                MessageBox.Show(
                    "La boleta fue eliminada correctamente.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Recargar el grid
                CargarTodasLasBoletas();

                // Limpiar campos
                Txt_Dpi.Clear();
                Txt_Nombres.Clear();
                Txt_Apellidos.Clear();
            }
            else
            {
                MessageBox.Show(
                    "No se pudo eliminar la boleta.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // MODIFICAR
        private void Btn_ModificarBoleta_Click(object sender, EventArgs e)
        {
            if (Dgv_Boletas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una boleta en el listado.");
                return;
            }

            object val = Dgv_Boletas.CurrentRow.Cells["Pk_Id_Boleta"].Value;
            if (val == null || val == DBNull.Value)
            {
                MessageBox.Show("Seleccione una boleta válida.");
                return;
            }

            int idBoleta = Convert.ToInt32(val);

            Hide();
            Frm_Banrural frm = new Frm_Banrural(idBoleta);
            frm.ShowDialog();
            Show();

            CargarTodasLasBoletas();
        }

        // EXTRAS (si están en designer, no borrar)
        private void Txt_Nombres_TextChanged(object sender, EventArgs e) { }
        private void Txt_Apellidos_TextChanged(object sender, EventArgs e) { }
        private void Dgv_Boletas_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Btn_LimpiarTodo_Click(object sender, EventArgs e)
        {
            Txt_Dpi.Clear();
            Txt_Nombres.Clear();
            Txt_Apellidos.Clear();

            _idBoletaSeleccionada = 0;

            CargarTodasLasBoletas();

            Dgv_Boletas.ClearSelection();

            Txt_Dpi.Focus();
        }
    }
}