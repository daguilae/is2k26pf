
namespace Capa_Vista_Comprobantes
{
    partial class Frm_Comprobante_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Comprobante_Compra));
            this.Dvg_Comprobante_Compra = new System.Windows.Forms.DataGridView();
            this.GB_Ventas = new System.Windows.Forms.GroupBox();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Receptor = new System.Windows.Forms.TextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Hora_Entrega = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Id_Proveedor = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Comprobante_Compra = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Entrega_Comprobante_Compra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Limpiar_Comprobante = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Crear_Comprobante = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Gb_Detalle_Entrega = new System.Windows.Forms.GroupBox();
            this.Dgv_Detalle_Entrega = new System.Windows.Forms.DataGridView();
            this.Btn_Ver_Detalle = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Comprobante_Compra)).BeginInit();
            this.GB_Ventas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Gb_Detalle_Entrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Entrega)).BeginInit();
            this.SuspendLayout();
            // 
            // Dvg_Comprobante_Compra
            // 
            this.Dvg_Comprobante_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Comprobante_Compra.Location = new System.Drawing.Point(21, 146);
            this.Dvg_Comprobante_Compra.Name = "Dvg_Comprobante_Compra";
            this.Dvg_Comprobante_Compra.Size = new System.Drawing.Size(1152, 66);
            this.Dvg_Comprobante_Compra.TabIndex = 60;
            this.Dvg_Comprobante_Compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Comprobante_Compra_CellContentClick);
            // 
            // GB_Ventas
            // 
            this.GB_Ventas.Controls.Add(this.Dvg_Comprobante_Compra);
            this.GB_Ventas.Controls.Add(this.Txt_Observaciones);
            this.GB_Ventas.Controls.Add(this.Txt_Nombre_Receptor);
            this.GB_Ventas.Controls.Add(this.Cbo_Estado);
            this.GB_Ventas.Controls.Add(this.Dtp_Fecha_Hora_Entrega);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Proveedor);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Comprobante_Compra);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Entrega_Comprobante_Compra);
            this.GB_Ventas.Controls.Add(this.label3);
            this.GB_Ventas.Controls.Add(this.label8);
            this.GB_Ventas.Controls.Add(this.label2);
            this.GB_Ventas.Controls.Add(this.label7);
            this.GB_Ventas.Controls.Add(this.label4);
            this.GB_Ventas.Controls.Add(this.label6);
            this.GB_Ventas.Controls.Add(this.label5);
            this.GB_Ventas.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Ventas.Location = new System.Drawing.Point(45, 191);
            this.GB_Ventas.Name = "GB_Ventas";
            this.GB_Ventas.Size = new System.Drawing.Size(1196, 235);
            this.GB_Ventas.TabIndex = 59;
            this.GB_Ventas.TabStop = false;
            this.GB_Ventas.Text = "Comprobante Compra";
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Observaciones.ForeColor = System.Drawing.Color.Black;
            this.Txt_Observaciones.Location = new System.Drawing.Point(980, 68);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(193, 23);
            this.Txt_Observaciones.TabIndex = 54;
            // 
            // Txt_Nombre_Receptor
            // 
            this.Txt_Nombre_Receptor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre_Receptor.Location = new System.Drawing.Point(481, 95);
            this.Txt_Nombre_Receptor.Name = "Txt_Nombre_Receptor";
            this.Txt_Nombre_Receptor.Size = new System.Drawing.Size(139, 23);
            this.Txt_Nombre_Receptor.TabIndex = 53;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(741, 42);
            this.Cbo_Estado.MaxLength = 13;
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(123, 24);
            this.Cbo_Estado.TabIndex = 52;
            // 
            // Dtp_Fecha_Hora_Entrega
            // 
            this.Dtp_Fecha_Hora_Entrega.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Fecha_Hora_Entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Hora_Entrega.Location = new System.Drawing.Point(789, 95);
            this.Dtp_Fecha_Hora_Entrega.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Hora_Entrega.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Hora_Entrega.Name = "Dtp_Fecha_Hora_Entrega";
            this.Dtp_Fecha_Hora_Entrega.Size = new System.Drawing.Size(128, 23);
            this.Dtp_Fecha_Hora_Entrega.TabIndex = 51;
            // 
            // Cbo_Id_Proveedor
            // 
            this.Cbo_Id_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Id_Proveedor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Proveedor.FormattingEnabled = true;
            this.Cbo_Id_Proveedor.Location = new System.Drawing.Point(440, 42);
            this.Cbo_Id_Proveedor.Name = "Cbo_Id_Proveedor";
            this.Cbo_Id_Proveedor.Size = new System.Drawing.Size(122, 24);
            this.Cbo_Id_Proveedor.TabIndex = 50;
            // 
            // Cbo_Id_Comprobante_Compra
            // 
            this.Cbo_Id_Comprobante_Compra.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Comprobante_Compra.FormattingEnabled = true;
            this.Cbo_Id_Comprobante_Compra.Location = new System.Drawing.Point(129, 42);
            this.Cbo_Id_Comprobante_Compra.Name = "Cbo_Id_Comprobante_Compra";
            this.Cbo_Id_Comprobante_Compra.Size = new System.Drawing.Size(122, 24);
            this.Cbo_Id_Comprobante_Compra.TabIndex = 49;
            // 
            // Cbo_Id_Entrega_Comprobante_Compra
            // 
            this.Cbo_Id_Entrega_Comprobante_Compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Id_Entrega_Comprobante_Compra.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Id_Entrega_Comprobante_Compra.FormattingEnabled = true;
            this.Cbo_Id_Entrega_Comprobante_Compra.Location = new System.Drawing.Point(144, 88);
            this.Cbo_Id_Entrega_Comprobante_Compra.MaxLength = 13;
            this.Cbo_Id_Entrega_Comprobante_Compra.Name = "Cbo_Id_Entrega_Comprobante_Compra";
            this.Cbo_Id_Entrega_Comprobante_Compra.Size = new System.Drawing.Size(176, 24);
            this.Cbo_Id_Entrega_Comprobante_Compra.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Id Entrega Compra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1024, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "Observaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Id Comprobante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(661, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre Receptor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(661, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "Fecha Hora Entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 44;
            this.label5.Text = "Proveedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 80);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comprobante de Compra";
            // 
            // Btn_Limpiar_Comprobante
            // 
            this.Btn_Limpiar_Comprobante.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Comprobante.Image")));
            this.Btn_Limpiar_Comprobante.Location = new System.Drawing.Point(730, 87);
            this.Btn_Limpiar_Comprobante.Name = "Btn_Limpiar_Comprobante";
            this.Btn_Limpiar_Comprobante.Size = new System.Drawing.Size(86, 80);
            this.Btn_Limpiar_Comprobante.TabIndex = 56;
            this.Btn_Limpiar_Comprobante.Text = "LIMPIAR COMPROBANTE";
            this.Btn_Limpiar_Comprobante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Comprobante.UseVisualStyleBackColor = true;
            this.Btn_Limpiar_Comprobante.Click += new System.EventHandler(this.Btn_Limpiar_Comprobante_Click_1);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1077, 89);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 80);
            this.Btn_Salir.TabIndex = 55;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click_1);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(538, 87);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Modificar.TabIndex = 54;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(823, 87);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(86, 80);
            this.Btn_Reporte.TabIndex = 53;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(915, 87);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(86, 80);
            this.Btn_Ayuda.TabIndex = 52;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(446, 89);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Cancelar.TabIndex = 51;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Crear_Comprobante
            // 
            this.Btn_Crear_Comprobante.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Crear_Comprobante.Image")));
            this.Btn_Crear_Comprobante.Location = new System.Drawing.Point(26, 89);
            this.Btn_Crear_Comprobante.Name = "Btn_Crear_Comprobante";
            this.Btn_Crear_Comprobante.Size = new System.Drawing.Size(132, 80);
            this.Btn_Crear_Comprobante.TabIndex = 50;
            this.Btn_Crear_Comprobante.Text = "ADD COMPROBANTE";
            this.Btn_Crear_Comprobante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Crear_Comprobante.UseVisualStyleBackColor = true;
            this.Btn_Crear_Comprobante.Click += new System.EventHandler(this.Btn_Crear_Comprobante_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(298, 89);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(132, 80);
            this.Btn_Guardar.TabIndex = 61;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Gb_Detalle_Entrega
            // 
            this.Gb_Detalle_Entrega.Controls.Add(this.Dgv_Detalle_Entrega);
            this.Gb_Detalle_Entrega.Controls.Add(this.Btn_Ver_Detalle);
            this.Gb_Detalle_Entrega.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Detalle_Entrega.Location = new System.Drawing.Point(45, 432);
            this.Gb_Detalle_Entrega.Name = "Gb_Detalle_Entrega";
            this.Gb_Detalle_Entrega.Size = new System.Drawing.Size(1196, 120);
            this.Gb_Detalle_Entrega.TabIndex = 61;
            this.Gb_Detalle_Entrega.TabStop = false;
            this.Gb_Detalle_Entrega.Text = "Detalle";
            // 
            // Dgv_Detalle_Entrega
            // 
            this.Dgv_Detalle_Entrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Entrega.Location = new System.Drawing.Point(21, 29);
            this.Dgv_Detalle_Entrega.Name = "Dgv_Detalle_Entrega";
            this.Dgv_Detalle_Entrega.Size = new System.Drawing.Size(1035, 64);
            this.Dgv_Detalle_Entrega.TabIndex = 1;
            // 
            // Btn_Ver_Detalle
            // 
            this.Btn_Ver_Detalle.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_Detalle.Location = new System.Drawing.Point(1090, 41);
            this.Btn_Ver_Detalle.Name = "Btn_Ver_Detalle";
            this.Btn_Ver_Detalle.Size = new System.Drawing.Size(83, 41);
            this.Btn_Ver_Detalle.TabIndex = 0;
            this.Btn_Ver_Detalle.Text = "Ver Detalle";
            this.Btn_Ver_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Ver_Detalle.Click += new System.EventHandler(this.Btn_Ver_Detalle_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(630, 89);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(94, 78);
            this.Btn_Eliminar.TabIndex = 62;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Frm_Comprobante_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1267, 741);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gb_Detalle_Entrega);
            this.Controls.Add(this.GB_Ventas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Limpiar_Comprobante);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Crear_Comprobante);
            this.Name = "Frm_Comprobante_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante de Compra";
            this.Load += new System.EventHandler(this.Frm_Comprobante_Compra_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Comprobante_Compra)).EndInit();
            this.GB_Ventas.ResumeLayout(false);
            this.GB_Ventas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gb_Detalle_Entrega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Entrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dvg_Comprobante_Compra;
        private System.Windows.Forms.GroupBox GB_Ventas;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.TextBox Txt_Nombre_Receptor;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Hora_Entrega;
        private System.Windows.Forms.ComboBox Cbo_Id_Proveedor;
        private System.Windows.Forms.ComboBox Cbo_Id_Comprobante_Compra;
        private System.Windows.Forms.ComboBox Cbo_Id_Entrega_Comprobante_Compra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Limpiar_Comprobante;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Crear_Comprobante;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.GroupBox Gb_Detalle_Entrega;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Entrega;
        private System.Windows.Forms.Button Btn_Ver_Detalle;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}