using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_Emision_pasaporte
{
    public partial class Frm_fotografia : Form
    {
        public Frm_fotografia()
        {
            InitializeComponent();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
