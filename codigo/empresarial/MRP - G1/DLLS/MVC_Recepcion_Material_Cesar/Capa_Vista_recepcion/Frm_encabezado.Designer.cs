
namespace Capa_Vista_recepcion
{
    partial class Frm_encabezado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_encabezado));
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Cmb_Id = new System.Windows.Forms.ComboBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_listado = new System.Windows.Forms.Label();
            this.Dg_BOM = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Noti = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_BOM)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id.Location = new System.Drawing.Point(13, 107);
            this.Lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(100, 23);
            this.Lbl_id.TabIndex = 44;
            this.Lbl_id.Text = "Buscar Id";
            // 
            // Cmb_Id
            // 
            this.Cmb_Id.FormattingEnabled = true;
            this.Cmb_Id.Location = new System.Drawing.Point(121, 109);
            this.Cmb_Id.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Id.Name = "Cmb_Id";
            this.Cmb_Id.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Id.TabIndex = 43;
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(351, 109);
            this.Cmb_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(134, 21);
            this.Cmb_Estado.TabIndex = 42;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(272, 107);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(81, 23);
            this.Lbl_Estado.TabIndex = 41;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Btn_crear
            // 
            this.Btn_crear.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.Location = new System.Drawing.Point(1224, 106);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(137, 30);
            this.Btn_crear.TabIndex = 40;
            this.Btn_crear.Text = "Crear Nueva Receta";
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 46);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1364, 12);
            this.flowLayoutPanel2.TabIndex = 39;
            // 
            // Lbl_listado
            // 
            this.Lbl_listado.AutoSize = true;
            this.Lbl_listado.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listado.Location = new System.Drawing.Point(6, 7);
            this.Lbl_listado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_listado.Name = "Lbl_listado";
            this.Lbl_listado.Size = new System.Drawing.Size(366, 29);
            this.Lbl_listado.TabIndex = 38;
            this.Lbl_listado.Text = "Listado Recepcion Materiales";
            // 
            // Dg_BOM
            // 
            this.Dg_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_BOM.Location = new System.Drawing.Point(11, 154);
            this.Dg_BOM.Margin = new System.Windows.Forms.Padding(4);
            this.Dg_BOM.Name = "Dg_BOM";
            this.Dg_BOM.RowHeadersWidth = 51;
            this.Dg_BOM.Size = new System.Drawing.Size(1289, 391);
            this.Dg_BOM.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(924, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Notificación:";
            // 
            // Dtp_Ingreso
            // 
            this.Dtp_Ingreso.Location = new System.Drawing.Point(1008, 112);
            this.Dtp_Ingreso.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Ingreso.Name = "Dtp_Ingreso";
            this.Dtp_Ingreso.Size = new System.Drawing.Size(209, 20);
            this.Dtp_Ingreso.TabIndex = 34;
            // 
            // Dtp_Noti
            // 
            this.Dtp_Noti.Location = new System.Drawing.Point(707, 112);
            this.Dtp_Noti.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Noti.Name = "Dtp_Noti";
            this.Dtp_Noti.Size = new System.Drawing.Size(210, 20);
            this.Dtp_Noti.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.Location = new System.Drawing.Point(1307, 248);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(74, 71);
            this.Btn_Limpiar.TabIndex = 45;
            this.Btn_Limpiar.Text = "Refrescar";
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Frm_encabezado
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
            this.Controls.Add(this.Dg_BOM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Dtp_Ingreso);
            this.Controls.Add(this.Dtp_Noti);
            this.Controls.Add(this.label3);
            this.Name = "Frm_encabezado";
            this.Text = "Encabezado Recepcion";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_BOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.ComboBox Cmb_Id;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Lbl_listado;
        private System.Windows.Forms.DataGridView Dg_BOM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_Ingreso;
        private System.Windows.Forms.DateTimePicker Dtp_Noti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Limpiar;
    }
}