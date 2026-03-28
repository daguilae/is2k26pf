namespace Capa_Vista_Citas
{
    partial class Frm_Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Citas));
            this.lbl_AgendarCita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Tipo_Cita = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Cita = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_Horario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbo_Sede = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_No_Boleta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AgendarCita
            // 
            this.lbl_AgendarCita.AutoSize = true;
            this.lbl_AgendarCita.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AgendarCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.lbl_AgendarCita.Location = new System.Drawing.Point(278, 85);
            this.lbl_AgendarCita.Name = "lbl_AgendarCita";
            this.lbl_AgendarCita.Size = new System.Drawing.Size(169, 29);
            this.lbl_AgendarCita.TabIndex = 0;
            this.lbl_AgendarCita.Text = "Agendar Cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motivo de cita";
            // 
            // Cbo_Tipo_Cita
            // 
            this.Cbo_Tipo_Cita.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cbo_Tipo_Cita.FormattingEnabled = true;
            this.Cbo_Tipo_Cita.Location = new System.Drawing.Point(28, 100);
            this.Cbo_Tipo_Cita.Name = "Cbo_Tipo_Cita";
            this.Cbo_Tipo_Cita.Size = new System.Drawing.Size(367, 24);
            this.Cbo_Tipo_Cita.TabIndex = 2;
            this.Cbo_Tipo_Cita.Text = "Selecciona el motivo de tu cita";
            // 
            // Dtp_Fecha_Cita
            // 
            this.Dtp_Fecha_Cita.CalendarForeColor = System.Drawing.Color.Black;
            this.Dtp_Fecha_Cita.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(231)))), ((int)(((byte)(248)))));
            this.Dtp_Fecha_Cita.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.Dtp_Fecha_Cita.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Cita.Location = new System.Drawing.Point(28, 170);
            this.Dtp_Fecha_Cita.Name = "Dtp_Fecha_Cita";
            this.Dtp_Fecha_Cita.Size = new System.Drawing.Size(367, 23);
            this.Dtp_Fecha_Cita.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccionar Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.label3.Location = new System.Drawing.Point(25, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccionar Horario";
            // 
            // Cbo_Horario
            // 
            this.Cbo_Horario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cbo_Horario.FormattingEnabled = true;
            this.Cbo_Horario.Location = new System.Drawing.Point(28, 239);
            this.Cbo_Horario.Name = "Cbo_Horario";
            this.Cbo_Horario.Size = new System.Drawing.Size(367, 24);
            this.Cbo_Horario.TabIndex = 6;
            this.Cbo_Horario.Text = "Seleccione el horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.label4.Location = new System.Drawing.Point(25, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seleccionar Sede";
            // 
            // Cbo_Sede
            // 
            this.Cbo_Sede.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Cbo_Sede.FormattingEnabled = true;
            this.Cbo_Sede.Location = new System.Drawing.Point(28, 312);
            this.Cbo_Sede.Name = "Cbo_Sede";
            this.Cbo_Sede.Size = new System.Drawing.Size(367, 24);
            this.Cbo_Sede.TabIndex = 8;
            this.Cbo_Sede.Text = "Seleccione la sede";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.label5.Location = new System.Drawing.Point(25, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "No.Boleta";
            // 
            // Txt_No_Boleta
            // 
            this.Txt_No_Boleta.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Txt_No_Boleta.Location = new System.Drawing.Point(28, 36);
            this.Txt_No_Boleta.Name = "Txt_No_Boleta";
            this.Txt_No_Boleta.Size = new System.Drawing.Size(367, 22);
            this.Txt_No_Boleta.TabIndex = 10;
            this.Txt_No_Boleta.Text = "Ingresa tu número de boleta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_No_Boleta);
            this.groupBox1.Controls.Add(this.Cbo_Sede);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cbo_Tipo_Cita);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cbo_Horario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Dtp_Fecha_Cita);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(109, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 417);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(151)))), ((int)(((byte)(208)))));
            this.button1.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Agendar Cita";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_AgendarCita);
            this.Name = "Frm_Citas";
            this.Text = "Frm_Citas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AgendarCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Cita;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Cita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbo_Sede;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_No_Boleta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}