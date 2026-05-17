namespace Capa_Vista_CXP
{
    partial class Frm_Seleccion_Reporte_CXP
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
            this.Btn_reporte_simple = new System.Windows.Forms.Button();
            this.Btn_reporte_antiguedad = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_reporte_simple
            // 
            this.Btn_reporte_simple.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_reporte_simple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte_simple.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_reporte_simple.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_reporte_simple.Location = new System.Drawing.Point(35, 57);
            this.Btn_reporte_simple.Name = "Btn_reporte_simple";
            this.Btn_reporte_simple.Size = new System.Drawing.Size(86, 87);
            this.Btn_reporte_simple.TabIndex = 53;
            this.Btn_reporte_simple.Text = "Reporte Simple";
            this.Btn_reporte_simple.UseVisualStyleBackColor = false;
            // 
            // Btn_reporte_antiguedad
            // 
            this.Btn_reporte_antiguedad.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_reporte_antiguedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte_antiguedad.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_reporte_antiguedad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_reporte_antiguedad.Location = new System.Drawing.Point(127, 57);
            this.Btn_reporte_antiguedad.Name = "Btn_reporte_antiguedad";
            this.Btn_reporte_antiguedad.Size = new System.Drawing.Size(86, 87);
            this.Btn_reporte_antiguedad.TabIndex = 54;
            this.Btn_reporte_antiguedad.Text = "Antigüedad de Saldos";
            this.Btn_reporte_antiguedad.UseVisualStyleBackColor = false;
            // 
            // Btn_salir
            // 
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_salir.Image = global::Capa_Vista_Compras.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_salir.Location = new System.Drawing.Point(219, 57);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(86, 87);
            this.Btn_salir.TabIndex = 66;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Frm_Seleccion_Reporte_CXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 206);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte_antiguedad);
            this.Controls.Add(this.Btn_reporte_simple);
            this.Name = "Frm_Seleccion_Reporte_CXP";
            this.Text = "Seleccion de reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_reporte_simple;
        private System.Windows.Forms.Button Btn_reporte_antiguedad;
        private System.Windows.Forms.Button Btn_salir;
    }
}