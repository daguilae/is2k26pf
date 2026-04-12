
namespace Capa_vista_Emision_pasaporte
{
    partial class Frm_Firma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Firma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Ptb_firma = new System.Windows.Forms.PictureBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_tomar_firma = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_firma)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 38);
            this.panel1.TabIndex = 9;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(455, 2);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(31, 26);
            this.Btn_cerrar.TabIndex = 6;
            this.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // Ptb_firma
            // 
            this.Ptb_firma.BackColor = System.Drawing.Color.White;
            this.Ptb_firma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ptb_firma.Location = new System.Drawing.Point(38, 153);
            this.Ptb_firma.Margin = new System.Windows.Forms.Padding(2);
            this.Ptb_firma.Name = "Ptb_firma";
            this.Ptb_firma.Size = new System.Drawing.Size(261, 185);
            this.Ptb_firma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_firma.TabIndex = 7;
            this.Ptb_firma.TabStop = false;
            this.Ptb_firma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ptb_firma_MouseDown);
            this.Ptb_firma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ptb_firma_MouseMove);
            this.Ptb_firma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ptb_firma_MouseUp);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_limpiar.Image")));
            this.Btn_limpiar.Location = new System.Drawing.Point(344, 177);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(62, 41);
            this.Btn_limpiar.TabIndex = 13;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(344, 277);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(62, 32);
            this.Btn_cancelar.TabIndex = 12;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(344, 228);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(62, 37);
            this.Btn_guardar.TabIndex = 11;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Lbl_tomar_firma
            // 
            this.Lbl_tomar_firma.AutoSize = true;
            this.Lbl_tomar_firma.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_tomar_firma.Location = new System.Drawing.Point(145, 74);
            this.Lbl_tomar_firma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_tomar_firma.Name = "Lbl_tomar_firma";
            this.Lbl_tomar_firma.Size = new System.Drawing.Size(154, 27);
            this.Lbl_tomar_firma.TabIndex = 10;
            this.Lbl_tomar_firma.Text = "Tomar Firma";
            // 
            // Frm_Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ptb_firma);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Lbl_tomar_firma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Firma";
            this.Text = "Frm_Firma";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_firma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.PictureBox Ptb_firma;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_tomar_firma;
    }
}