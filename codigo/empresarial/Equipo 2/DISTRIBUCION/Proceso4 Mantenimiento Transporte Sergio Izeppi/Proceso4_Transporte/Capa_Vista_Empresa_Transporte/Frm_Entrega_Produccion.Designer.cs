
namespace Capa_Vista_Empresa_Transporte
{
    partial class Frm_Entrega_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Entrega_Produccion));
            this.Dgv_Entrega_Produccion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Txt_ID_Produccion = new System.Windows.Forms.TextBox();
            this.Cbo_Estado_Entrega = new System.Windows.Forms.ComboBox();
            this.Lbl_Tipo_Transporte = new System.Windows.Forms.Label();
            this.Lbl_ID_Empresa = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Piloto = new System.Windows.Forms.Label();
            this.Txt_ID_Transporte = new System.Windows.Forms.TextBox();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Lbl_Estado_Transporte = new System.Windows.Forms.Label();
            this.Lbl_Capacidad = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Entrega_Produccion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Entrega_Produccion
            // 
            this.Dgv_Entrega_Produccion.AllowUserToAddRows = false;
            this.Dgv_Entrega_Produccion.AllowUserToDeleteRows = false;
            this.Dgv_Entrega_Produccion.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_Entrega_Produccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Entrega_Produccion.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dgv_Entrega_Produccion.Location = new System.Drawing.Point(17, 357);
            this.Dgv_Entrega_Produccion.Name = "Dgv_Entrega_Produccion";
            this.Dgv_Entrega_Produccion.ReadOnly = true;
            this.Dgv_Entrega_Produccion.RowHeadersWidth = 51;
            this.Dgv_Entrega_Produccion.RowTemplate.Height = 24;
            this.Dgv_Entrega_Produccion.Size = new System.Drawing.Size(1083, 260);
            this.Dgv_Entrega_Produccion.TabIndex = 165;
            this.Dgv_Entrega_Produccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Entrega_Produccion_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTP_Fecha);
            this.groupBox1.Controls.Add(this.Txt_ID_Produccion);
            this.groupBox1.Controls.Add(this.Cbo_Estado_Entrega);
            this.groupBox1.Controls.Add(this.Lbl_Tipo_Transporte);
            this.groupBox1.Controls.Add(this.Lbl_ID_Empresa);
            this.groupBox1.Controls.Add(this.Lbl_Nombre_Piloto);
            this.groupBox1.Controls.Add(this.Txt_ID_Transporte);
            this.groupBox1.Controls.Add(this.Txt_Direccion);
            this.groupBox1.Controls.Add(this.Lbl_Estado_Transporte);
            this.groupBox1.Controls.Add(this.Lbl_Capacidad);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1083, 179);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Entrega";
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Location = new System.Drawing.Point(13, 132);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(220, 27);
            this.DTP_Fecha.TabIndex = 157;
            // 
            // Txt_ID_Produccion
            // 
            this.Txt_ID_Produccion.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_ID_Produccion.Location = new System.Drawing.Point(13, 59);
            this.Txt_ID_Produccion.Name = "Txt_ID_Produccion";
            this.Txt_ID_Produccion.Size = new System.Drawing.Size(220, 27);
            this.Txt_ID_Produccion.TabIndex = 143;
            // 
            // Cbo_Estado_Entrega
            // 
            this.Cbo_Estado_Entrega.FormattingEnabled = true;
            this.Cbo_Estado_Entrega.Location = new System.Drawing.Point(416, 133);
            this.Cbo_Estado_Entrega.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Estado_Entrega.Name = "Cbo_Estado_Entrega";
            this.Cbo_Estado_Entrega.Size = new System.Drawing.Size(220, 28);
            this.Cbo_Estado_Entrega.TabIndex = 154;
            // 
            // Lbl_Tipo_Transporte
            // 
            this.Lbl_Tipo_Transporte.AutoSize = true;
            this.Lbl_Tipo_Transporte.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Transporte.Location = new System.Drawing.Point(790, 36);
            this.Lbl_Tipo_Transporte.Name = "Lbl_Tipo_Transporte";
            this.Lbl_Tipo_Transporte.Size = new System.Drawing.Size(176, 20);
            this.Lbl_Tipo_Transporte.TabIndex = 142;
            this.Lbl_Tipo_Transporte.Text = "Direccion de Entrega";
            // 
            // Lbl_ID_Empresa
            // 
            this.Lbl_ID_Empresa.AutoSize = true;
            this.Lbl_ID_Empresa.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Empresa.Location = new System.Drawing.Point(9, 35);
            this.Lbl_ID_Empresa.Name = "Lbl_ID_Empresa";
            this.Lbl_ID_Empresa.Size = new System.Drawing.Size(199, 20);
            this.Lbl_ID_Empresa.TabIndex = 144;
            this.Lbl_ID_Empresa.Text = "ID Orden de Produccion";
            // 
            // Lbl_Nombre_Piloto
            // 
            this.Lbl_Nombre_Piloto.AutoSize = true;
            this.Lbl_Nombre_Piloto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Piloto.Location = new System.Drawing.Point(9, 109);
            this.Lbl_Nombre_Piloto.Name = "Lbl_Nombre_Piloto";
            this.Lbl_Nombre_Piloto.Size = new System.Drawing.Size(146, 20);
            this.Lbl_Nombre_Piloto.TabIndex = 150;
            this.Lbl_Nombre_Piloto.Text = "Fecha de Entrega";
            // 
            // Txt_ID_Transporte
            // 
            this.Txt_ID_Transporte.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_ID_Transporte.Location = new System.Drawing.Point(416, 59);
            this.Txt_ID_Transporte.Name = "Txt_ID_Transporte";
            this.Txt_ID_Transporte.Size = new System.Drawing.Size(220, 27);
            this.Txt_ID_Transporte.TabIndex = 145;
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_Direccion.Location = new System.Drawing.Point(794, 59);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(220, 27);
            this.Txt_Direccion.TabIndex = 149;
            // 
            // Lbl_Estado_Transporte
            // 
            this.Lbl_Estado_Transporte.AutoSize = true;
            this.Lbl_Estado_Transporte.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Transporte.Location = new System.Drawing.Point(412, 109);
            this.Lbl_Estado_Transporte.Name = "Lbl_Estado_Transporte";
            this.Lbl_Estado_Transporte.Size = new System.Drawing.Size(170, 20);
            this.Lbl_Estado_Transporte.TabIndex = 146;
            this.Lbl_Estado_Transporte.Text = "Estado de la Entrega";
            // 
            // Lbl_Capacidad
            // 
            this.Lbl_Capacidad.AutoSize = true;
            this.Lbl_Capacidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Capacidad.Location = new System.Drawing.Point(414, 35);
            this.Lbl_Capacidad.Name = "Lbl_Capacidad";
            this.Lbl_Capacidad.Size = new System.Drawing.Size(145, 20);
            this.Lbl_Capacidad.TabIndex = 148;
            this.Lbl_Capacidad.Text = "ID del Transporte";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 64);
            this.panel2.TabIndex = 157;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "720 - ENTREGA DE PRODUCCION";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(574, 74);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(110, 82);
            this.Btn_Eliminar.TabIndex = 200;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(336, 74);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(111, 82);
            this.Btn_Guardar.TabIndex = 199;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(920, 74);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(93, 82);
            this.Btn_Salir.TabIndex = 198;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(217, 74);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(111, 82);
            this.Btn_Modificar.TabIndex = 197;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(692, 74);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(98, 82);
            this.Btn_Reporte.TabIndex = 196;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(811, 74);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(90, 82);
            this.Btn_Ayuda.TabIndex = 195;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(455, 74);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(111, 82);
            this.Btn_Cancelar.TabIndex = 194;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar.Image")));
            this.Btn_Ingresar.Location = new System.Drawing.Point(92, 74);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(109, 82);
            this.Btn_Ingresar.TabIndex = 193;
            this.Btn_Ingresar.Text = "INGRESAR";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Frm_Entrega_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 639);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.Dgv_Entrega_Produccion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Entrega_Produccion";
            this.Text = "Entrega de Produccion";
            this.Load += new System.EventHandler(this.Frm_Entrega_Produccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Entrega_Produccion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Entrega_Produccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_ID_Produccion;
        private System.Windows.Forms.ComboBox Cbo_Estado_Entrega;
        private System.Windows.Forms.Label Lbl_Tipo_Transporte;
        private System.Windows.Forms.Label Lbl_ID_Empresa;
        private System.Windows.Forms.Label Lbl_Nombre_Piloto;
        private System.Windows.Forms.TextBox Txt_ID_Transporte;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label Lbl_Estado_Transporte;
        private System.Windows.Forms.Label Lbl_Capacidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
    }
}