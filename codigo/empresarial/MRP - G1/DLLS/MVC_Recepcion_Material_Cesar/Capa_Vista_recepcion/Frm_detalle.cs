using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_recepcion;
namespace Capa_Vista_recepcion
{
    public partial class Frm_detalle : Form
    {       
        //cesar santizo 0901-22-5215

        public Frm_detalle()
        {
            InitializeComponent();
            cargarCombos();
            inicializarColumnas();
        }
        Controlador con = new Controlador();

        private void inicializarColumnas()
        {
            Dgv_Materiales.Columns.Clear();

            Dgv_Materiales.Columns.Add("idMaterial", "ID Material");
            Dgv_Materiales.Columns.Add("nombreMaterial", "Material");
            Dgv_Materiales.Columns.Add("cantidad", "Cantidad");
            Dgv_Materiales.Columns.Add("costo", "Costo Unitario");
        }

        //cesar santizo 0901-22-5215

        public void cargarCombos()
        {
            Cbo_Materiales.DataSource = con.getMateriales();
            Cbo_Materiales.DisplayMember = "Nombre_Material";
            Cbo_Materiales.ValueMember = "Pk_Id_Materiales";
            Cbo_Materiales.SelectedIndex = -1;

            Cbo_Almacen.DataSource = con.cargarUbi();
            Cbo_Almacen.DisplayMember = "Nombre_Almacen";
            Cbo_Almacen.ValueMember = "Pk_Id_Almacen";
            Cbo_Almacen.SelectedIndex = -1;

            Cbo_estado.DataSource = con.cargarestado();
            Cbo_estado.DisplayMember = "Nombre_Estado_Recepcion_Material";
            Cbo_estado.ValueMember = "Pk_Id_Estado_Recepcion_Material";
            Cbo_estado.SelectedIndex = -1;
        }
        //cesar santizo 0901-22-5215

        private void Btn_agregarMat_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (Cbo_Materiales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material");
                return;
            }

            if (Nud_Cantidad.Value <= 0 || string.IsNullOrWhiteSpace(Txt_Costo.Text))
            {
                MessageBox.Show("Ingrese cantidad y costo");
                return;
            }

            // Obtener datos
            int idMaterial = Convert.ToInt32(Cbo_Materiales.SelectedValue);
            string nombreMaterial = Cbo_Materiales.Text;
            decimal cantidad = Nud_Cantidad.Value; // 👈 aquí cambia
            decimal costo = Convert.ToDecimal(Txt_Costo.Text);


            foreach (DataGridViewRow fila in Dgv_Materiales.Rows)
            {
                if (fila.Cells["idMaterial"].Value != null &&
                    Convert.ToInt32(fila.Cells["idMaterial"].Value) == idMaterial)
                {
                    MessageBox.Show("Ese material ya fue agregado");
                    return;
                }
            }

            // Agregar fila
            Dgv_Materiales.Rows.Add(idMaterial, nombreMaterial, cantidad, costo);

            // Limpiar campos
            Cbo_Materiales.SelectedIndex = -1;
            Nud_Cantidad.Value = 0; 
            Txt_Costo.Clear();
        }
        //cesar santizo 0901-22-5215

        private void Btn_eliminarMat_Click(object sender, EventArgs e)
        {
            if (Dgv_Materiales.CurrentRow != null)
            {
                Dgv_Materiales.Rows.Remove(Dgv_Materiales.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            Frm_reportes frm = new Frm_reportes();
            frm.ShowDialog();
        }
    }





}
