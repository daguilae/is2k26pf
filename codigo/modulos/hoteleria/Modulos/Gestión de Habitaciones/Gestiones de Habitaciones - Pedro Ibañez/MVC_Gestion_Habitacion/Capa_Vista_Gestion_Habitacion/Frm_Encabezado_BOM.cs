using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Recetas;

// Hecho por: Maria Morales 0901-22-1226
namespace Capa_Vista_CVRecetas
{
    public partial class Frm_Encabezado_BOM : Form
    {
        Controlador con = new Controlador();

        public Frm_Encabezado_BOM()
        {
            InitializeComponent();
            this.Load += Frm_Encabezado_BOM_Load;
            Dg_BOM.CellContentClick += Dg_BOM_CellContentClick;

            Cmb_Id.SelectedIndexChanged += Cmb_Id_SelectedIndexChanged;
            Cmb_Estado.SelectedIndexChanged += Cmb_Estado_SelectedIndexChanged;
            Dtp_Desde.ValueChanged += Dtp_Desde_ValueChanged;
            Dtp_Hasta.ValueChanged += Dtp_Hasta_ValueChanged;
            Btn_Limpiar.Click += Btn_Limpiar_Click;
        }

        // Diego Monterroso 0901-22-1369
        private void Cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }
        // Diego Monterroso 0901-22-1369
        private void Cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }
        // Diego Monterroso 0901-22-1369
        private void Dtp_Desde_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }
        // Diego Monterroso 0901-22-1369
        private void Dtp_Hasta_ValueChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
        }

        private void cargarGrid()
        {
            DataTable dt = con.obtenerListadoBOM();
            Dg_BOM.DataSource = dt;

            // Ocultar ID si existe
            if (Dg_BOM.Columns.Contains("ID"))
                Dg_BOM.Columns["ID"].Visible = false;

            // Agregar botón UNA sola vez
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

        private void EstilizarGrid()
        {
            // Encabezado
            Dg_BOM.EnableHeadersVisualStyles = false;
            Dg_BOM.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 95, 165);
            Dg_BOM.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(230, 241, 251);
            Dg_BOM.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Dg_BOM.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            Dg_BOM.ColumnHeadersHeight = 38;
            Dg_BOM.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Filas
            Dg_BOM.DefaultCellStyle.BackColor = Color.White;
            Dg_BOM.DefaultCellStyle.ForeColor = Color.FromArgb(44, 44, 42);
            Dg_BOM.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            Dg_BOM.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 138, 221);
            Dg_BOM.DefaultCellStyle.SelectionForeColor = Color.White;
            Dg_BOM.DefaultCellStyle.Padding = new Padding(4, 0, 4, 0);
            Dg_BOM.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 241, 251);

            // Bordes y grilla
            Dg_BOM.GridColor = Color.FromArgb(181, 212, 244);
            Dg_BOM.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Dg_BOM.BorderStyle = BorderStyle.FixedSingle;

            // Filas y columnas
            Dg_BOM.RowHeadersVisible = false;
            Dg_BOM.RowTemplate.Height = 32;
            Dg_BOM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dg_BOM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dg_BOM.ReadOnly = false; // el botón de Acciones necesita interacción
            Dg_BOM.AllowUserToAddRows = false;
            Dg_BOM.AllowUserToDeleteRows = false;
        }


        // Diego Monterroso 0901-22-1369
        private void Frm_Encabezado_BOM_Load(object sender, EventArgs e)
        {
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.Add("Todos");
            Cmb_Estado.Items.Add("Activo");
            Cmb_Estado.Items.Add("Inactivo");
            Cmb_Estado.SelectedIndex = 0;

            // Fechas
            Dtp_Desde.Value = DateTime.Today.AddYears(-5);
            Dtp_Hasta.Value = DateTime.Today.AddYears(5);

            // Diego Monterroso 0901-22-1369
            DataTable dt = con.obtenerListadoBOM();
            Cmb_Id.DataSource = dt;
            Cmb_Id.DisplayMember = "ID";     // lo que se muestra
            Cmb_Id.ValueMember = "ID";       // valor real
            Cmb_Id.SelectedIndex = -1;       // que inicie vacío

            cargarGrid();
        }


        private void Dg_BOM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Dg_BOM.Columns[e.ColumnIndex].Name == "Acciones")
            {
                int idBOM = Convert.ToInt32(Dg_BOM.Rows[e.RowIndex].Cells["ID"].Value);

                Frm_Recetas frm = new Frm_Recetas();
                frm.cargarDesdeListado(idBOM);
                frm.ShowDialog();
            }
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
          
            Frm_Recetas fr = new Frm_Recetas();

            fr.Show();
        }
        private void aplicarFiltro()
        {
            string id = "";

            if (Cmb_Id.SelectedIndex != -1)
            {
                id = Cmb_Id.SelectedValue.ToString();
            }
            string estado = Cmb_Estado.Text;

            if (estado == "Todos")
                estado = "";

            DateTime desde = Dtp_Desde.Value.Date;
            DateTime hasta = Dtp_Hasta.Value.Date.AddDays(1).AddSeconds(-1);

            DataTable dt = con.filtrarListadoBOM(id, estado, desde, hasta);
            Dg_BOM.DataSource = dt;

            if (Dg_BOM.Columns.Contains("ID"))
                Dg_BOM.Columns["ID"].Visible = false;

            EstilizarGrid();


        }
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Cmb_Id.DataSource = null;
            DataTable dt = con.obtenerListadoBOM();
            Cmb_Id.DataSource = dt;
            Cmb_Id.DisplayMember = "ID";
            Cmb_Id.ValueMember = "ID";
            Cmb_Id.SelectedIndex = -1;

            // Resetear estado
            Cmb_Estado.SelectedIndex = 0;

            // Resetear fechas
            Dtp_Desde.Value = DateTime.Today.AddYears(-5);
            Dtp_Hasta.Value = DateTime.Today.AddYears(5);

            // Recargar todo el grid
            cargarGrid();
        }
    }
}

