
namespace Capa_Controlador_emision_pasaporte
{
    partial class Frm_emision_pasaporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_emision_pasaporte));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_emision_pasaporte = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_tipo = new System.Windows.Forms.Label();
            this.Cmb_tipo = new System.Windows.Forms.ComboBox();
            this.Lbl_pais_emisor = new System.Windows.Forms.Label();
            this.Txt_numero_pasaporte = new System.Windows.Forms.TextBox();
            this.Lbl_numero_pasaporte = new System.Windows.Forms.Label();
            this.Lbl_apellidos = new System.Windows.Forms.Label();
            this.Lbl_nacionalidad = new System.Windows.Forms.Label();
            this.Lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.Lbl_identidad_numero = new System.Windows.Forms.Label();
            this.Lbl_sexo = new System.Windows.Forms.Label();
            this.Lbl_lugar_nacimiento = new System.Windows.Forms.Label();
            this.Txt_apellidos = new System.Windows.Forms.TextBox();
            this.Txt_nacionalidad = new System.Windows.Forms.TextBox();
            this.Cmb_pais_emisor = new System.Windows.Forms.ComboBox();
            this.Cmb_sexo = new System.Windows.Forms.ComboBox();
            this.Txt_identidad_no = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_fecha_emision = new System.Windows.Forms.Label();
            this.Lbl_fecha_vencimiento = new System.Windows.Forms.Label();
            this.Lbl_autoridad = new System.Windows.Forms.Label();
            this.Cmb_autoridad = new System.Windows.Forms.ComboBox();
            this.Lbl_no_libreta = new System.Windows.Forms.Label();
            this.Txt_lugar_nacimiento = new System.Windows.Forms.TextBox();
            this.Txt_no_libreta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dtp_fecha_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fecha_vecimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fecha_emision = new System.Windows.Forms.DateTimePicker();
            this.Ptb_fotografia = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_cerrarr = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_fotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(588, 456);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(71, 52);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // lbl_emision_pasaporte
            // 
            this.lbl_emision_pasaporte.AutoSize = true;
            this.lbl_emision_pasaporte.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lbl_emision_pasaporte.Location = new System.Drawing.Point(371, 54);
            this.lbl_emision_pasaporte.Name = "lbl_emision_pasaporte";
            this.lbl_emision_pasaporte.Size = new System.Drawing.Size(272, 35);
            this.lbl_emision_pasaporte.TabIndex = 1;
            this.lbl_emision_pasaporte.Text = "Emisión Pasaporte";
            this.lbl_emision_pasaporte.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(36, 249);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(132, 22);
            this.Txt_nombre.TabIndex = 2;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_nombre.Location = new System.Drawing.Point(33, 211);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(73, 20);
            this.Lbl_nombre.TabIndex = 3;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_tipo
            // 
            this.Lbl_tipo.AutoSize = true;
            this.Lbl_tipo.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_tipo.Location = new System.Drawing.Point(32, 123);
            this.Lbl_tipo.Name = "Lbl_tipo";
            this.Lbl_tipo.Size = new System.Drawing.Size(44, 20);
            this.Lbl_tipo.TabIndex = 4;
            this.Lbl_tipo.Text = "Tipo";
            // 
            // Cmb_tipo
            // 
            this.Cmb_tipo.FormattingEnabled = true;
            this.Cmb_tipo.Location = new System.Drawing.Point(36, 164);
            this.Cmb_tipo.Name = "Cmb_tipo";
            this.Cmb_tipo.Size = new System.Drawing.Size(121, 24);
            this.Cmb_tipo.TabIndex = 5;
            // 
            // Lbl_pais_emisor
            // 
            this.Lbl_pais_emisor.AutoSize = true;
            this.Lbl_pais_emisor.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_pais_emisor.Location = new System.Drawing.Point(206, 123);
            this.Lbl_pais_emisor.Name = "Lbl_pais_emisor";
            this.Lbl_pais_emisor.Size = new System.Drawing.Size(105, 20);
            this.Lbl_pais_emisor.TabIndex = 6;
            this.Lbl_pais_emisor.Text = "País Emisor ";
            // 
            // Txt_numero_pasaporte
            // 
            this.Txt_numero_pasaporte.Location = new System.Drawing.Point(411, 164);
            this.Txt_numero_pasaporte.Name = "Txt_numero_pasaporte";
            this.Txt_numero_pasaporte.Size = new System.Drawing.Size(150, 22);
            this.Txt_numero_pasaporte.TabIndex = 8;
            // 
            // Lbl_numero_pasaporte
            // 
            this.Lbl_numero_pasaporte.AutoSize = true;
            this.Lbl_numero_pasaporte.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_numero_pasaporte.Location = new System.Drawing.Point(407, 123);
            this.Lbl_numero_pasaporte.Name = "Lbl_numero_pasaporte";
            this.Lbl_numero_pasaporte.Size = new System.Drawing.Size(108, 20);
            this.Lbl_numero_pasaporte.TabIndex = 9;
            this.Lbl_numero_pasaporte.Text = "Pasaporte N.";
            // 
            // Lbl_apellidos
            // 
            this.Lbl_apellidos.AutoSize = true;
            this.Lbl_apellidos.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_apellidos.Location = new System.Drawing.Point(206, 211);
            this.Lbl_apellidos.Name = "Lbl_apellidos";
            this.Lbl_apellidos.Size = new System.Drawing.Size(84, 20);
            this.Lbl_apellidos.TabIndex = 10;
            this.Lbl_apellidos.Text = "Apellidos";
            // 
            // Lbl_nacionalidad
            // 
            this.Lbl_nacionalidad.AutoSize = true;
            this.Lbl_nacionalidad.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_nacionalidad.Location = new System.Drawing.Point(409, 211);
            this.Lbl_nacionalidad.Name = "Lbl_nacionalidad";
            this.Lbl_nacionalidad.Size = new System.Drawing.Size(112, 20);
            this.Lbl_nacionalidad.TabIndex = 11;
            this.Lbl_nacionalidad.Text = "Nacionalidad";
            // 
            // Lbl_fecha_nacimiento
            // 
            this.Lbl_fecha_nacimiento.AutoSize = true;
            this.Lbl_fecha_nacimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_fecha_nacimiento.Location = new System.Drawing.Point(617, 211);
            this.Lbl_fecha_nacimiento.Name = "Lbl_fecha_nacimiento";
            this.Lbl_fecha_nacimiento.Size = new System.Drawing.Size(150, 20);
            this.Lbl_fecha_nacimiento.TabIndex = 12;
            this.Lbl_fecha_nacimiento.Text = "Fecha Nacimiento";
            // 
            // Lbl_identidad_numero
            // 
            this.Lbl_identidad_numero.AutoSize = true;
            this.Lbl_identidad_numero.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_identidad_numero.Location = new System.Drawing.Point(33, 306);
            this.Lbl_identidad_numero.Name = "Lbl_identidad_numero";
            this.Lbl_identidad_numero.Size = new System.Drawing.Size(114, 20);
            this.Lbl_identidad_numero.TabIndex = 13;
            this.Lbl_identidad_numero.Text = "Identidad No.";
            // 
            // Lbl_sexo
            // 
            this.Lbl_sexo.AutoSize = true;
            this.Lbl_sexo.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_sexo.Location = new System.Drawing.Point(206, 306);
            this.Lbl_sexo.Name = "Lbl_sexo";
            this.Lbl_sexo.Size = new System.Drawing.Size(47, 20);
            this.Lbl_sexo.TabIndex = 14;
            this.Lbl_sexo.Text = "Sexo";
            // 
            // Lbl_lugar_nacimiento
            // 
            this.Lbl_lugar_nacimiento.AutoSize = true;
            this.Lbl_lugar_nacimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_lugar_nacimiento.Location = new System.Drawing.Point(407, 306);
            this.Lbl_lugar_nacimiento.Name = "Lbl_lugar_nacimiento";
            this.Lbl_lugar_nacimiento.Size = new System.Drawing.Size(172, 20);
            this.Lbl_lugar_nacimiento.TabIndex = 15;
            this.Lbl_lugar_nacimiento.Text = "Lugar de Nacimiento";
            // 
            // Txt_apellidos
            // 
            this.Txt_apellidos.Location = new System.Drawing.Point(210, 249);
            this.Txt_apellidos.Name = "Txt_apellidos";
            this.Txt_apellidos.Size = new System.Drawing.Size(144, 22);
            this.Txt_apellidos.TabIndex = 16;
            // 
            // Txt_nacionalidad
            // 
            this.Txt_nacionalidad.Location = new System.Drawing.Point(413, 251);
            this.Txt_nacionalidad.Name = "Txt_nacionalidad";
            this.Txt_nacionalidad.Size = new System.Drawing.Size(150, 22);
            this.Txt_nacionalidad.TabIndex = 17;
            // 
            // Cmb_pais_emisor
            // 
            this.Cmb_pais_emisor.FormattingEnabled = true;
            this.Cmb_pais_emisor.Location = new System.Drawing.Point(210, 164);
            this.Cmb_pais_emisor.Name = "Cmb_pais_emisor";
            this.Cmb_pais_emisor.Size = new System.Drawing.Size(142, 24);
            this.Cmb_pais_emisor.TabIndex = 18;
            this.Cmb_pais_emisor.SelectedIndexChanged += new System.EventHandler(this.Cmb_pais_emisor_SelectedIndexChanged);
            // 
            // Cmb_sexo
            // 
            this.Cmb_sexo.FormattingEnabled = true;
            this.Cmb_sexo.Location = new System.Drawing.Point(210, 341);
            this.Cmb_sexo.Name = "Cmb_sexo";
            this.Cmb_sexo.Size = new System.Drawing.Size(144, 24);
            this.Cmb_sexo.TabIndex = 19;
            this.Cmb_sexo.SelectedIndexChanged += new System.EventHandler(this.Cmb_sexo_SelectedIndexChanged);
            // 
            // Txt_identidad_no
            // 
            this.Txt_identidad_no.Location = new System.Drawing.Point(36, 341);
            this.Txt_identidad_no.Name = "Txt_identidad_no";
            this.Txt_identidad_no.Size = new System.Drawing.Size(132, 22);
            this.Txt_identidad_no.TabIndex = 20;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar.Image")));
            this.Btn_buscar.Location = new System.Drawing.Point(464, 458);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(80, 50);
            this.Btn_buscar.TabIndex = 21;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_fecha_emision
            // 
            this.Lbl_fecha_emision.AutoSize = true;
            this.Lbl_fecha_emision.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_fecha_emision.Location = new System.Drawing.Point(40, 395);
            this.Lbl_fecha_emision.Name = "Lbl_fecha_emision";
            this.Lbl_fecha_emision.Size = new System.Drawing.Size(128, 20);
            this.Lbl_fecha_emision.TabIndex = 22;
            this.Lbl_fecha_emision.Text = "Fecha Emisión ";
            // 
            // Lbl_fecha_vencimiento
            // 
            this.Lbl_fecha_vencimiento.AutoSize = true;
            this.Lbl_fecha_vencimiento.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_fecha_vencimiento.Location = new System.Drawing.Point(206, 395);
            this.Lbl_fecha_vencimiento.Name = "Lbl_fecha_vencimiento";
            this.Lbl_fecha_vencimiento.Size = new System.Drawing.Size(161, 20);
            this.Lbl_fecha_vencimiento.TabIndex = 23;
            this.Lbl_fecha_vencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_autoridad
            // 
            this.Lbl_autoridad.AutoSize = true;
            this.Lbl_autoridad.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_autoridad.Location = new System.Drawing.Point(625, 306);
            this.Lbl_autoridad.Name = "Lbl_autoridad";
            this.Lbl_autoridad.Size = new System.Drawing.Size(87, 20);
            this.Lbl_autoridad.TabIndex = 24;
            this.Lbl_autoridad.Text = "Autoridad";
            // 
            // Cmb_autoridad
            // 
            this.Cmb_autoridad.FormattingEnabled = true;
            this.Cmb_autoridad.Location = new System.Drawing.Point(621, 339);
            this.Cmb_autoridad.Name = "Cmb_autoridad";
            this.Cmb_autoridad.Size = new System.Drawing.Size(146, 24);
            this.Cmb_autoridad.TabIndex = 25;
            // 
            // Lbl_no_libreta
            // 
            this.Lbl_no_libreta.AutoSize = true;
            this.Lbl_no_libreta.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.Lbl_no_libreta.Location = new System.Drawing.Point(617, 123);
            this.Lbl_no_libreta.Name = "Lbl_no_libreta";
            this.Lbl_no_libreta.Size = new System.Drawing.Size(95, 20);
            this.Lbl_no_libreta.TabIndex = 26;
            this.Lbl_no_libreta.Text = "No. Libreta";
            // 
            // Txt_lugar_nacimiento
            // 
            this.Txt_lugar_nacimiento.Location = new System.Drawing.Point(411, 341);
            this.Txt_lugar_nacimiento.Name = "Txt_lugar_nacimiento";
            this.Txt_lugar_nacimiento.Size = new System.Drawing.Size(150, 22);
            this.Txt_lugar_nacimiento.TabIndex = 27;
            // 
            // Txt_no_libreta
            // 
            this.Txt_no_libreta.Location = new System.Drawing.Point(621, 166);
            this.Txt_no_libreta.Name = "Txt_no_libreta";
            this.Txt_no_libreta.Size = new System.Drawing.Size(145, 22);
            this.Txt_no_libreta.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.Btn_cerrarr);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 41);
            this.panel1.TabIndex = 29;
            // 
            // Dtp_fecha_nacimiento
            // 
            this.Dtp_fecha_nacimiento.Location = new System.Drawing.Point(621, 249);
            this.Dtp_fecha_nacimiento.Name = "Dtp_fecha_nacimiento";
            this.Dtp_fecha_nacimiento.Size = new System.Drawing.Size(146, 22);
            this.Dtp_fecha_nacimiento.TabIndex = 30;
            // 
            // Dtp_fecha_vecimiento
            // 
            this.Dtp_fecha_vecimiento.Location = new System.Drawing.Point(210, 445);
            this.Dtp_fecha_vecimiento.Name = "Dtp_fecha_vecimiento";
            this.Dtp_fecha_vecimiento.Size = new System.Drawing.Size(144, 22);
            this.Dtp_fecha_vecimiento.TabIndex = 31;
            // 
            // Dtp_fecha_emision
            // 
            this.Dtp_fecha_emision.Location = new System.Drawing.Point(36, 445);
            this.Dtp_fecha_emision.Name = "Dtp_fecha_emision";
            this.Dtp_fecha_emision.Size = new System.Drawing.Size(140, 22);
            this.Dtp_fecha_emision.TabIndex = 32;
            // 
            // Ptb_fotografia
            // 
            this.Ptb_fotografia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ptb_fotografia.Location = new System.Drawing.Point(824, 160);
            this.Ptb_fotografia.Name = "Ptb_fotografia";
            this.Ptb_fotografia.Size = new System.Drawing.Size(155, 191);
            this.Ptb_fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ptb_fotografia.TabIndex = 33;
            this.Ptb_fotografia.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Tomar Fotografía ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_imprimir.Image")));
            this.Btn_imprimir.Location = new System.Drawing.Point(708, 456);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(73, 52);
            this.Btn_imprimir.TabIndex = 35;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(833, 458);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(70, 50);
            this.Btn_cerrar.TabIndex = 36;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(865, 54);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(70, 55);
            this.Btn_ayuda.TabIndex = 37;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_cerrarr
            // 
            this.Btn_cerrarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrarr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_cerrarr.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrarr.Image")));
            this.Btn_cerrarr.Location = new System.Drawing.Point(937, 3);
            this.Btn_cerrarr.Name = "Btn_cerrarr";
            this.Btn_cerrarr.Size = new System.Drawing.Size(78, 38);
            this.Btn_cerrarr.TabIndex = 0;
            this.Btn_cerrarr.UseVisualStyleBackColor = true;
            this.Btn_cerrarr.Click += new System.EventHandler(this.Btn_cerrarr_Click);
            // 
            // Frm_emision_pasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 520);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_cerrar);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ptb_fotografia);
            this.Controls.Add(this.Dtp_fecha_emision);
            this.Controls.Add(this.Dtp_fecha_vecimiento);
            this.Controls.Add(this.Dtp_fecha_nacimiento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_no_libreta);
            this.Controls.Add(this.Txt_lugar_nacimiento);
            this.Controls.Add(this.Lbl_no_libreta);
            this.Controls.Add(this.Cmb_autoridad);
            this.Controls.Add(this.Lbl_autoridad);
            this.Controls.Add(this.Lbl_fecha_vencimiento);
            this.Controls.Add(this.Lbl_fecha_emision);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_identidad_no);
            this.Controls.Add(this.Cmb_sexo);
            this.Controls.Add(this.Cmb_pais_emisor);
            this.Controls.Add(this.Txt_nacionalidad);
            this.Controls.Add(this.Txt_apellidos);
            this.Controls.Add(this.Lbl_lugar_nacimiento);
            this.Controls.Add(this.Lbl_sexo);
            this.Controls.Add(this.Lbl_identidad_numero);
            this.Controls.Add(this.Lbl_fecha_nacimiento);
            this.Controls.Add(this.Lbl_nacionalidad);
            this.Controls.Add(this.Lbl_apellidos);
            this.Controls.Add(this.Lbl_numero_pasaporte);
            this.Controls.Add(this.Txt_numero_pasaporte);
            this.Controls.Add(this.Lbl_pais_emisor);
            this.Controls.Add(this.Cmb_tipo);
            this.Controls.Add(this.Lbl_tipo);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.lbl_emision_pasaporte);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_emision_pasaporte";
            this.Text = "Tipo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_fotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label lbl_emision_pasaporte;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_tipo;
        private System.Windows.Forms.ComboBox Cmb_tipo;
        private System.Windows.Forms.Label Lbl_pais_emisor;
        private System.Windows.Forms.TextBox Txt_numero_pasaporte;
        private System.Windows.Forms.Label Lbl_numero_pasaporte;
        private System.Windows.Forms.Label Lbl_apellidos;
        private System.Windows.Forms.Label Lbl_nacionalidad;
        private System.Windows.Forms.Label Lbl_fecha_nacimiento;
        private System.Windows.Forms.Label Lbl_identidad_numero;
        private System.Windows.Forms.Label Lbl_sexo;
        private System.Windows.Forms.Label Lbl_lugar_nacimiento;
        private System.Windows.Forms.TextBox Txt_apellidos;
        private System.Windows.Forms.TextBox Txt_nacionalidad;
        private System.Windows.Forms.ComboBox Cmb_pais_emisor;
        private System.Windows.Forms.ComboBox Cmb_sexo;
        private System.Windows.Forms.TextBox Txt_identidad_no;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_fecha_emision;
        private System.Windows.Forms.Label Lbl_fecha_vencimiento;
        private System.Windows.Forms.Label Lbl_autoridad;
        private System.Windows.Forms.ComboBox Cmb_autoridad;
        private System.Windows.Forms.Label Lbl_no_libreta;
        private System.Windows.Forms.TextBox Txt_lugar_nacimiento;
        private System.Windows.Forms.TextBox Txt_no_libreta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_nacimiento;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_vecimiento;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_emision;
        private System.Windows.Forms.PictureBox Ptb_fotografia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_cerrarr;
    }
}

