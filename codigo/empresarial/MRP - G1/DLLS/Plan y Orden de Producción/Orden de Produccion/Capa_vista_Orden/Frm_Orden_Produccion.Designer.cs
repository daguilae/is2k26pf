
namespace Capa_vista_Orden
{
    partial class Frm_Orden_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Orden_Produccion));
            this.Lbl_Orden_Produccion = new System.Windows.Forms.Label();
            this.Gpb_Orden = new System.Windows.Forms.GroupBox();
            this.Dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fin = new System.Windows.Forms.Label();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Inicio = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Programada = new System.Windows.Forms.TextBox();
            this.Lbl_Cantidad_Programada = new System.Windows.Forms.Label();
            this.Txt_Id_Orden_Produccion = new System.Windows.Forms.TextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cbo_Material = new System.Windows.Forms.ComboBox();
            this.Lbl_Material = new System.Windows.Forms.Label();
            this.Cbo_Plan_Produccion = new System.Windows.Forms.ComboBox();
            this.Lbl_Plan_Produccion = new System.Windows.Forms.Label();
            this.Lbl_Id_Orden_Produccion = new System.Windows.Forms.Label();
            this.Dgv_Orden_Produccion = new System.Windows.Forms.DataGridView();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Gpb_Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Orden_Produccion)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Orden_Produccion
            // 
            this.Lbl_Orden_Produccion.AutoSize = true;
            this.Lbl_Orden_Produccion.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Produccion.Location = new System.Drawing.Point(14, 155);
            this.Lbl_Orden_Produccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Orden_Produccion.Name = "Lbl_Orden_Produccion";
            this.Lbl_Orden_Produccion.Size = new System.Drawing.Size(266, 29);
            this.Lbl_Orden_Produccion.TabIndex = 0;
            this.Lbl_Orden_Produccion.Text = "Orden de Producción";
            this.Lbl_Orden_Produccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // Gpb_Orden
            // 
            this.Gpb_Orden.Controls.Add(this.Dtp_Fin);
            this.Gpb_Orden.Controls.Add(this.Lbl_Fin);
            this.Gpb_Orden.Controls.Add(this.Dtp_Inicio);
            this.Gpb_Orden.Controls.Add(this.Lbl_Inicio);
            this.Gpb_Orden.Controls.Add(this.Txt_Cantidad_Programada);
            this.Gpb_Orden.Controls.Add(this.Lbl_Cantidad_Programada);
            this.Gpb_Orden.Controls.Add(this.Txt_Id_Orden_Produccion);
            this.Gpb_Orden.Controls.Add(this.Cbo_Estado);
            this.Gpb_Orden.Controls.Add(this.Lbl_Estado);
            this.Gpb_Orden.Controls.Add(this.Cbo_Material);
            this.Gpb_Orden.Controls.Add(this.Lbl_Material);
            this.Gpb_Orden.Controls.Add(this.Cbo_Plan_Produccion);
            this.Gpb_Orden.Controls.Add(this.Lbl_Plan_Produccion);
            this.Gpb_Orden.Controls.Add(this.Lbl_Id_Orden_Produccion);
            this.Gpb_Orden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_Orden.Location = new System.Drawing.Point(19, 208);
            this.Gpb_Orden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_Orden.Name = "Gpb_Orden";
            this.Gpb_Orden.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gpb_Orden.Size = new System.Drawing.Size(1110, 167);
            this.Gpb_Orden.TabIndex = 1;
            this.Gpb_Orden.TabStop = false;
            this.Gpb_Orden.Text = "Datos Orden de Produccion";
            // 
            // Dtp_Fin
            // 
            this.Dtp_Fin.Location = new System.Drawing.Point(753, 48);
            this.Dtp_Fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_Fin.Name = "Dtp_Fin";
            this.Dtp_Fin.Size = new System.Drawing.Size(186, 23);
            this.Dtp_Fin.TabIndex = 14;
            // 
            // Lbl_Fin
            // 
            this.Lbl_Fin.AutoSize = true;
            this.Lbl_Fin.Location = new System.Drawing.Point(750, 29);
            this.Lbl_Fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fin.Name = "Lbl_Fin";
            this.Lbl_Fin.Size = new System.Drawing.Size(70, 17);
            this.Lbl_Fin.TabIndex = 13;
            this.Lbl_Fin.Text = "Fecha Fin";
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.Location = new System.Drawing.Point(492, 120);
            this.Dtp_Inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(186, 23);
            this.Dtp_Inicio.TabIndex = 12;
            // 
            // Lbl_Inicio
            // 
            this.Lbl_Inicio.AutoSize = true;
            this.Lbl_Inicio.Location = new System.Drawing.Point(488, 101);
            this.Lbl_Inicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Inicio.Name = "Lbl_Inicio";
            this.Lbl_Inicio.Size = new System.Drawing.Size(85, 17);
            this.Lbl_Inicio.TabIndex = 11;
            this.Lbl_Inicio.Text = "Fecha Inicio";
            // 
            // Txt_Cantidad_Programada
            // 
            this.Txt_Cantidad_Programada.Location = new System.Drawing.Point(250, 120);
            this.Txt_Cantidad_Programada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Cantidad_Programada.Name = "Txt_Cantidad_Programada";
            this.Txt_Cantidad_Programada.Size = new System.Drawing.Size(186, 23);
            this.Txt_Cantidad_Programada.TabIndex = 10;
            // 
            // Lbl_Cantidad_Programada
            // 
            this.Lbl_Cantidad_Programada.AutoSize = true;
            this.Lbl_Cantidad_Programada.Location = new System.Drawing.Point(246, 101);
            this.Lbl_Cantidad_Programada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Cantidad_Programada.Name = "Lbl_Cantidad_Programada";
            this.Lbl_Cantidad_Programada.Size = new System.Drawing.Size(150, 17);
            this.Lbl_Cantidad_Programada.TabIndex = 9;
            this.Lbl_Cantidad_Programada.Text = "Cantidad Programada";
            // 
            // Txt_Id_Orden_Produccion
            // 
            this.Txt_Id_Orden_Produccion.Location = new System.Drawing.Point(8, 48);
            this.Txt_Id_Orden_Produccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Id_Orden_Produccion.Name = "Txt_Id_Orden_Produccion";
            this.Txt_Id_Orden_Produccion.Size = new System.Drawing.Size(186, 23);
            this.Txt_Id_Orden_Produccion.TabIndex = 8;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(9, 120);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(186, 25);
            this.Cbo_Estado.TabIndex = 7;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(5, 101);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(174, 17);
            this.Lbl_Estado.TabIndex = 6;
            this.Lbl_Estado.Text = "Estado Orden Produccion";
            this.Lbl_Estado.Click += new System.EventHandler(this.label5_Click);
            // 
            // Cbo_Material
            // 
            this.Cbo_Material.FormattingEnabled = true;
            this.Cbo_Material.Location = new System.Drawing.Point(491, 48);
            this.Cbo_Material.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Material.Name = "Cbo_Material";
            this.Cbo_Material.Size = new System.Drawing.Size(186, 25);
            this.Cbo_Material.TabIndex = 5;
            // 
            // Lbl_Material
            // 
            this.Lbl_Material.AutoSize = true;
            this.Lbl_Material.Location = new System.Drawing.Point(488, 29);
            this.Lbl_Material.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Material.Name = "Lbl_Material";
            this.Lbl_Material.Size = new System.Drawing.Size(60, 17);
            this.Lbl_Material.TabIndex = 4;
            this.Lbl_Material.Text = "Material";
            // 
            // Cbo_Plan_Produccion
            // 
            this.Cbo_Plan_Produccion.FormattingEnabled = true;
            this.Cbo_Plan_Produccion.Location = new System.Drawing.Point(249, 47);
            this.Cbo_Plan_Produccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Plan_Produccion.Name = "Cbo_Plan_Produccion";
            this.Cbo_Plan_Produccion.Size = new System.Drawing.Size(186, 25);
            this.Cbo_Plan_Produccion.TabIndex = 3;
            // 
            // Lbl_Plan_Produccion
            // 
            this.Lbl_Plan_Produccion.AutoSize = true;
            this.Lbl_Plan_Produccion.Location = new System.Drawing.Point(245, 29);
            this.Lbl_Plan_Produccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Plan_Produccion.Name = "Lbl_Plan_Produccion";
            this.Lbl_Plan_Produccion.Size = new System.Drawing.Size(133, 17);
            this.Lbl_Plan_Produccion.TabIndex = 2;
            this.Lbl_Plan_Produccion.Text = "Plan de Produccion";
            // 
            // Lbl_Id_Orden_Produccion
            // 
            this.Lbl_Id_Orden_Produccion.AutoSize = true;
            this.Lbl_Id_Orden_Produccion.Location = new System.Drawing.Point(4, 29);
            this.Lbl_Id_Orden_Produccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Id_Orden_Produccion.Name = "Lbl_Id_Orden_Produccion";
            this.Lbl_Id_Orden_Produccion.Size = new System.Drawing.Size(145, 17);
            this.Lbl_Id_Orden_Produccion.TabIndex = 0;
            this.Lbl_Id_Orden_Produccion.Text = "ID Orden Produccion";
            // 
            // Dgv_Orden_Produccion
            // 
            this.Dgv_Orden_Produccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Orden_Produccion.Location = new System.Drawing.Point(19, 409);
            this.Dgv_Orden_Produccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_Orden_Produccion.Name = "Dgv_Orden_Produccion";
            this.Dgv_Orden_Produccion.RowHeadersWidth = 51;
            this.Dgv_Orden_Produccion.RowTemplate.Height = 24;
            this.Dgv_Orden_Produccion.Size = new System.Drawing.Size(1110, 249);
            this.Dgv_Orden_Produccion.TabIndex = 2;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.Location = new System.Drawing.Point(11, 12);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(74, 87);
            this.Btn_ingresar.TabIndex = 28;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(91, 12);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(74, 87);
            this.Btn_modificar.TabIndex = 29;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(172, 12);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(74, 87);
            this.Btn_guardar.TabIndex = 30;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(252, 12);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(74, 87);
            this.Btn_cancelar.TabIndex = 31;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(332, 12);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(74, 87);
            this.Btn_eliminar.TabIndex = 32;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.Location = new System.Drawing.Point(413, 12);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(74, 87);
            this.Btn_consultar.TabIndex = 33;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_imprimir.Image")));
            this.Btn_imprimir.Location = new System.Drawing.Point(493, 12);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(74, 87);
            this.Btn_imprimir.TabIndex = 34;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.Image")));
            this.Btn_refrescar.Location = new System.Drawing.Point(573, 12);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(74, 87);
            this.Btn_refrescar.TabIndex = 35;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(653, 12);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(74, 87);
            this.Btn_inicio.TabIndex = 36;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(733, 12);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(74, 87);
            this.Btn_anterior.TabIndex = 37;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(814, 12);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(74, 87);
            this.Btn_sig.TabIndex = 38;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(894, 12);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(74, 87);
            this.Btn_fin.TabIndex = 39;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(974, 12);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(74, 87);
            this.Btn_ayuda.TabIndex = 40;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(1055, 12);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(74, 87);
            this.Btn_salir.TabIndex = 41;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1147, 18);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // Frm_Orden_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 669);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Btn_refrescar);
            this.Controls.Add(this.Btn_inicio);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.Btn_sig);
            this.Controls.Add(this.Btn_fin);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dgv_Orden_Produccion);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Gpb_Orden);
            this.Controls.Add(this.Lbl_Orden_Produccion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Orden_Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Produccion";
            this.Load += new System.EventHandler(this.Frm_Orden_Produccion_Load);
            this.Gpb_Orden.ResumeLayout(false);
            this.Gpb_Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Orden_Produccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Orden_Produccion;
        private System.Windows.Forms.GroupBox Gpb_Orden;
        private System.Windows.Forms.ComboBox Cbo_Material;
        private System.Windows.Forms.Label Lbl_Material;
        private System.Windows.Forms.ComboBox Cbo_Plan_Produccion;
        private System.Windows.Forms.Label Lbl_Plan_Produccion;
        private System.Windows.Forms.Label Lbl_Id_Orden_Produccion;
        private System.Windows.Forms.DataGridView Dgv_Orden_Produccion;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.DateTimePicker Dtp_Fin;
        private System.Windows.Forms.Label Lbl_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.Label Lbl_Inicio;
        private System.Windows.Forms.TextBox Txt_Cantidad_Programada;
        private System.Windows.Forms.Label Lbl_Cantidad_Programada;
        private System.Windows.Forms.TextBox Txt_Id_Orden_Produccion;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}