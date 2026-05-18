// 0901-20-4620 Ruben Armando Lopez Luch
using System;
using System.Windows.Forms;
using Capa_Vista_Mant_DiegoM;
using Capa_Vista_Mant_Kevin;
using Capa_Vista_Mantenimiento;
using Capa_Vista_Bom;
using Capa_Vista_Costo_Fase;
using Capa_vista;
using Capa_Vista_Estado_Fases;
using Capa_Vista_Mantenimiento_Gerber;
using Capa_Vista_Mant_Merma;
using Capa_Vista_Mant_UDM;
using Capa_Vista_TipoInve;
using Capa_Vista_Tipo_Costo;
using Capa_Vista_Tipo_de_Movimiento_Inventario;
using Capa_Vista_Estado_Orden_Recibida;
using Capa_vista_produccion;
// Enrega de producto terminado
using Capa_Vista_Materiales;
using Capa_Vista_InventarioPT;
using Capa_Vista_Movimiento_Inventario;
using Capa_Vista_RO;
using Capa_Vista_CVRecetas;
using Capa_Vista_Expl_Mat;
using Capa_Vista_recepcion;
using Capa_Vista_Plan;
using Capa_Vista_Fases;
using Capa_Vista_Cronograma;
using Capa_vista_Orden;
using Capa_Vista_DispoInve;
using Capa_Vista_Prod;
using Capa_Vista_Orden_Material;
using Capa_Vista_Factura;

namespace Capa_Vista_MRP
{
    public partial class Frm_MDI_MRP : Form
    {
        private int childFormNumber = 0;


        public Frm_MDI_MRP()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


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
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.Show();
        }

        private void tipoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Tipo_Material m = new Frm_Mantenimiento_Tipo_Material();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void categoríaDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Categoria_Material m = new Frm_Categoria_Material();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void unidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_UDM m = new Frm_UDM();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Almacen m = new Frm_Mantenimiento_Almacen();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Mant_Kevin.Frm_Materiales m = new Capa_Vista_Mant_Kevin.Frm_Materiales();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void tipoDeMermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Merma m = new Frm_Tipo_Merma();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void estadoDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_produccion m = new Frm_produccion();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void tipoDeMovimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_de_movimineto_inventario m = new Frm_Tipo_de_movimineto_inventario();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void estadoBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bom m = new Frm_Bom();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void estadoPlanDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estado_Plan_Produccion m = new Frm_Estado_Plan_Produccion();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void estadoOrdenDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Estado_OP m = new Frm_Mantenimiento_Estado_OP();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void estadoOrdenRecibidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estado_Orden_Recibida m = new Frm_Estado_Orden_Recibida();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void estadoRecepciónMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_estado_recepcion_material m = new Frm_estado_recepcion_material();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void tipoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TipoInve m = new Frm_TipoInve();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void ordenProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Capa_Vista_Orden_Produccion.Frm_Orden_Produccion orden = new Capa_Vista_Orden_Produccion.Frm_Orden_Produccion();
            //orden.Show();
        }

        private void materialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Capa_Vista_Materiales.Frm_Materiales m = new Capa_Vista_Materiales.Frm_Materiales();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario_EntregaPT m = new Frm_Inventario_EntregaPT();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void movimientoInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Movimiento_Inventario m = new Frm_Movimiento_Inventario();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void recibirOrdenDeLogísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Orden m = new Frm_Encabezado_Orden();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void bOMYFactibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_BOM m = new Frm_Encabezado_BOM();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void explosiónDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Expl_Impl m = new Frm_Expl_Impl();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();

        }

        private void recepciónDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_encabezado m = new Frm_encabezado();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void planDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Plan m = new Frm_Encabezado_Plan();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void cronogramaFasesDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cronograma_Fases m = new Frm_Cronograma_Fases();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void fasesDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Fases_Produccion m = new Frm_Fases_Produccion();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void ordenDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_vista_Orden.Frm_Orden_Produccion m = new Capa_vista_Orden.Frm_Orden_Produccion();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void disponibilidadDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DispoInve m = new Frm_DispoInve();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void costosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Costo_Fases m = new Frm_Costo_Fases();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void tipoDeCostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Costo m = new Frm_Tipo_Costo();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void costosDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Produccion m = new Frm_Produccion();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void ordenDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Orden_Material m = new Frm_Encabezado_Orden_Material();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frms_Factura  m = new Frms_Factura();
            m.MdiParent = this;
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }

        private void bitacorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capa_Vista_Seguridad.Frm_Bitacora bitacora = new Capa_Vista_Seguridad.Frm_Bitacora();
            bitacora.MdiParent = this;
            bitacora.StartPosition = FormStartPosition.CenterScreen;
            bitacora.Show();

        }

        private void cambiarContraseñaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Capa_Vista_Seguridad.Frm_cambiar_contrasena contrasena = new Capa_Vista_Seguridad.Frm_cambiar_contrasena(Capa_Controlador_Seguridad.Cls_Usuario_Conectado.iIdUsuario);
            contrasena.MdiParent = this;
            contrasena.StartPosition = FormStartPosition.CenterScreen;
            contrasena.Show();
        }
    }
    
}
