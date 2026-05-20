using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            // ==========================================
            // BOTON DETALLE
            // ==========================================
            if (!Dgv_Ventas_Generales.Columns.Contains("Detalle"))
            {
                DataGridViewButtonColumn btnDetalle =
                    new DataGridViewButtonColumn();

                btnDetalle.Name = "Detalle";
                btnDetalle.HeaderText = "Acción";
                btnDetalle.Text = "Ver";
                btnDetalle.UseColumnTextForButtonValue = true;

                Dgv_Ventas_Generales.Columns.Add(btnDetalle);
            }
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

        private void Dgv_Ventas_Generales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // EVITAR HEADER
                if (e.RowIndex < 0)
                    return;

                // CLICK EN BOTON DETALLE
                if (Dgv_Ventas_Generales.Columns[e.ColumnIndex].Name
                    == "Detalle")
                {
                    int idVenta = Convert.ToInt32(
                        Dgv_Ventas_Generales.Rows[e.RowIndex]
                        .Cells["IdVenta"].Value
                    );

                    Frm_Detalle_Ventas frm = new Frm_Detalle_Ventas(idVenta);

                    frm.MdiParent = this.MdiParent;
                    frm.StartPosition =
                        FormStartPosition.CenterParent;

                    // RECARGAR GRID AL GUARDAR
                    frm.VentaGuardada += () =>
                    {
                        fun_CargarVentas();
                    };

                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message);
            }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta relativa donde está tu archivo CHM (igual que tu compañero)
                const string subRutaAyuda = @"ayuda\Empresarial\Equipo 2\Ventas\FrmVentas\Ventasayuda.chm";

                string rutaEncontrada = null;
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                // Busca la carpeta hacia arriba (10 niveles)
                for (int i = 0; i < 10 && dir != null; i++, dir = dir.Parent)
                {
                    string candidata = Path.Combine(dir.FullName, subRutaAyuda);
                    if (File.Exists(candidata))
                    {
                        rutaEncontrada = candidata;
                        break;
                    }
                }
                if (rutaEncontrada != null)

                {
                    // Esta es la ruta INTERNA del archivo dentro del CHM
                    string rutaInterna = @"Ventas Generales.html";

                    Help.ShowHelp(this, rutaEncontrada, HelpNavigator.Topic, rutaInterna);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo de ayuda.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ayuda:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

