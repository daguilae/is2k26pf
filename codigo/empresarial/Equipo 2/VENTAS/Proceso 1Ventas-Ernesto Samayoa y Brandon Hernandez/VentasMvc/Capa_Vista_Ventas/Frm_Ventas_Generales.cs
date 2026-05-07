using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Ventas_Generales : Form
    {
        Cls_Ventas_Controlador controlador = new Cls_Ventas_Controlador();

        public Frm_Ventas_Generales()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Frm_Ventas_Generales_Load(object sender, EventArgs e)
        {
            fun_CargarVentas();
            
        }

        private void fun_CargarVentas()
        {
            Dgv_Ventas_Generales.DataSource = controlador.ObtenerListadoVentas();
            Dgv_Ventas_Generales.Columns["IdVenta"].HeaderText = "ID Venta";
            Dgv_Ventas_Generales.Columns["Fecha"].HeaderText = "Fecha";
            Dgv_Ventas_Generales.Columns["Cliente"].HeaderText = "Cliente";
            Dgv_Ventas_Generales.Columns["TipoCliente"].HeaderText = "Tipo Cliente";
            Dgv_Ventas_Generales.Columns["TipoOperacion"].HeaderText = "Tipo Operacion";
            Dgv_Ventas_Generales.Columns["Total"].HeaderText = "Total";
        }

        private void Btn_Agregar_Ventas_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Ventas detalle_Ventas = new Frm_Detalle_Ventas();


            //(MDI + CENTRADO)
            detalle_Ventas.MdiParent = this.MdiParent;
            detalle_Ventas.StartPosition = FormStartPosition.CenterParent;

            //ESCUCHAR CUANDO SE GUARDA
            detalle_Ventas.VentaGuardada += () =>
            {
                fun_CargarVentas(); //Recarga automática del grid
            };

            detalle_Ventas.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_Ventas_Generales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                if (Dgv_Ventas_Generales.Rows[e.RowIndex].Cells["TipoOperacion"].Value != null)
                {
                    string tipo = Dgv_Ventas_Generales.Rows[e.RowIndex]
                        .Cells["TipoOperacion"]
                        .Value.ToString();

                    // VENTA
                    if (tipo == "Venta")
                    {
                        Dgv_Ventas_Generales.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        Dgv_Ventas_Generales.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }

                    // COTIZACION
                    else if (tipo == "Cotizacion")
                    {
                        Dgv_Ventas_Generales.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Khaki;
                        Dgv_Ventas_Generales.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }

                    // PEDIDO
                    else if (tipo == "Pedido")
                    {
                        Dgv_Ventas_Generales.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
                        Dgv_Ventas_Generales.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch
            {

            }
        }

        private void Btn_Reporte_Ventas_Click(object sender, EventArgs e)
        {
            Rpt_Ventas_Generales rpt = new Rpt_Ventas_Generales();
            rpt.Show();
        }
    }
}

