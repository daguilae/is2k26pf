using CrystalDecisions.CrystalReports.Engine;
using System;
using System.IO;
using System.Windows.Forms;

namespace Capa_Vista_CXP
{
    public partial class Frm_Visor_Reportes : Form
    {
        private readonly string nombreReporte;

        public Frm_Visor_Reportes(string reporte)
        {
            InitializeComponent();
            nombreReporte = reporte;
            this.Load += Frm_Visor_Reportes_Load;
        }

        private void Frm_Visor_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();

                string ruta = Path.Combine(Application.StartupPath, nombreReporte);

                rpt.Load(ruta);

                Crv_reporte.ReportSource = rpt;
                Crv_reporte.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
            }
        }
    }
}