/*
    Autor: Diego Andre Monterroso Rabarique
    Mantenimiento: Frm_Mantenimiento_Tipo_Atencion
    Descripción: Mantenimiento tipo atencion con parametros con navegador
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
namespace Capa_Vista_Datos_Adicionales
{
    public partial class Frm_Mantenimiento_Tipo_Atencion : Form
    {
        public Frm_Mantenimiento_Tipo_Atencion()
   
     
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

                    "tipo_atencion",
                    "id",
                    "tipo"

                };

                   string[] sEtiquetas = {

                    "Código Tipo de Atención",
                    "Tipo de Atención"

                };


            int id_aplicacion = 5019;
                int id_Modulo = 1;
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


