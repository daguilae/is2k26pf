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
            Dgv_orden.DataSource = cont.MostrarDetalleOrden();

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
       


        }
       
    }

