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
    public partial class Frm_Entrega_Venta : Form
    {
        public Frm_Entrega_Venta()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Venta_Load(object sender, EventArgs e)
        {
            Dgv_Entrega_Venta.Columns.Clear();
            Dgv_Entrega_Venta.Columns.Add("identregaventa", "ID Entrega de Venta");
            Dgv_Entrega_Venta.Columns.Add("idventa", "ID de la Venta");
            Dgv_Entrega_Venta.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Venta.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Venta.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Venta.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Venta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Venta.AllowUserToAddRows = false;
        }
    }
}
