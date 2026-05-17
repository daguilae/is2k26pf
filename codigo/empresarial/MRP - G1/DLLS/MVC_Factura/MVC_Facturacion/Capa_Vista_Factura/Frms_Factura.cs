using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Factura;

// Paula Daniela Leonardo Paredes - 0901-22-9580
namespace Capa_Vista_Factura
{
    public partial class Frms_Factura : Form
    {
        Cls_Controlador_Fac controlador = new Cls_Controlador_Fac();

        public Frms_Factura()
        {
            InitializeComponent();
        }

        private void Frms_Factura_Load(object sender, EventArgs e)
        {
            // Configurar DateTimePicker
            Dtp_Emision.ShowCheckBox = true;
            Dtp_Emision.Checked = false;
            Dtp_Emision.Value = DateTime.Today;

            // Cargar combo de órdenes
            CargarComboOrdenes();

            // Cargar grid
            CargarGrid();

            // Eventos
            Txt_NoFactura.TextChanged += Txt_NoFactura_TextChanged;
            Dtp_Emision.ValueChanged += Dtp_Emision_ValueChanged;
            Cmb_OrdenRecibida.SelectedIndexChanged += Cmb_OrdenRecibida_SelectedIndexChanged;
        }

        // ─── COMBO ÓRDENES ────────────────────────────────────────
        private void CargarComboOrdenes()
        {
            Cmb_OrdenRecibida.SelectedIndexChanged -= Cmb_OrdenRecibida_SelectedIndexChanged;

            DataTable dt = controlador.ObtenerOrdenesRecibidas();

            // Agregar opción "Todas" al inicio
            DataRow todos = dt.NewRow();
            todos["Pk_Id_Orden_Recibida"] = 0;
            todos["Nombre_Orden"] = "Todas las órdenes";
            dt.Rows.InsertAt(todos, 0);

            Cmb_OrdenRecibida.DataSource = dt;
            Cmb_OrdenRecibida.DisplayMember = "Nombre_Orden";
            Cmb_OrdenRecibida.ValueMember = "Pk_Id_Orden_Recibida";
            Cmb_OrdenRecibida.SelectedIndex = 0;

            Cmb_OrdenRecibida.SelectedIndexChanged += Cmb_OrdenRecibida_SelectedIndexChanged;
        }

        // ─── GRID ─────────────────────────────────────────────────
        private void CargarGrid()
        {
            Dgv_Facturas.DataSource = controlador.ObtenerFacturas();
            ConfigurarGrid();
            AgregarBotonVer();
        }

        private void ConfigurarGrid()
        {
            if (Dgv_Facturas.Columns.Count == 0) return;

            // Ocultar PK
            if (Dgv_Facturas.Columns.Contains("No_Factura"))
            {
                Dgv_Facturas.Columns["No_Factura"].HeaderText = "No. Factura";
                Dgv_Facturas.Columns["No_Factura"].Visible = true;
            }
            if (Dgv_Facturas.Columns.Contains("ID_Orden"))
                Dgv_Facturas.Columns["ID_Orden"].Visible = false;
            if (Dgv_Facturas.Columns.Contains("Nombre_Orden"))
                Dgv_Facturas.Columns["Nombre_Orden"].HeaderText = "Orden Recibida";
            if (Dgv_Facturas.Columns.Contains("Fecha_Emision"))
                Dgv_Facturas.Columns["Fecha_Emision"].HeaderText = "Fecha Emisión";
            if (Dgv_Facturas.Columns.Contains("Total"))
                Dgv_Facturas.Columns["Total"].HeaderText = "Total Factura";

            Dgv_Facturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Facturas.ReadOnly = true;
            Dgv_Facturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Facturas.MultiSelect = false;
        }

        private void AgregarBotonVer()
        {
            if (!Dgv_Facturas.Columns.Contains("Ver"))
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
                btnVer.Name = "Ver";
                btnVer.HeaderText = "Acciones";
                btnVer.Text = "Ver";
                btnVer.UseColumnTextForButtonValue = true;
                Dgv_Facturas.Columns.Add(btnVer);
            }
        }

        // ─── FILTROS ──────────────────────────────────────────────

        // Filtro por No. Factura
        private void Txt_NoFactura_TextChanged(object sender, EventArgs e)
        {
            string busqueda = Txt_NoFactura.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
                CargarGrid();
            else
            {
                Dgv_Facturas.DataSource = controlador.FiltrarPorNumero(busqueda);
                ConfigurarGrid();
                AgregarBotonVer();
            }
        }

        // Filtro por fecha de emisión
        private void Dtp_Emision_ValueChanged(object sender, EventArgs e)
        {
            if (!Dtp_Emision.Checked)
            {
                CargarGrid();
                return;
            }

            string fecha = Dtp_Emision.Value.ToString("yyyy-MM-dd");
            Dgv_Facturas.DataSource = controlador.FiltrarPorFecha(fecha);
            ConfigurarGrid();
            AgregarBotonVer();
        }

        // Filtro por orden recibida
        private void Cmb_OrdenRecibida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_OrdenRecibida.SelectedValue == null) return;

            int idOrden = Convert.ToInt32(Cmb_OrdenRecibida.SelectedValue.ToString());

            if (idOrden == 0)
                CargarGrid();
            else
            {
                string nombreOrden = Cmb_OrdenRecibida.Text;
                Dgv_Facturas.DataSource = controlador.FiltrarPorOrden(nombreOrden);
                ConfigurarGrid();
                AgregarBotonVer();
            }
        }

        private void Dgv_Facturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (Dgv_Facturas.Columns[e.ColumnIndex].Name == "Ver")
            {
                var valor = Dgv_Facturas
                                .Rows[e.RowIndex]
                                .Cells["No_Factura"].Value;

                if (valor != DBNull.Value && valor != null)
                {
                    int idFactura = Convert.ToInt32(valor);
                    Frm_Detalle_Facturacion frm = new Frm_Detalle_Facturacion(idFactura);
                    frm.ShowDialog();

                    // frm.ShowDialog();
                    // CargarGrid();
                }
            }
        }

        // ─── BOTÓN VER ────────────────────────────────────────────

    }
}
