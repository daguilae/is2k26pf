namespace Capa_Vista_CXP
{
    partial class Frm_Compras_CXP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbo_id_compra = new System.Windows.Forms.ComboBox();
            this.Cbo_numero_factura = new System.Windows.Forms.ComboBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.No = new System.Windows.Forms.Label();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.Txt_adelanto = new System.Windows.Forms.TextBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Txt_orden = new System.Windows.Forms.TextBox();
            this.Dgv_compras = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_compras = new System.Windows.Forms.Label();
            this.Btn_grabar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_compras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de facturacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id orden de compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total de la compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adelanto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Saldo Pendiente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_id_compra);
            this.groupBox1.Controls.Add(this.Cbo_numero_factura);
            this.groupBox1.Controls.Add(this.Btn_limpiar);
            this.groupBox1.Controls.Add(this.Dtp_fecha);
            this.groupBox1.Controls.Add(this.Cbo_proveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 120);
            this.groupBox1.TabIndex = 9;
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
            this.Btn_limpiar.Location = new System.Drawing.Point(654, 41);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 50);
            this.Btn_limpiar.TabIndex = 33;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Location = new System.Drawing.Point(402, 29);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 23);
            this.Dtp_fecha.TabIndex = 13;
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.FormattingEnabled = true;
            this.Cbo_proveedor.Location = new System.Drawing.Point(404, 71);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(198, 25);
            this.Cbo_proveedor.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_documento);
            this.groupBox2.Controls.Add(this.No);
            this.groupBox2.Controls.Add(this.Btn_aceptar);
            this.groupBox2.Controls.Add(this.Txt_estado);
            this.groupBox2.Controls.Add(this.Txt_saldo);
            this.groupBox2.Controls.Add(this.Txt_adelanto);
            this.groupBox2.Controls.Add(this.Txt_total);
            this.groupBox2.Controls.Add(this.Txt_orden);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de pago";
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(148, 55);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(100, 23);
            this.Txt_documento.TabIndex = 44;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(66, 58);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(85, 17);
            this.No.TabIndex = 44;
            this.No.Text = "No. Factura:";
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_aceptar.Location = new System.Drawing.Point(654, 48);
            this.Btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(75, 50);
            this.Btn_aceptar.TabIndex = 33;
            this.Btn_aceptar.Text = "Pagar";
            this.Btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // Txt_estado
            // 
            this.Txt_estado.Location = new System.Drawing.Point(450, 81);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(100, 23);
            this.Txt_estado.TabIndex = 12;
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Location = new System.Drawing.Point(450, 48);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(100, 23);
            this.Txt_saldo.TabIndex = 12;
            // 
            // Txt_adelanto
            // 
            this.Txt_adelanto.Location = new System.Drawing.Point(450, 19);
            this.Txt_adelanto.Name = "Txt_adelanto";
            this.Txt_adelanto.Size = new System.Drawing.Size(100, 23);
            this.Txt_adelanto.TabIndex = 12;
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(148, 84);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(100, 23);
            this.Txt_total.TabIndex = 12;
            // 
            // Txt_orden
            // 
            this.Txt_orden.Location = new System.Drawing.Point(148, 26);
            this.Txt_orden.Name = "Txt_orden";
            this.Txt_orden.Size = new System.Drawing.Size(100, 23);
            this.Txt_orden.TabIndex = 12;
            // 
            // Dgv_compras
            // 
            this.Dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_compras.Location = new System.Drawing.Point(12, 468);
            this.Dgv_compras.Name = "Dgv_compras";
            this.Dgv_compras.Size = new System.Drawing.Size(754, 167);
            this.Dgv_compras.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Lbl_compras);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 60);
            this.panel1.TabIndex = 34;
            // 
            // Lbl_compras
            // 
            this.Lbl_compras.AutoSize = true;
            this.Lbl_compras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_compras.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_compras.Location = new System.Drawing.Point(22, 19);
            this.Lbl_compras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_compras.Name = "Lbl_compras";
            this.Lbl_compras.Size = new System.Drawing.Size(324, 27);
            this.Lbl_compras.TabIndex = 31;
            this.Lbl_compras.Text = "715 - CUENTAS POR PAGAR";
            // 
            // Btn_grabar
            // 
            this.Btn_grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_grabar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_grabar.Image = global::Capa_Vista_Compras.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_grabar.Location = new System.Drawing.Point(169, 65);
            this.Btn_grabar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_grabar.Name = "Btn_grabar";
            this.Btn_grabar.Size = new System.Drawing.Size(74, 87);
            this.Btn_grabar.TabIndex = 35;
            this.Btn_grabar.Text = "Guardar";
            this.Btn_grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_grabar.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_buscar.Image = global::Capa_Vista_Compras.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_buscar.Location = new System.Drawing.Point(408, 66);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(74, 87);
            this.Btn_buscar.TabIndex = 36;
            this.Btn_buscar.Text = "Consultar";
            this.Btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_salir.Image = global::Capa_Vista_Compras.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_salir.Location = new System.Drawing.Point(1043, 66);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(74, 87);
            this.Btn_salir.TabIndex = 37;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_imprimir.Image = global::Capa_Vista_Compras.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_imprimir.Location = new System.Drawing.Point(487, 66);
            this.Btn_imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(74, 87);
            this.Btn_imprimir.TabIndex = 38;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_editar.Image = global::Capa_Vista_Compras.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_editar.Location = new System.Drawing.Point(91, 66);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(74, 87);
            this.Btn_editar.TabIndex = 41;
            this.Btn_editar.Text = "Modificar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_refrescar.Image = global::Capa_Vista_Compras.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_refrescar.Location = new System.Drawing.Point(565, 66);
            this.Btn_refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(74, 87);
            this.Btn_refrescar.TabIndex = 43;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
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
            this.Btn_ingresar.TabIndex = 44;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button4.Image = global::Capa_Vista_Compras.Properties.Resources.delete_remove_trash_icon_177304;
            this.button4.Location = new System.Drawing.Point(328, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 87);
            this.button4.TabIndex = 46;
            this.button4.Text = "Eliminar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button3.Image = global::Capa_Vista_Compras.Properties.Resources.Cancel_icon_icons_com_73703;
            this.button3.Location = new System.Drawing.Point(248, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 87);
            this.button3.TabIndex = 45;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button12.Image = global::Capa_Vista_Compras.Properties.Resources.help_question_16768;
            this.button12.Location = new System.Drawing.Point(964, 66);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 87);
            this.button12.TabIndex = 54;
            this.button12.Text = "Ayuda";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button11.Image = global::Capa_Vista_Compras.Properties.Resources.next_forward_player_multimedia_video_play_button_icon_250680__1_;
            this.button11.Location = new System.Drawing.Point(884, 66);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 87);
            this.button11.TabIndex = 53;
            this.button11.Text = "Fin";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button10.Image = global::Capa_Vista_Compras.Properties.Resources.next_right_play_arrow_arrows_fast_forward_icon_250672;
            this.button10.Location = new System.Drawing.Point(804, 66);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 87);
            this.button10.TabIndex = 52;
            this.button10.Text = "Siguiente";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button9.Image = global::Capa_Vista_Compras.Properties.Resources.direction_play_backward_arrow_next_previous_back_icon_250674;
            this.button9.Location = new System.Drawing.Point(724, 66);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 87);
            this.button9.TabIndex = 51;
            this.button9.Text = "Anterior";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button8.Image = global::Capa_Vista_Compras.Properties.Resources.arrow_direction_left_undo_previous_backward_back_icon_250686;
            this.button8.Location = new System.Drawing.Point(644, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 87);
            this.button8.TabIndex = 50;
            this.button8.Text = "Inicio";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Frm_Compras_CXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 647);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Btn_refrescar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_grabar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_compras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Compras_CXP";
            this.Text = "715 - CUENTAS POR PAGAR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_compras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_proveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.TextBox Txt_adelanto;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.TextBox Txt_orden;
        private System.Windows.Forms.DataGridView Dgv_compras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_compras;
        private System.Windows.Forms.Button Btn_grabar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.Label No;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.ComboBox Cbo_id_compra;
        private System.Windows.Forms.ComboBox Cbo_numero_factura;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}