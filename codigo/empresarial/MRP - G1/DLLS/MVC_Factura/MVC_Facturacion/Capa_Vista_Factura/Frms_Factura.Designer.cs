
namespace Capa_Vista_Factura
{
    partial class Frms_Factura
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Txt_NoFactura = new System.Windows.Forms.TextBox();
            this.Dtp_Emision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_OrdenRecibida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_Facturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Facturación";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 51);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1284, 10);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Txt_NoFactura
            // 
            this.Txt_NoFactura.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NoFactura.Location = new System.Drawing.Point(15, 91);
            this.Txt_NoFactura.Name = "Txt_NoFactura";
            this.Txt_NoFactura.Size = new System.Drawing.Size(327, 23);
            this.Txt_NoFactura.TabIndex = 18;
            this.Txt_NoFactura.TextChanged += new System.EventHandler(this.Txt_NoFactura_TextChanged);
            // 
            // Dtp_Emision
            // 
            this.Dtp_Emision.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Emision.Location = new System.Drawing.Point(378, 91);
            this.Dtp_Emision.Name = "Dtp_Emision";
            this.Dtp_Emision.Size = new System.Drawing.Size(327, 23);
            this.Dtp_Emision.TabIndex = 19;
            this.Dtp_Emision.ValueChanged += new System.EventHandler(this.Dtp_Emision_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número de Factura:";
            // 
            // Cmb_OrdenRecibida
            // 
            this.Cmb_OrdenRecibida.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_OrdenRecibida.FormattingEnabled = true;
            this.Cmb_OrdenRecibida.Location = new System.Drawing.Point(737, 91);
            this.Cmb_OrdenRecibida.Name = "Cmb_OrdenRecibida";
            this.Cmb_OrdenRecibida.Size = new System.Drawing.Size(327, 24);
            this.Cmb_OrdenRecibida.TabIndex = 21;
            this.Cmb_OrdenRecibida.SelectedIndexChanged += new System.EventHandler(this.Cmb_OrdenRecibida_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha de Emisión:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(734, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Orden Recibida:";
            // 
            // Dgv_Facturas
            // 
            this.Dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Facturas.Location = new System.Drawing.Point(15, 132);
            this.Dgv_Facturas.Name = "Dgv_Facturas";
            this.Dgv_Facturas.RowHeadersWidth = 51;
            this.Dgv_Facturas.RowTemplate.Height = 24;
            this.Dgv_Facturas.Size = new System.Drawing.Size(1279, 384);
            this.Dgv_Facturas.TabIndex = 25;
            this.Dgv_Facturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Facturas_CellContentClick);
            // 
            // Frms_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 556);
            this.Controls.Add(this.Dgv_Facturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cmb_OrdenRecibida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Txt_NoFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_Emision);
            this.Controls.Add(this.label2);
            this.Name = "Frms_Factura";
            this.Text = "Frms_Factura";
            this.Load += new System.EventHandler(this.Frms_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Facturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Txt_NoFactura;
        private System.Windows.Forms.DateTimePicker Dtp_Emision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_OrdenRecibida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_Facturas;
    }
}