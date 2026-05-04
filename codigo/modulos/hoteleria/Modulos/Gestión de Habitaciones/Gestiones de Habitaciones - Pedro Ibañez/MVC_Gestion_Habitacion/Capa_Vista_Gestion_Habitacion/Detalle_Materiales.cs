using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Recetas;

namespace Capa_Vista_CVRecetas
{
    public partial class Detalle_Materiales : Form
    {
        // Diego Monterroso
        Controlador_detalle_Materiales controlador = new Controlador_detalle_Materiales();

        int idDetalleSeleccionado = -1;
        bool modoEdicion = false;

        // Diego Monterroso
        public Detalle_Materiales()
        {
            InitializeComponent();
            configurarDGV();
            cargarCombos();
            cargarDatos();

            estadoInicial();
        }

        private void estadoInicial()
        {
            habilitarControles(false);

            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_eliminar.Enabled = true;
        }

        private void modoIngreso()
        {
            habilitarControles(true);

            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

            btn_ingresar.Enabled = false;
            btn_editar.Enabled = false;

            btn_eliminar.Enabled = true;
        }

        private void modoNormal()
        {
            habilitarControles(false);

            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;

            btn_ingresar.Enabled = true;
            btn_editar.Enabled = true;

            btn_eliminar.Enabled = true;
        }

        private void habilitarControles(bool estado)
        {
            Cbo_Producto.Enabled = estado;
            Cbo_Material.Enabled = estado;
            Cbo_Unidad.Enabled = estado;
            Nud_Cantidad.Enabled = estado;
        }

        // Diego Monterroso

        private void configurarDGV()
        {
            Dgv_Recetas.Columns.Clear();
            Dgv_Recetas.ColumnCount = 7;

            Dgv_Recetas.Columns[0].Name = "IdDetalle";
            Dgv_Recetas.Columns[1].Name = "IdProducto";
            Dgv_Recetas.Columns[2].Name = "Producto";
            Dgv_Recetas.Columns[3].Name = "IdMaterial";
            Dgv_Recetas.Columns[4].Name = "Material";
            Dgv_Recetas.Columns[5].Name = "Unidad";
            Dgv_Recetas.Columns[6].Name = "Cantidad";

            Dgv_Recetas.Columns[0].Visible = false;
            Dgv_Recetas.Columns[1].Visible = false;
            Dgv_Recetas.Columns[3].Visible = false;

            Dgv_Recetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Diego Monterroso
        private void cargarCombos()
        {
            Cbo_Producto.DataSource = controlador.getProductos();
            Cbo_Producto.DisplayMember = "Nombre_Material";
            Cbo_Producto.ValueMember = "Pk_Id_Materiales";
            Cbo_Producto.SelectedIndex = -1;

            Cbo_Material.DataSource = controlador.getMateriales();
            Cbo_Material.DisplayMember = "Nombre_Material";
            Cbo_Material.ValueMember = "Pk_Id_Materiales";
            Cbo_Material.SelectedIndex = -1;

            Cbo_Unidad.DataSource = controlador.getUnidades();
            Cbo_Unidad.DisplayMember = "Nombre_Unidad_Medida";
            Cbo_Unidad.ValueMember = "Pk_Id_Unidad_Medida";
            Cbo_Unidad.SelectedIndex = -1;
        }

        // Diego Monterroso
        private void cargarDatos()
        {
            Dgv_Recetas.Rows.Clear();
            DataTable dt = controlador.getDetalles();

            foreach (DataRow row in dt.Rows)
            {
                Dgv_Recetas.Rows.Add(
                    row[0], row[1], row[2],
                    row[3], row[4], row[5], row[6]
                );
            }
        }

        // Ruben Lopez 0901-20-4620
        // INGRESAR

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            limpiar();
            idDetalleSeleccionado = -1;
            modoEdicion = false;

            modoIngreso();
        }

        // Ruben Lopez 0901-20-4620
        // GUARDAR

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_Producto.SelectedValue == null ||
                Cbo_Material.SelectedValue == null ||
                Cbo_Unidad.SelectedValue == null ||
                Nud_Cantidad.Value <= 0)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int p = Convert.ToInt32(Cbo_Producto.SelectedValue);
            int m = Convert.ToInt32(Cbo_Material.SelectedValue);
            int u = Convert.ToInt32(Cbo_Unidad.SelectedValue);
            decimal c = Nud_Cantidad.Value;

            if (!modoEdicion)
            {
                controlador.guardarDetalle(p, m, u, c);
                MessageBox.Show("Guardado correctamente");
            }
            else
            {
                controlador.actualizarDetalle(idDetalleSeleccionado, p, m, u, c);
                MessageBox.Show("Actualizado correctamente");
            }

            cargarDatos();
            limpiar();
            modoNormal();
        }

        // Ruben Lopez 0901-20-4620
        // EDITAR

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (Dgv_Recetas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DataGridViewRow fila = Dgv_Recetas.SelectedRows[0];

            idDetalleSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
            modoEdicion = true;

            Cbo_Producto.SelectedValue = fila.Cells[1].Value;
            Cbo_Material.SelectedValue = fila.Cells[3].Value;
            Cbo_Unidad.Text = fila.Cells[5].Value.ToString();
            Nud_Cantidad.Value = Convert.ToDecimal(fila.Cells[6].Value);

            modoIngreso();
        }
        // Ruben Lopez 0901-20-4620
        // ELIMINAR (SIEMPRE ACTIVO)

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Recetas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar");
                return;
            }

            var confirm = MessageBox.Show(
                "¿Seguro que desea eliminar este registro?",
                "Confirmar",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                DataGridViewRow fila = Dgv_Recetas.SelectedRows[0];
                int id = Convert.ToInt32(fila.Cells[0].Value);

                controlador.eliminarDetalle(id);

                cargarDatos();
                limpiar();
                MessageBox.Show("Eliminado correctamente");
            }
        }

        // Ruben Lopez 0901-20-4620
        // CANCELAR

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            modoNormal();
        }

        // Ruben Lopez 0901-20-4620
        // GRID CLICK

        private void Dgv_Recetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_Recetas.Rows[e.RowIndex];
                idDetalleSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
            }
        }

        // Ruben Lopez 0901-20-4620
        // LIMPIAR

        private void limpiar()
        {
            Cbo_Producto.SelectedIndex = -1;
            Cbo_Material.SelectedIndex = -1;
            Cbo_Unidad.SelectedIndex = -1;
            Nud_Cantidad.Value = 0;

            idDetalleSeleccionado = -1;
            modoEdicion = false;
        }
        // Ruben Lopez 0901-20-4620
        private void btn_salir_Click(object sender, EventArgs e)
        {

        }
    }
}