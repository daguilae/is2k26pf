using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Migracion
{
    public partial class Frm_RENAP : Form
    {
        public Frm_RENAP()
        {
            InitializeComponent();
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
            new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_renap"
            };

            string[] columnas = {
                "tbl_renap",
                "pk_renap_id",
                "Cmp_dpi",
                "Cmp_nombre",
                "Cmp_apellido",
                "Cmp_sexo",
                "Cmp_departamento",
                "Cmp_estado_Civil",
                "Cmp_fecha_nacimiento",
                "Cmp_estado_vital"
            };

            string[] sEtiquetas = {
                "Código RENAP",
                "DPI",
                "Nombre",
                "Apellido",
                "Sexo",
                "Departamento",
                "Estado Civil",
                "Fecha de Nacimiento",
                "Estado Vital"
            };

            int id_aplicacion = 5024;
            int id_Modulo = 1;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
