
namespace Capa_Vista_Migracion
{
    partial class Splash
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LbSubtitulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.picGif = new System.Windows.Forms.PictureBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbTitulo.Location = new System.Drawing.Point(150, 27);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(513, 55);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "Sistema De Migración";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 402);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(473, 62);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // LbSubtitulo
            // 
            this.LbSubtitulo.AutoSize = true;
            this.LbSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubtitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbSubtitulo.Location = new System.Drawing.Point(309, 370);
            this.LbSubtitulo.Name = "LbSubtitulo";
            this.LbSubtitulo.Size = new System.Drawing.Size(157, 20);
            this.LbSubtitulo.TabIndex = 3;
            this.LbSubtitulo.Text = "Cargando sistema...";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(587, 425);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(46, 17);
            this.lblPorcentaje.TabIndex = 5;
            this.lblPorcentaje.Text = "label1";
            // 
            // picGif
            // 
            this.picGif.BackColor = System.Drawing.Color.Transparent;
            this.picGif.Image = global::Capa_Vista_Migracion.Properties.Resources.pugpolicia3;
            this.picGif.Location = new System.Drawing.Point(160, 85);
            this.picGif.Name = "picGif";
            this.picGif.Size = new System.Drawing.Size(489, 257);
            this.picGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGif.TabIndex = 1;
            this.picGif.TabStop = false;
            this.picGif.Click += new System.EventHandler(this.picGif_Click);
            // 
            // picFondo
            // 
            this.picFondo.BackColor = System.Drawing.Color.Transparent;
            this.picFondo.BackgroundImage = global::Capa_Vista_Migracion.Properties.Resources.descarga;
            this.picFondo.Location = new System.Drawing.Point(5, 1);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(862, 477);
            this.picFondo.TabIndex = 4;
            this.picFondo.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(870, 478);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.LbSubtitulo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picGif);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.picFondo);
            this.Name = "Splash";
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.picGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.PictureBox picGif;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LbSubtitulo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}