using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace Capa_Vista_Mant_DiegoM
{
    public partial class Frm_Reportes : Form
    {
        private readonly string rutaReporte;
        private ReportDocument reporte;

        public Frm_Reportes(string nombreReporte)
        {
            InitializeComponent();
            rutaReporte = Path.Combine(Application.StartupPath, nombreReporte);
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {
            try
            {
                reporte = new ReportDocument();
                reporte.Load(rutaReporte);

                crystalReportViewer1.ReportSource = reporte;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el reporte.\n\n" + ex.Message,
                    "Error de reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            try
            {
                if (reporte != null)
                {
                    reporte.Close();
                    reporte.Dispose();
                }
            }
            catch
            {
            }

            base.OnFormClosed(e);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}