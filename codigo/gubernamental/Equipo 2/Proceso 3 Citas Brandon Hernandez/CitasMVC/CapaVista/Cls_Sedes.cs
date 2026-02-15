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
namespace CapaVista
{
    public partial class Cls_Sedes : Form
    {
        public Cls_Sedes()
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
                Nombre = "dgv_sedes"
            };
            string[] columnas = {
                    "Tbl_Sede",
                    "Pk_Id_sede",
                    "Cmp_Departamento",
                    "Cmp_Municipio",
                    "Cmp_Direccion"
                 
            };

            string[] sEtiquetas = {
                    "Id Sede ",
                    "Departamento",
                    "Municipio",
                    "Direccion"
             

                };


            int id_aplicacion = 301;
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

