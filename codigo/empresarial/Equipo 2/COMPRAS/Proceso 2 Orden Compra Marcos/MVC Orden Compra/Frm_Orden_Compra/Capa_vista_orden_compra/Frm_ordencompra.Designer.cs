
namespace Capa_vista_orden_compra
{
    partial class Frm_ordencompra
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
            this.Pn_titulo = new System.Windows.Forms.Panel();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Dgv_orden = new System.Windows.Forms.DataGridView();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Pn_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_orden)).BeginInit();
            this.SuspendLayout();
            // 
            // Pn_titulo
            // 
            this.Pn_titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pn_titulo.Controls.Add(this.Lbl_titulo);
            this.Pn_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pn_titulo.Margin = new System.Windows.Forms.Padding(2);
            this.Pn_titulo.Name = "Pn_titulo";
            this.Pn_titulo.Size = new System.Drawing.Size(897, 63);
            this.Pn_titulo.TabIndex = 0;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_titulo.Location = new System.Drawing.Point(23, 20);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(305, 27);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "713 - ORDEN DE COMPRA";
            // 
            // Dgv_orden
            // 
            this.Dgv_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_orden.Location = new System.Drawing.Point(10, 185);
            this.Dgv_orden.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_orden.Name = "Dgv_orden";
            this.Dgv_orden.RowHeadersWidth = 51;
            this.Dgv_orden.RowTemplate.Height = 24;
            this.Dgv_orden.Size = new System.Drawing.Size(817, 222);
            this.Dgv_orden.TabIndex = 40;
            this.Dgv_orden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_orden_CellClick);
            this.Dgv_orden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_orden_CellContentClick);
            this.Dgv_orden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_orden_CellDoubleClick);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_vista_orden_compra.Properties.Resources.help_question_16768;
            this.Btn_ayuda.Location = new System.Drawing.Point(794, 80);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(49, 44);
            this.Btn_ayuda.TabIndex = 41;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Capa_vista_orden_compra.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(622, 87);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 65);
            this.button2.TabIndex = 39;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Image = global::Capa_vista_orden_compra.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Imprimir.Location = new System.Drawing.Point(532, 87);
            this.Btn_Imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(86, 65);
            this.Btn_Imprimir.TabIndex = 38;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_vista_orden_compra.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(431, 87);
            this.Btn_Refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(96, 65);
            this.Btn_Refrescar.TabIndex = 37;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::Capa_vista_orden_compra.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancelar.Location = new System.Drawing.Point(333, 87);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(94, 65);
            this.Btn_Cancelar.TabIndex = 36;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Grabar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Grabar.Image = global::Capa_vista_orden_compra.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Grabar.Location = new System.Drawing.Point(213, 87);
            this.Btn_Grabar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(117, 65);
            this.Btn_Grabar.TabIndex = 35;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_vista_orden_compra.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(110, 87);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(99, 65);
            this.Btn_Editar.TabIndex = 34;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_vista_orden_compra.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(10, 87);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(95, 65);
            this.Btn_Ingresar.TabIndex = 33;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Frm_ordencompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 434);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dgv_orden);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.Pn_titulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ordencompra";
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.Frm_ordencompra_Load);
            this.Pn_titulo.ResumeLayout(false);
            this.Pn_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_orden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pn_titulo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.DataGridView Dgv_orden;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}