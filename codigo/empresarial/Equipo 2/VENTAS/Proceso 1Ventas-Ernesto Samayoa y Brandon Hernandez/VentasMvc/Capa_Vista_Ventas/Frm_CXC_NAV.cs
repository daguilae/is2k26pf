using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_NavegadorTrs;

namespace Capa_Vista_Ventas
{
    public partial class Frm_CXC_NAV : Form
    {
        public Frm_CXC_NAV()
        {
            InitializeComponent();
            //navegadorTrs1.Load += (s, e) => navegadorTrs1.BotonesEstadoCRUD(true, true, true, true, true);
            Capa_Controlador_NavegadorTrs.Cls_ConfiguracionDataGridView config = new Capa_Controlador_NavegadorTrs.Cls_ConfiguracionDataGridView
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
                        "Tbl_Cuentas_Por_Cobrar",
                        "Pk_Id_Cuenta_Por_Cobrar",
                        "Fk_Id_Venta",
                        "Fk_Id_Cliente",
                        "Cmp_Fecha_De_Deuda",
                        "Cmp_Fecha_Vencimiento",
                        "Cmp_Monto_Total",
                        "Cmp_Estado"

                     };

            string[] sEtiquetas = {
                        "ID :",
                        "Venta:",
                        "Cliente:",
                        "Fecha Deuda",
                        "Fecha Vencimiento :",
                        "Monto Total :",
                        "Estado"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Venta",
                        TablaReferencia = "Tbl_Ventas",
                        CampoPK         = "Pk_Id_Ventas",
                        CampoMostrar    = "Pk_Id_Ventas",

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Cliente",
                        TablaReferencia = "Tbl_Clientes",
                        CampoPK         = "Pk_Id_Cliente",
                        CampoMostrar    = "Cmp_Nombre",

                        CamposEditables = new List<Cls_CampoEditable>
                        {
                             new Cls_CampoEditable { NombreCampo = "Cmp_Nombre",  Etiqueta = "Nombre", SoloLectura = true  },
                            new Cls_CampoEditable { NombreCampo = "Cmp_Apellido",  Etiqueta = "Apellidos", SoloLectura = true  },


                        }
                    },


                };




            int id_aplicacion = 711;
            int id_modulo = 44;

            navegadorTrs1.IPkId_Aplicacion = id_aplicacion;
            navegadorTrs1.IPkId_Modulo = id_modulo;
            navegadorTrs1.configurarDataGridView(config);
            navegadorTrs1.SNombreTabla = columnas[0];
            navegadorTrs1.SAlias = columnas;
            navegadorTrs1.SEtiquetas = sEtiquetas;
            navegadorTrs1.SConfiguracionFK = fks;
            navegadorTrs1.mostrarDatos();
        }
    }
}
 