namespace N2_Jogo
{
    partial class frTelaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTelaInicial));
            this.lblConfig = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblRecordes = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.wmpMusicaLogin = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblMiniJogos = new System.Windows.Forms.Label();
            this.timerLigaMusica = new System.Windows.Forms.Timer(this.components);
            this.timerDesligaMusica = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusicaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.Location = new System.Drawing.Point(501, 351);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(166, 24);
            this.lblConfig.TabIndex = 29;
            this.lblConfig.Text = "Configurações";
            this.lblConfig.Click += new System.EventHandler(this.lblConfig_Click_1);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(549, 518);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(58, 24);
            this.lblSair.TabIndex = 27;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click_1);
            // 
            // lblRecordes
            // 
            this.lblRecordes.AutoSize = true;
            this.lblRecordes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordes.Location = new System.Drawing.Point(531, 459);
            this.lblRecordes.Name = "lblRecordes";
            this.lblRecordes.Size = new System.Drawing.Size(106, 24);
            this.lblRecordes.TabIndex = 26;
            this.lblRecordes.Text = "Recordes";
            this.lblRecordes.Click += new System.EventHandler(this.lblRecordes_Click_1);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(549, 297);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(70, 24);
            this.lblAjuda.TabIndex = 25;
            this.lblAjuda.Text = "Ajuda";
            this.lblAjuda.Click += new System.EventHandler(this.lblAjuda_Click_1);
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(549, 405);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(70, 24);
            this.lblSobre.TabIndex = 24;
            this.lblSobre.Text = "Sobre";
            this.lblSobre.Click += new System.EventHandler(this.lblSobre_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Defensors Vs Aliens";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(549, 243);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(70, 24);
            this.lblLogin.TabIndex = 22;
            this.lblLogin.Text = "Jogar";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click_1);
            // 
            // wmpMusicaLogin
            // 
            this.wmpMusicaLogin.Enabled = true;
            this.wmpMusicaLogin.Location = new System.Drawing.Point(1108, 12);
            this.wmpMusicaLogin.Name = "wmpMusicaLogin";
            this.wmpMusicaLogin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusicaLogin.OcxState")));
            this.wmpMusicaLogin.Size = new System.Drawing.Size(35, 35);
            this.wmpMusicaLogin.TabIndex = 30;
            this.wmpMusicaLogin.Visible = false;
            // 
            // lblMiniJogos
            // 
            this.lblMiniJogos.AutoSize = true;
            this.lblMiniJogos.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniJogos.Location = new System.Drawing.Point(12, 9);
            this.lblMiniJogos.Name = "lblMiniJogos";
            this.lblMiniJogos.Size = new System.Drawing.Size(94, 24);
            this.lblMiniJogos.TabIndex = 31;
            this.lblMiniJogos.Text = "+ Jogos";
            this.lblMiniJogos.Click += new System.EventHandler(this.lblMiniJogos_Click);
            // 
            // timerLigaMusica
            // 
            this.timerLigaMusica.Interval = 10;
            this.timerLigaMusica.Tick += new System.EventHandler(this.timerLigaMusica_Tick);
            // 
            // timerDesligaMusica
            // 
            this.timerDesligaMusica.Interval = 10;
            this.timerDesligaMusica.Tick += new System.EventHandler(this.timerDesligaMusica_Tick);
            // 
            // frTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1155, 611);
            this.Controls.Add(this.lblMiniJogos);
            this.Controls.Add(this.wmpMusicaLogin);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblRecordes);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.lblSobre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frTelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defensors Vs Aliens";
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusicaLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblRecordes;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusicaLogin;
        private System.Windows.Forms.Label lblMiniJogos;
        private System.Windows.Forms.Timer timerLigaMusica;
        private System.Windows.Forms.Timer timerDesligaMusica;
    }
}

