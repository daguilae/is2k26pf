using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_Expl_Mat;

// Paula Daniela Leonardo Paredes - 0901-22-9580
namespace Capa_Vista_Expl_Mat
{
    public partial class Frm_Expl_Mat : Form
    {
        Cls_Controlador_Expl controlador = new Cls_Controlador_Expl();
        private DataTable _resultadoExplosion;
        private int _idExplosionCargada = 0;

        // Constructor modo nuevo
        public Frm_Expl_Mat()
        {
            InitializeComponent();
            this.Load += Frm_Expl_Mat_Load;
        }

        // Constructor modo consulta
        public Frm_Expl_Mat(int idExplosion)
        {
            InitializeComponent();
            _idExplosionCargada = idExplosion;
            this.Load += Frm_Expl_Mat_Load;
        }

        private void Frm_Expl_Mat_Load(object sender, EventArgs e)
        {
            CargarComboOrdenes();
            ConfigurarGridExplosion();

            if (_idExplosionCargada > 0)
                Btn_guardar.Enabled = false;
        }

        // ─── COMBO ────────────────────────────────────────────────
        private void CargarComboOrdenes()
        {
            // Desuscribir para evitar que se dispare al cargar
            Cmb_OrdenProduccion.SelectedIndexChanged -= Cmb_OrdenProduccion_SelectedIndexChanged;

            DataTable dt = controlador.ObtenerOrdenesRecibidas();
            Cmb_OrdenProduccion.DataSource = null;
            Cmb_OrdenProduccion.DataSource = dt;
            Cmb_OrdenProduccion.DisplayMember = "Descripcion";
            Cmb_OrdenProduccion.ValueMember = "Pk_Id_Orden_Recibida";
            Cmb_OrdenProduccion.SelectedIndex = -1;

            // Suscribir después de cargar
            Cmb_OrdenProduccion.SelectedIndexChanged += Cmb_OrdenProduccion_SelectedIndexChanged;
        }

        private void Cmb_OrdenProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_OrdenProduccion.SelectedIndex < 0) return;
            if (Cmb_OrdenProduccion.SelectedValue == null) return;

