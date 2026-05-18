using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Balance;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace Capa_Vista_Balance
{
    public partial class Frm_Balance_Menu : Form
    {
        Cls_BalanceControlador controlador = new Cls_BalanceControlador();

        public Frm_Balance_Menu()
        {
            InitializeComponent();
            Dtp_Inicio.Format = DateTimePickerFormat.Short;
            Dtp_Final.Format = DateTimePickerFormat.Short;
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            DateTime inicio = Dtp_Inicio.Value.Date;
            DateTime fin = Dtp_Final.Value.Date;
           
                    

            if (inicio > fin)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor que la fecha fin.");
                return;
            }

            try
            {
                DataTable dt = controlador.ObtenerAntiguedadSaldos(inicio, fin);

                // Aquí está lo importante:
                //dataGridView1.DataSource = dt;
            }
             
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar antigüedad de saldos: " + ex.Message);
            }
}

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            
                DateTime desde = Dtp_Inicio.Value.Date;
                DateTime hasta = Dtp_Final.Value.Date;

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.");
                    return;
                }

                try
                {
                    // 1) Traer datos (usa el controlador que ya tienes arriba)
                    DataTable dt = controlador.ObtenerAntiguedadSaldos(desde, hasta);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay datos para el rango seleccionado.");
                        return;
                    }

                // 2) Pasar a DataSet tipado (XSD)
                var ds = new DataSet1();
                ds.AntiguedadSaldos.Clear();

                foreach (DataRow r in dt.Rows)
                {
                    ds.AntiguedadSaldos.ImportRow(r);
                }


                // 3) Reporte
                var rpt = new Rpt_Balance_Menu(); // tu .rpt
                    rpt.SetDataSource(ds);

                // 4) Mostrar en el viewer (ASEGÚRATE que este sea el CrystalReportViewer)
                
                crystalReportViewer1.ReportSource = rpt;
                    crystalReportViewer1.RefreshReport();
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar reporte: " + ex.Message);
                }
            }
        }
    }

 