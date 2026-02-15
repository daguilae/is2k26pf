
namespace Capa_Vista_CheckList_Entrevista
{
    partial class Frm_Preguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Preguntas));
            this.Lbl_Preguntas = new System.Windows.Forms.Label();
            this.DGV_PREGUNTAS_REP = new System.Windows.Forms.DataGridView();
            this.Lbl_Pregunta = new System.Windows.Forms.Label();
            this.Cbo_Pregunta = new System.Windows.Forms.ComboBox();
            this.lbl_nvl_preg = new System.Windows.Forms.Label();
            this.Cbo_Nivel_Pregunta = new System.Windows.Forms.ComboBox();
            this.Btn_Filtrar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PREGUNTAS_REP)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Preguntas
            // 
            this.Lbl_Preguntas.AutoSize = true;
            this.Lbl_Preguntas.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preguntas.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Preguntas.Name = "Lbl_Preguntas";
            this.Lbl_Preguntas.Size = new System.Drawing.Size(124, 27);
            this.Lbl_Preguntas.TabIndex = 1;
            this.Lbl_Preguntas.Text = "Preguntas";
            // 
            // DGV_PREGUNTAS_REP
            // 
            this.DGV_PREGUNTAS_REP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PREGUNTAS_REP.Location = new System.Drawing.Point(12, 82);
            this.DGV_PREGUNTAS_REP.Name = "DGV_PREGUNTAS_REP";
            this.DGV_PREGUNTAS_REP.Size = new System.Drawing.Size(740, 347);
            this.DGV_PREGUNTAS_REP.TabIndex = 2;
            // 
            // Lbl_Pregunta
            // 
            this.Lbl_Pregunta.AutoSize = true;
            this.Lbl_Pregunta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pregunta.Location = new System.Drawing.Point(33, 52);
            this.Lbl_Pregunta.Name = "Lbl_Pregunta";
            this.Lbl_Pregunta.Size = new System.Drawing.Size(79, 16);
            this.Lbl_Pregunta.TabIndex = 3;
            this.Lbl_Pregunta.Text = "Id Pregunta:";
            // 
            // Cbo_Pregunta
            // 
            this.Cbo_Pregunta.FormattingEnabled = true;
            this.Cbo_Pregunta.Location = new System.Drawing.Point(128, 51);
            this.Cbo_Pregunta.Name = "Cbo_Pregunta";
            this.Cbo_Pregunta.Size = new System.Drawing.Size(162, 21);
            this.Cbo_Pregunta.TabIndex = 6;
            // 
            // lbl_nvl_preg
            // 
            this.lbl_nvl_preg.AutoSize = true;
            this.lbl_nvl_preg.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nvl_preg.Location = new System.Drawing.Point(339, 52);
            this.lbl_nvl_preg.Name = "lbl_nvl_preg";
            this.lbl_nvl_preg.Size = new System.Drawing.Size(41, 16);
            this.lbl_nvl_preg.TabIndex = 7;
            this.lbl_nvl_preg.Text = "Nivel:";
            // 
            // Cbo_Nivel_Pregunta
            // 
            this.Cbo_Nivel_Pregunta.FormattingEnabled = true;
            this.Cbo_Nivel_Pregunta.Location = new System.Drawing.Point(386, 52);
            this.Cbo_Nivel_Pregunta.Name = "Cbo_Nivel_Pregunta";
            this.Cbo_Nivel_Pregunta.Size = new System.Drawing.Size(162, 21);
            this.Cbo_Nivel_Pregunta.TabIndex = 8;
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filtrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Filtrar.Image")));
            this.Btn_Filtrar.Location = new System.Drawing.Point(617, 6);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(86, 67);
            this.Btn_Filtrar.TabIndex = 9;
            this.Btn_Filtrar.Text = "FILTRAR";
            this.Btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Filtrar.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(448, 445);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Agregar.TabIndex = 10;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(606, 445);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(135, 48);
            this.Btn_Cancelar.TabIndex = 11;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Frm_Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 505);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Filtrar);
            this.Controls.Add(this.Cbo_Nivel_Pregunta);
            this.Controls.Add(this.lbl_nvl_preg);
            this.Controls.Add(this.Cbo_Pregunta);
            this.Controls.Add(this.Lbl_Pregunta);
            this.Controls.Add(this.DGV_PREGUNTAS_REP);
            this.Controls.Add(this.Lbl_Preguntas);
            this.Name = "Frm_Preguntas";
            this.Text = "Frm_Preguntas";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PREGUNTAS_REP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Preguntas;
        private System.Windows.Forms.DataGridView DGV_PREGUNTAS_REP;
        private System.Windows.Forms.Label Lbl_Pregunta;
        private System.Windows.Forms.ComboBox Cbo_Pregunta;
        private System.Windows.Forms.Label lbl_nvl_preg;
        private System.Windows.Forms.ComboBox Cbo_Nivel_Pregunta;
        private System.Windows.Forms.Button Btn_Filtrar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}