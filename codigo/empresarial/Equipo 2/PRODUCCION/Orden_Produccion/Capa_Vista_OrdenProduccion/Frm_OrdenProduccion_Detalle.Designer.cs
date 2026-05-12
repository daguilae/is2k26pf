
namespace Capa_Vista_OrdenProduccion
{
    partial class Frm_OrdenProduccion_Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdenProduccion_Detalle));
            this.Gpo_Detalle = new System.Windows.Forms.GroupBox();
            this.Txt_CantidadSolicitada = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Lbl_CantidadS = new System.Windows.Forms.Label();
            this.Lbl_CodigoCta = new System.Windows.Forms.Label();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.Gpo_Encabezado = new System.Windows.Forms.GroupBox();
            this.Lbl_FechaEntrega = new System.Windows.Forms.Label();
            this.Dtp_FechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.Cmb_Vendedor = new System.Windows.Forms.ComboBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Vendedor = new System.Windows.Forms.Label();
            this.Lbl_IdOrden = new System.Windows.Forms.Label();
            this.Txt_IDOrden = new System.Windows.Forms.TextBox();
            this.Lbl_FechaEmision = new System.Windows.Forms.Label();
            this.Dtp_FechaEmision = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_DetalleMovimientos = new System.Windows.Forms.Label();
            this.Btn_Quitar = new System.Windows.Forms.Button();
            this.Dgv_DetalleOrdenProduccion = new System.Windows.Forms.DataGridView();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.Lbl_TituloForm = new System.Windows.Forms.Label();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            this.Gpo_Detalle.SuspendLayout();
            this.Gpo_Encabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleOrdenProduccion)).BeginInit();
            this.Pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpo_Detalle
            // 
            this.Gpo_Detalle.Controls.Add(this.Txt_CantidadSolicitada);
            this.Gpo_Detalle.Controls.Add(this.Btn_Aceptar);
            this.Gpo_Detalle.Controls.Add(this.Lbl_CantidadS);
            this.Gpo_Detalle.Controls.Add(this.Lbl_CodigoCta);
            this.Gpo_Detalle.Controls.Add(this.Cmb_Producto);
            this.Gpo_Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Detalle.Location = new System.Drawing.Point(13, 374);
            this.Gpo_Detalle.Name = "Gpo_Detalle";
            this.Gpo_Detalle.Size = new System.Drawing.Size(1031, 115);
            this.Gpo_Detalle.TabIndex = 50;
            this.Gpo_Detalle.TabStop = false;
            this.Gpo_Detalle.Text = "Detalle de la Producción";
            // 
            // Txt_CantidadSolicitada
            // 
            this.Txt_CantidadSolicitada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CantidadSolicitada.Location = new System.Drawing.Point(643, 66);
            this.Txt_CantidadSolicitada.Name = "Txt_CantidadSolicitada";
            this.Txt_CantidadSolicitada.Size = new System.Drawing.Size(212, 27);
            this.Txt_CantidadSolicitada.TabIndex = 33;
            this.Txt_CantidadSolicitada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadSolicitada_KeyPress);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(919, 31);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(100, 62);
            this.Btn_Aceptar.TabIndex = 32;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Lbl_CantidadS
            // 
            this.Lbl_CantidadS.AutoSize = true;
            this.Lbl_CantidadS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CantidadS.Location = new System.Drawing.Point(675, 31);
            this.Lbl_CantidadS.Name = "Lbl_CantidadS";
            this.Lbl_CantidadS.Size = new System.Drawing.Size(153, 20);
            this.Lbl_CantidadS.TabIndex = 21;
            this.Lbl_CantidadS.Text = "Cantidad Solicitada";
            // 
            // Lbl_CodigoCta
            // 
            this.Lbl_CodigoCta.AutoSize = true;
            this.Lbl_CodigoCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoCta.Location = new System.Drawing.Point(266, 31);
            this.Lbl_CodigoCta.Name = "Lbl_CodigoCta";
            this.Lbl_CodigoCta.Size = new System.Drawing.Size(81, 20);
            this.Lbl_CodigoCta.TabIndex = 22;
            this.Lbl_CodigoCta.Text = "Producto ";
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(10, 66);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(603, 28);
            this.Cmb_Producto.TabIndex = 23;
            // 
            // Gpo_Encabezado
            // 
            this.Gpo_Encabezado.Controls.Add(this.Lbl_FechaEntrega);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_FechaEntrega);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_Vendedor);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_Estado);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_Vendedor);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_IdOrden);
            this.Gpo_Encabezado.Controls.Add(this.Txt_IDOrden);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_FechaEmision);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_FechaEmision);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_Estado);
            this.Gpo_Encabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Encabezado.Location = new System.Drawing.Point(14, 182);
            this.Gpo_Encabezado.Name = "Gpo_Encabezado";
            this.Gpo_Encabezado.Size = new System.Drawing.Size(1029, 182);
            this.Gpo_Encabezado.TabIndex = 49;
            this.Gpo_Encabezado.TabStop = false;
            this.Gpo_Encabezado.Text = "Encabezado Poliza";
            // 
            // Lbl_FechaEntrega
            // 
            this.Lbl_FechaEntrega.AutoSize = true;
            this.Lbl_FechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaEntrega.Location = new System.Drawing.Point(365, 98);
            this.Lbl_FechaEntrega.Name = "Lbl_FechaEntrega";
            this.Lbl_FechaEntrega.Size = new System.Drawing.Size(216, 20);
            this.Lbl_FechaEntrega.TabIndex = 38;
            this.Lbl_FechaEntrega.Text = "Fecha Estimada de Entrega";
            // 
            // Dtp_FechaEntrega
            // 
            this.Dtp_FechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaEntrega.Location = new System.Drawing.Point(597, 93);
            this.Dtp_FechaEntrega.Name = "Dtp_FechaEntrega";
            this.Dtp_FechaEntrega.Size = new System.Drawing.Size(366, 27);
            this.Dtp_FechaEntrega.TabIndex = 39;
            // 
            // Cmb_Vendedor
            // 
            this.Cmb_Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Vendedor.FormattingEnabled = true;
            this.Cmb_Vendedor.Location = new System.Drawing.Point(92, 90);
            this.Cmb_Vendedor.Name = "Cmb_Vendedor";
            this.Cmb_Vendedor.Size = new System.Drawing.Size(252, 28);
            this.Cmb_Vendedor.TabIndex = 37;
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(92, 135);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(252, 28);
            this.Cmb_Estado.TabIndex = 36;
            // 
            // Lbl_Vendedor
            // 
            this.Lbl_Vendedor.AutoSize = true;
            this.Lbl_Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Vendedor.Location = new System.Drawing.Point(6, 93);
            this.Lbl_Vendedor.Name = "Lbl_Vendedor";
            this.Lbl_Vendedor.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Vendedor.TabIndex = 34;
            this.Lbl_Vendedor.Text = "Vendedor";
            // 
            // Lbl_IdOrden
            // 
            this.Lbl_IdOrden.AutoSize = true;
            this.Lbl_IdOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IdOrden.Location = new System.Drawing.Point(6, 47);
            this.Lbl_IdOrden.Name = "Lbl_IdOrden";
            this.Lbl_IdOrden.Size = new System.Drawing.Size(55, 20);
            this.Lbl_IdOrden.TabIndex = 26;
            this.Lbl_IdOrden.Text = "Orden";
            // 
            // Txt_IDOrden
            // 
            this.Txt_IDOrden.Enabled = false;
            this.Txt_IDOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IDOrden.Location = new System.Drawing.Point(92, 44);
            this.Txt_IDOrden.Name = "Txt_IDOrden";
            this.Txt_IDOrden.Size = new System.Drawing.Size(252, 27);
            this.Txt_IDOrden.TabIndex = 27;
            // 
            // Lbl_FechaEmision
            // 
            this.Lbl_FechaEmision.AutoSize = true;
            this.Lbl_FechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaEmision.Location = new System.Drawing.Point(365, 47);
            this.Lbl_FechaEmision.Name = "Lbl_FechaEmision";
            this.Lbl_FechaEmision.Size = new System.Drawing.Size(143, 20);
            this.Lbl_FechaEmision.TabIndex = 28;
            this.Lbl_FechaEmision.Text = "Fecha de Emisión";
            // 
            // Dtp_FechaEmision
            // 
            this.Dtp_FechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_FechaEmision.Location = new System.Drawing.Point(597, 44);
            this.Dtp_FechaEmision.Name = "Dtp_FechaEmision";
            this.Dtp_FechaEmision.Size = new System.Drawing.Size(366, 27);
            this.Dtp_FechaEmision.TabIndex = 33;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(6, 143);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Estado.TabIndex = 30;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_DetalleMovimientos
            // 
            this.Lbl_DetalleMovimientos.AutoSize = true;
            this.Lbl_DetalleMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetalleMovimientos.Location = new System.Drawing.Point(19, 497);
            this.Lbl_DetalleMovimientos.Name = "Lbl_DetalleMovimientos";
            this.Lbl_DetalleMovimientos.Size = new System.Drawing.Size(205, 24);
            this.Lbl_DetalleMovimientos.TabIndex = 48;
            this.Lbl_DetalleMovimientos.Text = "Detalle de Movimientos";
            // 
            // Btn_Quitar
            // 
            this.Btn_Quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitar.Location = new System.Drawing.Point(932, 524);
            this.Btn_Quitar.Name = "Btn_Quitar";
            this.Btn_Quitar.Size = new System.Drawing.Size(100, 71);
            this.Btn_Quitar.TabIndex = 47;
            this.Btn_Quitar.Text = "Quitar";
            this.Btn_Quitar.UseVisualStyleBackColor = true;
            this.Btn_Quitar.Click += new System.EventHandler(this.Btn_Quitar_Click);
            // 
            // Dgv_DetalleOrdenProduccion
            // 
            this.Dgv_DetalleOrdenProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleOrdenProduccion.EnableHeadersVisualStyles = false;
            this.Dgv_DetalleOrdenProduccion.Location = new System.Drawing.Point(14, 524);
            this.Dgv_DetalleOrdenProduccion.Name = "Dgv_DetalleOrdenProduccion";
            this.Dgv_DetalleOrdenProduccion.RowHeadersWidth = 51;
            this.Dgv_DetalleOrdenProduccion.RowTemplate.Height = 24;
            this.Dgv_DetalleOrdenProduccion.Size = new System.Drawing.Size(898, 285);
            this.Dgv_DetalleOrdenProduccion.TabIndex = 46;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_salir1;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(708, 82);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(114, 80);
            this.Btn_Salir.TabIndex = 45;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_refrescar1;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(574, 82);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(128, 80);
            this.Btn_Refrescar.TabIndex = 44;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Enabled = false;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_cancelar;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancelar.Location = new System.Drawing.Point(443, 82);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 80);
            this.Btn_Cancelar.TabIndex = 43;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Grabar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_guardar;
            this.Btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Grabar.Location = new System.Drawing.Point(283, 82);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(156, 80);
            this.Btn_Grabar.TabIndex = 42;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_modificar1;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(145, 82);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(132, 80);
            this.Btn_Editar.TabIndex = 41;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Enabled = false;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_agregar1;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(12, 82);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(127, 80);
            this.Btn_Ingresar.TabIndex = 40;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_Titulo.Controls.Add(this.Lbl_TituloForm);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1089, 64);
            this.Pnl_Titulo.TabIndex = 51;
            // 
            // Lbl_TituloForm
            // 
            this.Lbl_TituloForm.AutoSize = true;
            this.Lbl_TituloForm.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloForm.Location = new System.Drawing.Point(23, 18);
            this.Lbl_TituloForm.Name = "Lbl_TituloForm";
            this.Lbl_TituloForm.Size = new System.Drawing.Size(484, 35);
            this.Lbl_TituloForm.TabIndex = 0;
            this.Lbl_TituloForm.Text = "731 - Ordenes de Producción - Detalles";
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Enabled = false;
            this.Btn_Inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.Location = new System.Drawing.Point(932, 648);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(100, 71);
            this.Btn_Inventario.TabIndex = 52;
            this.Btn_Inventario.Text = "Actualizar Inventario";
            this.Btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // Frm_OrdenProduccion_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 823);
            this.Controls.Add(this.Btn_Inventario);
            this.Controls.Add(this.Pnl_Titulo);
            this.Controls.Add(this.Gpo_Detalle);
            this.Controls.Add(this.Gpo_Encabezado);
            this.Controls.Add(this.Lbl_DetalleMovimientos);
            this.Controls.Add(this.Btn_Quitar);
            this.Controls.Add(this.Dgv_DetalleOrdenProduccion);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_OrdenProduccion_Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "731 - Ordenes de Producción - Detalles";
            this.Load += new System.EventHandler(this.Frm_OrdenProduccion_Detalle_Load);
            this.Gpo_Detalle.ResumeLayout(false);
            this.Gpo_Detalle.PerformLayout();
            this.Gpo_Encabezado.ResumeLayout(false);
            this.Gpo_Encabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleOrdenProduccion)).EndInit();
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpo_Detalle;
        private System.Windows.Forms.TextBox Txt_CantidadSolicitada;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label Lbl_CantidadS;
        private System.Windows.Forms.Label Lbl_CodigoCta;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.GroupBox Gpo_Encabezado;
        private System.Windows.Forms.Label Lbl_FechaEntrega;
        private System.Windows.Forms.DateTimePicker Dtp_FechaEntrega;
        private System.Windows.Forms.ComboBox Cmb_Vendedor;
        private System.Windows.Forms.ComboBox Cmb_Estado;
        private System.Windows.Forms.Label Lbl_Vendedor;
        private System.Windows.Forms.Label Lbl_IdOrden;
        private System.Windows.Forms.TextBox Txt_IDOrden;
        private System.Windows.Forms.Label Lbl_FechaEmision;
        private System.Windows.Forms.DateTimePicker Dtp_FechaEmision;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_DetalleMovimientos;
        private System.Windows.Forms.Button Btn_Quitar;
        private System.Windows.Forms.DataGridView Dgv_DetalleOrdenProduccion;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Label Lbl_TituloForm;
        private System.Windows.Forms.Button Btn_Inventario;
    }
}