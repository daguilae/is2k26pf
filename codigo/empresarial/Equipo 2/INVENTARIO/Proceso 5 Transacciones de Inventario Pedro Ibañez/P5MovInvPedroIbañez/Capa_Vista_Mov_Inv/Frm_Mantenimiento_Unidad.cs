using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Mantenimiento_Unidad : Form
    {
        public Frm_Mantenimiento_Unidad()
        {
            InitializeComponent();

            // Configuración del DataGridView
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
            new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_tipo_operacion_cxc"
            };

            // Columnas (tabla + campos)
            string[] columnas = {
                    "tbl_unidad_de_medida",
                    "ID_Unidad",
                    "Nombre_Unidad",
                    "Abreviacion_Medida",
                    "Descripcion",
                    "Estado_Medida"
                };

            // Etiquetas visibles
            string[] sEtiquetas = {
                    "ID Unidad",
                    "Nombre Unidad",
                    "Abreviacion Medida",
                    "Descripcion",
                    "Estado Medida"
                };

            // ID de aplicación
            int id_aplicacion = 724;
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
