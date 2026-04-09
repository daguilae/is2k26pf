
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
            this.Cbo_Estado_Cheque = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Cobro = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Fecha_Emision = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Estado_Cheque = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Cobro = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Emision = new System.Windows.Forms.Label();
            this.Txt_Nombre_Titular = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Titular = new System.Windows.Forms.Label();
            this.Txt_Banco_Emisor = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Cheque = new System.Windows.Forms.TextBox();
            this.Lbl_Banco_Emisor = new System.Windows.Forms.Label();
            this.Lbl_Numero_Cheque = new System.Windows.Forms.Label();
            this.Gbo_Pago_Con_Cheque = new System.Windows.Forms.GroupBox();
            this.Lbl_Pago_Con_Cheque = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gbo_Cmpos.SuspendLayout();
            this.Gbo_Pago_Con_Cheque.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Cbo_Estado_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Cobro);
            this.Gbo_Cmpos.Controls.Add(this.Dtp_Fecha_Emision);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Estado_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha_Cobro);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Fecha_Emision);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Nombre_Titular);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Banco_Emisor);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Numero_Cheque);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Banco_Emisor);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Numero_Cheque);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(2, 146);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1161, 387);
            this.Gbo_Cmpos.TabIndex = 135;
            this.Gbo_Cmpos.TabStop = false;
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
            // Txt_Banco_Emisor
            // 
            this.Txt_Banco_Emisor.Location = new System.Drawing.Point(185, 90);
            this.Txt_Banco_Emisor.Name = "Txt_Banco_Emisor";
            this.Txt_Banco_Emisor.Size = new System.Drawing.Size(305, 22);
            this.Txt_Banco_Emisor.TabIndex = 28;
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
            this.Gbo_Pago_Con_Cheque.Location = new System.Drawing.Point(12, 36);
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
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1074, 57);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Limpiar.TabIndex = 134;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Guardar.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_guardar;
            this.Btn_Guardar.Location = new System.Drawing.Point(982, 57);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Guardar.TabIndex = 132;
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Nuevo.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_agregar;
            this.Btn_Nuevo.Location = new System.Drawing.Point(904, 57);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(55, 54);
            this.Btn_Nuevo.TabIndex = 131;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // Frm_Pago_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 609);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Gbo_Pago_Con_Cheque);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Pago_Cheque";
            this.Text = "Pago con cheque";
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.Gbo_Pago_Con_Cheque.ResumeLayout(false);
            this.Gbo_Pago_Con_Cheque.PerformLayout();
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
        private System.Windows.Forms.TextBox Txt_Banco_Emisor;
        private System.Windows.Forms.TextBox Txt_Numero_Cheque;
        private System.Windows.Forms.Label Lbl_Banco_Emisor;
        private System.Windows.Forms.Label Lbl_Numero_Cheque;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.GroupBox Gbo_Pago_Con_Cheque;
        private System.Windows.Forms.Label Lbl_Pago_Con_Cheque;
    }
}