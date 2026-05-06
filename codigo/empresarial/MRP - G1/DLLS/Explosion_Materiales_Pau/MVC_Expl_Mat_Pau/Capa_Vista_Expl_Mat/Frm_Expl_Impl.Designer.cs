
namespace Capa_Vista_Expl_Mat
{
    partial class Frm_Expl_Impl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ExplPage = new System.Windows.Forms.TabPage();
            this.Dgv_InformacionExplosion = new System.Windows.Forms.DataGridView();
            this.Btn_CrearExplosion = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_BuscarOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImplPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ExplPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InformacionExplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.ExplPage);
            this.tabControl1.Controls.Add(this.ImplPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // ExplPage
            // 
            this.ExplPage.Controls.Add(this.Dgv_InformacionExplosion);
            this.ExplPage.Controls.Add(this.Btn_CrearExplosion);
            this.ExplPage.Controls.Add(this.dateTimePicker2);
            this.ExplPage.Controls.Add(this.label5);
            this.ExplPage.Controls.Add(this.dateTimePicker1);
            this.ExplPage.Controls.Add(this.label4);
            this.ExplPage.Controls.Add(this.Txt_BuscarOrden);
            this.ExplPage.Controls.Add(this.label1);
            this.ExplPage.Location = new System.Drawing.Point(4, 32);
            this.ExplPage.Name = "ExplPage";
            this.ExplPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExplPage.Size = new System.Drawing.Size(1142, 581);
            this.ExplPage.TabIndex = 0;
            this.ExplPage.Text = "Explosión";
            this.ExplPage.UseVisualStyleBackColor = true;
            // 
            // Dgv_InformacionExplosion
            // 
            this.Dgv_InformacionExplosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_InformacionExplosion.Location = new System.Drawing.Point(14, 106);
            this.Dgv_InformacionExplosion.Name = "Dgv_InformacionExplosion";
            this.Dgv_InformacionExplosion.RowHeadersWidth = 51;
            this.Dgv_InformacionExplosion.RowTemplate.Height = 24;
            this.Dgv_InformacionExplosion.Size = new System.Drawing.Size(1102, 451);
            this.Dgv_InformacionExplosion.TabIndex = 49;
            this.Dgv_InformacionExplosion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_InformacionExplosion_CellContentClick);
            // 
            // Btn_CrearExplosion
            // 
            this.Btn_CrearExplosion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CrearExplosion.Location = new System.Drawing.Point(951, 48);
            this.Btn_CrearExplosion.Name = "Btn_CrearExplosion";
            this.Btn_CrearExplosion.Size = new System.Drawing.Size(165, 29);
            this.Btn_CrearExplosion.TabIndex = 12;
            this.Btn_CrearExplosion.Text = "Explosión Nueva";
            this.Btn_CrearExplosion.UseVisualStyleBackColor = true;
            this.Btn_CrearExplosion.Click += new System.EventHandler(this.Btn_CrearExplosion_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(643, 55);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 57);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desde: ";
            // 
            // Txt_BuscarOrden
            // 
            this.Txt_BuscarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BuscarOrden.Location = new System.Drawing.Point(14, 59);
            this.Txt_BuscarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_BuscarOrden.Name = "Txt_BuscarOrden";
            this.Txt_BuscarOrden.Size = new System.Drawing.Size(172, 22);
            this.Txt_BuscarOrden.TabIndex = 2;
            this.Txt_BuscarOrden.Text = "Buscar por Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Explosiones";
            // 
            // ImplPage
            // 
            this.ImplPage.Location = new System.Drawing.Point(4, 32);
            this.ImplPage.Name = "ImplPage";
            this.ImplPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImplPage.Size = new System.Drawing.Size(1142, 581);
            this.ImplPage.TabIndex = 1;
            this.ImplPage.Text = "Implosión";
            this.ImplPage.UseVisualStyleBackColor = true;
            // 
            // Frm_Expl_Impl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Expl_Impl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explosión e Implosión de Materiales";
            this.tabControl1.ResumeLayout(false);
            this.ExplPage.ResumeLayout(false);
            this.ExplPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InformacionExplosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ExplPage;
        private System.Windows.Forms.TabPage ImplPage;
        private System.Windows.Forms.Button Btn_CrearExplosion;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_BuscarOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_InformacionExplosion;
    }
}