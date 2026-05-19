
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
            this.Btn_Apartar_Stock = new System.Windows.Forms.Button();
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
            this.GB_Detalle = new System.Windows.Forms.GroupBox();
            this.cbo_unidad_medida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_IDBodega = new System.Windows.Forms.ComboBox();
            this.Lbl_IDBodega = new System.Windows.Forms.Label();
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
            this.ID_unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.GB_ENCABEZADO.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GB_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cant_mov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LIMPIAR_ENCABEZADO
            // 
            this.BTN_LIMPIAR_ENCABEZADO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_ENCABEZADO.Image")));
            this.BTN_LIMPIAR_ENCABEZADO.Location = new System.Drawing.Point(571, 99);
            this.BTN_LIMPIAR_ENCABEZADO.Name = "BTN_LIMPIAR_ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.Size = new System.Drawing.Size(86, 80);
            this.BTN_LIMPIAR_ENCABEZADO.TabIndex = 29;
            this.BTN_LIMPIAR_ENCABEZADO.Text = "LIMPIAR ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_ENCABEZADO.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_ENCABEZADO.Click += new System.EventHandler(this.BTN_LIMPIAR_ENCABEZADO_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1105, 99);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 80);
            this.Btn_Salir.TabIndex = 28;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Apartar_Stock
            // 
            this.Btn_Apartar_Stock.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Apartar_Stock.Image")));
            this.Btn_Apartar_Stock.Location = new System.Drawing.Point(203, 100);
            this.Btn_Apartar_Stock.Name = "Btn_Apartar_Stock";
            this.Btn_Apartar_Stock.Size = new System.Drawing.Size(86, 80);
            this.Btn_Apartar_Stock.TabIndex = 25;
            this.Btn_Apartar_Stock.Text = "APARTAR STOCK";
            this.Btn_Apartar_Stock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Apartar_Stock.UseVisualStyleBackColor = true;
            this.Btn_Apartar_Stock.Click += new System.EventHandler(this.Btn_Apartar_Stock_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(479, 99);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(86, 80);
            this.Btn_Reporte.TabIndex = 24;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1013, 99);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(86, 80);
            this.Btn_Ayuda.TabIndex = 23;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(293, 99);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Cancelar.TabIndex = 22;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(104, 99);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(93, 80);
            this.btn_Guardar.TabIndex = 21;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Btn_Agregar_Movimiento
            // 
            this.Btn_Agregar_Movimiento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Movimiento.Image")));
            this.Btn_Agregar_Movimiento.Location = new System.Drawing.Point(8, 98);
            this.Btn_Agregar_Movimiento.Name = "Btn_Agregar_Movimiento";
            this.Btn_Agregar_Movimiento.Size = new System.Drawing.Size(90, 80);
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
            this.GB_ENCABEZADO.Location = new System.Drawing.Point(230, 193);
            this.GB_ENCABEZADO.Name = "GB_ENCABEZADO";
            this.GB_ENCABEZADO.Size = new System.Drawing.Size(866, 234);
            this.GB_ENCABEZADO.TabIndex = 19;
            this.GB_ENCABEZADO.TabStop = false;
            this.GB_ENCABEZADO.Text = "ENCABEZADO";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(24, 152);
            this.txt_descripcion.MinimumSize = new System.Drawing.Size(4, 80);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(645, 26);
            this.txt_descripcion.TabIndex = 9;
            // 
            // Cbo_Id_Movimiento
            // 
            this.Cbo_Id_Movimiento.FormattingEnabled = true;
            this.Cbo_Id_Movimiento.Location = new System.Drawing.Point(155, 29);
            this.Cbo_Id_Movimiento.Name = "Cbo_Id_Movimiento";
            this.Cbo_Id_Movimiento.Size = new System.Drawing.Size(162, 27);
            this.Cbo_Id_Movimiento.TabIndex = 8;
            // 
            // DTP_FECHA_Movimiento
            // 
            this.DTP_FECHA_Movimiento.Location = new System.Drawing.Point(472, 30);
            this.DTP_FECHA_Movimiento.Name = "DTP_FECHA_Movimiento";
            this.DTP_FECHA_Movimiento.Size = new System.Drawing.Size(279, 26);
            this.DTP_FECHA_Movimiento.TabIndex = 6;
            // 
            // CBO_ID_Tipo_Movimiento
            // 
            this.CBO_ID_Tipo_Movimiento.FormattingEnabled = true;
            this.CBO_ID_Tipo_Movimiento.Location = new System.Drawing.Point(155, 80);
            this.CBO_ID_Tipo_Movimiento.MaxLength = 13;
            this.CBO_ID_Tipo_Movimiento.Name = "CBO_ID_Tipo_Movimiento";
            this.CBO_ID_Tipo_Movimiento.Size = new System.Drawing.Size(311, 27);
            this.CBO_ID_Tipo_Movimiento.TabIndex = 5;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(21, 123);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(81, 16);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripcion:";
            // 
            // Lbl_Fecha_Movimiento
            // 
            this.Lbl_Fecha_Movimiento.AutoSize = true;
            this.Lbl_Fecha_Movimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Movimiento.Location = new System.Drawing.Point(345, 34);
            this.Lbl_Fecha_Movimiento.Name = "Lbl_Fecha_Movimiento";
            this.Lbl_Fecha_Movimiento.Size = new System.Drawing.Size(121, 16);
            this.Lbl_Fecha_Movimiento.TabIndex = 2;
            this.Lbl_Fecha_Movimiento.Text = "Fecha_Movimiento:";
            // 
            // Lbl_ID_TipoMovimiento
            // 
            this.Lbl_ID_TipoMovimiento.AutoSize = true;
            this.Lbl_ID_TipoMovimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_TipoMovimiento.Location = new System.Drawing.Point(24, 81);
            this.Lbl_ID_TipoMovimiento.Name = "Lbl_ID_TipoMovimiento";
            this.Lbl_ID_TipoMovimiento.Size = new System.Drawing.Size(125, 16);
            this.Lbl_ID_TipoMovimiento.TabIndex = 1;
            this.Lbl_ID_TipoMovimiento.Text = "Tipo de Movimiento:";
            // 
            // Lbl_IDMovInv
            // 
            this.Lbl_IDMovInv.AutoSize = true;
            this.Lbl_IDMovInv.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDMovInv.Location = new System.Drawing.Point(24, 34);
            this.Lbl_IDMovInv.Name = "Lbl_IDMovInv";
            this.Lbl_IDMovInv.Size = new System.Drawing.Size(94, 16);
            this.Lbl_IDMovInv.TabIndex = 0;
            this.Lbl_IDMovInv.Text = "Id Movimiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 80);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "728 - MOVIMIENTO DE INVENTARIO";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(387, 99);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(86, 80);
            this.btn_buscar.TabIndex = 31;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // GB_Detalle
            // 
            this.GB_Detalle.Controls.Add(this.cbo_unidad_medida);
            this.GB_Detalle.Controls.Add(this.label2);
            this.GB_Detalle.Controls.Add(this.Cbo_IDBodega);
            this.GB_Detalle.Controls.Add(this.Lbl_IDBodega);
            this.GB_Detalle.Controls.Add(this.NUD_Cant_mov);
            this.GB_Detalle.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle.Controls.Add(this.Cbo_ID_Inventario);
            this.GB_Detalle.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle.Controls.Add(this.BTN_LIMPIAR_DETALE);
            this.GB_Detalle.Controls.Add(this.Btn_Remover_Detalle);
            this.GB_Detalle.Controls.Add(this.Btn_Agregar_Detalle);
            this.GB_Detalle.Controls.Add(this.DGV_DETALLE_MOVIMIENTO);
            this.GB_Detalle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle.Location = new System.Drawing.Point(161, 443);
            this.GB_Detalle.Name = "GB_Detalle";
            this.GB_Detalle.Size = new System.Drawing.Size(999, 470);
            this.GB_Detalle.TabIndex = 32;
            this.GB_Detalle.TabStop = false;
            this.GB_Detalle.Text = "DETALLE";
            // 
            // cbo_unidad_medida
            // 
            this.cbo_unidad_medida.FormattingEnabled = true;
            this.cbo_unidad_medida.Location = new System.Drawing.Point(114, 77);
            this.cbo_unidad_medida.Name = "cbo_unidad_medida";
            this.cbo_unidad_medida.Size = new System.Drawing.Size(150, 27);
            this.cbo_unidad_medida.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Unidad Medida";
            // 
            // Cbo_IDBodega
            // 
            this.Cbo_IDBodega.FormattingEnabled = true;
            this.Cbo_IDBodega.Location = new System.Drawing.Point(372, 28);
            this.Cbo_IDBodega.Name = "Cbo_IDBodega";
            this.Cbo_IDBodega.Size = new System.Drawing.Size(162, 27);
            this.Cbo_IDBodega.TabIndex = 19;
            // 
            // Lbl_IDBodega
            // 
            this.Lbl_IDBodega.AutoSize = true;
            this.Lbl_IDBodega.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDBodega.Location = new System.Drawing.Point(303, 35);
            this.Lbl_IDBodega.Name = "Lbl_IDBodega";
            this.Lbl_IDBodega.Size = new System.Drawing.Size(73, 16);
            this.Lbl_IDBodega.TabIndex = 18;
            this.Lbl_IDBodega.Text = "ID Bodega:";
            // 
            // NUD_Cant_mov
            // 
            this.NUD_Cant_mov.Location = new System.Drawing.Point(698, 31);
            this.NUD_Cant_mov.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.NUD_Cant_mov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Cant_mov.Name = "NUD_Cant_mov";
            this.NUD_Cant_mov.Size = new System.Drawing.Size(120, 26);
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
            this.Lbl_Cantidad.Location = new System.Drawing.Point(580, 35);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(112, 16);
            this.Lbl_Cantidad.TabIndex = 15;
            this.Lbl_Cantidad.Text = "Cantidad Movida:";
            // 
            // Cbo_ID_Inventario
            // 
            this.Cbo_ID_Inventario.FormattingEnabled = true;
            this.Cbo_ID_Inventario.Location = new System.Drawing.Point(102, 28);
            this.Cbo_ID_Inventario.Name = "Cbo_ID_Inventario";
            this.Cbo_ID_Inventario.Size = new System.Drawing.Size(162, 27);
            this.Cbo_ID_Inventario.TabIndex = 14;
            // 
            // Lbl_Inventario
            // 
            this.Lbl_Inventario.AutoSize = true;
            this.Lbl_Inventario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventario.Location = new System.Drawing.Point(11, 33);
            this.Lbl_Inventario.Name = "Lbl_Inventario";
            this.Lbl_Inventario.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Inventario.TabIndex = 13;
            this.Lbl_Inventario.Text = "Id Inventario:";
            // 
            // BTN_LIMPIAR_DETALE
            // 
            this.BTN_LIMPIAR_DETALE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_DETALE.Image")));
            this.BTN_LIMPIAR_DETALE.Location = new System.Drawing.Point(870, 207);
            this.BTN_LIMPIAR_DETALE.Name = "BTN_LIMPIAR_DETALE";
            this.BTN_LIMPIAR_DETALE.Size = new System.Drawing.Size(113, 80);
            this.BTN_LIMPIAR_DETALE.TabIndex = 12;
            this.BTN_LIMPIAR_DETALE.Text = "LIMPIAR";
            this.BTN_LIMPIAR_DETALE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_DETALE.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_DETALE.Click += new System.EventHandler(this.BTN_LIMPIAR_DETALE_Click);
            // 
            // Btn_Remover_Detalle
            // 
            this.Btn_Remover_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle.Image")));
            this.Btn_Remover_Detalle.Location = new System.Drawing.Point(870, 121);
            this.Btn_Remover_Detalle.Name = "Btn_Remover_Detalle";
            this.Btn_Remover_Detalle.Size = new System.Drawing.Size(113, 80);
            this.Btn_Remover_Detalle.TabIndex = 11;
            this.Btn_Remover_Detalle.Text = "REMOVER";
            this.Btn_Remover_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Remover_Detalle.Click += new System.EventHandler(this.Btn_Remover_Detalle_Click);
            // 
            // Btn_Agregar_Detalle
            // 
            this.Btn_Agregar_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle.Image")));
            this.Btn_Agregar_Detalle.Location = new System.Drawing.Point(870, 35);
            this.Btn_Agregar_Detalle.Name = "Btn_Agregar_Detalle";
            this.Btn_Agregar_Detalle.Size = new System.Drawing.Size(113, 80);
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
            this.ID_unidad,
            this.UnidadMedida,
            this.ID_Bodega,
            this.Bodega,
            this.Clm_Cantidad});
            this.DGV_DETALLE_MOVIMIENTO.Location = new System.Drawing.Point(14, 121);
            this.DGV_DETALLE_MOVIMIENTO.Name = "DGV_DETALLE_MOVIMIENTO";
            this.DGV_DETALLE_MOVIMIENTO.RowHeadersWidth = 51;
            this.DGV_DETALLE_MOVIMIENTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DETALLE_MOVIMIENTO.Size = new System.Drawing.Size(836, 339);
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
            // ID_unidad
            // 
            this.ID_unidad.HeaderText = "ID Unidad";
            this.ID_unidad.Name = "ID_unidad";
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "Medida_Unidad";
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // ID_Bodega
            // 
            this.ID_Bodega.HeaderText = "ID Bodega";
            this.ID_Bodega.Name = "ID_Bodega";
            // 
            // Bodega
            // 
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.Name = "Bodega";
            // 
            // Clm_Cantidad
            // 
            this.Clm_Cantidad.HeaderText = "Cantidad";
            this.Clm_Cantidad.MinimumWidth = 6;
            this.Clm_Cantidad.Name = "Clm_Cantidad";
            this.Clm_Cantidad.Width = 125;
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(663, 98);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(83, 81);
            this.Btn_inicio.TabIndex = 9;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(752, 98);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(81, 81);
            this.Btn_anterior.TabIndex = 33;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(839, 100);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(81, 79);
            this.Btn_sig.TabIndex = 34;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(926, 100);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(81, 79);
            this.Btn_fin.TabIndex = 35;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Frm_Encabezado_Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 925);
            this.Controls.Add(this.Btn_fin);
            this.Controls.Add(this.Btn_sig);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.Btn_inicio);
            this.Controls.Add(this.GB_Detalle);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_LIMPIAR_ENCABEZADO);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Apartar_Stock);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.Btn_Agregar_Movimiento);
            this.Controls.Add(this.GB_ENCABEZADO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Encabezado_Transaccion";
            this.Text = "Movimiento de Inventario";
            this.GB_ENCABEZADO.ResumeLayout(false);
            this.GB_ENCABEZADO.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB_Detalle.ResumeLayout(false);
            this.GB_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cant_mov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_LIMPIAR_ENCABEZADO;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Apartar_Stock;
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
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox GB_Detalle;
        private System.Windows.Forms.NumericUpDown NUD_Cant_mov;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_ID_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.Button BTN_LIMPIAR_DETALE;
        private System.Windows.Forms.Button Btn_Remover_Detalle;
        private System.Windows.Forms.Button Btn_Agregar_Detalle;
        public System.Windows.Forms.DataGridView DGV_DETALLE_MOVIMIENTO;
        private System.Windows.Forms.ComboBox Cbo_IDBodega;
        private System.Windows.Forms.Label Lbl_IDBodega;
        private System.Windows.Forms.ComboBox cbo_unidad_medida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Cantidad;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_fin;
    }
}