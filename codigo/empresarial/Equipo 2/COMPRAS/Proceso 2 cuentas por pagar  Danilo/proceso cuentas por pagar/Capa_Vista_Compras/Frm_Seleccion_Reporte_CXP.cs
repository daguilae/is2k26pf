using System;
using System.Windows.Forms;

namespace Capa_Vista_CXP
{
    public partial class Frm_Seleccion_Reporte_CXP : Form
    {
        public Frm_Seleccion_Reporte_CXP()
        {
            InitializeComponent();

            Btn_reporte_simple.Click += Btn_reporte_simple_Click;
            Btn_reporte_antiguedad.Click += Btn_reporte_antiguedad_Click;
            Btn_salir.Click += Btn_salir_Click;
        }

        private void Btn_reporte_simple_Click(object sender, EventArgs e)
        {
            Frm_Visor_Reportes frm = new Frm_Visor_Reportes("Rpt_CXP_Simple.rpt");
            frm.ShowDialog();
        }

        private void Btn_reporte_antiguedad_Click(object sender, EventArgs e)
        {
            Frm_Visor_Reportes frm = new Frm_Visor_Reportes("Rpt_CXP_Antiguedad.rpt");
            frm.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}