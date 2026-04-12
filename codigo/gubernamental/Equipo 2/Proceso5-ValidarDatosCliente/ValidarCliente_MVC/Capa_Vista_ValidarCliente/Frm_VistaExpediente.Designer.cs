
namespace Capa_Vista_ValidarCliente
{
    partial class Frm_VistaExpediente
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
            this.Pnl_Botones = new System.Windows.Forms.Panel();
            this.Lbl_TituloExpediente = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Dgv_Expediente = new System.Windows.Forms.DataGridView();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Pnl_Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Expediente)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Botones
            // 
            this.Pnl_Botones.Controls.Add(this.Btn_Ingresar);
            this.Pnl_Botones.Controls.Add(this.Btn_Editar);
            this.Pnl_Botones.Controls.Add(this.Lbl_TituloExpediente);
            this.Pnl_Botones.Controls.Add(this.Btn_Borrar);
            this.Pnl_Botones.Controls.Add(this.Btn_Filtrar);
            this.Pnl_Botones.Controls.Add(this.Btn_Imprimir);
            this.Pnl_Botones.Controls.Add(this.Btn_Salir);
            this.Pnl_Botones.Controls.Add(this.Btn_Refrescar);
            this.Pnl_Botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Botones.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Botones.Name = "Pnl_Botones";
            this.Pnl_Botones.Size = new System.Drawing.Size(1206, 147);
            this.Pnl_Botones.TabIndex = 16;
            // 
            // Lbl_TituloExpediente
            // 
            this.Lbl_TituloExpediente.AutoSize = true;
            this.Lbl_TituloExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloExpediente.Location = new System.Drawing.Point(904, 57);
            this.Lbl_TituloExpediente.Name = "Lbl_TituloExpediente";
            this.Lbl_TituloExpediente.Size = new System.Drawing.Size(198, 24);
            this.Lbl_TituloExpediente.TabIndex = 9;
            this.Lbl_TituloExpediente.Text = "Expediente Clientes";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_salir;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(713, 33);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(100, 77);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            // 
            // Dgv_Expediente
            // 
            this.Dgv_Expediente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Expediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Expediente.Location = new System.Drawing.Point(0, 163);
            this.Dgv_Expediente.Name = "Dgv_Expediente";
            this.Dgv_Expediente.RowHeadersWidth = 51;
            this.Dgv_Expediente.RowTemplate.Height = 24;
            this.Dgv_Expediente.Size = new System.Drawing.Size(1206, 492);
            this.Dgv_Expediente.TabIndex = 17;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_agregar;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(10, 33);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(116, 77);
            this.Btn_Ingresar.TabIndex = 1;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_modificar;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(132, 33);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(109, 77);
            this.Btn_Editar.TabIndex = 2;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_eliminar;
            this.Btn_Borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Borrar.Location = new System.Drawing.Point(247, 33);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(106, 77);
            this.Btn_Borrar.TabIndex = 3;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Enabled = false;
            this.Btn_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filtrar.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_buscar;
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
            this.Btn_Imprimir.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_imprimir;
            this.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Imprimir.Location = new System.Drawing.Point(489, 33);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(112, 77);
            this.Btn_Imprimir.TabIndex = 4;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_Vista_ValidarCliente.Properties.Resources.icono_refrescar;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(359, 33);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(124, 77);
            this.Btn_Refrescar.TabIndex = 5;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            // 
            // Frm_VistaExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 655);
            this.Controls.Add(this.Dgv_Expediente);
            this.Controls.Add(this.Pnl_Botones);
            this.Name = "Frm_VistaExpediente";
            this.Text = "Frm_VistaExpediente";
            this.Pnl_Botones.ResumeLayout(false);
            this.Pnl_Botones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Expediente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Botones;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Label Lbl_TituloExpediente;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.DataGridView Dgv_Expediente;
    }
}