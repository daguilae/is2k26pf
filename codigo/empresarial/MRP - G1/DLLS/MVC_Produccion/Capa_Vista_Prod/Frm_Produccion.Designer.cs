
namespace Capa_Vista_Prod
{
    partial class Frm_Produccion
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_Costos = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tbc_Produccion = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Lbl_Orden = new System.Windows.Forms.Label();
            this.Cbo_Orden = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Lbl_Costos);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(13, 13);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1074, 515);
            this.panel4.TabIndex = 7;
            // 
            // Lbl_Costos
            // 
            this.Lbl_Costos.AutoSize = true;
            this.Lbl_Costos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Costos.Location = new System.Drawing.Point(23, 14);
            this.Lbl_Costos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Costos.Name = "Lbl_Costos";
            this.Lbl_Costos.Size = new System.Drawing.Size(336, 38);
            this.Lbl_Costos.TabIndex = 11;
            this.Lbl_Costos.Text = "Costos de Producción";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 53);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1013, 14);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tbc_Produccion);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(42, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 345);
            this.tabControl1.TabIndex = 8;
            // 
            // Tbc_Produccion
            // 
            this.Tbc_Produccion.Location = new System.Drawing.Point(4, 25);
            this.Tbc_Produccion.Name = "Tbc_Produccion";
            this.Tbc_Produccion.Padding = new System.Windows.Forms.Padding(3);
            this.Tbc_Produccion.Size = new System.Drawing.Size(1005, 316);
            this.Tbc_Produccion.TabIndex = 0;
            this.Tbc_Produccion.Text = "Mano de Obra";
            this.Tbc_Produccion.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Costos Indirectos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Lbl_Orden
            // 
            this.Lbl_Orden.AutoSize = true;
            this.Lbl_Orden.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden.Location = new System.Drawing.Point(42, 111);
            this.Lbl_Orden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Orden.Name = "Lbl_Orden";
            this.Lbl_Orden.Size = new System.Drawing.Size(105, 22);
            this.Lbl_Orden.TabIndex = 18;
            this.Lbl_Orden.Text = "Orden No:";
            // 
            // Cbo_Orden
            // 
            this.Cbo_Orden.FormattingEnabled = true;
            this.Cbo_Orden.Location = new System.Drawing.Point(154, 111);
            this.Cbo_Orden.Name = "Cbo_Orden";
            this.Cbo_Orden.Size = new System.Drawing.Size(179, 24);
            this.Cbo_Orden.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1066, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mermas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Frm_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 541);
            this.Controls.Add(this.Cbo_Orden);
            this.Controls.Add(this.Lbl_Orden);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.Name = "Frm_Produccion";
            this.Text = "Frm_Produccion";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_Costos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tbc_Produccion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Lbl_Orden;
        private System.Windows.Forms.ComboBox Cbo_Orden;
    }
}