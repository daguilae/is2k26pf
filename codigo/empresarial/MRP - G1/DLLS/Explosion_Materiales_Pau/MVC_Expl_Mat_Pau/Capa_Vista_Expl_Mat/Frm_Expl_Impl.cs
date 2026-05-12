using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Expl_Mat;
using System.Drawing;
using System.Linq;

namespace Capa_Vista_Expl_Mat
// PAULA DANIELA LEONARDO PAREDES  0901-22-9580
{
    public partial class Frm_Expl_Impl : Form
    {
        // Paula Daniela Leonardo Paredes - [tu carné] - [fecha]
        Cls_Controlador_Expl controlador = new Cls_Controlador_Expl();

        public Frm_Expl_Impl()
        {
            InitializeComponent();
            this.Load += Frm_Expl_Impl_Load;

            ToolTip tip = new ToolTip();
            tip.IsBalloon = true; 
            tip.ToolTipTitle = "Búsqueda de Órdenes";
            tip.SetToolTip(Cmb_OrdenProduccion, "Seleccione o escriba el número de orden para realizar la implosión.");
        }

        private void Frm_Expl_Impl_Load(object sender, EventArgs e)
        {
            // Configurar DateTimePickers igual que Kevin
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker2.ShowCheckBox = true;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;

            ObtenerOrdenesRecibidas();
            Btn_GenerarOrdenLogistica.Enabled = false;
            Cmb_OrdenProduccion.SelectedIndexChanged
                += Cmb_OrdenProduccion_SelectedIndexChanged;

            CargarGrid();

            // Eventos
            Txt_BuscarOrden.TextChanged += Filtrar;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;

            // Clic en botón Ver del grid
            Dgv_InformacionExplosion.CellContentClick
                += Dgv_InformacionExplosion_CellContentClick;


            SendMessage(Cmb_OrdenProduccion.Handle, 0x1703, 0, "Escriba No. de Orden...");

            Cmb_OrdenProduccion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cmb_OrdenProduccion.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CargarGrid()
        {
            Dgv_InformacionExplosion.DataSource = controlador.ObtenerExplosiones();
            ConfigurarGrid();
            AgregarBotonVer();
        }

        private void ConfigurarGrid()
        {
            if (Dgv_InformacionExplosion.Columns.Count == 0) return;

            if (Dgv_InformacionExplosion.Columns.Contains("No_Explosion"))
            {
                Dgv_InformacionExplosion.Columns["No_Explosion"].HeaderText = "No. Explosión";
                Dgv_InformacionExplosion.Columns["No_Explosion"].Visible = true;
            }

            if (Dgv_InformacionExplosion.Columns.Contains("No_Orden"))
                Dgv_InformacionExplosion.Columns["No_Orden"].HeaderText = "No. Orden";

            if (Dgv_InformacionExplosion.Columns.Contains("Fecha_Explosion"))
                Dgv_InformacionExplosion.Columns["Fecha_Explosion"].HeaderText = "Fecha Explosión";

            // Ocultar cualquier otra columna que no necesites
            foreach (DataGridViewColumn col in Dgv_InformacionExplosion.Columns)
            {
                if (col.Name != "No_Explosion" && col.Name != "No_Orden"
                    && col.Name != "Fecha_Explosion" && col.Name != "Ver")
                    col.Visible = false;
            }

            Dgv_InformacionExplosion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_InformacionExplosion.ReadOnly = true;
            Dgv_InformacionExplosion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_InformacionExplosion.MultiSelect = false;
        }

        private void AgregarBotonVer()
        {
            if (!Dgv_InformacionExplosion.Columns.Contains("Ver"))
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "Ver";
                btnVer.HeaderText = "Acciones";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                Dgv_InformacionExplosion.Columns.Add(btnVer);
            }
        }

        // Filtro por ID (TextBox)
        private void Filtrar(object sender, EventArgs e)
        {
            string busqueda = Txt_BuscarOrden.Text.Trim();
            Dgv_InformacionExplosion.DataSource = controlador.FiltrarPorNombre(busqueda);
            ConfigurarGrid();
            AgregarBotonVer();
        }

        // Filtro por fechas
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FiltrarSiAmbosChecked();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FiltrarSiAmbosChecked();
        }

        private void FiltrarSiAmbosChecked()
        {
            if (!dateTimePicker1.Checked || !dateTimePicker2.Checked)
            {
                CargarGrid();
                return;
            }

            string fechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            Dgv_InformacionExplosion.DataSource =
                controlador.FiltrarPorFechas(fechaInicio, fechaFin);
            ConfigurarGrid();
            AgregarBotonVer();
        }

        // Botón Ver — abre el detalle de esa explosión
        private void Dgv_InformacionExplosion_CellContentClick(object sender,
                                                                DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (Dgv_InformacionExplosion.Columns[e.ColumnIndex].Name == "Ver")
            {
                var valor = Dgv_InformacionExplosion
                            .Rows[e.RowIndex]
                            .Cells["No_Explosion"].Value;

                if (valor != DBNull.Value && valor != null)
                {
                    int idExplosion = Convert.ToInt32(valor);

                    Frm_Expl_Mat frm = new Frm_Expl_Mat(idExplosion);
                    frm.ShowDialog();
                    CargarGrid();
                }
            }
        }

        // Botón Explosión Nueva
        private void Btn_CrearExplosion_Click(object sender, EventArgs e)
        {
            Frm_Expl_Mat frm = new Frm_Expl_Mat();
            frm.ShowDialog();
            CargarGrid();
        }

        // Buscar por nombre de orden
        private void Txt_BuscarOrden_TextChanged(object sender, EventArgs e)
        {
            string busqueda = Txt_BuscarOrden.Text.Trim();
            Dgv_InformacionExplosion.DataSource = controlador.FiltrarPorNombre(busqueda);
            ConfigurarGrid();
            AgregarBotonVer();
        }

        // Eliminar explosión
        private void Btn_eliminar_explo_Click(object sender, EventArgs e)
        {
            if (Dgv_InformacionExplosion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una explosión para eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valor = Dgv_InformacionExplosion
                            .SelectedRows[0]
                            .Cells["No_Explosion"].Value;

            if (valor == null || valor == DBNull.Value) return;

            int idExplosion = Convert.ToInt32(valor);

            var confirm = MessageBox.Show(
                $"¿Está seguro de eliminar la explosión No. {idExplosion}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool ok = controlador.EliminarExplosion(idExplosion);
                if (ok)
                {
                    MessageBox.Show("Explosión eliminada correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                }
                else
                    MessageBox.Show("Error al eliminar la explosión.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refrescar encabezado
        private void Btn_Ref_Click(object sender, EventArgs e)
        {
            Txt_BuscarOrden.Text = "";
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            CargarGrid();
        }

        private void ImplPage_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Implosion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // PAULA DANIELA LEONARDO PAREDES  0901-22-9580


        //DANIELA

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);

        private DataTable _datosImplosion;

        private void ObtenerOrdenesRecibidas()
        {
            DataTable dt = controlador.ObtenerOrdenesRecibidas();
            Cmb_OrdenProduccion.DataSource = dt;
            Cmb_OrdenProduccion.DisplayMember = "No_Orden";  
            Cmb_OrdenProduccion.ValueMember = "Pk_Id_Orden_Recibida";
            Cmb_OrdenProduccion.SelectedIndex = -1;
        }

        private void Cmb_OrdenProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_OrdenProduccion.SelectedValue == null) return;

            int idOrden = Convert.ToInt32(Cmb_OrdenProduccion.SelectedValue);
            _datosImplosion = controlador.ObtenerImplosion(idOrden);

            Dgv_Implosion.DataSource = _datosImplosion;
            ConfigurarGridImplosion();
            EvaluarSiHayFaltante();
        }

        private void ConfigurarGridImplosion()
        {
            if (Dgv_Implosion.Columns.Count == 0) return;

            // Ocultar columna Id
            if (Dgv_Implosion.Columns.Contains("Id_Material"))
                Dgv_Implosion.Columns["Id_Material"].Visible = false;

            // Headers legibles
            if (Dgv_Implosion.Columns.Contains("Material"))
                Dgv_Implosion.Columns["Material"].HeaderText = "Material";
            if (Dgv_Implosion.Columns.Contains("Cantidad_Requerida"))
                Dgv_Implosion.Columns["Cantidad_Requerida"].HeaderText = "Requerido (Explosión)";
            if (Dgv_Implosion.Columns.Contains("Stock_Actual"))
                Dgv_Implosion.Columns["Stock_Actual"].HeaderText = "Stock Actual";
            if (Dgv_Implosion.Columns.Contains("Faltante"))
                Dgv_Implosion.Columns["Faltante"].HeaderText = "Faltante (Implosión)";

            Dgv_Implosion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Implosion.ReadOnly = true;

            // Pintar filas con faltante en rojo claro
            foreach (DataGridViewRow row in Dgv_Implosion.Rows)
            {
                if (row.IsNewRow) continue;
                decimal faltante = Convert.ToDecimal(row.Cells["Faltante"].Value);
                row.DefaultCellStyle.BackColor = faltante > 0
                    ? Color.FromArgb(255, 200, 200)   //rojo
                    : Color.FromArgb(200, 255, 200);  // verde 
            }
        }

        private void EvaluarSiHayFaltante()
        {
            if (_datosImplosion == null || _datosImplosion.Rows.Count == 0)
            {
                Btn_GenerarOrdenLogistica.Enabled = false;
                Lbl_EstadoImplosion.Text = "Sin datos de explosión para esta orden.";
                return;
            }

            bool hayFaltante = false;
            foreach (DataRow row in _datosImplosion.Rows)
            {
                if (Convert.ToDecimal(row["Faltante"]) > 0)
                {
                    hayFaltante = true;
                    break;
                }
            }

            Btn_GenerarOrdenLogistica.Enabled = hayFaltante;
            Lbl_EstadoImplosion.Text = hayFaltante
                ? "⚠ Hay materiales faltantes. Puede generar la orden."
                : "✔ Stock suficiente. No se requiere orden.";
        }


        private void Btn_GenerarOrdenLogistica_Click_1(object sender, EventArgs e)
        {
            if (_datosImplosion == null) return;

            int idOrden = Convert.ToInt32(Cmb_OrdenProduccion.SelectedValue);

            // Validación antes de guardar
            if (controlador.OrdenYaGenerada(idOrden))
            {
                MessageBox.Show(
                    "Ya existe una orden de material para esta orden de producción.",
                    "Orden duplicada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Btn_GenerarOrdenLogistica.Enabled = false;
                return;
            }


            // Arón Ricardo Esquit Silva 0901-22-13036 11/05/2026
            RespuestaApiOrdenMaterial respuesta = controlador.GenerarYEnviarOrdenMaterialApi(idOrden, _datosImplosion);

            if (respuesta.Exitoso)
            {
                MessageBox.Show(
                    "Orden generada y enviada a Logística correctamente.\n\n" +
                    "ID Orden Material: " + respuesta.IdOrdenMaterial + "\n" +
                    "ID Venta Logística: " + respuesta.IdVentaLogistica,
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Btn_GenerarOrdenLogistica.Enabled = false;
                Lbl_EstadoImplosion.Text = "Orden generada y enviada a Logística.";
            }


            else if (respuesta.IdOrdenMaterial > 0)
            {
                MessageBox.Show(
                    "Orden guardada correctamente, pero no se pudo enviar a Logística.\n\n" +
                    "Detalle: " + respuesta.Mensaje,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Btn_GenerarOrdenLogistica.Enabled = false;
                Lbl_EstadoImplosion.Text = " Orden guardada. Pendiente de envío a Logística.";
            }

            else
            {
                MessageBox.Show(
                    "Error al guardar la orden.\n\nDetalle: " + respuesta.Mensaje,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Lbl_EstadoImplosion.Text = "Error al generar la orden.";
            }
        }



        private void Dgv_Implosion_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Cmb_OrdenProduccion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Cmb_OrdenProduccion.SelectedValue != null && Cmb_OrdenProduccion.ValueMember != "")
            {
                Cmb_OrdenProduccion_SelectedIndexChanged(sender, e);
            }
        }

        private void Btn_BuscarOtraOrden_Click(object sender, EventArgs e)
        {
            Cmb_OrdenProduccion.SelectedIndex = -1;
            Dgv_Implosion.DataSource = null;
            _datosImplosion = null;
            Btn_GenerarOrdenLogistica.Enabled = false;
            Lbl_EstadoImplosion.Text = "";
            Cmb_OrdenProduccion.Focus();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            if (Cmb_OrdenProduccion.SelectedValue == null) return;
            Cmb_OrdenProduccion_SelectedIndexChanged(null, null);
        }

        //DANIELA SALGUERO
    }
}