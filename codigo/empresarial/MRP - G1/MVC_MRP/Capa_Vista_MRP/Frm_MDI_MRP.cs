// 0901-20-4620 Ruben Armando Lopez Luch
using System;
using System.Windows.Forms;
namespace Capa_Vista_MRP
{
    public partial class Frm_MDI_MRP : Form
    {
        private int childFormNumber = 0;

        public Frm_MDI_MRP()
        {
            InitializeComponent();


            this.IsMdiContainer = true; // <- activa MDI container
            this.Load += Frm_MDI_MRP_Load;
        }

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            /// ---------------------------------- AQUI SE COLOCA EL FRM DE LOGIN MRP ----------------------------------
            ///this.Hide();
            ///Frm_Login_Migracion ventanaPrincipal = new Frm_Login_Migracion();
            ///ventanaPrincipal.ShowDialog();
            ///this.Close();
        }

        private void Frm_MDI_MRP_Load(object sender, EventArgs e)
        {
            // Mostrar usuario conectado en StatusStrip si existe el control
            try
            {
                toolStripStatusLabel.Text = $"Estado: Conectado | Usuario: {Capa_Controlador_Seguridad.Cls_Usuario_Conectado.sNombreUsuario}";
            }
            catch
            {
                // Si no existe toolStripStatusLabel en este formulario, ignorar.
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cambiar_Contrasena ventana = new Frm_Cambiar_Contrasena(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario);
            ventana.Show();
        }
    }
}
