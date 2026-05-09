namespace Capa_Vista_CXP
{
    partial class Frm_Compra_manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Compra_manual));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_compras = new System.Windows.Forms.Label();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_total_ingreso = new System.Windows.Forms.TextBox();
            this.Txt_subtotal_ingreso = new System.Windows.Forms.TextBox();
            this.Cbo_tipo_compra_ingreso = new System.Windows.Forms.ComboBox();
            this.Txt_dias_credito_ingreso = new System.Windows.Forms.TextBox();
            this.Dtp_vencimiento_ingreso = new System.Windows.Forms.DateTimePicker();
            this.Dtp_fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.Txt_numero_factura_ingreso = new System.Windows.Forms.TextBox();
            this.Txt_serie_factura_ingreso = new System.Windows.Forms.TextBox();
            this.Cbo_bodega_ingreso = new System.Windows.Forms.ComboBox();
            this.Cbo_proveedor_ingreso = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Dgv_detalle_ingreso = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Cbo_producto_detalle = new System.Windows.Forms.ComboBox();
            this.Cbo_unidad_detalle = new System.Windows.Forms.ComboBox();
            this.Txt_cantidad_detalle = new System.Windows.Forms.TextBox();
            this.Txt_precio_detalle = new System.Windows.Forms.TextBox();
            this.Txt_subtotal_detalle = new System.Windows.Forms.TextBox();
            this.Btn_agregar_detalle = new System.Windows.Forms.Button();
            this.Btn_quitar_detalle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_ingreso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Lbl_compras);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 60);
            this.panel1.TabIndex = 35;
            // 
            // Lbl_compras
            // 
            this.Lbl_compras.AutoSize = true;
            this.Lbl_compras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_compras.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_compras.Location = new System.Drawing.Point(22, 19);
            this.Lbl_compras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_compras.Name = "Lbl_compras";
            this.Lbl_compras.Size = new System.Drawing.Size(283, 27);
            this.Lbl_compras.TabIndex = 31;
            this.Lbl_compras.Text = "715 - COMPRA MANUAL";
            // 
            // Btn_fin
            // 
            this.Btn_fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_fin.Image = global::Capa_Vista_Compras.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_fin.Location = new System.Drawing.Point(1052, 76);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(74, 87);
            this.Btn_fin.TabIndex = 79;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button12.Image = global::Capa_Vista_Compras.Properties.Resources.help_question_16768;
            this.button12.Location = new System.Drawing.Point(972, 76);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 87);
            this.button12.TabIndex = 78;
            this.button12.Text = "Ayuda";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button11.Image = global::Capa_Vista_Compras.Properties.Resources.next_forward_player_multimedia_video_play_button_icon_250680__1_;
            this.button11.Location = new System.Drawing.Point(892, 76);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 87);
            this.button11.TabIndex = 77;
            this.button11.Text = "Fin";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button10.Image = global::Capa_Vista_Compras.Properties.Resources.next_right_play_arrow_arrows_fast_forward_icon_250672;
            this.button10.Location = new System.Drawing.Point(812, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 87);
            this.button10.TabIndex = 76;
            this.button10.Text = "Siguiente";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button9.Image = global::Capa_Vista_Compras.Properties.Resources.direction_play_backward_arrow_next_previous_back_icon_250674;
            this.button9.Location = new System.Drawing.Point(732, 76);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 87);
            this.button9.TabIndex = 75;
            this.button9.Text = "Anterior";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button8.Image = global::Capa_Vista_Compras.Properties.Resources.arrow_direction_left_undo_previous_backward_back_icon_250686;
            this.button8.Location = new System.Drawing.Point(652, 76);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 87);
            this.button8.TabIndex = 74;
            this.button8.Text = "Inicio";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_refrescar.Image = global::Capa_Vista_Compras.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_refrescar.Location = new System.Drawing.Point(572, 76);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(74, 87);
            this.Btn_refrescar.TabIndex = 73;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_imprimir.Image = global::Capa_Vista_Compras.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_imprimir.Location = new System.Drawing.Point(492, 76);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(74, 87);
            this.Btn_imprimir.TabIndex = 72;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.Location = new System.Drawing.Point(412, 76);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(74, 87);
            this.Btn_consultar.TabIndex = 71;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_eliminar.Image = global::Capa_Vista_Compras.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_eliminar.Location = new System.Drawing.Point(332, 76);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(74, 87);
            this.Btn_eliminar.TabIndex = 70;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_cancelar.Image = global::Capa_Vista_Compras.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_cancelar.Location = new System.Drawing.Point(252, 76);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(74, 87);
            this.Btn_cancelar.TabIndex = 69;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_guardar.Image = global::Capa_Vista_Compras.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_guardar.Location = new System.Drawing.Point(172, 76);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(74, 87);
            this.Btn_guardar.TabIndex = 68;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_modificar.Image = global::Capa_Vista_Compras.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_modificar.Location = new System.Drawing.Point(92, 76);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(74, 87);
            this.Btn_modificar.TabIndex = 67;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_ingresar.Image = global::Capa_Vista_Compras.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_ingresar.Location = new System.Drawing.Point(12, 76);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(74, 87);
            this.Btn_ingresar.TabIndex = 66;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_total_ingreso);
            this.groupBox1.Controls.Add(this.Txt_subtotal_ingreso);
            this.groupBox1.Controls.Add(this.Cbo_tipo_compra_ingreso);
            this.groupBox1.Controls.Add(this.Txt_dias_credito_ingreso);
            this.groupBox1.Controls.Add(this.Dtp_vencimiento_ingreso);
            this.groupBox1.Controls.Add(this.Dtp_fecha_ingreso);
            this.groupBox1.Controls.Add(this.Txt_numero_factura_ingreso);
            this.groupBox1.Controls.Add(this.Txt_serie_factura_ingreso);
            this.groupBox1.Controls.Add(this.Cbo_bodega_ingreso);
            this.groupBox1.Controls.Add(this.Cbo_proveedor_ingreso);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 173);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado de compra";
            // 
            // Txt_total_ingreso
            // 
            this.Txt_total_ingreso.Location = new System.Drawing.Point(913, 122);
            this.Txt_total_ingreso.Name = "Txt_total_ingreso";
            this.Txt_total_ingreso.Size = new System.Drawing.Size(121, 23);
            this.Txt_total_ingreso.TabIndex = 19;
            // 
            // Txt_subtotal_ingreso
            // 
            this.Txt_subtotal_ingreso.Location = new System.Drawing.Point(913, 79);
            this.Txt_subtotal_ingreso.Name = "Txt_subtotal_ingreso";
            this.Txt_subtotal_ingreso.Size = new System.Drawing.Size(121, 23);
            this.Txt_subtotal_ingreso.TabIndex = 18;
            // 
            // Cbo_tipo_compra_ingreso
            // 
            this.Cbo_tipo_compra_ingreso.FormattingEnabled = true;
            this.Cbo_tipo_compra_ingreso.Location = new System.Drawing.Point(913, 36);
            this.Cbo_tipo_compra_ingreso.Name = "Cbo_tipo_compra_ingreso";
            this.Cbo_tipo_compra_ingreso.Size = new System.Drawing.Size(121, 25);
            this.Cbo_tipo_compra_ingreso.TabIndex = 17;
            // 
            // Txt_dias_credito_ingreso
            // 
            this.Txt_dias_credito_ingreso.Location = new System.Drawing.Point(469, 122);
            this.Txt_dias_credito_ingreso.Name = "Txt_dias_credito_ingreso";
            this.Txt_dias_credito_ingreso.Size = new System.Drawing.Size(121, 23);
            this.Txt_dias_credito_ingreso.TabIndex = 16;
            // 
            // Dtp_vencimiento_ingreso
            // 
            this.Dtp_vencimiento_ingreso.Location = new System.Drawing.Point(469, 77);
            this.Dtp_vencimiento_ingreso.Name = "Dtp_vencimiento_ingreso";
            this.Dtp_vencimiento_ingreso.Size = new System.Drawing.Size(272, 23);
            this.Dtp_vencimiento_ingreso.TabIndex = 15;
            // 
            // Dtp_fecha_ingreso
            // 
            this.Dtp_fecha_ingreso.Location = new System.Drawing.Point(469, 34);
            this.Dtp_fecha_ingreso.Name = "Dtp_fecha_ingreso";
            this.Dtp_fecha_ingreso.Size = new System.Drawing.Size(272, 23);
            this.Dtp_fecha_ingreso.TabIndex = 14;
            // 
            // Txt_numero_factura_ingreso
            // 
            this.Txt_numero_factura_ingreso.Location = new System.Drawing.Point(160, 135);
            this.Txt_numero_factura_ingreso.Name = "Txt_numero_factura_ingreso";
            this.Txt_numero_factura_ingreso.Size = new System.Drawing.Size(121, 23);
            this.Txt_numero_factura_ingreso.TabIndex = 13;
            // 
            // Txt_serie_factura_ingreso
            // 
            this.Txt_serie_factura_ingreso.Location = new System.Drawing.Point(160, 105);
            this.Txt_serie_factura_ingreso.Name = "Txt_serie_factura_ingreso";
            this.Txt_serie_factura_ingreso.Size = new System.Drawing.Size(121, 23);
            this.Txt_serie_factura_ingreso.TabIndex = 12;
            // 
            // Cbo_bodega_ingreso
            // 
            this.Cbo_bodega_ingreso.FormattingEnabled = true;
            this.Cbo_bodega_ingreso.Location = new System.Drawing.Point(160, 71);
            this.Cbo_bodega_ingreso.Name = "Cbo_bodega_ingreso";
            this.Cbo_bodega_ingreso.Size = new System.Drawing.Size(121, 25);
            this.Cbo_bodega_ingreso.TabIndex = 11;
            // 
            // Cbo_proveedor_ingreso
            // 
            this.Cbo_proveedor_ingreso.FormattingEnabled = true;
            this.Cbo_proveedor_ingreso.Location = new System.Drawing.Point(160, 34);
            this.Cbo_proveedor_ingreso.Name = "Cbo_proveedor_ingreso";
            this.Cbo_proveedor_ingreso.Size = new System.Drawing.Size(121, 25);
            this.Cbo_proveedor_ingreso.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(845, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sub total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(869, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha de vencimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dias de credito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(797, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha del pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. facrura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. serie de factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id bodega:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id proveedor:";
            // 
            // Dgv_detalle_ingreso
            // 
            this.Dgv_detalle_ingreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalle_ingreso.Location = new System.Drawing.Point(12, 571);
            this.Dgv_detalle_ingreso.Name = "Dgv_detalle_ingreso";
            this.Dgv_detalle_ingreso.Size = new System.Drawing.Size(1114, 174);
            this.Dgv_detalle_ingreso.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Detalle del producto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Precio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Sub total: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Unidad:";
            // 
            // Cbo_producto_detalle
            // 
            this.Cbo_producto_detalle.FormattingEnabled = true;
            this.Cbo_producto_detalle.Location = new System.Drawing.Point(160, 51);
            this.Cbo_producto_detalle.Name = "Cbo_producto_detalle";
            this.Cbo_producto_detalle.Size = new System.Drawing.Size(121, 25);
            this.Cbo_producto_detalle.TabIndex = 5;
            // 
            // Cbo_unidad_detalle
            // 
            this.Cbo_unidad_detalle.FormattingEnabled = true;
            this.Cbo_unidad_detalle.Location = new System.Drawing.Point(160, 93);
            this.Cbo_unidad_detalle.Name = "Cbo_unidad_detalle";
            this.Cbo_unidad_detalle.Size = new System.Drawing.Size(121, 25);
            this.Cbo_unidad_detalle.TabIndex = 6;
            // 
            // Txt_cantidad_detalle
            // 
            this.Txt_cantidad_detalle.Location = new System.Drawing.Point(160, 133);
            this.Txt_cantidad_detalle.Name = "Txt_cantidad_detalle";
            this.Txt_cantidad_detalle.Size = new System.Drawing.Size(121, 23);
            this.Txt_cantidad_detalle.TabIndex = 7;
            // 
            // Txt_precio_detalle
            // 
            this.Txt_precio_detalle.Location = new System.Drawing.Point(438, 70);
            this.Txt_precio_detalle.Name = "Txt_precio_detalle";
            this.Txt_precio_detalle.Size = new System.Drawing.Size(152, 23);
            this.Txt_precio_detalle.TabIndex = 8;
            // 
            // Txt_subtotal_detalle
            // 
            this.Txt_subtotal_detalle.Location = new System.Drawing.Point(438, 111);
            this.Txt_subtotal_detalle.Name = "Txt_subtotal_detalle";
            this.Txt_subtotal_detalle.Size = new System.Drawing.Size(152, 23);
            this.Txt_subtotal_detalle.TabIndex = 9;
            // 
            // Btn_agregar_detalle
            // 
            this.Btn_agregar_detalle.Location = new System.Drawing.Point(720, 38);
            this.Btn_agregar_detalle.Name = "Btn_agregar_detalle";
            this.Btn_agregar_detalle.Size = new System.Drawing.Size(87, 49);
            this.Btn_agregar_detalle.TabIndex = 10;
            this.Btn_agregar_detalle.Text = "Agregar";
            this.Btn_agregar_detalle.UseVisualStyleBackColor = true;
            // 
            // Btn_quitar_detalle
            // 
            this.Btn_quitar_detalle.Location = new System.Drawing.Point(720, 107);
            this.Btn_quitar_detalle.Name = "Btn_quitar_detalle";
            this.Btn_quitar_detalle.Size = new System.Drawing.Size(87, 49);
            this.Btn_quitar_detalle.TabIndex = 11;
            this.Btn_quitar_detalle.Text = "Quitar";
            this.Btn_quitar_detalle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_quitar_detalle);
            this.groupBox2.Controls.Add(this.Btn_agregar_detalle);
            this.groupBox2.Controls.Add(this.Txt_subtotal_detalle);
            this.groupBox2.Controls.Add(this.Txt_precio_detalle);
            this.groupBox2.Controls.Add(this.Txt_cantidad_detalle);
            this.groupBox2.Controls.Add(this.Cbo_unidad_detalle);
            this.groupBox2.Controls.Add(this.Cbo_producto_detalle);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1114, 178);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de compras";
            // 
            // Frm_Compra_manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 749);
            this.Controls.Add(this.Dgv_detalle_ingreso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_fin);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Btn_refrescar);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Compra_manual";
            this.Text = "Compra manual";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_ingreso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_compras;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_numero_factura_ingreso;
        private System.Windows.Forms.TextBox Txt_serie_factura_ingreso;
        private System.Windows.Forms.ComboBox Cbo_bodega_ingreso;
        private System.Windows.Forms.ComboBox Cbo_proveedor_ingreso;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_ingreso;
        private System.Windows.Forms.DateTimePicker Dtp_vencimiento_ingreso;
        private System.Windows.Forms.TextBox Txt_total_ingreso;
        private System.Windows.Forms.TextBox Txt_subtotal_ingreso;
        private System.Windows.Forms.ComboBox Cbo_tipo_compra_ingreso;
        private System.Windows.Forms.TextBox Txt_dias_credito_ingreso;
        private System.Windows.Forms.DataGridView Dgv_detalle_ingreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Cbo_producto_detalle;
        private System.Windows.Forms.ComboBox Cbo_unidad_detalle;
        private System.Windows.Forms.TextBox Txt_cantidad_detalle;
        private System.Windows.Forms.TextBox Txt_precio_detalle;
        private System.Windows.Forms.TextBox Txt_subtotal_detalle;
        private System.Windows.Forms.Button Btn_agregar_detalle;
        private System.Windows.Forms.Button Btn_quitar_detalle;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}