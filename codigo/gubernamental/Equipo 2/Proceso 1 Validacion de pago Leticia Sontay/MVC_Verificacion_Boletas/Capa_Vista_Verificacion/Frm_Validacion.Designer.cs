
namespace Capa_Vista_Verificacion
{
    partial class Frm_Validacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Validacion));
            this.btn_Validacion = new System.Windows.Forms.Button();
            this.Lbl_validacion = new System.Windows.Forms.Label();
            this.Txt_Validacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Validacion
            // 
            this.btn_Validacion.Font = new System.Drawing.Font("Rockwell Extra Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Validacion.Location = new System.Drawing.Point(232, 275);
            this.btn_Validacion.Name = "btn_Validacion";
            this.btn_Validacion.Size = new System.Drawing.Size(186, 62);
            this.btn_Validacion.TabIndex = 0;
            this.btn_Validacion.Text = "Validar";
            this.btn_Validacion.UseVisualStyleBackColor = true;
            this.btn_Validacion.Click += new System.EventHandler(this.btn_Validacion_Click);
            // 
            // Lbl_validacion
            // 
            this.Lbl_validacion.AutoSize = true;
            this.Lbl_validacion.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_validacion.Location = new System.Drawing.Point(35, 61);
            this.Lbl_validacion.Name = "Lbl_validacion";
            this.Lbl_validacion.Size = new System.Drawing.Size(578, 37);
            this.Lbl_validacion.TabIndex = 1;
            this.Lbl_validacion.Text = "Validacion de Boleta de Pago";
            // 
            // Txt_Validacion
            // 
            this.Txt_Validacion.Location = new System.Drawing.Point(298, 185);
            this.Txt_Validacion.Name = "Txt_Validacion";
            this.Txt_Validacion.Size = new System.Drawing.Size(315, 20);
            this.Txt_Validacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 60);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el numero de boleta";
            // 
            // Frm_Validacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Validacion);
            this.Controls.Add(this.Lbl_validacion);
            this.Controls.Add(this.btn_Validacion);
            this.Name = "Frm_Validacion";
            this.Text = "Frm_Validacion";
            this.Click += new System.EventHandler(this.btn_Validacion_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Validacion;
        private System.Windows.Forms.Label Lbl_validacion;
        private System.Windows.Forms.TextBox Txt_Validacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}