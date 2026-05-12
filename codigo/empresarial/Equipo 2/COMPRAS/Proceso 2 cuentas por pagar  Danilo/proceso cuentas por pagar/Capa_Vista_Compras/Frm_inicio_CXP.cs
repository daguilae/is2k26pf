using System;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_CXP;
using Capa_Vista_CXP;
using Capa_Vista_Compras;

namespace Capa_Vista_Compras
{
    public partial class Frm_inicio_CXP : Form
    {
        private readonly Cls_Compras_Controlador cm = new Cls_Compras_Controlador();

        public Frm_inicio_CXP()
        {
            InitializeComponent();

            this.Load += Frm_inicio_CXP_Load;

            Btn_ingresar.Click += Btn_ingresar_Click;
            Btn_modificar.Click += Btn_modificar_Click;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_salir.Click += Btn_salir_Click;

            Dgv_inicio.CellDoubleClick += Dgv_inicio_CellDoubleClick;
        }

        private void Frm_inicio_CXP_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarCuentas();
        }

        private void ConfigurarGrid()
        {
            Dgv_inicio.ReadOnly = true;
            Dgv_inicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_inicio.MultiSelect = false;
            Dgv_inicio.AllowUserToAddRows = false;
            Dgv_inicio.RowHeadersVisible = false;
            Dgv_inicio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarCuentas()
        {
            Dgv_inicio.DataSource = cm.ObtenerTodasCuentas();
            ConfigurarEncabezados();
            PintarFilas();
        }

        private void ConfigurarEncabezados()
        {
            if (Dgv_inicio.Columns.Count == 0)
                return;

            if (Dgv_inicio.Columns.Contains("IdCuentaPorPagar"))
                Dgv_inicio.Columns["IdCuentaPorPagar"].HeaderText = "Id CXP";

            if (Dgv_inicio.Columns.Contains("IdCompra"))
                Dgv_inicio.Columns["IdCompra"].HeaderText = "Id Compra";

            if (Dgv_inicio.Columns.Contains("NumeroFactura"))
                Dgv_inicio.Columns["NumeroFactura"].HeaderText = "No. Factura";

            if (Dgv_inicio.Columns.Contains("FechaFactura"))
                Dgv_inicio.Columns["FechaFactura"].HeaderText = "Fecha";

            if (Dgv_inicio.Columns.Contains("Proveedor"))
                Dgv_inicio.Columns["Proveedor"].HeaderText = "Proveedor";

            if (Dgv_inicio.Columns.Contains("TotalCompra"))
                Dgv_inicio.Columns["TotalCompra"].HeaderText = "Total";

            if (Dgv_inicio.Columns.Contains("TotalPagado"))
                Dgv_inicio.Columns["TotalPagado"].HeaderText = "Pagado";

            if (Dgv_inicio.Columns.Contains("SaldoPendiente"))
                Dgv_inicio.Columns["SaldoPendiente"].HeaderText = "Saldo";

            if (Dgv_inicio.Columns.Contains("Estado"))
                Dgv_inicio.Columns["Estado"].HeaderText = "Estado";
        }

        private void PintarFilas()
        {
            foreach (DataGridViewRow row in Dgv_inicio.Rows)
            {
                string estado = row.Cells["Estado"].Value?.ToString()?.ToLower();

                if (estado == "pendiente")
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                else if (estado == "parcial")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if (estado == "pagado")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private int ObtenerIdCompraSeleccionada()
        {
            if (Dgv_inicio.CurrentRow == null)
                return 0;

            return Convert.ToInt32(Dgv_inicio.CurrentRow.Cells["IdCompra"].Value);
        }

        private void AbrirCompraSeleccionada()
        {
            int idCompra = ObtenerIdCompraSeleccionada();

            if (idCompra <= 0)
            {
                MessageBox.Show("Seleccione una cuenta por pagar.");
                return;
            }

            Frm_Compras_CXP frm = new Frm_Compras_CXP(idCompra);
            frm.ShowDialog();

            CargarCuentas();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            AbrirCompraSeleccionada();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            AbrirCompraSeleccionada();
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarCuentas();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_inicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            AbrirCompraSeleccionada();
        }

        private void Btn_ingresar_Click_1(object sender, EventArgs e)
        {
            Frm_Compra_manual frm = new Frm_Compra_manual();
            frm.ShowDialog();

          
        }
    }
}