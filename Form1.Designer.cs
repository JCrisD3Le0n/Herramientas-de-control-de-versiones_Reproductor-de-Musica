
namespace Tarea_de_investigacion_ReproductorMusical
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureImageAlbum = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPlay.Location = new System.Drawing.Point(329, 391);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(36, 31);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPausa.BackgroundImage")));
            this.btnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausa.Location = new System.Drawing.Point(284, 391);
            this.btnPausa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(39, 31);
            this.btnPausa.TabIndex = 5;
            this.btnPausa.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(370, 391);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(37, 31);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateral.Controls.Add(this.listBoxMusic);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(167, 450);
            this.panelLateral.TabIndex = 9;
            this.panelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.listBoxMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(6, 120);
            this.listBoxMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(157, 208);
            this.listBoxMusic.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(167, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 68);
            this.panel1.TabIndex = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(409, 391);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(237, 45);
            this.trackBar1.TabIndex = 11;
            // 
            // pictureImageAlbum
            // 
            this.pictureImageAlbum.Image = ((System.Drawing.Image)(resources.GetObject("pictureImageAlbum.Image")));
            this.pictureImageAlbum.Location = new System.Drawing.Point(255, 83);
            this.pictureImageAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureImageAlbum.Name = "pictureImageAlbum";
            this.pictureImageAlbum.Size = new System.Drawing.Size(408, 282);
            this.pictureImageAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImageAlbum.TabIndex = 7;
            this.pictureImageAlbum.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.pictureImageAlbum);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Reproductor de Musica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureImageAlbum;
        private System.Windows.Forms.ListBox listBoxMusic;
    }
}

