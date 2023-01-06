namespace Jogao_N2
{
    partial class FlappyBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBall));
            this.tmPontuacao = new System.Windows.Forms.Timer(this.components);
            this.imgDefender = new System.Windows.Forms.PictureBox();
            this.imgDefender0 = new System.Windows.Forms.PictureBox();
            this.imgLineBack = new System.Windows.Forms.PictureBox();
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.imgDefender1 = new System.Windows.Forms.PictureBox();
            this.imgLose = new System.Windows.Forms.PictureBox();
            this.imgLineUp = new System.Windows.Forms.PictureBox();
            this.imgDudu = new System.Windows.Forms.PictureBox();
            this.imgBolaRolando = new System.Windows.Forms.PictureBox();
            this.txtComoJogar = new System.Windows.Forms.Label();
            this.txtInstrucao = new System.Windows.Forms.Label();
            this.txtFechar = new System.Windows.Forms.Label();
            this.tmCarregamento = new System.Windows.Forms.Timer(this.components);
            this.imgBound = new System.Windows.Forms.PictureBox();
            this.imgCry = new System.Windows.Forms.PictureBox();
            this.imgGOL = new System.Windows.Forms.PictureBox();
            this.tmColisao = new System.Windows.Forms.Timer(this.components);
            this.tmLose = new System.Windows.Forms.Timer(this.components);
            this.imgWIN = new System.Windows.Forms.PictureBox();
            this.txtWIN = new System.Windows.Forms.Label();
            this.tmJogoPrincipal = new System.Windows.Forms.Timer(this.components);
            this.golcurintia = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefender0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLineBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLineUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDudu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBolaRolando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGOL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golcurintia)).BeginInit();
            this.SuspendLayout();
            // 
            // tmPontuacao
            // 
            this.tmPontuacao.Interval = 50;
            this.tmPontuacao.Tick += new System.EventHandler(this.tmPontuacao_Tick);
            // 
            // imgDefender
            // 
            this.imgDefender.BackColor = System.Drawing.Color.Transparent;
            this.imgDefender.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview1;
            this.imgDefender.Location = new System.Drawing.Point(519, 293);
            this.imgDefender.Name = "imgDefender";
            this.imgDefender.Size = new System.Drawing.Size(69, 133);
            this.imgDefender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDefender.TabIndex = 1;
            this.imgDefender.TabStop = false;
            // 
            // imgDefender0
            // 
            this.imgDefender0.BackColor = System.Drawing.Color.Transparent;
            this.imgDefender0.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview;
            this.imgDefender0.Location = new System.Drawing.Point(37, 19);
            this.imgDefender0.Name = "imgDefender0";
            this.imgDefender0.Size = new System.Drawing.Size(48, 102);
            this.imgDefender0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDefender0.TabIndex = 7;
            this.imgDefender0.TabStop = false;
            // 
            // imgLineBack
            // 
            this.imgLineBack.Image = global::Jogao_N2.Properties.Resources.image;
            this.imgLineBack.Location = new System.Drawing.Point(1, 432);
            this.imgLineBack.Name = "imgLineBack";
            this.imgLineBack.Size = new System.Drawing.Size(599, 16);
            this.imgLineBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLineBack.TabIndex = 3;
            this.imgLineBack.TabStop = false;
            // 
            // imgBall
            // 
            this.imgBall.BackColor = System.Drawing.Color.Transparent;
            this.imgBall.Image = global::Jogao_N2.Properties.Resources.bolasemfundo_removebg_preview;
            this.imgBall.Location = new System.Drawing.Point(37, 332);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(37, 40);
            this.imgBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBall.TabIndex = 2;
            this.imgBall.TabStop = false;
            // 
            // imgDefender1
            // 
            this.imgDefender1.BackColor = System.Drawing.Color.Transparent;
            this.imgDefender1.Image = global::Jogao_N2.Properties.Resources.jogador_removebg_preview1;
            this.imgDefender1.Location = new System.Drawing.Point(301, 135);
            this.imgDefender1.Name = "imgDefender1";
            this.imgDefender1.Size = new System.Drawing.Size(58, 119);
            this.imgDefender1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDefender1.TabIndex = 6;
            this.imgDefender1.TabStop = false;
            // 
            // imgLose
            // 
            this.imgLose.BackColor = System.Drawing.Color.Transparent;
            this.imgLose.Image = global::Jogao_N2.Properties.Resources._200w;
            this.imgLose.Location = new System.Drawing.Point(214, 9);
            this.imgLose.Name = "imgLose";
            this.imgLose.Size = new System.Drawing.Size(191, 147);
            this.imgLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLose.TabIndex = 8;
            this.imgLose.TabStop = false;
            this.imgLose.Visible = false;
            // 
            // imgLineUp
            // 
            this.imgLineUp.Image = global::Jogao_N2.Properties.Resources.image;
            this.imgLineUp.Location = new System.Drawing.Point(1, -1);
            this.imgLineUp.Name = "imgLineUp";
            this.imgLineUp.Size = new System.Drawing.Size(599, 10);
            this.imgLineUp.TabIndex = 10;
            this.imgLineUp.TabStop = false;
            // 
            // imgDudu
            // 
            this.imgDudu.BackColor = System.Drawing.Color.Transparent;
            this.imgDudu.BackgroundImage = global::Jogao_N2.Properties.Resources.gramado_grama_Easy_Resize_com__2_;
            this.imgDudu.Image = global::Jogao_N2.Properties.Resources.dudasv2;
            this.imgDudu.Location = new System.Drawing.Point(1, -1);
            this.imgDudu.Name = "imgDudu";
            this.imgDudu.Size = new System.Drawing.Size(599, 449);
            this.imgDudu.TabIndex = 11;
            this.imgDudu.TabStop = false;
            this.imgDudu.Click += new System.EventHandler(this.imgDudu_Click);
            // 
            // imgBolaRolando
            // 
            this.imgBolaRolando.BackColor = System.Drawing.Color.Transparent;
            this.imgBolaRolando.Image = global::Jogao_N2.Properties.Resources.gif_bola_rolando;
            this.imgBolaRolando.Location = new System.Drawing.Point(116, 322);
            this.imgBolaRolando.Name = "imgBolaRolando";
            this.imgBolaRolando.Size = new System.Drawing.Size(54, 50);
            this.imgBolaRolando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBolaRolando.TabIndex = 12;
            this.imgBolaRolando.TabStop = false;
            // 
            // txtComoJogar
            // 
            this.txtComoJogar.AutoSize = true;
            this.txtComoJogar.BackColor = System.Drawing.Color.Transparent;
            this.txtComoJogar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComoJogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtComoJogar.Location = new System.Drawing.Point(327, 144);
            this.txtComoJogar.Name = "txtComoJogar";
            this.txtComoJogar.Size = new System.Drawing.Size(165, 30);
            this.txtComoJogar.TabIndex = 13;
            this.txtComoJogar.Text = "COMO JOGAR :";
            // 
            // txtInstrucao
            // 
            this.txtInstrucao.AutoSize = true;
            this.txtInstrucao.BackColor = System.Drawing.Color.Transparent;
            this.txtInstrucao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrucao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInstrucao.Location = new System.Drawing.Point(327, 179);
            this.txtInstrucao.Name = "txtInstrucao";
            this.txtInstrucao.Size = new System.Drawing.Size(235, 125);
            this.txtInstrucao.TabIndex = 14;
            this.txtInstrucao.Text = "FlappyBall\r\n\r\n- Aperte Espaço para subir\r\n\r\nE ao final, marque o GOL!\r\n";
            // 
            // txtFechar
            // 
            this.txtFechar.AutoSize = true;
            this.txtFechar.BackColor = System.Drawing.Color.Transparent;
            this.txtFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFechar.Location = new System.Drawing.Point(185, 372);
            this.txtFechar.Name = "txtFechar";
            this.txtFechar.Size = new System.Drawing.Size(193, 21);
            this.txtFechar.TabIndex = 15;
            this.txtFechar.Text = "Clique enter para iniciar";
            // 
            // tmCarregamento
            // 
            this.tmCarregamento.Enabled = true;
            this.tmCarregamento.Interval = 20;
            this.tmCarregamento.Tick += new System.EventHandler(this.tmCarregamento_Tick);
            // 
            // imgBound
            // 
            this.imgBound.Location = new System.Drawing.Point(590, 309);
            this.imgBound.Name = "imgBound";
            this.imgBound.Size = new System.Drawing.Size(10, 63);
            this.imgBound.TabIndex = 16;
            this.imgBound.TabStop = false;
            this.imgBound.Visible = false;
            // 
            // imgCry
            // 
            this.imgCry.BackColor = System.Drawing.Color.Transparent;
            this.imgCry.Image = global::Jogao_N2.Properties.Resources.crying_89;
            this.imgCry.Location = new System.Drawing.Point(237, 162);
            this.imgCry.Name = "imgCry";
            this.imgCry.Size = new System.Drawing.Size(141, 132);
            this.imgCry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCry.TabIndex = 17;
            this.imgCry.TabStop = false;
            this.imgCry.Visible = false;
            // 
            // imgGOL
            // 
            this.imgGOL.BackColor = System.Drawing.Color.Transparent;
            this.imgGOL.Image = global::Jogao_N2.Properties.Resources.Futebol_Trave_de_Futebol_PNG_COMFUNDO_removebg_preview;
            this.imgGOL.Location = new System.Drawing.Point(809, 74);
            this.imgGOL.Name = "imgGOL";
            this.imgGOL.Size = new System.Drawing.Size(92, 192);
            this.imgGOL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGOL.TabIndex = 18;
            this.imgGOL.TabStop = false;
            // 
            // tmColisao
            // 
            this.tmColisao.Enabled = true;
            this.tmColisao.Interval = 20;
            this.tmColisao.Tick += new System.EventHandler(this.tmColisao_Tick);
            // 
            // tmLose
            // 
            this.tmLose.Interval = 1000;
            this.tmLose.Tick += new System.EventHandler(this.tmLose_Tick);
            // 
            // imgWIN
            // 
            this.imgWIN.BackColor = System.Drawing.Color.Transparent;
            this.imgWIN.Image = global::Jogao_N2.Properties.Resources.Curinthians;
            this.imgWIN.Location = new System.Drawing.Point(91, 29);
            this.imgWIN.Name = "imgWIN";
            this.imgWIN.Size = new System.Drawing.Size(366, 225);
            this.imgWIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgWIN.TabIndex = 19;
            this.imgWIN.TabStop = false;
            this.imgWIN.Visible = false;
            // 
            // txtWIN
            // 
            this.txtWIN.AutoSize = true;
            this.txtWIN.BackColor = System.Drawing.Color.Transparent;
            this.txtWIN.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWIN.Location = new System.Drawing.Point(136, 293);
            this.txtWIN.Name = "txtWIN";
            this.txtWIN.Size = new System.Drawing.Size(356, 65);
            this.txtWIN.TabIndex = 20;
            this.txtWIN.Text = "GoOoOoOooL!";
            this.txtWIN.Visible = false;
            // 
            // tmJogoPrincipal
            // 
            this.tmJogoPrincipal.Interval = 2000;
            // 
            // golcurintia
            // 
            this.golcurintia.Enabled = true;
            this.golcurintia.Location = new System.Drawing.Point(513, 19);
            this.golcurintia.Name = "golcurintia";
            this.golcurintia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("golcurintia.OcxState")));
            this.golcurintia.Size = new System.Drawing.Size(75, 23);
            this.golcurintia.TabIndex = 21;
            this.golcurintia.Visible = false;
            // 
            // FlappyBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Jogao_N2.Properties.Resources.gramado_grama_Easy_Resize_com__2_;
            this.ClientSize = new System.Drawing.Size(601, 448);
            this.Controls.Add(this.golcurintia);
            this.Controls.Add(this.imgGOL);
            this.Controls.Add(this.imgBolaRolando);
            this.Controls.Add(this.imgDefender);
            this.Controls.Add(this.imgDefender0);
            this.Controls.Add(this.imgBall);
            this.Controls.Add(this.imgDefender1);
            this.Controls.Add(this.imgLineUp);
            this.Controls.Add(this.imgLineBack);
            this.Controls.Add(this.imgDudu);
            this.Controls.Add(this.imgCry);
            this.Controls.Add(this.imgLose);
            this.Controls.Add(this.imgWIN);
            this.Controls.Add(this.txtWIN);
            this.Controls.Add(this.txtInstrucao);
            this.Controls.Add(this.txtComoJogar);
            this.Controls.Add(this.imgBound);
            this.Controls.Add(this.txtFechar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlappyBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBall";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBall_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBall_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgDefender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefender0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLineBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDefender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLineUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDudu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBolaRolando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGOL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golcurintia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgDefender;
        private System.Windows.Forms.PictureBox imgLineBack;
        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.Timer tmPontuacao;
        private System.Windows.Forms.PictureBox imgDefender1;
        private System.Windows.Forms.PictureBox imgDefender0;
        private System.Windows.Forms.PictureBox imgLose;
        private System.Windows.Forms.PictureBox imgLineUp;
        private System.Windows.Forms.PictureBox imgDudu;
        private System.Windows.Forms.PictureBox imgBolaRolando;
        private System.Windows.Forms.Label txtComoJogar;
        private System.Windows.Forms.Label txtInstrucao;
        private System.Windows.Forms.Label txtFechar;
        private System.Windows.Forms.Timer tmCarregamento;
        private System.Windows.Forms.PictureBox imgBound;
        private System.Windows.Forms.PictureBox imgCry;
        private System.Windows.Forms.PictureBox imgGOL;
        private System.Windows.Forms.Timer tmColisao;
        private System.Windows.Forms.Timer tmLose;
        private System.Windows.Forms.PictureBox imgWIN;
        private System.Windows.Forms.Label txtWIN;
        private System.Windows.Forms.Timer tmJogoPrincipal;
        private AxWMPLib.AxWindowsMediaPlayer golcurintia;
    }
}