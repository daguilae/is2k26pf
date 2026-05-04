using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_Navegador;

namespace PruebaEjecucionNavegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            navegador1.Load += Navegador1_Load;

            void Navegador1_Load(object sender, EventArgs e)
            {
                navegador1.BotonesEstadoCRUD(true, true, true, true, true);
            }

            // ─────────────────────────────────────────────────────────────────
            // CONFIGURACIÓN DEL DATAGRIDVIEW
            // ─────────────────────────────────────────────────────────────────
            Cls_ConfiguracionDataGridView config = new Cls_ConfiguracionDataGridView
            {
                Ancho          = 1100,
                Alto           = 200,
                PosX           = 10,
                PosY           = 350,
                ColorFondo     = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre         = "dgv_plan_produccion"
            };

            // ─────────────────────────────────────────────────────────────────
            // COLUMNAS de Tbl_Plan_Produccion
            // ─────────────────────────────────────────────────────────────────
            string[] columnas = {
                "Tbl_Plan_Produccion",              // [0] tabla principal
                "Pk_Id_Plan_Produccion",            // [1] PK (se bloquea sola)
                "Fk_Id_Orden_Recibida",             // [2] FK → Tbl_Orden_Recibida
                "Fk_Id_Estado_Plan_Produccion",     // [3] FK → Tbl_Estado_Plan_Produccion
                "Fecha_Plan_Produccion",            // [4] fecha  → DateTimePicker automático
                "Descripcion_Plan_Produccion"       // [5] texto  → ComboBox normal
            };

            string[] etiquetas = {
                "ID Plan",
                "Orden Recibida",         // combo mostrará el ID externo de la orden
                "Estado del Plan",        // combo mostrará nombre del estado
                "Fecha del Plan",
                "Descripción"
            };

            // ─────────────────────────────────────────────────────────────────
            // CONFIGURACIÓN DE FK con CAMPOS EDITABLES  ← NUEVA FUNCIONALIDAD
            //
            // FK 1 → Tbl_Orden_Recibida
            //   El combo muestra: Id_Externo_Logistica
            //   Campos editables de esa tabla que aparecerán en el formulario:
            //     - Id_Externo_Logistica  (editable)
            //     - Cantidad_Solicitada   (editable)
            //     - Fecha_Requerida       (editable)
            //     - Observacion           (editable)
            //     - Fecha_Recepcion       (solo lectura - es un timestamp automático)
            //
            // FK 2 → Tbl_Estado_Plan_Produccion
            //   Solo combo de selección, sin campos editables (comportamiento original)
            // ─────────────────────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> configuracionFK = new List<Cls_ConfiguracionFK>
            {
                new Cls_ConfiguracionFK
                {
                    CampoFK         = "Fk_Id_Orden_Recibida",
                    TablaReferencia = "Tbl_Orden_Recibida",
                    CampoPK         = "Pk_Id_Orden_Recibida",
                    CampoMostrar    = "Id_Externo_Logistica",
                    FormatoDisplay  = "{PK} - {DISPLAY}",  // combo muestra: "5 - ORD-2024-001"

                    // Campos de Tbl_Orden_Recibida que el usuario puede VER y EDITAR
                    CamposEditables = new List<Cls_CampoEditable>
                    {
                        new Cls_CampoEditable
                        {
                            NombreCampo = "Id_Externo_Logistica",
                            Etiqueta    = "ID Externo Logística",
                            SoloLectura = false   // editable
                        },
                        new Cls_CampoEditable
                        {
                            NombreCampo = "Cantidad_Solicitada",
                            Etiqueta    = "Cantidad Solicitada",
                            SoloLectura = false
                        },
                        new Cls_CampoEditable
                        {
                            NombreCampo = "Fecha_Requerida",
                            Etiqueta    = "Fecha Requerida",
                            SoloLectura = false
                        },
                        new Cls_CampoEditable
                        {
                            NombreCampo = "Observacion",
                            Etiqueta    = "Observación",
                            SoloLectura = false
                        },
                        new Cls_CampoEditable
                        {
                            NombreCampo = "Fecha_Recepcion",
                            Etiqueta    = "Fecha de Recepción",
                            SoloLectura = true    // SOLO LECTURA: timestamp automático de BD
                        }
                    }
                },

                new Cls_ConfiguracionFK
                {
                    CampoFK         = "Fk_Id_Estado_Plan_Produccion",
                    TablaReferencia = "Tbl_Estado_Plan_Produccion",
                    CampoPK         = "Pk_Id_Estado_Plan_Produccion",
                    CampoMostrar    = "Nombre_Estado_Plan_Produccion"
                    // Sin CamposEditables → solo combo de selección (igual que antes)
                }
            };

            // ─────────────────────────────────────────────────────────────────
            // ASIGNACIÓN AL NAVEGADOR
            // ─────────────────────────────────────────────────────────────────
            int id_aplicacion = 100;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla     = columnas[0];
            navegador1.SAlias           = columnas;
            navegador1.SEtiquetas       = etiquetas;
            navegador1.SConfiguracionFK = configuracionFK;
            navegador1.mostrarDatos();
        }
    }
}
