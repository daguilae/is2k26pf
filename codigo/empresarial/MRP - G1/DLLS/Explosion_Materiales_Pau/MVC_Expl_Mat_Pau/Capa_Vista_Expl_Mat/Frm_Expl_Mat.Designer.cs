
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
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Seleccion
            // 
            this.Lbl_Seleccion.AutoSize = true;
            this.Lbl_Seleccion.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seleccion.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Seleccion.Name = "Lbl_Seleccion";
            this.Lbl_Seleccion.Size = new System.Drawing.Size(344, 38);
            this.Lbl_Seleccion.TabIndex = 0;
            this.Lbl_Seleccion.Text = "Selección de Producto";
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
            this.Btn_Salir.Location = new System.Drawing.Point(872, 5);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(60, 47);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(806, 5);
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
            this.Btn_Imprimir.Location = new System.Drawing.Point(740, 5);
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
            this.Lbl_InfoBOM.Size = new System.Drawing.Size(195, 20);
            this.Lbl_InfoBOM.TabIndex = 18;
            this.Lbl_InfoBOM.Text = "Información del BOM";
            // 
            // Frm_Expl_Mat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 953);
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
            this.Text = "Explosión de Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cantidad)).EndInit();
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
    }
}