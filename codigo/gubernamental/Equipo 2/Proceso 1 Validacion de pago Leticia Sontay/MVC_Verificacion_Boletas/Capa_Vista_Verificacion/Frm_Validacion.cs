using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Verificacion;



namespace Capa_Vista_Verificacion
{
    public partial class Frm_Validacion : Form
    {
        // Instancia del controlador
        private readonly Cls_Controlador_Verificacion controlador = new Cls_Controlador_Verificacion();

        public Frm_Validacion()
        {
            InitializeComponent();
        }

        private void btn_Validacion_Click(object sender, EventArgs e)
        {
            // Obtener y limpiar el texto del TextBox
            string numeroBoleta = Txt_Validacion.Text.Trim();

            // Validar que no esté vacío
            if (string.IsNullOrEmpty(numeroBoleta))
            {
                MessageBox.Show(
                    "Por favor, ingrese un número de boleta.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                Txt_Validacion.Focus();
                return;
            }

            try
            {
                // Llamar al controlador
                DataTable resultado = controlador.ValidarBoleta(numeroBoleta);

                // Evaluar resultado
                if (resultado == null || resultado.Rows.Count == 0)
                {
                    MessageBox.Show(
                        $"La boleta N° {numeroBoleta} no existe en el sistema.",
                        "Boleta no encontrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    string estadoBoleta = resultado.Rows[0]["estado_boleta"].ToString();
                    string idBoleta = resultado.Rows[0]["id_boleta"].ToString();

                    MessageBox.Show(
                        $"Boleta encontrada.\n\n" +
                        $"ID Boleta : {idBoleta}\n" +
                        $"N° Boleta : {numeroBoleta}\n" +
                        $"Estado    : {estadoBoleta}",
                        "Resultado de Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ocurrió un error al validar la boleta:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}