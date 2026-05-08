using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_recepcion;

namespace Capa_Vista_recepcion
{
    public partial class Frm_encabezado : Form
    {
        Controlador con = new Controlador();
        private int idRecepcion = 0;
        public Frm_encabezado()
        {
            InitializeComponent();

            this.Load += Frm_encabezado_Load;
            Dg_BOM.CellContentClick += Dg_BOM_CellContentClick;

            Cmb_Id.SelectedIndexChanged += Cmb_Id_SelectedIndexChanged;
            Cmb_Estado.SelectedIndexChanged += Cmb_Estado_SelectedIndexChanged;
            Dtp_Noti.ValueChanged += Dtp_Desde_ValueChanged;
            Dtp_Ingreso.ValueChanged += Dtp_Hasta_ValueChanged;

            Btn_Limpiar.Click += Btn_Limpiar_Click;
        }

        private void Frm_encabezado_Load(object sender, EventArgs e)
        {
            cargarEstado();
            cargarFechas();
            cargarComboId();
            cargarGrid();
        }

        private void cargarEstado()
        {
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Todos");
            Cmb_Estado.Items.Add("Pendiente");
            Cmb_Estado.Items.Add("Recibido");
            Cmb_Estado.Items.Add("Rechazado");
            Cmb_Estado.SelectedIndex = 0;
        }
        private void Dg_BOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Dg_BOM.Columns[e.ColumnIndex].Name == "Acciones")
            {
                int idRecepcion = Convert.ToInt32(Dg_BOM.Rows[e.RowIndex].Cells["ID"].Value);

                Frm_Detalle_Recepcion frm = new Frm_Detalle_Recepcion();

                frm.cargarRecepcion(idRecepcion);

                frm.ShowDialog();
            }
        }
        private void cargarFechas()
        {
            Dtp_Noti.Value = DateTime.Today.AddYears(-5);
            Dtp_Ingreso.Value = DateTime.Today.AddYears(5);
        }

        private void cargarComboId()
        {
            Cmb_Id.DataSource = null;

            DataTable dt = con.obtenerListadoRecepciones();

            Cmb_Id.DataSource = dt;
            Cmb_Id.DisplayMember = "ID";
            Cmb_Id.ValueMember = "ID";
            Cmb_Id.SelectedIndex = -1;
        }

        private void cargarGrid()
        {
            DataTable dt = con.obtenerListadoRecepciones();
            Dg_BOM.DataSource = dt;

            // Ocultar ID
            if (Dg_BOM.Columns.Contains("ID"))
                Dg_BOM.Columns["ID"].Visible = false;

            // Crear botón solo una vez
            if (!Dg_BOM.Columns.Contains("Acciones"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

                btn.Name = "Acciones";
                btn.HeaderText = "Acciones";
                btn.Text = "Ver detalle";
                btn.UseColumnTextForButtonValue = true;

                Dg_BOM.Columns.Add(btn);
            }

            EstilizarGrid();
        }
        private void aplicarFiltro()
        {
            string id = "";

            if (Cmb_Id.SelectedIndex != -1 && Cmb_Id.SelectedValue != null)
                id = Cmb_Id.SelectedValue.ToString();

            string estado = Cmb_Estado.Text;

            if (estado == "Todos")
                estado = "";

            DateTime desde = Dtp_Noti.Value.Date;
            DateTime hasta = Dtp_Ingreso.Value.Date.AddDays(1).AddSeconds(-1);

            DataTable dt = con.filtrarListadoRecepciones(id, estado, desde, hasta);

            Dg_BOM.DataSource = dt;

            if (Dg_BOM.Columns.Contains("ID"))
                Dg_BOM.Columns["ID"].Visible = false;

            EstilizarGrid();
        }

        private void Cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

        private void Cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

        private void Dtp_Desde_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

        private void Dtp_Hasta_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

       

        private void EstilizarGrid()
        {
            Dg_BOM.EnableHeadersVisualStyles = false;
            Dg_BOM.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 95, 165);
            Dg_BOM.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(230, 241, 251);
            Dg_BOM.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Dg_BOM.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Dg_BOM.ColumnHeadersHeight = 38;
            Dg_BOM.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            Dg_BOM.DefaultCellStyle.BackColor = Color.White;
            Dg_BOM.DefaultCellStyle.ForeColor = Color.FromArgb(44, 44, 42);
            Dg_BOM.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            Dg_BOM.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 138, 221);
            Dg_BOM.DefaultCellStyle.SelectionForeColor = Color.White;
            Dg_BOM.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            Dg_BOM.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 241, 251);

            Dg_BOM.GridColor = Color.FromArgb(181, 212, 244);
            Dg_BOM.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Dg_BOM.BorderStyle = BorderStyle.FixedSingle;

            Dg_BOM.RowHeadersVisible = false;
            Dg_BOM.RowTemplate.Height = 32;
            Dg_BOM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dg_BOM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dg_BOM.ReadOnly = false;
            Dg_BOM.AllowUserToAddRows = false;
            Dg_BOM.AllowUserToDeleteRows = false;
        }
        private void Btn_crear_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Recepcion frm = new Frm_Detalle_Recepcion();
            frm.ShowDialog();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Cmb_Id.DataSource = null;

            DataTable dt = con.obtenerListadoRecepciones();

            Cmb_Id.DataSource = dt;
            Cmb_Id.DisplayMember = "ID";
            Cmb_Id.ValueMember = "ID";
            Cmb_Id.SelectedIndex = -1;

            // Resetear estado
            Cmb_Estado.SelectedIndex = 0;

            // Resetear fechas
            Dtp_Noti.Value = DateTime.Today.AddYears(-5);
            Dtp_Ingreso.Value = DateTime.Today.AddYears(5);

            // Recargar todo el grid
            cargarGrid();
        }


     

    }
}