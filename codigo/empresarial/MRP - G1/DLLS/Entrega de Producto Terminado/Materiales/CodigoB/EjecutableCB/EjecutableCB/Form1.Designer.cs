
namespace EjecutableCB
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
            this.Btn_VC = new System.Windows.Forms.Button();
            this.Btn_GC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_VC
            // 
            this.Btn_VC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VC.Location = new System.Drawing.Point(186, 155);
            this.Btn_VC.Name = "Btn_VC";
            this.Btn_VC.Size = new System.Drawing.Size(119, 80);
            this.Btn_VC.TabIndex = 3;
            this.Btn_VC.Text = "Ver Codigo";
            this.Btn_VC.UseVisualStyleBackColor = true;
            this.Btn_VC.Click += new System.EventHandler(this.Btn_VC_Click);
            // 
            // Btn_GC
            // 
            this.Btn_GC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GC.Location = new System.Drawing.Point(45, 155);
            this.Btn_GC.Name = "Btn_GC";
            this.Btn_GC.Size = new System.Drawing.Size(119, 80);
            this.Btn_GC.TabIndex = 2;
            this.Btn_GC.Text = "Generar Codigo";
            this.Btn_GC.UseVisualStyleBackColor = true;
            this.Btn_GC.Click += new System.EventHandler(this.Btn_GC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo de barras";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_VC);
            this.Controls.Add(this.Btn_GC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_VC;
        private System.Windows.Forms.Button Btn_GC;
        private System.Windows.Forms.Label label1;
    }
}

