using Capa_vista_Emision_pasaporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_emision_pasaporte
{
    public partial class Frm_emision_pasaporte : Form
    {
        public Frm_emision_pasaporte()
        {
            InitializeComponent();


            Cmb_sexo.Items.Clear();
            Cmb_sexo.Items.Add("M");
            Cmb_sexo.Items.Add("F");
            Cmb_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

            // PAIS
            Cmb_pais_emisor.Items.Clear();
            Cmb_pais_emisor.Items.Add("GTM");
            Cmb_pais_emisor.DropDownStyle = ComboBoxStyle.DropDownList;

            // AUTORIDAD
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_fotografia frm = new Frm_fotografia();
            frm.Show();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btn_cerrarr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
