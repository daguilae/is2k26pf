using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_Orden
{
    public partial class Frm_Orden_Produccion : Form
    {
        public Frm_Orden_Produccion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Orden_Produccion_Load(object sender, EventArgs e)
        {
            Dgv_Orden_Produccion.Columns.Clear();
            Dgv_Orden_Produccion.Columns.Add("IdOrdenProduccion", "ID Orden Produccion");
            Dgv_Orden_Produccion.Columns.Add("PlanProduccion", "Plan Produccion");
            Dgv_Orden_Produccion.Columns.Add("material", "Material");
            Dgv_Orden_Produccion.Columns.Add("estadoOrdenProduccion", "Estado Orden Produccion");
            Dgv_Orden_Produccion.Columns.Add("cantidad", "Cantidad");
            Dgv_Orden_Produccion.Columns.Add("fechaInicio", "Fecha Inicio");
            Dgv_Orden_Produccion.Columns.Add("fechaFin", "Fecha Fin");

            Dgv_Orden_Produccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Orden_Produccion.AllowUserToAddRows = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
