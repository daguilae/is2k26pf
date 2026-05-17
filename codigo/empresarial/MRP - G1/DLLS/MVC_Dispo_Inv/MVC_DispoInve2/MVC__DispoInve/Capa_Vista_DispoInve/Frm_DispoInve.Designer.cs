
namespace Capa_Vista_DispoInve
{
    partial class Frm_DispoInve
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISPONIBILIDAD DE INVENTARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Almacen:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(17, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label5";
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(21, 276);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(1182, 288);
            this.dgvInventario.TabIndex = 6;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(110, 151);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(1035, 27);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Location = new System.Drawing.Point(502, 182);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(276, 28);
            this.cmbAlmacen.TabIndex = 10;
            this.cmbAlmacen.SelectedIndexChanged += new System.EventHandler(this.cmbAlmacen_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(110, 186);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(276, 28);
            this.cmbTipo.TabIndex = 11;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(21, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1182, 8);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Resultados:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(21, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1182, 8);
            this.label5.TabIndex = 29;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.izquierda;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(693, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 70);
            this.button8.TabIndex = 28;
            this.button8.Text = "Inicio";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.izquierda2;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(779, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 70);
            this.button7.TabIndex = 27;
            this.button7.Text = "Anterior";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.derecha2;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(865, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 70);
            this.button6.TabIndex = 26;
            this.button6.Text = "Siguiente";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.derecha;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(951, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 70);
            this.button5.TabIndex = 25;
            this.button5.Text = "Fin";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.buscar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(435, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 70);
            this.button4.TabIndex = 24;
            this.button4.Text = "Consultar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.cancelar2;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(263, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 70);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.agregar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 70);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ingresar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_salir.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.salir;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_salir.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salir.Location = new System.Drawing.Point(1123, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(85, 70);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ayuda.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.ayuda;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ayuda.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ayuda.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ayuda.Location = new System.Drawing.Point(1037, 12);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(85, 70);
            this.btn_ayuda.TabIndex = 17;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_imprimir.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.imprimir;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_imprimir.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_imprimir.Location = new System.Drawing.Point(521, 12);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(85, 70);
            this.btn_imprimir.TabIndex = 16;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_actualizar.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.refrescar;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_actualizar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_actualizar.Location = new System.Drawing.Point(607, 12);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(85, 70);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.Text = "Refrescar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_eliminar.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.eliminar;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_eliminar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_eliminar.Location = new System.Drawing.Point(349, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(85, 70);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_editar.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.modificar;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_editar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_editar.Location = new System.Drawing.Point(177, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(85, 70);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Modificar";
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_guardar.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_guardar.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar.Location = new System.Drawing.Point(91, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(85, 70);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Capa_Vista_DispoInve.Properties.Resources.buscar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1164, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_DispoInve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbAlmacen);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DispoInve";
            this.Text = "Disponibilidad de Inventario - 731 ";
            this.Load += new System.EventHandler(this.Frm_DispoInve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
    }
}