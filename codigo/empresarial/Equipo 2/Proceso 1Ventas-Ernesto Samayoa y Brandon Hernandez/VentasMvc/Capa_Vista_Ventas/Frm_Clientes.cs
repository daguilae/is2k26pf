using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
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
                    "Tbl_Clientes",
                    "Pk_Id_Cliente",
                    "Cmp_CuioNit",
                    "Cmp_Nombre",
                    "Cmp_Apellido",
                    "Cmp_Telefono",
                    "Cmp_Correo",
                    "Cmp_Saldo_Total",
                    "Cmp_Direccion",
                    "Cmp_Estado"
                };

            string[] sEtiquetas = {
                    "Código Cliente",
                    "CUI/NIT",
                    "Nombre",
                    "Apellido",
                    "Telefono",
                    "Correo",
                    "Saldo Total",
                    "Dirección",
                    "Estado"
                };
            int id_aplicacion = 702;
            int id_Modulo = 44;
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
