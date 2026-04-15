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

namespace Capa_Vista_Tipo_de_Movimiento_Inventario
{
    public partial class Frm_Tipo_de_movimineto_inventario : Form
    {
        public Frm_Tipo_de_movimineto_inventario()
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
                Nombre = "dgv_Tipo_de_movimineto_inventario"
            };

            string[] columnas = {
                "Tbl_Tipo_Movimiento_Inventario",
                "Pk_Id_Tipo_Movimiento_Inventario",
                "Nombre_Tipo_Movimiento_Inventario",
            };

            string[] sEtiquetas = {
                 "ID",
                 "Tipo movimiento del inventario",
            };



            int id_aplicacion = 706;
            int id_modulo = 5;

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
