using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ernesto David Samayoa Jocol 0901-22-3415 Nuevo ingreso
namespace Capa_Vista_Seguridad
{
    public partial class Frm_EmpleadosV2 : Form
    {
        private Timer timerBotones; // 🔹 temporizador para vigilar los botones
        public Frm_EmpleadosV2()
        {
            InitializeComponent();
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
                    "Tbl_Empleado",
                    "Pk_Id_Empleado",
                    "Cmp_Nombres_Empleado",
                    "Cmp_Apellidos_Empleado",
                    "Cmp_DPi_Empleado",
                    "Cmp_Nit_Empleado",
                    "Cmp_Correo_Empleado",
                    "Cmp_Telefono_Empleado",
                    "Cmp_Genero_Empleado",
                    "Cmp_Fecha_Nacimiento_Empleado",
                    "Cmp_Fecha_Contratacion__Empleado"

            };

            string[] sEtiquetas = {
                    "Id Empleado ",
                    "Nombre",
                    "Apellido",
                    "Dpi",
                    "Nit",
                    "Correo",
                    "Teléfono",
                    "Genero",
                    "Fecha Nacimiento",
                    "Fecha Contratación"

                };


            int id_aplicacion = 3402;
            int id_Modulo = 6;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();

            // ==============================
            // 🔓 Activar los botones al inicio
            // ==============================
            ActivarBotonesInternos(navegador1);

            // ==============================
            // 🔁 Crear un temporizador que re-activa botones cada 0.5 segundos
            // ==============================
            timerBotones = new Timer();
            timerBotones.Interval = 500; // medio segundo
            timerBotones.Tick += (s, e) => ActivarBotonesInternos(navegador1);
            timerBotones.Start();

        }

        // ======================================================
        // Función recursiva para habilitar botones dentro del navegador
        // ======================================================
        public void ActivarBotonesInternos(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                if (c is Button btn)
                    btn.Enabled = true;
                else if (c.HasChildren)
                    ActivarBotonesInternos(c);
            }
        }
    }
}