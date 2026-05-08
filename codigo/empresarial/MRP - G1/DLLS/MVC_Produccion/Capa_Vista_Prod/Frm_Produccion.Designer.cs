
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
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCostoMermas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCostoIndirecto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCostoManoObra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCostoMateriales = new System.Windows.Forms.Label();
            this.dgvCostos = new System.Windows.Forms.DataGridView();
            this.Cbo_Orden = new System.Windows.Forms.ComboBox();
            this.Lbl_Costos = new System.Windows.Forms.Label();
            this.Lbl_Orden = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Produccion.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).BeginInit();
            this.tabCostos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostos)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(1209, 621);
            this.panel4.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMaterial);
            this.tabControl1.Controls.Add(this.tabMerma);
            this.tabControl1.Controls.Add(this.tab_Produccion);
            this.tabControl1.Controls.Add(this.tabCostos);
            this.tabControl1.Location = new System.Drawing.Point(28, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1174, 486);
            this.tabControl1.TabIndex = 8;
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
            this.tab_Produccion.Location = new System.Drawing.Point(4, 25);
            this.tab_Produccion.Name = "tab_Produccion";
            this.tab_Produccion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Produccion.Size = new System.Drawing.Size(1166, 457);
            this.tab_Produccion.TabIndex = 0;
            this.tab_Produccion.Text = "Mano de Obra";
            this.tab_Produccion.UseVisualStyleBackColor = true;
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
            this.panel5.Location = new System.Drawing.Point(12, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1134, 114);
            this.panel5.TabIndex = 8;
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(1043, 3);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(74, 87);
            this.Btn_salir.TabIndex = 13;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(963, 3);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(74, 87);
            this.Btn_ayuda.TabIndex = 12;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(883, 3);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(74, 87);
            this.Btn_fin.TabIndex = 11;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(803, 3);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(74, 87);
            this.Btn_sig.TabIndex = 10;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(723, 3);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(74, 87);
            this.Btn_anterior.TabIndex = 9;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(643, 3);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(74, 87);
            this.Btn_inicio.TabIndex = 8;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.Image")));
            this.Btn_refrescar.Location = new System.Drawing.Point(563, 3);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(74, 87);
            this.Btn_refrescar.TabIndex = 7;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_imprimir.Image")));
            this.Btn_imprimir.Location = new System.Drawing.Point(483, 3);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(74, 87);
            this.Btn_imprimir.TabIndex = 6;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.Location = new System.Drawing.Point(403, 3);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(74, 87);
            this.Btn_consultar.TabIndex = 5;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarManoObra
            // 
            this.BtnEliminarManoObra.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarManoObra.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarManoObra.Image")));
            this.BtnEliminarManoObra.Location = new System.Drawing.Point(323, 3);
            this.BtnEliminarManoObra.Name = "BtnEliminarManoObra";
            this.BtnEliminarManoObra.Size = new System.Drawing.Size(74, 87);
            this.BtnEliminarManoObra.TabIndex = 4;
            this.BtnEliminarManoObra.Text = "Eliminar";
            this.BtnEliminarManoObra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarManoObra.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(243, 3);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(74, 87);
            this.Btn_cancelar.TabIndex = 3;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardarManoObra
            // 
            this.BtnGuardarManoObra.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarManoObra.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardarManoObra.Image")));
            this.BtnGuardarManoObra.Location = new System.Drawing.Point(163, 3);
            this.BtnGuardarManoObra.Name = "BtnGuardarManoObra";
            this.BtnGuardarManoObra.Size = new System.Drawing.Size(74, 87);
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
            this.Btn_modificar.Location = new System.Drawing.Point(83, 3);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(74, 87);
            this.Btn_modificar.TabIndex = 1;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.Location = new System.Drawing.Point(3, 3);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(74, 87);
            this.Btn_ingresar.TabIndex = 0;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // nudCostoHora
            // 
            this.nudCostoHora.Location = new System.Drawing.Point(500, 175);
            this.nudCostoHora.Name = "nudCostoHora";
            this.nudCostoHora.Size = new System.Drawing.Size(120, 22);
            this.nudCostoHora.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Costo Hora";
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(274, 178);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(120, 22);
            this.nudHoras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Horas";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(15, 177);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(70, 16);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // dgvManoObra
            // 
            this.dgvManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManoObra.Location = new System.Drawing.Point(9, 220);
            this.dgvManoObra.Name = "dgvManoObra";
            this.dgvManoObra.RowTemplate.Height = 24;
            this.dgvManoObra.Size = new System.Drawing.Size(989, 213);
            this.dgvManoObra.TabIndex = 0;
            // 
            // tabCostos
            // 
            this.tabCostos.Controls.Add(this.lblCostoTotal);
            this.tabCostos.Controls.Add(this.label7);
            this.tabCostos.Controls.Add(this.lblCostoMermas);
            this.tabCostos.Controls.Add(this.label6);
            this.tabCostos.Controls.Add(this.lblCostoIndirecto);
            this.tabCostos.Controls.Add(this.label3);
            this.tabCostos.Controls.Add(this.lblCostoManoObra);
            this.tabCostos.Controls.Add(this.label5);
            this.tabCostos.Controls.Add(this.label4);
            this.tabCostos.Controls.Add(this.lblCostoMateriales);
            this.tabCostos.Controls.Add(this.dgvCostos);
            this.tabCostos.Location = new System.Drawing.Point(4, 25);
            this.tabCostos.Name = "tabCostos";
            this.tabCostos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCostos.Size = new System.Drawing.Size(1161, 428);
            this.tabCostos.TabIndex = 1;
            this.tabCostos.Text = "Costos Indirectos";
            this.tabCostos.UseVisualStyleBackColor = true;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(164, 325);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(44, 16);
            this.lblCostoTotal.TabIndex = 10;
            this.lblCostoTotal.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Costo Total";
            // 
            // lblCostoMermas
            // 
            this.lblCostoMermas.AutoSize = true;
            this.lblCostoMermas.Location = new System.Drawing.Point(164, 297);
            this.lblCostoMermas.Name = "lblCostoMermas";
            this.lblCostoMermas.Size = new System.Drawing.Size(44, 16);
            this.lblCostoMermas.TabIndex = 8;
            this.lblCostoMermas.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mermas: ";
            // 
            // lblCostoIndirecto
            // 
            this.lblCostoIndirecto.AutoSize = true;
            this.lblCostoIndirecto.Location = new System.Drawing.Point(164, 270);
            this.lblCostoIndirecto.Name = "lblCostoIndirecto";
            this.lblCostoIndirecto.Size = new System.Drawing.Size(44, 16);
            this.lblCostoIndirecto.TabIndex = 6;
            this.lblCostoIndirecto.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costos Indirectos:";
            // 
            // lblCostoManoObra
            // 
            this.lblCostoManoObra.AutoSize = true;
            this.lblCostoManoObra.Location = new System.Drawing.Point(164, 244);
            this.lblCostoManoObra.Name = "lblCostoManoObra";
            this.lblCostoManoObra.Size = new System.Drawing.Size(44, 16);
            this.lblCostoManoObra.TabIndex = 4;
            this.lblCostoManoObra.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Costo Mano de Obra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Costo Materiales: ";
            // 
            // lblCostoMateriales
            // 
            this.lblCostoMateriales.AutoSize = true;
            this.lblCostoMateriales.Location = new System.Drawing.Point(164, 215);
            this.lblCostoMateriales.Name = "lblCostoMateriales";
            this.lblCostoMateriales.Size = new System.Drawing.Size(44, 16);
            this.lblCostoMateriales.TabIndex = 1;
            this.lblCostoMateriales.Text = "label3";
            // 
            // dgvCostos
            // 
            this.dgvCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCostos.Location = new System.Drawing.Point(19, 18);
            this.dgvCostos.Name = "dgvCostos";
            this.dgvCostos.RowTemplate.Height = 24;
            this.dgvCostos.Size = new System.Drawing.Size(1087, 181);
            this.dgvCostos.TabIndex = 0;
            // 
            // Cbo_Orden
            // 
            this.Cbo_Orden.FormattingEnabled = true;
            this.Cbo_Orden.Location = new System.Drawing.Point(168, 87);
            this.Cbo_Orden.Name = "Cbo_Orden";
            this.Cbo_Orden.Size = new System.Drawing.Size(132, 24);
            this.Cbo_Orden.TabIndex = 19;
            this.Cbo_Orden.SelectedIndexChanged += new System.EventHandler(this.Cbo_Orden_SelectedIndexChanged);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 49);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1013, 14);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(91, 175);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cboEmpleado.TabIndex = 9;
            // 
            // Frm_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 660);
            this.Controls.Add(this.panel4);
            this.Name = "Frm_Produccion";
            this.Text = "Frm_Produccion";
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
            this.tabCostos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCostos)).EndInit();
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
        private System.Windows.Forms.Label lblCostoMateriales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCostoIndirecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCostoManoObra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCostoMermas;
        private System.Windows.Forms.ComboBox cboEmpleado;
    }
}