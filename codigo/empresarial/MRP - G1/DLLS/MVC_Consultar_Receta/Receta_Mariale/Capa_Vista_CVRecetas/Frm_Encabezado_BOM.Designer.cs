
namespace Capa_Vista_CVRecetas
{
    partial class Frm_Encabezado_BOM
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dg_BOM = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Desde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_listado = new System.Windows.Forms.Label();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cmb_Id = new System.Windows.Forms.ComboBox();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_BOM)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-227, -32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1016, 10);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // Dg_BOM
            // 
            this.Dg_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_BOM.Location = new System.Drawing.Point(17, 134);
            this.Dg_BOM.Name = "Dg_BOM";
            this.Dg_BOM.RowHeadersWidth = 51;
            this.Dg_BOM.Size = new System.Drawing.Size(1262, 391);
            this.Dg_BOM.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(895, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Desde: ";
            // 
            // Dtp_Hasta
            // 
            this.Dtp_Hasta.Location = new System.Drawing.Point(967, 88);
            this.Dtp_Hasta.Name = "Dtp_Hasta";
            this.Dtp_Hasta.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Hasta.TabIndex = 18;
            // 
            // Dtp_Desde
            // 
            this.Dtp_Desde.Location = new System.Drawing.Point(679, 88);
            this.Dtp_Desde.Name = "Dtp_Desde";
            this.Dtp_Desde.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Desde.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(-226, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 20);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "Buscar por ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-232, -64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Listado de Ordenes Recibidas";
            // 
            // Btn_crear
            // 
            this.Btn_crear.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.Location = new System.Drawing.Point(1177, 84);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(140, 24);
            this.Btn_crear.TabIndex = 26;
            this.Btn_crear.Text = "Crear Nueva Receta";
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 41);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1257, 10);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // Lbl_listado
            // 
            this.Lbl_listado.AutoSize = true;
            this.Lbl_listado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listado.Location = new System.Drawing.Point(12, 9);
            this.Lbl_listado.Name = "Lbl_listado";
            this.Lbl_listado.Size = new System.Drawing.Size(340, 29);
            this.Lbl_listado.TabIndex = 24;
            this.Lbl_listado.Text = "Listado de Recetas Creadas";
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(370, 87);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Estado.TabIndex = 29;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(290, 83);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(81, 23);
            this.Lbl_Estado.TabIndex = 28;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Cmb_Id
            // 
            this.Cmb_Id.FormattingEnabled = true;
            this.Cmb_Id.Location = new System.Drawing.Point(132, 89);
            this.Cmb_Id.Name = "Cmb_Id";
            this.Cmb_Id.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Id.TabIndex = 30;
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id.Location = new System.Drawing.Point(6, 89);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(100, 23);
            this.Lbl_id.TabIndex = 31;
            this.Lbl_id.Text = "Buscar Id";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Image = global::Capa_Vista_CVRecetas.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1285, 220);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 59);
            this.Btn_Limpiar.TabIndex = 32;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Frm_Encabezado_BOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 571);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Lbl_id);
            this.Controls.Add(this.Cmb_Id);
            this.Controls.Add(this.Cmb_Estado);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Lbl_listado);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Dg_BOM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dtp_Hasta);
            this.Controls.Add(this.Dtp_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Encabezado_BOM";
            this.Text = "Encabezado_BOM";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_BOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView Dg_BOM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_Hasta;
        private System.Windows.Forms.DateTimePicker Dtp_Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Lbl_listado;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.ComboBox Cmb_Id;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}