
namespace Capa_vista_Orden
{
    partial class Frm_Orden_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Orden_Produccion));
            this.Lbl_Orden_Produccion = new System.Windows.Forms.Label();
            this.Gpb_Orden = new System.Windows.Forms.GroupBox();
            this.Cbo_Material = new System.Windows.Forms.ComboBox();
            this.Lbl_Material = new System.Windows.Forms.Label();
            this.Cbo_Plan_Produccion = new System.Windows.Forms.ComboBox();
            this.Lbl_Plan_Produccion = new System.Windows.Forms.Label();
            this.Lbl_Id_Orden_Produccion = new System.Windows.Forms.Label();
            this.Dgv_Orden_Produccion = new System.Windows.Forms.DataGridView();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Txt_Id_Orden_Produccion = new System.Windows.Forms.TextBox();
            this.Lbl_Cantidad_Programada = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Programada = new System.Windows.Forms.TextBox();
            this.Lbl_Inicio = new System.Windows.Forms.Label();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fin = new System.Windows.Forms.Label();
            this.Dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Gpb_Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Orden_Produccion)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Orden_Produccion
            // 
            this.Lbl_Orden_Produccion.AutoSize = true;
            this.Lbl_Orden_Produccion.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Produccion.Location = new System.Drawing.Point(366, 9);
            this.Lbl_Orden_Produccion.Name = "Lbl_Orden_Produccion";
            this.Lbl_Orden_Produccion.Size = new System.Drawing.Size(332, 38);
            this.Lbl_Orden_Produccion.TabIndex = 0;
            this.Lbl_Orden_Produccion.Text = "Orden de Producción";
            this.Lbl_Orden_Produccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gpb_Orden
            // 
            this.Gpb_Orden.Controls.Add(this.Dtp_Fin);
            this.Gpb_Orden.Controls.Add(this.Lbl_Fin);
            this.Gpb_Orden.Controls.Add(this.Dtp_Inicio);
            this.Gpb_Orden.Controls.Add(this.Lbl_Inicio);
            this.Gpb_Orden.Controls.Add(this.Txt_Cantidad_Programada);
            this.Gpb_Orden.Controls.Add(this.Lbl_Cantidad_Programada);
            this.Gpb_Orden.Controls.Add(this.Txt_Id_Orden_Produccion);
            this.Gpb_Orden.Controls.Add(this.Cbo_Estado);
            this.Gpb_Orden.Controls.Add(this.Lbl_Estado);
            this.Gpb_Orden.Controls.Add(this.Cbo_Material);
            this.Gpb_Orden.Controls.Add(this.Lbl_Material);
            this.Gpb_Orden.Controls.Add(this.Cbo_Plan_Produccion);
            this.Gpb_Orden.Controls.Add(this.Lbl_Plan_Produccion);
            this.Gpb_Orden.Controls.Add(this.Lbl_Id_Orden_Produccion);
            this.Gpb_Orden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Orden.Location = new System.Drawing.Point(19, 72);
            this.Gpb_Orden.Name = "Gpb_Orden";
            this.Gpb_Orden.Size = new System.Drawing.Size(312, 549);
            this.Gpb_Orden.TabIndex = 1;
            this.Gpb_Orden.TabStop = false;
            this.Gpb_Orden.Text = "Datos Orden de Produccion";
            // 
            // Cbo_Material
            // 
            this.Cbo_Material.FormattingEnabled = true;
            this.Cbo_Material.Location = new System.Drawing.Point(10, 205);
            this.Cbo_Material.Name = "Cbo_Material";
            this.Cbo_Material.Size = new System.Drawing.Size(247, 28);
            this.Cbo_Material.TabIndex = 5;
            // 
            // Lbl_Material
            // 
            this.Lbl_Material.AutoSize = true;
            this.Lbl_Material.Location = new System.Drawing.Point(6, 182);
            this.Lbl_Material.Name = "Lbl_Material";
            this.Lbl_Material.Size = new System.Drawing.Size(74, 20);
            this.Lbl_Material.TabIndex = 4;
            this.Lbl_Material.Text = "Material";
            // 
            // Cbo_Plan_Produccion
            // 
            this.Cbo_Plan_Produccion.FormattingEnabled = true;
            this.Cbo_Plan_Produccion.Location = new System.Drawing.Point(10, 131);
            this.Cbo_Plan_Produccion.Name = "Cbo_Plan_Produccion";
            this.Cbo_Plan_Produccion.Size = new System.Drawing.Size(247, 28);
            this.Cbo_Plan_Produccion.TabIndex = 3;
            // 
            // Lbl_Plan_Produccion
            // 
            this.Lbl_Plan_Produccion.AutoSize = true;
            this.Lbl_Plan_Produccion.Location = new System.Drawing.Point(6, 108);
            this.Lbl_Plan_Produccion.Name = "Lbl_Plan_Produccion";
            this.Lbl_Plan_Produccion.Size = new System.Drawing.Size(161, 20);
            this.Lbl_Plan_Produccion.TabIndex = 2;
            this.Lbl_Plan_Produccion.Text = "Plan de Produccion";
            // 
            // Lbl_Id_Orden_Produccion
            // 
            this.Lbl_Id_Orden_Produccion.AutoSize = true;
            this.Lbl_Id_Orden_Produccion.Location = new System.Drawing.Point(6, 36);
            this.Lbl_Id_Orden_Produccion.Name = "Lbl_Id_Orden_Produccion";
            this.Lbl_Id_Orden_Produccion.Size = new System.Drawing.Size(175, 20);
            this.Lbl_Id_Orden_Produccion.TabIndex = 0;
            this.Lbl_Id_Orden_Produccion.Text = "ID Orden Produccion";
            // 
            // Dgv_Orden_Produccion
            // 
            this.Dgv_Orden_Produccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Orden_Produccion.Location = new System.Drawing.Point(360, 180);
            this.Dgv_Orden_Produccion.Name = "Dgv_Orden_Produccion";
            this.Dgv_Orden_Produccion.RowHeadersWidth = 51;
            this.Dgv_Orden_Produccion.RowTemplate.Height = 24;
            this.Dgv_Orden_Produccion.Size = new System.Drawing.Size(702, 307);
            this.Dgv_Orden_Produccion.TabIndex = 2;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(6, 251);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(211, 20);
            this.Lbl_Estado.TabIndex = 6;
            this.Lbl_Estado.Text = "Estado Orden Produccion";
            this.Lbl_Estado.Click += new System.EventHandler(this.label5_Click);
            // 
            // Txt_Id_Orden_Produccion
            // 
            this.Txt_Id_Orden_Produccion.Location = new System.Drawing.Point(10, 59);
            this.Txt_Id_Orden_Produccion.Name = "Txt_Id_Orden_Produccion";
            this.Txt_Id_Orden_Produccion.Size = new System.Drawing.Size(247, 27);
            this.Txt_Id_Orden_Produccion.TabIndex = 8;
            // 
            // Lbl_Cantidad_Programada
            // 
            this.Lbl_Cantidad_Programada.AutoSize = true;
            this.Lbl_Cantidad_Programada.Location = new System.Drawing.Point(6, 324);
            this.Lbl_Cantidad_Programada.Name = "Lbl_Cantidad_Programada";
            this.Lbl_Cantidad_Programada.Size = new System.Drawing.Size(180, 20);
            this.Lbl_Cantidad_Programada.TabIndex = 9;
            this.Lbl_Cantidad_Programada.Text = "Cantidad Programada";
            // 
            // Txt_Cantidad_Programada
            // 
            this.Txt_Cantidad_Programada.Location = new System.Drawing.Point(10, 347);
            this.Txt_Cantidad_Programada.Name = "Txt_Cantidad_Programada";
            this.Txt_Cantidad_Programada.Size = new System.Drawing.Size(247, 27);
            this.Txt_Cantidad_Programada.TabIndex = 10;
            // 
            // Lbl_Inicio
            // 
            this.Lbl_Inicio.AutoSize = true;
            this.Lbl_Inicio.Location = new System.Drawing.Point(6, 398);
            this.Lbl_Inicio.Name = "Lbl_Inicio";
            this.Lbl_Inicio.Size = new System.Drawing.Size(104, 20);
            this.Lbl_Inicio.TabIndex = 11;
            this.Lbl_Inicio.Text = "Fecha Inicio";
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.Location = new System.Drawing.Point(10, 421);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(247, 27);
            this.Dtp_Inicio.TabIndex = 12;
            // 
            // Lbl_Fin
            // 
            this.Lbl_Fin.AutoSize = true;
            this.Lbl_Fin.Location = new System.Drawing.Point(6, 464);
            this.Lbl_Fin.Name = "Lbl_Fin";
            this.Lbl_Fin.Size = new System.Drawing.Size(84, 20);
            this.Lbl_Fin.TabIndex = 13;
            this.Lbl_Fin.Text = "Fecha Fin";
            // 
            // Dtp_Fin
            // 
            this.Dtp_Fin.Location = new System.Drawing.Point(10, 500);
            this.Dtp_Fin.Name = "Dtp_Fin";
            this.Dtp_Fin.Size = new System.Drawing.Size(247, 27);
            this.Dtp_Fin.TabIndex = 14;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(10, 274);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(247, 28);
            this.Cbo_Estado.TabIndex = 7;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.White;
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(943, 84);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(56, 46);
            this.Btn_Reporte.TabIndex = 166;
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(884, 82);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Limpiar.TabIndex = 165;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(830, 84);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(48, 46);
            this.Btn_Eliminar.TabIndex = 164;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(771, 82);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Modificar.TabIndex = 163;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.White;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(712, 82);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 46);
            this.Btn_guardar.TabIndex = 162;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.White;
            this.Btn_Ayuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Ayuda.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_Ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(1005, 83);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(56, 46);
            this.Btn_Ayuda.TabIndex = 167;
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // Frm_Orden_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 642);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Dgv_Orden_Produccion);
            this.Controls.Add(this.Gpb_Orden);
            this.Controls.Add(this.Lbl_Orden_Produccion);
            this.Name = "Frm_Orden_Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Produccion";
            this.Load += new System.EventHandler(this.Frm_Orden_Produccion_Load);
            this.Gpb_Orden.ResumeLayout(false);
            this.Gpb_Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Orden_Produccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Orden_Produccion;
        private System.Windows.Forms.GroupBox Gpb_Orden;
        private System.Windows.Forms.ComboBox Cbo_Material;
        private System.Windows.Forms.Label Lbl_Material;
        private System.Windows.Forms.ComboBox Cbo_Plan_Produccion;
        private System.Windows.Forms.Label Lbl_Plan_Produccion;
        private System.Windows.Forms.Label Lbl_Id_Orden_Produccion;
        private System.Windows.Forms.DataGridView Dgv_Orden_Produccion;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fin;
        private System.Windows.Forms.Label Lbl_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.Label Lbl_Inicio;
        private System.Windows.Forms.TextBox Txt_Cantidad_Programada;
        private System.Windows.Forms.Label Lbl_Cantidad_Programada;
        private System.Windows.Forms.TextBox Txt_Id_Orden_Produccion;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}