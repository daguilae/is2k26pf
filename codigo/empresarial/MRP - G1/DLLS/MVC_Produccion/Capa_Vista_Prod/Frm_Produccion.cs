using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Prod;

namespace Capa_Vista_Prod
{
    public partial class Frm_Produccion : Form
    {
        Cls_Controlador_Prod controlador = new Cls_Controlador_Prod();
        public Frm_Produccion()
        {
            InitializeComponent();

            try
            {
                ObtenerOrdenesProduccion();
                CargarComboEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Frm_Prod_Load(object sender, EventArgs e)
        {
            
            
        }

        private void ObtenerOrdenesProduccion()
        {
            DataTable dt = controlador.ObtenerOrdenesProduccion();
            Cbo_Orden.DataSource = dt;
            Cbo_Orden.DisplayMember = "Descripcion";
            Cbo_Orden.ValueMember = "IdOrden";
            Cbo_Orden.SelectedIndex = -1;
        }

        //################### METODOS PARA COSTOS y MANO DE OBRA #############################

        private void Cbo_Orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Orden.SelectedValue == null || Cbo_Orden.SelectedIndex < 0) return;
            if (Cbo_Orden.SelectedValue is DataRowView) return; 

            int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);
            CargarManoObra(idOrden);
            CargarCostosIndirectos(idOrden);
            CargarCostos(idOrden);
        }

