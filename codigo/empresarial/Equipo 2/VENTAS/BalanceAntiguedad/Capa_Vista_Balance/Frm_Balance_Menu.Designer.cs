
namespace Capa_Vista_Balance
{
    partial class Frm_Balance_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Balance_Menu));
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Final = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Final = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.Location = new System.Drawing.Point(17, 78);
            this.Dtp_Inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(188, 20);
            this.Dtp_Inicio.TabIndex = 0;
            // 
            // Dtp_Final
            // 
            this.Dtp_Final.Location = new System.Drawing.Point(244, 78);
            this.Dtp_Final.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_Final.Name = "Dtp_Final";
            this.Dtp_Final.Size = new System.Drawing.Size(188, 20);
            this.Dtp_Final.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(54, 42);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(97, 16);
            this.Lbl_Fecha_Inicio.TabIndex = 63;
            this.Lbl_Fecha_Inicio.Text = "Fecha de inicio ";
            // 
            // Lbl_Fecha_Final
            // 
            this.Lbl_Fecha_Final.AutoSize = true;
            this.Lbl_Fecha_Final.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Final.Location = new System.Drawing.Point(292, 42);
            this.Lbl_Fecha_Final.Name = "Lbl_Fecha_Final";
            this.Lbl_Fecha_Final.Size = new System.Drawing.Size(73, 16);
            this.Lbl_Fecha_Final.TabIndex = 64;
            this.Lbl_Fecha_Final.Text = "Fecha final ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Reporte);
            this.groupBox1.Controls.Add(this.Lbl_Fecha_Inicio);
            this.groupBox1.Controls.Add(this.Lbl_Fecha_Final);
            this.groupBox1.Controls.Add(this.Dtp_Final);
            this.groupBox1.Controls.Add(this.Dtp_Inicio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1119, 131);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(457, 27);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(74, 83);
            this.Btn_Reporte.TabIndex = 67;
            this.Btn_Reporte.Text = "Imprimir";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 131);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1119, 518);
            this.crystalReportViewer1.TabIndex = 67;
            this.crystalReportViewer1.ToolPanelWidth = 367;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Frm_Balance_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 649);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Balance_Menu";
            this.Text = "Frm_Balance_Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.DateTimePicker Dtp_Final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Fecha_Final;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Reporte;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}