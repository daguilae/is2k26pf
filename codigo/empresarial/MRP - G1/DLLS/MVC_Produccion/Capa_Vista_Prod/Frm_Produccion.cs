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
                CargarComboTiposMerma(); // este para el merma
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
            CargarMaterialesConsumidos(idOrden);
            CargarCostos(idOrden);
            // Metodos para mermas 
            CargarMermas(idOrden);               
            CargarComboMaterialesMerma(idOrden);
        }

        // ── Pestaña Mano de Obra ──────────────────────────────
        private void CargarManoObra(int idOrden)
        {
            DataTable dt = controlador.ObtenerManoObra(idOrden);
            dgvManoObra.DataSource = dt;
            Cls_Estilos_DGV.Aplicar(dgvManoObra);

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
            Cls_Estilos_DGV.Aplicar(dgvCostos);
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
            Cls_Estilos_DGV.Aplicar(dgvCostosIndirectos);

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

        // #################### COSTOS INDIRECTOS ####################################################

        // ###################### MATERIAL CONSUMIDO ##################################################
        private void CargarMaterialesConsumidos(int idOrden)
        {
            DataTable dt = controlador.ObtenerMaterialesConsumidos(idOrden);
            dgvMateriales.DataSource = dt;
            Cls_Estilos_DGV.Aplicar(dgvMateriales);

            if (dgvMateriales.Columns.Count == 0) return;
            dgvMateriales.Columns["Id_Material"].Visible = false;
            dgvMateriales.Columns["Material"].HeaderText = "Material";
            dgvMateriales.Columns["Unidad"].HeaderText = "Unidad";
            dgvMateriales.Columns["Cantidad_Necesaria"].HeaderText = "Cantidad Necesaria";
            dgvMateriales.Columns["Cantidad_Con_Merma"].HeaderText = "Cantidad con Merma";
            dgvMateriales.Columns["Costo_Unitario"].HeaderText = "Costo Unitario (Q)";
            dgvMateriales.Columns["Subtotal"].HeaderText = "Subtotal (Q)";
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriales.ReadOnly = true;
            dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Calcular y mostrar total
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
                total += Convert.ToDecimal(row["Subtotal"]);

            lblTotalMateriales.Text = $"Total materiales: Q {total:N2}";
        }

        private void btn_consumir_Click(object sender, EventArgs e)
        {
            if (Cbo_Orden.SelectedValue == null || Cbo_Orden.SelectedValue is DataRowView)
            {
                MessageBox.Show("Seleccione una orden primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvMateriales.Rows.Count == 0)
            {
                MessageBox.Show("No hay materiales para consumir.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Confirmar el consumo de materiales del inventario?\nEsta acción no se puede deshacer.",
                "Confirmar consumo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);

                if (controlador.DescontarMateriales(idOrden))
                {
                    MessageBox.Show("Materiales descontados del inventario correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar la pestaña de materiales y costos
                    CargarMaterialesConsumidos(idOrden);
                    CargarCostos(idOrden);

                    // Opcional: deshabilitar el botón para evitar doble consumo
                    btn_consumir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consumir materiales:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ###################### MATERIAL CONSUMIDO ##################################################


        // ##################### MERMAS ###############################################################
        private void CargarComboTiposMerma()
        {
            DataTable dt = controlador.ObtenerTiposMerma();
            cboTipoMerma.DataSource = dt;
            cboTipoMerma.DisplayMember = "Nombre";
            cboTipoMerma.ValueMember = "IdTipo";
            cboTipoMerma.SelectedIndex = -1;
        }

        private void CargarComboMaterialesMerma(int idOrden)
        {
            DataTable dt = controlador.ObtenerMaterialesPorOrden(idOrden);
            cboMaterial.DataSource = dt;
            cboMaterial.DisplayMember = "Nombre";
            cboMaterial.ValueMember = "IdMaterial";
            cboMaterial.SelectedIndex = -1;
        }

        private void CargarMermas(int idOrden)
        {
            DataTable dt = controlador.ObtenerMermas(idOrden);
            dgvMermas.DataSource = dt;
            Cls_Estilos_DGV.Aplicar(dgvMermas);

            if (dgvMermas.Columns.Count == 0) return;

            dgvMermas.Columns["Id"].Visible = false;
            dgvMermas.Columns["Material"].HeaderText = "Material";
            dgvMermas.Columns["Tipo"].HeaderText = "Tipo de Merma";
            dgvMermas.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvMermas.Columns["CostoUnitario"].HeaderText = "Costo Unitario (Q)";
            dgvMermas.Columns["Subtotal"].HeaderText = "Subtotal (Q)";
            dgvMermas.Columns["Motivo"].HeaderText = "Motivo";
            dgvMermas.Columns["Fecha"].HeaderText = "Fecha";
            dgvMermas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMermas.ReadOnly = true;
            dgvMermas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Total
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
                total += Convert.ToDecimal(row["Subtotal"]);

            lblTotalMermas.Text = $"Total mermas: Q {total:N2}";
        }

        private void btnGuardarMerma_Click(object sender, EventArgs e)
        {
            if (Cbo_Orden.SelectedValue == null || Cbo_Orden.SelectedValue is DataRowView)
            {
                MessageBox.Show("Seleccione una orden primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMaterial.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un material.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTipoMerma.SelectedValue == null)
            {
                MessageBox.Show("Seleccione el tipo de merma.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudCantidadMerma.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivoMerma.Text))
            {
                MessageBox.Show("Ingrese el motivo de la merma.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);
            int idMaterial = Convert.ToInt32(cboMaterial.SelectedValue);
            int idTipo = Convert.ToInt32(cboTipoMerma.SelectedValue);

            bool exito = controlador.GuardarMerma(
                idOrden, idMaterial, idTipo,
                nudCantidadMerma.Value,
                txtMotivoMerma.Text.Trim());

            if (exito)
            {
                MessageBox.Show("Merma registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                cboMaterial.SelectedIndex = -1;
                cboTipoMerma.SelectedIndex = -1;
                nudCantidadMerma.Value = 0;
                txtMotivoMerma.Text = "";

                // Refrescar
                CargarMermas(idOrden);
                CargarCostos(idOrden); // actualiza la pestaña de costos también
            }
            else
            {
                MessageBox.Show("Error al registrar la merma.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarMerma_Click(object sender, EventArgs e)
        {
            if (dgvMermas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("¿Eliminar esta merma?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvMermas.SelectedRows[0].Cells["Id"].Value);

                if (controlador.EliminarMerma(id))
                {
                    int idOrden = Convert.ToInt32(Cbo_Orden.SelectedValue);
                    CargarMermas(idOrden);
                    CargarCostos(idOrden);
                }
                else
                {
                    MessageBox.Show("Error al eliminar.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // ##################### MERMAS ###############################################################

        // ######################## DISEÑO DE FORMULARIOS ##############################################
        public static class Cls_Estilos_DGV
        {
            // Paleta de colores — cámbiala a tu gusto
            private static readonly Color ColorEncabezado = Color.FromArgb(34, 74, 112);   // Azul oscuro
            private static readonly Color ColorFilaImpar = Color.FromArgb(245, 248, 252);  // Blanco azulado
            private static readonly Color ColorFilaPar = Color.White;
            private static readonly Color ColorSeleccion = Color.FromArgb(173, 214, 255);  // Azul claro
            private static readonly Color ColorTextoEncabezado = Color.White;
            private static readonly Color ColorTextoCelda = Color.FromArgb(40, 40, 40);     // Casi negro
            private static readonly Color ColorBorde = Color.FromArgb(210, 220, 235);

            public static void Aplicar(DataGridView dgv)
            {
                // ── Comportamiento general ──────────────────────────────
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.GridColor = ColorBorde;
                dgv.RowHeadersVisible = false;
                dgv.AllowUserToResizeRows = false;
                dgv.AllowUserToAddRows = false;
                dgv.BackgroundColor = Color.White;

                // ── Fuente general ──────────────────────────────────────
                dgv.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

                // ── Encabezado ──────────────────────────────────────────
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorEncabezado;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorTextoEncabezado;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
                dgv.ColumnHeadersHeight = 38;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                // ── Celdas ──────────────────────────────────────────────
                dgv.DefaultCellStyle.ForeColor = ColorTextoCelda;
                dgv.DefaultCellStyle.SelectionBackColor = ColorSeleccion;
                dgv.DefaultCellStyle.SelectionForeColor = ColorTextoCelda;
                dgv.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgv.RowTemplate.Height = 32;

                // ── Filas alternadas ────────────────────────────────────
                dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorFilaImpar;
                dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = ColorSeleccion;
                dgv.RowsDefaultCellStyle.BackColor = ColorFilaPar;

                // ── Evento para pintar filas en tiempo real ─────────────
                dgv.RowPrePaint += (s, e) =>
                {
                    e.PaintParts &= ~DataGridViewPaintParts.Focus;
                };
            }

            // Centra columnas específicas (para montos, cantidades, fechas)
            public static void CentrarColumnas(DataGridView dgv, params string[] columnas)
            {
                foreach (string col in columnas)
                {
                    if (dgv.Columns.Contains(col))
                        dgv.Columns[col].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleCenter;
                }
            }

            // Alinea a la derecha (ideal para montos en Q)
            public static void AlinearDerechaCols(DataGridView dgv, params string[] columnas)
            {
                foreach (string col in columnas)
                {
                    if (dgv.Columns.Contains(col))
                        dgv.Columns[col].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void nudHoras_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // ######################## DISEÑO DE FORMULARIOS ##############################################



    }


}
