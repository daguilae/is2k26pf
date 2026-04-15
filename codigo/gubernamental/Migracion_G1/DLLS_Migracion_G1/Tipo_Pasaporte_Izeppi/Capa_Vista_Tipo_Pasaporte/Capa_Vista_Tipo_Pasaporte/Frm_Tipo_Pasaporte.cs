using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Tipo_Pasaporte
{
    public partial class Frm_Tipo_Pasaporte : Form
    {
        public Frm_Tipo_Pasaporte()
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
                "Tbl_Tipo_Pasaporte",
                "Pk_Id_Tipo_Pasaporte",
                "Cmp_Tipo_Pasaporte",
                "Cmp_Duracion_Pasaporte",
                "Precio"
            };

            string[] sEtiquetas = {
                "ID Pasaporte",
                "Tipo Pasaporte",
                "Duracion Pasaporte",
                "Precio"
            };



            int id_aplicacion = 401;
            int id_modulo = 7;

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
