
namespace Capa_Vista_Migracion
{
    partial class Frm_MDI_Migracion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarBoletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antecedentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosDeCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paísEmisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisionPasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.simulacionesToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.emitirPasaporteToolStripMenuItem,
            this.toolsMenu,
            this.seguridadToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1701, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Rockwell", 10F);
            this.fileMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(85, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // simulacionesToolStripMenuItem
            // 
            this.simulacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renapToolStripMenuItem,
            this.generarBoletaToolStripMenuItem,
            this.agendarCitaToolStripMenuItem,
            this.antecedentesToolStripMenuItem});
            this.simulacionesToolStripMenuItem.Name = "simulacionesToolStripMenuItem";
            this.simulacionesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.simulacionesToolStripMenuItem.Text = "Simulaciones";
            // 
            // renapToolStripMenuItem
            // 
            this.renapToolStripMenuItem.Name = "renapToolStripMenuItem";
            this.renapToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.renapToolStripMenuItem.Text = "Renap";
            this.renapToolStripMenuItem.Click += new System.EventHandler(this.renapToolStripMenuItem_Click);
            // 
            // generarBoletaToolStripMenuItem
            // 
            this.generarBoletaToolStripMenuItem.Name = "generarBoletaToolStripMenuItem";
            this.generarBoletaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.generarBoletaToolStripMenuItem.Text = "Generar Boleta";
            this.generarBoletaToolStripMenuItem.Click += new System.EventHandler(this.generarBoletaToolStripMenuItem_Click);
            // 
            // agendarCitaToolStripMenuItem
            // 
            this.agendarCitaToolStripMenuItem.Name = "agendarCitaToolStripMenuItem";
            this.agendarCitaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.agendarCitaToolStripMenuItem.Text = "Agendar Cita";
            this.agendarCitaToolStripMenuItem.Click += new System.EventHandler(this.agendarCitaToolStripMenuItem_Click);
            // 
            // antecedentesToolStripMenuItem
            // 
            this.antecedentesToolStripMenuItem.Name = "antecedentesToolStripMenuItem";
            this.antecedentesToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.antecedentesToolStripMenuItem.Text = "Antecedentes";
            this.antecedentesToolStripMenuItem.Click += new System.EventHandler(this.antecedentesToolStripMenuItem_Click);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoPasaporteToolStripMenuItem,
            this.horariosDeCitaToolStripMenuItem,
            this.sedesToolStripMenuItem,
            this.estadoCitaToolStripMenuItem,
            this.paísEmisorToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.mantenimientosToolStripMenuItem.Text = "Catálogos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // tipoPasaporteToolStripMenuItem
            // 
            this.tipoPasaporteToolStripMenuItem.Name = "tipoPasaporteToolStripMenuItem";
            this.tipoPasaporteToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.tipoPasaporteToolStripMenuItem.Text = "Tipo Pasaporte";
            this.tipoPasaporteToolStripMenuItem.Click += new System.EventHandler(this.tipoPasaporteToolStripMenuItem_Click);
            // 
            // horariosDeCitaToolStripMenuItem
            // 
            this.horariosDeCitaToolStripMenuItem.Name = "horariosDeCitaToolStripMenuItem";
            this.horariosDeCitaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.horariosDeCitaToolStripMenuItem.Text = "Horarios de Cita";
            this.horariosDeCitaToolStripMenuItem.Click += new System.EventHandler(this.horariosDeCitaToolStripMenuItem_Click);
            // 
            // sedesToolStripMenuItem
            // 
            this.sedesToolStripMenuItem.Name = "sedesToolStripMenuItem";
            this.sedesToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.sedesToolStripMenuItem.Text = "Sedes";
            this.sedesToolStripMenuItem.Click += new System.EventHandler(this.sedesToolStripMenuItem_Click);
            // 
            // estadoCitaToolStripMenuItem
            // 
            this.estadoCitaToolStripMenuItem.Name = "estadoCitaToolStripMenuItem";
            this.estadoCitaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.estadoCitaToolStripMenuItem.Text = "Estado Cita";
            this.estadoCitaToolStripMenuItem.Click += new System.EventHandler(this.estadoCitaToolStripMenuItem_Click);
            // 
            // paísEmisorToolStripMenuItem
            // 
            this.paísEmisorToolStripMenuItem.Name = "paísEmisorToolStripMenuItem";
            this.paísEmisorToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.paísEmisorToolStripMenuItem.Text = "País Emisor";
            this.paísEmisorToolStripMenuItem.Click += new System.EventHandler(this.paísEmisorToolStripMenuItem_Click);
            // 
            // emitirPasaporteToolStripMenuItem
            // 
            this.emitirPasaporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaciónCitaToolStripMenuItem,
            this.emisionPasaporteToolStripMenuItem});
            this.emitirPasaporteToolStripMenuItem.Name = "emitirPasaporteToolStripMenuItem";
            this.emitirPasaporteToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.emitirPasaporteToolStripMenuItem.Text = "Emitir Pasaporte";
            // 
            // asignaciónCitaToolStripMenuItem
            // 
            this.asignaciónCitaToolStripMenuItem.Name = "asignaciónCitaToolStripMenuItem";
            this.asignaciónCitaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.asignaciónCitaToolStripMenuItem.Text = "Asignación Cita";
            this.asignaciónCitaToolStripMenuItem.Click += new System.EventHandler(this.asignaciónCitaToolStripMenuItem_Click);
            // 
            // emisionPasaporteToolStripMenuItem
            // 
            this.emisionPasaporteToolStripMenuItem.Name = "emisionPasaporteToolStripMenuItem";
            this.emisionPasaporteToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.emisionPasaporteToolStripMenuItem.Text = "Emisión Pasaporte";
            this.emisionPasaporteToolStripMenuItem.Click += new System.EventHandler(this.emisionPasaporteToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Rockwell", 10F);
            this.toolsMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(130, 24);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 10F);
            this.seguridadToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.seguridadToolStripMenuItem.Text = "Bitacora";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.Btn_Bitacora);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8});
            this.helpMenu.Font = new System.Drawing.Font("Rockwell", 10F);
            this.helpMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(74, 24);
            this.helpMenu.Text = "Ay&uda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(71, 6);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 647);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1701, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Frm_MDI_Migracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 673);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MDI_Migracion";
            this.Text = "mdi";
            this.Load += new System.EventHandler(this.Frm_MDI_Migracion_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarBoletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antecedentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosDeCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paísEmisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emisionPasaporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
    }
}



