
namespace Capa_vista_Factura
{
    partial class Frm_factura
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
            this.Lbl_factura = new System.Windows.Forms.Label();
            this.Lbl_serie = new System.Windows.Forms.Label();
            this.Lbl_numero = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_orden = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_subtotal = new System.Windows.Forms.Label();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_bucar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_factura
            // 
            this.Lbl_factura.AutoSize = true;
            this.Lbl_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_factura.Location = new System.Drawing.Point(428, 31);
            this.Lbl_factura.Name = "Lbl_factura";
            this.Lbl_factura.Size = new System.Drawing.Size(130, 36);
            this.Lbl_factura.TabIndex = 0;
            this.Lbl_factura.Text = "Facturas";
            // 
            // Lbl_serie
            // 
            this.Lbl_serie.AutoSize = true;
            this.Lbl_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_serie.Location = new System.Drawing.Point(38, 106);
            this.Lbl_serie.Name = "Lbl_serie";
            this.Lbl_serie.Size = new System.Drawing.Size(77, 29);
            this.Lbl_serie.TabIndex = 1;
            this.Lbl_serie.Text = "Serie:";
            // 
            // Lbl_numero
            // 
            this.Lbl_numero.AutoSize = true;
            this.Lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numero.Location = new System.Drawing.Point(381, 113);
            this.Lbl_numero.Name = "Lbl_numero";
            this.Lbl_numero.Size = new System.Drawing.Size(106, 29);
            this.Lbl_numero.TabIndex = 2;
            this.Lbl_numero.Text = "Numero:";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lbl_fecha.Location = new System.Drawing.Point(818, 120);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(86, 29);
            this.Lbl_fecha.TabIndex = 3;
            this.Lbl_fecha.Text = "Fecha:";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proveedor.Location = new System.Drawing.Point(38, 177);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(132, 29);
            this.Lbl_proveedor.TabIndex = 5;
            this.Lbl_proveedor.Text = "Proveedor:";
            // 
            // Lbl_orden
            // 
            this.Lbl_orden.AutoSize = true;
            this.Lbl_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_orden.Location = new System.Drawing.Point(372, 184);
            this.Lbl_orden.Name = "Lbl_orden";
            this.Lbl_orden.Size = new System.Drawing.Size(213, 29);
            this.Lbl_orden.TabIndex = 6;
            this.Lbl_orden.Text = "Orden de Compra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 184);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(609, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(170, 22);
            this.textBox5.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Productos ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(960, 52);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(170, 22);
            this.textBox7.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(574, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio Unitarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(150, 52);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(170, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Producto:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(917, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducto,
            this.ColumnCantidad,
            this.ColumnPrecioUnitario,
            this.ColumnTotal});
            this.dataGridView1.Location = new System.Drawing.Point(35, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 197);
            this.dataGridView1.TabIndex = 14;
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.MinimumWidth = 6;
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.Width = 125;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MinimumWidth = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Width = 125;
            // 
            // ColumnPrecioUnitario
            // 
            this.ColumnPrecioUnitario.HeaderText = "Precio Unitario";
            this.ColumnPrecioUnitario.MinimumWidth = 6;
            this.ColumnPrecioUnitario.Name = "ColumnPrecioUnitario";
            this.ColumnPrecioUnitario.Width = 125;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.MinimumWidth = 6;
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.Width = 125;
            // 
            // Lbl_subtotal
            // 
            this.Lbl_subtotal.AutoSize = true;
            this.Lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subtotal.Location = new System.Drawing.Point(54, 599);
            this.Lbl_subtotal.Name = "Lbl_subtotal";
            this.Lbl_subtotal.Size = new System.Drawing.Size(107, 29);
            this.Lbl_subtotal.TabIndex = 18;
            this.Lbl_subtotal.Text = "Subtotal:";
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.Location = new System.Drawing.Point(413, 599);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(74, 29);
            this.Lbl_total.TabIndex = 19;
            this.Lbl_total.Text = "Total:";
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Location = new System.Drawing.Point(185, 599);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(170, 22);
            this.Txt_subtotal.TabIndex = 18;
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(526, 606);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(170, 22);
            this.Txt_total.TabIndex = 20;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_vista_Factura.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_salir.Location = new System.Drawing.Point(1106, 617);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(59, 48);
            this.Btn_salir.TabIndex = 24;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Image = global::Capa_vista_Factura.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_imprimir.Location = new System.Drawing.Point(1008, 617);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(72, 46);
            this.Btn_imprimir.TabIndex = 23;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Image = global::Capa_vista_Factura.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_guardar.Location = new System.Drawing.Point(804, 617);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(74, 42);
            this.Btn_guardar.TabIndex = 22;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_bucar
            // 
            this.Btn_bucar.Image = global::Capa_vista_Factura.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_bucar.Location = new System.Drawing.Point(908, 617);
            this.Btn_bucar.Name = "Btn_bucar";
            this.Btn_bucar.Size = new System.Drawing.Size(72, 44);
            this.Btn_bucar.TabIndex = 21;
            this.Btn_bucar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Image = global::Capa_vista_Factura.Properties.Resources.clear_all_icon_180807;
            this.Btn_eliminar.Location = new System.Drawing.Point(1035, 466);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(82, 50);
            this.Btn_eliminar.TabIndex = 16;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Image = global::Capa_vista_Factura.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_agregar.Location = new System.Drawing.Point(1035, 368);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(82, 47);
            this.Btn_agregar.TabIndex = 15;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_vista_Factura.Properties.Resources.help_question_16768;
            this.Btn_ayuda.Location = new System.Drawing.Point(930, 28);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(65, 54);
            this.Btn_ayuda.TabIndex = 4;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Frm_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 680);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_bucar);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.Txt_subtotal);
            this.Controls.Add(this.Lbl_total);
            this.Controls.Add(this.Lbl_subtotal);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_orden);
            this.Controls.Add(this.Lbl_proveedor);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_numero);
            this.Controls.Add(this.Lbl_serie);
            this.Controls.Add(this.Lbl_factura);
            this.Name = "Frm_factura";
            this.Text = "Facturas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_factura;
        private System.Windows.Forms.Label Lbl_serie;
        private System.Windows.Forms.Label Lbl_numero;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_orden;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Label Lbl_subtotal;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Button Btn_bucar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_salir;
    }
}