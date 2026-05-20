using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Renap;


// EMPIEZA CODIGO HECHO POR: MARIA MORALES 0901-22-1226 EN LA FECHA DE: 04/03/2026
namespace Capa_Vista_Renap
{
    public partial class Frm_Renap : Form
    {
        public Frm_Renap()
        {
            InitializeComponent();
            actualizardatagriew();
            this.Load += Frm_Renap_Load;
        }

        int idCiudadanoSeleccionado = 0;

        string ciu = "Tbl_Ciudadano";
        Cls_Controlador controlador = new Cls_Controlador();


        //Mostrar los datos CAPA VISTA


        public void actualizardatagriew()
        {
            DataTable dt = controlador.llenarTbl(ciu);
            dgv_renap.DataSource = dt;

            dgv_renap.Columns["Pk_Id_Ciudadano"].HeaderText = "ID Ciudadano";
            dgv_renap.Columns["Cmp_Dpi_Ciudadano"].HeaderText = "DPI";
            dgv_renap.Columns["Cmp_Nombres_Ciudadano"].HeaderText = "Nombres";
            dgv_renap.Columns["Cmp_Apellidos_Ciudadano"].HeaderText = "Apellidos";
            dgv_renap.Columns["Cmp_Sexo_Ciudadano"].HeaderText = "Sexo";
            dgv_renap.Columns["Cmp_Nacionalidad_Ciudadano"].HeaderText = "Nacionalidad";
            dgv_renap.Columns["Cmp_Lugar_Nacimiento_Ciudadano"].HeaderText = "Lugar de nacimiento";
            dgv_renap.Columns["Cmp_Fecha_Nacimiento_Ciudadano"].HeaderText = "Fecha de nacimiento";

        }

        private void Frm_Renap_Load(object sender, EventArgs e)
        {
            
            dgv_renap.EnableHeadersVisualStyles = false;

           
            dgv_renap.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;

           
            dgv_renap.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            
            dgv_renap.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 8, FontStyle.Bold);

            
            dgv_renap.ColumnHeadersHeight = 35;
        }



        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            // validar DPI
            if (!long.TryParse(txt_dpi.Text.Trim(), out long dpi))
            {
                MessageBox.Show("Ingrese un número de identificación válido.");
                txt_dpi.Focus();
                return;
            }

            // validar sexo
            if (!rdb_femenino.Checked && !rdb_masculino.Checked)
            {
                MessageBox.Show("Seleccione el sexo.");
                return;
            }

            string nombres = txt_nombres.Text.Trim();
            string apellidos = txt_apellidos.Text.Trim();
            string nacionalidad = txt_nacionalidad.Text.Trim();
            string lugarNacimiento = txt_lugarnac.Text.Trim();
            DateTime fechaNacimiento = dtp_fecha.Value;

            // femenino = 0, masculino = 1
            int sexo = rdb_masculino.Checked ? 1 : 0;

            Cls_Controlador controlador = new Cls_Controlador();

            bool guardado = controlador.Guardar(
                                dpi,
                                nombres,
                                apellidos,
                                sexo,
                                nacionalidad,
                                lugarNacimiento,
                                fechaNacimiento
                            );

            if (guardado)
                MessageBox.Show("Registro guardado correctamente.");
            else
                MessageBox.Show("Error al guardar el registro.");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_renap.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro.");
                return;
            }

            int idCiudadano = Convert.ToInt32(
                dgv_renap.CurrentRow.Cells["Pk_Id_Ciudadano"].Value
            );

            DialogResult r = MessageBox.Show(
                "¿Está seguro de eliminar este registro?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
                return;

            bool eliminado = controlador.Eliminar(idCiudadano);

            if (eliminado)
            {
                MessageBox.Show("Registro eliminado correctamente.");
                actualizardatagriew();   // refresca el grid
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro.");
            }
        }

        private void dgv_renap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgv_renap.Rows[e.RowIndex];

            idCiudadanoSeleccionado =
                Convert.ToInt32(fila.Cells["Pk_Id_Ciudadano"].Value);

            txt_dpi.Text = fila.Cells["Cmp_Dpi_Ciudadano"].Value.ToString();
            txt_nombres.Text = fila.Cells["Cmp_Nombres_Ciudadano"].Value.ToString();
            txt_apellidos.Text = fila.Cells["Cmp_Apellidos_Ciudadano"].Value.ToString();
            txt_nacionalidad.Text = fila.Cells["Cmp_Nacionalidad_Ciudadano"].Value.ToString();
            txt_lugarnac.Text = fila.Cells["Cmp_Lugar_Nacimiento_Ciudadano"].Value.ToString();

            dtp_fecha.Value = Convert.ToDateTime(
                fila.Cells["Cmp_Fecha_Nacimiento_Ciudadano"].Value
            );

            int sexo = Convert.ToInt32(
                fila.Cells["Cmp_Sexo_Ciudadano"].Value
            );

            if (sexo == 1)
                rdb_masculino.Checked = true;
            else
                rdb_femenino.Checked = true;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (idCiudadanoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un ciudadano de la tabla.");
                return;
            }

            if (!long.TryParse(txt_dpi.Text.Trim(), out long dpi))
            {
                MessageBox.Show("Ingrese un número de identificación válido.");
                return;
            }

            if (!rdb_femenino.Checked && !rdb_masculino.Checked)
            {
                MessageBox.Show("Seleccione el sexo.");
                return;
            }

            string nombres = txt_nombres.Text.Trim();
            string apellidos = txt_apellidos.Text.Trim();
            string nacionalidad = txt_nacionalidad.Text.Trim();
            string lugarNacimiento = txt_lugarnac.Text.Trim();
            DateTime fechaNacimiento = dtp_fecha.Value;

            int sexo = rdb_masculino.Checked ? 1 : 0;

            bool modificado = controlador.Modificar(
                                    idCiudadanoSeleccionado,
                                    dpi,
                                    nombres,
                                    apellidos,
                                    sexo,
                                    nacionalidad,
                                    lugarNacimiento,
                                    fechaNacimiento
                               );

            if (modificado)
            {
                MessageBox.Show("Registro modificado correctamente.");
                actualizardatagriew();
            }
            else
            {
                MessageBox.Show("Error al modificar el registro.");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
// FINALIZA CODIGO HECHO POR: MARIA MORALES 0901-22-1226 EN LA FECHA DE: 04/03/2026