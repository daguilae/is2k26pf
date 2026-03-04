
namespace Capa_Vista_Antecedentes
{
    partial class Frm_Antecedentes
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
            this.Dtp_Hora = new System.Windows.Forms.DateTimePicker();
            this.Txt_Tipo = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.RichTextBox();
            this.Cbo_Ciudadano = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_Tipo_Antecedente = new System.Windows.Forms.Label();
            this.Lbl_Estado_Antecedente = new System.Windows.Forms.Label();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Ciudadano = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Cbo_Buscar = new System.Windows.Forms.ComboBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtp_Hora
            // 
            this.Dtp_Hora.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.Dtp_Hora.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Hora.Location = new System.Drawing.Point(140, 211);
            this.Dtp_Hora.Name = "Dtp_Hora";
            this.Dtp_Hora.Size = new System.Drawing.Size(311, 27);
            this.Dtp_Hora.TabIndex = 6;
            // 
            // Txt_Tipo
            // 
            this.Txt_Tipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Tipo.Location = new System.Drawing.Point(140, 249);
            this.Txt_Tipo.Name = "Txt_Tipo";
            this.Txt_Tipo.Size = new System.Drawing.Size(311, 27);
            this.Txt_Tipo.TabIndex = 7;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descripcion.Location = new System.Drawing.Point(576, 206);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(339, 150);
            this.Txt_Descripcion.TabIndex = 11;
            this.Txt_Descripcion.Text = "";
            this.Txt_Descripcion.TextChanged += new System.EventHandler(this.Txt_Descripcion_TextChanged);
            // 
            // Cbo_Ciudadano
            // 
            this.Cbo_Ciudadano.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Ciudadano.FormattingEnabled = true;
            this.Cbo_Ciudadano.Location = new System.Drawing.Point(140, 328);
            this.Cbo_Ciudadano.Name = "Cbo_Ciudadano";
            this.Cbo_Ciudadano.Size = new System.Drawing.Size(311, 28);
            this.Cbo_Ciudadano.TabIndex = 12;
            this.Cbo_Ciudadano.SelectedIndexChanged += new System.EventHandler(this.Cbo_Ciudadano_SelectedIndexChanged);
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Fecha.Location = new System.Drawing.Point(30, 218);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Fecha.TabIndex = 13;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Lbl_Tipo_Antecedente
            // 
            this.Lbl_Tipo_Antecedente.AutoSize = true;
            this.Lbl_Tipo_Antecedente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Antecedente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Tipo_Antecedente.Location = new System.Drawing.Point(30, 256);
            this.Lbl_Tipo_Antecedente.Name = "Lbl_Tipo_Antecedente";
            this.Lbl_Tipo_Antecedente.Size = new System.Drawing.Size(49, 20);
            this.Lbl_Tipo_Antecedente.TabIndex = 14;
            this.Lbl_Tipo_Antecedente.Text = "Tipo:";
            // 
            // Lbl_Estado_Antecedente
            // 
            this.Lbl_Estado_Antecedente.AutoSize = true;
            this.Lbl_Estado_Antecedente.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Antecedente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Estado_Antecedente.Location = new System.Drawing.Point(30, 292);
            this.Lbl_Estado_Antecedente.Name = "Lbl_Estado_Antecedente";
            this.Lbl_Estado_Antecedente.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Estado_Antecedente.TabIndex = 15;
            this.Lbl_Estado_Antecedente.Text = "Estado:";
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Descripcion.Location = new System.Drawing.Point(461, 211);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(109, 20);
            this.Lbl_Descripcion.TabIndex = 16;
            this.Lbl_Descripcion.Text = "Descripción:";
            this.Lbl_Descripcion.Click += new System.EventHandler(this.Lbl_Descripcion_Click);
            // 
            // Lbl_Ciudadano
            // 
            this.Lbl_Ciudadano.AutoSize = true;
            this.Lbl_Ciudadano.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ciudadano.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Ciudadano.Location = new System.Drawing.Point(30, 336);
            this.Lbl_Ciudadano.Name = "Lbl_Ciudadano";
            this.Lbl_Ciudadano.Size = new System.Drawing.Size(100, 20);
            this.Lbl_Ciudadano.TabIndex = 17;
            this.Lbl_Ciudadano.Text = "Ciudadano:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 82);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Capa_Vista_Antecedentes.Properties.Resources.CrossWay_Logo_Blanco;
            this.pictureBox1.Location = new System.Drawing.Point(-48, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Titulo.Location = new System.Drawing.Point(413, 97);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Titulo.Size = new System.Drawing.Size(205, 35);
            this.Lbl_Titulo.TabIndex = 24;
            this.Lbl_Titulo.Text = "Antecedentes";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Items.AddRange(new object[] {
            "Activo",
            "Descativado",
            "Inexistente"});
            this.Cbo_Estado.Location = new System.Drawing.Point(140, 289);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(311, 28);
            this.Cbo_Estado.TabIndex = 25;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl_Buscar.Location = new System.Drawing.Point(30, 147);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Buscar.TabIndex = 26;
            this.Lbl_Buscar.Text = "Buscar:";
            // 
            // Cbo_Buscar
            // 
            this.Cbo_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cbo_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cbo_Buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Buscar.FormattingEnabled = true;
            this.Cbo_Buscar.Location = new System.Drawing.Point(140, 147);
            this.Cbo_Buscar.Name = "Cbo_Buscar";
            this.Cbo_Buscar.Size = new System.Drawing.Size(720, 28);
            this.Cbo_Buscar.TabIndex = 27;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.buscar;
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Location = new System.Drawing.Point(866, 140);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(49, 47);
            this.Btn_Buscar.TabIndex = 28;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.refrescar;
            this.Btn_Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Location = new System.Drawing.Point(701, 12);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(49, 48);
            this.Btn_Refrescar.TabIndex = 20;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.salir;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(866, 12);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(49, 48);
            this.Btn_Salir.TabIndex = 19;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.modificar;
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Modificar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(591, 12);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(49, 48);
            this.Btn_Modificar.TabIndex = 18;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.imprimir;
            this.Btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Location = new System.Drawing.Point(756, 12);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(49, 48);
            this.Btn_Imprimir.TabIndex = 5;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.eliminar;
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(646, 12);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(49, 48);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.cancelar;
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(811, 12);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(49, 48);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.agregar;
            this.Btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(481, 12);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(49, 48);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackgroundImage = global::Capa_Vista_Antecedentes.Properties.Resources.guardar;
            this.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Location = new System.Drawing.Point(536, 12);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(49, 48);
            this.Btn_Guardar.TabIndex = 1;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Frm_Antecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 391);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Cbo_Buscar);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Lbl_Ciudadano);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Lbl_Estado_Antecedente);
            this.Controls.Add(this.Lbl_Tipo_Antecedente);
            this.Controls.Add(this.Lbl_Fecha);
            this.Controls.Add(this.Cbo_Ciudadano);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Txt_Tipo);
            this.Controls.Add(this.Dtp_Hora);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Guardar);
            this.Name = "Frm_Antecedentes";
            this.Text = "Frm_Antecedentes";
            this.Load += new System.EventHandler(this.Frm_Antecedentes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.DateTimePicker Dtp_Hora;
        private System.Windows.Forms.TextBox Txt_Tipo;
        private System.Windows.Forms.RichTextBox Txt_Descripcion;
        private System.Windows.Forms.ComboBox Cbo_Ciudadano;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_Tipo_Antecedente;
        private System.Windows.Forms.Label Lbl_Estado_Antecedente;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Ciudadano;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.ComboBox Cbo_Buscar;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}