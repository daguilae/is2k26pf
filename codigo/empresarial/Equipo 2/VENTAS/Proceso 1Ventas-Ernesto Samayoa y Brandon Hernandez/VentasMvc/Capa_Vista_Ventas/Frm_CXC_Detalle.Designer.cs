
namespace Capa_Vista_Ventas
{
    partial class Frm_CXC_Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CXC_Detalle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Limpiar_Ventas = new System.Windows.Forms.Button();
            this.Btn_buscar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reporte_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Gbp_encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Txt_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_Venta = new System.Windows.Forms.TextBox();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Ftp_Fecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Deuda = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Vemcimiento = new System.Windows.Forms.Label();
            this.Lbl_fecha_deuda = new System.Windows.Forms.Label();
            this.Lbl_clientes = new System.Windows.Forms.Label();
            this.Lbl_Ventas = new System.Windows.Forms.Label();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Estado_Detalle = new System.Windows.Forms.TextBox();
            this.Lbl_Estado_Detalle = new System.Windows.Forms.Label();
            this.Txt_Monto_Pago = new System.Windows.Forms.TextBox();
            this.Txt_No_Documento = new System.Windows.Forms.TextBox();
            this.Txt_Tipo_Operacion = new System.Windows.Forms.TextBox();
            this.Txt_Id_Detalle = new System.Windows.Forms.TextBox();
            this.Lbl_Monto_Pagado = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Pago = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Tipo_Pago = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Pago = new System.Windows.Forms.Label();
            this.Lbl_NoDocumento = new System.Windows.Forms.Label();
            this.Lbl_Tipo_Operacion = new System.Windows.Forms.Label();
            this.Lbl_id_detalle = new System.Windows.Forms.Label();
            this.Txt_Tipo_Pago = new System.Windows.Forms.TextBox();
            this.Dgv_CXC_Detalle = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Gbp_encabezado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CXC_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 72);
            this.panel1.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "712- Cuenta Por cobrar Detalle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Limpiar_Ventas
            // 
            this.Btn_Limpiar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Ventas.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar_Ventas.Location = new System.Drawing.Point(220, 77);
            this.Btn_Limpiar_Ventas.Name = "Btn_Limpiar_Ventas";
            this.Btn_Limpiar_Ventas.Size = new System.Drawing.Size(83, 80);
            this.Btn_Limpiar_Ventas.TabIndex = 150;
            this.Btn_Limpiar_Ventas.Text = "LIMPIAR";
            this.Btn_Limpiar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar_Ventas
            // 
            this.Btn_buscar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar_Ventas.Image")));
            this.Btn_buscar_Ventas.Location = new System.Drawing.Point(307, 77);
            this.Btn_buscar_Ventas.Name = "Btn_buscar_Ventas";
            this.Btn_buscar_Ventas.Size = new System.Drawing.Size(83, 80);
            this.Btn_buscar_Ventas.TabIndex = 149;
            this.Btn_buscar_Ventas.Text = "BUSCAR";
            this.Btn_buscar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(574, 77);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(83, 80);
            this.Btn_Salir.TabIndex = 148;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Reporte_Ventas
            // 
            this.Btn_Reporte_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte_Ventas.Image")));
            this.Btn_Reporte_Ventas.Location = new System.Drawing.Point(396, 77);
            this.Btn_Reporte_Ventas.Name = "Btn_Reporte_Ventas";
            this.Btn_Reporte_Ventas.Size = new System.Drawing.Size(83, 80);
            this.Btn_Reporte_Ventas.TabIndex = 147;
            this.Btn_Reporte_Ventas.Text = "REPORTE";
            this.Btn_Reporte_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(485, 77);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(83, 80);
            this.Btn_Ayuda.TabIndex = 146;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Gbp_encabezado
            // 
            this.Gbp_encabezado.Controls.Add(this.Txt_Estado);
            this.Gbp_encabezado.Controls.Add(this.Lbl_Estado);
            this.Gbp_encabezado.Controls.Add(this.Txt_Monto);
            this.Gbp_encabezado.Controls.Add(this.Txt_Cliente);
            this.Gbp_encabezado.Controls.Add(this.Txt_Venta);
            this.Gbp_encabezado.Controls.Add(this.Txt_Id);
            this.Gbp_encabezado.Controls.Add(this.Lbl_Monto);
            this.Gbp_encabezado.Controls.Add(this.Ftp_Fecha_Vencimiento);
            this.Gbp_encabezado.Controls.Add(this.Dtp_Fecha_Deuda);
            this.Gbp_encabezado.Controls.Add(this.Lbl_Fecha_Vemcimiento);
            this.Gbp_encabezado.Controls.Add(this.Lbl_fecha_deuda);
            this.Gbp_encabezado.Controls.Add(this.Lbl_clientes);
            this.Gbp_encabezado.Controls.Add(this.Lbl_Ventas);
            this.Gbp_encabezado.Controls.Add(this.Lbl_id);
            this.Gbp_encabezado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_encabezado.Location = new System.Drawing.Point(24, 190);
            this.Gbp_encabezado.Name = "Gbp_encabezado";
            this.Gbp_encabezado.Size = new System.Drawing.Size(947, 198);
            this.Gbp_encabezado.TabIndex = 151;
            this.Gbp_encabezado.TabStop = false;
            this.Gbp_encabezado.Text = "Encabezado Cuenta por Cobrar";
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(305, 151);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(222, 26);
            this.Txt_Estado.TabIndex = 13;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(222, 158);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Estado.TabIndex = 12;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(78, 151);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(121, 26);
            this.Txt_Monto.TabIndex = 11;
            // 
            // Txt_Cliente
            // 
            this.Txt_Cliente.Location = new System.Drawing.Point(618, 17);
            this.Txt_Cliente.Name = "Txt_Cliente";
            this.Txt_Cliente.Size = new System.Drawing.Size(277, 26);
            this.Txt_Cliente.TabIndex = 10;
            // 
            // Txt_Venta
            // 
            this.Txt_Venta.Location = new System.Drawing.Point(283, 24);
            this.Txt_Venta.Name = "Txt_Venta";
            this.Txt_Venta.Size = new System.Drawing.Size(222, 26);
            this.Txt_Venta.TabIndex = 9;
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(65, 28);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(121, 26);
            this.Txt_Id.TabIndex = 8;
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Location = new System.Drawing.Point(6, 158);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(55, 19);
            this.Lbl_Monto.TabIndex = 7;
            this.Lbl_Monto.Text = "Monto";
            // 
            // Ftp_Fecha_Vencimiento
            // 
            this.Ftp_Fecha_Vencimiento.Location = new System.Drawing.Point(604, 95);
            this.Ftp_Fecha_Vencimiento.Name = "Ftp_Fecha_Vencimiento";
            this.Ftp_Fecha_Vencimiento.Size = new System.Drawing.Size(291, 26);
            this.Ftp_Fecha_Vencimiento.TabIndex = 6;
            // 
            // Dtp_Fecha_Deuda
            // 
            this.Dtp_Fecha_Deuda.Location = new System.Drawing.Point(122, 95);
            this.Dtp_Fecha_Deuda.Name = "Dtp_Fecha_Deuda";
            this.Dtp_Fecha_Deuda.Size = new System.Drawing.Size(291, 26);
            this.Dtp_Fecha_Deuda.TabIndex = 5;
            // 
            // Lbl_Fecha_Vemcimiento
            // 
            this.Lbl_Fecha_Vemcimiento.AutoSize = true;
            this.Lbl_Fecha_Vemcimiento.Location = new System.Drawing.Point(450, 102);
            this.Lbl_Fecha_Vemcimiento.Name = "Lbl_Fecha_Vemcimiento";
            this.Lbl_Fecha_Vemcimiento.Size = new System.Drawing.Size(148, 19);
            this.Lbl_Fecha_Vemcimiento.TabIndex = 4;
            this.Lbl_Fecha_Vemcimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_fecha_deuda
            // 
            this.Lbl_fecha_deuda.AutoSize = true;
            this.Lbl_fecha_deuda.Location = new System.Drawing.Point(6, 102);
            this.Lbl_fecha_deuda.Name = "Lbl_fecha_deuda";
            this.Lbl_fecha_deuda.Size = new System.Drawing.Size(110, 19);
            this.Lbl_fecha_deuda.TabIndex = 3;
            this.Lbl_fecha_deuda.Text = "Fecha Deuda ";
            // 
            // Lbl_clientes
            // 
            this.Lbl_clientes.AutoSize = true;
            this.Lbl_clientes.Location = new System.Drawing.Point(537, 24);
            this.Lbl_clientes.Name = "Lbl_clientes";
            this.Lbl_clientes.Size = new System.Drawing.Size(61, 19);
            this.Lbl_clientes.TabIndex = 2;
            this.Lbl_clientes.Text = "Cliente";
            // 
            // Lbl_Ventas
            // 
            this.Lbl_Ventas.AutoSize = true;
            this.Lbl_Ventas.Location = new System.Drawing.Point(213, 31);
            this.Lbl_Ventas.Name = "Lbl_Ventas";
            this.Lbl_Ventas.Size = new System.Drawing.Size(52, 19);
            this.Lbl_Ventas.TabIndex = 1;
            this.Lbl_Ventas.Text = "Venta";
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(21, 35);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(26, 19);
            this.Lbl_id.TabIndex = 0;
            this.Lbl_id.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Tipo_Pago);
            this.groupBox1.Controls.Add(this.Txt_Estado_Detalle);
            this.groupBox1.Controls.Add(this.Lbl_Estado_Detalle);
            this.groupBox1.Controls.Add(this.Txt_Monto_Pago);
            this.groupBox1.Controls.Add(this.Txt_No_Documento);
            this.groupBox1.Controls.Add(this.Txt_Tipo_Operacion);
            this.groupBox1.Controls.Add(this.Txt_Id_Detalle);
            this.groupBox1.Controls.Add(this.Lbl_Monto_Pagado);
            this.groupBox1.Controls.Add(this.Dtp_Fecha_Pago);
            this.groupBox1.Controls.Add(this.Lbl_Tipo_Pago);
            this.groupBox1.Controls.Add(this.Lbl_Fecha_Pago);
            this.groupBox1.Controls.Add(this.Lbl_NoDocumento);
            this.groupBox1.Controls.Add(this.Lbl_Tipo_Operacion);
            this.groupBox1.Controls.Add(this.Lbl_id_detalle);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 198);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado Cuenta por Cobrar";
            // 
            // Txt_Estado_Detalle
            // 
            this.Txt_Estado_Detalle.Location = new System.Drawing.Point(550, 144);
            this.Txt_Estado_Detalle.Name = "Txt_Estado_Detalle";
            this.Txt_Estado_Detalle.Size = new System.Drawing.Size(222, 26);
            this.Txt_Estado_Detalle.TabIndex = 13;
            // 
            // Lbl_Estado_Detalle
            // 
            this.Lbl_Estado_Detalle.AutoSize = true;
            this.Lbl_Estado_Detalle.Location = new System.Drawing.Point(446, 147);
            this.Lbl_Estado_Detalle.Name = "Lbl_Estado_Detalle";
            this.Lbl_Estado_Detalle.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Estado_Detalle.TabIndex = 12;
            this.Lbl_Estado_Detalle.Text = "Estado";
            // 
            // Txt_Monto_Pago
            // 
            this.Txt_Monto_Pago.Location = new System.Drawing.Point(127, 155);
            this.Txt_Monto_Pago.Name = "Txt_Monto_Pago";
            this.Txt_Monto_Pago.Size = new System.Drawing.Size(286, 26);
            this.Txt_Monto_Pago.TabIndex = 11;
            // 
            // Txt_No_Documento
            // 
            this.Txt_No_Documento.Location = new System.Drawing.Point(705, 17);
            this.Txt_No_Documento.Name = "Txt_No_Documento";
            this.Txt_No_Documento.Size = new System.Drawing.Size(222, 26);
            this.Txt_No_Documento.TabIndex = 10;
            // 
            // Txt_Tipo_Operacion
            // 
            this.Txt_Tipo_Operacion.Location = new System.Drawing.Point(342, 25);
            this.Txt_Tipo_Operacion.Name = "Txt_Tipo_Operacion";
            this.Txt_Tipo_Operacion.Size = new System.Drawing.Size(222, 26);
            this.Txt_Tipo_Operacion.TabIndex = 9;
            // 
            // Txt_Id_Detalle
            // 
            this.Txt_Id_Detalle.Location = new System.Drawing.Point(70, 35);
            this.Txt_Id_Detalle.Name = "Txt_Id_Detalle";
            this.Txt_Id_Detalle.Size = new System.Drawing.Size(121, 26);
            this.Txt_Id_Detalle.TabIndex = 8;
            // 
            // Lbl_Monto_Pagado
            // 
            this.Lbl_Monto_Pagado.AutoSize = true;
            this.Lbl_Monto_Pagado.Location = new System.Drawing.Point(6, 158);
            this.Lbl_Monto_Pagado.Name = "Lbl_Monto_Pagado";
            this.Lbl_Monto_Pagado.Size = new System.Drawing.Size(115, 19);
            this.Lbl_Monto_Pagado.TabIndex = 7;
            this.Lbl_Monto_Pagado.Text = "Monto Pagado";
            // 
            // Dtp_Fecha_Pago
            // 
            this.Dtp_Fecha_Pago.Location = new System.Drawing.Point(122, 95);
            this.Dtp_Fecha_Pago.Name = "Dtp_Fecha_Pago";
            this.Dtp_Fecha_Pago.Size = new System.Drawing.Size(291, 26);
            this.Dtp_Fecha_Pago.TabIndex = 5;
            // 
            // Lbl_Tipo_Pago
            // 
            this.Lbl_Tipo_Pago.AutoSize = true;
            this.Lbl_Tipo_Pago.Location = new System.Drawing.Point(436, 101);
            this.Lbl_Tipo_Pago.Name = "Lbl_Tipo_Pago";
            this.Lbl_Tipo_Pago.Size = new System.Drawing.Size(86, 19);
            this.Lbl_Tipo_Pago.TabIndex = 4;
            this.Lbl_Tipo_Pago.Text = "Tipo Pago ";
            // 
            // Lbl_Fecha_Pago
            // 
            this.Lbl_Fecha_Pago.AutoSize = true;
            this.Lbl_Fecha_Pago.Location = new System.Drawing.Point(6, 101);
            this.Lbl_Fecha_Pago.Name = "Lbl_Fecha_Pago";
            this.Lbl_Fecha_Pago.Size = new System.Drawing.Size(98, 19);
            this.Lbl_Fecha_Pago.TabIndex = 3;
            this.Lbl_Fecha_Pago.Text = "Fecha Pago ";
            // 
            // Lbl_NoDocumento
            // 
            this.Lbl_NoDocumento.AutoSize = true;
            this.Lbl_NoDocumento.Location = new System.Drawing.Point(570, 25);
            this.Lbl_NoDocumento.Name = "Lbl_NoDocumento";
            this.Lbl_NoDocumento.Size = new System.Drawing.Size(119, 19);
            this.Lbl_NoDocumento.TabIndex = 2;
            this.Lbl_NoDocumento.Text = "No,Documento";
            // 
            // Lbl_Tipo_Operacion
            // 
            this.Lbl_Tipo_Operacion.AutoSize = true;
            this.Lbl_Tipo_Operacion.Location = new System.Drawing.Point(213, 31);
            this.Lbl_Tipo_Operacion.Name = "Lbl_Tipo_Operacion";
            this.Lbl_Tipo_Operacion.Size = new System.Drawing.Size(123, 19);
            this.Lbl_Tipo_Operacion.TabIndex = 1;
            this.Lbl_Tipo_Operacion.Text = "Tipo Operación";
            // 
            // Lbl_id_detalle
            // 
            this.Lbl_id_detalle.AutoSize = true;
            this.Lbl_id_detalle.Location = new System.Drawing.Point(21, 35);
            this.Lbl_id_detalle.Name = "Lbl_id_detalle";
            this.Lbl_id_detalle.Size = new System.Drawing.Size(26, 19);
            this.Lbl_id_detalle.TabIndex = 0;
            this.Lbl_id_detalle.Text = "ID";
            // 
            // Txt_Tipo_Pago
            // 
            this.Txt_Tipo_Pago.Location = new System.Drawing.Point(541, 101);
            this.Txt_Tipo_Pago.Name = "Txt_Tipo_Pago";
            this.Txt_Tipo_Pago.Size = new System.Drawing.Size(222, 26);
            this.Txt_Tipo_Pago.TabIndex = 14;
            // 
            // Dgv_CXC_Detalle
            // 
            this.Dgv_CXC_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CXC_Detalle.Location = new System.Drawing.Point(24, 609);
            this.Dgv_CXC_Detalle.Name = "Dgv_CXC_Detalle";
            this.Dgv_CXC_Detalle.Size = new System.Drawing.Size(1024, 269);
            this.Dgv_CXC_Detalle.TabIndex = 153;
            // 
            // Frm_CXC_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 901);
            this.Controls.Add(this.Dgv_CXC_Detalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gbp_encabezado);
            this.Controls.Add(this.Btn_Limpiar_Ventas);
            this.Controls.Add(this.Btn_buscar_Ventas);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte_Ventas);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_CXC_Detalle";
            this.Text = "Cuentas Por Cobrar Detalle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gbp_encabezado.ResumeLayout(false);
            this.Gbp_encabezado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CXC_Detalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Limpiar_Ventas;
        private System.Windows.Forms.Button Btn_buscar_Ventas;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Reporte_Ventas;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.GroupBox Gbp_encabezado;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.TextBox Txt_Cliente;
        private System.Windows.Forms.TextBox Txt_Venta;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.DateTimePicker Ftp_Fecha_Vencimiento;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Deuda;
        private System.Windows.Forms.Label Lbl_Fecha_Vemcimiento;
        private System.Windows.Forms.Label Lbl_fecha_deuda;
        private System.Windows.Forms.Label Lbl_clientes;
        private System.Windows.Forms.Label Lbl_Ventas;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Estado_Detalle;
        private System.Windows.Forms.Label Lbl_Estado_Detalle;
        private System.Windows.Forms.TextBox Txt_Monto_Pago;
        private System.Windows.Forms.TextBox Txt_No_Documento;
        private System.Windows.Forms.TextBox Txt_Tipo_Operacion;
        private System.Windows.Forms.TextBox Txt_Id_Detalle;
        private System.Windows.Forms.Label Lbl_Monto_Pagado;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Pago;
        private System.Windows.Forms.Label Lbl_Tipo_Pago;
        private System.Windows.Forms.Label Lbl_Fecha_Pago;
        private System.Windows.Forms.Label Lbl_NoDocumento;
        private System.Windows.Forms.Label Lbl_Tipo_Operacion;
        private System.Windows.Forms.Label Lbl_id_detalle;
        private System.Windows.Forms.TextBox Txt_Tipo_Pago;
        private System.Windows.Forms.DataGridView Dgv_CXC_Detalle;
    }
}