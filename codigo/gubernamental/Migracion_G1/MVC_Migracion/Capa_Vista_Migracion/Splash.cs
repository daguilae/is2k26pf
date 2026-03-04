using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capa_Vista_Migracion
{
    public partial class Splash : Form
    {
        int progress = 0;

        public Splash()
        {
            InitializeComponent();
            ConfigurarDiseño();
            timer1.Start();
        }

        private void ConfigurarDiseño()
        {
            this.FormBorderStyle = FormBorderStyle.None; 
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.Opacity = 0; 

            LbTitulo.Parent = picFondo;
            LbTitulo.BackColor = Color.Transparent;

            LbSubtitulo.Parent = picFondo;
            LbSubtitulo.BackColor = Color.Transparent;

            lblPorcentaje.Parent = picFondo;
            lblPorcentaje.BackColor = Color.Transparent;

            picGif.Parent = picFondo;
            picGif.BackColor = Color.Transparent;

            lblPorcentaje.Parent = picFondo;
            lblPorcentaje.BackColor = Color.Transparent;
            lblPorcentaje.ForeColor = Color.White; 
            lblPorcentaje.Text = "0%"; 
            lblPorcentaje.BringToFront();
            lblPorcentaje.Location = new Point(10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Progreso actual: " + progress + "%"); 
            lblPorcentaje.Visible = true; 

            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }

            progress += 1;

            if (progress <= 100)
            {
                progressBar1.Value = progress;
                lblPorcentaje.Text = progress.ToString() + "%";
                this.Update(); 
            }
            else
            {
                timer1.Stop();
                this.Hide();

                Frm_Login_Migracion login = new Frm_Login_Migracion();
                login.Show();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84) m.Result = (IntPtr)0x2; 
        }

        private void picGif_Click(object sender, EventArgs e)
        {
            picGif.Parent = picFondo;
            picGif.BackColor = Color.Transparent;
        }
    }
}