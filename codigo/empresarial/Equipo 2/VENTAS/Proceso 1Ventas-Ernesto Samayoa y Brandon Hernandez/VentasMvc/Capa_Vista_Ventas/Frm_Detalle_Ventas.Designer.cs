
namespace Capa_Vista_Ventas
{
    partial class Frm_Detalle_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_Ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Ventas = new System.Windows.Forms.GroupBox();
            this.Dtp_fecha_cotizacion_pedido = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Cotizacion_pedido = new System.Windows.Forms.Label();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Cbo_Tipo_Operacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cbo_Id_Sucursal = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Sucursal = new System.Windows.Forms.Label();
            this.Cbo_Id_Venta = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Venta = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Id_Cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha_Venta = new System.Windows.Forms.Label();
            this.Lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Lbl_IDVenta = new System.Windows.Forms.Label();
            this.Txt_Saldo_Total = new System.Windows.Forms.TextBox();
            this.lbl_Saldo_Total = new System.Windows.Forms.Label();
            this.GB_Detalle_Ventas = new System.Windows.Forms.GroupBox();
            this.Cbo_Unidad_Medida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Limpiar_Detalle_Ventas = new System.Windows.Forms.Button();
            this.Btn_Remover_Detalle_Ventas = new System.Windows.Forms.Button();
            this.Btn_Agregar_Detalle_Ventas = new System.Windows.Forms.Button();
            this.Cbo_Id_Bodega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Pagar = new System.Windows.Forms.Button();
            this.Nud_Cant_Prod = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_Id_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.Dgv_Detalle_Venta = new System.Windows.Forms.DataGridView();
            this.Btn_Salir_Dventas = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_Guardar_Ventas = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_buscar_Ventas = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_Reporte_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ingresar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Modificar_Ventas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.GB_Ventas.SuspendLayout();
            this.GB_Detalle_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 82);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "710 - Ventas";
            // 
            // GB_Ventas
            // 
            this.GB_Ventas.Controls.Add(this.Dtp_fecha_cotizacion_pedido);
            this.GB_Ventas.Controls.Add(this.Lbl_Fecha_Cotizacion_pedido);
            this.GB_Ventas.Controls.Add(this.Cbo_Estado);
            this.GB_Ventas.Controls.Add(this.Cbo_Tipo_Operacion);
            this.GB_Ventas.Controls.Add(this.label3);
            this.GB_Ventas.Controls.Add(this.Lbl_Estado);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Venta);
            this.GB_Ventas.Controls.Add(this.Dtp_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_IDVenta);
            this.GB_Ventas.Font = new System.Drawing.Font("Rockwell", 10F);
            this.GB_Ventas.Location = new System.Drawing.Point(35, 215);
            this.GB_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Name = "GB_Ventas";
            this.GB_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Size = new System.Drawing.Size(1373, 171);
            this.GB_Ventas.TabIndex = 43;
            this.GB_Ventas.TabStop = false;
            this.GB_Ventas.Text = "Encabezado de Venta";
            // 
            // Dtp_fecha_cotizacion_pedido
            // 
            this.Dtp_fecha_cotizacion_pedido.Location = new System.Drawing.Point(969, 131);
            this.Dtp_fecha_cotizacion_pedido.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_fecha_cotizacion_pedido.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_fecha_cotizacion_pedido.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_fecha_cotizacion_pedido.Name = "Dtp_fecha_cotizacion_pedido";
            this.Dtp_fecha_cotizacion_pedido.Size = new System.Drawing.Size(376, 27);
            this.Dtp_fecha_cotizacion_pedido.TabIndex = 20;
            this.Dtp_fecha_cotizacion_pedido.Value = new System.DateTime(2026, 5, 17, 8, 9, 44, 0);
            // 
            // Lbl_Fecha_Cotizacion_pedido
            // 
            this.Lbl_Fecha_Cotizacion_pedido.AutoSize = true;
            this.Lbl_Fecha_Cotizacion_pedido.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Cotizacion_pedido.Location = new System.Drawing.Point(773, 137);
            this.Lbl_Fecha_Cotizacion_pedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Cotizacion_pedido.Name = "Lbl_Fecha_Cotizacion_pedido";
            this.Lbl_Fecha_Cotizacion_pedido.Size = new System.Drawing.Size(191, 20);
            this.Lbl_Fecha_Cotizacion_pedido.TabIndex = 19;
            this.Lbl_Fecha_Cotizacion_pedido.Text = "Fecha de vencimiento :";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(539, 87);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Estado.MaxLength = 13;
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(163, 28);
            this.Cbo_Estado.TabIndex = 18;
            // 
            // Cbo_Tipo_Operacion
            // 
            this.Cbo_Tipo_Operacion.FormattingEnabled = true;
            this.Cbo_Tipo_Operacion.Location = new System.Drawing.Point(969, 87);
            this.Cbo_Tipo_Operacion.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Tipo_Operacion.MaxLength = 13;
            this.Cbo_Tipo_Operacion.Name = "Cbo_Tipo_Operacion";
            this.Cbo_Tipo_Operacion.Size = new System.Drawing.Size(163, 28);
            this.Cbo_Tipo_Operacion.TabIndex = 17;
            this.Cbo_Tipo_Operacion.SelectedValueChanged += new System.EventHandler(this.Cbo_Tipo_Operacion_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(808, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo Operación:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(464, 91);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Estado.TabIndex = 14;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Cbo_Id_Sucursal
            // 
            this.Cbo_Id_Sucursal.FormattingEnabled = true;
            this.Cbo_Id_Sucursal.Location = new System.Drawing.Point(121, 88);
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
            this.Lbl_Id_Sucursal.Location = new System.Drawing.Point(13, 92);
            this.Lbl_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Sucursal.Name = "Lbl_Id_Sucursal";
            this.Lbl_Id_Sucursal.Size = new System.Drawing.Size(100, 20);
            this.Lbl_Id_Sucursal.TabIndex = 12;
            this.Lbl_Id_Sucursal.Text = "Id Sucursal:";
            // 
            // Cbo_Id_Venta
            // 
            this.Cbo_Id_Venta.FormattingEnabled = true;
            this.Cbo_Id_Venta.Location = new System.Drawing.Point(104, 32);
            this.Cbo_Id_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Venta.Name = "Cbo_Id_Venta";
            this.Cbo_Id_Venta.Size = new System.Drawing.Size(119, 28);
            this.Cbo_Id_Venta.TabIndex = 8;
            // 
            // Dtp_Fecha_Venta
            // 
            this.Dtp_Fecha_Venta.Location = new System.Drawing.Point(907, 33);
            this.Dtp_Fecha_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Fecha_Venta.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.Name = "Dtp_Fecha_Venta";
            this.Dtp_Fecha_Venta.Size = new System.Drawing.Size(376, 27);
            this.Dtp_Fecha_Venta.TabIndex = 6;
            this.Dtp_Fecha_Venta.Value = new System.DateTime(2026, 5, 17, 8, 9, 39, 0);
            // 
            // Cbo_Id_Cliente
            // 
            this.Cbo_Id_Cliente.FormattingEnabled = true;
            this.Cbo_Id_Cliente.Location = new System.Drawing.Point(391, 33);
            this.Cbo_Id_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Cliente.MaxLength = 13;
            this.Cbo_Id_Cliente.Name = "Cbo_Id_Cliente";
            this.Cbo_Id_Cliente.Size = new System.Drawing.Size(388, 28);
            this.Cbo_Id_Cliente.TabIndex = 5;
            this.Cbo_Id_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Cliente_SelectedIndexChanged);
            // 
            // Lbl_Fecha_Venta
            // 
            this.Lbl_Fecha_Venta.AutoSize = true;
            this.Lbl_Fecha_Venta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Venta.Location = new System.Drawing.Point(811, 36);
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
            this.Lbl_Id_Cliente.Location = new System.Drawing.Point(291, 34);
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
            this.Lbl_IDVenta.Location = new System.Drawing.Point(8, 32);
            this.Lbl_IDVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDVenta.Name = "Lbl_IDVenta";
            this.Lbl_IDVenta.Size = new System.Drawing.Size(79, 20);
            this.Lbl_IDVenta.TabIndex = 0;
            this.Lbl_IDVenta.Text = "Id Venta:";
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
            // GB_Detalle_Ventas
            // 
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Unidad_Medida);
            this.GB_Detalle_Ventas.Controls.Add(this.label4);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Limpiar_Detalle_Ventas);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Remover_Detalle_Ventas);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Agregar_Detalle_Ventas);
            this.GB_Detalle_Ventas.Controls.Add(this.Txt_Saldo_Total);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Bodega);
            this.GB_Detalle_Ventas.Controls.Add(this.lbl_Saldo_Total);
            this.GB_Detalle_Ventas.Controls.Add(this.label2);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Pagar);
            this.GB_Detalle_Ventas.Controls.Add(this.Nud_Cant_Prod);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Dgv_Detalle_Venta);
            this.GB_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle_Ventas.Location = new System.Drawing.Point(35, 394);
            this.GB_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Name = "GB_Detalle_Ventas";
            this.GB_Detalle_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Size = new System.Drawing.Size(1373, 492);
            this.GB_Detalle_Ventas.TabIndex = 64;
            this.GB_Detalle_Ventas.TabStop = false;
            this.GB_Detalle_Ventas.Text = "Detalle de ventas";
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
            // Btn_Limpiar_Detalle_Ventas
            // 
            this.Btn_Limpiar_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Detalle_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Detalle_Ventas.Image")));
            this.Btn_Limpiar_Detalle_Ventas.Location = new System.Drawing.Point(1220, 332);
            this.Btn_Limpiar_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar_Detalle_Ventas.Name = "Btn_Limpiar_Detalle_Ventas";
            this.Btn_Limpiar_Detalle_Ventas.Size = new System.Drawing.Size(99, 98);
            this.Btn_Limpiar_Detalle_Ventas.TabIndex = 171;
            this.Btn_Limpiar_Detalle_Ventas.Text = "Limpiar";
            this.Btn_Limpiar_Detalle_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Detalle_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Limpiar_Detalle_Ventas.Click += new System.EventHandler(this.Btn_Limpiar_Detalle_Ventas_Click);
            // 
            // Btn_Remover_Detalle_Ventas
            // 
            this.Btn_Remover_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remover_Detalle_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle_Ventas.Image")));
            this.Btn_Remover_Detalle_Ventas.Location = new System.Drawing.Point(1220, 217);
            this.Btn_Remover_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remover_Detalle_Ventas.Name = "Btn_Remover_Detalle_Ventas";
            this.Btn_Remover_Detalle_Ventas.Size = new System.Drawing.Size(99, 98);
            this.Btn_Remover_Detalle_Ventas.TabIndex = 170;
            this.Btn_Remover_Detalle_Ventas.Text = "Remover";
            this.Btn_Remover_Detalle_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Remover_Detalle_Ventas.Click += new System.EventHandler(this.Btn_Remover_Detalle_Ventas_Click);
            // 
            // Btn_Agregar_Detalle_Ventas
            // 
            this.Btn_Agregar_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Detalle_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle_Ventas.Image")));
            this.Btn_Agregar_Detalle_Ventas.Location = new System.Drawing.Point(1220, 107);
            this.Btn_Agregar_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Agregar_Detalle_Ventas.Name = "Btn_Agregar_Detalle_Ventas";
            this.Btn_Agregar_Detalle_Ventas.Size = new System.Drawing.Size(99, 102);
            this.Btn_Agregar_Detalle_Ventas.TabIndex = 169;
            this.Btn_Agregar_Detalle_Ventas.Text = "Agregar";
            this.Btn_Agregar_Detalle_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Detalle_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Detalle_Ventas.Click += new System.EventHandler(this.Btn_Agregar_Detalle_Ventas_Click);
            // 
            // Cbo_Id_Bodega
            // 
            this.Cbo_Id_Bodega.Location = new System.Drawing.Point(137, 95);
            this.Cbo_Id_Bodega.Name = "Cbo_Id_Bodega";
            this.Cbo_Id_Bodega.Size = new System.Drawing.Size(365, 30);
            this.Cbo_Id_Bodega.TabIndex = 174;
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
            // Btn_Pagar
            // 
            this.Btn_Pagar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Pagar.Location = new System.Drawing.Point(1220, 44);
            this.Btn_Pagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Pagar.Name = "Btn_Pagar";
            this.Btn_Pagar.Size = new System.Drawing.Size(99, 39);
            this.Btn_Pagar.TabIndex = 166;
            this.Btn_Pagar.Text = "Pagar";
            this.Btn_Pagar.UseVisualStyleBackColor = false;
            this.Btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
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
            // Dgv_Detalle_Venta
            // 
            this.Dgv_Detalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Venta.Location = new System.Drawing.Point(35, 149);
            this.Dgv_Detalle_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Detalle_Venta.Name = "Dgv_Detalle_Venta";
            this.Dgv_Detalle_Venta.RowHeadersWidth = 51;
            this.Dgv_Detalle_Venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle_Venta.Size = new System.Drawing.Size(1157, 254);
            this.Dgv_Detalle_Venta.TabIndex = 10;
            this.Dgv_Detalle_Venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Detalle_Venta_CellContentClick);
            // 
            // Btn_Salir_Dventas
            // 
            this.Btn_Salir_Dventas.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir_Dventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir_Dventas.Image")));
            this.Btn_Salir_Dventas.Location = new System.Drawing.Point(1307, 102);
            this.Btn_Salir_Dventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir_Dventas.Name = "Btn_Salir_Dventas";
            this.Btn_Salir_Dventas.Size = new System.Drawing.Size(95, 97);
            this.Btn_Salir_Dventas.TabIndex = 69;
            this.Btn_Salir_Dventas.Text = "Salir";
            this.Btn_Salir_Dventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir_Dventas.UseVisualStyleBackColor = true;
            this.Btn_Salir_Dventas.Click += new System.EventHandler(this.Btn_Salir_Dventas_Click);
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(787, 102);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(99, 100);
            this.Btn_inicio.TabIndex = 65;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(461, 100);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(99, 103);
            this.Btn_Eliminar.TabIndex = 63;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(893, 100);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(95, 100);
            this.Btn_anterior.TabIndex = 66;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar_Ventas
            // 
            this.Btn_Guardar_Ventas.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar_Ventas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Guardar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Ventas.Image")));
            this.Btn_Guardar_Ventas.Location = new System.Drawing.Point(248, 100);
            this.Btn_Guardar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar_Ventas.Name = "Btn_Guardar_Ventas";
            this.Btn_Guardar_Ventas.Size = new System.Drawing.Size(99, 105);
            this.Btn_Guardar_Ventas.TabIndex = 62;
            this.Btn_Guardar_Ventas.Text = "Guardar";
            this.Btn_Guardar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar_Ventas.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Ventas.Click += new System.EventHandler(this.Btn_Guardar_Ventas_Click);
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(997, 102);
            this.Btn_sig.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(95, 98);
            this.Btn_sig.TabIndex = 67;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar_Ventas
            // 
            this.Btn_buscar_Ventas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_buscar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar_Ventas.Image")));
            this.Btn_buscar_Ventas.Location = new System.Drawing.Point(569, 99);
            this.Btn_buscar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar_Ventas.Name = "Btn_buscar_Ventas";
            this.Btn_buscar_Ventas.Size = new System.Drawing.Size(101, 103);
            this.Btn_buscar_Ventas.TabIndex = 61;
            this.Btn_buscar_Ventas.Text = "Consultar";
            this.Btn_buscar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_buscar_Ventas.Click += new System.EventHandler(this.Btn_buscar_Ventas_Click);
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(1100, 100);
            this.Btn_fin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(95, 98);
            this.Btn_fin.TabIndex = 68;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte_Ventas
            // 
            this.Btn_Reporte_Ventas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Reporte_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte_Ventas.Image")));
            this.Btn_Reporte_Ventas.Location = new System.Drawing.Point(676, 99);
            this.Btn_Reporte_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Ventas.Name = "Btn_Reporte_Ventas";
            this.Btn_Reporte_Ventas.Size = new System.Drawing.Size(99, 102);
            this.Btn_Reporte_Ventas.TabIndex = 58;
            this.Btn_Reporte_Ventas.Text = "Imprimir";
            this.Btn_Reporte_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Ingresar_Ventas
            // 
            this.Btn_Ingresar_Ventas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Ingresar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar_Ventas.Image")));
            this.Btn_Ingresar_Ventas.Location = new System.Drawing.Point(35, 100);
            this.Btn_Ingresar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingresar_Ventas.Name = "Btn_Ingresar_Ventas";
            this.Btn_Ingresar_Ventas.Size = new System.Drawing.Size(99, 107);
            this.Btn_Ingresar_Ventas.TabIndex = 55;
            this.Btn_Ingresar_Ventas.Text = "Ingresar";
            this.Btn_Ingresar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Ingresar_Ventas.Click += new System.EventHandler(this.Btn_Ingresar_Ventas_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1203, 102);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(95, 98);
            this.Btn_Ayuda.TabIndex = 57;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Cancelar_Ventas
            // 
            this.Btn_Cancelar_Ventas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Cancelar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar_Ventas.Image")));
            this.Btn_Cancelar_Ventas.Location = new System.Drawing.Point(355, 102);
            this.Btn_Cancelar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar_Ventas.Name = "Btn_Cancelar_Ventas";
            this.Btn_Cancelar_Ventas.Size = new System.Drawing.Size(99, 103);
            this.Btn_Cancelar_Ventas.TabIndex = 56;
            this.Btn_Cancelar_Ventas.Text = "Cancelar";
            this.Btn_Cancelar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Ventas.Click += new System.EventHandler(this.Btn_Cancelar_Ventas_Click);
            // 
            // Btn_Modificar_Ventas
            // 
            this.Btn_Modificar_Ventas.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Modificar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar_Ventas.Image")));
            this.Btn_Modificar_Ventas.Location = new System.Drawing.Point(139, 100);
            this.Btn_Modificar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar_Ventas.Name = "Btn_Modificar_Ventas";
            this.Btn_Modificar_Ventas.Size = new System.Drawing.Size(101, 106);
            this.Btn_Modificar_Ventas.TabIndex = 59;
            this.Btn_Modificar_Ventas.Text = "Modificar";
            this.Btn_Modificar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Modificar_Ventas.Click += new System.EventHandler(this.Btn_Modificar_Ventas_Click);
            // 
            // Frm_Detalle_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1447, 913);
            this.Controls.Add(this.Btn_Salir_Dventas);
            this.Controls.Add(this.Btn_inicio);
            this.Controls.Add(this.GB_Detalle_Ventas);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.GB_Ventas);
            this.Controls.Add(this.Btn_Guardar_Ventas);
            this.Controls.Add(this.Btn_sig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_buscar_Ventas);
            this.Controls.Add(this.Btn_fin);
            this.Controls.Add(this.Btn_Reporte_Ventas);
            this.Controls.Add(this.Btn_Ingresar_Ventas);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar_Ventas);
            this.Controls.Add(this.Btn_Modificar_Ventas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Detalle_Ventas";
            this.Text = "Detalle Ventas";
            this.Load += new System.EventHandler(this.Frm_Detalle_Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB_Ventas.ResumeLayout(false);
            this.GB_Ventas.PerformLayout();
            this.GB_Detalle_Ventas.ResumeLayout(false);
            this.GB_Detalle_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Venta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Ventas;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Venta;
        private System.Windows.Forms.ComboBox Cbo_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Fecha_Venta;
        private System.Windows.Forms.Label Lbl_Id_Cliente;
        private System.Windows.Forms.ComboBox Cbo_Id_Sucursal;
        private System.Windows.Forms.Label Lbl_Id_Sucursal;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Saldo_Total;
        private System.Windows.Forms.Label lbl_Saldo_Total;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar_Ventas;
        private System.Windows.Forms.Button Btn_buscar_Ventas;
        private System.Windows.Forms.Button Btn_Modificar_Ventas;
        private System.Windows.Forms.Button Btn_Reporte_Ventas;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar_Ventas;
        private System.Windows.Forms.Button Btn_Ingresar_Ventas;
        private System.Windows.Forms.GroupBox GB_Detalle_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Id_Bodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Pagar;
        private System.Windows.Forms.NumericUpDown Nud_Cant_Prod;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Id_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Venta;
        private System.Windows.Forms.Button Btn_Limpiar_Detalle_Ventas;
        private System.Windows.Forms.Button Btn_Remover_Detalle_Ventas;
        private System.Windows.Forms.Button Btn_Agregar_Detalle_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Id_Venta;
        private System.Windows.Forms.Label Lbl_IDVenta;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Operacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Salir_Dventas;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_cotizacion_pedido;
        private System.Windows.Forms.Label Lbl_Fecha_Cotizacion_pedido;
        private System.Windows.Forms.ComboBox Cbo_Unidad_Medida;
        private System.Windows.Forms.Label label4;
    }
}