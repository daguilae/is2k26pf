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
using Capa_Vista_Navegador;

namespace Mantenimiento_Proveedores
{
    public partial class Frm_proveedores : Form
    {
        public Frm_proveedores()
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
                Nombre = "dgv_proveedores"
            };



            string[] columnas = {
                    "tbl_proveedores",
                    "pk_id_proveedor",
                    "cmp_nombre_proveedor",
                    "cmp_direccion",
                    "cmp_telefono",
                    "cmp_correo",
                    "cmp_descripcion",
                    "cmp_estado",

                };

            string[] sEtiquetas = {
                    "Código Provedor",
                    "Nombre",
                    "Dirección",
                    "Teléfono",
                    "Correo",
                    "Descripción",
                    "Estado",

                };
            int id_aplicacion = 703;
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
