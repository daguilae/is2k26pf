
namespace Capa_Vista_Ventas
{
    partial class Frm_pago_efectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pago_efectivo));
            this.Gbo_Cmpos = new System.Windows.Forms.GroupBox();
            this.Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Txt_Numero_Recibo = new System.Windows.Forms.TextBox();
            this.Lbl_Observaciones = new System.Windows.Forms.Label();
            this.Lbl_Numero_Recibo = new System.Windows.Forms.Label();
            this.Gbo_Pago_Con_Efectivo = new System.Windows.Forms.GroupBox();
            this.Lbl_Pago_Con_Efectivo = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Gbo_Cmpos.SuspendLayout();
            this.Gbo_Pago_Con_Efectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbo_Cmpos
            // 
            this.Gbo_Cmpos.Controls.Add(this.Txt_Observaciones);
            this.Gbo_Cmpos.Controls.Add(this.Txt_Numero_Recibo);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Observaciones);
            this.Gbo_Cmpos.Controls.Add(this.Lbl_Numero_Recibo);
            this.Gbo_Cmpos.Location = new System.Drawing.Point(13, 154);
            this.Gbo_Cmpos.Name = "Gbo_Cmpos";
            this.Gbo_Cmpos.Size = new System.Drawing.Size(1144, 341);
            this.Gbo_Cmpos.TabIndex = 128;
            this.Gbo_Cmpos.TabStop = false;
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(235, 88);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(280, 22);
            this.Txt_Observaciones.TabIndex = 28;
            // 
            // Txt_Numero_Recibo
            // 
            this.Txt_Numero_Recibo.Location = new System.Drawing.Point(235, 28);
            this.Txt_Numero_Recibo.Name = "Txt_Numero_Recibo";
            this.Txt_Numero_Recibo.Size = new System.Drawing.Size(280, 22);
            this.Txt_Numero_Recibo.TabIndex = 27;
            // 
            // Lbl_Observaciones
            // 
            this.Lbl_Observaciones.AutoSize = true;
            this.Lbl_Observaciones.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Observaciones.Location = new System.Drawing.Point(31, 89);
            this.Lbl_Observaciones.Name = "Lbl_Observaciones";
            this.Lbl_Observaciones.Size = new System.Drawing.Size(149, 21);
            this.Lbl_Observaciones.TabIndex = 17;
            this.Lbl_Observaciones.Text = "Observaciones:";
            // 
            // Lbl_Numero_Recibo
            // 
            this.Lbl_Numero_Recibo.AutoSize = true;
            this.Lbl_Numero_Recibo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Numero_Recibo.Location = new System.Drawing.Point(31, 28);
            this.Lbl_Numero_Recibo.Name = "Lbl_Numero_Recibo";
            this.Lbl_Numero_Recibo.Size = new System.Drawing.Size(150, 21);
            this.Lbl_Numero_Recibo.TabIndex = 16;
            this.Lbl_Numero_Recibo.Text = "Número recibo:";
            // 
            // Gbo_Pago_Con_Efectivo
            // 
            this.Gbo_Pago_Con_Efectivo.Controls.Add(this.Lbl_Pago_Con_Efectivo);
            this.Gbo_Pago_Con_Efectivo.Location = new System.Drawing.Point(12, 22);
            this.Gbo_Pago_Con_Efectivo.Name = "Gbo_Pago_Con_Efectivo";
            this.Gbo_Pago_Con_Efectivo.Size = new System.Drawing.Size(699, 104);
            this.Gbo_Pago_Con_Efectivo.TabIndex = 127;
            this.Gbo_Pago_Con_Efectivo.TabStop = false;
            // 
            // Lbl_Pago_Con_Efectivo
            // 
            this.Lbl_Pago_Con_Efectivo.AutoSize = true;
            this.Lbl_Pago_Con_Efectivo.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_Pago_Con_Efectivo.Location = new System.Drawing.Point(32, 21);
            this.Lbl_Pago_Con_Efectivo.Name = "Lbl_Pago_Con_Efectivo";
            this.Lbl_Pago_Con_Efectivo.Size = new System.Drawing.Size(274, 35);
            this.Lbl_Pago_Con_Efectivo.TabIndex = 112;
            this.Lbl_Pago_Con_Efectivo.Text = "Pagos con efectivo";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Limpiar.Image = global::Capa_Vista_Ventas.Properties.Resources.icono_limpiar__1_;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1083, 43);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Limpiar.TabIndex = 132;
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
            this.Btn_Guardar.Location = new System.Drawing.Point(1002, 43);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(55, 54);
            this.Btn_Guardar.TabIndex = 130;
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
            this.Btn_Nuevo.Location = new System.Drawing.Point(919, 43);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(55, 54);
            this.Btn_Nuevo.TabIndex = 129;
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // Frm_pago_efectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 601);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Gbo_Cmpos);
            this.Controls.Add(this.Gbo_Pago_Con_Efectivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_pago_efectivo";
            this.Text = "Pago con efectivo ";
            this.Gbo_Cmpos.ResumeLayout(false);
            this.Gbo_Cmpos.PerformLayout();
            this.Gbo_Pago_Con_Efectivo.ResumeLayout(false);
            this.Gbo_Pago_Con_Efectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.GroupBox Gbo_Cmpos;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.TextBox Txt_Numero_Recibo;
        private System.Windows.Forms.Label Lbl_Observaciones;
        private System.Windows.Forms.Label Lbl_Numero_Recibo;
        private System.Windows.Forms.GroupBox Gbo_Pago_Con_Efectivo;
        private System.Windows.Forms.Label Lbl_Pago_Con_Efectivo;
    }
}