using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Mov_Inv;
using Capa_Modelo_Mov_Inv;
using Capa_Controlador_NavegadorTrs;

namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Inventario_Mantenimiento : Form
    {
        public Frm_Inventario_Mantenimiento()
        {
            InitializeComponent();

            //navegadorTrs1.Load += (s, e) => 
            //    navegadorTrs1.BotonesEstadoCRUD(true, true, true, true, true);

            // ─────────────────────────────────────────────────────────────────
            // CONFIGURACIÓN DEL DATAGRIDVIEW
            // ─────────────────────────────────────────────────────────────────
            Capa_Controlador_NavegadorTrs.Cls_ConfiguracionDataGridView config =
                new Capa_Controlador_NavegadorTrs.Cls_ConfiguracionDataGridView
                {
                    Ancho = 1100,
                    Alto = 250,
                    PosX = 10,
                    PosY = 300,
                    ColorFondo = Color.AliceBlue,
                    TipoScrollBars = ScrollBars.Both,
                    Nombre = "dgv_inventario"
                };

            // ─────────────────────────────────────────────────────────────────
            // COLUMNAS DE tbl_inventario
            // ─────────────────────────────────────────────────────────────────
            string[] columnas =
            {
    "tbl_inventario",
    "pk_inventario_id",
    "fk_linea_id",
    "fk_marca_id",
    "nombre_prod",
    "descripcion",
    "precio_unitario",
    "tipo_producto",
    "estado_producto"
};

            // ─────────────────────────────────────────────────────────────────
            // ETIQUETAS
            // ─────────────────────────────────────────────────────────────────
            string[] sEtiquetas =
            {
    "ID Inventario",
    "Línea",
    "Marca",
    "Nombre Producto",
    "Descripción",
    "Precio Unitario",
    "Tipo Producto",
    "Estado Producto"
};

            // ─────────────────────────────────────────────────────────────────
            // CONFIGURACIÓN FK
            // ─────────────────────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
{
    // ============================================================
    // FK → tbl_linea_producto
    // ============================================================
    new Cls_ConfiguracionFK
    {
        CampoFK         = "fk_linea_id",
        TablaReferencia = "tbl_linea_producto",
        CampoPK         = "pk_id_linea",
        CampoMostrar    = "cmp_nombre_linea",
    },

    // ============================================================
    // FK → tbl_marca
    // ============================================================
    new Cls_ConfiguracionFK
    {
        CampoFK         = "fk_marca_id",
        TablaReferencia = "tbl_marca",
        CampoPK         = "ID_Marca",
        CampoMostrar    = "Nombre_Marca",
    }
};

            // ─────────────────────────────────────────────────────────────────
            // CONFIGURACIÓN DEL NAVEGADOR
            // ─────────────────────────────────────────────────────────────────
            int id_aplicacion = 726;
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
