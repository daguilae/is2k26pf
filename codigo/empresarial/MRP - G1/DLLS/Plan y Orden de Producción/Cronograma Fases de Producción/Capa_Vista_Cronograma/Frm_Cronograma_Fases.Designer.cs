
namespace Capa_Vista_Cronograma
{
    partial class Frm_Cronograma_Fases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cronograma_Fases));
            this.Lbl_Titulo_Cronograma = new System.Windows.Forms.Label();
            this.Gpb_Datos_Orden = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_NoOrden = new System.Windows.Forms.ComboBox();
            this.Lbl_NoOrden = new System.Windows.Forms.Label();
            this.Dgv_Cronograma = new System.Windows.Forms.DataGridView();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Txt_Producto = new System.Windows.Forms.TextBox();
            this.Txt_FechaInicio = new System.Windows.Forms.TextBox();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_FechaFin = new System.Windows.Forms.TextBox();
            this.Lbl_FechaFin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Gpb_Datos_Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cronograma)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo_Cronograma
            // 
            this.Lbl_Titulo_Cronograma.AutoSize = true;
            this.Lbl_Titulo_Cronograma.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo_Cronograma.Location = new System.Drawing.Point(344, 9);
            this.Lbl_Titulo_Cronograma.Name = "Lbl_Titulo_Cronograma";
            this.Lbl_Titulo_Cronograma.Size = new System.Drawing.Size(514, 38);
            this.Lbl_Titulo_Cronograma.TabIndex = 0;
            this.Lbl_Titulo_Cronograma.Text = "Cronograma Fases de Producción";
            // 
            // Gpb_Datos_Orden
            // 
            this.Gpb_Datos_Orden.Controls.Add(this.Txt_FechaFin);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_FechaFin);
            this.Gpb_Datos_Orden.Controls.Add(this.label6);
            this.Gpb_Datos_Orden.Controls.Add(this.Txt_FechaInicio);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_FechaInicio);
            this.Gpb_Datos_Orden.Controls.Add(this.label4);
            this.Gpb_Datos_Orden.Controls.Add(this.Txt_Producto);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_Producto);
            this.Gpb_Datos_Orden.Controls.Add(this.label2);
            this.Gpb_Datos_Orden.Controls.Add(this.Cbo_NoOrden);
            this.Gpb_Datos_Orden.Controls.Add(this.Lbl_NoOrden);
            this.Gpb_Datos_Orden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Datos_Orden.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Gpb_Datos_Orden.Location = new System.Drawing.Point(20, 113);
            this.Gpb_Datos_Orden.Name = "Gpb_Datos_Orden";
            this.Gpb_Datos_Orden.Size = new System.Drawing.Size(315, 362);
            this.Gpb_Datos_Orden.TabIndex = 1;
            this.Gpb_Datos_Orden.TabStop = false;
            this.Gpb_Datos_Orden.Text = "Datos Orden de Producción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // Cbo_NoOrden
            // 
            this.Cbo_NoOrden.FormattingEnabled = true;
            this.Cbo_NoOrden.Location = new System.Drawing.Point(16, 62);
            this.Cbo_NoOrden.Name = "Cbo_NoOrden";
            this.Cbo_NoOrden.Size = new System.Drawing.Size(263, 28);
            this.Cbo_NoOrden.TabIndex = 1;
            // 
            // Lbl_NoOrden
            // 
            this.Lbl_NoOrden.AutoSize = true;
            this.Lbl_NoOrden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoOrden.Location = new System.Drawing.Point(12, 39);
            this.Lbl_NoOrden.Name = "Lbl_NoOrden";
            this.Lbl_NoOrden.Size = new System.Drawing.Size(228, 20);
            this.Lbl_NoOrden.TabIndex = 0;
            this.Lbl_NoOrden.Text = "Selecciona el No. de Orden ";
            // 
            // Dgv_Cronograma
            // 
            this.Dgv_Cronograma.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Cronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cronograma.Location = new System.Drawing.Point(351, 123);
            this.Dgv_Cronograma.Name = "Dgv_Cronograma";
            this.Dgv_Cronograma.RowHeadersWidth = 51;
            this.Dgv_Cronograma.RowTemplate.Height = 24;
            this.Dgv_Cronograma.Size = new System.Drawing.Size(770, 352);
            this.Dgv_Cronograma.TabIndex = 2;
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto.Location = new System.Drawing.Point(12, 109);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Producto.TabIndex = 3;
            this.Lbl_Producto.Text = "Producto";
            // 
            // Txt_Producto
            // 
            this.Txt_Producto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_Producto.Location = new System.Drawing.Point(16, 140);
            this.Txt_Producto.Name = "Txt_Producto";
            this.Txt_Producto.ReadOnly = true;
            this.Txt_Producto.Size = new System.Drawing.Size(263, 27);
            this.Txt_Producto.TabIndex = 4;
            // 
            // Txt_FechaInicio
            // 
            this.Txt_FechaInicio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_FechaInicio.Location = new System.Drawing.Point(16, 223);
            this.Txt_FechaInicio.Name = "Txt_FechaInicio";
            this.Txt_FechaInicio.ReadOnly = true;
            this.Txt_FechaInicio.Size = new System.Drawing.Size(263, 27);
            this.Txt_FechaInicio.TabIndex = 7;
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(12, 192);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(222, 20);
            this.Lbl_FechaInicio.TabIndex = 6;
            this.Lbl_FechaInicio.Text = "Fecha Inicio de Producción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // Txt_FechaFin
            // 
            this.Txt_FechaFin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_FechaFin.Location = new System.Drawing.Point(16, 302);
            this.Txt_FechaFin.Name = "Txt_FechaFin";
            this.Txt_FechaFin.ReadOnly = true;
            this.Txt_FechaFin.Size = new System.Drawing.Size(263, 27);
            this.Txt_FechaFin.TabIndex = 10;
            // 
            // Lbl_FechaFin
            // 
            this.Lbl_FechaFin.AutoSize = true;
            this.Lbl_FechaFin.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaFin.Location = new System.Drawing.Point(12, 271);
            this.Lbl_FechaFin.Name = "Lbl_FechaFin";
            this.Lbl_FechaFin.Size = new System.Drawing.Size(216, 20);
            this.Lbl_FechaFin.TabIndex = 9;
            this.Lbl_FechaFin.Text = "Fecha Final de Producción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1003, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 46);
            this.button2.TabIndex = 171;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(944, 72);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 46);
            this.button3.TabIndex = 170;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(890, 72);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(48, 46);
            this.Btn_Eliminar.TabIndex = 169;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(831, 73);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Modificar.TabIndex = 168;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("Rockwell", 10F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(769, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 46);
            this.button4.TabIndex = 172;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("Rockwell", 10F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1065, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 46);
            this.button5.TabIndex = 173;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Frm_Cronograma_Fases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 569);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Dgv_Cronograma);
            this.Controls.Add(this.Gpb_Datos_Orden);
            this.Controls.Add(this.Lbl_Titulo_Cronograma);
            this.Name = "Frm_Cronograma_Fases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronograma Fases de Producción";
            this.Load += new System.EventHandler(this.Frm_Cronograma_Fases_Load);
            this.Gpb_Datos_Orden.ResumeLayout(false);
            this.Gpb_Datos_Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cronograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo_Cronograma;
        private System.Windows.Forms.GroupBox Gpb_Datos_Orden;
        private System.Windows.Forms.DataGridView Dgv_Cronograma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_NoOrden;
        private System.Windows.Forms.Label Lbl_NoOrden;
        private System.Windows.Forms.TextBox Txt_FechaFin;
        private System.Windows.Forms.Label Lbl_FechaFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_FechaInicio;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Producto;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}