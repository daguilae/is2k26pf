using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_LineaProd
{
    public partial class Frm_Mantenimiento_LineaProducto : Form
    {
        public Frm_Mantenimiento_LineaProducto()
        {
            //Mantenimiento Kenph Luna 9959-22-6326 
            //27/03/2026
            // Configuración del DataGridView
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config =
            new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_lineaprod"
            };

            // Columnas (tabla + campos)
            string[] columnas = {
                    "tbl_Linea_Producto",
                    "pk_id_linea",
                    "cmp_nombre_linea",
                    "cmp_descripcion",
                    "cmp_estado_linea"
                };

            // Etiquetas visibles
            string[] sEtiquetas = {
                    "Código Linea Producto",
                    "Nombre de Linea",
                    "Descripcion",
                    "Estado Linea"
                };

            // ID de aplicación
            int id_aplicacion = 704;
            int id_modulo = 44;
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
