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
namespace Capa_Vista_Fases
{
    public partial class Frm_Fases_Produccion : Form
    {
        public Frm_Fases_Produccion()
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
                "Tbl_Fases_Produccion",
                "Pk_Id_Fase_Producto",
                "Fk_Id_Material",
                "Nombre_Fase_Produccion",
                "Descripcion_Fase_Produccion"
            };

            // ETIQUETAS
            string[] sEtiquetas = {
                "ID Fase Produccion",
                "Producto",
                "Nombre Fase de Produccion",
                "Descripcion de Fase"
            };

            // CONFIGURACION DE FK 
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
            {
                new Cls_ConfiguracionFK
                {
                    CampoFK = "Fk_Id_Material",
                    TablaReferencia = "Tbl_Materiales",
                    CampoPK = "Pk_Id_Materiales",
                    CampoMostrar = "Nombre_Material"
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
