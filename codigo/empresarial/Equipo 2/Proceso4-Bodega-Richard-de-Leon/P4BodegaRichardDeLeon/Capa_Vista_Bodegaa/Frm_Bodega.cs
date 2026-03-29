using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Bodegaa
{
    public partial class Frm_Bodega : Form
    {
        public Frm_Bodega()
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
                Nombre = "dgv_Bodega"
            };

            string[] columnas = {
                    "tbl_bodega",
                    "Pk_Id_Bodega",
                    "Cmp_Nombre_Bodega",
                    "Cmp_Descripcion_Bodega",
                    "Cmp_Estado_Bodega"
                };

                            string[] sEtiquetas = {
                    "Código Bodega",
                    "Nombre de Bodega",
                    "Descripción de Bodega",
                    "Estado de Bodega"
                };

            int id_aplicacion = 705;
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
