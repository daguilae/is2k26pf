
namespace Capa_Vista_Mov_Inv
{
    partial class Frm_Inventario_Mantenimiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.navegadorTrs1 = new Capa_Vista_Navegador.NavegadorTrs();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 80);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "726-MANTENIMIENTO INVENTARIO";
            // 
            // navegadorTrs1
            // 
            this.navegadorTrs1.IPkId_Aplicacion = 0;
            this.navegadorTrs1.IPkId_Modulo = 0;
            this.navegadorTrs1.Location = new System.Drawing.Point(13, 89);
            this.navegadorTrs1.Name = "navegadorTrs1";
            this.navegadorTrs1.SAlias = null;
            this.navegadorTrs1.SConfiguracionFK = null;
            this.navegadorTrs1.SEtiquetas = null;
            this.navegadorTrs1.Size = new System.Drawing.Size(1199, 734);
            this.navegadorTrs1.SNombreTabla = null;
            this.navegadorTrs1.TabIndex = 32;
            // 
            // Frm_Inventario_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 827);
            this.Controls.Add(this.navegadorTrs1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Inventario_Mantenimiento";
            this.Text = "Mantenimiento Inventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Capa_Vista_Navegador.NavegadorTrs navegadorTrs1;
    }
}