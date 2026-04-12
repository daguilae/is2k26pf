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
    public partial class Frm_Mantenimiento_Tipo_Op_CXC : Form
    {
        public Frm_Mantenimiento_Tipo_Op_CXC()
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
                    "tbl_tipo_operacion_cxc",
                    "pk_tipo_operacion_cxc_id",
                    "cmp_operacion",
                    "cmp_efecto",
                    "cmp_estado_tipo_operacion_cxc"
                };

                            // Etiquetas visibles
                            string[] sEtiquetas = {
                    "Código Tipo Operación",
                    "Operación",
                    "Efecto",
                    "Estado"
                };

            // ID de aplicación
            int id_aplicacion = 709;
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
