using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_CheckList_Entrevista
{
    public partial class Frm_CheckList : Form
    {
        public Frm_CheckList()
        {
            InitializeComponent();
        }

        private void ChB_Estado_CheckedChanged(object sender, EventArgs e)
        {
            ChB_Rechazado.Checked = false;
        }

        private void ChB_Rechazado_CheckedChanged(object sender, EventArgs e)
        {
            ChB_Estado.Checked = false;
        }

        private void Btn_Agregar_Pregunta_Click(object sender, EventArgs e)
        {
            Frm_Preguntas form_preguntas = new Frm_Preguntas();

            form_preguntas.ShowDialog();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
