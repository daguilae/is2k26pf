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
    public partial class Frm_CXC_Detalle_NAV : Form
    {
        public Frm_CXC_Detalle_NAV()
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
                        "Tbl_Cuentas_Por_Cobrar_detalle",
                        "Pk_Id_Cuenta_Por_Cobrar_Detalle",
                        "Fk_Id_Cuenta_Por_Cobrar",
                        "Fk_Id_Tipo_Operacion",
                        "Cmp_No_Documento",
                        "Cmp_Fecha_Pago",
                        "Cmp_Monto_Pagado",
                        "Cmp_Saldo_Pendiente"
                     
                     };

            string[] sEtiquetas = {
                        "ID ",
                        "Id Cuenta por cobrar",
                        "Tipo Operacion",
                        "No. Documento" ,
                        "Fecha de pago",
                        "Monto Total",
                        "Saldo pendiente"
                     };
            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Cuenta_por_Cobrar",
                        TablaReferencia = "Tbl_Cuenta_Por_Cobrar",
                        CampoPK         = "Pk_Id_Cuenta_Por_Cobrar",
                        CampoMostrar    = "Pk_Id_Cuenta_Por_Cobrar",

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Tipo_Operacion",
                        TablaReferencia = "Tbl_Tipo_Operacion_CXC",
                        CampoPK         = "pk_tipo_operacion_cxc_id",
                        CampoMostrar    = "Cmp_Operacion",


                    },
                    };

                    int id_aplicacion = 732;
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
