
namespace Capa_Vista_LineaProd
{
    partial class Frm_Mantenimiento_LineaProducto
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
            this.navegador1 = new Capa_Vista_Navegador.Navegador();
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.IPkId_Aplicacion = 0;
            this.navegador1.IPkId_Modulo = 0;
            this.navegador1.Location = new System.Drawing.Point(4, 71);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.SAlias = null;
            this.navegador1.SEtiquetas = null;
            this.navegador1.Size = new System.Drawing.Size(1534, 622);
            this.navegador1.SNombreTabla = null;
            this.navegador1.TabIndex = 0;
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_Titulo.Controls.Add(this.label1);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1551, 64);
            this.Pnl_Titulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO LINEA DE PRODUCTO";
            // 
            // Frm_Mantenimiento_LineaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 697);
            this.Controls.Add(this.Pnl_Titulo);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_Mantenimiento_LineaProducto";
            this.Text = "Frm_Mantenimiento_LineaProducto";
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Label label1;
    }
}