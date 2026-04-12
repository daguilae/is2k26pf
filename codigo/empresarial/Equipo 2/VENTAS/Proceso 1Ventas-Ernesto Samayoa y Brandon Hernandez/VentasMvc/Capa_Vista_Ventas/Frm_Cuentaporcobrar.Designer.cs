
namespace Capa_Vista_Ventas
{
    partial class Frm_Cuentaporcobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cuentaporcobrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Btn_CXCDetalle = new System.Windows.Forms.Button();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_MontoTotal = new System.Windows.Forms.TextBox();
            this.Lbl_MontoTotal = new System.Windows.Forms.Label();
            this.Dtp_FechaDeuda = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fechadeuda = new System.Windows.Forms.Label();
            this.DTP_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Vencimiento = new System.Windows.Forms.Label();
            this.Cbo_IdCXC = new System.Windows.Forms.ComboBox();
            this.Lbl_IDCXC = new System.Windows.Forms.Label();
            this.Cbo_Clientes = new System.Windows.Forms.ComboBox();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.Cbo_Ventas = new System.Windows.Forms.ComboBox();
            this.Lbl_IdVenta = new System.Windows.Forms.Label();
            this.Btn_Limpiar_Ventas = new System.Windows.Forms.Button();
            this.Btn_buscar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reporte_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 87);
            this.panel1.TabIndex = 135;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "711- Cuenta Por cobrar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Estado);
            this.groupBox1.Controls.Add(this.Btn_CXCDetalle);
            this.groupBox1.Controls.Add(this.Lbl_Estado);
            this.groupBox1.Controls.Add(this.Txt_MontoTotal);
            this.groupBox1.Controls.Add(this.Lbl_MontoTotal);
            this.groupBox1.Controls.Add(this.Dtp_FechaDeuda);
            this.groupBox1.Controls.Add(this.Lbl_Fechadeuda);
            this.groupBox1.Controls.Add(this.DTP_FechaVencimiento);
            this.groupBox1.Controls.Add(this.Lbl_Fecha_Vencimiento);
            this.groupBox1.Controls.Add(this.Cbo_IdCXC);
            this.groupBox1.Controls.Add(this.Lbl_IDCXC);
            this.groupBox1.Controls.Add(this.Cbo_Clientes);
            this.groupBox1.Controls.Add(this.Lbl_Cliente);
            this.groupBox1.Controls.Add(this.Cbo_Ventas);
            this.groupBox1.Controls.Add(this.Lbl_IdVenta);
            this.groupBox1.Location = new System.Drawing.Point(14, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1363, 564);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Estado.Location = new System.Drawing.Point(706, 286);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(451, 31);
            this.Txt_Estado.TabIndex = 164;
            // 
            // Btn_CXCDetalle
            // 
            this.Btn_CXCDetalle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_CXCDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CXCDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_CXCDetalle.Location = new System.Drawing.Point(426, 417);
            this.Btn_CXCDetalle.Name = "Btn_CXCDetalle";
            this.Btn_CXCDetalle.Size = new System.Drawing.Size(322, 82);
            this.Btn_CXCDetalle.TabIndex = 163;
            this.Btn_CXCDetalle.Text = "Ver Detalle ";
            this.Btn_CXCDetalle.UseVisualStyleBackColor = false;
            this.Btn_CXCDetalle.Click += new System.EventHandler(this.Btn_CXCDetalle_Click);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(606, 289);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(78, 22);
            this.Lbl_Estado.TabIndex = 162;
            this.Lbl_Estado.Text = "Estado ";
            // 
            // Txt_MontoTotal
            // 
            this.Txt_MontoTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_MontoTotal.Location = new System.Drawing.Point(182, 286);
            this.Txt_MontoTotal.Name = "Txt_MontoTotal";
            this.Txt_MontoTotal.Size = new System.Drawing.Size(390, 31);
            this.Txt_MontoTotal.TabIndex = 161;
            // 
            // Lbl_MontoTotal
            // 
            this.Lbl_MontoTotal.AutoSize = true;
            this.Lbl_MontoTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MontoTotal.Location = new System.Drawing.Point(20, 295);
            this.Lbl_MontoTotal.Name = "Lbl_MontoTotal";
            this.Lbl_MontoTotal.Size = new System.Drawing.Size(112, 22);
            this.Lbl_MontoTotal.TabIndex = 160;
            this.Lbl_MontoTotal.Text = "Monto total";
            // 
            // Dtp_FechaDeuda
            // 
            this.Dtp_FechaDeuda.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaDeuda.Location = new System.Drawing.Point(174, 176);
            this.Dtp_FechaDeuda.Name = "Dtp_FechaDeuda";
            this.Dtp_FechaDeuda.Size = new System.Drawing.Size(398, 31);
            this.Dtp_FechaDeuda.TabIndex = 159;
            // 
            // Lbl_Fechadeuda
            // 
            this.Lbl_Fechadeuda.AutoSize = true;
            this.Lbl_Fechadeuda.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fechadeuda.Location = new System.Drawing.Point(6, 182);
            this.Lbl_Fechadeuda.Name = "Lbl_Fechadeuda";
            this.Lbl_Fechadeuda.Size = new System.Drawing.Size(159, 22);
            this.Lbl_Fechadeuda.TabIndex = 158;
            this.Lbl_Fechadeuda.Text = "Fecha de Deuda";
            // 
            // DTP_FechaVencimiento
            // 
            this.DTP_FechaVencimiento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_FechaVencimiento.Location = new System.Drawing.Point(836, 172);
            this.DTP_FechaVencimiento.Name = "DTP_FechaVencimiento";
            this.DTP_FechaVencimiento.Size = new System.Drawing.Size(486, 31);
            this.DTP_FechaVencimiento.TabIndex = 157;
            // 
            // Lbl_Fecha_Vencimiento
            // 
            this.Lbl_Fecha_Vencimiento.AutoSize = true;
            this.Lbl_Fecha_Vencimiento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Vencimiento.Location = new System.Drawing.Point(594, 172);
            this.Lbl_Fecha_Vencimiento.Name = "Lbl_Fecha_Vencimiento";
            this.Lbl_Fecha_Vencimiento.Size = new System.Drawing.Size(217, 22);
            this.Lbl_Fecha_Vencimiento.TabIndex = 156;
            this.Lbl_Fecha_Vencimiento.Text = "Fecha de Vencimiento ";
            // 
            // Cbo_IdCXC
            // 
            this.Cbo_IdCXC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_IdCXC.FormattingEnabled = true;
            this.Cbo_IdCXC.Location = new System.Drawing.Point(241, 36);
            this.Cbo_IdCXC.Name = "Cbo_IdCXC";
            this.Cbo_IdCXC.Size = new System.Drawing.Size(216, 30);
            this.Cbo_IdCXC.TabIndex = 155;
            // 
            // Lbl_IDCXC
            // 
            this.Lbl_IDCXC.AutoSize = true;
            this.Lbl_IDCXC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDCXC.Location = new System.Drawing.Point(20, 39);
            this.Lbl_IDCXC.Name = "Lbl_IDCXC";
            this.Lbl_IDCXC.Size = new System.Drawing.Size(207, 22);
            this.Lbl_IDCXC.TabIndex = 154;
            this.Lbl_IDCXC.Text = "ID Cuenta Por Cobrar";
            // 
            // Cbo_Clientes
            // 
            this.Cbo_Clientes.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Clientes.FormattingEnabled = true;
            this.Cbo_Clientes.Location = new System.Drawing.Point(706, 109);
            this.Cbo_Clientes.Name = "Cbo_Clientes";
            this.Cbo_Clientes.Size = new System.Drawing.Size(616, 30);
            this.Cbo_Clientes.TabIndex = 153;
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cliente.Location = new System.Drawing.Point(568, 112);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(76, 22);
            this.Lbl_Cliente.TabIndex = 152;
            this.Lbl_Cliente.Text = "Cliente";
            // 
            // Cbo_Ventas
            // 
            this.Cbo_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Ventas.FormattingEnabled = true;
            this.Cbo_Ventas.Location = new System.Drawing.Point(174, 112);
            this.Cbo_Ventas.Name = "Cbo_Ventas";
            this.Cbo_Ventas.Size = new System.Drawing.Size(297, 30);
            this.Cbo_Ventas.TabIndex = 151;
            // 
            // Lbl_IdVenta
            // 
            this.Lbl_IdVenta.AutoSize = true;
            this.Lbl_IdVenta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdVenta.Location = new System.Drawing.Point(20, 119);
            this.Lbl_IdVenta.Name = "Lbl_IdVenta";
            this.Lbl_IdVenta.Size = new System.Drawing.Size(63, 22);
            this.Lbl_IdVenta.TabIndex = 150;
            this.Lbl_IdVenta.Text = "Venta";
            // 
            // Btn_Limpiar_Ventas
            // 
            this.Btn_Limpiar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Ventas.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar_Ventas.Location = new System.Drawing.Point(24, 101);
            this.Btn_Limpiar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar_Ventas.Name = "Btn_Limpiar_Ventas";
            this.Btn_Limpiar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Limpiar_Ventas.TabIndex = 145;
            this.Btn_Limpiar_Ventas.Text = "LIMPIAR";
            this.Btn_Limpiar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_buscar_Ventas
            // 
            this.Btn_buscar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar_Ventas.Image")));
            this.Btn_buscar_Ventas.Location = new System.Drawing.Point(139, 101);
            this.Btn_buscar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar_Ventas.Name = "Btn_buscar_Ventas";
            this.Btn_buscar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_buscar_Ventas.TabIndex = 144;
            this.Btn_buscar_Ventas.Text = "BUSCAR";
            this.Btn_buscar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(496, 101);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(111, 98);
            this.Btn_Salir.TabIndex = 143;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Btn_Reporte_Ventas
            // 
            this.Btn_Reporte_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte_Ventas.Image")));
            this.Btn_Reporte_Ventas.Location = new System.Drawing.Point(258, 101);
            this.Btn_Reporte_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Ventas.Name = "Btn_Reporte_Ventas";
            this.Btn_Reporte_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Reporte_Ventas.TabIndex = 141;
            this.Btn_Reporte_Ventas.Text = "REPORTE";
            this.Btn_Reporte_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(377, 101);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(111, 98);
            this.Btn_Ayuda.TabIndex = 140;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Frm_Cuentaporcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 788);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Limpiar_Ventas);
            this.Controls.Add(this.Btn_buscar_Ventas);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte_Ventas);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cuentaporcobrar";
            this.Text = "Cuentas Por Cobrar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_buscar_Ventas;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Reporte_Ventas;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Limpiar_Ventas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.Button Btn_CXCDetalle;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_MontoTotal;
        private System.Windows.Forms.Label Lbl_MontoTotal;
        private System.Windows.Forms.DateTimePicker Dtp_FechaDeuda;
        private System.Windows.Forms.Label Lbl_Fechadeuda;
        private System.Windows.Forms.DateTimePicker DTP_FechaVencimiento;
        private System.Windows.Forms.Label Lbl_Fecha_Vencimiento;
        private System.Windows.Forms.ComboBox Cbo_IdCXC;
        private System.Windows.Forms.Label Lbl_IDCXC;
        private System.Windows.Forms.ComboBox Cbo_Clientes;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.ComboBox Cbo_Ventas;
        private System.Windows.Forms.Label Lbl_IdVenta;
    }
}