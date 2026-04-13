using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cronograma
{
    public partial class Frm_Cronograma_Fases : Form
    {
        public Frm_Cronograma_Fases()
        {
            InitializeComponent();
        }

        private void Frm_Cronograma_Fases_Load(object sender, EventArgs e)
        {
            Dgv_Cronograma.Columns.Clear();
            Dgv_Cronograma.Columns.Add("faseProduccion", "Fase de Producción");
            Dgv_Cronograma.Columns.Add("fechaInicio", "Fecha Inicio de Fase");
            Dgv_Cronograma.Columns.Add("faseFinal", "Fecha Final de Fase");
            Dgv_Cronograma.Columns.Add("horasHombres", "Horas Hombre");
            Dgv_Cronograma.Columns.Add("estadoFase", "Estado de la Fase");

            Dgv_Cronograma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Cronograma.AllowUserToAddRows = false;
        }
    }
}
