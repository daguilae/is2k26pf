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
    public partial class Frm_Policia_Nacional : Form
    {
        public Frm_Policia_Nacional()
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
                Nombre = "dgv_policia_nacional"
            };

            string[] columnas = {
                "tbl_policia_nacional",
                "pk_policia_id",
                "Cmp_dpi",
                "Cmp_tiene_orden_captura",
                "Cmp_tiene_arraigo",
                "Cmp_motivo_alerta",
                "Cmp_fecha_emision"
            };

            string[] sEtiquetas = {
                "Código Policia",
                "DPI",
                "Tiene Orden de Captura",
                "Tiene Orden de Arraigo",
                "Motivo de la Alerta",
                "Fecha de Emisión"
            };


            int id_aplicacion = 5026;
            int id_Modulo = 1;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
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
