using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Mov_Inv;
using Capa_Vista_LineaProd;

namespace Capa_Vista_Logista
{
    public partial class Frm_MDI : Form
    {
        public Frm_MDI()
        {
            InitializeComponent();
        }
        

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
  

        }

        private void cuentaPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Op_CXC CXC = new Frm_Mantenimiento_Tipo_Op_CXC();
            CXC.ShowDialog();
        }

        private void lineaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_LineaProducto LineaProducto = new Frm_Mantenimiento_LineaProducto();
            LineaProducto.ShowDialog();
        }
    }
}
