
namespace Capa_Vista_MRP
{
    partial class Frm_MDI_MRP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosPrincipalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríaDeMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMermaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosSecundariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeMovimientoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoBOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoPlanDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoOrdenDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoOrdenRecibidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoRecepciónMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosMRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ordenProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosPrincipalesToolStripMenuItem,
            this.catálogosSecundariosToolStripMenuItem,
            this.procesosMRPToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1631, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // catálogosPrincipalesToolStripMenuItem
            // 
            this.catálogosPrincipalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeMaterialToolStripMenuItem,
            this.categoríaDeMaterialToolStripMenuItem,
            this.unidadDeMedidaToolStripMenuItem,
            this.almacenesToolStripMenuItem,
            this.materialesToolStripMenuItem,
            this.tipoDeMermaToolStripMenuItem});
            this.catálogosPrincipalesToolStripMenuItem.Name = "catálogosPrincipalesToolStripMenuItem";
            this.catálogosPrincipalesToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.catálogosPrincipalesToolStripMenuItem.Text = "Catálogos Principales";
            // 
            // tipoDeMaterialToolStripMenuItem
            // 
            this.tipoDeMaterialToolStripMenuItem.Name = "tipoDeMaterialToolStripMenuItem";
            this.tipoDeMaterialToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tipoDeMaterialToolStripMenuItem.Text = "Tipo de Material";
            this.tipoDeMaterialToolStripMenuItem.Click += new System.EventHandler(this.tipoDeMaterialToolStripMenuItem_Click);
            // 
            // categoríaDeMaterialToolStripMenuItem
            // 
            this.categoríaDeMaterialToolStripMenuItem.Name = "categoríaDeMaterialToolStripMenuItem";
            this.categoríaDeMaterialToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.categoríaDeMaterialToolStripMenuItem.Text = "Categoría de Material";
            this.categoríaDeMaterialToolStripMenuItem.Click += new System.EventHandler(this.categoríaDeMaterialToolStripMenuItem_Click);
            // 
            // unidadDeMedidaToolStripMenuItem
            // 
            this.unidadDeMedidaToolStripMenuItem.Name = "unidadDeMedidaToolStripMenuItem";
            this.unidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.unidadDeMedidaToolStripMenuItem.Text = "Unidad de Medida";
            this.unidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadDeMedidaToolStripMenuItem_Click);
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.almacenesToolStripMenuItem.Text = "Almacenes";
            this.almacenesToolStripMenuItem.Click += new System.EventHandler(this.almacenesToolStripMenuItem_Click);
            // 
            // materialesToolStripMenuItem
            // 
            this.materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            this.materialesToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.materialesToolStripMenuItem.Text = "Materiales";
            this.materialesToolStripMenuItem.Click += new System.EventHandler(this.materialesToolStripMenuItem_Click);
            // 
            // tipoDeMermaToolStripMenuItem
            // 
            this.tipoDeMermaToolStripMenuItem.Name = "tipoDeMermaToolStripMenuItem";
            this.tipoDeMermaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.tipoDeMermaToolStripMenuItem.Text = "Tipo de Merma";
            this.tipoDeMermaToolStripMenuItem.Click += new System.EventHandler(this.tipoDeMermaToolStripMenuItem_Click);
            // 
            // catálogosSecundariosToolStripMenuItem
            // 
            this.catálogosSecundariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDeProducciónToolStripMenuItem,
            this.tipoDeMovimientoDeInventarioToolStripMenuItem,
            this.estadoBOMToolStripMenuItem,
            this.estadoPlanDeProducciónToolStripMenuItem,
            this.estadoOrdenDeProducciónToolStripMenuItem,
            this.estadoOrdenRecibidaToolStripMenuItem,
            this.estadoRecepciónMaterialToolStripMenuItem,
            this.tipoDeInventarioToolStripMenuItem});
            this.catálogosSecundariosToolStripMenuItem.Name = "catálogosSecundariosToolStripMenuItem";
            this.catálogosSecundariosToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.catálogosSecundariosToolStripMenuItem.Text = "Catálogos Secundarios";
            // 
            // estadoDeProducciónToolStripMenuItem
            // 
            this.estadoDeProducciónToolStripMenuItem.Name = "estadoDeProducciónToolStripMenuItem";
            this.estadoDeProducciónToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.estadoDeProducciónToolStripMenuItem.Text = "Estado de Producción";
            this.estadoDeProducciónToolStripMenuItem.Click += new System.EventHandler(this.estadoDeProducciónToolStripMenuItem_Click);
            // 
            // tipoDeMovimientoDeInventarioToolStripMenuItem
            // 
            this.tipoDeMovimientoDeInventarioToolStripMenuItem.Name = "tipoDeMovimientoDeInventarioToolStripMenuItem";
            this.tipoDeMovimientoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.tipoDeMovimientoDeInventarioToolStripMenuItem.Text = "Tipo de Movimiento de Inventario";
            this.tipoDeMovimientoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeMovimientoDeInventarioToolStripMenuItem_Click);
            // 
            // estadoBOMToolStripMenuItem
            // 
            this.estadoBOMToolStripMenuItem.Name = "estadoBOMToolStripMenuItem";
            this.estadoBOMToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.estadoBOMToolStripMenuItem.Text = "Estado BOM";
            this.estadoBOMToolStripMenuItem.Click += new System.EventHandler(this.estadoBOMToolStripMenuItem_Click);
            // 
            // estadoPlanDeProducciónToolStripMenuItem
            // 
            this.estadoPlanDeProducciónToolStripMenuItem.Name = "estadoPlanDeProducciónToolStripMenuItem";
            this.estadoPlanDeProducciónToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.estadoPlanDeProducciónToolStripMenuItem.Text = "Estado Plan de Producción";
            this.estadoPlanDeProducciónToolStripMenuItem.Click += new System.EventHandler(this.estadoPlanDeProducciónToolStripMenuItem_Click);
            // 
            // estadoOrdenDeProducciónToolStripMenuItem
            // 
            this.estadoOrdenDeProducciónToolStripMenuItem.Name = "estadoOrdenDeProducciónToolStripMenuItem";
            this.estadoOrdenDeProducciónToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.estadoOrdenDeProducciónToolStripMenuItem.Text = "Estado Orden de Producción";
            this.estadoOrdenDeProducciónToolStripMenuItem.Click += new System.EventHandler(this.estadoOrdenDeProducciónToolStripMenuItem_Click);
            // 
            // estadoOrdenRecibidaToolStripMenuItem
            // 
            this.estadoOrdenRecibidaToolStripMenuItem.Name = "estadoOrdenRecibidaToolStripMenuItem";
            this.estadoOrdenRecibidaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.estadoOrdenRecibidaToolStripMenuItem.Text = "Estado Orden Recibida";
            this.estadoOrdenRecibidaToolStripMenuItem.Click += new System.EventHandler(this.estadoOrdenRecibidaToolStripMenuItem_Click);
            // 
            // estadoRecepciónMaterialToolStripMenuItem
            // 
            this.estadoRecepciónMaterialToolStripMenuItem.Name = "estadoRecepciónMaterialToolStripMenuItem";
            this.estadoRecepciónMaterialToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.estadoRecepciónMaterialToolStripMenuItem.Text = "Estado Recepción Material";
            this.estadoRecepciónMaterialToolStripMenuItem.Click += new System.EventHandler(this.estadoRecepciónMaterialToolStripMenuItem_Click);
            // 
            // tipoDeInventarioToolStripMenuItem
            // 
            this.tipoDeInventarioToolStripMenuItem.Name = "tipoDeInventarioToolStripMenuItem";
            this.tipoDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.tipoDeInventarioToolStripMenuItem.Text = "Tipo de Inventario";
            this.tipoDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeInventarioToolStripMenuItem_Click);
            // 
            // procesosMRPToolStripMenuItem
            // 
            this.procesosMRPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenProduccionToolStripMenuItem});
            this.procesosMRPToolStripMenuItem.Name = "procesosMRPToolStripMenuItem";
            this.procesosMRPToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.procesosMRPToolStripMenuItem.Text = "Procesos MRP";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 711);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1631, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // ordenProduccionToolStripMenuItem
            // 
            this.ordenProduccionToolStripMenuItem.Name = "ordenProduccionToolStripMenuItem";
            this.ordenProduccionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenProduccionToolStripMenuItem.Text = "Orden Produccion";
            this.ordenProduccionToolStripMenuItem.Click += new System.EventHandler(this.ordenProduccionToolStripMenuItem_Click);
            // 
            // Frm_MDI_MRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 737);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_MDI_MRP";
            this.Text = "Sistema MRP";
            this.Load += new System.EventHandler(this.Frm_MDI_MRP_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosPrincipalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríaDeMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMermaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosSecundariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMovimientoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoBOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoPlanDeProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoOrdenDeProducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoOrdenRecibidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoRecepciónMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosMRPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenProduccionToolStripMenuItem;
    }
}



