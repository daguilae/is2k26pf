namespace Capa_Vista_RO
{
    partial class Frm_Detalle_Orden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_Orden));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_UnidadDeMedida = new System.Windows.Forms.TextBox();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Udm = new System.Windows.Forms.Label();
            this.Lbl_Material = new System.Windows.Forms.Label();
            this.Lbl_IDMaterial = new System.Windows.Forms.Label();
            this.Nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Cmb_IDMat = new System.Windows.Forms.ComboBox();
            this.Cmb_NombreMat = new System.Windows.Forms.ComboBox();
            this.Btn_eliminarMat = new System.Windows.Forms.Button();
            this.Btn_agregarMat = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Dgv_Materiales = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rtxt_Observaciones = new System.Windows.Forms.RichTextBox();
            this.Dtp_Requerida = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Recepcion = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Cmb_ID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materiales)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1517, 738);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_UnidadDeMedida);
            this.panel3.Controls.Add(this.Lbl_Cantidad);
            this.panel3.Controls.Add(this.Lbl_Udm);
            this.panel3.Controls.Add(this.Lbl_Material);
            this.panel3.Controls.Add(this.Lbl_IDMaterial);
            this.panel3.Controls.Add(this.Nud_Cantidad);
            this.panel3.Controls.Add(this.Cmb_IDMat);
            this.panel3.Controls.Add(this.Cmb_NombreMat);
            this.panel3.Controls.Add(this.Btn_eliminarMat);
            this.panel3.Controls.Add(this.Btn_agregarMat);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.Dgv_Materiales);
            this.panel3.Location = new System.Drawing.Point(468, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 667);
            this.panel3.TabIndex = 14;
            // 
            // txt_UnidadDeMedida
            // 
            this.txt_UnidadDeMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnidadDeMedida.Enabled = false;
            this.txt_UnidadDeMedida.Location = new System.Drawing.Point(868, 92);
            this.txt_UnidadDeMedida.Name = "txt_UnidadDeMedida";
            this.txt_UnidadDeMedida.Size = new System.Drawing.Size(120, 22);
            this.txt_UnidadDeMedida.TabIndex = 37;
            this.txt_UnidadDeMedida.TextChanged += new System.EventHandler(this.txt_UnidadDeMedida_TextChanged);
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(758, 150);
            this.Lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(102, 22);
            this.Lbl_Cantidad.TabIndex = 36;
            this.Lbl_Cantidad.Text = "Cantidad:";
            // 
            // Lbl_Udm
            // 
            this.Lbl_Udm.AutoSize = true;
            this.Lbl_Udm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Udm.Location = new System.Drawing.Point(670, 92);
            this.Lbl_Udm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Udm.Name = "Lbl_Udm";
            this.Lbl_Udm.Size = new System.Drawing.Size(190, 22);
            this.Lbl_Udm.TabIndex = 35;
            this.Lbl_Udm.Text = "Unidad de Medida:";
            // 
            // Lbl_Material
            // 
            this.Lbl_Material.AutoSize = true;
            this.Lbl_Material.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Material.Location = new System.Drawing.Point(254, 150);
            this.Lbl_Material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Material.Name = "Lbl_Material";
            this.Lbl_Material.Size = new System.Drawing.Size(172, 22);
            this.Lbl_Material.TabIndex = 34;
            this.Lbl_Material.Text = "Nombre Material:";
            // 
            // Lbl_IDMaterial
            // 
            this.Lbl_IDMaterial.AutoSize = true;
            this.Lbl_IDMaterial.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDMaterial.Location = new System.Drawing.Point(307, 94);
            this.Lbl_IDMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDMaterial.Name = "Lbl_IDMaterial";
            this.Lbl_IDMaterial.Size = new System.Drawing.Size(119, 22);
            this.Lbl_IDMaterial.TabIndex = 28;
            this.Lbl_IDMaterial.Text = "ID Material:";
            // 
            // Nud_Cantidad
            // 
            this.Nud_Cantidad.Location = new System.Drawing.Point(868, 151);
            this.Nud_Cantidad.Name = "Nud_Cantidad";
            this.Nud_Cantidad.Size = new System.Drawing.Size(120, 22);
            this.Nud_Cantidad.TabIndex = 33;
            this.Nud_Cantidad.ValueChanged += new System.EventHandler(this.Nud_Cantidad_ValueChanged);
            // 
            // Cmb_IDMat
            // 
            this.Cmb_IDMat.FormattingEnabled = true;
            this.Cmb_IDMat.Location = new System.Drawing.Point(444, 94);
            this.Cmb_IDMat.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_IDMat.Name = "Cmb_IDMat";
            this.Cmb_IDMat.Size = new System.Drawing.Size(157, 24);
            this.Cmb_IDMat.TabIndex = 30;
            this.Cmb_IDMat.SelectedIndexChanged += new System.EventHandler(this.Cmb_IDMat_SelectedIndexChanged);
            // 
            // Cmb_NombreMat
            // 
            this.Cmb_NombreMat.FormattingEnabled = true;
            this.Cmb_NombreMat.Location = new System.Drawing.Point(444, 148);
            this.Cmb_NombreMat.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_NombreMat.Name = "Cmb_NombreMat";
            this.Cmb_NombreMat.Size = new System.Drawing.Size(288, 24);
            this.Cmb_NombreMat.TabIndex = 28;
            this.Cmb_NombreMat.SelectedIndexChanged += new System.EventHandler(this.Cmb_NombreMat_SelectedIndexChanged);
            // 
            // Btn_eliminarMat
            // 
            this.Btn_eliminarMat.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminarMat.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminarMat.Image")));
            this.Btn_eliminarMat.Location = new System.Drawing.Point(144, 80);
            this.Btn_eliminarMat.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminarMat.Name = "Btn_eliminarMat";
            this.Btn_eliminarMat.Size = new System.Drawing.Size(99, 107);
            this.Btn_eliminarMat.TabIndex = 14;
            this.Btn_eliminarMat.Text = "Eliminar";
            this.Btn_eliminarMat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminarMat.UseVisualStyleBackColor = true;
            this.Btn_eliminarMat.Click += new System.EventHandler(this.Btn_eliminarMat_Click);
            // 
            // Btn_agregarMat
            // 
            this.Btn_agregarMat.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarMat.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregarMat.Image")));
            this.Btn_agregarMat.Location = new System.Drawing.Point(37, 80);
            this.Btn_agregarMat.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregarMat.Name = "Btn_agregarMat";
            this.Btn_agregarMat.Size = new System.Drawing.Size(99, 107);
            this.Btn_agregarMat.TabIndex = 14;
            this.Btn_agregarMat.Text = "Agregar";
            this.Btn_agregarMat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_agregarMat.UseVisualStyleBackColor = true;
            this.Btn_agregarMat.Click += new System.EventHandler(this.Btn_agregarMat_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(27, 18, 20, 18);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1023, 72);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Materiales de la Orden";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(916, 622);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "0.00";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(797, 617);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total:";
            // 
            // Dgv_Materiales
            // 
            this.Dgv_Materiales.AllowUserToAddRows = false;
            this.Dgv_Materiales.AllowUserToDeleteRows = false;
            this.Dgv_Materiales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Materiales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Materiales.Location = new System.Drawing.Point(37, 194);
            this.Dgv_Materiales.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Materiales.Name = "Dgv_Materiales";
            this.Dgv_Materiales.ReadOnly = true;
            this.Dgv_Materiales.RowHeadersWidth = 51;
            this.Dgv_Materiales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Materiales.Size = new System.Drawing.Size(951, 393);
            this.Dgv_Materiales.TabIndex = 0;
            this.Dgv_Materiales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Materiales_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Rtxt_Observaciones);
            this.panel2.Controls.Add(this.Dtp_Requerida);
            this.panel2.Controls.Add(this.Dtp_Recepcion);
            this.panel2.Controls.Add(this.Cmb_Estado);
            this.panel2.Controls.Add(this.Cmb_ID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(28, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 667);
            this.panel2.TabIndex = 13;
            // 
            // Rtxt_Observaciones
            // 
            this.Rtxt_Observaciones.Location = new System.Drawing.Point(24, 378);
            this.Rtxt_Observaciones.Margin = new System.Windows.Forms.Padding(4);
            this.Rtxt_Observaciones.Name = "Rtxt_Observaciones";
            this.Rtxt_Observaciones.Size = new System.Drawing.Size(363, 106);
            this.Rtxt_Observaciones.TabIndex = 27;
            this.Rtxt_Observaciones.Text = "";
            // 
            // Dtp_Requerida
            // 
            this.Dtp_Requerida.Location = new System.Drawing.Point(24, 302);
            this.Dtp_Requerida.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Requerida.Name = "Dtp_Requerida";
            this.Dtp_Requerida.Size = new System.Drawing.Size(363, 22);
            this.Dtp_Requerida.TabIndex = 25;
            // 
            // Dtp_Recepcion
            // 
            this.Dtp_Recepcion.Location = new System.Drawing.Point(24, 241);
            this.Dtp_Recepcion.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Recepcion.Name = "Dtp_Recepcion";
            this.Dtp_Recepcion.Size = new System.Drawing.Size(363, 22);
            this.Dtp_Recepcion.TabIndex = 24;
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(24, 181);
            this.Cmb_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(363, 24);
            this.Cmb_Estado.TabIndex = 23;
            this.Cmb_Estado.SelectedIndexChanged += new System.EventHandler(this.label2_Click);
            // 
            // Cmb_ID
            // 
            this.Cmb_ID.FormattingEnabled = true;
            this.Cmb_ID.Location = new System.Drawing.Point(24, 121);
            this.Cmb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_ID.Name = "Cmb_ID";
            this.Cmb_ID.Size = new System.Drawing.Size(363, 24);
            this.Cmb_ID.TabIndex = 22;
            this.Cmb_ID.SelectedIndexChanged += new System.EventHandler(this.Cmb_ID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 332);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Observaciones:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha Requerida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha de Recepcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID Orden:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(27, 18, 20, 18);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(409, 72);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datos de la Orden";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 53);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1424, 14);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "Detalle de Orden Recibida";
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.Location = new System.Drawing.Point(4, 4);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(99, 107);
            this.Btn_ingresar.TabIndex = 0;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Enabled = false;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(111, 4);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(99, 107);
            this.Btn_modificar.TabIndex = 1;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(217, 4);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(99, 107);
            this.Btn_guardar.TabIndex = 2;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(324, 4);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(99, 107);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(431, 4);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(99, 107);
            this.Btn_eliminar.TabIndex = 4;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.Location = new System.Drawing.Point(537, 4);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(99, 107);
            this.Btn_consultar.TabIndex = 5;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.Image")));
            this.Btn_refrescar.Location = new System.Drawing.Point(751, 4);
            this.Btn_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(99, 107);
            this.Btn_refrescar.TabIndex = 7;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            this.Btn_refrescar.Click += new System.EventHandler(this.Btn_refrescar_Click);
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(857, 4);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(99, 107);
            this.Btn_inicio.TabIndex = 8;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            this.Btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(964, 4);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(99, 107);
            this.Btn_anterior.TabIndex = 9;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            this.Btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(1071, 4);
            this.Btn_sig.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(99, 107);
            this.Btn_sig.TabIndex = 10;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            this.Btn_sig.Click += new System.EventHandler(this.Btn_sig_Click);
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(1177, 4);
            this.Btn_fin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(99, 107);
            this.Btn_fin.TabIndex = 11;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            this.Btn_fin.Click += new System.EventHandler(this.Btn_fin_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(1284, 4);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(99, 107);
            this.Btn_ayuda.TabIndex = 12;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(1391, 4);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(99, 107);
            this.Btn_salir.TabIndex = 13;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(16, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1517, 224);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn_salir);
            this.panel5.Controls.Add(this.Btn_ayuda);
            this.panel5.Controls.Add(this.Btn_fin);
            this.panel5.Controls.Add(this.Btn_sig);
            this.panel5.Controls.Add(this.Btn_anterior);
            this.panel5.Controls.Add(this.Btn_inicio);
            this.panel5.Controls.Add(this.Btn_refrescar);
            this.panel5.Controls.Add(this.Btn_imprimir);
            this.panel5.Controls.Add(this.Btn_consultar);
            this.panel5.Controls.Add(this.Btn_eliminar);
            this.panel5.Controls.Add(this.Btn_cancelar);
            this.panel5.Controls.Add(this.Btn_guardar);
            this.panel5.Controls.Add(this.Btn_modificar);
            this.panel5.Controls.Add(this.Btn_ingresar);
            this.panel5.Location = new System.Drawing.Point(4, 85);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1499, 126);
            this.panel5.TabIndex = 7;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_imprimir.Image")));
            this.Btn_imprimir.Location = new System.Drawing.Point(644, 4);
            this.Btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(99, 107);
            this.Btn_imprimir.TabIndex = 6;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Frm_Detalle_Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 998);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Detalle_Orden";
            this.Text = "Detalle de Orden Recibidas - 714";
            this.Load += new System.EventHandler(this.Frm_Detalle_Orden_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Materiales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dgv_Materiales;
        private System.Windows.Forms.RichTextBox Rtxt_Observaciones;
        private System.Windows.Forms.DateTimePicker Dtp_Requerida;
        private System.Windows.Forms.DateTimePicker Dtp_Recepcion;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.ComboBox Cmb_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Udm;
        private System.Windows.Forms.Label Lbl_Material;
        private System.Windows.Forms.Label Lbl_IDMaterial;
        private System.Windows.Forms.NumericUpDown Nud_Cantidad;
        private System.Windows.Forms.ComboBox Cmb_IDMat;
        private System.Windows.Forms.ComboBox Cmb_NombreMat;
        private System.Windows.Forms.Button Btn_eliminarMat;
        private System.Windows.Forms.Button Btn_agregarMat;
        private System.Windows.Forms.TextBox txt_UnidadDeMedida;
        private System.Windows.Forms.Button Btn_imprimir;
    }
}