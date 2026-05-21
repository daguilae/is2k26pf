using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Tipo_Clientes : Form
    {
        public Frm_Tipo_Clientes()
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
                Nombre = "dgv_empleados"
            };
            string[] columnas = {
                    "tbl_tipo_cliente",
                    "Pk_Id_Tipo_Cliente",
                    "Cmp_Tipo",
                    "Cmp_Descripcion"
                };

            string[] sEtiquetas = {
                    "Código de Tipo Cliente",
                    "Tipo de Cliente",
                    "Descripción"
                };
            int id_aplicacion = 730;
            int id_Modulo = 44;
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
