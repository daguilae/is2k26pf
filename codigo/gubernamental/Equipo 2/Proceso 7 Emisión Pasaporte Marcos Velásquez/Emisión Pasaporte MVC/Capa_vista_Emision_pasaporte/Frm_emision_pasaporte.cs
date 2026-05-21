using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Image = System.Drawing.Image;
using Capa_Controlador_Emision;
using System.IO;

namespace Capa_vista_Emision_pasaporte
{
    public partial class Frm_emision_pasaporte : Form
    {
        public Frm_emision_pasaporte()
        {

            QuestPDF.Settings.License = LicenseType.Community;

            InitializeComponent();


            Cmb_tipo.Items.Clear();
            Cmb_tipo.Items.Add("P");

            Cmb_sexo.Items.Clear();
            Cmb_sexo.Items.Add("M");
            Cmb_sexo.Items.Add("F");
            Cmb_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

           
            Cmb_pais_emisor.Items.Clear();
            Cmb_pais_emisor.Items.Add("GTM");
            Cmb_pais_emisor.DropDownStyle = ComboBoxStyle.DropDownList;

            
            Cmb_autoridad.Items.Clear();
            Cmb_autoridad.Items.Add("Migración");
            Cmb_autoridad.Items.Add("Consulado");
            Cmb_autoridad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void Cmb_pais_emisor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {



           
            byte[] imagenBytes = null;
            if (Ptb_fotografia.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                   
                    using (Bitmap bmp = new Bitmap(Ptb_fotografia.Image))
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    imagenBytes = ms.ToArray();
                }
            }

           
            byte[] firmaDummy = new byte[0];

            Cls_controlador controlador = new Cls_controlador();
            try
            {
                controlador.Guardar(
                    Txt_identidad_no.Text, Txt_nombre.Text, Txt_apellidos.Text,
                    Cmb_sexo.Text, Dtp_fecha_nacimiento.Value,
                    Txt_numero_pasaporte.Text, Dtp_fecha_emision.Value, Dtp_fecha_vecimiento.Value,
                    imagenBytes, firmaDummy 
                );
                MessageBox.Show("Registro completo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_fotografia frm = new Frm_fotografia();
        


            frm.OnFotoCapturada = (imagen) =>
            {
                if (Ptb_fotografia.Image != null)
                {
                    Ptb_fotografia.Image.Dispose();
                }

                Ptb_fotografia.Image = (Image)imagen.Clone();
            };

            frm.ShowDialog();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btn_cerrarr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_emision_pasaporte_Load(object sender, EventArgs e)
        {

        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {


            string tipo = Cmb_tipo.Text;
            string pais_Emisor = Cmb_pais_emisor.Text;
            string Pasaporte_N = Txt_numero_pasaporte.Text;
            string No_Libreta = Txt_no_libreta.Text;
            string Nombre = Txt_nombre.Text;
            string Apellidos = Txt_apellidos.Text;
            string Nacionalidad = Txt_nacionalidad.Text;
            string FechaNacimiento = Dtp_fecha_nacimiento.Value.ToString("yyyy-MM-dd");
            string Identidad_No = Txt_identidad_no.Text;
            string Sexo = Cmb_sexo.Text;
            string Lugar_Nacimiento = Txt_lugar_nacimiento.Text;
            string Autoridad = Cmb_autoridad.Text;
            string Fecha_Emision = Dtp_fecha_emision.Value.ToString("yyyy-MM-dd");
            string Fecha_Vencimiento = Dtp_fecha_vecimiento.Value.ToString("yyyy-MM-dd");

            string ruta = @"C:\Users\Public\pasaporte.pdf";

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);

                    page.Content().Column(col =>
                    {
                        col.Item().Text("PASAPORTE").FontSize(20).Bold();

                        col.Item().Text($"Nombre: {Nombre} {Apellidos}");
                        col.Item().Text($"Pasaporte No: {Pasaporte_N}");
                        col.Item().Text($"Nacionalidad: {Nacionalidad}");
                        col.Item().Text($"Fecha Nacimiento: {FechaNacimiento}");
                        col.Item().Text($"Sexo: {Sexo}");
                        col.Item().Text($"País Emisor: {pais_Emisor}");
                        col.Item().Text($"Autoridad: {Autoridad}");
                        col.Item().Text($"Fecha Emisión: {Fecha_Emision}");
                        col.Item().Text($"Fecha Vencimiento: {Fecha_Vencimiento}");

                        if (Ptb_fotografia.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                Ptb_fotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] imageBytes = ms.ToArray();

                                col.Item().Image(imageBytes);
                            }
                        }
                    });
                });
            })
            .GeneratePdf(ruta);

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = ruta,
                UseShellExecute = true
            });

            MessageBox.Show("PDF generado y abierto correctamente");



















        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {



            Cls_controlador controlador = new Cls_controlador();
            try
            {
                DataTable datos = controlador.ObtenerDatosSolicitante(Txt_identidad_no.Text);

                if (datos != null && datos.Rows.Count > 0)
                {
                    DataRow fila = datos.Rows[0];

                  
                    Txt_nombre.Text = fila["Cmp_Nombre"].ToString();
                    Txt_apellidos.Text = fila["Cmp_Apellido"].ToString();
                    Cmb_sexo.Text = fila["Cmp_Sexo"].ToString();
                    Dtp_fecha_nacimiento.Value = Convert.ToDateTime(fila["Cmp_Fecha_Nacimiento"]);

                    
                    if (datos.Columns.Contains("fotografia") && fila["fotografia"] != DBNull.Value)
                    {
                        byte[] imagenBytes = (byte[])fila["fotografia"];
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            Ptb_fotografia.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        Ptb_fotografia.Image = null; 
                    }

                    MessageBox.Show("Datos cargados.");
                }
                else
                {
                    MessageBox.Show("No se encontró el DPI.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }

        }

        public void recibirFirma(Image firmaCapturada)
        {
            if (firmaCapturada != null)
            {
                pbFirma.Image = new Bitmap(firmaCapturada);

                pbFirma.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btn_Firma_Click(object sender, EventArgs e)
        {
            Frm_Firma frm = new Frm_Firma();
            frm.Show();
        }
    }
}
