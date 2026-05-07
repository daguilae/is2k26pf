
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
            this.tab_Produccion = new System.Windows.Forms.TabPage();
            this.tabCostos = new System.Windows.Forms.TabPage();
            this.tabMerma = new System.Windows.Forms.TabPage();
            this.Lbl_Orden = new System.Windows.Forms.Label();
            this.Cbo_Orden = new System.Windows.Forms.ComboBox();
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Controls.Add(this.Cbo_Orden);
            this.panel4.Controls.Add(this.Lbl_Costos);
            this.panel4.Controls.Add(this.Lbl_Orden);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(13, 13);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1220, 581);
            this.panel4.TabIndex = 7;
            // 
            // Lbl_Costos
            // 
            this.Lbl_Costos.AutoSize = true;
            this.Lbl_Costos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Costos.Location = new System.Drawing.Point(23, 14);
            this.Lbl_Costos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Costos.Name = "Lbl_Costos";
            this.Lbl_Costos.Size = new System.Drawing.Size(269, 29);
            this.Lbl_Costos.TabIndex = 11;
            this.Lbl_Costos.Text = "Costos de Producción";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 49);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1013, 14);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaterial);
            this.tabControl1.Controls.Add(this.tabMerma);
            this.tabControl1.Controls.Add(this.tab_Produccion);
            this.tabControl1.Controls.Add(this.tabCostos);
            this.tabControl1.Location = new System.Drawing.Point(28, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1169, 457);
            this.tabControl1.TabIndex = 8;
            // 
            // tab_Produccion
            // 
            this.tab_Produccion.Location = new System.Drawing.Point(4, 25);
            this.tab_Produccion.Name = "tab_Produccion";
            this.tab_Produccion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Produccion.Size = new System.Drawing.Size(1161, 428);
            this.tab_Produccion.TabIndex = 0;
            this.tab_Produccion.Text = "Mano de Obra";
            this.tab_Produccion.UseVisualStyleBackColor = true;
            // 
            // tabCostos
            // 
            this.tabCostos.Location = new System.Drawing.Point(4, 25);
            this.tabCostos.Name = "tabCostos";
            this.tabCostos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCostos.Size = new System.Drawing.Size(1161, 428);
            this.tabCostos.TabIndex = 1;
            this.tabCostos.Text = "Costos Indirectos";
            this.tabCostos.UseVisualStyleBackColor = true;
            // 
            // tabMerma
            // 
            this.tabMerma.Location = new System.Drawing.Point(4, 25);
            this.tabMerma.Name = "tabMerma";
            this.tabMerma.Padding = new System.Windows.Forms.Padding(3);
            this.tabMerma.Size = new System.Drawing.Size(1161, 428);
            this.tabMerma.TabIndex = 2;
            this.tabMerma.Text = "Mermas";
            this.tabMerma.UseVisualStyleBackColor = true;
            // 
            // Lbl_Orden
            // 
            this.Lbl_Orden.AutoSize = true;
            this.Lbl_Orden.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden.Location = new System.Drawing.Point(28, 88);
            this.Lbl_Orden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Orden.Name = "Lbl_Orden";
            this.Lbl_Orden.Size = new System.Drawing.Size(87, 19);
            this.Lbl_Orden.TabIndex = 18;
            this.Lbl_Orden.Text = "Orden No:";
            // 
            // Cbo_Orden
            // 
            this.Cbo_Orden.FormattingEnabled = true;
            this.Cbo_Orden.Location = new System.Drawing.Point(122, 87);
            this.Cbo_Orden.Name = "Cbo_Orden";
            this.Cbo_Orden.Size = new System.Drawing.Size(132, 24);
            this.Cbo_Orden.TabIndex = 19;
            // 
            // tabMaterial
            // 
            this.tabMaterial.Location = new System.Drawing.Point(4, 25);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Size = new System.Drawing.Size(1161, 428);
            this.tabMaterial.TabIndex = 3;
            this.tabMaterial.Text = "Consumo de Materiales";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // Frm_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 627);
            this.Controls.Add(this.panel4);
            this.Name = "Frm_Produccion";
            this.Text = "Frm_Produccion";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Lbl_Costos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Produccion;
        private System.Windows.Forms.TabPage tabCostos;
        private System.Windows.Forms.TabPage tabMerma;
        private System.Windows.Forms.Label Lbl_Orden;
        private System.Windows.Forms.ComboBox Cbo_Orden;
        private System.Windows.Forms.TabPage tabMaterial;
    }
}