            int idOrden = Convert.ToInt32(Cmb_OrdenProduccion.SelectedValue.ToString());
            CargarInfoOrden(idOrden);
            CargarProductosOrden(idOrden);
        }

        // ─── DGV INFORMACIÓN DE LA ORDEN ─────────────────────────
        private void CargarInfoOrden(int idOrden)
        {
            DataTable dt = controlador.ObtenerInfoOrdenRecibida(idOrden);
            Dgv_InformacionOrden.DataSource = dt;

            if (Dgv_InformacionOrden.Columns.Count == 0) return;

            if (Dgv_InformacionOrden.Columns.Contains("No_Orden"))
                Dgv_InformacionOrden.Columns["No_Orden"].HeaderText = "No. Orden";
            if (Dgv_InformacionOrden.Columns.Contains("Plan"))
                Dgv_InformacionOrden.Columns["Plan"].HeaderText = "Plan";
            if (Dgv_InformacionOrden.Columns.Contains("Estado"))
                Dgv_InformacionOrden.Columns["Estado"].HeaderText = "Estado";
            if (Dgv_InformacionOrden.Columns.Contains("Fecha_Inicio"))
                Dgv_InformacionOrden.Columns["Fecha_Inicio"].HeaderText = "Fecha Inicio";
            if (Dgv_InformacionOrden.Columns.Contains("Fecha_Fin"))
                Dgv_InformacionOrden.Columns["Fecha_Fin"].HeaderText = "Fecha Fin";
            if (Dgv_InformacionOrden.Columns.Contains("Fecha_Requerida"))
                Dgv_InformacionOrden.Columns["Fecha_Requerida"].HeaderText = "Fecha Requerida";
            if (Dgv_InformacionOrden.Columns.Contains("Lead_Time"))
                Dgv_InformacionOrden.Columns["Lead_Time"].HeaderText = "Lead Time (días)";

            Dgv_InformacionOrden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_InformacionOrden.ReadOnly = true;
            Dgv_InformacionOrden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_InformacionOrden.MultiSelect = false;
        }

        // ─── DGV PRODUCTOS A FABRICAR ─────────────────────────────
        private void CargarProductosOrden(int idOrden)
        {
            DataTable dt = controlador.ObtenerProductosOrdenRecibida(idOrden);
            Dgv_ProductosAFabricar.DataSource = dt;

            if (Dgv_ProductosAFabricar.Columns.Count == 0) return;

            if (Dgv_ProductosAFabricar.Columns.Contains("Codigo"))
                Dgv_ProductosAFabricar.Columns["Codigo"].HeaderText = "Código";
            if (Dgv_ProductosAFabricar.Columns.Contains("Producto"))
                Dgv_ProductosAFabricar.Columns["Producto"].HeaderText = "Producto";
            if (Dgv_ProductosAFabricar.Columns.Contains("Cantidad"))
                Dgv_ProductosAFabricar.Columns["Cantidad"].HeaderText = "Cantidad";
            if (Dgv_ProductosAFabricar.Columns.Contains("Unidad"))
                Dgv_ProductosAFabricar.Columns["Unidad"].HeaderText = "Unidad";
            if (Dgv_ProductosAFabricar.Columns.Contains("Lead_Time_Dias"))
                Dgv_ProductosAFabricar.Columns["Lead_Time_Dias"].HeaderText = "Lead Time (días)";

            Dgv_ProductosAFabricar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_ProductosAFabricar.ReadOnly = true;
            Dgv_ProductosAFabricar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_ProductosAFabricar.MultiSelect = false;
        }

        // ─── BOTÓN EXPLOTAR BOM ───────────────────────────────────
        private void Btn_ExplotarBOM_Click(object sender, EventArgs e)
        {
            if (Cmb_OrdenProduccion.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una orden de producción.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrden = Convert.ToInt32(Cmb_OrdenProduccion.SelectedValue);
            DataTable bomData = controlador.ObtenerBOMParaExplosion(idOrden);

            if (bomData.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró BOM activo para esta orden.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CalcularYMostrarExplosion(bomData);
        }

        // ─── CÁLCULO DE EXPLOSIÓN ─────────────────────────────────
        private void CalcularYMostrarExplosion(DataTable bomData)
        {
            _resultadoExplosion = new DataTable();
            _resultadoExplosion.Columns.Add("Id_Material", typeof(int));
            _resultadoExplosion.Columns.Add("Producto", typeof(string));
            _resultadoExplosion.Columns.Add("Codigo_MP", typeof(string));
            _resultadoExplosion.Columns.Add("Material", typeof(string));
            _resultadoExplosion.Columns.Add("Unidad", typeof(string));
            _resultadoExplosion.Columns.Add("Cant_Por_Unidad", typeof(decimal));
            _resultadoExplosion.Columns.Add("Pct_Merma", typeof(decimal));
            _resultadoExplosion.Columns.Add("Cant_Total", typeof(decimal));
            _resultadoExplosion.Columns.Add("Cant_Real", typeof(decimal));

            int totalMateriales = 0;

            foreach (DataRow r in bomData.Rows)
            {
                decimal cantSolicitada = Convert.ToDecimal(r["Cantidad_Solicitada"]);
                decimal cantPorUnidad = Convert.ToDecimal(r["Cant_Por_Unidad"]);
                decimal pctMerma = Convert.ToDecimal(r["Pct_Merma"]);

                // Tus únicos dos cálculos
                decimal cantTotal = cantPorUnidad * cantSolicitada;
                decimal cantReal = pctMerma > 0
                    ? cantTotal / (1 - pctMerma / 100)
                    : cantTotal;

                totalMateriales++;

                _resultadoExplosion.Rows.Add(
                    r["Id_Material"],
                    r["Producto"], r["Codigo_MP"],
                    r["Material"], r["Unidad"],
                    cantPorUnidad, pctMerma,
                    Math.Round(cantTotal, 4),
                    Math.Round(cantReal, 4)
                );
            }

            dataGridView1.DataSource = _resultadoExplosion;
            ConfigurarGridExplosion();

            // Solo total de materiales — lo demás no es tu responsabilidad
            Lbl_TotalMateriales.Text = totalMateriales.ToString();
        }

        // ─── CONFIGURAR GRID EXPLOSIÓN ────────────────────────────
        private void ConfigurarGridExplosion()
        {
            if (dataGridView1.Columns.Count == 0) return;

            if (dataGridView1.Columns.Contains("Id_Material"))
                dataGridView1.Columns["Id_Material"].Visible = false;
            if (dataGridView1.Columns.Contains("Tiene_Deficit"))
                dataGridView1.Columns["Tiene_Deficit"].Visible = false;

            string[,] headers = {
    {"Producto",        "Producto"},
    {"Codigo_MP",       "Código MP"},
    {"Material",        "Material"},
    {"Unidad",          "Unidad"},
    {"Cant_Por_Unidad", "Cant/Unidad"},
    {"Pct_Merma",       "% Merma"},
    {"Cant_Total",      "Cant. Total"},
    {"Cant_Real",       "Cant. Real (c/merma)"}
};

            for (int i = 0; i < headers.GetLength(0); i++)
            {
                string col = headers[i, 0];
                if (dataGridView1.Columns.Contains(col))
                    dataGridView1.Columns[col].HeaderText = headers[i, 1];
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void ColorearFilas()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells["Estado"].Value?.ToString() == "Déficit")
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                else
                    fila.DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        // ─── GUARDAR ──────────────────────────────────────────────
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (_resultadoExplosion == null || _resultadoExplosion.Rows.Count == 0)
            {
                MessageBox.Show("Primero debe explotar el BOM.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idOrden = Convert.ToInt32(Cmb_OrdenProduccion.SelectedValue.ToString());
            int idExplosion = controlador.GuardarExplosion(idOrden);

            if (idExplosion > 0)
            {
                bool ok = controlador.GuardarDetalleExplosion(idExplosion, _resultadoExplosion);
                if (ok)
                {
                    MessageBox.Show("Explosión guardada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Btn_guardar.Enabled = false;
                }
                else
                    MessageBox.Show("Error guardando el detalle.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error guardando la explosión.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ─── REFRESCAR ────────────────────────────────────────────
        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            Cmb_OrdenProduccion.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            Dgv_InformacionOrden.DataSource = null;
            Dgv_ProductosAFabricar.DataSource = null;
            _resultadoExplosion = null;
            Btn_guardar.Enabled = true;

            Lbl_TotalMateriales.Text = "";
        }

        // ─── EVENTOS SIN LÓGICA ───────────────────────────────────
        private void Dgv_InformacionOrden_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void Dgv_ProductosAFabricar_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void Gpb_TotalMateriales_Enter(object sender, EventArgs e) { }
        private void Gpb_Stock_Enter(object sender, EventArgs e) { }
        private void Gpb_Deficit_Enter(object sender, EventArgs e) { }
        private void Gpb_Factibilidad_Enter(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void Lbl_TotalMateriales_Click(object sender, EventArgs e) { }
        private void Lbl_ConStock_Click(object sender, EventArgs e) { }
        private void Lbl_ConDeficit_Click(object sender, EventArgs e) { }
        private void Lbl_Factibilidad_Click(object sender, EventArgs e) { }
    }
}
