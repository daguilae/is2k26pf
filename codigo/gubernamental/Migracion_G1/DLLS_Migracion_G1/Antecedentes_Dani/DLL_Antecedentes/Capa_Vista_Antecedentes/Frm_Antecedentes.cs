using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using System.Data.Odbc;

namespace Capa_Vista_Antecedentes
{
    public partial class Frm_Antecedentes : Form
    {
        public Frm_Antecedentes()
        {
            InitializeComponent();
        }

        private void CargarCiudadanos()
        {
            CiudadanoControlador controlador = new CiudadanoControlador();
            Cbo_Ciudadano.DataSource = controlador.ObtenerCiudadanos();
            Cbo_Ciudadano.DisplayMember = "NombreCompleto";
            Cbo_Ciudadano.ValueMember = "IdCiudadano";
            Cbo_Ciudadano.SelectedIndex = -1;
        }

        public DataTable llenarComboCiudadanos()
        {
            return cn.obtenerCiudadanos();
        }

        private void Frm_Antecedentes_Load(object sender, EventArgs e)
        {
            CargarCiudadanos();
            Cbo_Buscar.DisplayMember = "Cmp_Nombres_Ciudadano";

            DataTable dt = cn.obtenerCiudadanos();
            if (dt != null)
            {
                Cbo_Buscar.DataSource = dt;
                Cbo_Buscar.DisplayMember = "NombreCompleto"; 
                Cbo_Buscar.ValueMember = "Pk_Id_Ciudadano";
                Cbo_Buscar.SelectedIndex = -1;
            }
        }

        private void Cbo_Ciudadano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_Ciudadano.SelectedItem is Capa_Modelo_Antecedentes.Ciudadano ciudadano)
            {
                int idCiudadano = ciudadano.IdCiudadano;
                Console.WriteLine("ID seleccionado: " + idCiudadano);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void limpiarCampos()
        {
            Txt_Tipo.Clear();
            Txt_Descripcion.Clear();

            if (Cbo_Ciudadano.DataSource != null)
            {
                Cbo_Ciudadano.SelectedIndex = -1; 
            }

            if (Cbo_Estado.Items.Count > 0)
            {
                Cbo_Estado.SelectedIndex = -1; 
            }

            Dtp_Hora.Value = DateTime.Now;

            Txt_Tipo.Focus();
        }

        Controlador cn = new Controlador();
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string idCiudadano = Cbo_Ciudadano.SelectedValue.ToString();
            string estado = Cbo_Estado.SelectedItem.ToString();
            string fecha = Dtp_Hora.Value.ToString("yyyy-MM-dd");

            cn.ingresoAntecedentes(fecha, Txt_Tipo.Text, estado, Txt_Descripcion.Text, idCiudadano);

            MessageBox.Show("Datos guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            limpiarCampos();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cbo_Ciudadano.SelectedValue == null)
            {
                MessageBox.Show("Primero busque y seleccione un registro para modificar.");
                return;
            }

            try
            {
                string idCiudadano = Cbo_Ciudadano.SelectedValue.ToString();
                string estado = Cbo_Estado.SelectedItem.ToString();
                string fecha = Dtp_Hora.Value.ToString("yyyy-MM-dd");

                cn.actualizarAntecedente(fecha, Txt_Tipo.Text, estado, Txt_Descripcion.Text, idCiudadano);

                MessageBox.Show("Registro actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiarCampos();
                Frm_Antecedentes_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Cbo_Ciudadano.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un ciudadano de la lista.");
                return;
            }

            DialogResult res = MessageBox.Show("¿Desea eliminar los antecedentes del ciudadano seleccionado?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                string idCiudadano = Cbo_Ciudadano.SelectedValue.ToString();

                cn.borrarPorCiudadano(idCiudadano);

                MessageBox.Show("Antecedente(s) eliminado(s) correctamente.");
                limpiarCampos();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_Buscar_TextUpdate(object sender, EventArgs e)
        {
            string filtro = Cbo_Buscar.Text;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Cbo_Buscar.SelectedValue == null) return;

            string idSeleccionado = Cbo_Buscar.SelectedValue.ToString();

            OdbcDataReader lector = cn.obtenerAntecedente(idSeleccionado);

            if (lector != null && lector.Read())
            {
                Txt_Tipo.Text = lector.GetString(0);
                Txt_Descripcion.Text = lector.GetString(2);
                Dtp_Hora.Value = lector.GetDateTime(3);
                Cbo_Ciudadano.SelectedValue = idSeleccionado;

                int estado = Convert.ToInt32(lector.GetValue(1));
                Cbo_Estado.SelectedIndex = (estado == 1) ? 0 : 1; 

                MessageBox.Show("Datos cargados correctamente.");
            }
            else
            {
                MessageBox.Show("Este ciudadano no tiene antecedentes registrados.");
            }
        }



    }
}
