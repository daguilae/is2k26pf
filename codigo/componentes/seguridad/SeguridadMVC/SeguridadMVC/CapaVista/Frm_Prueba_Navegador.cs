using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Seguridad
{
    public partial class Frm_Prueba_Navegador : Form
    {

        public Frm_Prueba_Navegador()
        {
            InitializeComponent();
            //parametros para navegador
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
                        "tbl_empleados",
                        "Cmp_iId_Empleado",
                        "Cmp_sNombre_Empleado",
                        "Cmp_sApellido_Empleado",
                        "Cmp_sDpi_Empleado",
                        "Cmp_dFechaIngreso_Empleado",
                        "Cmp_deSalario_Empleado",
                        "Cmp_iId_Puesto",
                        "Cmp_bEstado_Empleado"
                    };

            string[] sEtiquetas = {
                        "Código Empleado",
                        "Nombre",
                        "Apellido",
                        "DPI",
                        "Fecha de Ingreso",
                        "Salario",
                        "Código Puesto",
                        "Estado del Empleado"
                    };



            int id_aplicacion = 303;
            int id_Modulo = 4;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();
        }
    }
}
