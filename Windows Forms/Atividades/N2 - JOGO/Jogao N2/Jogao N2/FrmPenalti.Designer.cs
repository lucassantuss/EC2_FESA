
namespace Jogao_N2
{
    partial class FrmPenalti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPenalti));
            this.imgGoleiro = new System.Windows.Forms.PictureBox();
            this.imgJogador = new System.Windows.Forms.PictureBox();
            this.imgBola = new System.Windows.Forms.PictureBox();
            this.timerGoleiro = new System.Windows.Forms.Timer(this.components);
            this.timerBola = new System.Windows.Forms.Timer(this.components);
            this.timerMovimento = new System.Windows.Forms.Timer(this.components);
            this.timerBolaEsq = new System.Windows.Forms.Timer(this.components);
            this.timerBolaDir = new System.Windows.Forms.Timer(this.components);
            this.MENSAGEM = new System.Windows.Forms.Label();
            this.timerTexto = new System.Windows.Forms.Timer(this.components);
            this.timerTentativa = new System.Windows.Forms.Timer(this.components);
            this.timerGol = new System.Windows.Forms.Timer(this.components);
            this.contGol = new System.Windows.Forms.Label();
            this.parabens = new System.Windows.Forms.Label();
            this.perdeu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.golcurintia = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.imgGoleiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBola)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.golcurintia)).BeginInit();
            this.SuspendLayout();
            // 
            // imgGoleiro
            // 
            this.imgGoleiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgGoleiro.BackColor = System.Drawing.Color.Transparent;
            this.imgGoleiro.Image = ((System.Drawing.Image)(resources.GetObject("imgGoleiro.Image")));
            this.imgGoleiro.Location = new System.Drawing.Point(180, 116);
            this.imgGoleiro.Name = "imgGoleiro";
            this.imgGoleiro.Size = new System.Drawing.Size(187, 213);
            this.imgGoleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGoleiro.TabIndex = 0;
            this.imgGoleiro.TabStop = false;
            // 
            // imgJogador
            // 
            this.imgJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgJogador.BackColor = System.Drawing.Color.Transparent;
            this.imgJogador.Image = ((System.Drawing.Image)(resources.GetObject("imgJogador.Image")));
            this.imgJogador.Location = new System.Drawing.Point(37, 453);
            this.imgJogador.Name = "imgJogador";
            this.imgJogador.Size = new System.Drawing.Size(182, 255);
            this.imgJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgJogador.TabIndex = 1;
            this.imgJogador.TabStop = false;
            this.imgJogador.Click += new System.EventHandler(this.imgJogador_Click);
            // 
            // imgBola
            // 
            this.imgBola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBola.BackColor = System.Drawing.Color.Transparent;
            this.imgBola.Image = global::Jogao_N2.Properties.Resources.bolasemfundo_removebg_preview;
            this.imgBola.Location = new System.Drawing.Point(225, 615);
            this.imgBola.Name = "imgBola";
            this.imgBola.Size = new System.Drawing.Size(79, 82);
            this.imgBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBola.TabIndex = 2;
            this.imgBola.TabStop = false;
            // 
            // timerGoleiro
            // 
            this.timerGoleiro.Enabled = true;
            this.timerGoleiro.Tick += new System.EventHandler(this.timerGoleiro_Tick);
            // 
            // timerBola
            // 
            this.timerBola.Interval = 1;
            this.timerBola.Tick += new System.EventHandler(this.timerBola_Tick);
            // 
            // timerMovimento
            // 
            this.timerMovimento.Interval = 4;
            this.timerMovimento.Tick += new System.EventHandler(this.timerMovimento_Tick);
            // 
            // timerBolaEsq
            // 
            this.timerBolaEsq.Interval = 1;
            this.timerBolaEsq.Tick += new System.EventHandler(this.timerBolaEsq_Tick);
            // 
            // timerBolaDir
            // 
            this.timerBolaDir.Interval = 1;
            this.timerBolaDir.Tick += new System.EventHandler(this.timerBolaDir_Tick);
            // 
            // MENSAGEM
            // 
            this.MENSAGEM.BackColor = System.Drawing.Color.Transparent;
            this.MENSAGEM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MENSAGEM.Font = new System.Drawing.Font("Abduction2002", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENSAGEM.ForeColor = System.Drawing.Color.Red;
            this.MENSAGEM.Location = new System.Drawing.Point(0, 0);
            this.MENSAGEM.Name = "MENSAGEM";
            this.MENSAGEM.Size = new System.Drawing.Size(540, 60);
            this.MENSAGEM.TabIndex = 3;
            this.MENSAGEM.Text = "MENSAGEM";
            this.MENSAGEM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MENSAGEM.Click += new System.EventHandler(this.MENSAGEM_Click);
            // 
            // timerTexto
            // 
            this.timerTexto.Interval = 3500;
            this.timerTexto.Tick += new System.EventHandler(this.timerTexto_Tick);
            // 
            // timerTentativa
            // 
            this.timerTentativa.Interval = 2000;
            this.timerTentativa.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerGol
            // 
            this.timerGol.Interval = 3000;
            this.timerGol.Tick += new System.EventHandler(this.timerGol_Tick);
            // 
            // contGol
            // 
            this.contGol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contGol.AutoSize = true;
            this.contGol.BackColor = System.Drawing.Color.Transparent;
            this.contGol.Font = new System.Drawing.Font("Abduction2002", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contGol.ForeColor = System.Drawing.Color.Red;
            this.contGol.Location = new System.Drawing.Point(12, 19);
            this.contGol.Name = "contGol";
            this.contGol.Size = new System.Drawing.Size(133, 32);
            this.contGol.TabIndex = 4;
            this.contGol.Text = "GOLS: 0";
            this.contGol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.contGol.Click += new System.EventHandler(this.label1_Click);
            // 
            // parabens
            // 
            this.parabens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parabens.AutoSize = true;
            this.parabens.BackColor = System.Drawing.Color.Transparent;
            this.parabens.Font = new System.Drawing.Font("Abduction2002", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parabens.ForeColor = System.Drawing.Color.Red;
            this.parabens.Location = new System.Drawing.Point(2, 420);
            this.parabens.Name = "parabens";
            this.parabens.Size = new System.Drawing.Size(526, 28);
            this.parabens.TabIndex = 5;
            this.parabens.Text = "PARABÉNS! VOCÊ GANHOU 500 PONTOS!";
            this.parabens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parabens.Visible = false;
            // 
            // perdeu
            // 
            this.perdeu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perdeu.AutoSize = true;
            this.perdeu.BackColor = System.Drawing.Color.Transparent;
            this.perdeu.Font = new System.Drawing.Font("Abduction2002", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perdeu.ForeColor = System.Drawing.Color.Red;
            this.perdeu.Location = new System.Drawing.Point(71, 418);
            this.perdeu.Name = "perdeu";
            this.perdeu.Size = new System.Drawing.Size(403, 32);
            this.perdeu.TabIndex = 6;
            this.perdeu.Text = "VOCÊ PERDEU! +0 PONTOS";
            this.perdeu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.perdeu.Visible = false;
            this.perdeu.Click += new System.EventHandler(this.perdeu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MENSAGEM);
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 60);
            this.panel1.TabIndex = 7;
            // 
            // golcurintia
            // 
            this.golcurintia.Enabled = true;
            this.golcurintia.Location = new System.Drawing.Point(398, 210);
            this.golcurintia.Name = "golcurintia";
            this.golcurintia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("golcurintia.OcxState")));
            this.golcurintia.Size = new System.Drawing.Size(75, 23);
            this.golcurintia.TabIndex = 8;
            this.golcurintia.Visible = false;
            this.golcurintia.Enter += new System.EventHandler(this.golcurintia_Enter);
            // 
            // FrmPenalti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 720);
            this.Controls.Add(this.golcurintia);
            this.Controls.Add(this.imgJogador);
            this.Controls.Add(this.perdeu);
            this.Controls.Add(this.parabens);
            this.Controls.Add(this.contGol);
            this.Controls.Add(this.imgBola);
            this.Controls.Add(this.imgGoleiro);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPenalti";
            this.Text = "Penalti";
            this.Load += new System.EventHandler(this.FrmPenalte_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPenalti_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPenalte_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgGoleiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBola)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.golcurintia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgGoleiro;
        private System.Windows.Forms.PictureBox imgJogador;
        private System.Windows.Forms.PictureBox imgBola;
        private System.Windows.Forms.Timer timerGoleiro;
        private System.Windows.Forms.Timer timerBola;
        private System.Windows.Forms.Timer timerMovimento;
        private System.Windows.Forms.Timer timerBolaEsq;
        private System.Windows.Forms.Timer timerBolaDir;
        private System.Windows.Forms.Label MENSAGEM;
        private System.Windows.Forms.Timer timerTexto;
        private System.Windows.Forms.Timer timerTentativa;
        private System.Windows.Forms.Timer timerGol;
        private System.Windows.Forms.Label contGol;
        private System.Windows.Forms.Label parabens;
        private System.Windows.Forms.Label perdeu;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer golcurintia;
    }
}