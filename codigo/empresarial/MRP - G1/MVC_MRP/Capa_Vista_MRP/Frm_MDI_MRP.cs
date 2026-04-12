// 0901-20-4620 Ruben Armando Lopez Luch
using System;
using System.Windows.Forms;
using Capa_Vista_Mant_DiegoM;
using Capa_Vista_Mant_Kevin;
using Capa_Vista_Mantenimiento;
using Capa_Vista_Bom;
using Capa_vista;
using Capa_Vista_Estado_Fases;
using Capa_Vista_Mantenimiento_Gerber;
using Capa_Vista_Mant_Merma;
using Capa_Vista_Mant_UDM;
using Capa_Vista_TipoInve;
using Capa_Vista_Tipo_de_Movimiento_Inventario;
using Capa_Vista_Estado_Orden_Recibida;
using Capa_vista_produccion;

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

        private void tipoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Material m = new Frm_Mantenimiento_Tipo_Material();
            m.Show();
        }

        private void categoríaDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categoria_Material m = new Frm_Categoria_Material();
            m.Show();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UDM m = new Frm_UDM();
            m.Show();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Almacen m = new Frm_Mantenimiento_Almacen();
            m.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Materiales m = new Frm_Materiales();
            m.Show();
        }

        private void tipoDeMermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Merma m = new Frm_Tipo_Merma();
            m.Show();
        }

        private void estadoDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produccion m = new Frm_produccion();
            m.Show();
        }

        private void tipoDeMovimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_de_movimineto_inventario m = new Frm_Tipo_de_movimineto_inventario();
            m.Show();
        }

        private void estadoBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bom m = new Frm_Bom();
            m.Show();
        }

        private void estadoPlanDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estado_Plan_Produccion m = new Frm_Estado_Plan_Produccion();
            m.Show();
        }

        private void estadoOrdenDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Estado_OP m = new Frm_Mantenimiento_Estado_OP();
            m.Show();
        }

        private void estadoOrdenRecibidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estado_Orden_Recibida m = new Frm_Estado_Orden_Recibida();
            m.Show();
        }

        private void estadoRecepciónMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_estado_recepcion_material m = new Frm_estado_recepcion_material();
            m.Show();
        }

        private void tipoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoInve m = new Frm_TipoInve();
            m.Show();
        }

        private void ordenProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Orden_Produccion.Frm_Orden_Produccion orden = new Capa_Vista_Orden_Produccion.Frm_Orden_Produccion();
            orden.Show();
        }
    }
    
}
