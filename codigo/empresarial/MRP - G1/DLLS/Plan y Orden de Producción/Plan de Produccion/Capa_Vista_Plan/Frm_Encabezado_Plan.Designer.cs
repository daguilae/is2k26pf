
namespace Capa_Vista_Plan
{
    partial class Frm_Encabezado_Plan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Encabezado_Plan));
            this.Lbl_listado_plan = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Cbo_ID_Plan = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cbo_Estado_Plan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_Desde_plan = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Dtp_Hasta_plan = new System.Windows.Forms.DateTimePicker();
            this.Btn_crear_plan = new System.Windows.Forms.Button();
            this.Dgv_BOM = new System.Windows.Forms.DataGridView();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BOM)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_listado_plan
            // 
            this.Lbl_listado_plan.AutoSize = true;
            this.Lbl_listado_plan.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listado_plan.Location = new System.Drawing.Point(16, 11);
            this.Lbl_listado_plan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_listado_plan.Name = "Lbl_listado_plan";
            this.Lbl_listado_plan.Size = new System.Drawing.Size(627, 38);
            this.Lbl_listado_plan.TabIndex = 25;
            this.Lbl_listado_plan.Text = "Listado de Planes de Producción Creados";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(23, 50);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1508, 12);
            this.flowLayoutPanel2.TabIndex = 26;
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id.Location = new System.Drawing.Point(18, 91);
            this.Lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(135, 29);
            this.Lbl_id.TabIndex = 32;
            this.Lbl_id.Text = "Buscar Id:";
            // 
            // Cbo_ID_Plan
            // 
            this.Cbo_ID_Plan.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_ID_Plan.FormattingEnabled = true;
            this.Cbo_ID_Plan.Location = new System.Drawing.Point(160, 91);
            this.Cbo_ID_Plan.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_ID_Plan.Name = "Cbo_ID_Plan";
            this.Cbo_ID_Plan.Size = new System.Drawing.Size(181, 28);
            this.Cbo_ID_Plan.TabIndex = 33;
            this.Cbo_ID_Plan.SelectedIndexChanged += new System.EventHandler(this.Cbo_ID_Plan_SelectedIndexChanged);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(354, 90);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(101, 29);
            this.Lbl_Estado.TabIndex = 34;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Cbo_Estado_Plan
            // 
            this.Cbo_Estado_Plan.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Estado_Plan.FormattingEnabled = true;
            this.Cbo_Estado_Plan.Location = new System.Drawing.Point(463, 92);
            this.Cbo_Estado_Plan.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Estado_Plan.Name = "Cbo_Estado_Plan";
            this.Cbo_Estado_Plan.Size = new System.Drawing.Size(237, 28);
            this.Cbo_Estado_Plan.TabIndex = 35;
            this.Cbo_Estado_Plan.SelectedIndexChanged += new System.EventHandler(this.Cbo_Estado_Plan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(708, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha Desde:";
            // 
            // Dtp_Desde_plan
            // 
            this.Dtp_Desde_plan.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Desde_plan.Location = new System.Drawing.Point(891, 96);
            this.Dtp_Desde_plan.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Desde_plan.Name = "Dtp_Desde_plan";
            this.Dtp_Desde_plan.Size = new System.Drawing.Size(265, 23);
            this.Dtp_Desde_plan.TabIndex = 38;
            this.Dtp_Desde_plan.ValueChanged += new System.EventHandler(this.Dtp_Desde_plan_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1170, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Hasta:";
            // 
            // Dtp_Hasta_plan
            // 
            this.Dtp_Hasta_plan.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Hasta_plan.Location = new System.Drawing.Point(1266, 94);
            this.Dtp_Hasta_plan.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Hasta_plan.Name = "Dtp_Hasta_plan";
            this.Dtp_Hasta_plan.Size = new System.Drawing.Size(265, 23);
            this.Dtp_Hasta_plan.TabIndex = 40;
            this.Dtp_Hasta_plan.ValueChanged += new System.EventHandler(this.Dtp_Hasta_plan_ValueChanged);
            // 
            // Btn_crear_plan
            // 
            this.Btn_crear_plan.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear_plan.Location = new System.Drawing.Point(1344, 14);
            this.Btn_crear_plan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_crear_plan.Name = "Btn_crear_plan";
            this.Btn_crear_plan.Size = new System.Drawing.Size(187, 30);
            this.Btn_crear_plan.TabIndex = 41;
            this.Btn_crear_plan.Text = "Crear Nuevo Plan";
            this.Btn_crear_plan.UseVisualStyleBackColor = true;
            this.Btn_crear_plan.Click += new System.EventHandler(this.Btn_crear_plan_Click);
            // 
            // Dgv_BOM
            // 
            this.Dgv_BOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_BOM.Location = new System.Drawing.Point(23, 204);
            this.Dgv_BOM.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_BOM.Name = "Dgv_BOM";
            this.Dgv_BOM.RowHeadersWidth = 51;
            this.Dgv_BOM.Size = new System.Drawing.Size(1508, 540);
            this.Dgv_BOM.TabIndex = 43;
            this.Dgv_BOM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_BOM_CellContentClick);
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.Image")));
            this.Btn_refrescar.Location = new System.Drawing.Point(1474, 147);
            this.Btn_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(57, 49);
            this.Btn_refrescar.TabIndex = 44;
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            this.Btn_refrescar.Click += new System.EventHandler(this.Btn_refrescar_Click);
            // 
            // Frm_Encabezado_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 800);
            this.Controls.Add(this.Btn_refrescar);
            this.Controls.Add(this.Dgv_BOM);
            this.Controls.Add(this.Btn_crear_plan);
            this.Controls.Add(this.Dtp_Hasta_plan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dtp_Desde_plan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbo_Estado_Plan);
            this.Controls.Add(this.Lbl_Estado);
            this.Controls.Add(this.Cbo_ID_Plan);
            this.Controls.Add(this.Lbl_id);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Lbl_listado_plan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Encabezado_Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Planes de Producción";
            this.Load += new System.EventHandler(this.Frm_Encabezado_Plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_BOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_listado_plan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.ComboBox Cbo_ID_Plan;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.ComboBox Cbo_Estado_Plan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_Desde_plan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dtp_Hasta_plan;
        private System.Windows.Forms.Button Btn_crear_plan;
        private System.Windows.Forms.DataGridView Dgv_BOM;
        private System.Windows.Forms.Button Btn_refrescar;
    }
}