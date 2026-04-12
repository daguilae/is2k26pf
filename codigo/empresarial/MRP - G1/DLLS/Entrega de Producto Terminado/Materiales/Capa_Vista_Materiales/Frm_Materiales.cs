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

namespace Capa_Vista_Materiales
{
    public partial class Frm_Materiales : Form
    {
        public Frm_Materiales()
        {
            InitializeComponent();
            //parametros para navegador
            navegador1.Load += (s, e) => navegador1.BotonesEstadoCRUD(true, true, true, true, true);
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
                        "tbl_materiales",
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
                        "ID Material",
                        "Código Material",
                        "Nombre del material",
                        "Descripción del material",
                        "Nombre de la categoria del material",
                        "Unidad de medida",
                        "Stock mínimo",
                        "Stock de seguridad",
                        "Lote mínimo compra",
                        "Tiempo de producción en días",
                        "Estado"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Categoria",
                        TablaReferencia = "tbl_categoria_material",
                        CampoPK         = "Pk_Id_Categoria_Material",
                        CampoMostrar    = "Nombre_Categoria_Material",

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Unidad_Medida",
                        TablaReferencia = "tbl_unidad_medida",
                        CampoPK         = "Pk_Id_Unidad_Medida",
                        CampoMostrar    = "Abreviatura_Unidad_Medida",

                    },

                };




            int id_aplicacion = 704;
            int id_modulo = 5;

            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.SConfiguracionFK = fks;
            navegador1.mostrarDatos();
        }
    }
}
