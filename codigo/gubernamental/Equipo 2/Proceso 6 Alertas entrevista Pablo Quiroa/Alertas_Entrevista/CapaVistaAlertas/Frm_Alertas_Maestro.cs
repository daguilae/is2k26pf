using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaAlertas
{
    public partial class Frm_Alertas_Maestro : Form
    {
        public Frm_Alertas_Maestro()
        {
            InitializeComponent();
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_alertas"
            };

            string[] columnas = {
                    "Tbl_alertas",
                    "Pk_Id_alerta",
                    "Cmp_Enunciado_Alerta",
                    "Cmp_Nivel"
                    

            };

            string[] sEtiquetas = {
                    "Id Alerta ",
                    "Enunciado alerta",
                    "Nivel alerta",
                   

                };


            int id_aplicacion = 5030;
            int id_Modulo = 1;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();

            // ==============================
        }
    }
}
