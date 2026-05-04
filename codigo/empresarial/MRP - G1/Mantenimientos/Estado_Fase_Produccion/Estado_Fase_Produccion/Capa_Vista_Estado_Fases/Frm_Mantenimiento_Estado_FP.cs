using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Estado_Fases
{
    public partial class Frm_Mantenimiento_Estado_FP : Form
    {
        public Frm_Mantenimiento_Estado_FP()
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
                 "Tbl_Estado_Fase_Produccion",
                 "Pk_Id_Estado_Fase",
                 "Nombre_Estado_Fase",
                 "Descripcion_Estado_Fase"
             };

            string[] sEtiquetas = {
                 "ID",
                 "Estado Fase Produccion",
                 "Descripcion Estado"
             };

            int id_aplicacion = 720;
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
