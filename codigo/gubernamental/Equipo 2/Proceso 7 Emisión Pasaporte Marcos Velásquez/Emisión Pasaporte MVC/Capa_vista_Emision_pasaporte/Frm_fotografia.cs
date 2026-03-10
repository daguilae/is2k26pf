using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Capa_vista_Emision_pasaporte
{
    public partial class Frm_fotografia : Form


    {
        private bool capturada = false;
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camara;

        public Action<Image> OnFotoCapturada;
        public Frm_fotografia()
        {
            InitializeComponent();
            this.Load += Frm_fotografia_Load;
            this.FormClosing += Frm_fotografia_FormClosing;







        }


        private void Frm_fotografia_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            MessageBox.Show("Cámaras detectadas: " + dispositivos.Count);

            if (dispositivos.Count > 0)
            {
                camara = new VideoCaptureDevice(dispositivos[1].MonikerString);
                camara.NewFrame += Camara_NewFrame;
                camara.Start();
            }
            else
            {
                MessageBox.Show("No se encontró ninguna cámara");
            }
        }


        private void Camara_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (capturada) return; 

            Bitmap nuevaImagen = (Bitmap)eventArgs.Frame.Clone();

            Ptb_camara.Invoke(new Action(() =>
            {
                if (Ptb_camara.Image != null)
                {
                    Ptb_camara.Image.Dispose();
                }

                Ptb_camara.Image = nuevaImagen;
            }));
        }


        private void Frm_fotografia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara.WaitForStop();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_capturar_Click(object sender, EventArgs e)
        {


            if (Ptb_camara.Image != null)
            {
                capturada = true; 

                Bitmap fotoCapturada = (Bitmap)Ptb_camara.Image.Clone();

                // Reemplazar por la imagen capturada
                Ptb_camara.Image.Dispose();
                Ptb_camara.Image = fotoCapturada;

                // Detener cámara (opcional pero recomendado)
                if (camara != null && camara.IsRunning)
                {
                    camara.SignalToStop();
                    camara.WaitForStop();
                }
            }
            else
            {
                MessageBox.Show("No hay imagen para capturar");
            }


        }

        private void Ptb_camara_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Ptb_camara.Image != null)
            {
                OnFotoCapturada?.Invoke((Image)Ptb_camara.Image.Clone());
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe capturar una foto primero");
            }
        }

        private void Btn_volvertoma_Click(object sender, EventArgs e)
        {


            
            capturada = false;

            
            if (Ptb_camara.Image != null)
            {
                Ptb_camara.Image.Dispose();
                Ptb_camara.Image = null;
            }

           
            if (camara != null)
            {
                try
                {
                    if (camara.IsRunning)
                    {
                        camara.SignalToStop();
                        camara.WaitForStop();
                    }

                    camara.NewFrame -= Camara_NewFrame;
                    camara = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al reiniciar cámara: " + ex.Message);
                }
            }

           
            System.Threading.Thread.Sleep(300);

           
            if (dispositivos.Count > 0)
            {
                camara = new VideoCaptureDevice(dispositivos[1].MonikerString);
                camara.NewFrame += Camara_NewFrame;

                try
                {
                    camara.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar cámara: " + ex.Message);
                }
            }





        }

        private void Btn_Aceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void Frm_fotografia_Load_1(object sender, EventArgs e)
        {

        }
    }
}
