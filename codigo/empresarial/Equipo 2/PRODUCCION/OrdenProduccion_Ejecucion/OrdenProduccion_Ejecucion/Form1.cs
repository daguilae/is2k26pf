using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_OrdenProduccion;

namespace OrdenProduccion_Ejecucion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Frm_OrdenProduccion_Encabezado vistaNueva = new Frm_OrdenProduccion_Encabezado();
            vistaNueva.Show();
        }
    }
}
