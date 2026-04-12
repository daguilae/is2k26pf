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
    public partial class Frm_Tipo_Transporte : Form
    {
        public Frm_Tipo_Transporte()
        {
            InitializeComponent();
        }

        private void Frm_Tipo_Transporte_Load(object sender, EventArgs e)
        {
            Dgv_Tipo_Transporte.Columns.Clear();
            Dgv_Tipo_Transporte.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Tipo_Transporte.Columns.Add("idempresa", "ID de la Empresa");
            Dgv_Tipo_Transporte.Columns.Add("tipotransporte", "Tipo de Transporte");
            Dgv_Tipo_Transporte.Columns.Add("placa", "Placa");
            Dgv_Tipo_Transporte.Columns.Add("nombrepiloto", "Nombre del Piloto");
            Dgv_Tipo_Transporte.Columns.Add("capacidad", "Capacidad");
            Dgv_Tipo_Transporte.Columns.Add("estadotransporte", "Estado del Transporte");

            Dgv_Tipo_Transporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Tipo_Transporte.AllowUserToAddRows = false;
        }
    }
}
