
namespace Capa_Vista_Asignacion
{
    partial class Frm_Asignacion_Cita
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Gpb_Datos = new System.Windows.Forms.GroupBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Empleado = new System.Windows.Forms.TextBox();
            this.Lbl_NoCita = new System.Windows.Forms.Label();
            this.Cbo_Citas = new System.Windows.Forms.ComboBox();
            this.Btn_Asignar = new System.Windows.Forms.Button();
            this.Btn_Asignaciones = new System.Windows.Forms.Button();
            this.Gpb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(250, 21);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(312, 38);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Asignación de Citas";
            // 
            // Gpb_Datos
            // 
            this.Gpb_Datos.Controls.Add(this.Btn_Asignaciones);
            this.Gpb_Datos.Controls.Add(this.Btn_Asignar);
            this.Gpb_Datos.Controls.Add(this.Cbo_Citas);
            this.Gpb_Datos.Controls.Add(this.Lbl_NoCita);
            this.Gpb_Datos.Controls.Add(this.Txt_Empleado);
            this.Gpb_Datos.Controls.Add(this.Lbl_Nombre);
            this.Gpb_Datos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos.Location = new System.Drawing.Point(166, 77);
            this.Gpb_Datos.Name = "Gpb_Datos";
            this.Gpb_Datos.Size = new System.Drawing.Size(472, 322);
            this.Gpb_Datos.TabIndex = 1;
            this.Gpb_Datos.TabStop = false;
            this.Gpb_Datos.Text = "Datos de Asignación";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(23, 49);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(183, 20);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Empleado Encargado:";
            // 
            // Txt_Empleado
            // 
            this.Txt_Empleado.Location = new System.Drawing.Point(27, 85);
            this.Txt_Empleado.Name = "Txt_Empleado";
            this.Txt_Empleado.Size = new System.Drawing.Size(399, 27);
            this.Txt_Empleado.TabIndex = 1;
            // 
            // Lbl_NoCita
            // 
            this.Lbl_NoCita.AutoSize = true;
            this.Lbl_NoCita.Location = new System.Drawing.Point(23, 152);
            this.Lbl_NoCita.Name = "Lbl_NoCita";
            this.Lbl_NoCita.Size = new System.Drawing.Size(211, 20);
            this.Lbl_NoCita.TabIndex = 2;
            this.Lbl_NoCita.Text = "Seleccione el No. de Cita:";
            // 
            // Cbo_Citas
            // 
            this.Cbo_Citas.FormattingEnabled = true;
            this.Cbo_Citas.Location = new System.Drawing.Point(27, 184);
            this.Cbo_Citas.Name = "Cbo_Citas";
            this.Cbo_Citas.Size = new System.Drawing.Size(399, 28);
            this.Cbo_Citas.TabIndex = 3;
            // 
            // Btn_Asignar
            // 
            this.Btn_Asignar.Location = new System.Drawing.Point(27, 241);
            this.Btn_Asignar.Name = "Btn_Asignar";
            this.Btn_Asignar.Size = new System.Drawing.Size(186, 32);
            this.Btn_Asignar.TabIndex = 4;
            this.Btn_Asignar.Text = "Asignar Cita";
            this.Btn_Asignar.UseVisualStyleBackColor = true;
            // 
            // Btn_Asignaciones
            // 
            this.Btn_Asignaciones.Location = new System.Drawing.Point(240, 241);
            this.Btn_Asignaciones.Name = "Btn_Asignaciones";
            this.Btn_Asignaciones.Size = new System.Drawing.Size(186, 32);
            this.Btn_Asignaciones.TabIndex = 5;
            this.Btn_Asignaciones.Text = "Ver Asignaciones";
            this.Btn_Asignaciones.UseVisualStyleBackColor = true;
            this.Btn_Asignaciones.Click += new System.EventHandler(this.Btn_Asignaciones_Click);
            // 
            // Frm_Asignacion_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 470);
            this.Controls.Add(this.Gpb_Datos);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Asignacion_Cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Asignacion_Cita";
            this.Load += new System.EventHandler(this.Frm_Asignacion_Cita_Load);
            this.Gpb_Datos.ResumeLayout(false);
            this.Gpb_Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.GroupBox Gpb_Datos;
        private System.Windows.Forms.Button Btn_Asignaciones;
        private System.Windows.Forms.Button Btn_Asignar;
        private System.Windows.Forms.ComboBox Cbo_Citas;
        private System.Windows.Forms.Label Lbl_NoCita;
        private System.Windows.Forms.TextBox Txt_Empleado;
        private System.Windows.Forms.Label Lbl_Nombre;
    }
}