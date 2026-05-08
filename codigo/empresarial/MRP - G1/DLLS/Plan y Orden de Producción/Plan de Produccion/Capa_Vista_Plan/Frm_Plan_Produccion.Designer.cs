
namespace Capa_Vista_Plan
{
    partial class Frm_Plan_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Plan_Produccion));
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Btn_refrescar = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrdenProduccion = new System.Windows.Forms.TabPage();
            this.Dgv_Orden_Pro = new System.Windows.Forms.DataGridView();
            this.Txt_Fecha_Fin = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Fin = new System.Windows.Forms.Label();
            this.Dtp_Fecha_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha_Inicio = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Programada = new System.Windows.Forms.TextBox();
            this.Cbo_Estado_Orden = new System.Windows.Forms.ComboBox();
            this.Cbo_Material = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado_Orde = new System.Windows.Forms.Label();
            this.Lbl_Cantidad_Programada = new System.Windows.Forms.Label();
            this.Lbl_Material = new System.Windows.Forms.Label();
            this.Btn_Actualizar_Orden = new System.Windows.Forms.Button();
            this.Btn_agregarOrden = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lbl_NombreFase = new System.Windows.Forms.Label();
            this.Cronograma = new System.Windows.Forms.TabPage();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Dtp_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Btn_agregar_fases = new System.Windows.Forms.Button();
            this.Cbo_EstadoFase = new System.Windows.Forms.ComboBox();
            this.Lbl_EstadoFase = new System.Windows.Forms.Label();
            this.Cbo_Empleados = new System.Windows.Forms.ComboBox();
            this.Lbl_Encargado = new System.Windows.Forms.Label();
            this.Txt_CantidadPersonal = new System.Windows.Forms.TextBox();
            this.Lbl_CantidadEmpleados = new System.Windows.Forms.Label();
            this.Cbo_Fases = new System.Windows.Forms.ComboBox();
            this.Lbl_Fase = new System.Windows.Forms.Label();
            this.Cbo_NoOrden = new System.Windows.Forms.ComboBox();
            this.Lbl_NoOrden = new System.Windows.Forms.Label();
            this.Lbl_FechaFin = new System.Windows.Forms.Label();
            this.Lbl_FechaInicio = new System.Windows.Forms.Label();
            this.Txt_ProductoC = new System.Windows.Forms.TextBox();
            this.Lbl_ProductoC = new System.Windows.Forms.Label();
            this.Dgv_Cronograma = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_DescripcionPlan = new System.Windows.Forms.TextBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Cbo_EstadoPlan = new System.Windows.Forms.ComboBox();
            this.Lbl_EstadoPlan = new System.Windows.Forms.Label();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.Cbo_OrdenRecibida = new System.Windows.Forms.ComboBox();
            this.Lbl_Orden = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.OrdenProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Orden_Pro)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.Cronograma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cronograma)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_salir
            // 
            this.Btn_salir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_salir.Image")));
            this.Btn_salir.Location = new System.Drawing.Point(1400, 75);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(99, 107);
            this.Btn_salir.TabIndex = 27;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(1293, 75);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(99, 107);
            this.Btn_ayuda.TabIndex = 26;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_fin
            // 
            this.Btn_fin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(1187, 75);
            this.Btn_fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(99, 107);
            this.Btn_fin.TabIndex = 25;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            // 
            // Btn_sig
            // 
            this.Btn_sig.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(1080, 75);
            this.Btn_sig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(99, 107);
            this.Btn_sig.TabIndex = 24;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(973, 75);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(99, 107);
            this.Btn_anterior.TabIndex = 23;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(867, 75);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(99, 107);
            this.Btn_inicio.TabIndex = 22;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            // 
            // Btn_refrescar
            // 
            this.Btn_refrescar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_refrescar.Image")));
            this.Btn_refrescar.Location = new System.Drawing.Point(760, 75);
            this.Btn_refrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_refrescar.Name = "Btn_refrescar";
            this.Btn_refrescar.Size = new System.Drawing.Size(99, 107);
            this.Btn_refrescar.TabIndex = 21;
            this.Btn_refrescar.Text = "Refrescar";
            this.Btn_refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_imprimir.Image")));
            this.Btn_imprimir.Location = new System.Drawing.Point(653, 75);
            this.Btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(99, 107);
            this.Btn_imprimir.TabIndex = 20;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.Location = new System.Drawing.Point(547, 75);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(99, 107);
            this.Btn_consultar.TabIndex = 19;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.Location = new System.Drawing.Point(440, 75);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(99, 107);
            this.Btn_eliminar.TabIndex = 18;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(333, 75);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(99, 107);
            this.Btn_cancelar.TabIndex = 17;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.Location = new System.Drawing.Point(227, 75);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(99, 107);
            this.Btn_guardar.TabIndex = 16;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Enabled = false;
            this.Btn_modificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.Location = new System.Drawing.Point(120, 75);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(99, 107);
            this.Btn_modificar.TabIndex = 15;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.Location = new System.Drawing.Point(13, 75);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(99, 107);
            this.Btn_ingresar.TabIndex = 14;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 53);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1485, 14);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(12, 16);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(293, 33);
            this.Lbl_Titulo.TabIndex = 29;
            this.Lbl_Titulo.Text = "Plan de Producción ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OrdenProduccion);
            this.tabControl1.Controls.Add(this.Cronograma);
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(387, 201);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 507);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // OrdenProduccion
            // 
            this.OrdenProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrdenProduccion.Controls.Add(this.Dgv_Orden_Pro);
            this.OrdenProduccion.Controls.Add(this.Txt_Fecha_Fin);
            this.OrdenProduccion.Controls.Add(this.Lbl_Fecha_Fin);
            this.OrdenProduccion.Controls.Add(this.Dtp_Fecha_Inicio);
            this.OrdenProduccion.Controls.Add(this.Lbl_Fecha_Inicio);
            this.OrdenProduccion.Controls.Add(this.Txt_Cantidad_Programada);
            this.OrdenProduccion.Controls.Add(this.Cbo_Estado_Orden);
            this.OrdenProduccion.Controls.Add(this.Cbo_Material);
            this.OrdenProduccion.Controls.Add(this.Lbl_Estado_Orde);
            this.OrdenProduccion.Controls.Add(this.Lbl_Cantidad_Programada);
            this.OrdenProduccion.Controls.Add(this.Lbl_Material);
            this.OrdenProduccion.Controls.Add(this.Btn_Actualizar_Orden);
            this.OrdenProduccion.Controls.Add(this.Btn_agregarOrden);
            this.OrdenProduccion.Controls.Add(this.flowLayoutPanel1);
            this.OrdenProduccion.Location = new System.Drawing.Point(4, 29);
            this.OrdenProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdenProduccion.Name = "OrdenProduccion";
            this.OrdenProduccion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdenProduccion.Size = new System.Drawing.Size(1105, 474);
            this.OrdenProduccion.TabIndex = 0;
            this.OrdenProduccion.Text = "Orden de Producción";
            this.OrdenProduccion.UseVisualStyleBackColor = true;
            // 
            // Dgv_Orden_Pro
            // 
            this.Dgv_Orden_Pro.AllowUserToAddRows = false;
            this.Dgv_Orden_Pro.AllowUserToDeleteRows = false;
            this.Dgv_Orden_Pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Orden_Pro.Location = new System.Drawing.Point(9, 213);
            this.Dgv_Orden_Pro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_Orden_Pro.Name = "Dgv_Orden_Pro";
            this.Dgv_Orden_Pro.ReadOnly = true;
            this.Dgv_Orden_Pro.RowHeadersWidth = 51;
            this.Dgv_Orden_Pro.RowTemplate.Height = 24;
            this.Dgv_Orden_Pro.Size = new System.Drawing.Size(1084, 249);
            this.Dgv_Orden_Pro.TabIndex = 53;
            // 
            // Txt_Fecha_Fin
            // 
            this.Txt_Fecha_Fin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_Fecha_Fin.Location = new System.Drawing.Point(560, 166);
            this.Txt_Fecha_Fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Fecha_Fin.Name = "Txt_Fecha_Fin";
            this.Txt_Fecha_Fin.ReadOnly = true;
            this.Txt_Fecha_Fin.Size = new System.Drawing.Size(224, 27);
            this.Txt_Fecha_Fin.TabIndex = 52;
            // 
            // Lbl_Fecha_Fin
            // 
            this.Lbl_Fecha_Fin.AutoSize = true;
            this.Lbl_Fecha_Fin.Location = new System.Drawing.Point(556, 139);
            this.Lbl_Fecha_Fin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Fin.Name = "Lbl_Fecha_Fin";
            this.Lbl_Fecha_Fin.Size = new System.Drawing.Size(84, 20);
            this.Lbl_Fecha_Fin.TabIndex = 51;
            this.Lbl_Fecha_Fin.Text = "Fecha Fin";
            // 
            // Dtp_Fecha_Inicio
            // 
            this.Dtp_Fecha_Inicio.Location = new System.Drawing.Point(280, 164);
            this.Dtp_Fecha_Inicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_Fecha_Inicio.Name = "Dtp_Fecha_Inicio";
            this.Dtp_Fecha_Inicio.Size = new System.Drawing.Size(224, 27);
            this.Dtp_Fecha_Inicio.TabIndex = 50;
            this.Dtp_Fecha_Inicio.ValueChanged += new System.EventHandler(this.Dtp_Fecha_Inicio_ValueChanged);
            // 
            // Lbl_Fecha_Inicio
            // 
            this.Lbl_Fecha_Inicio.AutoSize = true;
            this.Lbl_Fecha_Inicio.Location = new System.Drawing.Point(276, 139);
            this.Lbl_Fecha_Inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Inicio.Name = "Lbl_Fecha_Inicio";
            this.Lbl_Fecha_Inicio.Size = new System.Drawing.Size(104, 20);
            this.Lbl_Fecha_Inicio.TabIndex = 49;
            this.Lbl_Fecha_Inicio.Text = "Fecha Inicio";
            // 
            // Txt_Cantidad_Programada
            // 
            this.Txt_Cantidad_Programada.Location = new System.Drawing.Point(833, 94);
            this.Txt_Cantidad_Programada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Cantidad_Programada.Name = "Txt_Cantidad_Programada";
            this.Txt_Cantidad_Programada.Size = new System.Drawing.Size(224, 27);
            this.Txt_Cantidad_Programada.TabIndex = 48;
            // 
            // Cbo_Estado_Orden
            // 
            this.Cbo_Estado_Orden.FormattingEnabled = true;
            this.Cbo_Estado_Orden.Location = new System.Drawing.Point(560, 94);
            this.Cbo_Estado_Orden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Estado_Orden.Name = "Cbo_Estado_Orden";
            this.Cbo_Estado_Orden.Size = new System.Drawing.Size(224, 28);
            this.Cbo_Estado_Orden.TabIndex = 47;
            // 
            // Cbo_Material
            // 
            this.Cbo_Material.FormattingEnabled = true;
            this.Cbo_Material.Location = new System.Drawing.Point(280, 94);
            this.Cbo_Material.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Material.Name = "Cbo_Material";
            this.Cbo_Material.Size = new System.Drawing.Size(224, 28);
            this.Cbo_Material.TabIndex = 46;
            this.Cbo_Material.SelectedIndexChanged += new System.EventHandler(this.Cbo_Material_SelectedIndexChanged);
            // 
            // Lbl_Estado_Orde
            // 
            this.Lbl_Estado_Orde.AutoSize = true;
            this.Lbl_Estado_Orde.Location = new System.Drawing.Point(556, 73);
            this.Lbl_Estado_Orde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado_Orde.Name = "Lbl_Estado_Orde";
            this.Lbl_Estado_Orde.Size = new System.Drawing.Size(117, 20);
            this.Lbl_Estado_Orde.TabIndex = 45;
            this.Lbl_Estado_Orde.Text = "Estado Orden";
            // 
            // Lbl_Cantidad_Programada
            // 
            this.Lbl_Cantidad_Programada.AutoSize = true;
            this.Lbl_Cantidad_Programada.Location = new System.Drawing.Point(829, 69);
            this.Lbl_Cantidad_Programada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad_Programada.Name = "Lbl_Cantidad_Programada";
            this.Lbl_Cantidad_Programada.Size = new System.Drawing.Size(180, 20);
            this.Lbl_Cantidad_Programada.TabIndex = 44;
            this.Lbl_Cantidad_Programada.Text = "Cantidad Programada";
            // 
            // Lbl_Material
            // 
            this.Lbl_Material.AutoSize = true;
            this.Lbl_Material.Location = new System.Drawing.Point(276, 69);
            this.Lbl_Material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Material.Name = "Lbl_Material";
            this.Lbl_Material.Size = new System.Drawing.Size(74, 20);
            this.Lbl_Material.TabIndex = 43;
            this.Lbl_Material.Text = "Material";
            // 
            // Btn_Actualizar_Orden
            // 
            this.Btn_Actualizar_Orden.Enabled = false;
            this.Btn_Actualizar_Orden.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar_Orden.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar_Orden.Image")));
            this.Btn_Actualizar_Orden.Location = new System.Drawing.Point(117, 69);
            this.Btn_Actualizar_Orden.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_Actualizar_Orden.Name = "Btn_Actualizar_Orden";
            this.Btn_Actualizar_Orden.Size = new System.Drawing.Size(105, 100);
            this.Btn_Actualizar_Orden.TabIndex = 32;
            this.Btn_Actualizar_Orden.Text = "Modificar";
            this.Btn_Actualizar_Orden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Actualizar_Orden.UseVisualStyleBackColor = true;
            // 
            // Btn_agregarOrden
            // 
            this.Btn_agregarOrden.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarOrden.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregarOrden.Image")));
            this.Btn_agregarOrden.Location = new System.Drawing.Point(4, 69);
            this.Btn_agregarOrden.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btn_agregarOrden.Name = "Btn_agregarOrden";
            this.Btn_agregarOrden.Size = new System.Drawing.Size(103, 100);
            this.Btn_agregarOrden.TabIndex = 33;
            this.Btn_agregarOrden.Text = "Ingresar";
            this.Btn_agregarOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_agregarOrden.UseVisualStyleBackColor = true;
            this.Btn_agregarOrden.Click += new System.EventHandler(this.Btn_agregarOrden_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Controls.Add(this.Lbl_NombreFase);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1103, 62);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Lbl_NombreFase
            // 
            this.Lbl_NombreFase.AutoSize = true;
            this.Lbl_NombreFase.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreFase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lbl_NombreFase.Location = new System.Drawing.Point(4, 0);
            this.Lbl_NombreFase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_NombreFase.Name = "Lbl_NombreFase";
            this.Lbl_NombreFase.Size = new System.Drawing.Size(296, 33);
            this.Lbl_NombreFase.TabIndex = 35;
            this.Lbl_NombreFase.Text = "Orden de Producción";
            this.Lbl_NombreFase.Click += new System.EventHandler(this.Lbl_NombreFase_Click);
            // 
            // Cronograma
            // 
            this.Cronograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cronograma.Controls.Add(this.Btn_Actualizar);
            this.Cronograma.Controls.Add(this.Dtp_FechaFin);
            this.Cronograma.Controls.Add(this.Dtp_FechaInicio);
            this.Cronograma.Controls.Add(this.Btn_agregar_fases);
            this.Cronograma.Controls.Add(this.Cbo_EstadoFase);
            this.Cronograma.Controls.Add(this.Lbl_EstadoFase);
            this.Cronograma.Controls.Add(this.Cbo_Empleados);
            this.Cronograma.Controls.Add(this.Lbl_Encargado);
            this.Cronograma.Controls.Add(this.Txt_CantidadPersonal);
            this.Cronograma.Controls.Add(this.Lbl_CantidadEmpleados);
            this.Cronograma.Controls.Add(this.Cbo_Fases);
            this.Cronograma.Controls.Add(this.Lbl_Fase);
            this.Cronograma.Controls.Add(this.Cbo_NoOrden);
            this.Cronograma.Controls.Add(this.Lbl_NoOrden);
            this.Cronograma.Controls.Add(this.Lbl_FechaFin);
            this.Cronograma.Controls.Add(this.Lbl_FechaInicio);
            this.Cronograma.Controls.Add(this.Txt_ProductoC);
            this.Cronograma.Controls.Add(this.Lbl_ProductoC);
            this.Cronograma.Controls.Add(this.Dgv_Cronograma);
            this.Cronograma.Location = new System.Drawing.Point(4, 29);
            this.Cronograma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cronograma.Name = "Cronograma";
            this.Cronograma.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cronograma.Size = new System.Drawing.Size(1105, 474);
            this.Cronograma.TabIndex = 1;
            this.Cronograma.Text = "Cronograma Fases";
            this.Cronograma.UseVisualStyleBackColor = true;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Actualizar.Image")));
            this.Btn_Actualizar.Location = new System.Drawing.Point(8, 92);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(57, 57);
            this.Btn_Actualizar.TabIndex = 31;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // Dtp_FechaFin
            // 
            this.Dtp_FechaFin.CalendarFont = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaFin.Location = new System.Drawing.Point(337, 119);
            this.Dtp_FechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_FechaFin.Name = "Dtp_FechaFin";
            this.Dtp_FechaFin.Size = new System.Drawing.Size(224, 27);
            this.Dtp_FechaFin.TabIndex = 30;
            // 
            // Dtp_FechaInicio
            // 
            this.Dtp_FechaInicio.CalendarFont = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_FechaInicio.Location = new System.Drawing.Point(81, 119);
            this.Dtp_FechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_FechaInicio.Name = "Dtp_FechaInicio";
            this.Dtp_FechaInicio.Size = new System.Drawing.Size(224, 27);
            this.Dtp_FechaInicio.TabIndex = 29;
            // 
            // Btn_agregar_fases
            // 
            this.Btn_agregar_fases.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar_fases.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregar_fases.Image")));
            this.Btn_agregar_fases.Location = new System.Drawing.Point(8, 14);
            this.Btn_agregar_fases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_agregar_fases.Name = "Btn_agregar_fases";
            this.Btn_agregar_fases.Size = new System.Drawing.Size(57, 54);
            this.Btn_agregar_fases.TabIndex = 27;
            this.Btn_agregar_fases.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_agregar_fases.UseVisualStyleBackColor = true;
            this.Btn_agregar_fases.Click += new System.EventHandler(this.Btn_agregar_fases_Click);
            // 
            // Cbo_EstadoFase
            // 
            this.Cbo_EstadoFase.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_EstadoFase.FormattingEnabled = true;
            this.Cbo_EstadoFase.Location = new System.Drawing.Point(827, 119);
            this.Cbo_EstadoFase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_EstadoFase.Name = "Cbo_EstadoFase";
            this.Cbo_EstadoFase.Size = new System.Drawing.Size(224, 28);
            this.Cbo_EstadoFase.TabIndex = 26;
            // 
            // Lbl_EstadoFase
            // 
            this.Lbl_EstadoFase.AutoSize = true;
            this.Lbl_EstadoFase.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EstadoFase.Location = new System.Drawing.Point(823, 92);
            this.Lbl_EstadoFase.Name = "Lbl_EstadoFase";
            this.Lbl_EstadoFase.Size = new System.Drawing.Size(126, 20);
            this.Lbl_EstadoFase.TabIndex = 25;
            this.Lbl_EstadoFase.Text = "Estado de Fase";
            // 
            // Cbo_Empleados
            // 
            this.Cbo_Empleados.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Empleados.FormattingEnabled = true;
            this.Cbo_Empleados.Location = new System.Drawing.Point(827, 42);
            this.Cbo_Empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_Empleados.Name = "Cbo_Empleados";
            this.Cbo_Empleados.Size = new System.Drawing.Size(224, 28);
            this.Cbo_Empleados.TabIndex = 24;
            // 
            // Lbl_Encargado
            // 
            this.Lbl_Encargado.AutoSize = true;
            this.Lbl_Encargado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Encargado.Location = new System.Drawing.Point(823, 15);
            this.Lbl_Encargado.Name = "Lbl_Encargado";
            this.Lbl_Encargado.Size = new System.Drawing.Size(158, 20);
            this.Lbl_Encargado.TabIndex = 23;
            this.Lbl_Encargado.Text = "Encargado de Fase";
            // 
            // Txt_CantidadPersonal
            // 
            this.Txt_CantidadPersonal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_CantidadPersonal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CantidadPersonal.Location = new System.Drawing.Point(584, 119);
            this.Txt_CantidadPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CantidadPersonal.Name = "Txt_CantidadPersonal";
            this.Txt_CantidadPersonal.Size = new System.Drawing.Size(224, 27);
            this.Txt_CantidadPersonal.TabIndex = 22;
            // 
            // Lbl_CantidadEmpleados
            // 
            this.Lbl_CantidadEmpleados.AutoSize = true;
            this.Lbl_CantidadEmpleados.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CantidadEmpleados.Location = new System.Drawing.Point(580, 92);
            this.Lbl_CantidadEmpleados.Name = "Lbl_CantidadEmpleados";
            this.Lbl_CantidadEmpleados.Size = new System.Drawing.Size(177, 20);
            this.Lbl_CantidadEmpleados.TabIndex = 21;
            this.Lbl_CantidadEmpleados.Text = "Cantidad de Personal";
            // 
            // Cbo_Fases
            // 
            this.Cbo_Fases.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Fases.FormattingEnabled = true;
            this.Cbo_Fases.Location = new System.Drawing.Point(584, 42);
            this.Cbo_Fases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_Fases.Name = "Cbo_Fases";
            this.Cbo_Fases.Size = new System.Drawing.Size(224, 28);
            this.Cbo_Fases.TabIndex = 20;
            // 
            // Lbl_Fase
            // 
            this.Lbl_Fase.AutoSize = true;
            this.Lbl_Fase.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fase.Location = new System.Drawing.Point(580, 15);
            this.Lbl_Fase.Name = "Lbl_Fase";
            this.Lbl_Fase.Size = new System.Drawing.Size(171, 20);
            this.Lbl_Fase.TabIndex = 19;
            this.Lbl_Fase.Text = "Fases de Producción";
            // 
            // Cbo_NoOrden
            // 
            this.Cbo_NoOrden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_NoOrden.FormattingEnabled = true;
            this.Cbo_NoOrden.Location = new System.Drawing.Point(81, 42);
            this.Cbo_NoOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_NoOrden.Name = "Cbo_NoOrden";
            this.Cbo_NoOrden.Size = new System.Drawing.Size(224, 28);
            this.Cbo_NoOrden.TabIndex = 18;
            this.Cbo_NoOrden.SelectedIndexChanged += new System.EventHandler(this.Cbo_NoOrden_SelectedIndexChanged);
            // 
            // Lbl_NoOrden
            // 
            this.Lbl_NoOrden.AutoSize = true;
            this.Lbl_NoOrden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoOrden.Location = new System.Drawing.Point(77, 15);
            this.Lbl_NoOrden.Name = "Lbl_NoOrden";
            this.Lbl_NoOrden.Size = new System.Drawing.Size(185, 20);
            this.Lbl_NoOrden.TabIndex = 17;
            this.Lbl_NoOrden.Text = "No. Orden Producción";
            // 
            // Lbl_FechaFin
            // 
            this.Lbl_FechaFin.AutoSize = true;
            this.Lbl_FechaFin.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaFin.Location = new System.Drawing.Point(333, 89);
            this.Lbl_FechaFin.Name = "Lbl_FechaFin";
            this.Lbl_FechaFin.Size = new System.Drawing.Size(162, 20);
            this.Lbl_FechaFin.TabIndex = 15;
            this.Lbl_FechaFin.Text = "Fecha Final de Fase";
            // 
            // Lbl_FechaInicio
            // 
            this.Lbl_FechaInicio.AutoSize = true;
            this.Lbl_FechaInicio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaInicio.Location = new System.Drawing.Point(77, 89);
            this.Lbl_FechaInicio.Name = "Lbl_FechaInicio";
            this.Lbl_FechaInicio.Size = new System.Drawing.Size(168, 20);
            this.Lbl_FechaInicio.TabIndex = 13;
            this.Lbl_FechaInicio.Text = "Fecha Inicio de Fase";
            // 
            // Txt_ProductoC
            // 
            this.Txt_ProductoC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txt_ProductoC.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ProductoC.Location = new System.Drawing.Point(337, 42);
            this.Txt_ProductoC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductoC.Name = "Txt_ProductoC";
            this.Txt_ProductoC.ReadOnly = true;
            this.Txt_ProductoC.Size = new System.Drawing.Size(224, 27);
            this.Txt_ProductoC.TabIndex = 12;
            // 
            // Lbl_ProductoC
            // 
            this.Lbl_ProductoC.AutoSize = true;
            this.Lbl_ProductoC.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProductoC.Location = new System.Drawing.Point(333, 15);
            this.Lbl_ProductoC.Name = "Lbl_ProductoC";
            this.Lbl_ProductoC.Size = new System.Drawing.Size(80, 20);
            this.Lbl_ProductoC.TabIndex = 11;
            this.Lbl_ProductoC.Text = "Producto";
            // 
            // Dgv_Cronograma
            // 
            this.Dgv_Cronograma.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_Cronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cronograma.Location = new System.Drawing.Point(7, 167);
            this.Dgv_Cronograma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_Cronograma.Name = "Dgv_Cronograma";
            this.Dgv_Cronograma.RowHeadersWidth = 51;
            this.Dgv_Cronograma.RowTemplate.Height = 24;
            this.Dgv_Cronograma.Size = new System.Drawing.Size(1077, 295);
            this.Dgv_Cronograma.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 201);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Plan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_DescripcionPlan);
            this.panel1.Controls.Add(this.Lbl_Descripcion);
            this.panel1.Controls.Add(this.Cbo_EstadoPlan);
            this.panel1.Controls.Add(this.Lbl_EstadoPlan);
            this.panel1.Controls.Add(this.Dtp_Fecha);
            this.panel1.Controls.Add(this.Lbl_Fecha);
            this.panel1.Controls.Add(this.Cbo_OrdenRecibida);
            this.panel1.Controls.Add(this.Lbl_Orden);
            this.panel1.Location = new System.Drawing.Point(11, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 503);
            this.panel1.TabIndex = 0;
            // 
            // Txt_DescripcionPlan
            // 
            this.Txt_DescripcionPlan.Location = new System.Drawing.Point(8, 177);
            this.Txt_DescripcionPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_DescripcionPlan.Multiline = true;
            this.Txt_DescripcionPlan.Name = "Txt_DescripcionPlan";
            this.Txt_DescripcionPlan.Size = new System.Drawing.Size(353, 102);
            this.Txt_DescripcionPlan.TabIndex = 11;
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion.Location = new System.Drawing.Point(3, 148);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(176, 20);
            this.Lbl_Descripcion.TabIndex = 10;
            this.Lbl_Descripcion.Text = "Descripción del Plan:";
            // 
            // Cbo_EstadoPlan
            // 
            this.Cbo_EstadoPlan.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_EstadoPlan.FormattingEnabled = true;
            this.Cbo_EstadoPlan.Location = new System.Drawing.Point(7, 342);
            this.Cbo_EstadoPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_EstadoPlan.Name = "Cbo_EstadoPlan";
            this.Cbo_EstadoPlan.Size = new System.Drawing.Size(353, 28);
            this.Cbo_EstadoPlan.TabIndex = 9;
            // 
            // Lbl_EstadoPlan
            // 
            this.Lbl_EstadoPlan.AutoSize = true;
            this.Lbl_EstadoPlan.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EstadoPlan.Location = new System.Drawing.Point(3, 320);
            this.Lbl_EstadoPlan.Name = "Lbl_EstadoPlan";
            this.Lbl_EstadoPlan.Size = new System.Drawing.Size(67, 20);
            this.Lbl_EstadoPlan.TabIndex = 8;
            this.Lbl_EstadoPlan.Text = "Estado:";
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(7, 426);
            this.Dtp_Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(353, 22);
            this.Dtp_Fecha.TabIndex = 7;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.Location = new System.Drawing.Point(3, 402);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(154, 20);
            this.Lbl_Fecha.TabIndex = 6;
            this.Lbl_Fecha.Text = "Fecha de Registro:";
            // 
            // Cbo_OrdenRecibida
            // 
            this.Cbo_OrdenRecibida.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_OrdenRecibida.FormattingEnabled = true;
            this.Cbo_OrdenRecibida.Location = new System.Drawing.Point(7, 101);
            this.Cbo_OrdenRecibida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbo_OrdenRecibida.Name = "Cbo_OrdenRecibida";
            this.Cbo_OrdenRecibida.Size = new System.Drawing.Size(355, 28);
            this.Cbo_OrdenRecibida.TabIndex = 5;
            this.Cbo_OrdenRecibida.SelectedIndexChanged += new System.EventHandler(this.Cbo_OrdenRecibida_SelectedIndexChanged_1);
            // 
            // Lbl_Orden
            // 
            this.Lbl_Orden.AutoSize = true;
            this.Lbl_Orden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden.Location = new System.Drawing.Point(3, 71);
            this.Lbl_Orden.Name = "Lbl_Orden";
            this.Lbl_Orden.Size = new System.Drawing.Size(96, 20);
            this.Lbl_Orden.TabIndex = 4;
            this.Lbl_Orden.Text = "No. Orden:";
            // 
            // Frm_Plan_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_fin);
            this.Controls.Add(this.Btn_sig);
            this.Controls.Add(this.Btn_anterior);
            this.Controls.Add(this.Btn_inicio);
            this.Controls.Add(this.Btn_refrescar);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_ingresar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Plan_Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan y Orden de Produccion - 718";
            this.Load += new System.EventHandler(this.Frm_Plan_Produccion_Load);
            this.tabControl1.ResumeLayout(false);
            this.OrdenProduccion.ResumeLayout(false);
            this.OrdenProduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Orden_Pro)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.Cronograma.ResumeLayout(false);
            this.Cronograma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cronograma)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_inicio;
        private System.Windows.Forms.Button Btn_refrescar;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdenProduccion;
        private System.Windows.Forms.TabPage Cronograma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_DescripcionPlan;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.ComboBox Cbo_EstadoPlan;
        private System.Windows.Forms.Label Lbl_EstadoPlan;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.ComboBox Cbo_OrdenRecibida;
        private System.Windows.Forms.Label Lbl_Orden;
        private System.Windows.Forms.ComboBox Cbo_Fases;
        private System.Windows.Forms.Label Lbl_Fase;
        private System.Windows.Forms.ComboBox Cbo_NoOrden;
        private System.Windows.Forms.Label Lbl_NoOrden;
        private System.Windows.Forms.Label Lbl_FechaFin;
        private System.Windows.Forms.Label Lbl_FechaInicio;
        private System.Windows.Forms.TextBox Txt_ProductoC;
        private System.Windows.Forms.Label Lbl_ProductoC;
        private System.Windows.Forms.DataGridView Dgv_Cronograma;
        private System.Windows.Forms.ComboBox Cbo_EstadoFase;
        private System.Windows.Forms.Label Lbl_EstadoFase;
        private System.Windows.Forms.ComboBox Cbo_Empleados;
        private System.Windows.Forms.Label Lbl_Encargado;
        private System.Windows.Forms.TextBox Txt_CantidadPersonal;
        private System.Windows.Forms.Label Lbl_CantidadEmpleados;
        private System.Windows.Forms.Button Btn_agregar_fases;
        private System.Windows.Forms.DateTimePicker Dtp_FechaFin;
        private System.Windows.Forms.DateTimePicker Dtp_FechaInicio;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Lbl_NombreFase;
        private System.Windows.Forms.DataGridView Dgv_Orden_Pro;
        private System.Windows.Forms.TextBox Txt_Fecha_Fin;
        private System.Windows.Forms.Label Lbl_Fecha_Fin;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Inicio;
        private System.Windows.Forms.Label Lbl_Fecha_Inicio;
        private System.Windows.Forms.TextBox Txt_Cantidad_Programada;
        private System.Windows.Forms.ComboBox Cbo_Estado_Orden;
        private System.Windows.Forms.ComboBox Cbo_Material;
        private System.Windows.Forms.Label Lbl_Estado_Orde;
        private System.Windows.Forms.Label Lbl_Cantidad_Programada;
        private System.Windows.Forms.Label Lbl_Material;
        private System.Windows.Forms.Button Btn_Actualizar_Orden;
        private System.Windows.Forms.Button Btn_agregarOrden;
    }
}