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

namespace Capa_Vista_Datos_Cliente
{
    public partial class Frm_Datos_Solicitante : Form
    {
        private Cls_Controlador gObjControlador = new Cls_Controlador();
        public Frm_Datos_Solicitante()
        {
            InitializeComponent();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
          
        }

        private void funLimpiarCampos()
        {
            TxtDPI.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();

            Cbo_Sexo.SelectedIndex = -1;
            Cbo_estadoCivil.SelectedIndex = -1;
            Cbo_departamento.SelectedIndex = -1;

            Drt_fecha_nacimiento.Value = DateTime.Today;
        }
        private void TxtDPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            // Máximo 13
            if (!char.IsControl(e.KeyChar) && TxtDPI.Text.Length >= 13)
                e.Handled = true;
        }
        private bool funValidarCampos(out string sMensaje)
        {
            sMensaje = "";

            if (TxtDPI.Text.Trim().Length != 13)
            {
                sMensaje = "El DPI debe tener exactamente 13 dígitos.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                sMensaje = "El Nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                sMensaje = "El Apellido es obligatorio.";
                return false;
            }

            if (Cbo_Sexo.SelectedIndex == -1)
            {
                sMensaje = "Seleccione el Sexo.";
                return false;
            }

            if (Cbo_estadoCivil.SelectedIndex == -1)
            {
                sMensaje = "Seleccione el Estado Civil.";
                return false;
            }

            if (Cbo_departamento.SelectedIndex == -1)
            {
                sMensaje = "Seleccione el Departamento.";
                return false;
            }

            if (Drt_fecha_nacimiento.Value.Date >= DateTime.Today)
            {
                sMensaje = "La fecha de nacimiento no puede ser hoy o futura.";
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

            bool bResultado = gObjControlador.funGuardarSolicitante(
                TxtDPI.Text.Trim(),
                TxtNombre.Text.Trim(),
                TxtApellido.Text.Trim(),
                Cbo_Sexo.Text.Trim(),
                Cbo_departamento.Text.Trim(),
                Cbo_estadoCivil.Text.Trim(),
                Drt_fecha_nacimiento.Value.Date,
                out sMensaje);

            if (bResultado)
            {
                MessageBox.Show("Datos guardados correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                funLimpiarCampos();
            }
            else
            {
                MessageBox.Show(sMensaje, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Datos_Solicitante_Load(object sender, EventArgs e)
        {
            // ================= SEXO =================
            Cbo_Sexo.Items.Clear();
            Cbo_Sexo.Items.Add("M");
            Cbo_Sexo.Items.Add("F");

            // ================= ESTADO CIVIL =================
            Cbo_estadoCivil.Items.Clear();
            Cbo_estadoCivil.Items.Add("Soltero");
            Cbo_estadoCivil.Items.Add("Casado");
            Cbo_estadoCivil.Items.Add("Divorciado");
            Cbo_estadoCivil.Items.Add("Viudo");

            // ================= DEPARTAMENTO =================
            Cbo_departamento.Items.Clear();
            Cbo_departamento.Items.Add("Guatemala");
            Cbo_departamento.Items.Add("Sacatepéquez");
            Cbo_departamento.Items.Add("Chimaltenango");
            Cbo_departamento.Items.Add("Escuintla");
            Cbo_departamento.Items.Add("Quetzaltenango");
            Cbo_departamento.Items.Add("Petén");
            // Agrega los que necesites

            // Opcional: dejar sin selección
            Cbo_Sexo.SelectedIndex = -1;
            Cbo_estadoCivil.SelectedIndex = -1;
            Cbo_departamento.SelectedIndex = -1;

            Cbo_tipoPasaporte.Items.Clear();
            Cbo_tipoPasaporte.Items.Add("Temporal");
            Cbo_tipoPasaporte.Items.Add("Diplomático");
            Cbo_tipoPasaporte.Items.Add("Oficial");
            Cbo_tipoPasaporte.Items.Add("Menores");
        }
    }
}
