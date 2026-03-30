using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mant_Kevin
{
    public partial class Frm_Materiales : Form
    {
        public Frm_Materiales()
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
                "Tbl_Materiales",
                "Pk_Id_Materiales",
                "Codigo_Material",
                "Nombre_Material",
                "Descripcion_Material",
                "Fk_Id_Categoria",
                "Fk_Id_Unidad_Medida",
                "Stock_Minimo",
                "Stock_Seguridad",
                "Lote_Minimo_Compra",
                "Lead_Time_Produccion_Dias",
                "Activo"
      
            };

            string[] sEtiquetas = {
               "ID",
                "Codigo",
                "Nombre",
                "Descripcion",
                "ID Categoria",
                "ID Unidad",
                "Stock Minimo ",
                "Stock Seguridad",
                "Lote Minimo Compra",
                "Tiempo de produccion",
                "Activo"
            };



            int id_aplicacion = 401;
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
