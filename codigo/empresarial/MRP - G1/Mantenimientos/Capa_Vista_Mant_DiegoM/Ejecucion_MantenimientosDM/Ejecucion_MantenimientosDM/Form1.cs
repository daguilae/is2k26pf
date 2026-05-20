using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Mant_DiegoM;

namespace Ejecucion_MantenimientosDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Tipo_Material_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Material frm = new Frm_Mantenimiento_Tipo_Material();
            frm.ShowDialog();
        }

        private void Btn_Almacenes_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Almacen frm = new Frm_Mantenimiento_Almacen();
            frm.ShowDialog();
        }
    }
}