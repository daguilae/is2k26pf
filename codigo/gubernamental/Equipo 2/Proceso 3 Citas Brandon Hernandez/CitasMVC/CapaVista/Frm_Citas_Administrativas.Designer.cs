
namespace CapaVista
{
    partial class Txt_Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Txt_Cita));
            this.Gbo_opciones = new System.Windows.Forms.GroupBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Dtp_Fecha_hora = new System.Windows.Forms.DateTimePicker();
            this.Lbl_FechayHora = new System.Windows.Forms.Label();
            this.Txt_sede = new System.Windows.Forms.TextBox();
            this.Lbl_Sedes = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Lbl_Citas = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Dgv_Citas = new System.Windows.Forms.DataGridView();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Gbo_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Citas)).BeginInit();
            this.SuspendLayout();
            // 
            // Gbo_opciones
            // 
            this.Gbo_opciones.Controls.Add(this.Cbo_Estado);
            this.Gbo_opciones.Controls.Add(this.Lbl_Estado);
            this.Gbo_opciones.Controls.Add(this.Dtp_Fecha_hora);
            this.Gbo_opciones.Controls.Add(this.Lbl_FechayHora);
            this.Gbo_opciones.Controls.Add(this.Txt_sede);
            this.Gbo_opciones.Controls.Add(this.Lbl_Sedes);
            this.Gbo_opciones.Controls.Add(this.Txt_id);
            this.Gbo_opciones.Controls.Add(this.Lbl_Citas);
            this.Gbo_opciones.Location = new System.Drawing.Point(12, 101);
            this.Gbo_opciones.Name = "Gbo_opciones";
            this.Gbo_opciones.Size = new System.Drawing.Size(1400, 145);
            this.Gbo_opciones.TabIndex = 0;
            this.Gbo_opciones.TabStop = false;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(1066, 62);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(272, 28);
            this.Cbo_Estado.TabIndex = 7;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(995, 62);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(62, 20);
            this.Lbl_Estado.TabIndex = 6;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Dtp_Fecha_hora
            // 
            this.Dtp_Fecha_hora.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_hora.Location = new System.Drawing.Point(605, 53);
            this.Dtp_Fecha_hora.Name = "Dtp_Fecha_hora";
            this.Dtp_Fecha_hora.Size = new System.Drawing.Size(360, 27);
            this.Dtp_Fecha_hora.TabIndex = 5;
            // 
            // Lbl_FechayHora
            // 
            this.Lbl_FechayHora.AutoSize = true;
            this.Lbl_FechayHora.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechayHora.Location = new System.Drawing.Point(476, 58);
            this.Lbl_FechayHora.Name = "Lbl_FechayHora";
            this.Lbl_FechayHora.Size = new System.Drawing.Size(114, 20);
            this.Lbl_FechayHora.TabIndex = 4;
            this.Lbl_FechayHora.Text = "Fecha y hora ";
            // 
            // Txt_sede
            // 
            this.Txt_sede.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sede.Location = new System.Drawing.Point(220, 55);
            this.Txt_sede.Name = "Txt_sede";
            this.Txt_sede.Size = new System.Drawing.Size(250, 27);
            this.Txt_sede.TabIndex = 3;
            // 
            // Lbl_Sedes
            // 
            this.Lbl_Sedes.AutoSize = true;
            this.Lbl_Sedes.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sedes.Location = new System.Drawing.Point(166, 62);
            this.Lbl_Sedes.Name = "Lbl_Sedes";
            this.Lbl_Sedes.Size = new System.Drawing.Size(48, 20);
            this.Lbl_Sedes.TabIndex = 2;
            this.Lbl_Sedes.Text = "Sede";
            // 
            // Txt_id
            // 
            this.Txt_id.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id.Location = new System.Drawing.Point(86, 59);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(74, 27);
            this.Txt_id.TabIndex = 1;
            // 
            // Lbl_Citas
            // 
            this.Lbl_Citas.AutoSize = true;
            this.Lbl_Citas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Citas.Location = new System.Drawing.Point(20, 62);
            this.Lbl_Citas.Name = "Lbl_Citas";
            this.Lbl_Citas.Size = new System.Drawing.Size(60, 20);
            this.Lbl_Citas.TabIndex = 0;
            this.Lbl_Citas.Text = "Id Cita";
            // 
            // Dgv_Citas
            // 
            this.Dgv_Citas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Citas.Location = new System.Drawing.Point(46, 303);
            this.Dgv_Citas.Name = "Dgv_Citas";
            this.Dgv_Citas.RowHeadersWidth = 51;
            this.Dgv_Citas.RowTemplate.Height = 24;
            this.Dgv_Citas.Size = new System.Drawing.Size(1304, 445);
            this.Dgv_Citas.TabIndex = 1;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(946, 12);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(123, 72);
            this.Btn_Modificar.TabIndex = 2;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Borrar.Image")));
            this.Btn_Borrar.Location = new System.Drawing.Point(1078, 12);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(123, 72);
            this.Btn_Borrar.TabIndex = 3;
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(1227, 12);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(123, 72);
            this.Btn_Limpiar.TabIndex = 4;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Txt_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1455, 760);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Dgv_Citas);
            this.Controls.Add(this.Gbo_opciones);
            this.Name = "Txt_Cita";
            this.Text = "Cls_Citas_Administrativas";
            this.Gbo_opciones.ResumeLayout(false);
            this.Gbo_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Citas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbo_opciones;
        private System.Windows.Forms.Label Lbl_Citas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView Dgv_Citas;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_hora;
        private System.Windows.Forms.Label Lbl_FechayHora;
        private System.Windows.Forms.TextBox Txt_sede;
        private System.Windows.Forms.Label Lbl_Sedes;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}