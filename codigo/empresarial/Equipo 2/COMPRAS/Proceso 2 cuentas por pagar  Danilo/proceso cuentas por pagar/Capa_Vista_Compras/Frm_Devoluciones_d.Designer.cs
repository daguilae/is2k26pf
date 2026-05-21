namespace Capa_Vista_Compras
{
    partial class Frm_Devoluciones_d
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Devoluciones_d));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_compras = new System.Windows.Forms.Label();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbo_id_compra = new System.Windows.Forms.ComboBox();
            this.Cbo_numero_factura = new System.Windows.Forms.ComboBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Dtp_fecha_facturacion = new System.Windows.Forms.DateTimePicker();
            this.Cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_confirmar = new System.Windows.Forms.Button();
            this.Txt_valor_monetario = new System.Windows.Forms.TextBox();
            this.Cbo_tipo_devolucion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Txt_id_devolucion = new System.Windows.Forms.TextBox();
            this.Cbo_motivo = new System.Windows.Forms.ComboBox();
            this.Dtp_fecha_devolucion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_detalle_devolucion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_devolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Lbl_compras);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 60);
            this.panel1.TabIndex = 36;
            // 
            // Lbl_compras
            // 
            this.Lbl_compras.AutoSize = true;
            this.Lbl_compras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_compras.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_compras.Location = new System.Drawing.Point(22, 19);
            this.Lbl_compras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_compras.Name = "Lbl_compras";
            this.Lbl_compras.Size = new System.Drawing.Size(199, 27);
            this.Lbl_compras.TabIndex = 31;
            this.Lbl_compras.Text = "DEVOLUCIONES";
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_ingresar.Image = global::Capa_Vista_Compras.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_ingresar.Location = new System.Drawing.Point(12, 66);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(74, 87);
            this.Btn_ingresar.TabIndex = 37;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.Image = global::Capa_Vista_Compras.Properties.Resources.compose_edit_modify_icon_177770;
            this.button1.Location = new System.Drawing.Point(92, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 87);
            this.button1.TabIndex = 38;
            this.button1.Text = "Modificar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button2.Image = global::Capa_Vista_Compras.Properties.Resources.savetheapplication_guardar_2958;
            this.button2.Location = new System.Drawing.Point(172, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 87);
            this.button2.TabIndex = 39;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button3.Image = global::Capa_Vista_Compras.Properties.Resources.Cancel_icon_icons_com_73703;
            this.button3.Location = new System.Drawing.Point(252, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 87);
            this.button3.TabIndex = 40;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button4.Image = global::Capa_Vista_Compras.Properties.Resources.delete_remove_trash_icon_177304;
            this.button4.Location = new System.Drawing.Point(332, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 87);
            this.button4.TabIndex = 41;
            this.button4.Text = "Eliminar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(412, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 87);
            this.button5.TabIndex = 42;
            this.button5.Text = "Consultar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_imprimir.Image = global::Capa_Vista_Compras.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_imprimir.Location = new System.Drawing.Point(492, 66);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(74, 87);
            this.Btn_imprimir.TabIndex = 43;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_refrescar.Image = global::Capa_Vista_Compras.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_refrescar.Location = new System.Drawing.Point(572, 66);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(74, 87);
            this.Btn_refrescar.TabIndex = 44;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button8.Image = global::Capa_Vista_Compras.Properties.Resources.arrow_direction_left_undo_previous_backward_back_icon_250686;
            this.button8.Location = new System.Drawing.Point(652, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 87);
            this.button8.TabIndex = 45;
            this.button8.Text = "Inicio";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button9.Image = global::Capa_Vista_Compras.Properties.Resources.direction_play_backward_arrow_next_previous_back_icon_250674;
            this.button9.Location = new System.Drawing.Point(732, 66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 87);
            this.button9.TabIndex = 46;
            this.button9.Text = "Anterior";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button10.Image = global::Capa_Vista_Compras.Properties.Resources.next_right_play_arrow_arrows_fast_forward_icon_250672;
            this.button10.Location = new System.Drawing.Point(812, 66);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 87);
            this.button10.TabIndex = 47;
            this.button10.Text = "Siguiente";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button11.Image = global::Capa_Vista_Compras.Properties.Resources.next_forward_player_multimedia_video_play_button_icon_250680__1_;
            this.button11.Location = new System.Drawing.Point(892, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 87);
            this.button11.TabIndex = 48;
            this.button11.Text = "Fin";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button12.Image = global::Capa_Vista_Compras.Properties.Resources.help_question_16768;
            this.button12.Location = new System.Drawing.Point(972, 66);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 87);
            this.button12.TabIndex = 49;
            this.button12.Text = "Ayuda";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_salir.Image = global::Capa_Vista_Compras.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_salir.Location = new System.Drawing.Point(1052, 66);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(74, 87);
            this.Btn_salir.TabIndex = 50;
            this.Btn_salir.Text = "Fin";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_id_compra);
            this.groupBox1.Controls.Add(this.Cbo_numero_factura);
            this.groupBox1.Controls.Add(this.Btn_limpiar);
            this.groupBox1.Controls.Add(this.Dtp_fecha_facturacion);
            this.groupBox1.Controls.Add(this.Cbo_proveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1154, 120);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la compra";
            // 
            // Cbo_id_compra
            // 
            this.Cbo_id_compra.FormattingEnabled = true;
            this.Cbo_id_compra.Location = new System.Drawing.Point(93, 28);
            this.Cbo_id_compra.Name = "Cbo_id_compra";
            this.Cbo_id_compra.Size = new System.Drawing.Size(145, 25);
            this.Cbo_id_compra.TabIndex = 44;
            // 
            // Cbo_numero_factura
            // 
            this.Cbo_numero_factura.FormattingEnabled = true;
            this.Cbo_numero_factura.Location = new System.Drawing.Point(93, 71);
            this.Cbo_numero_factura.Name = "Cbo_numero_factura";
            this.Cbo_numero_factura.Size = new System.Drawing.Size(145, 25);
            this.Cbo_numero_factura.TabIndex = 45;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(769, 40);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 50);
            this.Btn_limpiar.TabIndex = 33;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha_facturacion
            // 
            this.Dtp_fecha_facturacion.Location = new System.Drawing.Point(433, 28);
            this.Dtp_fecha_facturacion.Name = "Dtp_fecha_facturacion";
            this.Dtp_fecha_facturacion.Size = new System.Drawing.Size(281, 23);
            this.Dtp_fecha_facturacion.TabIndex = 13;
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.FormattingEnabled = true;
            this.Cbo_proveedor.Location = new System.Drawing.Point(435, 70);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(194, 25);
            this.Cbo_proveedor.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de facturacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_confirmar);
            this.groupBox2.Controls.Add(this.Txt_valor_monetario);
            this.groupBox2.Controls.Add(this.Cbo_tipo_devolucion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_estado);
            this.groupBox2.Controls.Add(this.Txt_id_devolucion);
            this.groupBox2.Controls.Add(this.Cbo_motivo);
            this.groupBox2.Controls.Add(this.Dtp_fecha_devolucion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 128);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motivo de devolucion";
            // 
            // Btn_confirmar
            // 
            this.Btn_confirmar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_confirmar.Location = new System.Drawing.Point(1040, 55);
            this.Btn_confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_confirmar.Name = "Btn_confirmar";
            this.Btn_confirmar.Size = new System.Drawing.Size(87, 50);
            this.Btn_confirmar.TabIndex = 53;
            this.Btn_confirmar.Text = "Confirmar";
            this.Btn_confirmar.UseVisualStyleBackColor = true;
            this.Btn_confirmar.Click += new System.EventHandler(this.button14_Click);
            // 
            // Txt_valor_monetario
            // 
            this.Txt_valor_monetario.Location = new System.Drawing.Point(844, 85);
            this.Txt_valor_monetario.Name = "Txt_valor_monetario";
            this.Txt_valor_monetario.Size = new System.Drawing.Size(100, 23);
            this.Txt_valor_monetario.TabIndex = 52;
            // 
            // Cbo_tipo_devolucion
            // 
            this.Cbo_tipo_devolucion.FormattingEnabled = true;
            this.Cbo_tipo_devolucion.Location = new System.Drawing.Point(844, 40);
            this.Cbo_tipo_devolucion.Name = "Cbo_tipo_devolucion";
            this.Cbo_tipo_devolucion.Size = new System.Drawing.Size(145, 25);
            this.Cbo_tipo_devolucion.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Valor monetario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tipo de devolucion:";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Location = new System.Drawing.Point(529, 88);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(100, 23);
            this.Txt_estado.TabIndex = 48;
            // 
            // Txt_id_devolucion
            // 
            this.Txt_id_devolucion.Location = new System.Drawing.Point(160, 37);
            this.Txt_id_devolucion.Name = "Txt_id_devolucion";
            this.Txt_id_devolucion.Size = new System.Drawing.Size(100, 23);
            this.Txt_id_devolucion.TabIndex = 47;
            // 
            // Cbo_motivo
            // 
            this.Cbo_motivo.FormattingEnabled = true;
            this.Cbo_motivo.Location = new System.Drawing.Point(530, 40);
            this.Cbo_motivo.Name = "Cbo_motivo";
            this.Cbo_motivo.Size = new System.Drawing.Size(145, 25);
            this.Cbo_motivo.TabIndex = 46;
            // 
            // Dtp_fecha_devolucion
            // 
            this.Dtp_fecha_devolucion.Location = new System.Drawing.Point(160, 88);
            this.Dtp_fecha_devolucion.Name = "Dtp_fecha_devolucion";
            this.Dtp_fecha_devolucion.Size = new System.Drawing.Size(281, 23);
            this.Dtp_fecha_devolucion.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Motivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de devolucion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id devolucion: ";
            // 
            // Dgv_detalle_devolucion
            // 
            this.Dgv_detalle_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalle_devolucion.Location = new System.Drawing.Point(12, 456);
            this.Dgv_detalle_devolucion.Name = "Dgv_detalle_devolucion";
            this.Dgv_detalle_devolucion.Size = new System.Drawing.Size(1114, 270);
            this.Dgv_detalle_devolucion.TabIndex = 53;
            // 
            // Frm_Devoluciones_d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 701);
            this.Controls.Add(this.Dgv_detalle_devolucion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Btn_refrescar);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Devoluciones_d";
            this.Text = "DEVOLUCIONES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_devolucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_compras;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cbo_id_compra;
        private System.Windows.Forms.ComboBox Cbo_numero_factura;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_facturacion;
        private System.Windows.Forms.ComboBox Cbo_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbo_motivo;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_devolucion;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox Txt_id_devolucion;
        private System.Windows.Forms.DataGridView Dgv_detalle_devolucion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_confirmar;
        private System.Windows.Forms.TextBox Txt_valor_monetario;
        private System.Windows.Forms.ComboBox Cbo_tipo_devolucion;
    }
}