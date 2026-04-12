using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_TipoInve
{
    public partial class Frm_TipoInve : Form
    {
        public Frm_TipoInve()
        {
            InitializeComponent();

            // código mantenimiento
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };

            string[] columnas = {
                //nombre tabla
                 "Tbl_Tipo_Inventario",
                 //campos de la tabla
                 "Pk_Id_Tipo_Inventario",
                 "Nombre_Tipo_Inventario"
             };

            string[] sEtiquetas = {
                "ID",
                 "Tipo de Inventario"
             };

            int id_aplicacion = 712;
            int id_modulo = 5;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();

        }

        private void Frm_TipoInve_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
