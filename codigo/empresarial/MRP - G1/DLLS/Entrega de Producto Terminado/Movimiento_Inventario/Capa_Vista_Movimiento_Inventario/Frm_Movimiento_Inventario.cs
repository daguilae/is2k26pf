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

namespace Capa_Vista_Movimiento_Inventario
{
    public partial class Frm_Movimiento_Inventario : Form
    {
        public Frm_Movimiento_Inventario()
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
                        "tbl_movimiento_inventarios",
                        "Pk_Id_Movimiento_Inventarios",
                        "Fk_Tipo_Movimiento",
                        "Fk_Id_Material",
                        "Cantidad_Movida_Movimiento_Inventarios",
                        "Fk_Id_Almacen_Origen",
                        "Fk_Id_Almacen_Destino",
                        "Fk_Orden_Produccion",
                        "Fk_Id_Recepcion_Material",
                        "Fecha_Movimiento_Inventarios",
                        "Observacion_Movimiento_Inventarios"
                     };

            string[] sEtiquetas = {
                        "ID Movimiento inventario",
                        "Tipo de movimiento:",
                        "Material",
                        "Cantidad Movida Movimiento Inventarios",
                        "Nombre Almacen Origen",
                        "Almacen Destino",
                        "Cantidad producida",
                        "Costo Unitario Recibido",
                        "Fecha Movimiento Inventario",
                        "Observacion Movimiento Inventario"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Tipo_Movimiento",
                        TablaReferencia = "tbl_tipo_movimiento_inventario",
                        CampoPK         = "Pk_Id_Tipo_Movimiento_Inventario",
                        CampoMostrar    = "Nombre_Tipo_Movimiento_Inventario",

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
                        CampoFK         = "Fk_Id_Almacen_Origen",
                        TablaReferencia = "tbl_almacen",
                        CampoPK         = "Pk_Id_Almacen",
                        CampoMostrar    = "Nombre_Almacen"
                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Almacen_Destino",
                        TablaReferencia = "tbl_almacen",
                        CampoPK         = "Pk_Id_Almacen",
                        CampoMostrar    = "Nombre_Almacen"
                    },


                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Orden_Produccion",
                        TablaReferencia = "tbl_orden_produccion",
                        CampoPK         = "Pk_Id_Orden_Produccion",
                        CampoMostrar    = "Cantidad_Producida_Orden_Produccion"
                    },

                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Recepcion_Material",
                        TablaReferencia = "tbl_recepcion_material",
                        CampoPK         = "Pk_Id_Recepcion_Material",
                        CampoMostrar    = "Costo_Unitario_Recibido"
                    }

                };




            int id_aplicacion = 721;
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
