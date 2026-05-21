using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Asignacion;
using Capa_Controlador_Seguridad;


namespace Capa_Vista_Asignacion
{
    public partial class Frm_Asignacion_Cita : Form
    {
        Cls_Controlador_Asignacion controlador = new Cls_Controlador_Asignacion();
        public Frm_Asignacion_Cita()
        {
            InitializeComponent();
        }

        private void Frm_Asignacion_Cita_Load(object sender, EventArgs e)
        {
            Txt_Empleado.ReadOnly = true;
            pro_ObtenerEmpleado();
        }


        public void pro_ObtenerEmpleado()
        {
            try
            {
                var empleado = controlador.fun_ObtenerEmpleado(Cls_Usuario_Conectado.iIdUsuario);

                if (empleado.iIdEmpleado != 0)
                {
                    Txt_Empleado.Text = empleado.sNombre;
                }
                else
                {
                    MessageBox.Show("No se encontró empleado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Asignaciones_Click(object sender, EventArgs e)
        {
            Frm_Bitacora_Asignaciones frm_Bitacora_Asignaciones = new Frm_Bitacora_Asignaciones();
            frm_Bitacora_Asignaciones.Show();
        }
    }
}
