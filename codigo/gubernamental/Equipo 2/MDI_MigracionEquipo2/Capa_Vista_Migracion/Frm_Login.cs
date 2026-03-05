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

namespace Capa_Vista_Migracion
{
    public partial class Frm_Login : Form
    {
        private Cls_BitacoraControlador ctrlBitacora = new Cls_BitacoraControlador(); // Bitácora
        private Cls_ControladorLogin cn = new Cls_ControladorLogin();
        private Cls_Usuario_Controlador gUsuarioControlador = new Cls_Usuario_Controlador();
        public Frm_Login()
        {
            InitializeComponent();
            Txt_Contraseña.UseSystemPasswordChar = true;
            this.FormClosing += Frm_Login_FormClosing;
            this.AcceptButton = Btn_InicarSesion; // ENTER = Iniciar sesión
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Btn_InicarSesion_Click(object sender, EventArgs e)
        {
            string sUsuario = Txt_Usuario.Text.Trim();
            string sContrasena = Txt_Contraseña.Text.Trim();
            string sMensaje;
            string sNombreUsuarioReal = "";
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
                Frm_Mdi MDI = new Frm_Mdi();
                MDI.ShowDialog();
                this.Close();
            }
            else
            {
                Txt_Contraseña.Clear();
                Txt_Contraseña.Focus();
            }
        }

        private void Chk_MostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
           Txt_Contraseña.UseSystemPasswordChar = !Chk_MostrarContrasena.Checked;
        }
    }
    }
