
namespace Capa_vista_Emision_pasaporte
{
    partial class Frm_fotografia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_fotografia));
            this.Ptb_camara = new System.Windows.Forms.PictureBox();
            this.Btn_capturar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_tomar_fotografia = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_camara)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ptb_camara
            // 
            this.Ptb_camara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ptb_camara.Location = new System.Drawing.Point(80, 166);
            this.Ptb_camara.Name = "Ptb_camara";
            this.Ptb_camara.Size = new System.Drawing.Size(189, 215);
            this.Ptb_camara.TabIndex = 0;
            this.Ptb_camara.TabStop = false;
            // 
            // Btn_capturar
            // 
            this.Btn_capturar.Location = new System.Drawing.Point(416, 177);
            this.Btn_capturar.Name = "Btn_capturar";
            this.Btn_capturar.Size = new System.Drawing.Size(82, 46);
            this.Btn_capturar.TabIndex = 1;
            this.Btn_capturar.Text = "Capturar";
            this.Btn_capturar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 43);
            this.panel1.TabIndex = 2;
            // 
            // Lbl_tomar_fotografia
            // 
            this.Lbl_tomar_fotografia.AutoSize = true;
            this.Lbl_tomar_fotografia.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_tomar_fotografia.Location = new System.Drawing.Point(186, 70);
            this.Lbl_tomar_fotografia.Name = "Lbl_tomar_fotografia";
            this.Lbl_tomar_fotografia.Size = new System.Drawing.Size(262, 35);
            this.Lbl_tomar_fotografia.TabIndex = 3;
            this.Lbl_tomar_fotografia.Text = "Tomar Fotografía ";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.Image")));
            this.Btn_Aceptar.Location = new System.Drawing.Point(416, 252);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(82, 46);
            this.Btn_Aceptar.TabIndex = 4;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(416, 332);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(82, 40);
            this.Btn_cancelar.TabIndex = 5;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(564, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(41, 32);
            this.Btn_cerrar.TabIndex = 6;
            this.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_cerrar.UseVisualStyleBackColor = false;
            this.Btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_fotografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 451);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Lbl_tomar_fotografia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_capturar);
            this.Controls.Add(this.Ptb_camara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_fotografia";
            this.Text = "Frm_fotografia";
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_camara)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ptb_camara;
        private System.Windows.Forms.Button Btn_capturar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_tomar_fotografia;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_cerrar;
    }
}