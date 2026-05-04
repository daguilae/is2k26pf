// Arón Ricardo Esquit Silva - 0901-22-13036 - 21/02/2026

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Vista_Migracion
{
    public partial class Frm_Estado_Cita : Form
    {
        public Frm_Estado_Cita()
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
                    Nombre = "dgv_estado_cita"
                };

            string[] columnas = {
                "Tbl_Estado_Cita",
                "Pk_Id_Estado_Cita",
                "Cmp_Nombre_Estado"
            };

            string[] etiquetas = {
                "Id Estado",
                "Nombre Estado"
            };

            int id_aplicacion = 401; 
            int id_modulo = 7;     

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;

            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = etiquetas;

            navegador1.mostrarDatos();
        }
    }
}