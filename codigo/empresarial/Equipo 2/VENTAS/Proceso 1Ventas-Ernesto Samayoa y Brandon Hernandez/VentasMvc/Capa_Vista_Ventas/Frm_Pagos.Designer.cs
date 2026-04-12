
namespace Capa_Vista_Ventas
{
    partial class Frm_Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pagos));
            this.Gbo_Cmpos = new System.Windows.Forms.GroupBox();
            this.Dtp_Fecha_Pago = new System.Windows.Forms.DateTimePicker();
            this.Txt_Monto = new System.Windows.Forms.TextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Cbo_MetodoPago = new System.Windows.Forms.ComboBox();
            this.Cbo_CXC = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Monto = new System.Windows.Forms.Label();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Lbl_MetodoPago = new System.Windows.Forms.Label();
            this.Lbl_Folio = new System.Windows.Forms.Label();
            this.Gbo_Pago = new System.Windows.Forms.GroupBox();
            this.Lbl_Pagos = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Gbo_Cmpos.SuspendLayout();
            this.Gbo_Pago.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Pago);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Monto);
            this.Gbo_Cmpos.Controls.Add(this.Cbo_Estado);
            this.Gbo_Cmpos.Controls.Add(this.Cbo_MetodoPago);
            this.Gbo_Cmpos.Controls.Add(this.Cbo_CXC);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Estado);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Monto);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_MetodoPago);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Folio);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(12, 215);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1058, 341);
            this.Gbo_Cmpos.TabIndex = 121;
            this.Gbo_Cmpos.TabStop = false;
            // 
            // Dtp_Fecha_Pago
            // 
            this.Dtp_Fecha_Pago.Location = new System.Drawing.Point(108, 123);
            this.Dtp_Fecha_Pago.Name = "Dtp_Fecha_Pago";
            this.Dtp_Fecha_Pago.Size = new System.Drawing.Size(366, 22);
            this.Dtp_Fecha_Pago.TabIndex = 26;
            // 
            // Txt_Monto
            // 
            this.Txt_Monto.Location = new System.Drawing.Point(685, 73);
            this.Txt_Monto.Name = "Txt_Monto";
            this.Txt_Monto.Size = new System.Drawing.Size(308, 22);
            this.Txt_Monto.TabIndex = 25;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(684, 25);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(309, 24);
            this.Cbo_Estado.TabIndex = 24;
            // 
            // Cbo_MetodoPago
            // 
            this.Cbo_MetodoPago.FormattingEnabled = true;
            this.Cbo_MetodoPago.Location = new System.Drawing.Point(202, 73);
            this.Cbo_MetodoPago.Name = "Cbo_MetodoPago";
            this.Cbo_MetodoPago.Size = new System.Drawing.Size(272, 24);
            this.Cbo_MetodoPago.TabIndex = 23;
            this.Cbo_MetodoPago.SelectedIndexChanged += new System.EventHandler(this.Cbo_MetodoPago_SelectedIndexChanged);
            // 
            // Cbo_CXC
            // 
            this.Cbo_CXC.FormattingEnabled = true;
            this.Cbo_CXC.Location = new System.Drawing.Point(211, 21);
            this.Cbo_CXC.Name = "Cbo_CXC";
            this.Cbo_CXC.Size = new System.Drawing.Size(293, 24);
            this.Cbo_CXC.TabIndex = 22;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(544, 28);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(125, 21);
            this.Lbl_Estado.TabIndex = 21;
            this.Lbl_Estado.Text = "Estado Pago:";
            // 
            // Lbl_Monto
            // 
            this.Lbl_Monto.AutoSize = true;
            this.Lbl_Monto.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto.Location = new System.Drawing.Point(558, 76);
            this.Lbl_Monto.Name = "Lbl_Monto";
            this.Lbl_Monto.Size = new System.Drawing.Size(121, 21);
            this.Lbl_Monto.TabIndex = 20;
            this.Lbl_Monto.Text = "Monto Total:";
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(34, 123);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(68, 21);
            this.Lbl_Fecha.TabIndex = 18;
            this.Lbl_Fecha.Text = "Fecha:";
            // 
            // Lbl_MetodoPago
            // 
            this.Lbl_MetodoPago.AutoSize = true;
            this.Lbl_MetodoPago.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MetodoPago.Location = new System.Drawing.Point(34, 73);
            this.Lbl_MetodoPago.Name = "Lbl_MetodoPago";
            this.Lbl_MetodoPago.Size = new System.Drawing.Size(162, 21);
            this.Lbl_MetodoPago.TabIndex = 17;
            this.Lbl_MetodoPago.Text = "Método de pago:";
            // 
            // Lbl_Folio
            // 
            this.Lbl_Folio.AutoSize = true;
            this.Lbl_Folio.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Folio.Location = new System.Drawing.Point(34, 25);
            this.Lbl_Folio.Name = "Lbl_Folio";
            this.Lbl_Folio.Size = new System.Drawing.Size(173, 21);
            this.Lbl_Folio.TabIndex = 16;
            this.Lbl_Folio.Text = "Cuenta por cobrar";
            // 
            // Gbo_Pago
            // 
            this.Gbo_Pago.Controls.Add(this.Lbl_Pagos);
            this.Gbo_Pago.Location = new System.Drawing.Point(12, 88);
            this.Gbo_Pago.Name = "Gbo_Pago";
            this.Gbo_Pago.Size = new System.Drawing.Size(699, 104);
            this.Gbo_Pago.TabIndex = 120;
            this.Gbo_Pago.TabStop = false;
            // 
            // Lbl_Pagos
            // 
            this.Lbl_Pagos.AutoSize = true;
            this.Lbl_Pagos.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Pagos.Location = new System.Drawing.Point(32, 21);
            this.Lbl_Pagos.Name = "Lbl_Pagos";
            this.Lbl_Pagos.Size = new System.Drawing.Size(106, 35);
            this.Lbl_Pagos.TabIndex = 112;
            this.Lbl_Pagos.Text = "Pagos ";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(1002, 104);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Limpiar.TabIndex = 119;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Nuevo.Image")));
            this.Btn_Nuevo.Location = new System.Drawing.Point(871, 104);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(55, 54);
            this.Btn_Nuevo.TabIndex = 117;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_guardar;
            this.Btn_Guardar.Location = new System.Drawing.Point(932, 104);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Guardar.TabIndex = 116;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 103);
            this.panel1.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "710 - Pagos ";
            // 
            // Frm_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gbo_Pago);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Pagos";
            this.Text = "Pagos";
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.Gbo_Pago.ResumeLayout(false);
            this.Gbo_Pago.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbo_Cmpos;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Pago;
        private System.Windows.Forms.TextBox Txt_Monto;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.ComboBox Cbo_MetodoPago;
        private System.Windows.Forms.ComboBox Cbo_CXC;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Monto;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label Lbl_MetodoPago;
        private System.Windows.Forms.Label Lbl_Folio;
        private System.Windows.Forms.GroupBox Gbo_Pago;
        private System.Windows.Forms.Label Lbl_Pagos;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}