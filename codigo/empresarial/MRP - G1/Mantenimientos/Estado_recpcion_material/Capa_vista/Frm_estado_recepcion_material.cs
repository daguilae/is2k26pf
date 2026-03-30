using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista
{
    public partial class Frm_estado_recepcion_material : Form
    {
        public Frm_estado_recepcion_material()
        {
            InitializeComponent();


            //parametros para navegador
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
     "Tbl_Estado_Recepcion_Material",
     "Pk_Id_Estado_Recepcion_Material",
     "Nombre_Estado_Recepcion_Material",
     "Descripcion_Estado_Recepcion_Material"
     

 };

            string[] sEtiquetas = {
    "ID",
     "Nombre del estado",
     "Descripcion del estado",
   
 };



            int id_aplicacion = 401;
            int id_modulo = 5;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
