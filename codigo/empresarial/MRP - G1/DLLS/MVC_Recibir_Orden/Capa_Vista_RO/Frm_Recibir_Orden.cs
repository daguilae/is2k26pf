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

namespace Capa_Vista_RO
{
    public partial class Frm_Recibir_Orden : Form
    {
        public Frm_Recibir_Orden()
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
                        "Tbl_Orden_Recibida",
                        "Pk_Id_Orden_Recibida",
                        "Id_Externo_Logistica",
                        "Fk_Id_Material",
                        "Fk_Id_Estado_Orden_Recibida",
                        "Cantidad_Solicitada",
                        "Fecha_Recepcion",
                        "Fecha_Requerida",
                        "Observacion"
                     };

            string[] sEtiquetas = {
                        "ID Orden Recibida",
                        "ID Logistica",
                        "Id Material",
                        "Estado de Orden",
                        "Cantidad_Solicitada",
                        "Fecha_Recepcion",
                        "Fecha_Requerida",
                        "Observacion"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Material",
                        TablaReferencia = "Tbl_Materiales",
                        CampoPK         = "Pk_Id_Materiales",
                        CampoMostrar    = "Nombre_Material",
                        CamposEditables = new List<Cls_CampoEditable>
                        {
                            new Cls_CampoEditable { NombreCampo = "Stock_Minimo",  Etiqueta = "Stock minimo", SoloLectura = false },
                            new Cls_CampoEditable { NombreCampo = "Activo",  Etiqueta = "Activo", SoloLectura = false },
                        }

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Estado_Orden_Recibida",
                        TablaReferencia = "Tbl_Estado_Orden_Recibida",
                        CampoPK         = "Pk_Id_Estado_Orden_Recibida",
                        CampoMostrar    = "Nombre_Estado_Orden_Recibida",

                        
                    },

                   
                };




            int id_aplicacion = 714;
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
