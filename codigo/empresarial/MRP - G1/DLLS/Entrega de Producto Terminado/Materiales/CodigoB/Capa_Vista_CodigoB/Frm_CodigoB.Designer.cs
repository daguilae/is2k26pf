
namespace Capa_Vista_CodigoB
{
    partial class Frm_CodigoB
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
            this.Btn_GuardarC = new System.Windows.Forms.Button();
            this.Pic_Codigo = new System.Windows.Forms.PictureBox();
            this.Btn_GenerarC = new System.Windows.Forms.Button();
            this.Cmb_Tipo = new System.Windows.Forms.ComboBox();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_VerC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_GuardarC
            // 
            this.Btn_GuardarC.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarC.Location = new System.Drawing.Point(60, 359);
            this.Btn_GuardarC.Name = "Btn_GuardarC";
            this.Btn_GuardarC.Size = new System.Drawing.Size(167, 28);
            this.Btn_GuardarC.TabIndex = 15;
            this.Btn_GuardarC.Text = "Guardar Código";
            this.Btn_GuardarC.UseVisualStyleBackColor = true;
            // 
            // Pic_Codigo
            // 
            this.Pic_Codigo.Location = new System.Drawing.Point(44, 192);
            this.Pic_Codigo.Name = "Pic_Codigo";
            this.Pic_Codigo.Size = new System.Drawing.Size(400, 150);
            this.Pic_Codigo.TabIndex = 14;
            this.Pic_Codigo.TabStop = false;
            // 
            // Btn_GenerarC
            // 
            this.Btn_GenerarC.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarC.Location = new System.Drawing.Point(157, 152);
            this.Btn_GenerarC.Name = "Btn_GenerarC";
            this.Btn_GenerarC.Size = new System.Drawing.Size(167, 28);
            this.Btn_GenerarC.TabIndex = 13;
            this.Btn_GenerarC.Text = "Generar Código";
            this.Btn_GenerarC.UseVisualStyleBackColor = true;
            // 
            // Cmb_Tipo
            // 
            this.Cmb_Tipo.FormattingEnabled = true;
            this.Cmb_Tipo.Location = new System.Drawing.Point(178, 110);
            this.Cmb_Tipo.Name = "Cmb_Tipo";
            this.Cmb_Tipo.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Tipo.TabIndex = 12;
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(178, 54);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Producto.TabIndex = 11;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(188, 88);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(99, 19);
            this.Lbl_Tipo.TabIndex = 10;
            this.Lbl_Tipo.Text = "Tipo Código";
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto.Location = new System.Drawing.Point(201, 29);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(75, 19);
            this.Lbl_Producto.TabIndex = 9;
            this.Lbl_Producto.Text = "Producto";
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = global::Capa_Vista_CodigoB.Properties.Resources.help_question_16768;
            this.Btn_Ayuda.Location = new System.Drawing.Point(461, 110);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(119, 70);
            this.Btn_Ayuda.TabIndex = 16;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_VerC
            // 
            this.Btn_VerC.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VerC.Location = new System.Drawing.Point(246, 359);
            this.Btn_VerC.Name = "Btn_VerC";
            this.Btn_VerC.Size = new System.Drawing.Size(167, 28);
            this.Btn_VerC.TabIndex = 17;
            this.Btn_VerC.Text = "Ver Código";
            this.Btn_VerC.UseVisualStyleBackColor = true;
            this.Btn_VerC.Click += new System.EventHandler(this.Btn_VerC_Click);
            // 
            // Frm_CodigoB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 447);
            this.Controls.Add(this.Btn_VerC);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_GuardarC);
            this.Controls.Add(this.Pic_Codigo);
            this.Controls.Add(this.Btn_GenerarC);
            this.Controls.Add(this.Cmb_Tipo);
            this.Controls.Add(this.Cmb_Producto);
            this.Controls.Add(this.Lbl_Tipo);
            this.Controls.Add(this.Lbl_Producto);
            this.Name = "Frm_CodigoB";
            this.Text = "Código de Barras";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Codigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_GuardarC;
        private System.Windows.Forms.PictureBox Pic_Codigo;
        private System.Windows.Forms.Button Btn_GenerarC;
        private System.Windows.Forms.ComboBox Cmb_Tipo;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_VerC;
    }
}