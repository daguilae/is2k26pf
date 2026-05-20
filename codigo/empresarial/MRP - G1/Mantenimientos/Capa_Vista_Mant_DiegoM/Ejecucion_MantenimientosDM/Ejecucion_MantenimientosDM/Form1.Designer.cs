
namespace Ejecucion_MantenimientosDM
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
            this.Btn_Tipo_Material = new System.Windows.Forms.Button();
            this.Btn_Almacenes = new System.Windows.Forms.Button();
            this.Lbl_Mantenimientos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Tipo_Material
            // 
            this.Btn_Tipo_Material.Location = new System.Drawing.Point(203, 164);
            this.Btn_Tipo_Material.Name = "Btn_Tipo_Material";
            this.Btn_Tipo_Material.Size = new System.Drawing.Size(145, 146);
            this.Btn_Tipo_Material.TabIndex = 0;
            this.Btn_Tipo_Material.Text = "Tipo_Material";
            this.Btn_Tipo_Material.UseVisualStyleBackColor = true;
            this.Btn_Tipo_Material.Click += new System.EventHandler(this.Btn_Tipo_Material_Click);
            // 
            // Btn_Almacenes
            // 
            this.Btn_Almacenes.Location = new System.Drawing.Point(417, 164);
            this.Btn_Almacenes.Name = "Btn_Almacenes";
            this.Btn_Almacenes.Size = new System.Drawing.Size(145, 146);
            this.Btn_Almacenes.TabIndex = 1;
            this.Btn_Almacenes.Text = "Almacenes";
            this.Btn_Almacenes.UseVisualStyleBackColor = true;
            this.Btn_Almacenes.Click += new System.EventHandler(this.Btn_Almacenes_Click);
            // 
            // Lbl_Mantenimientos
            // 
            this.Lbl_Mantenimientos.AutoSize = true;
            this.Lbl_Mantenimientos.Location = new System.Drawing.Point(297, 83);
            this.Lbl_Mantenimientos.Name = "Lbl_Mantenimientos";
            this.Lbl_Mantenimientos.Size = new System.Drawing.Size(81, 13);
            this.Lbl_Mantenimientos.TabIndex = 2;
            this.Lbl_Mantenimientos.Text = "Mantenimientos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Mantenimientos);
            this.Controls.Add(this.Btn_Almacenes);
            this.Controls.Add(this.Btn_Tipo_Material);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Btn_Tipo_Material;
        private System.Windows.Forms.Button Btn_Almacenes;
        private System.Windows.Forms.Label Lbl_Mantenimientos;
    }
}

