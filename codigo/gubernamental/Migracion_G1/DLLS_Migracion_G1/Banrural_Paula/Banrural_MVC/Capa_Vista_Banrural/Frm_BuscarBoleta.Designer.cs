
namespace Capa_Vista_Banrural
{
    partial class Frm_BuscarBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarBoleta));
            this.Txt_Dpi = new System.Windows.Forms.TextBox();
            this.Lbl_Dpi = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Lbl_BuscarBoleta = new System.Windows.Forms.Label();
            this.Lbl_Banrural = new System.Windows.Forms.Label();
            this.Pnl_separacion = new System.Windows.Forms.Panel();
            this.Pic_Banrural = new System.Windows.Forms.PictureBox();
            this.Btn_BuscarDpi = new System.Windows.Forms.Button();
            this.Dgv_Boletas = new System.Windows.Forms.DataGridView();
            this.Txt_Apellidos = new System.Windows.Forms.TextBox();
            this.Lbl_Apellidos = new System.Windows.Forms.Label();
            this.Txt_Nombres = new System.Windows.Forms.TextBox();
            this.Lbl_Nombres = new System.Windows.Forms.Label();
            this.Btn_LimpiarTodo = new System.Windows.Forms.Button();
            this.Btn_EliminarBoleta = new System.Windows.Forms.Button();
            this.Btn_ModificarBoleta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Banrural)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Boletas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Dpi
            // 
            this.Txt_Dpi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Dpi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Dpi.Location = new System.Drawing.Point(59, 168);
            this.Txt_Dpi.Name = "Txt_Dpi";
            this.Txt_Dpi.Size = new System.Drawing.Size(363, 27);
            this.Txt_Dpi.TabIndex = 10;
            this.Txt_Dpi.TextChanged += new System.EventHandler(this.Txt_Dpi_TextChanged);
            // 
            // Lbl_Dpi
            // 
            this.Lbl_Dpi.AutoSize = true;
            this.Lbl_Dpi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dpi.Location = new System.Drawing.Point(12, 170);
            this.Lbl_Dpi.Name = "Lbl_Dpi";
            this.Lbl_Dpi.Size = new System.Drawing.Size(41, 20);
            this.Lbl_Dpi.TabIndex = 9;
            this.Lbl_Dpi.Text = "DPI:";
            this.Lbl_Dpi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(860, 22);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(60, 47);
            this.Btn_Salir.TabIndex = 16;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(794, 22);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(60, 47);
            this.Btn_Ayuda.TabIndex = 15;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Lbl_BuscarBoleta
            // 
            this.Lbl_BuscarBoleta.AutoSize = true;
            this.Lbl_BuscarBoleta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BuscarBoleta.Location = new System.Drawing.Point(311, 69);
            this.Lbl_BuscarBoleta.Name = "Lbl_BuscarBoleta";
            this.Lbl_BuscarBoleta.Size = new System.Drawing.Size(367, 22);
            this.Lbl_BuscarBoleta.TabIndex = 14;
            this.Lbl_BuscarBoleta.Text = "Busqueda de Boleta de Pago Pasaporte";
            this.Lbl_BuscarBoleta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Banrural
            // 
            this.Lbl_Banrural.AutoSize = true;
            this.Lbl_Banrural.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Banrural.Location = new System.Drawing.Point(412, 31);
            this.Lbl_Banrural.Name = "Lbl_Banrural";
            this.Lbl_Banrural.Size = new System.Drawing.Size(187, 38);
            this.Lbl_Banrural.TabIndex = 13;
            this.Lbl_Banrural.Text = "BANRURAL";
            this.Lbl_Banrural.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pnl_separacion
            // 
            this.Pnl_separacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(48)))));
            this.Pnl_separacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pnl_separacion.Location = new System.Drawing.Point(7, 130);
            this.Pnl_separacion.Name = "Pnl_separacion";
            this.Pnl_separacion.Size = new System.Drawing.Size(913, 12);
            this.Pnl_separacion.TabIndex = 12;
            // 
            // Pic_Banrural
            // 
            this.Pic_Banrural.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Banrural.Image")));
            this.Pic_Banrural.Location = new System.Drawing.Point(28, 12);
            this.Pic_Banrural.Name = "Pic_Banrural";
            this.Pic_Banrural.Size = new System.Drawing.Size(220, 100);
            this.Pic_Banrural.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Banrural.TabIndex = 11;
            this.Pic_Banrural.TabStop = false;
            // 
            // Btn_BuscarDpi
            // 
            this.Btn_BuscarDpi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BuscarDpi.Image = ((System.Drawing.Image)(resources.GetObject("Btn_BuscarDpi.Image")));
            this.Btn_BuscarDpi.Location = new System.Drawing.Point(446, 154);
            this.Btn_BuscarDpi.Name = "Btn_BuscarDpi";
            this.Btn_BuscarDpi.Size = new System.Drawing.Size(60, 51);
            this.Btn_BuscarDpi.TabIndex = 28;
            this.Btn_BuscarDpi.UseVisualStyleBackColor = true;
            this.Btn_BuscarDpi.Click += new System.EventHandler(this.Btn_BuscarDpi_Click);
            // 
            // Dgv_Boletas
            // 
            this.Dgv_Boletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Boletas.Location = new System.Drawing.Point(16, 339);
            this.Dgv_Boletas.Name = "Dgv_Boletas";
            this.Dgv_Boletas.RowHeadersWidth = 51;
            this.Dgv_Boletas.RowTemplate.Height = 24;
            this.Dgv_Boletas.Size = new System.Drawing.Size(904, 402);
            this.Dgv_Boletas.TabIndex = 29;
            this.Dgv_Boletas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Boletas_CellContentClick);
            // 
            // Txt_Apellidos
            // 
            this.Txt_Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Apellidos.Enabled = false;
            this.Txt_Apellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellidos.Location = new System.Drawing.Point(121, 277);
            this.Txt_Apellidos.Name = "Txt_Apellidos";
            this.Txt_Apellidos.Size = new System.Drawing.Size(567, 27);
            this.Txt_Apellidos.TabIndex = 33;
            this.Txt_Apellidos.TextChanged += new System.EventHandler(this.Txt_Apellidos_TextChanged);
            // 
            // Lbl_Apellidos
            // 
            this.Lbl_Apellidos.AutoSize = true;
            this.Lbl_Apellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Apellidos.Location = new System.Drawing.Point(13, 279);
            this.Lbl_Apellidos.Name = "Lbl_Apellidos";
            this.Lbl_Apellidos.Size = new System.Drawing.Size(89, 20);
            this.Lbl_Apellidos.TabIndex = 32;
            this.Lbl_Apellidos.Text = "Apellidos:";
            this.Lbl_Apellidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_Nombres
            // 
            this.Txt_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Nombres.Enabled = false;
            this.Txt_Nombres.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombres.Location = new System.Drawing.Point(121, 234);
            this.Txt_Nombres.Name = "Txt_Nombres";
            this.Txt_Nombres.Size = new System.Drawing.Size(567, 27);
            this.Txt_Nombres.TabIndex = 31;
            this.Txt_Nombres.TextChanged += new System.EventHandler(this.Txt_Nombres_TextChanged);
            // 
            // Lbl_Nombres
            // 
            this.Lbl_Nombres.AutoSize = true;
            this.Lbl_Nombres.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombres.Location = new System.Drawing.Point(13, 236);
            this.Lbl_Nombres.Name = "Lbl_Nombres";
            this.Lbl_Nombres.Size = new System.Drawing.Size(86, 20);
            this.Lbl_Nombres.TabIndex = 30;
            this.Lbl_Nombres.Text = "Nombres:";
            this.Lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_LimpiarTodo
            // 
            this.Btn_LimpiarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LimpiarTodo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_LimpiarTodo.Image")));
            this.Btn_LimpiarTodo.Location = new System.Drawing.Point(512, 154);
            this.Btn_LimpiarTodo.Name = "Btn_LimpiarTodo";
            this.Btn_LimpiarTodo.Size = new System.Drawing.Size(60, 51);
            this.Btn_LimpiarTodo.TabIndex = 34;
            this.Btn_LimpiarTodo.UseVisualStyleBackColor = true;
            // 
            // Btn_EliminarBoleta
            // 
            this.Btn_EliminarBoleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_EliminarBoleta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EliminarBoleta.Image")));
            this.Btn_EliminarBoleta.Location = new System.Drawing.Point(860, 282);
            this.Btn_EliminarBoleta.Name = "Btn_EliminarBoleta";
            this.Btn_EliminarBoleta.Size = new System.Drawing.Size(60, 51);
            this.Btn_EliminarBoleta.TabIndex = 35;
            this.Btn_EliminarBoleta.UseVisualStyleBackColor = true;
            this.Btn_EliminarBoleta.Click += new System.EventHandler(this.Btn_EliminarBoleta_Click);
            // 
            // Btn_ModificarBoleta
            // 
            this.Btn_ModificarBoleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ModificarBoleta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ModificarBoleta.Image")));
            this.Btn_ModificarBoleta.Location = new System.Drawing.Point(794, 282);
            this.Btn_ModificarBoleta.Name = "Btn_ModificarBoleta";
            this.Btn_ModificarBoleta.Size = new System.Drawing.Size(60, 51);
            this.Btn_ModificarBoleta.TabIndex = 36;
            this.Btn_ModificarBoleta.UseVisualStyleBackColor = true;
            this.Btn_ModificarBoleta.Click += new System.EventHandler(this.Btn_ModificarBoleta_Click);
            // 
            // Frm_BuscarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.Btn_ModificarBoleta);
            this.Controls.Add(this.Btn_EliminarBoleta);
            this.Controls.Add(this.Btn_LimpiarTodo);
            this.Controls.Add(this.Txt_Apellidos);
            this.Controls.Add(this.Lbl_Apellidos);
            this.Controls.Add(this.Txt_Nombres);
            this.Controls.Add(this.Lbl_Nombres);
            this.Controls.Add(this.Dgv_Boletas);
            this.Controls.Add(this.Btn_BuscarDpi);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Lbl_BuscarBoleta);
            this.Controls.Add(this.Lbl_Banrural);
            this.Controls.Add(this.Pnl_separacion);
            this.Controls.Add(this.Pic_Banrural);
            this.Controls.Add(this.Txt_Dpi);
            this.Controls.Add(this.Lbl_Dpi);
            this.Name = "Frm_BuscarBoleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BuscarBoleta";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Banrural)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Boletas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Dpi;
        private System.Windows.Forms.Label Lbl_Dpi;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Label Lbl_BuscarBoleta;
        private System.Windows.Forms.Label Lbl_Banrural;
        private System.Windows.Forms.Panel Pnl_separacion;
        private System.Windows.Forms.PictureBox Pic_Banrural;
        private System.Windows.Forms.Button Btn_BuscarDpi;
        private System.Windows.Forms.DataGridView Dgv_Boletas;
        private System.Windows.Forms.TextBox Txt_Apellidos;
        private System.Windows.Forms.Label Lbl_Apellidos;
        private System.Windows.Forms.TextBox Txt_Nombres;
        private System.Windows.Forms.Label Lbl_Nombres;
        private System.Windows.Forms.Button Btn_LimpiarTodo;
        private System.Windows.Forms.Button Btn_EliminarBoleta;
        private System.Windows.Forms.Button Btn_ModificarBoleta;
    }
}