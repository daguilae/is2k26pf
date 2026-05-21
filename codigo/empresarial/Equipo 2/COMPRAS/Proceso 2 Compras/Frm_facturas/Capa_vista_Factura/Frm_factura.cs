using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador_Facturas;
namespace Capa_vista_Factura
{
    public partial class Frm_factura : Form
    {

        Cls_controlador cont = new Cls_controlador();

        private void Frm_factura_Load(object sender, EventArgs e)
        {
            actualizardatagridview();
            this.Load += Frm_factura_Load;




        }

        public Frm_factura()
        {
            InitializeComponent();
           
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // configuracion botones
        private void ConfigurarBotonesInicio()
        {
            Btn_Ingresar.Enabled = true;
            Btn_Editar.Enabled = true;
            
            Btn_Imprimir.Enabled = true;
            Btn_Refrescar.Enabled = true;
//            Btn_Salir.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_reporte frm_Reporte = new Frm_reporte();
            frm_Reporte.ShowDialog();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {

               
                Frm_detalle_compra frmDetalleCompra =  new Frm_detalle_compra();
                frmDetalleCompra.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle de Compra: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_compras_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }


        public void actualizardatagridview()
        {
            try
            {
                // El controlador retorna el DataTable con el JOIN de las dos tablas
                DataTable dt = cont.llenarTblDetalle();
               // MessageBox.Show("Filas: " + dt.Rows.Count);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tabla: " + ex.Message);
            }
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }





        public void llenarDataGridView()
        {
            try
            {
                // 1. Obtenemos el DataTable desde el controlador
                // Recuerda que el controlador ya trae la unión (JOIN) de las tablas
                DataTable dt = cont.llenarTblDetalle();

                // 2. Validamos si trae datos
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Filas encontradas: " + dt.Rows.Count);
                }
                else
                {
                    // Opcional: Limpiar el grid si no hay registros
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Verifica el nombre exacto de la columna con el número de factura
            string numeroFactura = dataGridView1.Rows[e.RowIndex].Cells["NoFactura"].Value?.ToString();

            if (string.IsNullOrEmpty(numeroFactura)) return;

            Frm_detalle_compra frmDetalle = new Frm_detalle_compra();
            frmDetalle.NumeroFacturaACargar = numeroFactura;
            frmDetalle.ShowDialog();

            actualizardatagridview(); // refresca al cerrar
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_detalle_compra frmDetalleCompra = new Frm_detalle_compra();
            frmDetalleCompra.ShowDialog();
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            Frm_detalle_compra frmDetalleCompra = new Frm_detalle_compra();
            frmDetalleCompra.ShowDialog();
        }
    }
}
