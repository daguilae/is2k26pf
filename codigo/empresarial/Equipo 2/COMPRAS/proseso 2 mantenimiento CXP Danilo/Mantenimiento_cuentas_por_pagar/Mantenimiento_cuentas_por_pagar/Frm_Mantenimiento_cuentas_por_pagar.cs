using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                "tbl_cuentas_por_pagar",
                "pk_id_cuenta_por_pagar",
                "fk_id_compra",
                "cmp_fecha_deuda",
                "cmp_fecha_vencimiento",
                "cmp_monto_total",
                "cmp_estado"
            };

            string[] sEtiquetas = {
                "Código Cuenta por Pagar",
                "Compra",
                "Fecha Deuda",
                "Fecha Vencimiento",
                "Monto Total",
                "Estado"
            };

            int id_aplicacion = 715;
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