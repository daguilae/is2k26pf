using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_CheckList_Entrevista
{
    public partial class Frm_Mantenimiento_Preguntas : Form
    {
        public Frm_Mantenimiento_Preguntas()
        {
            InitializeComponent();

            // parametros para navegador
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
            new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_preguntas_alertas"
            };


            string[] columnas = {

                "tbl_preguntas_alertas",
                "pk_pregunta_id",
                "Cmp_Enunciado_Pregunta",
                "Cmp_Nivel"

};


            string[] sEtiquetas = {

                "Código Pregunta",
                "Enunciado de la Pregunta",
                "Nivel de Alerta"

};


            int id_aplicacion = 303;
            int id_Modulo = 4;
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
