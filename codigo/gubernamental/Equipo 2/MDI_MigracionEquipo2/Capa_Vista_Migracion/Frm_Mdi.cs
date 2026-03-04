using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_CheckList_Entrevista;
using CapaVista_Citas;
using Capa_Vista_Datos_Cliente;
using CapaVistaAlertas;
using Capa_Vista_Reporteador;

namespace Capa_Vista_Migracion
{
    public partial class Frm_Mdi : Form
    {
        public Frm_Mdi()
        {
            InitializeComponent();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Preguntas navpreg = new Frm_Mantenimiento_Preguntas();
            navpreg.ShowDialog();
        }

        private void checkListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CheckList chklist = new Frm_CheckList();
            chklist.ShowDialog();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sedes sedes = new Frm_Sedes();
            sedes.ShowDialog();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_Citas citas = new Frm_Citas();
            citas.ShowDialog();
        }

        private void datosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Datos_Solicitante datos = new Frm_Datos_Solicitante();
            datos.ShowDialog();
        }

        private void alertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alertas alertas = new Frm_Alertas();
            alertas.ShowDialog();
        }

        private void rENAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RENAP renap = new Frm_RENAP();
            renap.ShowDialog();
        }

        private void policiaNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Policia_Nacional policia = new Frm_Policia_Nacional();
            policia.ShowDialog();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reportes reporte = new Frm_Reportes();
            reporte.ShowDialog();
        }
    }
}