        // ── Pestaña Mano de Obra ──────────────────────────────
        private void CargarManoObra(int idOrden)
        {
            DataTable dt = controlador.ObtenerManoObra(idOrden);
            dgvManoObra.DataSource = dt;

            if (dgvManoObra.Columns.Count == 0) return;
            dgvManoObra.Columns["Id"].Visible = false;
            dgvManoObra.Columns["Empleado"].HeaderText = "Empleado";
            dgvManoObra.Columns["Horas"].HeaderText = "Horas";
            dgvManoObra.Columns["CostoHora"].HeaderText = "Costo/Hora";
            dgvManoObra.Columns["Subtotal"].HeaderText = "Subtotal";
            dgvManoObra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManoObra.ReadOnly = true;
            dgvManoObra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        

        private void BtnEliminarManoObra_Click(object sender, EventArgs e)
        {
            if (dgvManoObra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Eliminar este registro?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvManoObra.SelectedRows[0].Cells["Id"].Value);
                if (controlador.EliminarManoObra(id))
                {
                    int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);
                    CargarManoObra(idOrden);
                    CargarCostos(idOrden);
                }
            }
        }

        // ── Pestaña Costos ────────────────────────────────────
        private void CargarCostos(int idOrden)
        {
            DataTable dt = controlador.ObtenerCostosProduccion(idOrden);

            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            decimal materiales = Convert.ToDecimal(row["CostoMateriales"]);
            decimal manoObra = Convert.ToDecimal(row["CostoManoObra"]);
            decimal indirectos = Convert.ToDecimal(row["CostoIndirecto"]);
            decimal mermas = Convert.ToDecimal(row["CostoMermas"]);
            decimal total = materiales + manoObra + indirectos + mermas;

            /*lblCostoMateriales.Text = $"Q {materiales:N2}";
            lblCostoManoObra.Text = $"Q {manoObra:N2}";
            lblCostoIndirecto.Text = $"Q {indirectos:N2}";
            lblCostoMermas.Text = $"Q {mermas:N2}";
            lblCostoTotal.Text = $"Q {total:N2}";*/

            DataTable desglose = new DataTable();
            desglose.Columns.Add("Categoria", typeof(string)); // 👈 sin acento
            desglose.Columns.Add("Monto", typeof(decimal));

            desglose.Rows.Add("Materiales", materiales);
            desglose.Rows.Add("Mano de obra", manoObra);
            desglose.Rows.Add("Costos indirectos", indirectos);
            desglose.Rows.Add("Mermas", mermas);
            desglose.Rows.Add("TOTAL", total);

            dgvCostos.DataSource = desglose;
            dgvCostos.Columns["Categoria"].HeaderText = "Categoría";
            dgvCostos.Columns["Monto"].HeaderText = "Monto (Q)";
            dgvCostos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCostos.ReadOnly = true;
        }

        private void CargarComboEmpleados()
        {
            DataTable dt = controlador.ObtenerEmpleados();
            cboEmpleado.DataSource = dt;
            cboEmpleado.DisplayMember = "NombreCompleto";
            cboEmpleado.ValueMember = "IdEmpleado";
            cboEmpleado.SelectedIndex = -1;
        }

        private void BtnGuardarManoObra_Click(object sender, EventArgs e)
        {
            if (Cbo_Orden.SelectedValue == null || Cbo_Orden.SelectedValue is DataRowView)
            {
                MessageBox.Show("Seleccione una orden primero.");
                return;
            }

            if (cboEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }

            if (nudHoras.Value <= 0)
            {
                MessageBox.Show("Las horas deben ser mayor a 0.");
                return;
            }

            if (nudCostoHora.Value <= 0)
            {
                MessageBox.Show("El costo por hora debe ser mayor a 0.");
                return;
            }

            int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue); // 👈 declarar aquí
            int idEmpleado = Convert.ToInt32(cboEmpleado.SelectedValue);

            bool exito = controlador.GuardarManoObra(
                idOrden,
                idEmpleado,
                nudHoras.Value,
                nudCostoHora.Value);

            if (exito)
            {
                MessageBox.Show("Mano de obra registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboEmpleado.SelectedIndex = -1;
                nudHoras.Value = 0;
                nudCostoHora.Value = 0;
                CargarManoObra(idOrden);
                CargarCostos(idOrden);
            }
            else
            {
                MessageBox.Show("Error al guardar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ############### COSTOS INDIRECTOS #########################################

        private void CargarCostosIndirectos(int idOrden)
        {
            DataTable dt = controlador.ObtenerCostosIndirectos(idOrden);
            dgvCostosIndirectos.DataSource = dt;

            if (dgvCostosIndirectos.Columns.Count == 0) return;
            dgvCostosIndirectos.Columns["Id"].Visible = false;
            dgvCostosIndirectos.Columns["Concepto"].HeaderText = "Concepto";
            dgvCostosIndirectos.Columns["Monto"].HeaderText = "Monto (Q)";
            dgvCostosIndirectos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvCostosIndirectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCostosIndirectos.ReadOnly = true;
            dgvCostosIndirectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnGuardarCostoIndirecto_Click(object sender, EventArgs e)
        {
            if (Cbo_Orden.SelectedValue == null || Cbo_Orden.SelectedValue is DataRowView)
            {
                MessageBox.Show("Seleccione una orden primero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConcepto.Text))
            {
                MessageBox.Show("Ingrese el concepto.");
                return;
            }

            if (nudMonto.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a 0.");
                return;
            }

            int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);

            bool exito = controlador.GuardarCostoIndirecto(
                idOrden,
                txtConcepto.Text.Trim(),
                nudMonto.Value,
                txtDescripcion.Text.Trim());

            

            if (exito)
            {
                MessageBox.Show("Costo indirecto registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConcepto.Text = "";
                nudMonto.Value = 0;
                txtDescripcion.Text = "";
                CargarCostosIndirectos(idOrden);
                CargarCostos(idOrden);
            }


        }

        private void BtnEliminarCostoIndirecto_Click(object sender, EventArgs e)
        {
            if (dgvCostosIndirectos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Eliminar este registro?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvCostosIndirectos.SelectedRows[0].Cells["Id"].Value);
                if (controlador.EliminarCostoIndirecto(id))
                {
                    int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);
                    CargarCostosIndirectos(idOrden);
                    CargarCostos(idOrden);
                }
            }
        }
    }
}
