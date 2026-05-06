using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Expl_Mat;

namespace Capa_Vista_Expl_Mat
{
    public partial class Frm_Expl_Impl : Form
    {
        // Paula Daniela Leonardo Paredes - [tu carné] - [fecha]
        Cls_Controlador_Expl controlador = new Cls_Controlador_Expl();

        public Frm_Expl_Impl()
        {
            InitializeComponent();
            this.Load += Frm_Expl_Impl_Load;
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

            CargarGrid();

            // Eventos
            Txt_BuscarOrden.TextChanged += Filtrar;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;

            // Clic en botón Ver del grid
            Dgv_InformacionExplosion.CellContentClick
                += Dgv_InformacionExplosion_CellContentClick;
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

            // Ocultar PK
            if (Dgv_InformacionExplosion.Columns.Contains("Pk_Id_Explosion"))
                Dgv_InformacionExplosion.Columns["Pk_Id_Explosion"].Visible = false;

            // Encabezados legibles
            if (Dgv_InformacionExplosion.Columns.Contains("Orden"))
                Dgv_InformacionExplosion.Columns["Orden"].HeaderText = "N° Orden";

            if (Dgv_InformacionExplosion.Columns.Contains("Producto"))
                Dgv_InformacionExplosion.Columns["Producto"].HeaderText = "Producto";

            if (Dgv_InformacionExplosion.Columns.Contains("Fecha_Explosion"))
                Dgv_InformacionExplosion.Columns["Fecha_Explosion"].HeaderText = "Fecha Explosión";

            if (Dgv_InformacionExplosion.Columns.Contains("Factibilidad"))
                Dgv_InformacionExplosion.Columns["Factibilidad"].HeaderText = "Factibilidad";

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
            string idBusqueda = Txt_BuscarOrden.Text.Trim();
            Dgv_InformacionExplosion.DataSource = controlador.FiltrarPorId(idBusqueda);
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
                                .Cells["Pk_Id_Explosion"].Value;

                if (valor != DBNull.Value && valor != null)
                {
                    int idExplosion = Convert.ToInt32(valor);
                    //Frm_Expl_Mat frm = new Frm_Expl_Mat(idExplosion);
                   // frm.ShowDialog();
                   // CargarGrid();
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
    }
}