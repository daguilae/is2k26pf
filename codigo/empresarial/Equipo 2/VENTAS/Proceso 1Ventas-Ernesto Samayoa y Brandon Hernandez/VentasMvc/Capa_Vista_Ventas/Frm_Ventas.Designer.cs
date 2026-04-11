
namespace Capa_Vista_Ventas
{
    partial class Frm_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Ventas = new System.Windows.Forms.GroupBox();
            this.Txt_Saldo_total = new System.Windows.Forms.TextBox();
            this.lbl_Saldo_Total = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cbo_Id_Sucursal = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Sucursal = new System.Windows.Forms.Label();
            this.Cbo_Id_Vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Vendedor = new System.Windows.Forms.Label();
            this.Cbo_Id_Venta = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Venta = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Id_Cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha_Venta = new System.Windows.Forms.Label();
            this.Lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Lbl_IDVenta = new System.Windows.Forms.Label();
            this.GB_Detalle_Ventas = new System.Windows.Forms.GroupBox();
            this.Nud_Cant_Prod = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_Id_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.DGV_DETALLE_VENTA = new System.Windows.Forms.DataGridView();
            this.Clm_Id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Id_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_precio_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Precio_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Costo_Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Remover_Detalle = new System.Windows.Forms.Button();
            this.Btn_Guardar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Limpiar_Ventas = new System.Windows.Forms.Button();
            this.Btn_buscar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Reporte_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Agregar_Ventas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.GB_Ventas.SuspendLayout();
            this.GB_Detalle_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_VENTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 98);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // GB_Ventas
            // 
            this.GB_Ventas.Controls.Add(this.Txt_Saldo_total);
            this.GB_Ventas.Controls.Add(this.lbl_Saldo_Total);
            this.GB_Ventas.Controls.Add(this.comboBox1);
            this.GB_Ventas.Controls.Add(this.Lbl_Estado);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Vendedor);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Vendedor);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Venta);
            this.GB_Ventas.Controls.Add(this.Dtp_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_IDVenta);
            this.GB_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Ventas.Location = new System.Drawing.Point(13, 237);
            this.GB_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Name = "GB_Ventas";
            this.GB_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Size = new System.Drawing.Size(1111, 189);
            this.GB_Ventas.TabIndex = 43;
            this.GB_Ventas.TabStop = false;
            this.GB_Ventas.Text = "Encabezado de Venta";
            // 
            // Txt_Saldo_total
            // 
            this.Txt_Saldo_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Saldo_total.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Saldo_total.Location = new System.Drawing.Point(903, 143);
            this.Txt_Saldo_total.Name = "Txt_Saldo_total";
            this.Txt_Saldo_total.ReadOnly = true;
            this.Txt_Saldo_total.Size = new System.Drawing.Size(164, 29);
            this.Txt_Saldo_total.TabIndex = 23;
            this.Txt_Saldo_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Saldo_Total
            // 
            this.lbl_Saldo_Total.AutoSize = true;
            this.lbl_Saldo_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo_Total.Location = new System.Drawing.Point(797, 147);
            this.lbl_Saldo_Total.Name = "lbl_Saldo_Total";
            this.lbl_Saldo_Total.Size = new System.Drawing.Size(100, 20);
            this.lbl_Saldo_Total.TabIndex = 22;
            this.lbl_Saldo_Total.Text = "Saldo Total:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(903, 92);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MaxLength = 13;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 30);
            this.comboBox1.TabIndex = 15;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(828, 98);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Estado.TabIndex = 14;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Cbo_Id_Sucursal
            // 
            this.Cbo_Id_Sucursal.FormattingEnabled = true;
            this.Cbo_Id_Sucursal.Location = new System.Drawing.Point(479, 92);
            this.Cbo_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Sucursal.MaxLength = 13;
            this.Cbo_Id_Sucursal.Name = "Cbo_Id_Sucursal";
            this.Cbo_Id_Sucursal.Size = new System.Drawing.Size(231, 30);
            this.Cbo_Id_Sucursal.TabIndex = 13;
            // 
            // Lbl_Id_Sucursal
            // 
            this.Lbl_Id_Sucursal.AutoSize = true;
            this.Lbl_Id_Sucursal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Sucursal.Location = new System.Drawing.Point(371, 98);
            this.Lbl_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Sucursal.Name = "Lbl_Id_Sucursal";
            this.Lbl_Id_Sucursal.Size = new System.Drawing.Size(100, 20);
            this.Lbl_Id_Sucursal.TabIndex = 12;
            this.Lbl_Id_Sucursal.Text = "Id Sucursal:";
            // 
            // Cbo_Id_Vendedor
            // 
            this.Cbo_Id_Vendedor.FormattingEnabled = true;
            this.Cbo_Id_Vendedor.Location = new System.Drawing.Point(479, 32);
            this.Cbo_Id_Vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Vendedor.MaxLength = 13;
            this.Cbo_Id_Vendedor.Name = "Cbo_Id_Vendedor";
            this.Cbo_Id_Vendedor.Size = new System.Drawing.Size(231, 30);
            this.Cbo_Id_Vendedor.TabIndex = 11;
            // 
            // Lbl_Id_Vendedor
            // 
            this.Lbl_Id_Vendedor.AutoSize = true;
            this.Lbl_Id_Vendedor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Vendedor.Location = new System.Drawing.Point(359, 38);
            this.Lbl_Id_Vendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Vendedor.Name = "Lbl_Id_Vendedor";
            this.Lbl_Id_Vendedor.Size = new System.Drawing.Size(112, 20);
            this.Lbl_Id_Vendedor.TabIndex = 10;
            this.Lbl_Id_Vendedor.Text = "Id Vendedor:";
            // 
            // Cbo_Id_Venta
            // 
            this.Cbo_Id_Venta.FormattingEnabled = true;
            this.Cbo_Id_Venta.Location = new System.Drawing.Point(104, 32);
            this.Cbo_Id_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Venta.Name = "Cbo_Id_Venta";
            this.Cbo_Id_Venta.Size = new System.Drawing.Size(161, 30);
            this.Cbo_Id_Venta.TabIndex = 8;
            // 
            // Dtp_Fecha_Venta
            // 
            this.Dtp_Fecha_Venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Venta.Location = new System.Drawing.Point(896, 29);
            this.Dtp_Fecha_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Fecha_Venta.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.Name = "Dtp_Fecha_Venta";
            this.Dtp_Fecha_Venta.Size = new System.Drawing.Size(170, 31);
            this.Dtp_Fecha_Venta.TabIndex = 6;
            // 
            // Cbo_Id_Cliente
            // 
            this.Cbo_Id_Cliente.FormattingEnabled = true;
            this.Cbo_Id_Cliente.Location = new System.Drawing.Point(119, 92);
            this.Cbo_Id_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Cliente.MaxLength = 13;
            this.Cbo_Id_Cliente.Name = "Cbo_Id_Cliente";
            this.Cbo_Id_Cliente.Size = new System.Drawing.Size(233, 30);
            this.Cbo_Id_Cliente.TabIndex = 5;
            // 
            // Lbl_Fecha_Venta
            // 
            this.Lbl_Fecha_Venta.AutoSize = true;
            this.Lbl_Fecha_Venta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Venta.Location = new System.Drawing.Point(772, 35);
            this.Lbl_Fecha_Venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Venta.Name = "Lbl_Fecha_Venta";
            this.Lbl_Fecha_Venta.Size = new System.Drawing.Size(116, 20);
            this.Lbl_Fecha_Venta.TabIndex = 2;
            this.Lbl_Fecha_Venta.Text = "Fecha_Venta:";
            // 
            // Lbl_Id_Cliente
            // 
            this.Lbl_Id_Cliente.AutoSize = true;
            this.Lbl_Id_Cliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Cliente.Location = new System.Drawing.Point(18, 98);
            this.Lbl_Id_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Cliente.Name = "Lbl_Id_Cliente";
            this.Lbl_Id_Cliente.Size = new System.Drawing.Size(91, 20);
            this.Lbl_Id_Cliente.TabIndex = 1;
            this.Lbl_Id_Cliente.Text = "Id Cliente:";
            // 
            // Lbl_IDVenta
            // 
            this.Lbl_IDVenta.AutoSize = true;
            this.Lbl_IDVenta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDVenta.Location = new System.Drawing.Point(17, 42);
            this.Lbl_IDVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDVenta.Name = "Lbl_IDVenta";
            this.Lbl_IDVenta.Size = new System.Drawing.Size(79, 20);
            this.Lbl_IDVenta.TabIndex = 0;
            this.Lbl_IDVenta.Text = "Id Venta:";
            // 
            // GB_Detalle_Ventas
            // 
            this.GB_Detalle_Ventas.Controls.Add(this.Nud_Cant_Prod);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.DGV_DETALLE_VENTA);
            this.GB_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle_Ventas.Location = new System.Drawing.Point(13, 453);
            this.GB_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Name = "GB_Detalle_Ventas";
            this.GB_Detalle_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Size = new System.Drawing.Size(1107, 395);
            this.GB_Detalle_Ventas.TabIndex = 44;
            this.GB_Detalle_Ventas.TabStop = false;
            this.GB_Detalle_Ventas.Text = "DETALLE";
            // 
            // Nud_Cant_Prod
            // 
            this.Nud_Cant_Prod.Location = new System.Drawing.Point(641, 42);
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
            this.Nud_Cant_Prod.Size = new System.Drawing.Size(95, 31);
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
            this.Lbl_Cantidad.Location = new System.Drawing.Point(441, 48);
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
            this.Cbo_Id_Inventario.Size = new System.Drawing.Size(215, 30);
            this.Cbo_Id_Inventario.TabIndex = 14;
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
            // DGV_DETALLE_VENTA
            // 
            this.DGV_DETALLE_VENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DETALLE_VENTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Id_venta,
            this.Clm_Id_Inventario,
            this.Clm_Nombre_producto,
            this.Clm_precio_u,
            this.Clm_cantidad,
            this.Clm_Precio_sub,
            this.Clm_Costo_Subtotal});
            this.DGV_DETALLE_VENTA.Location = new System.Drawing.Point(17, 112);
            this.DGV_DETALLE_VENTA.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_DETALLE_VENTA.Name = "DGV_DETALLE_VENTA";
            this.DGV_DETALLE_VENTA.RowHeadersWidth = 51;
            this.DGV_DETALLE_VENTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DETALLE_VENTA.Size = new System.Drawing.Size(1067, 254);
            this.DGV_DETALLE_VENTA.TabIndex = 10;
            // 
            // Clm_Id_venta
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clm_Id_venta.DefaultCellStyle = dataGridViewCellStyle1;
            this.Clm_Id_venta.HeaderText = "Id";
            this.Clm_Id_venta.MinimumWidth = 6;
            this.Clm_Id_venta.Name = "Clm_Id_venta";
            this.Clm_Id_venta.Width = 125;
            // 
            // Clm_Id_Inventario
            // 
            this.Clm_Id_Inventario.HeaderText = "Id Inventario";
            this.Clm_Id_Inventario.MinimumWidth = 6;
            this.Clm_Id_Inventario.Name = "Clm_Id_Inventario";
            this.Clm_Id_Inventario.Width = 125;
            // 
            // Clm_Nombre_producto
            // 
            this.Clm_Nombre_producto.HeaderText = "Producto";
            this.Clm_Nombre_producto.MinimumWidth = 6;
            this.Clm_Nombre_producto.Name = "Clm_Nombre_producto";
            this.Clm_Nombre_producto.Width = 125;
            // 
            // Clm_precio_u
            // 
            this.Clm_precio_u.HeaderText = "Precio Unitario";
            this.Clm_precio_u.MinimumWidth = 6;
            this.Clm_precio_u.Name = "Clm_precio_u";
            this.Clm_precio_u.Width = 125;
            // 
            // Clm_cantidad
            // 
            this.Clm_cantidad.HeaderText = "Cantidad";
            this.Clm_cantidad.MinimumWidth = 6;
            this.Clm_cantidad.Name = "Clm_cantidad";
            this.Clm_cantidad.Width = 125;
            // 
            // Clm_Precio_sub
            // 
            this.Clm_Precio_sub.HeaderText = "Precio Subtotal";
            this.Clm_Precio_sub.MinimumWidth = 6;
            this.Clm_Precio_sub.Name = "Clm_Precio_sub";
            this.Clm_Precio_sub.Width = 125;
            // 
            // Clm_Costo_Subtotal
            // 
            this.Clm_Costo_Subtotal.HeaderText = "Costo Subtotal";
            this.Clm_Costo_Subtotal.MinimumWidth = 6;
            this.Clm_Costo_Subtotal.Name = "Clm_Costo_Subtotal";
            this.Clm_Costo_Subtotal.Width = 125;
            // 
            // Btn_Remover_Detalle
            // 
            this.Btn_Remover_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remover_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle.Image")));
            this.Btn_Remover_Detalle.Location = new System.Drawing.Point(611, 120);
            this.Btn_Remover_Detalle.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remover_Detalle.Name = "Btn_Remover_Detalle";
            this.Btn_Remover_Detalle.Size = new System.Drawing.Size(111, 98);
            this.Btn_Remover_Detalle.TabIndex = 42;
            this.Btn_Remover_Detalle.Text = "ELIMINAR";
            this.Btn_Remover_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar_Ventas
            // 
            this.Btn_Guardar_Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Guardar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Ventas.Image")));
            this.Btn_Guardar_Ventas.Location = new System.Drawing.Point(135, 120);
            this.Btn_Guardar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar_Ventas.Name = "Btn_Guardar_Ventas";
            this.Btn_Guardar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Guardar_Ventas.TabIndex = 41;
            this.Btn_Guardar_Ventas.Text = "GUARDAR";
            this.Btn_Guardar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar_Ventas.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar_Ventas
            // 
            this.Btn_Limpiar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Ventas.Image")));
            this.Btn_Limpiar_Ventas.Location = new System.Drawing.Point(373, 120);
            this.Btn_Limpiar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar_Ventas.Name = "Btn_Limpiar_Ventas";
            this.Btn_Limpiar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Limpiar_Ventas.TabIndex = 40;
            this.Btn_Limpiar_Ventas.Text = "LIMPIAR";
            this.Btn_Limpiar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar_Ventas
            // 
            this.Btn_buscar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar_Ventas.Image")));
            this.Btn_buscar_Ventas.Location = new System.Drawing.Point(730, 120);
            this.Btn_buscar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar_Ventas.Name = "Btn_buscar_Ventas";
            this.Btn_buscar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_buscar_Ventas.TabIndex = 39;
            this.Btn_buscar_Ventas.Text = "BUSCAR";
            this.Btn_buscar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1087, 120);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(111, 98);
            this.Btn_Salir.TabIndex = 37;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar_Ventas
            // 
            this.Btn_Modificar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar_Ventas.Image")));
            this.Btn_Modificar_Ventas.Location = new System.Drawing.Point(254, 120);
            this.Btn_Modificar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar_Ventas.Name = "Btn_Modificar_Ventas";
            this.Btn_Modificar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Modificar_Ventas.TabIndex = 36;
            this.Btn_Modificar_Ventas.Text = "MODIFICAR";
            this.Btn_Modificar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte_Ventas
            // 
            this.Btn_Reporte_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte_Ventas.Image")));
            this.Btn_Reporte_Ventas.Location = new System.Drawing.Point(849, 120);
            this.Btn_Reporte_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Ventas.Name = "Btn_Reporte_Ventas";
            this.Btn_Reporte_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Reporte_Ventas.TabIndex = 35;
            this.Btn_Reporte_Ventas.Text = "REPORTE";
            this.Btn_Reporte_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(968, 120);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(111, 98);
            this.Btn_Ayuda.TabIndex = 34;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar_Ventas
            // 
            this.Btn_Cancelar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar_Ventas.Image")));
            this.Btn_Cancelar_Ventas.Location = new System.Drawing.Point(492, 120);
            this.Btn_Cancelar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar_Ventas.Name = "Btn_Cancelar_Ventas";
            this.Btn_Cancelar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Cancelar_Ventas.TabIndex = 33;
            this.Btn_Cancelar_Ventas.Text = "CANCELAR";
            this.Btn_Cancelar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Ventas
            // 
            this.Btn_Agregar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Ventas.Image")));
            this.Btn_Agregar_Ventas.Location = new System.Drawing.Point(13, 120);
            this.Btn_Agregar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Agregar_Ventas.Name = "Btn_Agregar_Ventas";
            this.Btn_Agregar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Agregar_Ventas.TabIndex = 32;
            this.Btn_Agregar_Ventas.Text = "INGRESAR";
            this.Btn_Agregar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Ventas.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Ventas.Properties.Resources.shopping_commerce_flower_supermarket_sale_cart_icon_255564;
            this.pictureBox1.Location = new System.Drawing.Point(132, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1220, 912);
            this.Controls.Add(this.GB_Detalle_Ventas);
            this.Controls.Add(this.GB_Ventas);
            this.Controls.Add(this.Btn_Remover_Detalle);
            this.Controls.Add(this.Btn_Guardar_Ventas);
            this.Controls.Add(this.Btn_Limpiar_Ventas);
            this.Controls.Add(this.Btn_buscar_Ventas);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar_Ventas);
            this.Controls.Add(this.Btn_Reporte_Ventas);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar_Ventas);
            this.Controls.Add(this.Btn_Agregar_Ventas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB_Ventas.ResumeLayout(false);
            this.GB_Ventas.PerformLayout();
            this.GB_Detalle_Ventas.ResumeLayout(false);
            this.GB_Detalle_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_VENTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Agregar_Ventas;
        private System.Windows.Forms.Button Btn_buscar_Ventas;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar_Ventas;
        private System.Windows.Forms.Button Btn_Reporte_Ventas;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar_Ventas;
        private System.Windows.Forms.Button Btn_Limpiar_Ventas;
        private System.Windows.Forms.Button Btn_Guardar_Ventas;
        private System.Windows.Forms.Button Btn_Remover_Detalle;
        private System.Windows.Forms.GroupBox GB_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Id_Venta;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Venta;
        private System.Windows.Forms.ComboBox Cbo_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Fecha_Venta;
        private System.Windows.Forms.Label Lbl_Id_Cliente;
        private System.Windows.Forms.Label Lbl_IDVenta;
        private System.Windows.Forms.ComboBox Cbo_Id_Vendedor;
        private System.Windows.Forms.Label Lbl_Id_Vendedor;
        private System.Windows.Forms.ComboBox Cbo_Id_Sucursal;
        private System.Windows.Forms.Label Lbl_Id_Sucursal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Saldo_total;
        private System.Windows.Forms.Label lbl_Saldo_Total;
        private System.Windows.Forms.GroupBox GB_Detalle_Ventas;
        private System.Windows.Forms.NumericUpDown Nud_Cant_Prod;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Id_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.DataGridView DGV_DETALLE_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Id_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_precio_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Precio_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Costo_Subtotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}