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

namespace Mantenimiento_cuentas_por_pagar
{
    public partial class Frm_Mantenimiento_cuentas_por_pagar : Form
    {
        public Frm_Mantenimiento_cuentas_por_pagar()
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
                    Nombre = "dgv_cuentas_por_pagar"
                };

            string[] columnas = {
                "tbl_tipo_operacion_cxp",
                "id_tipo_operacion",
                "operacion",
                "efecto",
                "estado_tipo_transaccion"
            };

            string[] sEtiquetas = {
                "Código Tipo Operación",
                "Operación",
                "Efecto",
                "Estado"
            };

            int id_aplicacion = 708;
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