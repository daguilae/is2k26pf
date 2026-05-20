
namespace Capa_Vista_Asignacion
{
    partial class Frm_Bitacora_Asignaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bitacora_Asignaciones));
            this.Lbl_Titulo_Bitacora = new System.Windows.Forms.Label();
            this.Dgv_Citas_Empleado = new System.Windows.Forms.DataGridView();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Citas_Empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Titulo_Bitacora
            // 
            this.Lbl_Titulo_Bitacora.AutoSize = true;
            this.Lbl_Titulo_Bitacora.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo_Bitacora.Location = new System.Drawing.Point(43, 37);
            this.Lbl_Titulo_Bitacora.Name = "Lbl_Titulo_Bitacora";
            this.Lbl_Titulo_Bitacora.Size = new System.Drawing.Size(391, 38);
            this.Lbl_Titulo_Bitacora.TabIndex = 1;
            this.Lbl_Titulo_Bitacora.Text = "Bitácora de Asignaciones";
            // 
            // Dgv_Citas_Empleado
            // 
            this.Dgv_Citas_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Citas_Empleado.Location = new System.Drawing.Point(52, 110);
            this.Dgv_Citas_Empleado.Name = "Dgv_Citas_Empleado";
            this.Dgv_Citas_Empleado.RowHeadersWidth = 51;
            this.Dgv_Citas_Empleado.RowTemplate.Height = 24;
            this.Dgv_Citas_Empleado.Size = new System.Drawing.Size(753, 330);
            this.Dgv_Citas_Empleado.TabIndex = 2;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(757, 28);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(48, 46);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.White;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar.Image")));
            this.Btn_Modificar.Location = new System.Drawing.Point(698, 28);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(53, 46);
            this.Btn_Modificar.TabIndex = 14;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Frm_Bitacora_Asignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 477);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Dgv_Citas_Empleado);
            this.Controls.Add(this.Lbl_Titulo_Bitacora);
            this.Name = "Frm_Bitacora_Asignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Bitacora_Asignaciones";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Citas_Empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo_Bitacora;
        private System.Windows.Forms.DataGridView Dgv_Citas_Empleado;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Modificar;
    }
}