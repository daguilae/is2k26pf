
namespace Capa_Vista_Ventas
{
    partial class Frm_Asignacion_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Asignacion_Clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.GB_AsignClientes = new System.Windows.Forms.GroupBox();
            this.Cbo_Id_Cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Vendedor = new System.Windows.Forms.Label();
            this.Cbo_Id_Vendedor = new System.Windows.Forms.ComboBox();
            this.Lbl_IDVenta = new System.Windows.Forms.Label();
            this.Dgv_Asignacion_clientes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_AsignClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asignacion_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 98);
            this.panel1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Ventas.Properties.Resources._4105943_accounts_group_people_user_user_group_users_113923;
            this.pictureBox1.Location = new System.Drawing.Point(560, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASIGNACIÓN DE CLIENTES";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(484, 122);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Eliminar.TabIndex = 52;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.White;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(246, 122);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Guardar.TabIndex = 51;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.Location = new System.Drawing.Point(603, 122);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Buscar.TabIndex = 49;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.White;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(960, 122);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(111, 98);
            this.Btn_Salir.TabIndex = 48;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(127, 122);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Modificar.TabIndex = 47;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(722, 122);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(111, 98);
            this.Btn_Reporte.TabIndex = 46;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(841, 122);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(111, 98);
            this.Btn_Ayuda.TabIndex = 45;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(365, 122);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Cancelar.TabIndex = 44;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar.Image")));
            this.Btn_Ingresar.Location = new System.Drawing.Point(8, 122);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(111, 98);
            this.Btn_Ingresar.TabIndex = 43;
            this.Btn_Ingresar.Text = "INGRESAR";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // GB_AsignClientes
            // 
            this.GB_AsignClientes.Controls.Add(this.Cbo_Id_Cliente);
            this.GB_AsignClientes.Controls.Add(this.Lbl_Id_Vendedor);
            this.GB_AsignClientes.Controls.Add(this.Cbo_Id_Vendedor);
            this.GB_AsignClientes.Controls.Add(this.Lbl_IDVenta);
            this.GB_AsignClientes.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_AsignClientes.Location = new System.Drawing.Point(8, 248);
            this.GB_AsignClientes.Margin = new System.Windows.Forms.Padding(4);
            this.GB_AsignClientes.Name = "GB_AsignClientes";
            this.GB_AsignClientes.Padding = new System.Windows.Forms.Padding(4);
            this.GB_AsignClientes.Size = new System.Drawing.Size(882, 93);
            this.GB_AsignClientes.TabIndex = 53;
            this.GB_AsignClientes.TabStop = false;
            this.GB_AsignClientes.Text = "Asignaciones de clientes";
            // 
            // Cbo_Id_Cliente
            // 
            this.Cbo_Id_Cliente.FormattingEnabled = true;
            this.Cbo_Id_Cliente.Location = new System.Drawing.Point(530, 32);
            this.Cbo_Id_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Cliente.MaxLength = 13;
            this.Cbo_Id_Cliente.Name = "Cbo_Id_Cliente";
            this.Cbo_Id_Cliente.Size = new System.Drawing.Size(333, 30);
            this.Cbo_Id_Cliente.TabIndex = 11;
            // 
            // Lbl_Id_Vendedor
            // 
            this.Lbl_Id_Vendedor.AutoSize = true;
            this.Lbl_Id_Vendedor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Vendedor.Location = new System.Drawing.Point(431, 38);
            this.Lbl_Id_Vendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Vendedor.Name = "Lbl_Id_Vendedor";
            this.Lbl_Id_Vendedor.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Id_Vendedor.TabIndex = 10;
            this.Lbl_Id_Vendedor.Text = "Cliente:";
            // 
            // Cbo_Id_Vendedor
            // 
            this.Cbo_Id_Vendedor.FormattingEnabled = true;
            this.Cbo_Id_Vendedor.Location = new System.Drawing.Point(137, 38);
            this.Cbo_Id_Vendedor.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Vendedor.Name = "Cbo_Id_Vendedor";
            this.Cbo_Id_Vendedor.Size = new System.Drawing.Size(267, 30);
            this.Cbo_Id_Vendedor.TabIndex = 8;
            this.Cbo_Id_Vendedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Vendedor_SelectedIndexChanged);
            // 
            // Lbl_IDVenta
            // 
            this.Lbl_IDVenta.AutoSize = true;
            this.Lbl_IDVenta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDVenta.Location = new System.Drawing.Point(17, 42);
            this.Lbl_IDVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDVenta.Name = "Lbl_IDVenta";
            this.Lbl_IDVenta.Size = new System.Drawing.Size(93, 20);
            this.Lbl_IDVenta.TabIndex = 0;
            this.Lbl_IDVenta.Text = "Vendedor:";
            // 
            // Dgv_Asignacion_clientes
            // 
            this.Dgv_Asignacion_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Asignacion_clientes.Location = new System.Drawing.Point(246, 377);
            this.Dgv_Asignacion_clientes.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Asignacion_clientes.Name = "Dgv_Asignacion_clientes";
            this.Dgv_Asignacion_clientes.RowHeadersWidth = 51;
            this.Dgv_Asignacion_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Asignacion_clientes.Size = new System.Drawing.Size(580, 239);
            this.Dgv_Asignacion_clientes.TabIndex = 54;
            this.Dgv_Asignacion_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Asignacion_clientes_CellContentClick);
            // 
            // Frm_Asignacion_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 657);
            this.Controls.Add(this.Dgv_Asignacion_clientes);
            this.Controls.Add(this.GB_AsignClientes);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Asignacion_Clientes";
            this.Text = "Asignacion Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_AsignClientes.ResumeLayout(false);
            this.GB_AsignClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Asignacion_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.GroupBox GB_AsignClientes;
        private System.Windows.Forms.ComboBox Cbo_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Id_Vendedor;
        private System.Windows.Forms.ComboBox Cbo_Id_Vendedor;
        private System.Windows.Forms.Label Lbl_IDVenta;
        private System.Windows.Forms.DataGridView Dgv_Asignacion_clientes;
    }
}