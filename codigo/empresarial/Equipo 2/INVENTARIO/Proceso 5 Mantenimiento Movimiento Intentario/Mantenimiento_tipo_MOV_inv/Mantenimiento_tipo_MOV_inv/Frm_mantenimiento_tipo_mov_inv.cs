using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
using Capa_Vista_Navegador;

namespace Mantenimiento_tipo_MOV_inv
{
    public partial class Frm_mantenimiento_tipo_mov_inv : Form
    {
        public Frm_mantenimiento_tipo_mov_inv()
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
                    Nombre = "dgv_tipo_operacion"
                };

            string[] columnas = {
                "tbl_tipo_operacion_cxc",
                "pk_tipo_operacion_cxc_id",
                "cmp_operacion",
                "cmp_efecto",
                "cmp_estado_tipo_operacion_cxc"
            };

            string[] sEtiquetas = {
                "Código Tipo Operacion",
                "Descripcion Operacion",
                "Efecto Operacion",
                "Estado Operacion"
            };

            int id_aplicacion = 707;
            int id_Modulo = 44;

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
