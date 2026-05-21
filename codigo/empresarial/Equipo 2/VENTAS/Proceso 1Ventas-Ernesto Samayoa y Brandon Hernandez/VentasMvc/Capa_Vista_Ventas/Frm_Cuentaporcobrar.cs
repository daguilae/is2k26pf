using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Cuentaporcobrar : Form
    {
        public Frm_Cuentaporcobrar()
        {
            InitializeComponent();
        }

  

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Agregar_Ventas_Click(object sender, EventArgs e)
        {
            Frm_CXC_Detalle detalle = new Frm_CXC_Detalle();

            detalle.ShowDialog();
        }
    }
}
