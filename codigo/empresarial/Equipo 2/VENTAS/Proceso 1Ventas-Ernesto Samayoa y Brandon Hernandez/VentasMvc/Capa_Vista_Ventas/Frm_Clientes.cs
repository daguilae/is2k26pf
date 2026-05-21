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
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
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
                        "Tbl_Clientes",
                        "Pk_Id_Cliente",
                        "Cmp_CuioNit",
                        "Cmp_Nombre",
                        "Cmp_Apellido",
                        "Cmp_Telefono",
                        "Cmp_Correo",
                        "Cmp_Saldo_Total",
                        "Cmp_Direccion",
                        "Fk_Id_Tipo_Cliente",
                        "Cmp_Estado"

                     };

            string[] sEtiquetas = {
                        "ID",
                        "Cui/Nit",
                        "Nombre Cliente",
                        "Apellido Cliente",
                        "Teléfono",
                        "Correo",
                        "Saldo Total",
                        "Dirección",
                        "ID Tipo Cliente",
                        "Estado"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Tipo_Cliente",
                        TablaReferencia = "Tbl_Tipo_Cliente",
                        CampoPK         = "Id_Tipo_Cliente",
                        CampoMostrar    = "Cmp_Tipo",

                        CamposEditables = new List<Cls_CampoEditable>
                        {
                            new Cls_CampoEditable { NombreCampo = "Cmp_Descripcion",  Etiqueta = "Descripcion", SoloLectura = true  },


                        }
                    },


                };

            int id_aplicacion = 702;
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
