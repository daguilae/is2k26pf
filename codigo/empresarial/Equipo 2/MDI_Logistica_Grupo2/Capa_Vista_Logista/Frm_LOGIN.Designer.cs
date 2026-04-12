
namespace Capa_Vista_Logista
{
    partial class Frm_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LOGIN));
            this.Lbl_Migracion = new System.Windows.Forms.Label();
            this.Gbp_Campos = new System.Windows.Forms.GroupBox();
            this.Chk_MostrarContrasena = new System.Windows.Forms.CheckBox();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Btn_InicarSesion = new System.Windows.Forms.Button();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Pcb_Imgane = new System.Windows.Forms.PictureBox();
            this.Gbp_Campos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Imgane)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Migracion
            // 
            this.Lbl_Migracion.AutoSize = true;
            this.Lbl_Migracion.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Migracion.Location = new System.Drawing.Point(465, 53);
            this.Lbl_Migracion.Name = "Lbl_Migracion";
            this.Lbl_Migracion.Size = new System.Drawing.Size(92, 22);
            this.Lbl_Migracion.TabIndex = 50;
            this.Lbl_Migracion.Text = "Logística";
            // 
            // Gbp_Campos
            // 
            this.Gbp_Campos.Controls.Add(this.Chk_MostrarContrasena);
            this.Gbp_Campos.Controls.Add(this.Lbl_Contraseña);
            this.Gbp_Campos.Controls.Add(this.Lbl_Usuario);
            this.Gbp_Campos.Controls.Add(this.Btn_InicarSesion);
            this.Gbp_Campos.Controls.Add(this.Txt_Contraseña);
            this.Gbp_Campos.Controls.Add(this.Txt_Usuario);
            this.Gbp_Campos.Location = new System.Drawing.Point(104, 117);
            this.Gbp_Campos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gbp_Campos.Name = "Gbp_Campos";
            this.Gbp_Campos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Gbp_Campos.Size = new System.Drawing.Size(599, 338);
            this.Gbp_Campos.TabIndex = 49;
            this.Gbp_Campos.TabStop = false;
            // 
            // Chk_MostrarContrasena
            // 
            this.Chk_MostrarContrasena.AutoSize = true;
            this.Chk_MostrarContrasena.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Chk_MostrarContrasena.Location = new System.Drawing.Point(436, 103);
            this.Chk_MostrarContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chk_MostrarContrasena.Name = "Chk_MostrarContrasena";
            this.Chk_MostrarContrasena.Size = new System.Drawing.Size(118, 44);
            this.Chk_MostrarContrasena.TabIndex = 46;
            this.Chk_MostrarContrasena.Text = "mostrar\r\ncontraseña";
            this.Chk_MostrarContrasena.UseVisualStyleBackColor = true;
            this.Chk_MostrarContrasena.CheckedChanged += new System.EventHandler(this.Chk_MostrarContrasena_CheckedChanged);
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Contraseña.Location = new System.Drawing.Point(11, 114);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Contraseña.TabIndex = 45;
            this.Lbl_Contraseña.Text = "Contraseña:";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Lbl_Usuario.Location = new System.Drawing.Point(40, 54);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(75, 20);
            this.Lbl_Usuario.TabIndex = 44;
            this.Lbl_Usuario.Text = "Usuario:";
            // 
            // Btn_InicarSesion
            // 
            this.Btn_InicarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(88)))));
            this.Btn_InicarSesion.FlatAppearance.BorderSize = 0;
            this.Btn_InicarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_InicarSesion.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Btn_InicarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
            this.Btn_InicarSesion.Location = new System.Drawing.Point(197, 202);
            this.Btn_InicarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_InicarSesion.Name = "Btn_InicarSesion";
            this.Btn_InicarSesion.Size = new System.Drawing.Size(141, 48);
            this.Btn_InicarSesion.TabIndex = 43;
            this.Btn_InicarSesion.Text = "Iniciar Sesión";
            this.Btn_InicarSesion.UseVisualStyleBackColor = false;
            this.Btn_InicarSesion.Click += new System.EventHandler(this.Btn_InicarSesion_Click);
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Contraseña.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Contraseña.Location = new System.Drawing.Point(137, 108);
            this.Txt_Contraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.Size = new System.Drawing.Size(293, 27);
            this.Txt_Contraseña.TabIndex = 41;
            this.Txt_Contraseña.UseSystemPasswordChar = true;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.Txt_Usuario.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Txt_Usuario.Location = new System.Drawing.Point(137, 54);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(293, 27);
            this.Txt_Usuario.TabIndex = 40;
            // 
            // Pcb_Imgane
            // 
            this.Pcb_Imgane.Image = ((System.Drawing.Image)(resources.GetObject("Pcb_Imgane.Image")));
            this.Pcb_Imgane.Location = new System.Drawing.Point(719, 135);
            this.Pcb_Imgane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pcb_Imgane.Name = "Pcb_Imgane";
            this.Pcb_Imgane.Size = new System.Drawing.Size(249, 299);
            this.Pcb_Imgane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pcb_Imgane.TabIndex = 48;
            this.Pcb_Imgane.TabStop = false;
            // 
            // Frm_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Lbl_Migracion);
            this.Controls.Add(this.Gbp_Campos);
            this.Controls.Add(this.Pcb_Imgane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_LOGIN";
            this.Text = "Login";
            this.Gbp_Campos.ResumeLayout(false);
            this.Gbp_Campos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Imgane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Migracion;
        private System.Windows.Forms.GroupBox Gbp_Campos;
        private System.Windows.Forms.CheckBox Chk_MostrarContrasena;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Button Btn_InicarSesion;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.PictureBox Pcb_Imgane;
    }
}