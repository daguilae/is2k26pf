using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_OrdenProduccion;

namespace Capa_Vista_OrdenProduccion
{
    public partial class Frm_VisorReporte : Form
    {
        public Frm_VisorReporte()
        {
            InitializeComponent();
        }

        public void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Cls_ControladorOrdenP oControlador = new Cls_ControladorOrdenP();

            try
            {
                DataTable dtDatosReales = oControlador.ObtenerReporteOrdenes();
                Rpt_OrdenesProduccion miReporte = new Rpt_OrdenesProduccion();

                dtDatosReales.TableName = "Dt_Ordenes";
                miReporte.SetDataSource(dtDatosReales);

                crystalReportViewer1.ReportSource = miReporte;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
