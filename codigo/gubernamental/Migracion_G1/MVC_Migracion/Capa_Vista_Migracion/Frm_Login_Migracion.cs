using System;
using System.Windows.Forms;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_Migracion
{
    public partial class Frm_Login_Migracion : Form
    {
        public Frm_Login_Migracion()
        {
            InitializeComponent();
            txtContrasena.UseSystemPasswordChar = true;
            this.FormClosing += Frm_Login_FormClosing;
        }

        // VARIABLES GLOBALES

        private Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador(); // Bitácora
        private Cls_ControladorLogin cn = new Cls_ControladorLogin();
        private Cls_Usuario_Controlador gUsuarioControlador = new Cls_Usuario_Controlador();


        // CONSTRUCTOR

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }


        // EVENTOS CHECKBOX

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }

        


        // BOTÓN INICIAR SESIÓN

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

                //Aqui va el MDI
                this.Hide();
                Frm_MDI_Migracion frmMenu = new Frm_MDI_Migracion();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }
       
        // RECUPERAR CONTRASEÑA

        private void lblkRecuperarContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Recuperar_Contrasena frmRecuperar = new Frm_Recuperar_Contrasena();
            frmRecuperar.Show();
            this.Hide();

        }

        private void chkMostrarContrasena_CheckedChanged_1(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
        }
    }
}
