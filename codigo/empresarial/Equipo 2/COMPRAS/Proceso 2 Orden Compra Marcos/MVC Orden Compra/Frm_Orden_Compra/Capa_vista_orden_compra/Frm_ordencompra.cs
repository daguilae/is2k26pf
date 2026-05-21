using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador_orden_compra;
namespace Capa_vista_orden_compra
{
    public partial class Frm_ordencompra : Form
    {

        Cls_controlador cont = new Cls_controlador();


        private void Frm_ordencompra_Load(object sender, EventArgs e)
        {
         
            llenarDataGridView();
            

        }


        public Frm_ordencompra()
        {
            InitializeComponent();

        }

        private void Dgv_orden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_detalle_orden_compra frmDetalleorden = new Frm_detalle_orden_compra();
            frmDetalleorden.ShowDialog();
        }


        public void llenarDataGridView()
        {

          

                try
                {

                    DataTable dt = cont.llenarTblDetalle();

                    
                    if (dt == null)
                    {
                        
                        return;
                    }

                   

                    if (dt.Rows.Count > 0)
                    {
                        Dgv_orden.DataSource = dt;
                      
                    }
                    else
                    {
                      
                        Dgv_orden.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("PASO EXTRA: Ocurrió una excepción: " + ex.Message + "\n\nStack: " + ex.StackTrace);
                }
            }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {


            Frm_detalle_orden_compra frmDetalleorden = new Frm_detalle_orden_compra();
            frmDetalleorden.ShowDialog();

        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            Frm_detalle_orden_compra frmDetalleorden = new Frm_detalle_orden_compra();
            frmDetalleorden.ShowDialog();
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            Frm_reporte frmreporteorden = new Frm_reporte();
            frmreporteorden.ShowDialog();
        }

        private void Dgv_orden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }




        private void Dgv_orden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

            if (e.RowIndex < 0) return;

            
            string columnas = "";
            foreach (DataGridViewColumn col in Dgv_orden.Columns)
                columnas += col.Name + "\n";
            
            var valorCelda = Dgv_orden.Rows[e.RowIndex].Cells["numero_orden"].Value;
            

            string numeroOrden = valorCelda?.ToString();
            if (string.IsNullOrEmpty(numeroOrden))
            {
                
                return;
            }

            Frm_detalle_orden_compra frmDetalle = new Frm_detalle_orden_compra();
            frmDetalle.NumeroOrdenACargar = numeroOrden;
            frmDetalle.ShowDialog();
        }

    }
       
    }

