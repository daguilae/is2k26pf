
namespace Capa_Vista_Ventas
{
    partial class Frm_Detalle_Devoluciones_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_Devoluciones_Ventas));
            this.GB_Ventas = new System.Windows.Forms.GroupBox();
            this.Txt_Motivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbo_Id_Venta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cbo_Id_Sucursal = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Sucursal = new System.Windows.Forms.Label();
            this.Cbo_Id_Venta_Dev = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Devolucion = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Id_Cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha_Venta = new System.Windows.Forms.Label();
            this.Lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Lbl_IDDevolucion = new System.Windows.Forms.Label();
            this.Btn_Salir_Dev = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_Eliminar_Devolucion = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_Guardar_Devoluciones = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_buscar_Devolucion = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_Reporte_Dev = new System.Windows.Forms.Button();
            this.Btn_Ingresar_DevVentas = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Devolucion = new System.Windows.Forms.Button();
            this.Btn_Modificar_Devolucion = new System.Windows.Forms.Button();
            this.GB_Detalle_Ventas = new System.Windows.Forms.GroupBox();
            this.Cbo_Unidad_Medida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Limpiar_Detalle = new System.Windows.Forms.Button();
            this.Btn_Remover_Detalle_Dev = new System.Windows.Forms.Button();
            this.Btn_Agregar_Detalle_Dev = new System.Windows.Forms.Button();
            this.Txt_Saldo_Total = new System.Windows.Forms.TextBox();
            this.Cbo_Id_Bodega = new System.Windows.Forms.ComboBox();
            this.lbl_Saldo_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nud_Cant_Prod = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_Id_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.Dgv_Detalle_Devolucion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_Ventas.SuspendLayout();
            this.GB_Detalle_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Devolucion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Ventas
            // 
            this.GB_Ventas.Controls.Add(this.Txt_Motivo);
            this.GB_Ventas.Controls.Add(this.label5);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Venta);
            this.GB_Ventas.Controls.Add(this.label3);
            this.GB_Ventas.Controls.Add(this.Cbo_Estado);
            this.GB_Ventas.Controls.Add(this.Lbl_Estado);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Venta_Dev);
            this.GB_Ventas.Controls.Add(this.Dtp_Fecha_Devolucion);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_IDDevolucion);
            this.GB_Ventas.Font = new System.Drawing.Font("Rockwell", 10F);
            this.GB_Ventas.Location = new System.Drawing.Point(19, 219);
            this.GB_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Name = "GB_Ventas";
            this.GB_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Size = new System.Drawing.Size(1402, 171);
            this.GB_Ventas.TabIndex = 70;
            this.GB_Ventas.TabStop = false;
            this.GB_Ventas.Text = "Encabezado de Devoluciones";
            // 
            // Txt_Motivo
            // 
            this.Txt_Motivo.Location = new System.Drawing.Point(676, 85);
            this.Txt_Motivo.Name = "Txt_Motivo";
            this.Txt_Motivo.Size = new System.Drawing.Size(376, 27);
            this.Txt_Motivo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Motivo:";
            // 
            // Cbo_Id_Venta
            // 
            this.Cbo_Id_Venta.FormattingEnabled = true;
            this.Cbo_Id_Venta.Location = new System.Drawing.Point(383, 32);
            this.Cbo_Id_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Venta.Name = "Cbo_Id_Venta";
            this.Cbo_Id_Venta.Size = new System.Drawing.Size(177, 28);
            this.Cbo_Id_Venta.TabIndex = 20;
            this.Cbo_Id_Venta.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Venta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Venta:";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(1173, 55);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Estado.MaxLength = 13;
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(163, 28);
            this.Cbo_Estado.TabIndex = 18;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(1098, 59);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Estado.TabIndex = 14;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Cbo_Id_Sucursal
            // 
            this.Cbo_Id_Sucursal.FormattingEnabled = true;
            this.Cbo_Id_Sucursal.Location = new System.Drawing.Point(126, 135);
            this.Cbo_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Sucursal.MaxLength = 13;
            this.Cbo_Id_Sucursal.Name = "Cbo_Id_Sucursal";
            this.Cbo_Id_Sucursal.Size = new System.Drawing.Size(319, 28);
            this.Cbo_Id_Sucursal.TabIndex = 13;
            // 
            // Lbl_Id_Sucursal
            // 
            this.Lbl_Id_Sucursal.AutoSize = true;
            this.Lbl_Id_Sucursal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Sucursal.Location = new System.Drawing.Point(18, 139);
            this.Lbl_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Sucursal.Name = "Lbl_Id_Sucursal";
            this.Lbl_Id_Sucursal.Size = new System.Drawing.Size(100, 20);
            this.Lbl_Id_Sucursal.TabIndex = 12;
            this.Lbl_Id_Sucursal.Text = "Id Sucursal:";
            // 
            // Cbo_Id_Venta_Dev
            // 
            this.Cbo_Id_Venta_Dev.FormattingEnabled = true;
            this.Cbo_Id_Venta_Dev.Location = new System.Drawing.Point(139, 33);
            this.Cbo_Id_Venta_Dev.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Venta_Dev.Name = "Cbo_Id_Venta_Dev";
            this.Cbo_Id_Venta_Dev.Size = new System.Drawing.Size(119, 28);
            this.Cbo_Id_Venta_Dev.TabIndex = 8;
            // 
            // Dtp_Fecha_Devolucion
            // 
            this.Dtp_Fecha_Devolucion.Location = new System.Drawing.Point(676, 31);
            this.Dtp_Fecha_Devolucion.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Fecha_Devolucion.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Devolucion.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Devolucion.Name = "Dtp_Fecha_Devolucion";
            this.Dtp_Fecha_Devolucion.Size = new System.Drawing.Size(376, 27);
            this.Dtp_Fecha_Devolucion.TabIndex = 6;
            this.Dtp_Fecha_Devolucion.Value = new System.DateTime(2026, 5, 17, 8, 9, 26, 0);
            // 
            // Cbo_Id_Cliente
            // 
            this.Cbo_Id_Cliente.FormattingEnabled = true;
            this.Cbo_Id_Cliente.Location = new System.Drawing.Point(114, 85);
            this.Cbo_Id_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Cliente.MaxLength = 13;
            this.Cbo_Id_Cliente.Name = "Cbo_Id_Cliente";
            this.Cbo_Id_Cliente.Size = new System.Drawing.Size(388, 28);
            this.Cbo_Id_Cliente.TabIndex = 5;
            // 
            // Lbl_Fecha_Venta
            // 
            this.Lbl_Fecha_Venta.AutoSize = true;
            this.Lbl_Fecha_Venta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Venta.Location = new System.Drawing.Point(580, 34);
            this.Lbl_Fecha_Venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Venta.Name = "Lbl_Fecha_Venta";
            this.Lbl_Fecha_Venta.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Fecha_Venta.TabIndex = 2;
            this.Lbl_Fecha_Venta.Text = "Fecha:";
            // 
            // Lbl_Id_Cliente
            // 
            this.Lbl_Id_Cliente.AutoSize = true;
            this.Lbl_Id_Cliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Cliente.Location = new System.Drawing.Point(14, 86);
            this.Lbl_Id_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Cliente.Name = "Lbl_Id_Cliente";
            this.Lbl_Id_Cliente.Size = new System.Drawing.Size(91, 20);
            this.Lbl_Id_Cliente.TabIndex = 1;
            this.Lbl_Id_Cliente.Text = "Id Cliente:";
            // 
            // Lbl_IDDevolucion
            // 
            this.Lbl_IDDevolucion.AutoSize = true;
            this.Lbl_IDDevolucion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDDevolucion.Location = new System.Drawing.Point(8, 32);
            this.Lbl_IDDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDDevolucion.Name = "Lbl_IDDevolucion";
            this.Lbl_IDDevolucion.Size = new System.Drawing.Size(123, 20);
            this.Lbl_IDDevolucion.TabIndex = 0;
            this.Lbl_IDDevolucion.Text = "Id Devolución:";
            // 
            // Btn_Salir_Dev
            // 
            this.Btn_Salir_Dev.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir_Dev.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir_Dev.Image")));
            this.Btn_Salir_Dev.Location = new System.Drawing.Point(1326, 106);
            this.Btn_Salir_Dev.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir_Dev.Name = "Btn_Salir_Dev";
            this.Btn_Salir_Dev.Size = new System.Drawing.Size(95, 97);
            this.Btn_Salir_Dev.TabIndex = 83;
            this.Btn_Salir_Dev.Text = "Salir";
            this.Btn_Salir_Dev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir_Dev.UseVisualStyleBackColor = true;
            this.Btn_Salir_Dev.Click += new System.EventHandler(this.Btn_Salir_Dev_Click);
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(806, 106);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(99, 100);
            this.Btn_inicio.TabIndex = 79;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar_Devolucion
            // 
            this.Btn_Eliminar_Devolucion.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Eliminar_Devolucion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Devolucion.Image")));
            this.Btn_Eliminar_Devolucion.Location = new System.Drawing.Point(480, 104);
            this.Btn_Eliminar_Devolucion.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar_Devolucion.Name = "Btn_Eliminar_Devolucion";
            this.Btn_Eliminar_Devolucion.Size = new System.Drawing.Size(99, 103);
            this.Btn_Eliminar_Devolucion.TabIndex = 78;
            this.Btn_Eliminar_Devolucion.Text = "Eliminar";
            this.Btn_Eliminar_Devolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar_Devolucion.UseVisualStyleBackColor = true;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(912, 104);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(95, 100);
            this.Btn_anterior.TabIndex = 80;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar_Devoluciones
            // 
            this.Btn_Guardar_Devoluciones.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar_Devoluciones.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Guardar_Devoluciones.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Devoluciones.Image")));
            this.Btn_Guardar_Devoluciones.Location = new System.Drawing.Point(267, 104);
            this.Btn_Guardar_Devoluciones.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar_Devoluciones.Name = "Btn_Guardar_Devoluciones";
            this.Btn_Guardar_Devoluciones.Size = new System.Drawing.Size(99, 105);
            this.Btn_Guardar_Devoluciones.TabIndex = 77;
            this.Btn_Guardar_Devoluciones.Text = "Guardar";
            this.Btn_Guardar_Devoluciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar_Devoluciones.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Devoluciones.Click += new System.EventHandler(this.Btn_Guardar_Devoluciones_Click);
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(1016, 106);
            this.Btn_sig.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(95, 98);
            this.Btn_sig.TabIndex = 81;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar_Devolucion
            // 
            this.Btn_buscar_Devolucion.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_buscar_Devolucion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar_Devolucion.Image")));
            this.Btn_buscar_Devolucion.Location = new System.Drawing.Point(588, 103);
            this.Btn_buscar_Devolucion.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar_Devolucion.Name = "Btn_buscar_Devolucion";
            this.Btn_buscar_Devolucion.Size = new System.Drawing.Size(101, 103);
            this.Btn_buscar_Devolucion.TabIndex = 76;
            this.Btn_buscar_Devolucion.Text = "Consultar";
            this.Btn_buscar_Devolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar_Devolucion.UseVisualStyleBackColor = true;
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(1119, 104);
            this.Btn_fin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(95, 98);
            this.Btn_fin.TabIndex = 82;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte_Dev
            // 
            this.Btn_Reporte_Dev.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Reporte_Dev.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte_Dev.Image")));
            this.Btn_Reporte_Dev.Location = new System.Drawing.Point(695, 103);
            this.Btn_Reporte_Dev.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Dev.Name = "Btn_Reporte_Dev";
            this.Btn_Reporte_Dev.Size = new System.Drawing.Size(99, 102);
            this.Btn_Reporte_Dev.TabIndex = 74;
            this.Btn_Reporte_Dev.Text = "Imprimir";
            this.Btn_Reporte_Dev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte_Dev.UseVisualStyleBackColor = true;
            // 
            // Btn_Ingresar_DevVentas
            // 
            this.Btn_Ingresar_DevVentas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Ingresar_DevVentas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar_DevVentas.Image")));
            this.Btn_Ingresar_DevVentas.Location = new System.Drawing.Point(54, 104);
            this.Btn_Ingresar_DevVentas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingresar_DevVentas.Name = "Btn_Ingresar_DevVentas";
            this.Btn_Ingresar_DevVentas.Size = new System.Drawing.Size(99, 107);
            this.Btn_Ingresar_DevVentas.TabIndex = 71;
            this.Btn_Ingresar_DevVentas.Text = "Ingresar";
            this.Btn_Ingresar_DevVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar_DevVentas.UseVisualStyleBackColor = true;
            this.Btn_Ingresar_DevVentas.Click += new System.EventHandler(this.Btn_Ingresar_DevVentas_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1222, 106);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(95, 98);
            this.Btn_Ayuda.TabIndex = 73;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar_Devolucion
            // 
            this.Btn_Cancelar_Devolucion.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Cancelar_Devolucion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar_Devolucion.Image")));
            this.Btn_Cancelar_Devolucion.Location = new System.Drawing.Point(374, 106);
            this.Btn_Cancelar_Devolucion.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar_Devolucion.Name = "Btn_Cancelar_Devolucion";
            this.Btn_Cancelar_Devolucion.Size = new System.Drawing.Size(99, 103);
            this.Btn_Cancelar_Devolucion.TabIndex = 72;
            this.Btn_Cancelar_Devolucion.Text = "Cancelar";
            this.Btn_Cancelar_Devolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar_Devolucion.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Devolucion.Click += new System.EventHandler(this.Btn_Cancelar_Devolucion_Click);
            // 
            // Btn_Modificar_Devolucion
            // 
            this.Btn_Modificar_Devolucion.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Modificar_Devolucion.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar_Devolucion.Image")));
            this.Btn_Modificar_Devolucion.Location = new System.Drawing.Point(158, 104);
            this.Btn_Modificar_Devolucion.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar_Devolucion.Name = "Btn_Modificar_Devolucion";
            this.Btn_Modificar_Devolucion.Size = new System.Drawing.Size(101, 106);
            this.Btn_Modificar_Devolucion.TabIndex = 75;
            this.Btn_Modificar_Devolucion.Text = "Modificar";
            this.Btn_Modificar_Devolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar_Devolucion.UseVisualStyleBackColor = true;
            // 
            // GB_Detalle_Ventas
            // 
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Unidad_Medida);
            this.GB_Detalle_Ventas.Controls.Add(this.label4);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Limpiar_Detalle);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Remover_Detalle_Dev);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Agregar_Detalle_Dev);
            this.GB_Detalle_Ventas.Controls.Add(this.Txt_Saldo_Total);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Bodega);
            this.GB_Detalle_Ventas.Controls.Add(this.lbl_Saldo_Total);
            this.GB_Detalle_Ventas.Controls.Add(this.label2);
            this.GB_Detalle_Ventas.Controls.Add(this.Nud_Cant_Prod);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Dgv_Detalle_Devolucion);
            this.GB_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle_Ventas.Location = new System.Drawing.Point(19, 408);
            this.GB_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Name = "GB_Detalle_Ventas";
            this.GB_Detalle_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Size = new System.Drawing.Size(1402, 511);
            this.GB_Detalle_Ventas.TabIndex = 84;
            this.GB_Detalle_Ventas.TabStop = false;
            this.GB_Detalle_Ventas.Text = "Detalle Devoluciones Ventas";
            // 
            // Cbo_Unidad_Medida
            // 
            this.Cbo_Unidad_Medida.FormattingEnabled = true;
            this.Cbo_Unidad_Medida.Location = new System.Drawing.Point(858, 95);
            this.Cbo_Unidad_Medida.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Unidad_Medida.Name = "Cbo_Unidad_Medida";
            this.Cbo_Unidad_Medida.Size = new System.Drawing.Size(199, 30);
            this.Cbo_Unidad_Medida.TabIndex = 173;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(693, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 172;
            this.label4.Text = "Unidad Medida:";
            // 
            // Btn_Limpiar_Detalle
            // 
            this.Btn_Limpiar_Detalle.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Detalle.Image")));
            this.Btn_Limpiar_Detalle.Location = new System.Drawing.Point(1249, 310);
            this.Btn_Limpiar_Detalle.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar_Detalle.Name = "Btn_Limpiar_Detalle";
            this.Btn_Limpiar_Detalle.Size = new System.Drawing.Size(99, 98);
            this.Btn_Limpiar_Detalle.TabIndex = 171;
            this.Btn_Limpiar_Detalle.Text = "Limpiar";
            this.Btn_Limpiar_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Limpiar_Detalle.Click += new System.EventHandler(this.Btn_Limpiar_Detalle_Click);
            // 
            // Btn_Remover_Detalle_Dev
            // 
            this.Btn_Remover_Detalle_Dev.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remover_Detalle_Dev.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle_Dev.Image")));
            this.Btn_Remover_Detalle_Dev.Location = new System.Drawing.Point(1249, 195);
            this.Btn_Remover_Detalle_Dev.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remover_Detalle_Dev.Name = "Btn_Remover_Detalle_Dev";
            this.Btn_Remover_Detalle_Dev.Size = new System.Drawing.Size(99, 98);
            this.Btn_Remover_Detalle_Dev.TabIndex = 170;
            this.Btn_Remover_Detalle_Dev.Text = "Remover";
            this.Btn_Remover_Detalle_Dev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle_Dev.UseVisualStyleBackColor = true;
            this.Btn_Remover_Detalle_Dev.Click += new System.EventHandler(this.Btn_Remover_Detalle_Dev_Click);
            // 
            // Btn_Agregar_Detalle_Dev
            // 
            this.Btn_Agregar_Detalle_Dev.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Detalle_Dev.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle_Dev.Image")));
            this.Btn_Agregar_Detalle_Dev.Location = new System.Drawing.Point(1249, 85);
            this.Btn_Agregar_Detalle_Dev.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Agregar_Detalle_Dev.Name = "Btn_Agregar_Detalle_Dev";
            this.Btn_Agregar_Detalle_Dev.Size = new System.Drawing.Size(99, 102);
            this.Btn_Agregar_Detalle_Dev.TabIndex = 169;
            this.Btn_Agregar_Detalle_Dev.Text = "Agregar";
            this.Btn_Agregar_Detalle_Dev.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Detalle_Dev.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Detalle_Dev.Click += new System.EventHandler(this.Btn_Agregar_Detalle_Dev_Click);
            // 
            // Txt_Saldo_Total
            // 
            this.Txt_Saldo_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Saldo_Total.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Saldo_Total.Location = new System.Drawing.Point(627, 423);
            this.Txt_Saldo_Total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Saldo_Total.Name = "Txt_Saldo_Total";
            this.Txt_Saldo_Total.ReadOnly = true;
            this.Txt_Saldo_Total.Size = new System.Drawing.Size(213, 29);
            this.Txt_Saldo_Total.TabIndex = 23;
            this.Txt_Saldo_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Cbo_Id_Bodega
            // 
            this.Cbo_Id_Bodega.Location = new System.Drawing.Point(137, 95);
            this.Cbo_Id_Bodega.Name = "Cbo_Id_Bodega";
            this.Cbo_Id_Bodega.Size = new System.Drawing.Size(365, 30);
            this.Cbo_Id_Bodega.TabIndex = 174;
            // 
            // lbl_Saldo_Total
            // 
            this.lbl_Saldo_Total.AutoSize = true;
            this.lbl_Saldo_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo_Total.Location = new System.Drawing.Point(523, 428);
            this.lbl_Saldo_Total.Name = "lbl_Saldo_Total";
            this.lbl_Saldo_Total.Size = new System.Drawing.Size(100, 20);
            this.lbl_Saldo_Total.TabIndex = 22;
            this.lbl_Saldo_Total.Text = "Saldo Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 167;
            this.label2.Text = "Id Bodega:";
            // 
            // Nud_Cant_Prod
            // 
            this.Nud_Cant_Prod.Location = new System.Drawing.Point(860, 44);
            this.Nud_Cant_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.Nud_Cant_Prod.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Nud_Cant_Prod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Cant_Prod.Name = "Nud_Cant_Prod";
            this.Nud_Cant_Prod.Size = new System.Drawing.Size(75, 31);
            this.Nud_Cant_Prod.TabIndex = 17;
            this.Nud_Cant_Prod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(692, 48);
            this.Lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(160, 20);
            this.Lbl_Cantidad.TabIndex = 15;
            this.Lbl_Cantidad.Text = "Cantidad Producto:";
            // 
            // Cbo_Id_Inventario
            // 
            this.Cbo_Id_Inventario.FormattingEnabled = true;
            this.Cbo_Id_Inventario.Location = new System.Drawing.Point(137, 41);
            this.Cbo_Id_Inventario.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Inventario.Name = "Cbo_Id_Inventario";
            this.Cbo_Id_Inventario.Size = new System.Drawing.Size(365, 30);
            this.Cbo_Id_Inventario.TabIndex = 14;
            this.Cbo_Id_Inventario.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Inventario_SelectedIndexChanged);
            // 
            // Lbl_Inventario
            // 
            this.Lbl_Inventario.AutoSize = true;
            this.Lbl_Inventario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventario.Location = new System.Drawing.Point(13, 48);
            this.Lbl_Inventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Inventario.Name = "Lbl_Inventario";
            this.Lbl_Inventario.Size = new System.Drawing.Size(113, 20);
            this.Lbl_Inventario.TabIndex = 13;
            this.Lbl_Inventario.Text = "Id Inventario:";
            // 
            // Dgv_Detalle_Devolucion
            // 
            this.Dgv_Detalle_Devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Devolucion.Location = new System.Drawing.Point(35, 149);
            this.Dgv_Detalle_Devolucion.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Detalle_Devolucion.Name = "Dgv_Detalle_Devolucion";
            this.Dgv_Detalle_Devolucion.RowHeadersWidth = 51;
            this.Dgv_Detalle_Devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle_Devolucion.Size = new System.Drawing.Size(1157, 254);
            this.Dgv_Detalle_Devolucion.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "735 - Devoluciones Ventas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 82);
            this.panel1.TabIndex = 32;
            // 
            // Frm_Detalle_Devoluciones_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 932);
            this.Controls.Add(this.GB_Detalle_Ventas);
            this.Controls.Add(this.Btn_Salir_Dev);
            this.Controls.Add(this.Btn_inicio);
            this.Controls.Add(this.Btn_Eliminar_Devolucion);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.GB_Ventas);
            this.Controls.Add(this.Btn_Guardar_Devoluciones);
            this.Controls.Add(this.Btn_sig);
            this.Controls.Add(this.Btn_buscar_Devolucion);
            this.Controls.Add(this.Btn_fin);
            this.Controls.Add(this.Btn_Reporte_Dev);
            this.Controls.Add(this.Btn_Ingresar_DevVentas);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar_Devolucion);
            this.Controls.Add(this.Btn_Modificar_Devolucion);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Detalle_Devoluciones_Ventas";
            this.Text = "Frm_Detalle_Devoluciones_Ventas";
            this.Load += new System.EventHandler(this.Frm_Detalle_Devoluciones_Ventas_Load);
            this.GB_Ventas.ResumeLayout(false);
            this.GB_Ventas.PerformLayout();
            this.GB_Detalle_Ventas.ResumeLayout(false);
            this.GB_Detalle_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Devolucion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Salir_Dev;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_Eliminar_Devolucion;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.GroupBox GB_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.ComboBox Cbo_Id_Sucursal;
        private System.Windows.Forms.Label Lbl_Id_Sucursal;
        private System.Windows.Forms.ComboBox Cbo_Id_Venta_Dev;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Devolucion;
        private System.Windows.Forms.ComboBox Cbo_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Fecha_Venta;
        private System.Windows.Forms.Label Lbl_Id_Cliente;
        private System.Windows.Forms.Label Lbl_IDDevolucion;
        private System.Windows.Forms.Button Btn_Guardar_Devoluciones;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_buscar_Devolucion;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button Btn_Reporte_Dev;
        private System.Windows.Forms.Button Btn_Ingresar_DevVentas;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar_Devolucion;
        private System.Windows.Forms.Button Btn_Modificar_Devolucion;
        private System.Windows.Forms.GroupBox GB_Detalle_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Unidad_Medida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Limpiar_Detalle;
        private System.Windows.Forms.Button Btn_Remover_Detalle_Dev;
        private System.Windows.Forms.Button Btn_Agregar_Detalle_Dev;
        private System.Windows.Forms.TextBox Txt_Saldo_Total;
        private System.Windows.Forms.ComboBox Cbo_Id_Bodega;
        private System.Windows.Forms.Label lbl_Saldo_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Nud_Cant_Prod;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Id_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Devolucion;
        private System.Windows.Forms.TextBox Txt_Motivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cbo_Id_Venta;
        private System.Windows.Forms.Label label3;
    }
}