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
    public partial class Frm_Entrega_Compra : Form
    {
        public Frm_Entrega_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Compra_Load(object sender, EventArgs e)
        {
            Dgv_Entrega_Compra.Columns.Clear();
            Dgv_Entrega_Compra.Columns.Add("identregacommpra", "ID Entrega de Compra");
            Dgv_Entrega_Compra.Columns.Add("idordencompra", "ID Orden de Compra");
            Dgv_Entrega_Compra.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Compra.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Compra.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Compra.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Compra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Compra.AllowUserToAddRows = false;
        }
    }
}
