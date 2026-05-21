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
    public partial class Frm_Empresa_Transporte : Form
    {
        public Frm_Empresa_Transporte()
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
     "tbl_empresa_transporte",
     "pk_id_empresa",
     "cmp_nombre_empresa",
     "cmp_telefono_empresa",
     "cmp_correo_empresa",
     "cmp_estado_empresa"

 };

            string[] sEtiquetas = {
     "ID Empresa",
     "Nombre",
     "Telefono",
     "Correo",
     "Estado"
 };



            int id_aplicacion = 706;
            int id_modulo = 44;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
