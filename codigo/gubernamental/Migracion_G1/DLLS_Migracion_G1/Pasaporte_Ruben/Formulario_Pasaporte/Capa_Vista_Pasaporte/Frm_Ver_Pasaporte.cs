using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Capa_Controlador_Pasaporte;

namespace Capa_Vista_Pasaporte
{
    public partial class Frm_Ver_Pasaporte : Form
    {
        Controlador_Ver_Pasaporte controlador = new Controlador_Ver_Pasaporte();

        // PROPIEDAD PARA DEVOLVER EL PASAPORTE CAPTURADO
        public Bitmap ImagenPasaporteCapturada { get; private set; }

        public Frm_Ver_Pasaporte(int numeroPasaporte)
        {
            InitializeComponent();

            // Ajustar imagen automáticamente
            Ptb_Foto.SizeMode = PictureBoxSizeMode.Zoom;

            // Capturar antes de cerrar
            this.FormClosing += Frm_Ver_Pasaporte_FormClosing;

            CargarDatos(numeroPasaporte);
        }

        private void CargarDatos(int numeroPasaporte)
        {
            try
            {
                DataTable datos = controlador.VerPasaporte(numeroPasaporte);

                if (datos.Rows.Count == 0)
                {
                    MessageBox.Show("Pasaporte no encontrado.");
                    this.Close();
                    return;
                }

                DataRow row = datos.Rows[0];

                // REPÚBLICA
                Lbl_Republica.Text = "REPÚBLICA DE " +
                    row["Cmp_Nombre_Pais"].ToString().ToUpper();

                Lbl_Tipo.Text = row["Cmp_Tipo_Pasaporte"].ToString();
                Lbl_Numero.Text = row["Pk_Numero_Pasaporte"].ToString();
                Lbl_Dpi.Text = row["Cmp_Dpi_Ciudadano"].ToString();
                Lbl_Apellidos.Text = row["Cmp_Apellidos_Ciudadano"].ToString();
                Lbl_Nombres.Text = row["Cmp_Nombres_Ciudadano"].ToString();
                Lbl_Nacionalidad.Text = row["Cmp_Nacionalidad_Ciudadano"].ToString();

                Lbl_FechaNac.Text = Convert.ToDateTime(
                    row["Cmp_Fecha_Nacimiento_Ciudadano"]
                ).ToShortDateString();

                Lbl_Sexo.Text = Convert.ToBoolean(
                    row["Cmp_Sexo_Ciudadano"]
                ) ? "M" : "F";

                Lbl_Emision.Text = Convert.ToDateTime(
                    row["Cmp_Fecha_Emision"]
                ).ToShortDateString();

                Lbl_Vencimiento.Text = Convert.ToDateTime(
                    row["Cmp_Fecha_Expiracion"]
                ).ToShortDateString();

                // FOTO CON OPACIDAD
                if (row["Cmp_Fotografia"] != DBNull.Value)
                {
                    byte[] foto = (byte[])row["Cmp_Fotografia"];

                    using (MemoryStream ms = new MemoryStream(foto))
                    {
                        Image imagenOriginal = Image.FromStream(ms);

                        // Hacer opaca
                        Image imagenOpaca = HacerImagenOpaca(imagenOriginal, 0.15f);

                        // Ponerla como fondo del panel
                        Pnl_Pasaporte.BackgroundImage = imagenOpaca;
                        Pnl_Pasaporte.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pasaporte: " + ex.Message);
            }
        }

        // ======================================================
        // MÉTODO PARA HACER IMAGEN OPACA
        // ======================================================
        private Image HacerImagenOpaca(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(
                    image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0,
                    0,
                    image.Width,
                    image.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }

            return bmp;
        }

        // ======================================================
        // CAPTURAR SOLO EL PANEL DEL PASAPORTE
        // ======================================================
        private void CapturarPasaporte()
        {
            // Forzar que todo se dibuje antes de capturar
            Pnl_Pasaporte.Refresh();
            Application.DoEvents();

            Bitmap bmp = new Bitmap(Pnl_Pasaporte.Width, Pnl_Pasaporte.Height);
            Pnl_Pasaporte.DrawToBitmap(
                bmp,
                new Rectangle(0, 0, Pnl_Pasaporte.Width, Pnl_Pasaporte.Height)
            );

            ImagenPasaporteCapturada = bmp;
        }

        // ======================================================
        // EVENTO AL CERRAR EL FORM
        // ======================================================
        private void Frm_Ver_Pasaporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            CapturarPasaporte();
        }

    }
}