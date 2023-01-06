namespace Jogo_N2
{
    partial class frmInicio
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
            this.picConfig = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picRanking = new System.Windows.Forms.PictureBox();
            this.picSobre = new System.Windows.Forms.PictureBox();
            this.lnkSobre = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // picConfig
            // 
            this.picConfig.BackColor = System.Drawing.Color.White;
            this.picConfig.Image = global::Jogo_N2.Properties.Resources.iconfinder_Configuration_01_1976051;
            this.picConfig.Location = new System.Drawing.Point(12, 12);
            this.picConfig.Name = "picConfig";
            this.picConfig.Size = new System.Drawing.Size(100, 92);
            this.picConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConfig.TabIndex = 0;
            this.picConfig.TabStop = false;
            this.picConfig.Click += new System.EventHandler(this.picConfig_Click);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.White;
            this.picPlay.Image = global::Jogo_N2.Properties.Resources.iconfinder_play_circle_2561292;
            this.picPlay.Location = new System.Drawing.Point(174, 350);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(100, 87);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlay.TabIndex = 1;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picRanking
            // 
            this.picRanking.BackColor = System.Drawing.Color.White;
            this.picRanking.Image = global::Jogo_N2.Properties.Resources.iconfinder___Leaderboard_7738886;
            this.picRanking.Location = new System.Drawing.Point(12, 350);
            this.picRanking.Name = "picRanking";
            this.picRanking.Size = new System.Drawing.Size(100, 88);
            this.picRanking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRanking.TabIndex = 2;
            this.picRanking.TabStop = false;
            this.picRanking.Click += new System.EventHandler(this.picRanking_Click);
            // 
            // picSobre
            // 
            this.picSobre.BackColor = System.Drawing.Color.White;
            this.picSobre.Image = global::Jogo_N2.Properties.Resources.iconfinder__info__about_information_help_notification_description_4213426;
            this.picSobre.Location = new System.Drawing.Point(329, 358);
            this.picSobre.Name = "picSobre";
            this.picSobre.Size = new System.Drawing.Size(128, 80);
            this.picSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSobre.TabIndex = 4;
            this.picSobre.TabStop = false;
            this.picSobre.Click += new System.EventHandler(this.picSobre_Click);
            // 
            // lnkSobre
            // 
            this.lnkSobre.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkSobre.AutoSize = true;
            this.lnkSobre.BackColor = System.Drawing.Color.LightGray;
            this.lnkSobre.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSobre.LinkColor = System.Drawing.Color.Black;
            this.lnkSobre.Location = new System.Drawing.Point(332, 12);
            this.lnkSobre.Name = "lnkSobre";
            this.lnkSobre.Size = new System.Drawing.Size(125, 28);
            this.lnkSobre.TabIndex = 5;
            this.lnkSobre.TabStop = true;
            this.lnkSobre.Text = "Sobre-Nos";
            this.lnkSobre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSobre_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Placar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jogar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tutorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Musica";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Jogo_N2.Properties.Resources.plano_fundo_preto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkSobre);
            this.Controls.Add(this.picSobre);
            this.Controls.Add(this.picRanking);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picConfig);
            this.DoubleBuffered = true;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picConfig;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picRanking;
        private System.Windows.Forms.PictureBox picSobre;
        private System.Windows.Forms.LinkLabel lnkSobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

