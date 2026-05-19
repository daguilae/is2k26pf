using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_CodigoB;
namespace EjecutableCB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_GC_Click(object sender, EventArgs e)
        {
             Frm_CodigoB frm = new Frm_CodigoB();
            frm.ShowDialog();
        }

        private void Btn_VC_Click(object sender, EventArgs e)
        {
            Frm_Ver_CB frmv = new Frm_Ver_CB ();
            frmv.ShowDialog();
        }
    }
}
