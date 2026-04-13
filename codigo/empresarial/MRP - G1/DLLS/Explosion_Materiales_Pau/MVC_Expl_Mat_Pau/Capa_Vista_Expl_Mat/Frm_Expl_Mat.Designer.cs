
namespace Capa_Vista_Expl_Mat
{
    partial class Frm_Expl_Mat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Expl_Mat));
            this.Lbl_Seleccion = new System.Windows.Forms.Label();
            this.Pnl_1 = new System.Windows.Forms.Panel();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Btn_Explosion = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Pnl_2 = new System.Windows.Forms.Panel();
            this.Lbl_InfoBOM = new System.Windows.Forms.Label();
            this.Lbl_BOM = new System.Windows.Forms.Label();
            this.Lbl_NumeroBOM = new System.Windows.Forms.Label();
            this.Lbl_Est = new System.Windows.Forms.Label();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_LeadTime = new System.Windows.Forms.Label();
            this.Lbl_Dias = new System.Windows.Forms.Label();
            this.Lbl_FechaRequerida = new System.Windows.Forms.Label();
            this.Lbl_Factible = new System.Windows.Forms.Label();
            this.Lbl_DiasFact = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Pnl_3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pnl_4 = new System.Windows.Forms.Panel();
            this.Gpb_TotalMateriales = new System.Windows.Forms.GroupBox();
            this.Gpb_Stock = new System.Windows.Forms.GroupBox();
            this.Gpb_Deficit = new System.Windows.Forms.GroupBox();
            this.Gpb_Factibilidad = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Seleccion
            // 
            this.Lbl_Seleccion.AutoSize = true;
            this.Lbl_Seleccion.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seleccion.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Seleccion.Name = "Lbl_Seleccion";
            this.Lbl_Seleccion.Size = new System.Drawing.Size(441, 38);
            this.Lbl_Seleccion.TabIndex = 0;
            this.Lbl_Seleccion.Text = "SELECCIÓN DE PRODUCTO";
            // 
            // Pnl_1
            // 
            this.Pnl_1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_1.Location = new System.Drawing.Point(12, 58);
            this.Pnl_1.Name = "Pnl_1";
            this.Pnl_1.Size = new System.Drawing.Size(952, 10);
            this.Pnl_1.TabIndex = 1;
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto.Location = new System.Drawing.Point(15, 81);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(86, 20);
            this.Lbl_Producto.TabIndex = 2;
            this.Lbl_Producto.Text = "Producto";
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(19, 104);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(445, 28);
            this.Cmb_Producto.TabIndex = 3;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(903, 5);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(60, 47);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(837, 5);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(60, 47);
            this.Btn_Ayuda.TabIndex = 7;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Nud_Cantidad
            // 
            this.Nud_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud_Cantidad.Location = new System.Drawing.Point(552, 104);
            this.Nud_Cantidad.Name = "Nud_Cantidad";
            this.Nud_Cantidad.Size = new System.Drawing.Size(120, 27);
            this.Nud_Cantidad.TabIndex = 8;
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(548, 81);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(86, 20);
            this.Lbl_Cantidad.TabIndex = 9;
            this.Lbl_Cantidad.Text = "Producto";
            // 
            // Btn_Explosion
            // 
            this.Btn_Explosion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Explosion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Explosion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Explosion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Btn_Explosion.Location = new System.Drawing.Point(740, 95);
            this.Btn_Explosion.Name = "Btn_Explosion";
            this.Btn_Explosion.Size = new System.Drawing.Size(192, 37);
            this.Btn_Explosion.TabIndex = 16;
            this.Btn_Explosion.Text = "Explotar BOM";
            this.Btn_Explosion.UseVisualStyleBackColor = false;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Imprimir.Image")));
            this.Btn_Imprimir.Location = new System.Drawing.Point(771, 5);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(60, 47);
            this.Btn_Imprimir.TabIndex = 17;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Pnl_2
            // 
            this.Pnl_2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_2.Location = new System.Drawing.Point(12, 188);
            this.Pnl_2.Name = "Pnl_2";
            this.Pnl_2.Size = new System.Drawing.Size(952, 10);
            this.Pnl_2.TabIndex = 2;
            // 
            // Lbl_InfoBOM
            // 
            this.Lbl_InfoBOM.AutoSize = true;
            this.Lbl_InfoBOM.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoBOM.Location = new System.Drawing.Point(15, 165);
            this.Lbl_InfoBOM.Name = "Lbl_InfoBOM";
            this.Lbl_InfoBOM.Size = new System.Drawing.Size(229, 20);
            this.Lbl_InfoBOM.TabIndex = 18;
            this.Lbl_InfoBOM.Text = "INFORMACIÓN DE BOM:";
            // 
            // Lbl_BOM
            // 
            this.Lbl_BOM.AutoSize = true;
            this.Lbl_BOM.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BOM.Location = new System.Drawing.Point(15, 207);
            this.Lbl_BOM.Name = "Lbl_BOM";
            this.Lbl_BOM.Size = new System.Drawing.Size(60, 20);
            this.Lbl_BOM.TabIndex = 19;
            this.Lbl_BOM.Text = "BOM:";
            // 
            // Lbl_NumeroBOM
            // 
            this.Lbl_NumeroBOM.AutoSize = true;
            this.Lbl_NumeroBOM.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumeroBOM.Location = new System.Drawing.Point(81, 207);
            this.Lbl_NumeroBOM.Name = "Lbl_NumeroBOM";
            this.Lbl_NumeroBOM.Size = new System.Drawing.Size(117, 20);
            this.Lbl_NumeroBOM.TabIndex = 20;
            this.Lbl_NumeroBOM.Text = "BOM-001 v1.0";
            // 
            // Lbl_Est
            // 
            this.Lbl_Est.AutoSize = true;
            this.Lbl_Est.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Est.Location = new System.Drawing.Point(251, 207);
            this.Lbl_Est.Name = "Lbl_Est";
            this.Lbl_Est.Size = new System.Drawing.Size(88, 20);
            this.Lbl_Est.TabIndex = 21;
            this.Lbl_Est.Text = "ESTADO:";
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(345, 207);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(59, 20);
            this.Lbl_Estado.TabIndex = 22;
            this.Lbl_Estado.Text = "Activo";
            // 
            // Lbl_LeadTime
            // 
            this.Lbl_LeadTime.AutoSize = true;
            this.Lbl_LeadTime.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LeadTime.Location = new System.Drawing.Point(460, 207);
            this.Lbl_LeadTime.Name = "Lbl_LeadTime";
            this.Lbl_LeadTime.Size = new System.Drawing.Size(115, 20);
            this.Lbl_LeadTime.TabIndex = 23;
            this.Lbl_LeadTime.Text = "LEAD TIME:";
            // 
            // Lbl_Dias
            // 
            this.Lbl_Dias.AutoSize = true;
            this.Lbl_Dias.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dias.Location = new System.Drawing.Point(575, 207);
            this.Lbl_Dias.Name = "Lbl_Dias";
            this.Lbl_Dias.Size = new System.Drawing.Size(56, 20);
            this.Lbl_Dias.TabIndex = 24;
            this.Lbl_Dias.Text = "5 Días";
            // 
            // Lbl_FechaRequerida
            // 
            this.Lbl_FechaRequerida.AutoSize = true;
            this.Lbl_FechaRequerida.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaRequerida.Location = new System.Drawing.Point(685, 207);
            this.Lbl_FechaRequerida.Name = "Lbl_FechaRequerida";
            this.Lbl_FechaRequerida.Size = new System.Drawing.Size(185, 20);
            this.Lbl_FechaRequerida.TabIndex = 25;
            this.Lbl_FechaRequerida.Text = "FECHA REQUERIDA:";
            // 
            // Lbl_Factible
            // 
            this.Lbl_Factible.AutoSize = true;
            this.Lbl_Factible.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Factible.Location = new System.Drawing.Point(15, 248);
            this.Lbl_Factible.Name = "Lbl_Factible";
            this.Lbl_Factible.Size = new System.Drawing.Size(104, 20);
            this.Lbl_Factible.TabIndex = 27;
            this.Lbl_Factible.Text = "FACTIBLE:";
            // 
            // Lbl_DiasFact
            // 
            this.Lbl_DiasFact.AutoSize = true;
            this.Lbl_DiasFact.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DiasFact.Location = new System.Drawing.Point(125, 248);
            this.Lbl_DiasFact.Name = "Lbl_DiasFact";
            this.Lbl_DiasFact.Size = new System.Drawing.Size(179, 20);
            this.Lbl_DiasFact.TabIndex = 28;
            this.Lbl_DiasFact.Text = "Si (8 días disponibles)";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(689, 230);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(275, 22);
            this.Dtp_Fecha.TabIndex = 29;
            // 
            // Pnl_3
            // 
            this.Pnl_3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_3.Location = new System.Drawing.Point(12, 280);
            this.Pnl_3.Name = "Pnl_3";
            this.Pnl_3.Size = new System.Drawing.Size(952, 10);
            this.Pnl_3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "RESULTADO DE LA EXPLOSIÓN:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 423);
            this.dataGridView1.TabIndex = 31;
            // 
            // Pnl_4
            // 
            this.Pnl_4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Pnl_4.Location = new System.Drawing.Point(12, 354);
            this.Pnl_4.Name = "Pnl_4";
            this.Pnl_4.Size = new System.Drawing.Size(952, 10);
            this.Pnl_4.TabIndex = 4;
            // 
            // Gpb_TotalMateriales
            // 
            this.Gpb_TotalMateriales.Location = new System.Drawing.Point(12, 818);
            this.Gpb_TotalMateriales.Name = "Gpb_TotalMateriales";
            this.Gpb_TotalMateriales.Size = new System.Drawing.Size(232, 106);
            this.Gpb_TotalMateriales.TabIndex = 32;
            this.Gpb_TotalMateriales.TabStop = false;
            this.Gpb_TotalMateriales.Text = "Total de Materiales";
            // 
            // Gpb_Stock
            // 
            this.Gpb_Stock.Location = new System.Drawing.Point(255, 818);
            this.Gpb_Stock.Name = "Gpb_Stock";
            this.Gpb_Stock.Size = new System.Drawing.Size(232, 106);
            this.Gpb_Stock.TabIndex = 33;
            this.Gpb_Stock.TabStop = false;
            this.Gpb_Stock.Text = "Stock";
            // 
            // Gpb_Deficit
            // 
            this.Gpb_Deficit.Location = new System.Drawing.Point(493, 818);
            this.Gpb_Deficit.Name = "Gpb_Deficit";
            this.Gpb_Deficit.Size = new System.Drawing.Size(232, 106);
            this.Gpb_Deficit.TabIndex = 34;
            this.Gpb_Deficit.TabStop = false;
            this.Gpb_Deficit.Text = "Con Déficit";
            // 
            // Gpb_Factibilidad
            // 
            this.Gpb_Factibilidad.Location = new System.Drawing.Point(731, 818);
            this.Gpb_Factibilidad.Name = "Gpb_Factibilidad";
            this.Gpb_Factibilidad.Size = new System.Drawing.Size(232, 106);
            this.Gpb_Factibilidad.TabIndex = 35;
            this.Gpb_Factibilidad.TabStop = false;
            this.Gpb_Factibilidad.Text = "Factibilidad";
            // 
            // Frm_Expl_Mat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.Gpb_Factibilidad);
            this.Controls.Add(this.Gpb_Deficit);
            this.Controls.Add(this.Gpb_Stock);
            this.Controls.Add(this.Gpb_TotalMateriales);
            this.Controls.Add(this.Pnl_4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_3);
            this.Controls.Add(this.Dtp_Fecha);
            this.Controls.Add(this.Lbl_DiasFact);
            this.Controls.Add(this.Lbl_Factible);
            this.Controls.Add(this.Lbl_FechaRequerida);
            this.Controls.Add(this.Lbl_Dias);
            this.Controls.Add(this.Lbl_LeadTime);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Lbl_Est);
            this.Controls.Add(this.Lbl_NumeroBOM);
            this.Controls.Add(this.Lbl_BOM);
            this.Controls.Add(this.Lbl_InfoBOM);
            this.Controls.Add(this.Pnl_2);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Explosion);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.Nud_Cantidad);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Cmb_Producto);
            this.Controls.Add(this.Lbl_Producto);
            this.Controls.Add(this.Pnl_1);
            this.Controls.Add(this.Lbl_Seleccion);
            this.Name = "Frm_Expl_Mat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explosión de Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Seleccion;
        private System.Windows.Forms.Panel Pnl_1;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.NumericUpDown Nud_Cantidad;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Button Btn_Explosion;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Panel Pnl_2;
        private System.Windows.Forms.Label Lbl_InfoBOM;
        private System.Windows.Forms.Label Lbl_BOM;
        private System.Windows.Forms.Label Lbl_NumeroBOM;
        private System.Windows.Forms.Label Lbl_Est;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_LeadTime;
        private System.Windows.Forms.Label Lbl_Dias;
        private System.Windows.Forms.Label Lbl_FechaRequerida;
        private System.Windows.Forms.Label Lbl_Factible;
        private System.Windows.Forms.Label Lbl_DiasFact;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Panel Pnl_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Pnl_4;
        private System.Windows.Forms.GroupBox Gpb_TotalMateriales;
        private System.Windows.Forms.GroupBox Gpb_Stock;
        private System.Windows.Forms.GroupBox Gpb_Deficit;
        private System.Windows.Forms.GroupBox Gpb_Factibilidad;
    }
}