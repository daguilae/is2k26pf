
namespace Capa_Vista_Mov_Inv
{
    partial class Frm_Encabezado_Transaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Encabezado_Transaccion));
            this.BTN_LIMPIAR_ENCABEZADO = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.GB_Detalle = new System.Windows.Forms.GroupBox();
            this.NUD_Cant_mov = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_ID_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.BTN_LIMPIAR_DETALE = new System.Windows.Forms.Button();
            this.Btn_Remover_Detalle = new System.Windows.Forms.Button();
            this.Btn_Agregar_Detalle = new System.Windows.Forms.Button();
            this.DGV_DETALLE_MOVIMIENTO = new System.Windows.Forms.DataGridView();
            this.Clm_ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Agregar_Movimiento = new System.Windows.Forms.Button();
            this.GB_ENCABEZADO = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.Cbo_Id_Movimiento = new System.Windows.Forms.ComboBox();
            this.DTP_FECHA_Movimiento = new System.Windows.Forms.DateTimePicker();
            this.CBO_ID_Tipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Movimiento = new System.Windows.Forms.Label();
            this.Lbl_ID_TipoMovimiento = new System.Windows.Forms.Label();
            this.Lbl_IDMovInv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.GB_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cant_mov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).BeginInit();
            this.GB_ENCABEZADO.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_LIMPIAR_ENCABEZADO
            // 
            this.BTN_LIMPIAR_ENCABEZADO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_ENCABEZADO.Image")));
            this.BTN_LIMPIAR_ENCABEZADO.Location = new System.Drawing.Point(632, 137);
            this.BTN_LIMPIAR_ENCABEZADO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_LIMPIAR_ENCABEZADO.Name = "BTN_LIMPIAR_ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.Size = new System.Drawing.Size(115, 98);
            this.BTN_LIMPIAR_ENCABEZADO.TabIndex = 29;
            this.BTN_LIMPIAR_ENCABEZADO.Text = "LIMPIAR ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_ENCABEZADO.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_ENCABEZADO.Click += new System.EventHandler(this.BTN_LIMPIAR_ENCABEZADO_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(996, 137);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(115, 98);
            this.Btn_Salir.TabIndex = 28;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // GB_Detalle
            // 
            this.GB_Detalle.Controls.Add(this.NUD_Cant_mov);
            this.GB_Detalle.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle.Controls.Add(this.Cbo_ID_Inventario);
            this.GB_Detalle.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle.Controls.Add(this.BTN_LIMPIAR_DETALE);
            this.GB_Detalle.Controls.Add(this.Btn_Remover_Detalle);
            this.GB_Detalle.Controls.Add(this.Btn_Agregar_Detalle);
            this.GB_Detalle.Controls.Add(this.DGV_DETALLE_MOVIMIENTO);
            this.GB_Detalle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle.Location = new System.Drawing.Point(4, 559);
            this.GB_Detalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Detalle.Name = "GB_Detalle";
            this.GB_Detalle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_Detalle.Size = new System.Drawing.Size(1107, 533);
            this.GB_Detalle.TabIndex = 27;
            this.GB_Detalle.TabStop = false;
            this.GB_Detalle.Text = "DETALLE";
            // 
            // NUD_Cant_mov
            // 
            this.NUD_Cant_mov.Location = new System.Drawing.Point(727, 137);
            this.NUD_Cant_mov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NUD_Cant_mov.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUD_Cant_mov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Cant_mov.Name = "NUD_Cant_mov";
            this.NUD_Cant_mov.Size = new System.Drawing.Size(160, 31);
            this.NUD_Cant_mov.TabIndex = 17;
            this.NUD_Cant_mov.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(557, 143);
            this.Lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(147, 20);
            this.Lbl_Cantidad.TabIndex = 15;
            this.Lbl_Cantidad.Text = "Cantidad Movida:";
            // 
            // Cbo_ID_Inventario
            // 
            this.Cbo_ID_Inventario.FormattingEnabled = true;
            this.Cbo_ID_Inventario.Location = new System.Drawing.Point(197, 137);
            this.Cbo_ID_Inventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_ID_Inventario.Name = "Cbo_ID_Inventario";
            this.Cbo_ID_Inventario.Size = new System.Drawing.Size(215, 30);
            this.Cbo_ID_Inventario.TabIndex = 14;
            // 
            // Lbl_Inventario
            // 
            this.Lbl_Inventario.AutoSize = true;
            this.Lbl_Inventario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventario.Location = new System.Drawing.Point(23, 143);
            this.Lbl_Inventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Inventario.Name = "Lbl_Inventario";
            this.Lbl_Inventario.Size = new System.Drawing.Size(113, 20);
            this.Lbl_Inventario.TabIndex = 13;
            this.Lbl_Inventario.Text = "Id Inventario:";
            // 
            // BTN_LIMPIAR_DETALE
            // 
            this.BTN_LIMPIAR_DETALE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_DETALE.Image")));
            this.BTN_LIMPIAR_DETALE.Location = new System.Drawing.Point(348, 23);
            this.BTN_LIMPIAR_DETALE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_LIMPIAR_DETALE.Name = "BTN_LIMPIAR_DETALE";
            this.BTN_LIMPIAR_DETALE.Size = new System.Drawing.Size(151, 98);
            this.BTN_LIMPIAR_DETALE.TabIndex = 12;
            this.BTN_LIMPIAR_DETALE.Text = "LIMPIAR";
            this.BTN_LIMPIAR_DETALE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_DETALE.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_DETALE.Click += new System.EventHandler(this.BTN_LIMPIAR_DETALE_Click);
            // 
            // Btn_Remover_Detalle
            // 
            this.Btn_Remover_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle.Image")));
            this.Btn_Remover_Detalle.Location = new System.Drawing.Point(189, 23);
            this.Btn_Remover_Detalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Remover_Detalle.Name = "Btn_Remover_Detalle";
            this.Btn_Remover_Detalle.Size = new System.Drawing.Size(151, 98);
            this.Btn_Remover_Detalle.TabIndex = 11;
            this.Btn_Remover_Detalle.Text = "REMOVER";
            this.Btn_Remover_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Remover_Detalle.Click += new System.EventHandler(this.Btn_Remover_Detalle_Click);
            // 
            // Btn_Agregar_Detalle
            // 
            this.Btn_Agregar_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle.Image")));
            this.Btn_Agregar_Detalle.Location = new System.Drawing.Point(27, 23);
            this.Btn_Agregar_Detalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Agregar_Detalle.Name = "Btn_Agregar_Detalle";
            this.Btn_Agregar_Detalle.Size = new System.Drawing.Size(155, 98);
            this.Btn_Agregar_Detalle.TabIndex = 9;
            this.Btn_Agregar_Detalle.Text = "AGREGAR";
            this.Btn_Agregar_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Detalle.Click += new System.EventHandler(this.Btn_Agregar_Detalle_Click);
            // 
            // DGV_DETALLE_MOVIMIENTO
            // 
            this.DGV_DETALLE_MOVIMIENTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DETALLE_MOVIMIENTO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_ID_Producto,
            this.Clm_Producto,
            this.Clm_Cantidad});
            this.DGV_DETALLE_MOVIMIENTO.Location = new System.Drawing.Point(27, 198);
            this.DGV_DETALLE_MOVIMIENTO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_DETALLE_MOVIMIENTO.Name = "DGV_DETALLE_MOVIMIENTO";
            this.DGV_DETALLE_MOVIMIENTO.RowHeadersWidth = 51;
            this.DGV_DETALLE_MOVIMIENTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DETALLE_MOVIMIENTO.Size = new System.Drawing.Size(1052, 313);
            this.DGV_DETALLE_MOVIMIENTO.TabIndex = 10;
            // 
            // Clm_ID_Producto
            // 
            this.Clm_ID_Producto.HeaderText = "ID Producto";
            this.Clm_ID_Producto.MinimumWidth = 6;
            this.Clm_ID_Producto.Name = "Clm_ID_Producto";
            this.Clm_ID_Producto.Width = 125;
            // 
            // Clm_Producto
            // 
            this.Clm_Producto.HeaderText = "Producto";
            this.Clm_Producto.MinimumWidth = 6;
            this.Clm_Producto.Name = "Clm_Producto";
            this.Clm_Producto.Width = 125;
            // 
            // Clm_Cantidad
            // 
            this.Clm_Cantidad.HeaderText = "Cantidad";
            this.Clm_Cantidad.MinimumWidth = 6;
            this.Clm_Cantidad.Name = "Clm_Cantidad";
            this.Clm_Cantidad.Width = 125;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(387, 137);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(115, 98);
            this.Btn_Modificar.TabIndex = 25;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(751, 137);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(115, 98);
            this.Btn_Reporte.TabIndex = 24;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(873, 137);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(115, 98);
            this.Btn_Ayuda.TabIndex = 23;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(264, 137);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(115, 98);
            this.Btn_Cancelar.TabIndex = 22;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(956, 244);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(176, 98);
            this.btn_Guardar.TabIndex = 21;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Agregar_Movimiento
            // 
            this.Btn_Agregar_Movimiento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Movimiento.Image")));
            this.Btn_Agregar_Movimiento.Location = new System.Drawing.Point(16, 114);
            this.Btn_Agregar_Movimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Agregar_Movimiento.Name = "Btn_Agregar_Movimiento";
            this.Btn_Agregar_Movimiento.Size = new System.Drawing.Size(176, 98);
            this.Btn_Agregar_Movimiento.TabIndex = 20;
            this.Btn_Agregar_Movimiento.Text = "ADD Movimiento";
            this.Btn_Agregar_Movimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Movimiento.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Movimiento.Click += new System.EventHandler(this.Btn_Agregar_Movimiento_Click);
            // 
            // GB_ENCABEZADO
            // 
            this.GB_ENCABEZADO.Controls.Add(this.txt_descripcion);
            this.GB_ENCABEZADO.Controls.Add(this.Cbo_Id_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.DTP_FECHA_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.CBO_ID_Tipo_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_Descripcion);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_Fecha_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_ID_TipoMovimiento);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_IDMovInv);
            this.GB_ENCABEZADO.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ENCABEZADO.Location = new System.Drawing.Point(4, 230);
            this.GB_ENCABEZADO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_ENCABEZADO.Name = "GB_ENCABEZADO";
            this.GB_ENCABEZADO.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GB_ENCABEZADO.Size = new System.Drawing.Size(924, 297);
            this.GB_ENCABEZADO.TabIndex = 19;
            this.GB_ENCABEZADO.TabStop = false;
            this.GB_ENCABEZADO.Text = "ENCABEZADO";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(27, 174);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descripcion.MinimumSize = new System.Drawing.Size(4, 80);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(859, 31);
            this.txt_descripcion.TabIndex = 9;
            // 
            // Cbo_Id_Movimiento
            // 
            this.Cbo_Id_Movimiento.FormattingEnabled = true;
            this.Cbo_Id_Movimiento.Location = new System.Drawing.Point(207, 36);
            this.Cbo_Id_Movimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Id_Movimiento.Name = "Cbo_Id_Movimiento";
            this.Cbo_Id_Movimiento.Size = new System.Drawing.Size(215, 30);
            this.Cbo_Id_Movimiento.TabIndex = 8;
            // 
            // DTP_FECHA_Movimiento
            // 
            this.DTP_FECHA_Movimiento.Location = new System.Drawing.Point(629, 37);
            this.DTP_FECHA_Movimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTP_FECHA_Movimiento.Name = "DTP_FECHA_Movimiento";
            this.DTP_FECHA_Movimiento.Size = new System.Drawing.Size(265, 31);
            this.DTP_FECHA_Movimiento.TabIndex = 6;
            // 
            // CBO_ID_Tipo_Movimiento
            // 
            this.CBO_ID_Tipo_Movimiento.FormattingEnabled = true;
            this.CBO_ID_Tipo_Movimiento.Location = new System.Drawing.Point(207, 86);
            this.CBO_ID_Tipo_Movimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBO_ID_Tipo_Movimiento.MaxLength = 13;
            this.CBO_ID_Tipo_Movimiento.Name = "CBO_ID_Tipo_Movimiento";
            this.CBO_ID_Tipo_Movimiento.Size = new System.Drawing.Size(413, 30);
            this.CBO_ID_Tipo_Movimiento.TabIndex = 5;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(32, 134);
            this.Lbl_Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(109, 20);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripcion:";
            // 
            // Lbl_Fecha_Movimiento
            // 
            this.Lbl_Fecha_Movimiento.AutoSize = true;
            this.Lbl_Fecha_Movimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Movimiento.Location = new System.Drawing.Point(460, 42);
            this.Lbl_Fecha_Movimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Movimiento.Name = "Lbl_Fecha_Movimiento";
            this.Lbl_Fecha_Movimiento.Size = new System.Drawing.Size(164, 20);
            this.Lbl_Fecha_Movimiento.TabIndex = 2;
            this.Lbl_Fecha_Movimiento.Text = "Fecha_Movimiento:";
            // 
            // Lbl_ID_TipoMovimiento
            // 
            this.Lbl_ID_TipoMovimiento.AutoSize = true;
            this.Lbl_ID_TipoMovimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_TipoMovimiento.Location = new System.Drawing.Point(32, 92);
            this.Lbl_ID_TipoMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ID_TipoMovimiento.Name = "Lbl_ID_TipoMovimiento";
            this.Lbl_ID_TipoMovimiento.Size = new System.Drawing.Size(171, 20);
            this.Lbl_ID_TipoMovimiento.TabIndex = 1;
            this.Lbl_ID_TipoMovimiento.Text = "Tipo de Movimiento:";
            // 
            // Lbl_IDMovInv
            // 
            this.Lbl_IDMovInv.AutoSize = true;
            this.Lbl_IDMovInv.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDMovInv.Location = new System.Drawing.Point(32, 42);
            this.Lbl_IDMovInv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDMovInv.Name = "Lbl_IDMovInv";
            this.Lbl_IDMovInv.Size = new System.Drawing.Size(127, 20);
            this.Lbl_IDMovInv.TabIndex = 0;
            this.Lbl_IDMovInv.Text = "Id Movimiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 98);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimiento De Inventario";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(509, 137);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(115, 98);
            this.btn_buscar.TabIndex = 31;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Frm_Encabezado_Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 1055);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_LIMPIAR_ENCABEZADO);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.GB_Detalle);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.Btn_Agregar_Movimiento);
            this.Controls.Add(this.GB_ENCABEZADO);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Encabezado_Transaccion";
            this.Text = "Movimiento de Inventario";
            this.GB_Detalle.ResumeLayout(false);
            this.GB_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cant_mov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).EndInit();
            this.GB_ENCABEZADO.ResumeLayout(false);
            this.GB_ENCABEZADO.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_LIMPIAR_ENCABEZADO;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.GroupBox GB_Detalle;
        private System.Windows.Forms.Button BTN_LIMPIAR_DETALE;
        private System.Windows.Forms.Button Btn_Remover_Detalle;
        private System.Windows.Forms.Button Btn_Agregar_Detalle;
        private System.Windows.Forms.DataGridView DGV_DETALLE_MOVIMIENTO;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button Btn_Agregar_Movimiento;
        private System.Windows.Forms.GroupBox GB_ENCABEZADO;
        private System.Windows.Forms.ComboBox Cbo_Id_Movimiento;
        private System.Windows.Forms.DateTimePicker DTP_FECHA_Movimiento;
        private System.Windows.Forms.ComboBox CBO_ID_Tipo_Movimiento;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Fecha_Movimiento;
        private System.Windows.Forms.Label Lbl_ID_TipoMovimiento;
        private System.Windows.Forms.Label Lbl_IDMovInv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_ID_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.NumericUpDown NUD_Cant_mov;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Cantidad;
    }
}