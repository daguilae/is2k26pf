using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Migracion
{
    public partial class Frm_MDI_Migracion : Form
    {

        public Frm_MDI_Migracion()
        {
            InitializeComponent();

            this.IsMdiContainer = true; // <- activa MDI container
            this.Load += Frm_MDI_Migracion_Load;
        }
       

        private void Frm_MDI_Migracion_Load(object sender, EventArgs e)
        {
            // Mostrar usuario conectado en StatusStrip si existe el control
            try
            {
                toolStripStatusLabel.Text = $"Estado: Conectado | Usuario: {Capa_Controlador_Seguridad.Cls_Usuario_Conectado.sNombreUsuario}";
            }
            catch
            {
                // Si no existe toolStripStatusLabel en este formulario, ignorar.
            }

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login_Migracion ventanaPrincipal = new Frm_Login_Migracion();
            ventanaPrincipal.ShowDialog();
            this.Close();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cambiar_Contrasenea ventana = new Frm_Cambiar_Contrasenea(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario);
            ventana.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // Ruben Lopez 19/02/1016
        private void emisionPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Pasaporte.Frm_pasaporte pasaporte = new Capa_Vista_Pasaporte.Frm_pasaporte();
            pasaporte.MdiParent = this;
            pasaporte.Show();

        }


        private void horariosDeCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Horario.Frm_Horario pasaporte = new Capa_Vista_Horario.Frm_Horario();
            pasaporte.MdiParent = this;
            pasaporte.Show();
        }
        //Arón Esquit 21/2/2026
        private void estadoCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estado_Cita estado = new Frm_Estado_Cita();
            estado.MdiParent = this;
            estado.Show();

        }

        //Sergio Izeppi 21/02/2026
        private void tipoPasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Tipo_Pasaporte.Frm_Tipo_Pasaporte tipo_pasaporte = new Capa_Vista_Tipo_Pasaporte.Frm_Tipo_Pasaporte();
            tipo_pasaporte.MdiParent = this;
            tipo_pasaporte.Show();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Capa_Vista_Sedes.Frm_Sedes sedes = new Capa_Vista_Sedes.Frm_Sedes();
                sedes.MdiParent = this;
                sedes.Show();
        }

        //===== Kevin Natareno , 22/02/2026 =================================
        private void renapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Renap.Frm_Renap renap = new Capa_Vista_Renap.Frm_Renap();
            renap.MdiParent = this;
            renap.Show();
        }

        private void generarBoletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Banrural.Frm_Banrural banrural = new Capa_Vista_Banrural.Frm_Banrural();
            banrural.MdiParent = this;
            banrural.Show();
        }

        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Citas.Frm_Citas citas = new Capa_Vista_Citas.Frm_Citas();
            citas.MdiParent = this;
            citas.Show();
        }

        private void antecedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Antecedentes.Frm_Antecedentes ant = new Capa_Vista_Antecedentes.Frm_Antecedentes();
            ant.MdiParent = this;
            ant.Show();
        }

        private void paísEmisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Pais_Emisor.Frm_Pais_Emisor pais = new Capa_Vista_Pais_Emisor.Frm_Pais_Emisor();
            pais.MdiParent = this;
            pais.Show();
        }

        private void asignaciónCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Asignacion.Frm_Asignacion_Cita cita = new Capa_Vista_Asignacion.Frm_Asignacion_Cita();
            cita.MdiParent = this;
            cita.Show();
        }


        private void Btn_Bitacora(object sender, EventArgs e)
        {
            //Arón Esquit 4/3/26
            Capa_Vista_Seguridad.Frm_Bitacora bitacora = new Capa_Vista_Seguridad.Frm_Bitacora();
            bitacora.MdiParent = this;
            bitacora.Show();

        }

        //===== Kevin Natareno , 22/02/2026 =================================
    }
}
