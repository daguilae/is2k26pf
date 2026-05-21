
namespace Capa_Vista_Ventas
{
    partial class Frm_CXC_Detalle_NAV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CXC_Detalle_NAV));
            this.navegadorTrs1 = new Capa_Vista_Navegador.NavegadorTrs();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegadorTrs1
            // 
            this.navegadorTrs1.IPkId_Aplicacion = 0;
            this.navegadorTrs1.IPkId_Modulo = 0;
            this.navegadorTrs1.Location = new System.Drawing.Point(1, 83);
            this.navegadorTrs1.Margin = new System.Windows.Forms.Padding(4);
            this.navegadorTrs1.Name = "navegadorTrs1";
            this.navegadorTrs1.SAlias = null;
            this.navegadorTrs1.SConfiguracionFK = null;
            this.navegadorTrs1.SEtiquetas = null;
            this.navegadorTrs1.Size = new System.Drawing.Size(1568, 671);
            this.navegadorTrs1.SNombreTabla = null;
            this.navegadorTrs1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 93);
            this.panel1.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "732-  Detalle Cuenta Por cobrar";
            // 
            // Frm_CXC_Detalle_NAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navegadorTrs1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CXC_Detalle_NAV";
            this.Text = "Cuentas Por cobrar Detalles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.NavegadorTrs navegadorTrs1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}