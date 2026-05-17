namespace Capa_Vista_CXP
{
    partial class Frm_Visor_Reportes
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
            this.Crv_reporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Crv_reporte
            // 
            this.Crv_reporte.ActiveViewIndex = -1;
            this.Crv_reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Crv_reporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.Crv_reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Crv_reporte.Location = new System.Drawing.Point(0, 0);
            this.Crv_reporte.Name = "Crv_reporte";
            this.Crv_reporte.Size = new System.Drawing.Size(800, 450);
            this.Crv_reporte.TabIndex = 0;
            // 
            // Frm_Visor_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Crv_reporte);
            this.Name = "Frm_Visor_Reportes";
            this.Text = "Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Crv_reporte;
    }
}