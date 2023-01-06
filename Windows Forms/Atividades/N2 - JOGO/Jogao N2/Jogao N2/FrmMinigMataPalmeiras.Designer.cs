
namespace Jogao_N2 {
    partial class FrmMinigMataPalmeiras {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timerSpawnPalmeiras = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lbJogador = new System.Windows.Forms.Label();
            this.lbPontuacao = new System.Windows.Forms.Label();
            this.lb_game_title = new System.Windows.Forms.Label();
            this.pbLogoPalmeiras = new System.Windows.Forms.PictureBox();
            this.lb_how_to_play = new System.Windows.Forms.Label();
            this.lb_rule_2 = new System.Windows.Forms.Label();
            this.lb_rule_1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbQtdItens = new System.Windows.Forms.Label();
            this.lb_rule_3 = new System.Windows.Forms.Label();
            this.timerSpawnCorinthians = new System.Windows.Forms.Timer(this.components);
            this.pbCorinthians = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPalmeiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorinthians)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSpawnPalmeiras
            // 
            this.timerSpawnPalmeiras.Interval = 1000;
            this.timerSpawnPalmeiras.Tick += new System.EventHandler(this.timerSpawnPalmeiras_Tick);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(327, 358);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(145, 34);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Bora Derrotar o Palmeiras?!";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lbJogador
            // 
            this.lbJogador.AutoSize = true;
            this.lbJogador.BackColor = System.Drawing.Color.Transparent;
            this.lbJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJogador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbJogador.Location = new System.Drawing.Point(12, 9);
            this.lbJogador.Name = "lbJogador";
            this.lbJogador.Size = new System.Drawing.Size(81, 21);
            this.lbJogador.TabIndex = 1;
            this.lbJogador.Text = "Jogador: ";
            this.lbJogador.Click += new System.EventHandler(this.lbJogador_Click);
            // 
            // lbPontuacao
            // 
            this.lbPontuacao.AutoSize = true;
            this.lbPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lbPontuacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPontuacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPontuacao.Location = new System.Drawing.Point(633, 9);
            this.lbPontuacao.Name = "lbPontuacao";
            this.lbPontuacao.Size = new System.Drawing.Size(127, 21);
            this.lbPontuacao.TabIndex = 2;
            this.lbPontuacao.Text = "Pontuação: 000";
            // 
            // lb_game_title
            // 
            this.lb_game_title.AutoSize = true;
            this.lb_game_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_game_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_game_title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_game_title.Location = new System.Drawing.Point(50, 49);
            this.lb_game_title.Name = "lb_game_title";
            this.lb_game_title.Size = new System.Drawing.Size(402, 37);
            this.lb_game_title.TabIndex = 100;
            this.lb_game_title.Text = "Game: Acabe com o Palmeiras";
            // 
            // pbLogoPalmeiras
            // 
            this.pbLogoPalmeiras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogoPalmeiras.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoPalmeiras.BackgroundImage = global::Jogao_N2.Properties.Resources.logo_palmeiras_256;
            this.pbLogoPalmeiras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogoPalmeiras.InitialImage = global::Jogao_N2.Properties.Resources.palmeiras_logo;
            this.pbLogoPalmeiras.Location = new System.Drawing.Point(627, 252);
            this.pbLogoPalmeiras.Name = "pbLogoPalmeiras";
            this.pbLogoPalmeiras.Size = new System.Drawing.Size(133, 140);
            this.pbLogoPalmeiras.TabIndex = 4;
            this.pbLogoPalmeiras.TabStop = false;
            // 
            // lb_how_to_play
            // 
            this.lb_how_to_play.AutoSize = true;
            this.lb_how_to_play.BackColor = System.Drawing.Color.Transparent;
            this.lb_how_to_play.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_how_to_play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_how_to_play.Location = new System.Drawing.Point(52, 85);
            this.lb_how_to_play.Name = "lb_how_to_play";
            this.lb_how_to_play.Size = new System.Drawing.Size(122, 28);
            this.lb_how_to_play.TabIndex = 101;
            this.lb_how_to_play.Text = "Como Jogar:";
            // 
            // lb_rule_2
            // 
            this.lb_rule_2.AutoSize = true;
            this.lb_rule_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_rule_2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rule_2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_rule_2.Location = new System.Drawing.Point(52, 123);
            this.lb_rule_2.Name = "lb_rule_2";
            this.lb_rule_2.Size = new System.Drawing.Size(494, 28);
            this.lb_rule_2.TabIndex = 102;
            this.lb_rule_2.Text = "- Clique nos palmeiras que aparecerem, e extermine-os!";
            // 
            // lb_rule_1
            // 
            this.lb_rule_1.AutoSize = true;
            this.lb_rule_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_rule_1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rule_1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_rule_1.Location = new System.Drawing.Point(52, 151);
            this.lb_rule_1.Name = "lb_rule_1";
            this.lb_rule_1.Size = new System.Drawing.Size(492, 28);
            this.lb_rule_1.TabIndex = 103;
            this.lb_rule_1.Text = "- Não deixe chegar ao Número de 10 Palmeiras em Tela";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(364, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 24);
            this.btnStop.TabIndex = 104;
            this.btnStop.Text = "Pausar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbQtdItens
            // 
            this.lbQtdItens.AutoSize = true;
            this.lbQtdItens.BackColor = System.Drawing.Color.Transparent;
            this.lbQtdItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdItens.ForeColor = System.Drawing.Color.DarkRed;
            this.lbQtdItens.Location = new System.Drawing.Point(3, 431);
            this.lbQtdItens.Name = "lbQtdItens";
            this.lbQtdItens.Size = new System.Drawing.Size(202, 21);
            this.lbQtdItens.TabIndex = 105;
            this.lbQtdItens.Text = "Quantidade de Palmeiras";
            this.lbQtdItens.Visible = false;
            // 
            // lb_rule_3
            // 
            this.lb_rule_3.AutoSize = true;
            this.lb_rule_3.BackColor = System.Drawing.Color.Transparent;
            this.lb_rule_3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rule_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_rule_3.Location = new System.Drawing.Point(52, 184);
            this.lb_rule_3.Name = "lb_rule_3";
            this.lb_rule_3.Size = new System.Drawing.Size(383, 28);
            this.lb_rule_3.TabIndex = 106;
            this.lb_rule_3.Text = "- Não clique nos Corinthians que aparecer!";
            // 
            // timerSpawnCorinthians
            // 
            this.timerSpawnCorinthians.Interval = 1001;
            this.timerSpawnCorinthians.Tick += new System.EventHandler(this.timerSpawnCorinthians_Tick);
            // 
            // pbCorinthians
            // 
            this.pbCorinthians.BackColor = System.Drawing.Color.Transparent;
            this.pbCorinthians.BackgroundImage = global::Jogao_N2.Properties.Resources.logo_corinthians_512;
            this.pbCorinthians.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCorinthians.Location = new System.Drawing.Point(637, 49);
            this.pbCorinthians.Name = "pbCorinthians";
            this.pbCorinthians.Size = new System.Drawing.Size(123, 102);
            this.pbCorinthians.TabIndex = 107;
            this.pbCorinthians.TabStop = false;
            this.pbCorinthians.Visible = false;
            // 
            // FrmMinigMataPalmeiras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogao_N2.Properties.Resources.img_fundo_minig_palmeiras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pbCorinthians);
            this.Controls.Add(this.lb_rule_3);
            this.Controls.Add(this.lbQtdItens);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lb_rule_1);
            this.Controls.Add(this.lb_rule_2);
            this.Controls.Add(this.lb_how_to_play);
            this.Controls.Add(this.pbLogoPalmeiras);
            this.Controls.Add(this.lb_game_title);
            this.Controls.Add(this.lbPontuacao);
            this.Controls.Add(this.lbJogador);
            this.Controls.Add(this.btnStartGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMinigMataPalmeiras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minigame: Mata-Palmeiras";
            this.Load += new System.EventHandler(this.FrmMinigMataPalmeiras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPalmeiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorinthians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSpawnPalmeiras;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lbJogador;
        private System.Windows.Forms.Label lbPontuacao;
        private System.Windows.Forms.Label lb_game_title;
        private System.Windows.Forms.PictureBox pbLogoPalmeiras;
        private System.Windows.Forms.Label lb_how_to_play;
        private System.Windows.Forms.Label lb_rule_2;
        private System.Windows.Forms.Label lb_rule_1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbQtdItens;
        private System.Windows.Forms.Label lb_rule_3;
        private System.Windows.Forms.Timer timerSpawnCorinthians;
        private System.Windows.Forms.PictureBox pbCorinthians;
    }
}