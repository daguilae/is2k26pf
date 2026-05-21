using Capa_Controlador_Compras;
using Capa_Vista_CXP;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Vista_Compras
{
    public partial class Frm_inicio_devoluciones_d : Form
    {
        private readonly Cls_Devoluciones_Controlador controlador = new Cls_Devoluciones_Controlador();

        public Frm_inicio_devoluciones_d()
        {
            InitializeComponent();

            this.Load += Frm_inicio_devoluciones_d_Load;

            Btn_ingresar.Click += Btn_ingresar_Click;
            Btn_modificar.Click += Btn_modificar_Click;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_salir.Click += Btn_salir_Click;
            Btn_imprimir.Click += Btn_imprimir_Click;

            Dgv_devoluciones.CellDoubleClick += Dgv_devoluciones_CellDoubleClick;
        }

        private void Frm_inicio_devoluciones_d_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarCompras();
        }

        private void ConfigurarGrid()
        {
            Dgv_devoluciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_devoluciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_devoluciones.MultiSelect = false;
            Dgv_devoluciones.ReadOnly = true;
            Dgv_devoluciones.AllowUserToAddRows = false;
            Dgv_devoluciones.RowHeadersVisible = false;
        }

        private void CargarCompras()
        {
            try
            {
                Dgv_devoluciones.DataSource = controlador.MostrarComprasParaDevolucion();
                ConfigurarEncabezados();
                PintarFilas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras para devolución: " + ex.Message);
            }
        }

        private void ConfigurarEncabezados()
        {
            if (Dgv_devoluciones.Columns.Count == 0)
                return;

            if (Dgv_devoluciones.Columns.Contains("IdCompra"))
                Dgv_devoluciones.Columns["IdCompra"].HeaderText = "Id Compra";

            if (Dgv_devoluciones.Columns.Contains("NumeroFactura"))
                Dgv_devoluciones.Columns["NumeroFactura"].HeaderText = "No. Factura";

            if (Dgv_devoluciones.Columns.Contains("Proveedor"))
                Dgv_devoluciones.Columns["Proveedor"].HeaderText = "Proveedor";

            if (Dgv_devoluciones.Columns.Contains("FechaCompra"))
                Dgv_devoluciones.Columns["FechaCompra"].HeaderText = "Fecha Compra";

            if (Dgv_devoluciones.Columns.Contains("TotalCompra"))
                Dgv_devoluciones.Columns["TotalCompra"].HeaderText = "Total Compra";

            if (Dgv_devoluciones.Columns.Contains("EstadoCompra"))
                Dgv_devoluciones.Columns["EstadoCompra"].HeaderText = "Estado";

            if (Dgv_devoluciones.Columns.Contains("TotalDevuelto"))
                Dgv_devoluciones.Columns["TotalDevuelto"].HeaderText = "Total Devuelto";
        }

        private void PintarFilas()
        {
            foreach (DataGridViewRow row in Dgv_devoluciones.Rows)
            {
                string estado = row.Cells["EstadoCompra"].Value?.ToString()?.ToLower();

                if (estado == "pendiente")
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
                else if (estado == "parcial")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if (estado == "pagado")
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (estado == "devuelto")
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }

        private int ObtenerIdCompraSeleccionada()
        {
            if (Dgv_devoluciones.CurrentRow == null)
                return 0;

            return Convert.ToInt32(Dgv_devoluciones.CurrentRow.Cells["IdCompra"].Value);
        }

        private void AbrirCompraSeleccionada()
        {
            try
            {
                int idCompra = ObtenerIdCompraSeleccionada();

                if (idCompra <= 0)
                {
                    MessageBox.Show("Seleccione una compra para continuar.");
                    return;
                }

                Frm_Devoluciones_d frm = new Frm_Devoluciones_d(idCompra);
                frm.ShowDialog();

                CargarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la devolución: " + ex.Message);
            }
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
            CargarCompras();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_Visor_Reportes frm = new Frm_Visor_Reportes("Rpt_Devoluciones_Simple.rpt");
            frm.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_devoluciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            AbrirCompraSeleccionada();
        }
    }
}