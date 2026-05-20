using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mant_DiegoM
{
    public partial class Frm_Mantenimiento_Almacen : Form
    {
        public Frm_Mantenimiento_Almacen()
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
                Nombre = "dgv_Almacen"
            };

            string[] columnas = {
             "Tbl_Almacen",
             "Pk_Id_Almacen",
             "Nombre_Almacen",
             "Ubicacion_Almacen",
             "Tipo_Almacen",
             "Estado_Almacen"

             };

            string[] sEtiquetas = {
             "ID Almacen",
             "Nombre Almacen",
             "Ubicacion",
             "Tipo Almacen",
             "Estado"
            };



            int id_aplicacion = 703;
            int id_modulo = 5;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reportes frm = new Frm_Reportes("Reporte_Almacenes.rpt");
            frm.ShowDialog();
        }
    }
}
