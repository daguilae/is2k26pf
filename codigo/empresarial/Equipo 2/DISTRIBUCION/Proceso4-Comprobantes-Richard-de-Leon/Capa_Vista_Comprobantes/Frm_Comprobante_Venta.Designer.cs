
namespace Capa_Vista_Comprobantes
{
    partial class Frm_Comprobante_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Comprobante_Venta));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GB_Ventas = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Venta = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Venta = new System.Windows.Forms.ComboBox();
            this.Cbo_Id_Cliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_LIMPIAR_COMPROBANTE = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Agregar_Movimiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GB_Ventas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 109);
            this.dataGridView1.TabIndex = 71;
            // 
            // GB_Ventas
            // 
            this.GB_Ventas.Controls.Add(this.textBox2);
            this.GB_Ventas.Controls.Add(this.textBox1);
            this.GB_Ventas.Controls.Add(this.comboBox2);
            this.GB_Ventas.Controls.Add(this.Dtp_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.comboBox1);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Venta);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.label3);
            this.GB_Ventas.Controls.Add(this.label8);
            this.GB_Ventas.Controls.Add(this.label2);
            this.GB_Ventas.Controls.Add(this.label7);
            this.GB_Ventas.Controls.Add(this.label4);
            this.GB_Ventas.Controls.Add(this.label6);
            this.GB_Ventas.Controls.Add(this.label5);
            this.GB_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Ventas.Location = new System.Drawing.Point(30, 177);
            this.GB_Ventas.Name = "GB_Ventas";
            this.GB_Ventas.Size = new System.Drawing.Size(868, 183);
            this.GB_Ventas.TabIndex = 70;
            this.GB_Ventas.TabStop = false;
            this.GB_Ventas.Text = "Comprobante Venta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(675, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 26);
            this.textBox2.TabIndex = 54;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 53;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(420, 122);
            this.comboBox2.MaxLength = 13;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 27);
            this.comboBox2.TabIndex = 52;
            // 
            // Dtp_Fecha_Venta
            // 
            this.Dtp_Fecha_Venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Venta.Location = new System.Drawing.Point(488, 73);
            this.Dtp_Fecha_Venta.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.Name = "Dtp_Fecha_Venta";
            this.Dtp_Fecha_Venta.Size = new System.Drawing.Size(128, 26);
            this.Dtp_Fecha_Venta.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 27);
            this.comboBox1.TabIndex = 50;
            // 
            // Cbo_Id_Venta
            // 
            this.Cbo_Id_Venta.FormattingEnabled = true;
            this.Cbo_Id_Venta.Location = new System.Drawing.Point(126, 26);
            this.Cbo_Id_Venta.Name = "Cbo_Id_Venta";
            this.Cbo_Id_Venta.Size = new System.Drawing.Size(122, 27);
            this.Cbo_Id_Venta.TabIndex = 49;
            // 
            // Cbo_Id_Cliente
            // 
            this.Cbo_Id_Cliente.FormattingEnabled = true;
            this.Cbo_Id_Cliente.Location = new System.Drawing.Point(141, 72);
            this.Cbo_Id_Cliente.MaxLength = 13;
            this.Cbo_Id_Cliente.Name = "Cbo_Id_Cliente";
            this.Cbo_Id_Cliente.Size = new System.Drawing.Size(176, 27);
            this.Cbo_Id_Cliente.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Id Entrega Venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(720, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "Observaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Id Comprobante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombre Receptor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "Fecha Hora Entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 44;
            this.label5.Text = "Id Cliente:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(400, 91);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(86, 80);
            this.btn_buscar.TabIndex = 69;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 80);
            this.panel1.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comprobante de Venta";
            // 
            // BTN_LIMPIAR_COMPROBANTE
            // 
            this.BTN_LIMPIAR_COMPROBANTE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_COMPROBANTE.Image")));
            this.BTN_LIMPIAR_COMPROBANTE.Location = new System.Drawing.Point(492, 91);
            this.BTN_LIMPIAR_COMPROBANTE.Name = "BTN_LIMPIAR_COMPROBANTE";
            this.BTN_LIMPIAR_COMPROBANTE.Size = new System.Drawing.Size(86, 80);
            this.BTN_LIMPIAR_COMPROBANTE.TabIndex = 67;
            this.BTN_LIMPIAR_COMPROBANTE.Text = "LIMPIAR COMPROBANTE";
            this.BTN_LIMPIAR_COMPROBANTE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_COMPROBANTE.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(765, 91);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 80);
            this.Btn_Salir.TabIndex = 66;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(308, 91);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Modificar.TabIndex = 65;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(581, 91);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(86, 80);
            this.Btn_Reporte.TabIndex = 64;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(673, 91);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(86, 80);
            this.Btn_Ayuda.TabIndex = 63;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(216, 91);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Cancelar.TabIndex = 62;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Movimiento
            // 
            this.Btn_Agregar_Movimiento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Movimiento.Image")));
            this.Btn_Agregar_Movimiento.Location = new System.Drawing.Point(30, 91);
            this.Btn_Agregar_Movimiento.Name = "Btn_Agregar_Movimiento";
            this.Btn_Agregar_Movimiento.Size = new System.Drawing.Size(132, 80);
            this.Btn_Agregar_Movimiento.TabIndex = 61;
            this.Btn_Agregar_Movimiento.Text = "CREAR COMPROBANTE";
            this.Btn_Agregar_Movimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Movimiento.UseVisualStyleBackColor = true;
            // 
            // Frm_Comprobante_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GB_Ventas);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_LIMPIAR_COMPROBANTE);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Agregar_Movimiento);
            this.Name = "Frm_Comprobante_Venta";
            this.Text = "Frm_Comprobante_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GB_Ventas.ResumeLayout(false);
            this.GB_Ventas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox GB_Ventas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Venta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox Cbo_Id_Venta;
        private System.Windows.Forms.ComboBox Cbo_Id_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_LIMPIAR_COMPROBANTE;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Agregar_Movimiento;
    }
}