
namespace Capa_Vista_CheckList_Entrevista
{
    partial class Frm_CheckList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CheckList));
            this.label1 = new System.Windows.Forms.Label();
            this.GB_ENCABEZADO = new System.Windows.Forms.GroupBox();
            this.Cbo_Id_Entrevista = new System.Windows.Forms.ComboBox();
            this.Lbl_Cant_Pregunta = new System.Windows.Forms.Label();
            this.DTP_FECHA_ENTREVISTA = new System.Windows.Forms.DateTimePicker();
            this.CBO_DPI_SOLICITANTE = new System.Windows.Forms.ComboBox();
            this.Lbl_P = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_DPI = new System.Windows.Forms.Label();
            this.Lbl_IDentrevista = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar_Entrevista = new System.Windows.Forms.Button();
            this.Btn_Agregar_Pregunta = new System.Windows.Forms.Button();
            this.DGV_PREGUNTAS_ENTREVISTA = new System.Windows.Forms.DataGridView();
            this.IdPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enunciado_Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta_Aceptable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChB_Estado = new System.Windows.Forms.CheckBox();
            this.ChB_Rechazado = new System.Windows.Forms.CheckBox();
            this.GB_ESTADO = new System.Windows.Forms.GroupBox();
            this.GB_PREGUNTAS = new System.Windows.Forms.GroupBox();
            this.BTN_LIMPIAR_PREG = new System.Windows.Forms.Button();
            this.Btn_Remover_Pregunta = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.BTN_LIMPIAR_ENCABEZADO = new System.Windows.Forms.Button();
            this.GB_ENCABEZADO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PREGUNTAS_ENTREVISTA)).BeginInit();
            this.GB_ESTADO.SuspendLayout();
            this.GB_PREGUNTAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrevista";
            // 
            // GB_ENCABEZADO
            // 
            this.GB_ENCABEZADO.Controls.Add(this.Cbo_Id_Entrevista);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_Cant_Pregunta);
            this.GB_ENCABEZADO.Controls.Add(this.DTP_FECHA_ENTREVISTA);
            this.GB_ENCABEZADO.Controls.Add(this.CBO_DPI_SOLICITANTE);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_P);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_Fecha);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_DPI);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_IDentrevista);
            this.GB_ENCABEZADO.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ENCABEZADO.Location = new System.Drawing.Point(17, 85);
            this.GB_ENCABEZADO.Name = "GB_ENCABEZADO";
            this.GB_ENCABEZADO.Size = new System.Drawing.Size(830, 114);
            this.GB_ENCABEZADO.TabIndex = 2;
            this.GB_ENCABEZADO.TabStop = false;
            this.GB_ENCABEZADO.Text = "ENCABEZADO";
            // 
            // Cbo_Id_Entrevista
            // 
            this.Cbo_Id_Entrevista.FormattingEnabled = true;
            this.Cbo_Id_Entrevista.Location = new System.Drawing.Point(129, 29);
            this.Cbo_Id_Entrevista.Name = "Cbo_Id_Entrevista";
            this.Cbo_Id_Entrevista.Size = new System.Drawing.Size(162, 27);
            this.Cbo_Id_Entrevista.TabIndex = 8;
            // 
            // Lbl_Cant_Pregunta
            // 
            this.Lbl_Cant_Pregunta.AutoSize = true;
            this.Lbl_Cant_Pregunta.Location = new System.Drawing.Point(641, 75);
            this.Lbl_Cant_Pregunta.Name = "Lbl_Cant_Pregunta";
            this.Lbl_Cant_Pregunta.Size = new System.Drawing.Size(18, 19);
            this.Lbl_Cant_Pregunta.TabIndex = 7;
            this.Lbl_Cant_Pregunta.Text = "0";
            // 
            // DTP_FECHA_ENTREVISTA
            // 
            this.DTP_FECHA_ENTREVISTA.Location = new System.Drawing.Point(607, 34);
            this.DTP_FECHA_ENTREVISTA.Name = "DTP_FECHA_ENTREVISTA";
            this.DTP_FECHA_ENTREVISTA.Size = new System.Drawing.Size(200, 26);
            this.DTP_FECHA_ENTREVISTA.TabIndex = 6;
            // 
            // CBO_DPI_SOLICITANTE
            // 
            this.CBO_DPI_SOLICITANTE.FormattingEnabled = true;
            this.CBO_DPI_SOLICITANTE.Location = new System.Drawing.Point(129, 75);
            this.CBO_DPI_SOLICITANTE.MaxLength = 13;
            this.CBO_DPI_SOLICITANTE.Name = "CBO_DPI_SOLICITANTE";
            this.CBO_DPI_SOLICITANTE.Size = new System.Drawing.Size(162, 27);
            this.CBO_DPI_SOLICITANTE.TabIndex = 5;
            // 
            // Lbl_P
            // 
            this.Lbl_P.AutoSize = true;
            this.Lbl_P.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_P.Location = new System.Drawing.Point(488, 75);
            this.Lbl_P.Name = "Lbl_P";
            this.Lbl_P.Size = new System.Drawing.Size(146, 16);
            this.Lbl_P.TabIndex = 3;
            this.Lbl_P.Text = "Cantidad De Preguntas:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(488, 34);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(112, 16);
            this.Lbl_Fecha.TabIndex = 2;
            this.Lbl_Fecha.Text = "Fecha_Entrevista:";
            // 
            // Lbl_DPI
            // 
            this.Lbl_DPI.AutoSize = true;
            this.Lbl_DPI.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DPI.Location = new System.Drawing.Point(24, 75);
            this.Lbl_DPI.Name = "Lbl_DPI";
            this.Lbl_DPI.Size = new System.Drawing.Size(98, 16);
            this.Lbl_DPI.TabIndex = 1;
            this.Lbl_DPI.Text = "DPI_Solicitante:";
            // 
            // Lbl_IDentrevista
            // 
            this.Lbl_IDentrevista.AutoSize = true;
            this.Lbl_IDentrevista.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDentrevista.Location = new System.Drawing.Point(24, 34);
            this.Lbl_IDentrevista.Name = "Lbl_IDentrevista";
            this.Lbl_IDentrevista.Size = new System.Drawing.Size(89, 16);
            this.Lbl_IDentrevista.TabIndex = 0;
            this.Lbl_IDentrevista.Text = "Id_Entrevista:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(715, 673);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(132, 80);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(305, 9);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Cancelar.TabIndex = 5;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(669, 9);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(86, 80);
            this.Btn_Ayuda.TabIndex = 6;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(577, 9);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(86, 80);
            this.Btn_Reporte.TabIndex = 7;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(397, 9);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Modificar.TabIndex = 8;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Entrevista
            // 
            this.Btn_Agregar_Entrevista.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Entrevista.Image")));
            this.Btn_Agregar_Entrevista.Location = new System.Drawing.Point(146, 9);
            this.Btn_Agregar_Entrevista.Name = "Btn_Agregar_Entrevista";
            this.Btn_Agregar_Entrevista.Size = new System.Drawing.Size(132, 80);
            this.Btn_Agregar_Entrevista.TabIndex = 3;
            this.Btn_Agregar_Entrevista.Text = "ADD ENTREVISTA";
            this.Btn_Agregar_Entrevista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Entrevista.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Entrevista.Click += new System.EventHandler(this.Btn_Agregar_Entrevista_Click);
            // 
            // Btn_Agregar_Pregunta
            // 
            this.Btn_Agregar_Pregunta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Pregunta.Image")));
            this.Btn_Agregar_Pregunta.Location = new System.Drawing.Point(20, 19);
            this.Btn_Agregar_Pregunta.Name = "Btn_Agregar_Pregunta";
            this.Btn_Agregar_Pregunta.Size = new System.Drawing.Size(116, 80);
            this.Btn_Agregar_Pregunta.TabIndex = 9;
            this.Btn_Agregar_Pregunta.Text = "AGREGAR";
            this.Btn_Agregar_Pregunta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Pregunta.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Pregunta.Click += new System.EventHandler(this.Btn_Agregar_Pregunta_Click);
            // 
            // DGV_PREGUNTAS_ENTREVISTA
            // 
            this.DGV_PREGUNTAS_ENTREVISTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PREGUNTAS_ENTREVISTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPregunta,
            this.Enunciado_Pregunta,
            this.Nivel_Pregunta,
            this.Respuesta_Aceptable});
            this.DGV_PREGUNTAS_ENTREVISTA.Location = new System.Drawing.Point(20, 105);
            this.DGV_PREGUNTAS_ENTREVISTA.Name = "DGV_PREGUNTAS_ENTREVISTA";
            this.DGV_PREGUNTAS_ENTREVISTA.Size = new System.Drawing.Size(789, 310);
            this.DGV_PREGUNTAS_ENTREVISTA.TabIndex = 10;
            // 
            // IdPregunta
            // 
            this.IdPregunta.HeaderText = "IdPregunta";
            this.IdPregunta.Name = "IdPregunta";
            // 
            // Enunciado_Pregunta
            // 
            this.Enunciado_Pregunta.HeaderText = "Enunciado_Pregunta";
            this.Enunciado_Pregunta.Name = "Enunciado_Pregunta";
            // 
            // Nivel_Pregunta
            // 
            this.Nivel_Pregunta.HeaderText = "Nivel_Pregunta";
            this.Nivel_Pregunta.Name = "Nivel_Pregunta";
            // 
            // Respuesta_Aceptable
            // 
            this.Respuesta_Aceptable.HeaderText = "Respuesta_Aceptable";
            this.Respuesta_Aceptable.Name = "Respuesta_Aceptable";
            // 
            // ChB_Estado
            // 
            this.ChB_Estado.AutoSize = true;
            this.ChB_Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChB_Estado.Location = new System.Drawing.Point(84, 30);
            this.ChB_Estado.Name = "ChB_Estado";
            this.ChB_Estado.Size = new System.Drawing.Size(97, 20);
            this.ChB_Estado.TabIndex = 12;
            this.ChB_Estado.Text = "APROBADO";
            this.ChB_Estado.UseVisualStyleBackColor = true;
            this.ChB_Estado.CheckedChanged += new System.EventHandler(this.ChB_Estado_CheckedChanged);
            // 
            // ChB_Rechazado
            // 
            this.ChB_Rechazado.AutoSize = true;
            this.ChB_Rechazado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChB_Rechazado.Location = new System.Drawing.Point(307, 30);
            this.ChB_Rechazado.Name = "ChB_Rechazado";
            this.ChB_Rechazado.Size = new System.Drawing.Size(106, 20);
            this.ChB_Rechazado.TabIndex = 13;
            this.ChB_Rechazado.Text = "RECHAZADO";
            this.ChB_Rechazado.UseVisualStyleBackColor = true;
            this.ChB_Rechazado.CheckedChanged += new System.EventHandler(this.ChB_Rechazado_CheckedChanged);
            // 
            // GB_ESTADO
            // 
            this.GB_ESTADO.Controls.Add(this.ChB_Estado);
            this.GB_ESTADO.Controls.Add(this.ChB_Rechazado);
            this.GB_ESTADO.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ESTADO.Location = new System.Drawing.Point(146, 673);
            this.GB_ESTADO.Name = "GB_ESTADO";
            this.GB_ESTADO.Size = new System.Drawing.Size(495, 68);
            this.GB_ESTADO.TabIndex = 14;
            this.GB_ESTADO.TabStop = false;
            this.GB_ESTADO.Text = "ESTADO ENTREVISTA";
            // 
            // GB_PREGUNTAS
            // 
            this.GB_PREGUNTAS.Controls.Add(this.BTN_LIMPIAR_PREG);
            this.GB_PREGUNTAS.Controls.Add(this.Btn_Remover_Pregunta);
            this.GB_PREGUNTAS.Controls.Add(this.Btn_Agregar_Pregunta);
            this.GB_PREGUNTAS.Controls.Add(this.DGV_PREGUNTAS_ENTREVISTA);
            this.GB_PREGUNTAS.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_PREGUNTAS.Location = new System.Drawing.Point(17, 220);
            this.GB_PREGUNTAS.Name = "GB_PREGUNTAS";
            this.GB_PREGUNTAS.Size = new System.Drawing.Size(830, 433);
            this.GB_PREGUNTAS.TabIndex = 15;
            this.GB_PREGUNTAS.TabStop = false;
            this.GB_PREGUNTAS.Text = "PREGUNTAS REALIZADAS";
            // 
            // BTN_LIMPIAR_PREG
            // 
            this.BTN_LIMPIAR_PREG.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_PREG.Image")));
            this.BTN_LIMPIAR_PREG.Location = new System.Drawing.Point(261, 19);
            this.BTN_LIMPIAR_PREG.Name = "BTN_LIMPIAR_PREG";
            this.BTN_LIMPIAR_PREG.Size = new System.Drawing.Size(113, 80);
            this.BTN_LIMPIAR_PREG.TabIndex = 12;
            this.BTN_LIMPIAR_PREG.Text = "LIMPIAR";
            this.BTN_LIMPIAR_PREG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_PREG.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_PREG.Click += new System.EventHandler(this.BTN_LIMPIAR_PREG_Click);
            // 
            // Btn_Remover_Pregunta
            // 
            this.Btn_Remover_Pregunta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Pregunta.Image")));
            this.Btn_Remover_Pregunta.Location = new System.Drawing.Point(142, 19);
            this.Btn_Remover_Pregunta.Name = "Btn_Remover_Pregunta";
            this.Btn_Remover_Pregunta.Size = new System.Drawing.Size(113, 80);
            this.Btn_Remover_Pregunta.TabIndex = 11;
            this.Btn_Remover_Pregunta.Text = "REMOVER";
            this.Btn_Remover_Pregunta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Pregunta.UseVisualStyleBackColor = true;
            this.Btn_Remover_Pregunta.Click += new System.EventHandler(this.Btn_Remover_Pregunta_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(761, 9);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 80);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // BTN_LIMPIAR_ENCABEZADO
            // 
            this.BTN_LIMPIAR_ENCABEZADO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_ENCABEZADO.Image")));
            this.BTN_LIMPIAR_ENCABEZADO.Location = new System.Drawing.Point(488, 9);
            this.BTN_LIMPIAR_ENCABEZADO.Name = "BTN_LIMPIAR_ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.Size = new System.Drawing.Size(86, 80);
            this.BTN_LIMPIAR_ENCABEZADO.TabIndex = 17;
            this.BTN_LIMPIAR_ENCABEZADO.Text = "LIMPIAR ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_ENCABEZADO.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_ENCABEZADO.Click += new System.EventHandler(this.BTN_LIMPIAR_ENCABEZADO_Click);
            // 
            // Frm_CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 769);
            this.Controls.Add(this.BTN_LIMPIAR_ENCABEZADO);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.GB_PREGUNTAS);
            this.Controls.Add(this.GB_ESTADO);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.Btn_Agregar_Entrevista);
            this.Controls.Add(this.GB_ENCABEZADO);
            this.Controls.Add(this.label1);
            this.Name = "Frm_CheckList";
            this.Text = "Frm_CheckList";
            this.GB_ENCABEZADO.ResumeLayout(false);
            this.GB_ENCABEZADO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PREGUNTAS_ENTREVISTA)).EndInit();
            this.GB_ESTADO.ResumeLayout(false);
            this.GB_ESTADO.PerformLayout();
            this.GB_PREGUNTAS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_ENCABEZADO;
        private System.Windows.Forms.Label Lbl_IDentrevista;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_DPI;
        private System.Windows.Forms.Label Lbl_Cant_Pregunta;
        private System.Windows.Forms.DateTimePicker DTP_FECHA_ENTREVISTA;
        private System.Windows.Forms.ComboBox CBO_DPI_SOLICITANTE;
        private System.Windows.Forms.Label Lbl_P;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar_Entrevista;
        private System.Windows.Forms.Button Btn_Agregar_Pregunta;
        private System.Windows.Forms.DataGridView DGV_PREGUNTAS_ENTREVISTA;
        private System.Windows.Forms.CheckBox ChB_Estado;
        private System.Windows.Forms.CheckBox ChB_Rechazado;
        private System.Windows.Forms.GroupBox GB_ESTADO;
        private System.Windows.Forms.GroupBox GB_PREGUNTAS;
        private System.Windows.Forms.Button Btn_Remover_Pregunta;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enunciado_Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_Pregunta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Respuesta_Aceptable;
        private System.Windows.Forms.Button BTN_LIMPIAR_PREG;
        private System.Windows.Forms.ComboBox Cbo_Id_Entrevista;
        private System.Windows.Forms.Button BTN_LIMPIAR_ENCABEZADO;
    }
}