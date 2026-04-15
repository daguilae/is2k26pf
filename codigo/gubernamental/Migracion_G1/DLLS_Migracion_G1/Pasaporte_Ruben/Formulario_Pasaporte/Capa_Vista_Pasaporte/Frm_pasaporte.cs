using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Capa_Controlador_Pasaporte;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Pasaporte
{
    public partial class Frm_pasaporte : Form
    {
        Controlador_Pasaporte controlador = new Controlador_Pasaporte();
        //Aron Esquit 4/3/26
        private Cls_BitacoraControlador gCtrlBitacora = new Cls_BitacoraControlador();

        private byte[] fotoBytes;
        private int idCitaGlobal;

        // Aquí guardaremos el pasaporte completo capturado
        private Bitmap pasaporteCompletoGlobal;

        public Frm_pasaporte()
        {
            InitializeComponent();
            Btn_Emitir_Pasaporte.Enabled = false;
            CargarPaises();
        }

        // ==========================================
        // CONSULTAR BOLETA
        // ==========================================
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Numero_Boleta.Text))
            {
                MessageBox.Show("Ingrese un número de boleta.");
                return;
            }

            if (!int.TryParse(Txt_Numero_Boleta.Text, out int numeroBoleta))
            {
                MessageBox.Show("El número de boleta debe ser numérico.");
                return;
            }

            DataTable datos = controlador.ConsultarBoleta(numeroBoleta);

            if (datos.Rows.Count == 0)
            {
                MessageBox.Show("Boleta no encontrada.");
                Btn_Emitir_Pasaporte.Enabled = false;
                idCitaGlobal = 0;
                return;
            }

            DataRow row = datos.Rows[0];

            idCitaGlobal = Convert.ToInt32(row["Pk_Id_Cita"]);

            Txt_Tipo_Pasaporte.Text = row["Cmp_Tipo_Pasaporte"].ToString();
            Txt_Dpi.Text = row["Cmp_Dpi_Ciudadano"].ToString();
            Txt_Nombres.Text = row["Cmp_Nombres_Ciudadano"].ToString();
            Txt_Apellidos.Text = row["Cmp_Apellidos_Ciudadano"].ToString();
            Txt_Nacionalidad.Text = row["Cmp_Nacionalidad_Ciudadano"].ToString();

            DateTime fechaNacimiento = Convert.ToDateTime(row["Cmp_Fecha_Nacimiento_Ciudadano"]);
            Txt_Fecha_Nacimiento.Text = fechaNacimiento.ToShortDateString();
            Txt_Sexo.Text = row["Cmp_Sexo_Ciudadano"].ToString();

            // Bloquear campos
            Txt_Tipo_Pasaporte.Enabled = false;
            Txt_Dpi.Enabled = false;
            Txt_Nombres.Enabled = false;
            Txt_Apellidos.Enabled = false;
            Txt_Nacionalidad.Enabled = false;
            Txt_Fecha_Nacimiento.Enabled = false;
            Txt_Sexo.Enabled = false;

            // Generar libreta
            Txt_Numero_Libreta.Text = controlador.ObtenerNumeroLibreta().ToString();
            Txt_Numero_Libreta.Enabled = false;

            // Generar número pasaporte
            if (Txt_Dpi.Text.Trim().Length < 4)
            {
                MessageBox.Show("El DPI no tiene suficientes dígitos.");
                return;
            }

            int numeroPasaporte = controlador.GenerarNumeroPasaporte(Txt_Dpi.Text.Trim(), fechaNacimiento);
            Txt_Numero_Pasaporte.Text = numeroPasaporte.ToString();
            Txt_Numero_Pasaporte.Enabled = false;

            // Fechas
            DateTime fechaEmision = controlador.ObtenerFechaEmision();
            Dtp_Fecha_Emision.Value = fechaEmision;
            Dtp_Fecha_Emision.Enabled = false;

            int duracion = Convert.ToInt32(row["Cmp_Duracion_Pasaporte"]);
            Dtp_Fecha_Expiracion.Value = controlador.CalcularFechaExpiracion(fechaEmision, duracion);
            Dtp_Fecha_Expiracion.Enabled = false;

            // Menor
            bool esMenor = controlador.EsMenorDeEdad(fechaNacimiento);
            Chk_Menor.Checked = esMenor;
            Chk_Menor.Enabled = false;
            HabilitarChecklistMenor(esMenor);

            // Estado
            string estado = row["Cmp_Nombre_Estado"].ToString().Trim().ToLower();

            Btn_Emitir_Pasaporte.Enabled = (estado == "pendiente");

            if (estado != "pendiente")
                MessageBox.Show("La cita no está pendiente.");
        }

        // ==========================================
        private void HabilitarChecklistMenor(bool habilitar)
        {
            Chk_Certificado_Nacimiento.Enabled = habilitar;
            Chk_Ambos_Padres.Enabled = habilitar;
            Chk_Dpi_Ambos_Padres.Enabled = habilitar;
            Chk_Carta_Notariada.Enabled = habilitar;
            Chk_Autorizacion_Judicial.Enabled = habilitar;
            Chk_Dpi_Padre_Rep.Enabled = habilitar;

            if (!habilitar)
            {
                Chk_Certificado_Nacimiento.Checked = false;
                Chk_Ambos_Padres.Checked = false;
                Chk_Dpi_Ambos_Padres.Checked = false;
                Chk_Carta_Notariada.Checked = false;
                Chk_Autorizacion_Judicial.Checked = false;
                Chk_Dpi_Padre_Rep.Checked = false;
            }
        }

        // ==========================================
        // SUBIR FOTO
        // ==========================================
        private void Btn_Subir_Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image original = Image.FromFile(ofd.FileName);
                Bitmap bn = ConvertirBlancoNegro(new Bitmap(original));
                Ptb_Foto_Pasaporte.Image = bn;

                using (MemoryStream ms = new MemoryStream())
                {
                    bn.Save(ms, ImageFormat.Jpeg);
                    fotoBytes = ms.ToArray();
                }
            }
        }

        private Bitmap ConvertirBlancoNegro(Bitmap original)
        {
            Bitmap nueva = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int gris = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                    nueva.SetPixel(x, y, Color.FromArgb(gris, gris, gris));
                }
            }

            return nueva;
        }

        // ==========================================
        private void CargarPaises()
        {
            Cmb_Pais_Emisor.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Pais_Emisor.DataSource = controlador.ObtenerPaises();
            Cmb_Pais_Emisor.DisplayMember = "Cmp_Nombre_Pais";
            Cmb_Pais_Emisor.ValueMember = "Pk_Id_Pais_Emisor";
            Cmb_Pais_Emisor.SelectedIndex = -1;
        }

        // ==========================================
        // EMITIR PASAPORTE
        // ==========================================
        private void Btn_Emitir_Pasaporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (idCitaGlobal == 0)
                {
                    MessageBox.Show("Debe consultar una boleta válida.");
                    return;
                }

                if (fotoBytes == null)
                {
                    MessageBox.Show("Debe subir una fotografía.");
                    return;
                }

                if (Cmb_Pais_Emisor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un país emisor.");
                    return;
                }

                if (!int.TryParse(Txt_Estatura.Text, out int estatura))
                {
                    MessageBox.Show("Ingrese una estatura válida.");
                    return;
                }

                controlador.EmitirPasaporte(
                    Convert.ToInt32(Txt_Numero_Pasaporte.Text),
                    Dtp_Fecha_Emision.Value,
                    Dtp_Fecha_Expiracion.Value,
                    idCitaGlobal,
                    Convert.ToInt32(Cmb_Pais_Emisor.SelectedValue),
                    Chk_Huellas_Biometricas.Checked,
                    Chk_Firma_Digital.Checked,
                    fotoBytes,
                    estatura,
                    Chk_Menor.Checked,
                    Chk_Certificado_Nacimiento.Checked,
                    Chk_Ambos_Padres.Checked,
                    Chk_Dpi_Ambos_Padres.Checked,
                    Chk_Carta_Notariada.Checked,
                    Chk_Autorizacion_Judicial.Checked,
                    Chk_Dpi_Padre_Rep.Checked
                );

                MessageBox.Show("Pasaporte emitido correctamente.");
                Btn_Emitir_Pasaporte.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al emitir el pasaporte: " + ex.Message);
            }
        }

        // ==========================================
        // VER PASAPORTE
        // ==========================================
        private void Btn_Ver_Pasaporte_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Txt_Numero_Pasaporte.Text, out int numeroPasaporte))
            {
                MessageBox.Show("Número inválido.");
                return;
            }

            Frm_Ver_Pasaporte frm = new Frm_Ver_Pasaporte(numeroPasaporte);
            frm.ShowDialog();

            // Aquí obtenemos la imagen capturada correctamente
            pasaporteCompletoGlobal = frm.ImagenPasaporteCapturada;
        }

        // ==========================================
        // GUARDAR PASAPORTE COMPLETO
        // ==========================================
        private void Btn_Guardar_Imagen_Click(object sender, EventArgs e)
        {
            if (pasaporteCompletoGlobal == null)
            {
                MessageBox.Show("Primero debe visualizar el pasaporte.");
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Imagen PNG|*.png|Imagen JPG|*.jpg";
            guardar.FileName = "Pasaporte_Completo";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                if (guardar.FileName.ToLower().EndsWith(".jpg"))
                    pasaporteCompletoGlobal.Save(guardar.FileName, ImageFormat.Jpeg);
                else
                    pasaporteCompletoGlobal.Save(guardar.FileName, ImageFormat.Png);

                gCtrlBitacora.RegistrarAccion(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario, 1, $"Se ha impreso un pasaporte", true);
                MessageBox.Show("Pasaporte guardado correctamente.");

                
            }

         

        }
    }
}