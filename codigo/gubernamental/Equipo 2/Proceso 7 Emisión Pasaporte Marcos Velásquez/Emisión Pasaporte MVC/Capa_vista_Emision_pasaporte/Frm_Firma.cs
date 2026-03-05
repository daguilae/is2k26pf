using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Emision;

namespace Capa_vista_Emision_pasaporte
{
    public partial class Frm_Firma : Form
    {
        Point puntoAnterior = Point.Empty;
        Bitmap bmp;
        Graphics g;
        Pen lapiz = new Pen(Color.Black, 2f);

        public Frm_Firma()
        {
            InitializeComponent();
            InicializarLienzo();
        }

        private void InicializarLienzo()
        {
            // Creamos el mapa de bits del tamaño del PictureBox
            bmp = new Bitmap(Ptb_firma.Width, Ptb_firma.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Ptb_firma.Image = bmp;
        }

        private void Ptb_firma_MouseDown(object sender, MouseEventArgs e) => puntoAnterior = e.Location;

        private void Ptb_firma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(lapiz, puntoAnterior, e.Location);
                puntoAnterior = e.Location;
                Ptb_firma.Invalidate();
            }
        }

        private void Ptb_firma_MouseUp(object sender, MouseEventArgs e) => puntoAnterior = Point.Empty;

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Ptb_firma.Image != null)
            {

                var formularioAbierto = Application.OpenForms["Frm_emision_pasaporte"];

                if (formularioAbierto != null)
                {
                    Frm_emision_pasaporte principal = (Frm_emision_pasaporte)formularioAbierto;
                    principal.recibirFirma(Ptb_firma.Image);
                    this.Close();
                }
                else
                {
                    // Esto te ayudará a saber si el problema es que no lo encuentra
                    MessageBox.Show("Error: No se encontró el formulario principal abierto.");
                }
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Ptb_firma.Invalidate();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
