namespace JogoN2
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnJogar = new System.Windows.Forms.Button();
            this.mpMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.picMusica = new System.Windows.Forms.PictureBox();
            this.picMusicaX = new System.Windows.Forms.PictureBox();
            this.lstRank = new System.Windows.Forms.ListBox();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCheck1_off = new System.Windows.Forms.PictureBox();
            this.picCheck2_off = new System.Windows.Forms.PictureBox();
            this.picCheck3_off = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.picCheck1 = new System.Windows.Forms.PictureBox();
            this.picCheck2 = new System.Windows.Forms.PictureBox();
            this.picCheck3 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mpMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck1_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck2_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck3_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Red;
            this.btnJogar.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(408, 237);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(229, 57);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "<< JOGAR >>";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // mpMusica
            // 
            this.mpMusica.Enabled = true;
            this.mpMusica.Location = new System.Drawing.Point(12, 1);
            this.mpMusica.Name = "mpMusica";
            this.mpMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpMusica.OcxState")));
            this.mpMusica.Size = new System.Drawing.Size(239, 76);
            this.mpMusica.TabIndex = 1;
            this.mpMusica.Visible = false;
            // 
            // picMusica
            // 
            this.picMusica.BackColor = System.Drawing.Color.Transparent;
            this.picMusica.Image = ((System.Drawing.Image)(resources.GetObject("picMusica.Image")));
            this.picMusica.Location = new System.Drawing.Point(741, 12);
            this.picMusica.Name = "picMusica";
            this.picMusica.Size = new System.Drawing.Size(50, 46);
            this.picMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMusica.TabIndex = 2;
            this.picMusica.TabStop = false;
            this.picMusica.Click += new System.EventHandler(this.PicMusica_Click);
            // 
            // picMusicaX
            // 
            this.picMusicaX.BackColor = System.Drawing.Color.Transparent;
            this.picMusicaX.Image = ((System.Drawing.Image)(resources.GetObject("picMusicaX.Image")));
            this.picMusicaX.Location = new System.Drawing.Point(741, 12);
            this.picMusicaX.Name = "picMusicaX";
            this.picMusicaX.Size = new System.Drawing.Size(50, 46);
            this.picMusicaX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMusicaX.TabIndex = 3;
            this.picMusicaX.TabStop = false;
            this.picMusicaX.Visible = false;
            this.picMusicaX.Click += new System.EventHandler(this.PicMusicaX_Click);
            // 
            // lstRank
            // 
            this.lstRank.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRank.FormattingEnabled = true;
            this.lstRank.ItemHeight = 18;
            this.lstRank.Location = new System.Drawing.Point(12, 63);
            this.lstRank.Name = "lstRank";
            this.lstRank.Size = new System.Drawing.Size(239, 364);
            this.lstRank.TabIndex = 4;
            this.lstRank.Click += new System.EventHandler(this.LstRank_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.White;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSobre.Location = new System.Drawing.Point(587, 406);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(99, 25);
            this.btnSobre.TabIndex = 21;
            this.btnSobre.Text = "SOBRE";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.White;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjuda.Location = new System.Drawing.Point(692, 406);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(99, 25);
            this.btnAjuda.TabIndex = 20;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.BtnAjuda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picCheck1_off
            // 
            this.picCheck1_off.BackColor = System.Drawing.Color.Transparent;
            this.picCheck1_off.Image = ((System.Drawing.Image)(resources.GetObject("picCheck1_off.Image")));
            this.picCheck1_off.Location = new System.Drawing.Point(396, 21);
            this.picCheck1_off.Name = "picCheck1_off";
            this.picCheck1_off.Size = new System.Drawing.Size(23, 22);
            this.picCheck1_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck1_off.TabIndex = 11;
            this.picCheck1_off.TabStop = false;
            this.picCheck1_off.Click += new System.EventHandler(this.PicCheck1_off_Click);
            // 
            // picCheck2_off
            // 
            this.picCheck2_off.BackColor = System.Drawing.Color.Transparent;
            this.picCheck2_off.Image = ((System.Drawing.Image)(resources.GetObject("picCheck2_off.Image")));
            this.picCheck2_off.Location = new System.Drawing.Point(541, 20);
            this.picCheck2_off.Name = "picCheck2_off";
            this.picCheck2_off.Size = new System.Drawing.Size(23, 22);
            this.picCheck2_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck2_off.TabIndex = 13;
            this.picCheck2_off.TabStop = false;
            this.picCheck2_off.Click += new System.EventHandler(this.PicCheck2_off_Click);
            // 
            // picCheck3_off
            // 
            this.picCheck3_off.BackColor = System.Drawing.Color.Transparent;
            this.picCheck3_off.Image = ((System.Drawing.Image)(resources.GetObject("picCheck3_off.Image")));
            this.picCheck3_off.Location = new System.Drawing.Point(672, 21);
            this.picCheck3_off.Name = "picCheck3_off";
            this.picCheck3_off.Size = new System.Drawing.Size(23, 22);
            this.picCheck3_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck3_off.TabIndex = 14;
            this.picCheck3_off.TabStop = false;
            this.picCheck3_off.Click += new System.EventHandler(this.PicCheck3_off_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(527, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // txtNickName
            // 
            this.txtNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickName.Location = new System.Drawing.Point(408, 193);
            this.txtNickName.MaxLength = 10;
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(229, 38);
            this.txtNickName.TabIndex = 16;
            // 
            // picCheck1
            // 
            this.picCheck1.BackColor = System.Drawing.Color.Transparent;
            this.picCheck1.Image = ((System.Drawing.Image)(resources.GetObject("picCheck1.Image")));
            this.picCheck1.Location = new System.Drawing.Point(396, 21);
            this.picCheck1.Name = "picCheck1";
            this.picCheck1.Size = new System.Drawing.Size(23, 22);
            this.picCheck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck1.TabIndex = 17;
            this.picCheck1.TabStop = false;
            // 
            // picCheck2
            // 
            this.picCheck2.BackColor = System.Drawing.Color.Transparent;
            this.picCheck2.Image = ((System.Drawing.Image)(resources.GetObject("picCheck2.Image")));
            this.picCheck2.Location = new System.Drawing.Point(541, 21);
            this.picCheck2.Name = "picCheck2";
            this.picCheck2.Size = new System.Drawing.Size(23, 22);
            this.picCheck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck2.TabIndex = 18;
            this.picCheck2.TabStop = false;
            this.picCheck2.Visible = false;
            // 
            // picCheck3
            // 
            this.picCheck3.BackColor = System.Drawing.Color.Transparent;
            this.picCheck3.Image = ((System.Drawing.Image)(resources.GetObject("picCheck3.Image")));
            this.picCheck3.Location = new System.Drawing.Point(672, 21);
            this.picCheck3.Name = "picCheck3";
            this.picCheck3.Size = new System.Drawing.Size(23, 22);
            this.picCheck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCheck3.TabIndex = 19;
            this.picCheck3.TabStop = false;
            this.picCheck3.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(344, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(319, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.picCheck3);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.picCheck2);
            this.Controls.Add(this.picCheck1);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picCheck3_off);
            this.Controls.Add(this.picCheck2_off);
            this.Controls.Add(this.picCheck1_off);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstRank);
            this.Controls.Add(this.picMusica);
            this.Controls.Add(this.picMusicaX);
            this.Controls.Add(this.mpMusica);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.mpMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMusicaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck1_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck2_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck3_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private AxWMPLib.AxWindowsMediaPlayer mpMusica;
        private System.Windows.Forms.PictureBox picMusica;
        private System.Windows.Forms.PictureBox picMusicaX;
        private System.Windows.Forms.ListBox lstRank;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picCheck1_off;
        private System.Windows.Forms.PictureBox picCheck2_off;
        private System.Windows.Forms.PictureBox picCheck3_off;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.PictureBox picCheck1;
        private System.Windows.Forms.PictureBox picCheck2;
        private System.Windows.Forms.PictureBox picCheck3;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

