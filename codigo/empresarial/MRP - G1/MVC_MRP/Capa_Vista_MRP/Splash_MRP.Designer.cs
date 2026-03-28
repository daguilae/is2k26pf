
namespace Capa_Vista_MRP
{
    partial class Splash_MRP
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
            this.components = new System.ComponentModel.Container();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbSubtitulo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LbTitulo.Location = new System.Drawing.Point(140, 0);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(536, 91);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "Sistema MRP";
            // 
            // LbSubtitulo
            // 
            this.LbSubtitulo.AutoSize = true;
            this.LbSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubtitulo.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.LbSubtitulo.Location = new System.Drawing.Point(338, 91);
            this.LbSubtitulo.Name = "LbSubtitulo";
            this.LbSubtitulo.Size = new System.Drawing.Size(147, 20);
            this.LbSubtitulo.TabIndex = 1;
            this.LbSubtitulo.Text = "Cargando Sistema";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 377);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(727, 33);
            this.progressBar1.TabIndex = 2;
            // 
            // picGif
            // 
            this.picGif.BackColor = System.Drawing.Color.Transparent;
            this.picGif.Image = global::Capa_Vista_MRP.Properties.Resources.gatito_martillando;
            this.picGif.Location = new System.Drawing.Point(209, 119);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(404, 252);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 3;
            this.picGif.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(703, 353);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(46, 17);
            this.lblPorcentaje.TabIndex = 4;
            this.lblPorcentaje.Text = "label1";
            // 
            // Splash_MRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Vista_MRP.Properties.Resources.Fondo_de_Minecraft_para_pc;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.picGif);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LbSubtitulo);
            this.Controls.Add(this.LbTitulo);
            this.Name = "Splash_MRP";
            this.Text = "Splash_MRP";
            this.Load += new System.EventHandler(this.Splash_MRP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbSubtitulo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}