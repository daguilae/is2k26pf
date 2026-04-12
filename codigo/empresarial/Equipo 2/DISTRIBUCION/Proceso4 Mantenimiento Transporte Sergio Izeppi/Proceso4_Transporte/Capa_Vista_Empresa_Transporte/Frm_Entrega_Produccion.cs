using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Empresa_Transporte
{
    public partial class Frm_Entrega_Produccion : Form
    {
        public Frm_Entrega_Produccion()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Produccion_Load(object sender, EventArgs e)
        {
            Dgv_Entrega_Produccion.Columns.Clear();
            Dgv_Entrega_Produccion.Columns.Add("identregaproduccion", "ID Entrega Produccion");
            Dgv_Entrega_Produccion.Columns.Add("idordenp", "ID Orden de Produccion");
            Dgv_Entrega_Produccion.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Produccion.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Produccion.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Produccion.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Produccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Produccion.AllowUserToAddRows = false;
        }
    }
}
