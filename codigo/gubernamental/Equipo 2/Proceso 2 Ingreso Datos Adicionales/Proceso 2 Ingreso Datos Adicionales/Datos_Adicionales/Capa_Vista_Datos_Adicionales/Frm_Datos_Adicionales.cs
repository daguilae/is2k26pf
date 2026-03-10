/*
    Autor: Diego Andre Monterroso Rabarique
    Formulario: Frm_Datos_Adicionales
    Descripción: Vista los datos adicionales
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
namespace Capa_Vista_Datos_Adicionales
{
    public partial class Frm_Datos_Adicionales : Form
    {
        private Cls_Controlador_DatosAdicionales gObjControlador = new Cls_Controlador_DatosAdicionales();

        public Frm_Datos_Adicionales()
        {
            InitializeComponent();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {

        }

        private void funLimpiarCampos()
        {
            Txt_DPI.Clear();
            Txt_Domicilio.Clear();
            Txt_Informacion.Clear();

            Cmb_Tipo.SelectedIndex = -1;
            Cmb_Tipo_Atencion.SelectedIndex = -1;

            Nud_Cuantas_Personas.Value = 0;
        }

        private void Txt_DPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aquí después puedes validar si solo números o también letras
        }

        private bool funValidarCampos(out string sMensaje)
        {
            sMensaje = "";

            if (string.IsNullOrWhiteSpace(Txt_DPI.Text))
            {
                sMensaje = "El campo DPI o Pasaporte es obligatorio.";
                return false;
            }

            if (Cmb_Tipo.SelectedIndex == -1)
            {
                sMensaje = "Seleccione el Tipo de trámite.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Domicilio.Text))
            {
                sMensaje = "El Domicilio es obligatorio.";
                return false;
            }

            if (Nud_Cuantas_Personas.Value < 0)
            {
                sMensaje = "La cantidad de personas no puede ser negativa.";
                return false;
            }

            if (Cmb_Tipo_Atencion.SelectedIndex == -1)
            {
                sMensaje = "Seleccione el Tipo de atención.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Txt_Informacion.Text))
            {
                sMensaje = "La información de viaje es obligatoria.";
                return false;
            }

            return true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string sMensaje;

            if (!funValidarCampos(out sMensaje))
            {
                MessageBox.Show(sMensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Aquí después irá tu método del controlador
        }

        private void Frm_Datos_Adicionales_Load(object sender, EventArgs e)
        {
            Cmb_Tipo.Items.Clear();
            Cmb_Tipo.Items.Add("Ordinario");
            Cmb_Tipo.Items.Add("Oficial");
            Cmb_Tipo.Items.Add("Diplomático");

            Cmb_Tipo_Atencion.Items.Clear();
            Cmb_Tipo_Atencion.Items.Add("Personal");
            Cmb_Tipo_Atencion.Items.Add("Familiar");
            Cmb_Tipo_Atencion.Items.Add("Empresarial");

            Cmb_Tipo.SelectedIndex = -1;
            Cmb_Tipo_Atencion.SelectedIndex = -1;
        }
    }
}