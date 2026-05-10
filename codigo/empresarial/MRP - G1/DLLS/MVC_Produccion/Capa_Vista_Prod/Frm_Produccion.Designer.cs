
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Produccion));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.tabMerma = new System.Windows.Forms.TabPage();
            this.tab_Produccion = new System.Windows.Forms.TabPage();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.BtnEliminarManoObra = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.BtnGuardarManoObra = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.nudCostoHora = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dgvManoObra = new System.Windows.Forms.DataGridView();
            this.tabCostos = new System.Windows.Forms.TabPage();
            this.dgvCostos = new System.Windows.Forms.DataGridView();
            this.Cbo_Orden = new System.Windows.Forms.ComboBox();
            this.Lbl_Costos = new System.Windows.Forms.Label();
            this.Lbl_Orden = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCostosIndirectos = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.BtnEliminarCostoIndirecto = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.BtnGuardarCostoIndirecto = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.dgvCostosIndirectos = new System.Windows.Forms.DataGridView();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Produccion.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).BeginInit();
            this.tabCostos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostos)).BeginInit();
            this.tabCostosIndirectos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostosIndirectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
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
            this.panel4.Location = new System.Drawing.Point(10, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1283, 625);
            this.panel4.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaterial);
            this.tabControl1.Controls.Add(this.tabMerma);
            this.tabControl1.Controls.Add(this.tabCostosIndirectos);
            this.tabControl1.Controls.Add(this.tab_Produccion);
            this.tabControl1.Controls.Add(this.tabCostos);
            this.tabControl1.Location = new System.Drawing.Point(21, 96);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1245, 523);
            this.tabControl1.TabIndex = 8;
            // 
            // tabMaterial
            // 
            this.tabMaterial.Location = new System.Drawing.Point(4, 22);
            this.tabMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Size = new System.Drawing.Size(1237, 497);
            this.tabMaterial.TabIndex = 3;
            this.tabMaterial.Text = "Consumo de Materiales";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // tabMerma
            // 
            this.tabMerma.Location = new System.Drawing.Point(4, 22);
            this.tabMerma.Margin = new System.Windows.Forms.Padding(2);
            this.tabMerma.Name = "tabMerma";
            this.tabMerma.Padding = new System.Windows.Forms.Padding(2);
            this.tabMerma.Size = new System.Drawing.Size(1237, 497);
            this.tabMerma.TabIndex = 2;
            this.tabMerma.Text = "Mermas";
            this.tabMerma.UseVisualStyleBackColor = true;
            // 
            // tab_Produccion
            // 
            this.tab_Produccion.Controls.Add(this.cboEmpleado);
            this.tab_Produccion.Controls.Add(this.panel5);
            this.tab_Produccion.Controls.Add(this.nudCostoHora);
            this.tab_Produccion.Controls.Add(this.label2);
            this.tab_Produccion.Controls.Add(this.nudHoras);
            this.tab_Produccion.Controls.Add(this.label1);
            this.tab_Produccion.Controls.Add(this.lblEmpleado);
            this.tab_Produccion.Controls.Add(this.dgvManoObra);
            this.tab_Produccion.Location = new System.Drawing.Point(4, 22);
            this.tab_Produccion.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Produccion.Name = "tab_Produccion";
            this.tab_Produccion.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Produccion.Size = new System.Drawing.Size(1237, 497);
            this.tab_Produccion.TabIndex = 0;
            this.tab_Produccion.Text = "Mano de Obra";
            this.tab_Produccion.UseVisualStyleBackColor = true;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(86, 131);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(92, 21);
            this.cboEmpleado.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn_salir);
            this.panel5.Controls.Add(this.Btn_ayuda);
            this.panel5.Controls.Add(this.Btn_fin);
            this.panel5.Controls.Add(this.Btn_sig);
            this.panel5.Controls.Add(this.Btn_anterior);
            this.panel5.Controls.Add(this.Btn_inicio);
            this.panel5.Controls.Add(this.Btn_refrescar);
            this.panel5.Controls.Add(this.Btn_imprimir);
            this.panel5.Controls.Add(this.Btn_consultar);
            this.panel5.Controls.Add(this.BtnEliminarManoObra);
            this.panel5.Controls.Add(this.Btn_cancelar);
            this.panel5.Controls.Add(this.BtnGuardarManoObra);
            this.panel5.Controls.Add(this.Btn_modificar);
            this.panel5.Controls.Add(this.Btn_ingresar);
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1224, 100);
            this.panel5.TabIndex = 8;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(1113, 14);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(89, 72);
            this.Btn_salir.TabIndex = 13;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(1020, 14);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(89, 72);
            this.Btn_ayuda.TabIndex = 12;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(940, 14);
            this.Btn_fin.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(76, 72);
            this.Btn_fin.TabIndex = 11;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(856, 14);
            this.Btn_sig.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(80, 72);
            this.Btn_sig.TabIndex = 10;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(786, 14);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(66, 72);
            this.Btn_anterior.TabIndex = 9;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(712, 14);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(70, 72);
            this.Btn_inicio.TabIndex = 8;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.Image")));
            this.Btn_refrescar.Location = new System.Drawing.Point(619, 14);
            this.Btn_refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(89, 72);
            this.Btn_refrescar.TabIndex = 7;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_imprimir.Image")));
            this.Btn_imprimir.Location = new System.Drawing.Point(526, 14);
            this.Btn_imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(89, 72);
            this.Btn_imprimir.TabIndex = 6;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.Location = new System.Drawing.Point(444, 14);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(80, 72);
            this.Btn_consultar.TabIndex = 5;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarManoObra
            // 
            this.BtnEliminarManoObra.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarManoObra.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarManoObra.Image")));
            this.BtnEliminarManoObra.Location = new System.Drawing.Point(368, 14);
            this.BtnEliminarManoObra.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarManoObra.Name = "BtnEliminarManoObra";
            this.BtnEliminarManoObra.Size = new System.Drawing.Size(72, 72);
            this.BtnEliminarManoObra.TabIndex = 4;
            this.BtnEliminarManoObra.Text = "Eliminar";
            this.BtnEliminarManoObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarManoObra.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(275, 14);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(89, 72);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarManoObra
            // 
            this.BtnGuardarManoObra.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarManoObra.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarManoObra.Image")));
            this.BtnGuardarManoObra.Location = new System.Drawing.Point(191, 14);
            this.BtnGuardarManoObra.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarManoObra.Name = "BtnGuardarManoObra";
            this.BtnGuardarManoObra.Size = new System.Drawing.Size(80, 72);
            this.BtnGuardarManoObra.TabIndex = 2;
            this.BtnGuardarManoObra.Text = "Guardar";
            this.BtnGuardarManoObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarManoObra.UseVisualStyleBackColor = true;
            this.BtnGuardarManoObra.Click += new System.EventHandler(this.BtnGuardarManoObra_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Enabled = false;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(98, 14);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(89, 72);
            this.Btn_modificar.TabIndex = 1;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.Location = new System.Drawing.Point(5, 14);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(89, 72);
            this.Btn_ingresar.TabIndex = 0;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // nudCostoHora
            // 
            this.nudCostoHora.Location = new System.Drawing.Point(393, 131);
            this.nudCostoHora.Margin = new System.Windows.Forms.Padding(2);
            this.nudCostoHora.Name = "nudCostoHora";
            this.nudCostoHora.Size = new System.Drawing.Size(90, 20);
            this.nudCostoHora.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo Hora";
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(224, 134);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(2);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(90, 20);
            this.nudHoras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horas";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(29, 133);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // dgvManoObra
            // 
            this.dgvManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManoObra.Location = new System.Drawing.Point(9, 158);
            this.dgvManoObra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvManoObra.Name = "dgvManoObra";
            this.dgvManoObra.RowTemplate.Height = 24;
            this.dgvManoObra.Size = new System.Drawing.Size(1207, 327);
            this.dgvManoObra.TabIndex = 0;
            // 
            // tabCostos
            // 
            this.tabCostos.Controls.Add(this.dgvCostos);
            this.tabCostos.Location = new System.Drawing.Point(4, 22);
            this.tabCostos.Margin = new System.Windows.Forms.Padding(2);
            this.tabCostos.Name = "tabCostos";
            this.tabCostos.Padding = new System.Windows.Forms.Padding(2);
            this.tabCostos.Size = new System.Drawing.Size(1237, 497);
            this.tabCostos.TabIndex = 1;
            this.tabCostos.Text = "Costos de Producción";
            this.tabCostos.UseVisualStyleBackColor = true;
            // 
            // dgvCostos
            // 
            this.dgvCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostos.Location = new System.Drawing.Point(14, 15);
            this.dgvCostos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCostos.Name = "dgvCostos";
            this.dgvCostos.RowTemplate.Height = 24;
            this.dgvCostos.Size = new System.Drawing.Size(1207, 461);
            this.dgvCostos.TabIndex = 0;
            // 
            // Cbo_Orden
            // 
            this.Cbo_Orden.FormattingEnabled = true;
            this.Cbo_Orden.Location = new System.Drawing.Point(126, 71);
            this.Cbo_Orden.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Orden.Name = "Cbo_Orden";
            this.Cbo_Orden.Size = new System.Drawing.Size(100, 21);
            this.Cbo_Orden.TabIndex = 19;
            this.Cbo_Orden.SelectedIndexChanged += new System.EventHandler(this.Cbo_Orden_SelectedIndexChanged);
            // 
            // Lbl_Costos
            // 
            this.Lbl_Costos.AutoSize = true;
            this.Lbl_Costos.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Costos.Location = new System.Drawing.Point(17, 11);
            this.Lbl_Costos.Name = "Lbl_Costos";
            this.Lbl_Costos.Size = new System.Drawing.Size(269, 29);
            this.Lbl_Costos.TabIndex = 11;
            this.Lbl_Costos.Text = "Costos de Producción";
            // 
            // Lbl_Orden
            // 
            this.Lbl_Orden.AutoSize = true;
            this.Lbl_Orden.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden.Location = new System.Drawing.Point(21, 72);
            this.Lbl_Orden.Name = "Lbl_Orden";
            this.Lbl_Orden.Size = new System.Drawing.Size(87, 19);
            this.Lbl_Orden.TabIndex = 18;
            this.Lbl_Orden.Text = "Orden No:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 11);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // tabCostosIndirectos
            // 
            this.tabCostosIndirectos.Controls.Add(this.label10);
            this.tabCostosIndirectos.Controls.Add(this.label9);
            this.tabCostosIndirectos.Controls.Add(this.label8);
            this.tabCostosIndirectos.Controls.Add(this.txtDescripcion);
            this.tabCostosIndirectos.Controls.Add(this.nudMonto);
            this.tabCostosIndirectos.Controls.Add(this.txtConcepto);
            this.tabCostosIndirectos.Controls.Add(this.dgvCostosIndirectos);
            this.tabCostosIndirectos.Controls.Add(this.panel1);
            this.tabCostosIndirectos.Location = new System.Drawing.Point(4, 22);
            this.tabCostosIndirectos.Name = "tabCostosIndirectos";
            this.tabCostosIndirectos.Size = new System.Drawing.Size(1237, 497);
            this.tabCostosIndirectos.TabIndex = 4;
            this.tabCostosIndirectos.Text = "Costos Indirectos";
            this.tabCostosIndirectos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.BtnEliminarCostoIndirecto);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.BtnGuardarCostoIndirecto);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 100);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1113, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 72);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1020, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 72);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ayuda";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(940, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 72);
            this.button3.TabIndex = 11;
            this.button3.Text = "Fin";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(856, 14);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 72);
            this.button4.TabIndex = 10;
            this.button4.Text = "Siguiente";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(786, 14);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 72);
            this.button5.TabIndex = 9;
            this.button5.Text = "Anterior";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(712, 14);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 72);
            this.button6.TabIndex = 8;
            this.button6.Text = "Inicio";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(619, 14);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 72);
            this.button7.TabIndex = 7;
            this.button7.Text = "Refrescar";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(526, 14);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 72);
            this.button8.TabIndex = 6;
            this.button8.Text = "Imprimir";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(444, 14);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 72);
            this.button9.TabIndex = 5;
            this.button9.Text = "Consultar";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarCostoIndirecto
            // 
            this.BtnEliminarCostoIndirecto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCostoIndirecto.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCostoIndirecto.Image")));
            this.BtnEliminarCostoIndirecto.Location = new System.Drawing.Point(368, 14);
            this.BtnEliminarCostoIndirecto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarCostoIndirecto.Name = "BtnEliminarCostoIndirecto";
            this.BtnEliminarCostoIndirecto.Size = new System.Drawing.Size(72, 72);
            this.BtnEliminarCostoIndirecto.TabIndex = 4;
            this.BtnEliminarCostoIndirecto.Text = "Eliminar";
            this.BtnEliminarCostoIndirecto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarCostoIndirecto.UseVisualStyleBackColor = true;
            this.BtnEliminarCostoIndirecto.Click += new System.EventHandler(this.BtnEliminarCostoIndirecto_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(275, 14);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(89, 72);
            this.button11.TabIndex = 3;
            this.button11.Text = "Cancelar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarCostoIndirecto
            // 
            this.BtnGuardarCostoIndirecto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCostoIndirecto.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarCostoIndirecto.Image")));
            this.BtnGuardarCostoIndirecto.Location = new System.Drawing.Point(191, 14);
            this.BtnGuardarCostoIndirecto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardarCostoIndirecto.Name = "BtnGuardarCostoIndirecto";
            this.BtnGuardarCostoIndirecto.Size = new System.Drawing.Size(80, 72);
            this.BtnGuardarCostoIndirecto.TabIndex = 2;
            this.BtnGuardarCostoIndirecto.Text = "Guardar";
            this.BtnGuardarCostoIndirecto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardarCostoIndirecto.UseVisualStyleBackColor = true;
            this.BtnGuardarCostoIndirecto.Click += new System.EventHandler(this.BtnGuardarCostoIndirecto_Click);
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.Location = new System.Drawing.Point(98, 14);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 72);
            this.button13.TabIndex = 1;
            this.button13.Text = "Modificar";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.Location = new System.Drawing.Point(5, 14);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 72);
            this.button14.TabIndex = 0;
            this.button14.Text = "Ingresar";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // dgvCostosIndirectos
            // 
            this.dgvCostosIndirectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostosIndirectos.Location = new System.Drawing.Point(9, 222);
            this.dgvCostosIndirectos.Name = "dgvCostosIndirectos";
            this.dgvCostosIndirectos.Size = new System.Drawing.Size(1217, 261);
            this.dgvCostosIndirectos.TabIndex = 10;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(76, 131);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(159, 20);
            this.txtConcepto.TabIndex = 11;
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(307, 135);
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(120, 20);
            this.nudMonto.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(543, 135);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Concepto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Monto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descripción";
            // 
            // Frm_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 648);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Produccion";
            this.Text = "Frm_Produccion";
            this.Load += new System.EventHandler(this.Frm_Prod_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Produccion.ResumeLayout(false);
            this.tab_Produccion.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).EndInit();
            this.tabCostos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostos)).EndInit();
            this.tabCostosIndirectos.ResumeLayout(false);
            this.tabCostosIndirectos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostosIndirectos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvManoObra;
        private System.Windows.Forms.DataGridView dgvCostos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.NumericUpDown nudCostoHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button BtnEliminarManoObra;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button BtnGuardarManoObra;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.TabPage tabCostosIndirectos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button BtnEliminarCostoIndirecto;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button BtnGuardarCostoIndirecto;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.DataGridView dgvCostosIndirectos;
    }
}