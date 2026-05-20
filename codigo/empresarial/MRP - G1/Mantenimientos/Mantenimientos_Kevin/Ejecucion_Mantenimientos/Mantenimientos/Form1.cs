using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Mant_Kevin;

namespace Mantenimientos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_Materiales materiales = new Frm_Materiales();
            materiales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Categoria_Material categoria = new Frm_Categoria_Material();
            categoria.Show();
        }
    }
}
