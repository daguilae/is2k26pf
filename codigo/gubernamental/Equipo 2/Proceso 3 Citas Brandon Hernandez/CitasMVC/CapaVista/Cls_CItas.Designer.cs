
namespace CapaVista
{
    partial class Cls_CItas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Fechayhora = new System.Windows.Forms.Label();
            this.Dtp_Fechayhora = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Sedes = new System.Windows.Forms.Label();
            this.Cbo_Sedes = new System.Windows.Forms.ComboBox();
            this.Btn_Constancia = new System.Windows.Forms.Button();
            this.Lbl_Tiulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Constancia);
            this.groupBox1.Controls.Add(this.Lbl_Fechayhora);
            this.groupBox1.Controls.Add(this.Dtp_Fechayhora);
            this.groupBox1.Controls.Add(this.Lbl_Sedes);
            this.groupBox1.Controls.Add(this.Cbo_Sedes);
            this.groupBox1.Location = new System.Drawing.Point(48, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 572);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_Fechayhora
            // 
            this.Lbl_Fechayhora.AutoSize = true;
            this.Lbl_Fechayhora.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fechayhora.Location = new System.Drawing.Point(43, 152);
            this.Lbl_Fechayhora.Name = "Lbl_Fechayhora";
            this.Lbl_Fechayhora.Size = new System.Drawing.Size(146, 25);
            this.Lbl_Fechayhora.TabIndex = 3;
            this.Lbl_Fechayhora.Text = "Fecha y Hora:";
            this.Lbl_Fechayhora.Click += new System.EventHandler(this.Lbl_Fecha_Click);
            // 
            // Dtp_Fechayhora
            // 
            this.Dtp_Fechayhora.Location = new System.Drawing.Point(209, 152);
            this.Dtp_Fechayhora.Name = "Dtp_Fechayhora";
            this.Dtp_Fechayhora.Size = new System.Drawing.Size(616, 22);
            this.Dtp_Fechayhora.TabIndex = 2;
            this.Dtp_Fechayhora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Lbl_Sedes
            // 
            this.Lbl_Sedes.AutoSize = true;
            this.Lbl_Sedes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sedes.Location = new System.Drawing.Point(43, 81);
            this.Lbl_Sedes.Name = "Lbl_Sedes";
            this.Lbl_Sedes.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Sedes.TabIndex = 1;
            this.Lbl_Sedes.Text = "Sede : ";
            this.Lbl_Sedes.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cbo_Sedes
            // 
            this.Cbo_Sedes.FormattingEnabled = true;
            this.Cbo_Sedes.Location = new System.Drawing.Point(187, 69);
            this.Cbo_Sedes.Name = "Cbo_Sedes";
            this.Cbo_Sedes.Size = new System.Drawing.Size(638, 24);
            this.Cbo_Sedes.TabIndex = 0;
            // 
            // Btn_Constancia
            // 
            this.Btn_Constancia.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Constancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Constancia.Location = new System.Drawing.Point(264, 478);
            this.Btn_Constancia.Name = "Btn_Constancia";
            this.Btn_Constancia.Size = new System.Drawing.Size(434, 84);
            this.Btn_Constancia.TabIndex = 1;
            this.Btn_Constancia.Text = "Generar Constancia ";
            this.Btn_Constancia.UseVisualStyleBackColor = false;
            // 
            // Lbl_Tiulo
            // 
            this.Lbl_Tiulo.AutoSize = true;
            this.Lbl_Tiulo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tiulo.Location = new System.Drawing.Point(375, 51);
            this.Lbl_Tiulo.Name = "Lbl_Tiulo";
            this.Lbl_Tiulo.Size = new System.Drawing.Size(195, 28);
            this.Lbl_Tiulo.TabIndex = 4;
            this.Lbl_Tiulo.Text = "Programar Cita ";
            // 
            // Cls_CItas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 699);
            this.Controls.Add(this.Lbl_Tiulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cls_CItas";
            this.Text = "Cls_CItas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Sedes;
        private System.Windows.Forms.ComboBox Cbo_Sedes;
        private System.Windows.Forms.DateTimePicker Dtp_Fechayhora;
        private System.Windows.Forms.Label Lbl_Fechayhora;
        private System.Windows.Forms.Button Btn_Constancia;
        private System.Windows.Forms.Label Lbl_Tiulo;
    }
}