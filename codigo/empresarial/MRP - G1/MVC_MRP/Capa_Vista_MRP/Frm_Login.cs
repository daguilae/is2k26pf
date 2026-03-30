// Arón Ricardo Esquit 0901-22-13036

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_MRP
{
    public partial class Frm_Login : Form
    {
        private Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador(); // Bitácora
        private Cls_ControladorLogin cn = new Cls_ControladorLogin();
        private Cls_Usuario_Controlador gUsuarioControlador = new Cls_Usuario_Controlador();
        public Frm_Login()
        {
            InitializeComponent();
            txtContrasena.UseSystemPasswordChar = true;
            this.FormClosing += Frm_Login_FormClosing;
            this.AcceptButton = btnIniciarSesion; // ENTER = Iniciar sesión
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string sUsuario = txtUsuario.Text.Trim();
            string sContrasena = txtContrasena.Text.Trim();
            string sNombreUsuarioReal = "";

            string sMensaje;
            bool bLoginExitoso = cn.bAutenticarUsuario(sUsuario, sContrasena, out sMensaje, out int iIdUsuario, out sNombreUsuarioReal);

            MessageBox.Show(sMensaje);

            if (bLoginExitoso)
            {
                int iIdPerfil = gUsuarioControlador.ObtenerIdPerfilDeUsuario(iIdUsuario);

                // Guardar sesión
                Cls_Usuario_Conectado.IniciarSesion(iIdUsuario, sNombreUsuarioReal, iIdPerfil);


                // Registrar inicio en bitácora
                ctrlBitacora.RegistrarInicioSesion(iIdUsuario);

                // Abrir Frm_Principal
                this.Hide();
                Frm_MDI_MRP frmMenu = new Frm_MDI_MRP();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

        private void lblkRecuperarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Recuperar_Contrasena frmRecuperar = new Frm_Recuperar_Contrasena();
            frmRecuperar.Show();
            this.Hide();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }
    }
}
