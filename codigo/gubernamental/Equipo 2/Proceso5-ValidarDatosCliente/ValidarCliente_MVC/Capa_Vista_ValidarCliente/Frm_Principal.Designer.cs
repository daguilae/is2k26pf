
namespace Capa_Vista_ValidarCliente
{
    partial class Frm_Principal
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
            this.Btn_ValidarRenap = new System.Windows.Forms.Button();
            this.Lbl_Renap = new System.Windows.Forms.Label();
            this.Btn_ValidarPolicia = new System.Windows.Forms.Button();
            this.Btn_GenerarExpediente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ValidarRenap
            // 
            this.Btn_ValidarRenap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ValidarRenap.Location = new System.Drawing.Point(279, 159);
            this.Btn_ValidarRenap.Name = "Btn_ValidarRenap";
            this.Btn_ValidarRenap.Size = new System.Drawing.Size(131, 58);
            this.Btn_ValidarRenap.TabIndex = 2;
            this.Btn_ValidarRenap.Text = "Validar Datos RENAP";
            this.Btn_ValidarRenap.UseVisualStyleBackColor = true;
            // 
            // Lbl_Renap
            // 
            this.Lbl_Renap.AutoSize = true;
            this.Lbl_Renap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Renap.Location = new System.Drawing.Point(178, 67);
            this.Lbl_Renap.Name = "Lbl_Renap";
            this.Lbl_Renap.Size = new System.Drawing.Size(313, 27);
            this.Lbl_Renap.TabIndex = 3;
            this.Lbl_Renap.Text = "Validación de Datos del Cliente";
            // 
            // Btn_ValidarPolicia
            // 
            this.Btn_ValidarPolicia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ValidarPolicia.Location = new System.Drawing.Point(279, 239);
            this.Btn_ValidarPolicia.Name = "Btn_ValidarPolicia";
            this.Btn_ValidarPolicia.Size = new System.Drawing.Size(131, 74);
            this.Btn_ValidarPolicia.TabIndex = 4;
            this.Btn_ValidarPolicia.Text = "Validar Antecedentes Policiacos";
            this.Btn_ValidarPolicia.UseVisualStyleBackColor = true;
            // 
            // Btn_GenerarExpediente
            // 
            this.Btn_GenerarExpediente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GenerarExpediente.Location = new System.Drawing.Point(269, 388);
            this.Btn_GenerarExpediente.Name = "Btn_GenerarExpediente";
            this.Btn_GenerarExpediente.Size = new System.Drawing.Size(153, 79);
            this.Btn_GenerarExpediente.TabIndex = 5;
            this.Btn_GenerarExpediente.Text = "Generar Expediente Verificado";
            this.Btn_GenerarExpediente.UseVisualStyleBackColor = true;
            this.Btn_GenerarExpediente.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 500);
            this.Controls.Add(this.Btn_GenerarExpediente);
            this.Controls.Add(this.Btn_ValidarPolicia);
            this.Controls.Add(this.Lbl_Renap);
            this.Controls.Add(this.Btn_ValidarRenap);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ValidarRenap;
        private System.Windows.Forms.Label Lbl_Renap;
        private System.Windows.Forms.Button Btn_ValidarPolicia;
        private System.Windows.Forms.Button Btn_GenerarExpediente;
    }
}