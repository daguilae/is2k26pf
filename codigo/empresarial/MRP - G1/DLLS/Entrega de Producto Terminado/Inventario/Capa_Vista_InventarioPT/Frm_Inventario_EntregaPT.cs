
//Hecho Por Diego Andre Monterroso Rabarique 0901-22-1369

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
namespace Capa_Vista_InventarioPT
{
    public partial class Frm_Inventario_EntregaPT : Form
    {
        public Frm_Inventario_EntregaPT()
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
                        "tbl_inventario",
                        "Pk_Id_Inventario",
                        "Fk_Id_Tipo_Inventario",
                        "Fk_Id_Material",
                        "Fk_Id_Almacen",
                        "Fk_Id_Orden_Produccion",
                        "Fk_Id_Estado_Produccion",
                        "Cantidad_Disponible",
                        "Costo_Unitario",
                        "Fecha_Actualizacion"
                     };

            string[] sEtiquetas = {
                        "ID Inventario:",
                        "Tipo de Inventario:",
                        "Material",
                        "Almacén:",
                        "Cantidad_Producida:",
                        "Estado de Producción:",
                        "Cantidad Disponible:",
                        "Costo Unitario:",
                        "Fecha de Actualización:"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Tipo_Inventario",
                        TablaReferencia = "tbl_tipo_inventario",
                        CampoPK         = "Pk_Id_Tipo_Inventario",
                        CampoMostrar    = "Nombre_Tipo_Inventario",

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Material",
                        TablaReferencia = "tbl_materiales",
                        CampoPK         = "Pk_Id_Materiales",
                        CampoMostrar    = "Nombre_Material",

                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Almacen",
                        TablaReferencia = "tbl_almacen",
                        CampoPK         = "Pk_Id_Almacen",
                        CampoMostrar    = "Nombre_Almacen"
                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Orden_Produccion",
                        TablaReferencia = "tbl_orden_produccion",
                        CampoPK         = "Pk_Id_Orden_Produccion",
                        CampoMostrar    = "Cantidad_Producida_Orden_Produccion"
                    },
                     new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Estado_Produccion",
                        TablaReferencia = "tbl_estado_produccion",
                        CampoPK         = "Pk_Id_Estado_Produccion",
                        CampoMostrar    = "tbl_estado_produccion"
                    }
                };

                    
                    




            int id_aplicacion = 713;
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
