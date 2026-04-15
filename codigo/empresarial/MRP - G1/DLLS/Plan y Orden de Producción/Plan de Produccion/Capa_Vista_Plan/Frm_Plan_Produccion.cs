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

namespace Capa_Vista_Plan
{
    public partial class Frm_Plan_Produccion : Form
    {
        public Frm_Plan_Produccion()
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
                Nombre = "dgv_empleados"
            };

            // COLUMNAS (IMPORTANTE ORDEN)
            string[] columnas = {
                "Tbl_Plan_Produccion",
                "Pk_Id_Plan_Produccion",
                "Fk_Id_Orden_Recibida",
                "Fk_Id_Estado_Plan_Produccion",
                "Fecha_Plan_Produccion",
                "Descripcion_Plan_Produccion"
            };

            // ETIQUETAS
            string[] sEtiquetas = {
                "ID Plan Produccion",
                "ID Orden Recibida",
                "ID Estado Plan Produccion",
                "Descripcion Plan de Produccion"
            };

            // CONFIGURACION DE FK 
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
            {
                new Cls_ConfiguracionFK
                {
                    CampoFK = "Fk_Id_Plan_Produccion",
                    TablaReferencia = "Tbl_Orden_Recibida",
                    CampoPK = "Pk_Id_Orden_Recibida",
                    CampoMostrar = "Id_Orden_Recibida"
                },

                new Cls_ConfiguracionFK
                {
                    CampoFK = "Fk_Id_Estado_Plan_Produccion",
                    TablaReferencia = "Tbl_Estado_Plan_Produccion",
                    CampoPK = "Pk_Id_Estado_Plan_Produccion",
                    CampoMostrar = "Id_Estado_Plan_Produccion"
                },

             
            };

            int id_aplicacion = 711;
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
  