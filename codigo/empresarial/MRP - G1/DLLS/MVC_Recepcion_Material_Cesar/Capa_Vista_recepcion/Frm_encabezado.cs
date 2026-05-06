using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_recepcion
{
    public partial class Frm_encabezado : Form
    {
        public Frm_encabezado()
        {
            InitializeComponent();
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            Frm_detalle frm = new Frm_detalle();
            frm.ShowDialog();
        }
    }
}
