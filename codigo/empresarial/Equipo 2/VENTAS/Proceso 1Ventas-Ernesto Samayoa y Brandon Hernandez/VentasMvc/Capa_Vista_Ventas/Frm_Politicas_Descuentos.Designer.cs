
namespace Capa_Vista_Ventas
{
    partial class Frm_Politicas_Descuentos
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
            this.navegadorTrs1 = new Capa_Vista_Navegador.NavegadorTrs();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegadorTrs1
            // 
            this.navegadorTrs1.IPkId_Aplicacion = 0;
            this.navegadorTrs1.IPkId_Modulo = 0;
            this.navegadorTrs1.Location = new System.Drawing.Point(13, 85);
            this.navegadorTrs1.Margin = new System.Windows.Forms.Padding(4);
            this.navegadorTrs1.Name = "navegadorTrs1";
            this.navegadorTrs1.SAlias = null;
            this.navegadorTrs1.SConfiguracionFK = null;
            this.navegadorTrs1.SEtiquetas = null;
            this.navegadorTrs1.Size = new System.Drawing.Size(1500, 609);
            this.navegadorTrs1.SNombreTabla = null;
            this.navegadorTrs1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 64);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "731 - POLITICAS DE DESCUENTOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Ventas.Properties.Resources.mbrisale_99573;
            this.pictureBox1.Location = new System.Drawing.Point(555, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Politicas_Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navegadorTrs1);
            this.Name = "Frm_Politicas_Descuentos";
            this.Text = "Politicas_Descuentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.NavegadorTrs navegadorTrs1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}