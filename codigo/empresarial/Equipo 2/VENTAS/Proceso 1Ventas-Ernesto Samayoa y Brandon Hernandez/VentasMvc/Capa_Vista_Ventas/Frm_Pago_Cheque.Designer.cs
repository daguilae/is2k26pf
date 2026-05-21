
namespace Capa_Vista_Ventas
{
    partial class Frm_Pago_Cheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pago_Cheque));
            this.Gbo_Cmpos = new System.Windows.Forms.GroupBox();
            this.Cbo_Bancos = new System.Windows.Forms.ComboBox();
            this.Txt_Monto_Pagar = new System.Windows.Forms.TextBox();
            this.Lbl_Monto_Pagar = new System.Windows.Forms.Label();
            this.Txt_Monto_Total = new System.Windows.Forms.TextBox();
            this.Lbl_Monto_Pendiente = new System.Windows.Forms.Label();
            this.Cbo_Estado_Cheque = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Cobro = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Emision = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Estado_Cheque = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Cobro = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Emision = new System.Windows.Forms.Label();
            this.Txt_Nombre_Titular = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Titular = new System.Windows.Forms.Label();
            this.Txt_Numero_Cheque = new System.Windows.Forms.TextBox();
            this.Lbl_Banco_Emisor = new System.Windows.Forms.Label();
            this.Lbl_Numero_Cheque = new System.Windows.Forms.Label();
            this.Gbo_Pago_Con_Cheque = new System.Windows.Forms.GroupBox();
            this.Lbl_Pago_Con_Cheque = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Agregar_Ventas = new System.Windows.Forms.Button();
            this.Gbo_Cmpos.SuspendLayout();
            this.Gbo_Pago_Con_Cheque.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Cbo_Bancos);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Monto_Pagar);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Monto_Pagar);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Monto_Total);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Monto_Pendiente);
            this.Gbo_Cmpos.Controls.Add(this.Cbo_Estado_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Cobro);
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Emision);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Estado_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha_Cobro);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha_Emision);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Numero_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Banco_Emisor);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Numero_Cheque);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(12, 403);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1161, 387);
            this.Gbo_Cmpos.TabIndex = 135;
            this.Gbo_Cmpos.TabStop = false;
            // 
            // Cbo_Bancos
            // 
            this.Cbo_Bancos.FormattingEnabled = true;
            this.Cbo_Bancos.Location = new System.Drawing.Point(212, 87);
            this.Cbo_Bancos.Name = "Cbo_Bancos";
            this.Cbo_Bancos.Size = new System.Drawing.Size(280, 24);
            this.Cbo_Bancos.TabIndex = 138;
            // 
            // Txt_Monto_Pagar
            // 
            this.Txt_Monto_Pagar.Location = new System.Drawing.Point(762, 149);
            this.Txt_Monto_Pagar.Name = "Txt_Monto_Pagar";
            this.Txt_Monto_Pagar.Size = new System.Drawing.Size(265, 22);
            this.Txt_Monto_Pagar.TabIndex = 137;
            // 
            // Lbl_Monto_Pagar
            // 
            this.Lbl_Monto_Pagar.AutoSize = true;
            this.Lbl_Monto_Pagar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto_Pagar.Location = new System.Drawing.Point(546, 150);
            this.Lbl_Monto_Pagar.Name = "Lbl_Monto_Pagar";
            this.Lbl_Monto_Pagar.Size = new System.Drawing.Size(138, 21);
            this.Lbl_Monto_Pagar.TabIndex = 136;
            this.Lbl_Monto_Pagar.Text = "Monto a pagar";
            // 
            // Txt_Monto_Total
            // 
            this.Txt_Monto_Total.Location = new System.Drawing.Point(762, 91);
            this.Txt_Monto_Total.Name = "Txt_Monto_Total";
            this.Txt_Monto_Total.Size = new System.Drawing.Size(265, 22);
            this.Txt_Monto_Total.TabIndex = 135;
            // 
            // Lbl_Monto_Pendiente
            // 
            this.Lbl_Monto_Pendiente.AutoSize = true;
            this.Lbl_Monto_Pendiente.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Monto_Pendiente.Location = new System.Drawing.Point(562, 92);
            this.Lbl_Monto_Pendiente.Name = "Lbl_Monto_Pendiente";
            this.Lbl_Monto_Pendiente.Size = new System.Drawing.Size(166, 21);
            this.Lbl_Monto_Pendiente.TabIndex = 134;
            this.Lbl_Monto_Pendiente.Text = "Monto Pendiente ";
            // 
            // Cbo_Estado_Cheque
            // 
            this.Cbo_Estado_Cheque.FormattingEnabled = true;
            this.Cbo_Estado_Cheque.Location = new System.Drawing.Point(715, 29);
            this.Cbo_Estado_Cheque.Name = "Cbo_Estado_Cheque";
            this.Cbo_Estado_Cheque.Size = new System.Drawing.Size(291, 24);
            this.Cbo_Estado_Cheque.TabIndex = 133;
            // 
            // Dtp_Fecha_Cobro
            // 
            this.Dtp_Fecha_Cobro.Location = new System.Drawing.Point(201, 247);
            this.Dtp_Fecha_Cobro.Name = "Dtp_Fecha_Cobro";
            this.Dtp_Fecha_Cobro.Size = new System.Drawing.Size(291, 22);
            this.Dtp_Fecha_Cobro.TabIndex = 132;
            // 
            // Dtp_Fecha_Emision
            // 
            this.Dtp_Fecha_Emision.Location = new System.Drawing.Point(201, 201);
            this.Dtp_Fecha_Emision.Name = "Dtp_Fecha_Emision";
            this.Dtp_Fecha_Emision.Size = new System.Drawing.Size(291, 22);
            this.Dtp_Fecha_Emision.TabIndex = 131;
            // 
            // Lbl_Estado_Cheque
            // 
            this.Lbl_Estado_Cheque.AutoSize = true;
            this.Lbl_Estado_Cheque.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Estado_Cheque.Location = new System.Drawing.Point(562, 30);
            this.Lbl_Estado_Cheque.Name = "Lbl_Estado_Cheque";
            this.Lbl_Estado_Cheque.Size = new System.Drawing.Size(147, 21);
            this.Lbl_Estado_Cheque.TabIndex = 130;
            this.Lbl_Estado_Cheque.Text = "Estado cheque:";
            // 
            // Lbl_Fecha_Cobro
            // 
            this.Lbl_Fecha_Cobro.AutoSize = true;
            this.Lbl_Fecha_Cobro.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Fecha_Cobro.Location = new System.Drawing.Point(45, 247);
            this.Lbl_Fecha_Cobro.Name = "Lbl_Fecha_Cobro";
            this.Lbl_Fecha_Cobro.Size = new System.Drawing.Size(125, 21);
            this.Lbl_Fecha_Cobro.TabIndex = 32;
            this.Lbl_Fecha_Cobro.Text = "Fecha cobro:";
            // 
            // Lbl_Fecha_Emision
            // 
            this.Lbl_Fecha_Emision.AutoSize = true;
            this.Lbl_Fecha_Emision.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Fecha_Emision.Location = new System.Drawing.Point(45, 201);
            this.Lbl_Fecha_Emision.Name = "Lbl_Fecha_Emision";
            this.Lbl_Fecha_Emision.Size = new System.Drawing.Size(143, 21);
            this.Lbl_Fecha_Emision.TabIndex = 31;
            this.Lbl_Fecha_Emision.Text = "Fecha emisión:";
            // 
            // Txt_Nombre_Titular
            // 
            this.Txt_Nombre_Titular.Location = new System.Drawing.Point(201, 150);
            this.Txt_Nombre_Titular.Name = "Txt_Nombre_Titular";
            this.Txt_Nombre_Titular.Size = new System.Drawing.Size(291, 22);
            this.Txt_Nombre_Titular.TabIndex = 30;
            // 
            // Lbl_Nombre_Titular
            // 
            this.Lbl_Nombre_Titular.AutoSize = true;
            this.Lbl_Nombre_Titular.Font = new System.Drawing.Font("Rockwell", 10.8F);
            this.Lbl_Nombre_Titular.Location = new System.Drawing.Point(44, 150);
            this.Lbl_Nombre_Titular.Name = "Lbl_Nombre_Titular";
            this.Lbl_Nombre_Titular.Size = new System.Drawing.Size(151, 21);
            this.Lbl_Nombre_Titular.TabIndex = 29;
            this.Lbl_Nombre_Titular.Text = "Nombre TItular:";
            // 
            // Txt_Numero_Cheque
            // 
            this.Txt_Numero_Cheque.Location = new System.Drawing.Point(212, 29);
            this.Txt_Numero_Cheque.Name = "Txt_Numero_Cheque";
            this.Txt_Numero_Cheque.Size = new System.Drawing.Size(280, 22);
            this.Txt_Numero_Cheque.TabIndex = 27;
            // 
            // Lbl_Banco_Emisor
            // 
            this.Lbl_Banco_Emisor.AutoSize = true;
            this.Lbl_Banco_Emisor.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banco_Emisor.Location = new System.Drawing.Point(44, 90);
            this.Lbl_Banco_Emisor.Name = "Lbl_Banco_Emisor";
            this.Lbl_Banco_Emisor.Size = new System.Drawing.Size(135, 21);
            this.Lbl_Banco_Emisor.TabIndex = 17;
            this.Lbl_Banco_Emisor.Text = "Banco emisor:";
            // 
            // Lbl_Numero_Cheque
            // 
            this.Lbl_Numero_Cheque.AutoSize = true;
            this.Lbl_Numero_Cheque.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Cheque.Location = new System.Drawing.Point(44, 29);
            this.Lbl_Numero_Cheque.Name = "Lbl_Numero_Cheque";
            this.Lbl_Numero_Cheque.Size = new System.Drawing.Size(162, 21);
            this.Lbl_Numero_Cheque.TabIndex = 16;
            this.Lbl_Numero_Cheque.Text = "Numero Cheque:";
            // 
            // Gbo_Pago_Con_Cheque
            // 
            this.Gbo_Pago_Con_Cheque.Controls.Add(this.Lbl_Pago_Con_Cheque);
            this.Gbo_Pago_Con_Cheque.Location = new System.Drawing.Point(12, 280);
            this.Gbo_Pago_Con_Cheque.Name = "Gbo_Pago_Con_Cheque";
            this.Gbo_Pago_Con_Cheque.Size = new System.Drawing.Size(699, 104);
            this.Gbo_Pago_Con_Cheque.TabIndex = 130;
            this.Gbo_Pago_Con_Cheque.TabStop = false;
            // 
            // Lbl_Pago_Con_Cheque
            // 
            this.Lbl_Pago_Con_Cheque.AutoSize = true;
            this.Lbl_Pago_Con_Cheque.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Pago_Con_Cheque.Location = new System.Drawing.Point(32, 21);
            this.Lbl_Pago_Con_Cheque.Name = "Lbl_Pago_Con_Cheque";
            this.Lbl_Pago_Con_Cheque.Size = new System.Drawing.Size(266, 35);
            this.Lbl_Pago_Con_Cheque.TabIndex = 112;
            this.Lbl_Pago_Con_Cheque.Text = "Pagos con cheque";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 98);
            this.panel1.TabIndex = 136;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "734 - Pagos ";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(836, 134);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(111, 98);
            this.Btn_Salir.TabIndex = 141;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(649, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 98);
            this.button3.TabIndex = 140;
            this.button3.Text = "AYUDA";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Cancelar_Ventas
            // 
            this.Btn_Cancelar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar_Ventas.Image")));
            this.Btn_Cancelar_Ventas.Location = new System.Drawing.Point(470, 134);
            this.Btn_Cancelar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar_Ventas.Name = "Btn_Cancelar_Ventas";
            this.Btn_Cancelar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Cancelar_Ventas.TabIndex = 138;
            this.Btn_Cancelar_Ventas.Text = "CANCELAR";
            this.Btn_Cancelar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(265, 134);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Guardar.TabIndex = 139;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Agregar_Ventas
            // 
            this.Btn_Agregar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Ventas.Image")));
            this.Btn_Agregar_Ventas.Location = new System.Drawing.Point(61, 134);
            this.Btn_Agregar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Agregar_Ventas.Name = "Btn_Agregar_Ventas";
            this.Btn_Agregar_Ventas.Size = new System.Drawing.Size(111, 98);
            this.Btn_Agregar_Ventas.TabIndex = 137;
            this.Btn_Agregar_Ventas.Text = "INGRESAR";
            this.Btn_Agregar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Ventas.UseVisualStyleBackColor = true;
            // 
            // Frm_Pago_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 812);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Cancelar_Ventas);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Agregar_Ventas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Controls.Add(this.Gbo_Pago_Con_Cheque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Pago_Cheque";
            this.Text = "Pago con cheque";
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.Gbo_Pago_Con_Cheque.ResumeLayout(false);
            this.Gbo_Pago_Con_Cheque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbo_Cmpos;
        private System.Windows.Forms.ComboBox Cbo_Estado_Cheque;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Cobro;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Emision;
        private System.Windows.Forms.Label Lbl_Estado_Cheque;
        private System.Windows.Forms.Label Lbl_Fecha_Cobro;
        private System.Windows.Forms.Label Lbl_Fecha_Emision;
        private System.Windows.Forms.TextBox Txt_Nombre_Titular;
        private System.Windows.Forms.Label Lbl_Nombre_Titular;
        private System.Windows.Forms.TextBox Txt_Numero_Cheque;
        private System.Windows.Forms.Label Lbl_Banco_Emisor;
        private System.Windows.Forms.Label Lbl_Numero_Cheque;
        private System.Windows.Forms.GroupBox Gbo_Pago_Con_Cheque;
        private System.Windows.Forms.Label Lbl_Pago_Con_Cheque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Cancelar_Ventas;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Agregar_Ventas;
        private System.Windows.Forms.TextBox Txt_Monto_Total;
        private System.Windows.Forms.Label Lbl_Monto_Pendiente;
        private System.Windows.Forms.TextBox Txt_Monto_Pagar;
        private System.Windows.Forms.Label Lbl_Monto_Pagar;
        private System.Windows.Forms.ComboBox Cbo_Bancos;
    }
}