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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Expl_Impl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ExplPage = new System.Windows.Forms.TabPage();
            this.Btn_Ref = new System.Windows.Forms.Button();
            this.Btn_eliminar_explo = new System.Windows.Forms.Button();
            this.Dgv_InformacionExplosion = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_BuscarOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImplPage = new System.Windows.Forms.TabPage();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_BuscarOtraOrden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_EstadoImplosion = new System.Windows.Forms.Label();
            this.Btn_GenerarOrdenLogistica = new System.Windows.Forms.Button();
            this.Dgv_Implosion = new System.Windows.Forms.DataGridView();
            this.Cmb_OrdenProduccion = new System.Windows.Forms.ComboBox();
            this.Btn_CrearExplosion = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ExplPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InformacionExplosion)).BeginInit();
            this.ImplPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Implosion)).BeginInit();
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
            this.ExplPage.Controls.Add(this.Btn_Ref);
            this.ExplPage.Controls.Add(this.Btn_eliminar_explo);
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
            // Btn_Ref
            // 
            this.Btn_Ref.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ref.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ref.Image")));
            this.Btn_Ref.Location = new System.Drawing.Point(1026, 7);
            this.Btn_Ref.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ref.Name = "Btn_Ref";
            this.Btn_Ref.Size = new System.Drawing.Size(90, 90);
            this.Btn_Ref.TabIndex = 51;
            this.Btn_Ref.Text = "Refrescar";
            this.Btn_Ref.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ref.UseVisualStyleBackColor = true;
            this.Btn_Ref.Click += new System.EventHandler(this.Btn_Ref_Click);
            // 
            // Btn_eliminar_explo
            // 
            this.Btn_eliminar_explo.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar_explo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar_explo.Image")));
            this.Btn_eliminar_explo.Location = new System.Drawing.Point(928, 7);
            this.Btn_eliminar_explo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar_explo.Name = "Btn_eliminar_explo";
            this.Btn_eliminar_explo.Size = new System.Drawing.Size(90, 90);
            this.Btn_eliminar_explo.TabIndex = 50;
            this.Btn_eliminar_explo.Text = "Eliminar";
            this.Btn_eliminar_explo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar_explo.UseVisualStyleBackColor = true;
            this.Btn_eliminar_explo.Click += new System.EventHandler(this.Btn_eliminar_explo_Click);
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(510, 71);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(510, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desde: ";
            // 
            // Txt_BuscarOrden
            // 
            this.Txt_BuscarOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_BuscarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_BuscarOrden.Location = new System.Drawing.Point(14, 69);
            this.Txt_BuscarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_BuscarOrden.Name = "Txt_BuscarOrden";
            this.Txt_BuscarOrden.Size = new System.Drawing.Size(217, 22);
            this.Txt_BuscarOrden.TabIndex = 2;
            this.Txt_BuscarOrden.TextChanged += new System.EventHandler(this.Txt_BuscarOrden_TextChanged);
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
            this.ImplPage.Controls.Add(this.Btn_Refrescar);
            this.ImplPage.Controls.Add(this.Btn_BuscarOtraOrden);
            this.ImplPage.Controls.Add(this.label2);
            this.ImplPage.Controls.Add(this.Lbl_EstadoImplosion);
            this.ImplPage.Controls.Add(this.Btn_GenerarOrdenLogistica);
            this.ImplPage.Controls.Add(this.Dgv_Implosion);
            this.ImplPage.Controls.Add(this.Cmb_OrdenProduccion);
            this.ImplPage.Location = new System.Drawing.Point(4, 32);
            this.ImplPage.Name = "ImplPage";
            this.ImplPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImplPage.Size = new System.Drawing.Size(1142, 581);
            this.ImplPage.TabIndex = 1;
            this.ImplPage.Text = "Implosión";
            this.ImplPage.UseVisualStyleBackColor = true;
            this.ImplPage.Click += new System.EventHandler(this.ImplPage_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.AllowDrop = true;
            this.Btn_Refrescar.Location = new System.Drawing.Point(450, 116);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(195, 31);
            this.Btn_Refrescar.TabIndex = 6;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Btn_BuscarOtraOrden
            // 
            this.Btn_BuscarOtraOrden.Location = new System.Drawing.Point(249, 112);
            this.Btn_BuscarOtraOrden.Name = "Btn_BuscarOtraOrden";
            this.Btn_BuscarOtraOrden.Size = new System.Drawing.Size(195, 33);
            this.Btn_BuscarOtraOrden.TabIndex = 5;
            this.Btn_BuscarOtraOrden.Text = "Buscar Otra Orden";
            this.Btn_BuscarOtraOrden.UseVisualStyleBackColor = true;
            this.Btn_BuscarOtraOrden.Click += new System.EventHandler(this.Btn_BuscarOtraOrden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Analisis de Implosión";
            // 
            // Lbl_EstadoImplosion
            // 
            this.Lbl_EstadoImplosion.AutoSize = true;
            this.Lbl_EstadoImplosion.Location = new System.Drawing.Point(420, 78);
            this.Lbl_EstadoImplosion.Name = "Lbl_EstadoImplosion";
            this.Lbl_EstadoImplosion.Size = new System.Drawing.Size(177, 20);
            this.Lbl_EstadoImplosion.TabIndex = 3;
            this.Lbl_EstadoImplosion.Text = "Analizando orden...";
            // 
            // Btn_GenerarOrdenLogistica
            // 
            this.Btn_GenerarOrdenLogistica.Location = new System.Drawing.Point(35, 112);
            this.Btn_GenerarOrdenLogistica.Name = "Btn_GenerarOrdenLogistica";
            this.Btn_GenerarOrdenLogistica.Size = new System.Drawing.Size(208, 35);
            this.Btn_GenerarOrdenLogistica.TabIndex = 2;
            this.Btn_GenerarOrdenLogistica.Text = "Generar Orden ";
            this.Btn_GenerarOrdenLogistica.UseVisualStyleBackColor = true;
            this.Btn_GenerarOrdenLogistica.Click += new System.EventHandler(this.Btn_GenerarOrdenLogistica_Click_1);
            // 
            // Dgv_Implosion
            // 
            this.Dgv_Implosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Implosion.Location = new System.Drawing.Point(34, 163);
            this.Dgv_Implosion.Name = "Dgv_Implosion";
            this.Dgv_Implosion.RowHeadersWidth = 51;
            this.Dgv_Implosion.RowTemplate.Height = 24;
            this.Dgv_Implosion.Size = new System.Drawing.Size(1081, 412);
            this.Dgv_Implosion.TabIndex = 1;
            this.Dgv_Implosion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Implosion_CellContentClick_1);
            // 
            // Cmb_OrdenProduccion
            // 
            this.Cmb_OrdenProduccion.FormattingEnabled = true;
            this.Cmb_OrdenProduccion.Location = new System.Drawing.Point(34, 75);
            this.Cmb_OrdenProduccion.Name = "Cmb_OrdenProduccion";
            this.Cmb_OrdenProduccion.Size = new System.Drawing.Size(363, 28);
            this.Cmb_OrdenProduccion.TabIndex = 0;
            this.Cmb_OrdenProduccion.SelectedIndexChanged += new System.EventHandler(this.Cmb_OrdenProduccion_SelectedIndexChanged_1);
            // 
            // Btn_CrearExplosion
            // 
            this.Btn_CrearExplosion.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CrearExplosion.Location = new System.Drawing.Point(831, 10);
            this.Btn_CrearExplosion.Name = "Btn_CrearExplosion";
            this.Btn_CrearExplosion.Size = new System.Drawing.Size(90, 90);
            this.Btn_CrearExplosion.TabIndex = 12;
            this.Btn_CrearExplosion.Text = "Ingresar Explosión";
            this.Btn_CrearExplosion.UseVisualStyleBackColor = true;
            this.Btn_CrearExplosion.Click += new System.EventHandler(this.Btn_CrearExplosion_Click);
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
            this.ImplPage.ResumeLayout(false);
            this.ImplPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Implosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ExplPage;
        private System.Windows.Forms.TabPage ImplPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_BuscarOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_InformacionExplosion;
        private System.Windows.Forms.Label Lbl_EstadoImplosion;
        private System.Windows.Forms.Button Btn_GenerarOrdenLogistica;
        private System.Windows.Forms.DataGridView Dgv_Implosion;
        private System.Windows.Forms.ComboBox Cmb_OrdenProduccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_BuscarOtraOrden;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_eliminar_explo;
        private System.Windows.Forms.Button Btn_Ref;
        private System.Windows.Forms.Button Btn_CrearExplosion;
    }
}