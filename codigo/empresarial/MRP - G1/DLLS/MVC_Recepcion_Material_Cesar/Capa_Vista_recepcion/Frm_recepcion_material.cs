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

namespace Capa_Vista_recepcion
{
    public partial class Frm_recepcion_material : Form
    {
        public Frm_recepcion_material()
        {
            InitializeComponent();

            // ACTIVAR BOTONES CRUD
            navegador1.Load += (s, e) => navegador1.BotonesEstadoCRUD(true, true, true, true, true);

            // CONFIGURACION GRID
            Cls_ConfiguracionDataGridView config = new Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_recepcion_material"
            };

            // COLUMNAS (IMPORTANTE ORDEN)
            string[] columnas = {
                "Tbl_Recepcion_Material",
                "Pk_Id_Recepcion_Material",
                "Id_Externo_Logistica",
                "Fk_Id_Material",
                "Fk_Id_Almacen_Destino",
                "Fk_Id_Estado_Recepcion_Material",
                "Cantidad_Recibida",
                "Costo_Unitario_Recibido",
                "Fecha_Notificacion",
                "Fecha_Ingreso_Almacen",
                "Observacion"
            };

            // ETIQUETAS
            string[] sEtiquetas = {
                "ID:",
                "ID Externo:",
                "Material:",
                "Almacen Destino:",
                "Estado:",
                "Cantidad Recibida:",
                "Costo Unitario:",
                "Fecha Notificacion:",
                "Fecha Ingreso:",
                "Observacion:"
            };

            // CONFIGURACION DE FK 🔥
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
            {
                new Cls_ConfiguracionFK
                {
                    CampoFK = "Fk_Id_Material",
                    TablaReferencia = "Tbl_Materiales",
                    CampoPK = "Pk_Id_Materiales",
                    CampoMostrar = "Codigo_Material"
                },

                new Cls_ConfiguracionFK
                {
                    CampoFK = "Fk_Id_Almacen_Destino",
                    TablaReferencia = "Tbl_Almacen",
                    CampoPK = "Pk_Id_Almacen",
                    CampoMostrar = "Nombre_Almacen"
                },

                new Cls_ConfiguracionFK
                {
                    CampoFK = "Fk_Id_Estado_Recepcion_Material",
                    TablaReferencia = "Tbl_Estado_Recepcion_Material",
                    CampoPK = "Pk_Id_Estado_Recepcion_Material",
                    CampoMostrar = "Nombre_Estado_Recepcion_Material"
                }
            };

            int id_aplicacion = 711; // usa el mismo si te dieron ese
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