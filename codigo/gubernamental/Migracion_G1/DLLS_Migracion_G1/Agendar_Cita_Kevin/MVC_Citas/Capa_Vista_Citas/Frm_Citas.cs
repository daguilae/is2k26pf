using Capa_Controlador_Citas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Citas
{
    public partial class Frm_Citas : Form
    {
        Cls_Controlador_Citas controlador = new Cls_Controlador_Citas();
        public Frm_Citas()
        {
            
            InitializeComponent();
            CargarCombos();
        }
        private void CargarCombos()
        {
            DataTable dtTipos = controlador.ObtenerTiposCita();

            Cbo_Tipo_Cita.DataSource = dtTipos;
            Cbo_Tipo_Cita.DisplayMember = "Cmp_Nombre_Tipo_Cita";
            Cbo_Tipo_Cita.ValueMember = "Pk_Id_Tipo_Cita";
            Cbo_Tipo_Cita.SelectedIndex = -1; // Nada seleccionado

            // HORARIOS
            Cbo_Horario.DataSource = controlador.ObtenerHorarios();
            Cbo_Horario.DisplayMember = "Cmp_Hora";
            Cbo_Horario.ValueMember = "Pk_Id_Horarios";
            Cbo_Horario.SelectedIndex = -1;

            // SEDES
            Cbo_Sede.DataSource = controlador.ObtenerSedes();
            Cbo_Sede.DisplayMember = "Cmp_Nombre_Sede";
            Cbo_Sede.ValueMember = "Pk_Id_Sede";
            Cbo_Sede.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
         Cbo_Tipo_Cita.SelectedIndex == -1 ||
         Cbo_Horario.SelectedIndex == -1 ||
         Cbo_Sede.SelectedIndex == -1
     )
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            int idBoleta = Convert.ToInt32(Txt_No_Boleta.Text);
            bool resultado = controlador.AgendarCita(
                Convert.ToInt32(Cbo_Tipo_Cita.SelectedValue),
                Dtp_Fecha_Cita.Value.Date,
                Convert.ToInt32(Cbo_Horario.SelectedValue),
                Convert.ToInt32(Cbo_Sede.SelectedValue),
                idBoleta // este valor ya lo debes tener
            );

            if (resultado)
                MessageBox.Show("Cita agendada y asignada correctamente");
            else
                MessageBox.Show("Error al agendar la cita");

        }
    }
}