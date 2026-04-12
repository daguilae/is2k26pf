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

namespace Capa_Vista_Orden_Produccion
{
    public partial class Frm_Orden_Produccion : Form
    {
        public Frm_Orden_Produccion()
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
                        "Tbl_Orden_Produccion",
                        "Pk_Id_Orden_Produccion",
                        "Fk_Id_Plan_Produccion",
                        "Fk_Id_Material",
                        "Fk_Id_Estado_Orden_Produccion",
                        "Cantidad_Programada_Orden_Produccion",
                        "Cantidad_Producida_Orden_Produccion",
                        "Fecha_Inicio_Orden_Produccion",
                        "Fecha_Fin_Orden_Produccion"
                     };

            string[] sEtiquetas = {
                        "ID Orden produccion:",
                        "FK plan produccion:",
                        "FK material:",
                        "FK estado orden produccion",
                        "Cantidad programada:",
                        "Fecha inicio orden produccion:",
                        "Fecha fin orden produccion"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Plan_Produccion",
                        TablaReferencia = "tbl_plan_produccion",
                        CampoPK         = "Pk_Id_Plan_Produccion",
                        CampoMostrar    = "Descripcion_Plan_Produccion",

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Material",
                        TablaReferencia = "tbl_materiales",
                        CampoPK         = "Pk_Id_Materiales",
                        CampoMostrar    = "Codigo_Material",

                        CamposEditables = new List<Cls_CampoEditable>
                        {
                            new Cls_CampoEditable { NombreCampo = "Stock_Minimo",  Etiqueta = "Stock minimo", SoloLectura = false },
                            new Cls_CampoEditable { NombreCampo = "Activo",  Etiqueta = "Activo", SoloLectura = false },
                        }
                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Estado_Orden_Produccion",
                        TablaReferencia = "tbl_estado_orden_produccion",
                        CampoPK         = "Pk_Id_Estado_Orden_Produccion",
                        CampoMostrar    = "Nombre_Estado_Orden_Produccion"
                    }
                };




            int id_aplicacion = 301;
            int id_modulo = 4;

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
