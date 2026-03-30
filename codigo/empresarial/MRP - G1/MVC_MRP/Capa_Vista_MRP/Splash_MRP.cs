using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_MRP
{
    public partial class Splash_MRP : Form
    {
        int progress = 0;

        public Splash_MRP()
        {
            InitializeComponent();
            ConfigurarDiseño();
            timer1.Start();
        }


        private void ConfigurarDiseño()
        {
            LbTitulo.BackColor = Color.Transparent;
            LbSubtitulo.BackColor = Color.Transparent;

            LbTitulo.BackColor = Color.Transparent;
            LbSubtitulo.BackColor = Color.Transparent;

            LbTitulo.Parent = this;
            LbSubtitulo.Parent = this;
        }

        private void Splash_MRP_Load(object sender, EventArgs e)
        {

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

                Frm_Login login = new Frm_Login();
                login.Show();
            }
        }


    }
}
