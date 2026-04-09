
namespace Capa_Vista_Mov_Inv
{
    partial class Frm_Encabezado_Transaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Encabezado_Transaccion));
            this.BTN_LIMPIAR_ENCABEZADO = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.GB_Detalle = new System.Windows.Forms.GroupBox();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_ID_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.BTN_LIMPIAR_DETALE = new System.Windows.Forms.Button();
            this.Btn_Remover_Detalle = new System.Windows.Forms.Button();
            this.Btn_Agregar_Detalle = new System.Windows.Forms.Button();
            this.DGV_DETALLE_MOVIMIENTO = new System.Windows.Forms.DataGridView();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Agregar_Movimiento = new System.Windows.Forms.Button();
            this.GB_ENCABEZADO = new System.Windows.Forms.GroupBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.Cbo_Id_Movimiento = new System.Windows.Forms.ComboBox();
            this.DTP_FECHA_Movimiento = new System.Windows.Forms.DateTimePicker();
            this.CBO_ID_Tipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Movimiento = new System.Windows.Forms.Label();
            this.Lbl_ID_TipoMovimiento = new System.Windows.Forms.Label();
            this.Lbl_IDMovInv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NumUpDwn_CantidadMovida = new System.Windows.Forms.NumericUpDown();
            this.GB_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).BeginInit();
            this.GB_ENCABEZADO.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_CantidadMovida)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LIMPIAR_ENCABEZADO
            // 
            this.BTN_LIMPIAR_ENCABEZADO.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_ENCABEZADO.Image")));
            this.BTN_LIMPIAR_ENCABEZADO.Location = new System.Drawing.Point(474, 111);
            this.BTN_LIMPIAR_ENCABEZADO.Name = "BTN_LIMPIAR_ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.Size = new System.Drawing.Size(86, 80);
            this.BTN_LIMPIAR_ENCABEZADO.TabIndex = 29;
            this.BTN_LIMPIAR_ENCABEZADO.Text = "LIMPIAR ENCABEZADO";
            this.BTN_LIMPIAR_ENCABEZADO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_ENCABEZADO.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(747, 111);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 80);
            this.Btn_Salir.TabIndex = 28;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // GB_Detalle
            // 
            this.GB_Detalle.Controls.Add(this.NumUpDwn_CantidadMovida);
            this.GB_Detalle.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle.Controls.Add(this.Cbo_ID_Inventario);
            this.GB_Detalle.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle.Controls.Add(this.BTN_LIMPIAR_DETALE);
            this.GB_Detalle.Controls.Add(this.Btn_Remover_Detalle);
            this.GB_Detalle.Controls.Add(this.Btn_Agregar_Detalle);
            this.GB_Detalle.Controls.Add(this.DGV_DETALLE_MOVIMIENTO);
            this.GB_Detalle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle.Location = new System.Drawing.Point(3, 454);
            this.GB_Detalle.Name = "GB_Detalle";
            this.GB_Detalle.Size = new System.Drawing.Size(830, 433);
            this.GB_Detalle.TabIndex = 27;
            this.GB_Detalle.TabStop = false;
            this.GB_Detalle.Text = "DETALLE";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(418, 116);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(112, 16);
            this.Lbl_Cantidad.TabIndex = 15;
            this.Lbl_Cantidad.Text = "Cantidad Movida:";
            // 
            // Cbo_ID_Inventario
            // 
            this.Cbo_ID_Inventario.FormattingEnabled = true;
            this.Cbo_ID_Inventario.Location = new System.Drawing.Point(148, 111);
            this.Cbo_ID_Inventario.Name = "Cbo_ID_Inventario";
            this.Cbo_ID_Inventario.Size = new System.Drawing.Size(162, 27);
            this.Cbo_ID_Inventario.TabIndex = 14;
            // 
            // Lbl_Inventario
            // 
            this.Lbl_Inventario.AutoSize = true;
            this.Lbl_Inventario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventario.Location = new System.Drawing.Point(17, 116);
            this.Lbl_Inventario.Name = "Lbl_Inventario";
            this.Lbl_Inventario.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Inventario.TabIndex = 13;
            this.Lbl_Inventario.Text = "Id Inventario:";
            // 
            // BTN_LIMPIAR_DETALE
            // 
            this.BTN_LIMPIAR_DETALE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_DETALE.Image")));
            this.BTN_LIMPIAR_DETALE.Location = new System.Drawing.Point(261, 19);
            this.BTN_LIMPIAR_DETALE.Name = "BTN_LIMPIAR_DETALE";
            this.BTN_LIMPIAR_DETALE.Size = new System.Drawing.Size(113, 80);
            this.BTN_LIMPIAR_DETALE.TabIndex = 12;
            this.BTN_LIMPIAR_DETALE.Text = "LIMPIAR";
            this.BTN_LIMPIAR_DETALE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_DETALE.UseVisualStyleBackColor = true;
            // 
            // Btn_Remover_Detalle
            // 
            this.Btn_Remover_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle.Image")));
            this.Btn_Remover_Detalle.Location = new System.Drawing.Point(142, 19);
            this.Btn_Remover_Detalle.Name = "Btn_Remover_Detalle";
            this.Btn_Remover_Detalle.Size = new System.Drawing.Size(113, 80);
            this.Btn_Remover_Detalle.TabIndex = 11;
            this.Btn_Remover_Detalle.Text = "REMOVER";
            this.Btn_Remover_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Detalle
            // 
            this.Btn_Agregar_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle.Image")));
            this.Btn_Agregar_Detalle.Location = new System.Drawing.Point(20, 19);
            this.Btn_Agregar_Detalle.Name = "Btn_Agregar_Detalle";
            this.Btn_Agregar_Detalle.Size = new System.Drawing.Size(116, 80);
            this.Btn_Agregar_Detalle.TabIndex = 9;
            this.Btn_Agregar_Detalle.Text = "AGREGAR";
            this.Btn_Agregar_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Detalle.UseVisualStyleBackColor = true;
            // 
            // DGV_DETALLE_MOVIMIENTO
            // 
            this.DGV_DETALLE_MOVIMIENTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DETALLE_MOVIMIENTO.Location = new System.Drawing.Point(20, 161);
            this.DGV_DETALLE_MOVIMIENTO.Name = "DGV_DETALLE_MOVIMIENTO";
            this.DGV_DETALLE_MOVIMIENTO.Size = new System.Drawing.Size(789, 254);
            this.DGV_DETALLE_MOVIMIENTO.TabIndex = 10;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(383, 111);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Modificar.TabIndex = 25;
            this.Btn_Modificar.Text = "MODIFICAR";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte.Image")));
            this.Btn_Reporte.Location = new System.Drawing.Point(563, 111);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(86, 80);
            this.Btn_Reporte.TabIndex = 24;
            this.Btn_Reporte.Text = "REPORTE";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(655, 111);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(86, 80);
            this.Btn_Ayuda.TabIndex = 23;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(291, 111);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(86, 80);
            this.Btn_Cancelar.TabIndex = 22;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(717, 198);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(132, 80);
            this.btn_Guardar.TabIndex = 21;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Agregar_Movimiento
            // 
            this.Btn_Agregar_Movimiento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Movimiento.Image")));
            this.Btn_Agregar_Movimiento.Location = new System.Drawing.Point(132, 111);
            this.Btn_Agregar_Movimiento.Name = "Btn_Agregar_Movimiento";
            this.Btn_Agregar_Movimiento.Size = new System.Drawing.Size(132, 80);
            this.Btn_Agregar_Movimiento.TabIndex = 20;
            this.Btn_Agregar_Movimiento.Text = "ADD Movimiento";
            this.Btn_Agregar_Movimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Movimiento.UseVisualStyleBackColor = true;
            // 
            // GB_ENCABEZADO
            // 
            this.GB_ENCABEZADO.Controls.Add(this.txt_descripcion);
            this.GB_ENCABEZADO.Controls.Add(this.Cbo_Id_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.DTP_FECHA_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.CBO_ID_Tipo_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_Descripcion);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_Fecha_Movimiento);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_ID_TipoMovimiento);
            this.GB_ENCABEZADO.Controls.Add(this.Lbl_IDMovInv);
            this.GB_ENCABEZADO.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_ENCABEZADO.Location = new System.Drawing.Point(3, 187);
            this.GB_ENCABEZADO.Name = "GB_ENCABEZADO";
            this.GB_ENCABEZADO.Size = new System.Drawing.Size(693, 241);
            this.GB_ENCABEZADO.TabIndex = 19;
            this.GB_ENCABEZADO.TabStop = false;
            this.GB_ENCABEZADO.Text = "ENCABEZADO";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(20, 141);
            this.txt_descripcion.MinimumSize = new System.Drawing.Size(4, 80);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(645, 26);
            this.txt_descripcion.TabIndex = 9;
            // 
            // Cbo_Id_Movimiento
            // 
            this.Cbo_Id_Movimiento.FormattingEnabled = true;
            this.Cbo_Id_Movimiento.Location = new System.Drawing.Point(155, 29);
            this.Cbo_Id_Movimiento.Name = "Cbo_Id_Movimiento";
            this.Cbo_Id_Movimiento.Size = new System.Drawing.Size(162, 27);
            this.Cbo_Id_Movimiento.TabIndex = 8;
            // 
            // DTP_FECHA_Movimiento
            // 
            this.DTP_FECHA_Movimiento.Location = new System.Drawing.Point(472, 30);
            this.DTP_FECHA_Movimiento.Name = "DTP_FECHA_Movimiento";
            this.DTP_FECHA_Movimiento.Size = new System.Drawing.Size(200, 26);
            this.DTP_FECHA_Movimiento.TabIndex = 6;
            // 
            // CBO_ID_Tipo_Movimiento
            // 
            this.CBO_ID_Tipo_Movimiento.FormattingEnabled = true;
            this.CBO_ID_Tipo_Movimiento.Location = new System.Drawing.Point(155, 70);
            this.CBO_ID_Tipo_Movimiento.MaxLength = 13;
            this.CBO_ID_Tipo_Movimiento.Name = "CBO_ID_Tipo_Movimiento";
            this.CBO_ID_Tipo_Movimiento.Size = new System.Drawing.Size(162, 27);
            this.CBO_ID_Tipo_Movimiento.TabIndex = 5;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(24, 109);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(81, 16);
            this.Lbl_Descripcion.TabIndex = 3;
            this.Lbl_Descripcion.Text = "Descripcion:";
            // 
            // Lbl_Fecha_Movimiento
            // 
            this.Lbl_Fecha_Movimiento.AutoSize = true;
            this.Lbl_Fecha_Movimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Movimiento.Location = new System.Drawing.Point(345, 34);
            this.Lbl_Fecha_Movimiento.Name = "Lbl_Fecha_Movimiento";
            this.Lbl_Fecha_Movimiento.Size = new System.Drawing.Size(121, 16);
            this.Lbl_Fecha_Movimiento.TabIndex = 2;
            this.Lbl_Fecha_Movimiento.Text = "Fecha_Movimiento:";
            // 
            // Lbl_ID_TipoMovimiento
            // 
            this.Lbl_ID_TipoMovimiento.AutoSize = true;
            this.Lbl_ID_TipoMovimiento.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_TipoMovimiento.Location = new System.Drawing.Point(24, 75);
            this.Lbl_ID_TipoMovimiento.Name = "Lbl_ID_TipoMovimiento";
            this.Lbl_ID_TipoMovimiento.Size = new System.Drawing.Size(125, 16);
            this.Lbl_ID_TipoMovimiento.TabIndex = 1;
            this.Lbl_ID_TipoMovimiento.Text = "Tipo de Movimiento:";
            // 
            // Lbl_IDMovInv
            // 
            this.Lbl_IDMovInv.AutoSize = true;
            this.Lbl_IDMovInv.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDMovInv.Location = new System.Drawing.Point(24, 34);
            this.Lbl_IDMovInv.Name = "Lbl_IDMovInv";
            this.Lbl_IDMovInv.Size = new System.Drawing.Size(94, 16);
            this.Lbl_IDMovInv.TabIndex = 0;
            this.Lbl_IDMovInv.Text = "Id Movimiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 80);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movimiento De Inventario";
            // 
            // NumUpDwn_CantidadMovida
            // 
            this.NumUpDwn_CantidadMovida.Location = new System.Drawing.Point(545, 111);
            this.NumUpDwn_CantidadMovida.Name = "NumUpDwn_CantidadMovida";
            this.NumUpDwn_CantidadMovida.Size = new System.Drawing.Size(120, 26);
            this.NumUpDwn_CantidadMovida.TabIndex = 17;
            // 
            // Frm_Encabezado_Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_LIMPIAR_ENCABEZADO);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.GB_Detalle);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.Btn_Agregar_Movimiento);
            this.Controls.Add(this.GB_ENCABEZADO);
            this.Name = "Frm_Encabezado_Transaccion";
            this.Text = "Frm_Encabezado_Transaccion";
            this.GB_Detalle.ResumeLayout(false);
            this.GB_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).EndInit();
            this.GB_ENCABEZADO.ResumeLayout(false);
            this.GB_ENCABEZADO.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwn_CantidadMovida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_LIMPIAR_ENCABEZADO;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.GroupBox GB_Detalle;
        private System.Windows.Forms.Button BTN_LIMPIAR_DETALE;
        private System.Windows.Forms.Button Btn_Remover_Detalle;
        private System.Windows.Forms.Button Btn_Agregar_Detalle;
        private System.Windows.Forms.DataGridView DGV_DETALLE_MOVIMIENTO;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button Btn_Agregar_Movimiento;
        private System.Windows.Forms.GroupBox GB_ENCABEZADO;
        private System.Windows.Forms.ComboBox Cbo_Id_Movimiento;
        private System.Windows.Forms.DateTimePicker DTP_FECHA_Movimiento;
        private System.Windows.Forms.ComboBox CBO_ID_Tipo_Movimiento;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.Label Lbl_Fecha_Movimiento;
        private System.Windows.Forms.Label Lbl_ID_TipoMovimiento;
        private System.Windows.Forms.Label Lbl_IDMovInv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_ID_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.NumericUpDown NumUpDwn_CantidadMovida;
    }
}