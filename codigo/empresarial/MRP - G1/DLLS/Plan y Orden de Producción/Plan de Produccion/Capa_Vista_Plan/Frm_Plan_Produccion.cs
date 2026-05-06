using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Plan;


namespace Capa_Vista_Plan
{
    public partial class Frm_Plan_Produccion : Form
    {
        Cls_Controlador_Ordenes ordenes = new Cls_Controlador_Ordenes();
        Cls_Controlador_Cronograma cronograma = new Cls_Controlador_Cronograma();

        public Frm_Plan_Produccion()
        {
            InitializeComponent();
        }

    }

}
  