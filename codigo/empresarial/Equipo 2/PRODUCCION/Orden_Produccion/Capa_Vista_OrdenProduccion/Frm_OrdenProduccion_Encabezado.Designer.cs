
namespace Capa_Vista_OrdenProduccion
{
    partial class Frm_OrdenProduccion_Encabezado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdenProduccion_Encabezado));
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Dgv_EncabezadoOrdenP = new System.Windows.Forms.DataGridView();
            this.Pnl_Titulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_fin = new System.Windows.Forms.Button();
            this.Btn_sig = new System.Windows.Forms.Button();
            this.Btn_anterior = new System.Windows.Forms.Button();
            this.Btn_inicio = new System.Windows.Forms.Button();
            this.Pnl_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_EncabezadoOrdenP)).BeginInit();
            this.Pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.Controls.Add(this.Btn_fin);
            this.Pnl_Botones.Controls.Add(this.Btn_Ingresar);
            this.Pnl_Botones.Controls.Add(this.Btn_Editar);
            this.Pnl_Botones.Controls.Add(this.Btn_sig);
            this.Pnl_Botones.Controls.Add(this.Btn_Borrar);
            this.Pnl_Botones.Controls.Add(this.Btn_Filtrar);
            this.Pnl_Botones.Controls.Add(this.Btn_anterior);
            this.Pnl_Botones.Controls.Add(this.Btn_Imprimir);
            this.Pnl_Botones.Controls.Add(this.Btn_inicio);
            this.Pnl_Botones.Controls.Add(this.Btn_Salir);
            this.Pnl_Botones.Controls.Add(this.Btn_Refrescar);
            this.Pnl_Botones.Location = new System.Drawing.Point(0, 70);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(1366, 143);
            this.Pnl_Botones.TabIndex = 16;
            this.Pnl_Botones.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Botones_Paint);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_agregar;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(10, 33);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(116, 77);
            this.Btn_Ingresar.TabIndex = 1;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_modificar;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(132, 33);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(109, 77);
            this.Btn_Editar.TabIndex = 2;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_eliminar;
            this.Btn_Borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Borrar.Location = new System.Drawing.Point(247, 33);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(106, 77);
            this.Btn_Borrar.TabIndex = 3;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Enabled = false;
            this.Btn_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filtrar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_buscar;
            this.Btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Filtrar.Location = new System.Drawing.Point(607, 33);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(100, 77);
            this.Btn_Filtrar.TabIndex = 7;
            this.Btn_Filtrar.Text = "Filtrar";
            this.Btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Filtrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_imprimir;
            this.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Imprimir.Location = new System.Drawing.Point(489, 33);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(112, 77);
            this.Btn_Imprimir.TabIndex = 4;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_salir;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(1180, 35);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(100, 73);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_Vista_OrdenProduccion.Properties.Resources.icono_refrescar;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(359, 33);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(124, 77);
            this.Btn_Refrescar.TabIndex = 5;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Dgv_EncabezadoOrdenP
            // 
            this.Dgv_EncabezadoOrdenP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_EncabezadoOrdenP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_EncabezadoOrdenP.EnableHeadersVisualStyles = false;
            this.Dgv_EncabezadoOrdenP.Location = new System.Drawing.Point(0, 219);
            this.Dgv_EncabezadoOrdenP.Name = "Dgv_EncabezadoOrdenP";
            this.Dgv_EncabezadoOrdenP.RowHeadersWidth = 51;
            this.Dgv_EncabezadoOrdenP.RowTemplate.Height = 24;
            this.Dgv_EncabezadoOrdenP.Size = new System.Drawing.Size(1366, 480);
            this.Dgv_EncabezadoOrdenP.TabIndex = 17;
            this.Dgv_EncabezadoOrdenP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncabezados_CellDoubleClick);
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl_Titulo.Controls.Add(this.label1);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(1366, 64);
            this.Pnl_Titulo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "730 - Ordenes de Producción - Encabezado";
            // 
            // Btn_fin
            // 
            this.Btn_fin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_fin.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fin.Image")));
            this.Btn_fin.Location = new System.Drawing.Point(1064, 34);
            this.Btn_fin.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_fin.Name = "Btn_fin";
            this.Btn_fin.Size = new System.Drawing.Size(107, 74);
            this.Btn_fin.TabIndex = 39;
            this.Btn_fin.Text = "Fin";
            this.Btn_fin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_fin.UseVisualStyleBackColor = true;
            this.Btn_fin.Click += new System.EventHandler(this.Btn_fin_Click);
            // 
            // Btn_sig
            // 
            this.Btn_sig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sig.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sig.Image")));
            this.Btn_sig.Location = new System.Drawing.Point(948, 34);
            this.Btn_sig.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sig.Name = "Btn_sig";
            this.Btn_sig.Size = new System.Drawing.Size(107, 74);
            this.Btn_sig.TabIndex = 38;
            this.Btn_sig.Text = "Siguiente";
            this.Btn_sig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_sig.UseVisualStyleBackColor = true;
            this.Btn_sig.Click += new System.EventHandler(this.Btn_sig_Click);
            // 
            // Btn_anterior
            // 
            this.Btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_anterior.Image = ((System.Drawing.Image)(resources.GetObject("Btn_anterior.Image")));
            this.Btn_anterior.Location = new System.Drawing.Point(832, 32);
            this.Btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_anterior.Name = "Btn_anterior";
            this.Btn_anterior.Size = new System.Drawing.Size(107, 77);
            this.Btn_anterior.TabIndex = 37;
            this.Btn_anterior.Text = "Anterior";
            this.Btn_anterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_anterior.UseVisualStyleBackColor = true;
            this.Btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // Btn_inicio
            // 
            this.Btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_inicio.Image")));
            this.Btn_inicio.Location = new System.Drawing.Point(713, 32);
            this.Btn_inicio.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_inicio.Name = "Btn_inicio";
            this.Btn_inicio.Size = new System.Drawing.Size(110, 77);
            this.Btn_inicio.TabIndex = 36;
            this.Btn_inicio.Text = "Inicio";
            this.Btn_inicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_inicio.UseVisualStyleBackColor = true;
            this.Btn_inicio.Click += new System.EventHandler(this.Btn_inicio_Click);
            // 
            // Frm_OrdenProduccion_Encabezado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 699);
            this.Controls.Add(this.Pnl_Titulo);
            this.Controls.Add(this.Pnl_Botones);
            this.Controls.Add(this.Dgv_EncabezadoOrdenP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_OrdenProduccion_Encabezado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "730 - Ordenes de Producción";
            this.Load += new System.EventHandler(this.Frm_Ordenes_Encabezados_Load);
            this.Pnl_Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_EncabezadoOrdenP)).EndInit();
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.DataGridView Dgv_EncabezadoOrdenP;
        private System.Windows.Forms.Panel Pnl_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_fin;
        private System.Windows.Forms.Button Btn_sig;
        private System.Windows.Forms.Button Btn_anterior;
        private System.Windows.Forms.Button Btn_inicio;
    }
}