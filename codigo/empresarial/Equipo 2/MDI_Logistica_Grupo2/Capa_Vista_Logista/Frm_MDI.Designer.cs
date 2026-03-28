
namespace Capa_Vista_Logista
{
    partial class Frm_MDI
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
            this.Pnl_Superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_Superior.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Superior
            // 
            this.Pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(142)))), ((int)(((byte)(181)))));
            this.Pnl_Superior.Controls.Add(this.label1);
            this.Pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Superior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Superior.Name = "Pnl_Superior";
            this.Pnl_Superior.Size = new System.Drawing.Size(1105, 64);
            this.Pnl_Superior.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logística";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.asignacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 66);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(0, 503);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 1069, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1652, 28);
            this.menuStrip1.TabIndex = 101;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.archivoToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Salir";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaPorCobrarToolStripMenuItem,
            this.lineaDeProductoToolStripMenuItem});
            this.catálogosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // cuentaPorCobrarToolStripMenuItem
            // 
            this.cuentaPorCobrarToolStripMenuItem.Name = "cuentaPorCobrarToolStripMenuItem";
            this.cuentaPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.cuentaPorCobrarToolStripMenuItem.Text = "Cuenta por cobrar ";
            this.cuentaPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.cuentaPorCobrarToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteadorToolStripMenuItem});
            this.herramientasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.herramientasToolStripMenuItem.Text = "Reportes";
            // 
            // reporteadorToolStripMenuItem
            // 
            this.reporteadorToolStripMenuItem.Name = "reporteadorToolStripMenuItem";
            this.reporteadorToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.reporteadorToolStripMenuItem.Text = "Reporteador";
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.asignacionesToolStripMenuItem.Text = "Ayudas";
            // 
            // lineaDeProductoToolStripMenuItem
            // 
            this.lineaDeProductoToolStripMenuItem.Name = "lineaDeProductoToolStripMenuItem";
            this.lineaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.lineaDeProductoToolStripMenuItem.Text = "Linea de Producto";
            this.lineaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.lineaDeProductoToolStripMenuItem_Click);
            // 
            // Frm_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Pnl_Superior);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_MDI";
            this.Text = "Frm_MDI";
            this.Pnl_Superior.ResumeLayout(false);
            this.Pnl_Superior.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaDeProductoToolStripMenuItem;
    }
}