
namespace Frm_facturas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_seria = new System.Windows.Forms.Label();
            this.Lbl_numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas";
            // 
            // Lbl_seria
            // 
            this.Lbl_seria.AutoSize = true;
            this.Lbl_seria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_seria.Location = new System.Drawing.Point(61, 130);
            this.Lbl_seria.Name = "Lbl_seria";
            this.Lbl_seria.Size = new System.Drawing.Size(77, 29);
            this.Lbl_seria.TabIndex = 1;
            this.Lbl_seria.Text = "Serie:";
            // 
            // Lbl_numero
            // 
            this.Lbl_numero.AutoSize = true;
            this.Lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numero.Location = new System.Drawing.Point(334, 130);
            this.Lbl_numero.Name = "Lbl_numero";
            this.Lbl_numero.Size = new System.Drawing.Size(77, 29);
            this.Lbl_numero.TabIndex = 2;
            this.Lbl_numero.Text = "Serie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.Lbl_numero);
            this.Controls.Add(this.Lbl_seria);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_seria;
        private System.Windows.Forms.Label Lbl_numero;
    }
}

