
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRuta = new System.Windows.Forms.Button();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarSubirBajarVolumen = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.imglFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblimagenes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltituloCancion = new System.Windows.Forms.Label();
            this.panelLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSubirBajarVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.btnRuta);
            this.panelLateral.Controls.Add(this.listBoxMusic);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(2);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(175, 450);
            this.panelLateral.TabIndex = 9;
            this.panelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Music List";
            // 
            // btnRuta
            // 
            this.btnRuta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRuta.BackgroundImage")));
            this.btnRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuta.Location = new System.Drawing.Point(0, 422);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(35, 28);
            this.btnRuta.TabIndex = 13;
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.listBoxMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMusic.ForeColor = System.Drawing.Color.White;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(8, 67);
            this.listBoxMusic.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(157, 338);
            this.listBoxMusic.TabIndex = 12;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.listBoxMusic_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(101)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.lbltituloCancion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(175, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 68);
            this.panel1.TabIndex = 10;
            // 
            // trackBarSubirBajarVolumen
            // 
            this.trackBarSubirBajarVolumen.Location = new System.Drawing.Point(442, 391);
            this.trackBarSubirBajarVolumen.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSubirBajarVolumen.Name = "trackBarSubirBajarVolumen";
            this.trackBarSubirBajarVolumen.Size = new System.Drawing.Size(223, 45);
            this.trackBarSubirBajarVolumen.TabIndex = 11;
            this.trackBarSubirBajarVolumen.Value = 5;
            this.trackBarSubirBajarVolumen.Scroll += new System.EventHandler(this.trackBarSubirBajarVolumen_Scroll);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(370, 391);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(37, 31);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPausa.BackgroundImage")));
            this.btnPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPausa.Location = new System.Drawing.Point(284, 391);
            this.btnPausa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(39, 31);
            this.btnPausa.TabIndex = 5;
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
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
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(36, 31);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // imglFotos
            // 
            this.imglFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFotos.ImageStream")));
            this.imglFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFotos.Images.SetKeyName(0, "tres.jpg");
            this.imglFotos.Images.SetKeyName(1, "cuatro.PNG");
            this.imglFotos.Images.SetKeyName(2, "dos.jpg");
            // 
            // lblimagenes
            // 
            this.lblimagenes.ImageList = this.imglFotos;
            this.lblimagenes.Location = new System.Drawing.Point(281, 97);
            this.lblimagenes.Name = "lblimagenes";
            this.lblimagenes.Size = new System.Drawing.Size(295, 240);
            this.lblimagenes.TabIndex = 12;
            this.lblimagenes.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(649, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "+";
            // 
            // lbltituloCancion
            // 
            this.lbltituloCancion.AutoSize = true;
            this.lbltituloCancion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloCancion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltituloCancion.Location = new System.Drawing.Point(105, 33);
            this.lbltituloCancion.Name = "lbltituloCancion";
            this.lbltituloCancion.Size = new System.Drawing.Size(139, 22);
            this.lbltituloCancion.TabIndex = 16;
            this.lbltituloCancion.Text = "Reproduciendo:";
            this.lbltituloCancion.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblimagenes);
            this.Controls.Add(this.trackBarSubirBajarVolumen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Reproductor de Musica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSubirBajarVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarSubirBajarVolumen;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.ImageList imglFotos;
        private System.Windows.Forms.Label lblimagenes;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltituloCancion;
    }
}

