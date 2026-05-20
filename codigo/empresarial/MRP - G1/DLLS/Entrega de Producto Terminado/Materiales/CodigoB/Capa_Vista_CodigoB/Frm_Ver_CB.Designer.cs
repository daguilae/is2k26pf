
namespace Capa_Vista_CodigoB
{
    partial class Frm_Ver_CB
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.Pic_Codigo = new System.Windows.Forms.PictureBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Codigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Producto";
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(77, 63);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(183, 21);
            this.Cmb_Producto.TabIndex = 6;
            // 
            // Pic_Codigo
            // 
            this.Pic_Codigo.Location = new System.Drawing.Point(86, 90);
            this.Pic_Codigo.Name = "Pic_Codigo";
            this.Pic_Codigo.Size = new System.Drawing.Size(162, 96);
            this.Pic_Codigo.TabIndex = 5;
            this.Pic_Codigo.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(101, 202);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(137, 69);
            this.Btn_Buscar.TabIndex = 4;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Frm_Ver_CB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Producto);
            this.Controls.Add(this.Pic_Codigo);
            this.Controls.Add(this.Btn_Buscar);
            this.Name = "Frm_Ver_CB";
            this.Text = "Ver código de barras Guardado en la base";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Codigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.PictureBox Pic_Codigo;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}