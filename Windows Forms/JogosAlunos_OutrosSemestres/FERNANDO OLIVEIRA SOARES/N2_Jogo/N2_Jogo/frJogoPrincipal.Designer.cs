namespace N2_Jogo
{
    partial class frJogoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frJogoPrincipal));
            this.timerTiroJogador = new System.Windows.Forms.Timer(this.components);
            this.wmpDisparo = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpExplosao = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbTiroJogador = new System.Windows.Forms.PictureBox();
            this.pbNaveJogador = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerFinaliza = new System.Windows.Forms.Timer(this.components);
            this.timerDerrota = new System.Windows.Forms.Timer(this.components);
            this.timerResetaPosicao = new System.Windows.Forms.Timer(this.components);
            this.timerJogoCarregado = new System.Windows.Forms.Timer(this.components);
            this.pbCarregando = new System.Windows.Forms.PictureBox();
            this.timerSobeDesce = new System.Windows.Forms.Timer(this.components);
            this.lblEspecial = new System.Windows.Forms.Label();
            this.timerEspecial = new System.Windows.Forms.Timer(this.components);
            this.ucTiroAlien3 = new N2_Jogo.ucTiroAlien();
            this.ucTiroAlien2 = new N2_Jogo.ucTiroAlien();
            this.ucTiroAlien1 = new N2_Jogo.ucTiroAlien();
            this.ucNaveAlien3 = new N2_Jogo.ucNaveAlien();
            this.ucNaveAlien2 = new N2_Jogo.ucNaveAlien();
            this.ucNaveAlien1 = new N2_Jogo.ucNaveAlien();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDisparo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpExplosao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiroJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaveJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTiroJogador
            // 
            this.timerTiroJogador.Interval = 10;
            this.timerTiroJogador.Tick += new System.EventHandler(this.timerTiroJogador_Tick_1);
            // 
            // wmpDisparo
            // 
            this.wmpDisparo.Enabled = true;
            this.wmpDisparo.Location = new System.Drawing.Point(1108, 12);
            this.wmpDisparo.Name = "wmpDisparo";
            this.wmpDisparo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpDisparo.OcxState")));
            this.wmpDisparo.Size = new System.Drawing.Size(35, 35);
            this.wmpDisparo.TabIndex = 39;
            this.wmpDisparo.Visible = false;
            // 
            // wmpExplosao
            // 
            this.wmpExplosao.Enabled = true;
            this.wmpExplosao.Location = new System.Drawing.Point(1067, 12);
            this.wmpExplosao.Name = "wmpExplosao";
            this.wmpExplosao.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpExplosao.OcxState")));
            this.wmpExplosao.Size = new System.Drawing.Size(35, 35);
            this.wmpExplosao.TabIndex = 40;
            this.wmpExplosao.Visible = false;
            // 
            // pbTiroJogador
            // 
            this.pbTiroJogador.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbTiroJogador.Image = global::N2_Jogo.Properties.Resources.PlayerShoot;
            this.pbTiroJogador.Location = new System.Drawing.Point(78, 298);
            this.pbTiroJogador.Name = "pbTiroJogador";
            this.pbTiroJogador.Size = new System.Drawing.Size(30, 15);
            this.pbTiroJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTiroJogador.TabIndex = 38;
            this.pbTiroJogador.TabStop = false;
            // 
            // pbNaveJogador
            // 
            this.pbNaveJogador.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbNaveJogador.Image = global::N2_Jogo.Properties.Resources.PlayerSpaceship;
            this.pbNaveJogador.Location = new System.Drawing.Point(12, 278);
            this.pbNaveJogador.Name = "pbNaveJogador";
            this.pbNaveJogador.Size = new System.Drawing.Size(60, 60);
            this.pbNaveJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNaveJogador.TabIndex = 37;
            this.pbNaveJogador.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::N2_Jogo.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerFinaliza
            // 
            this.timerFinaliza.Interval = 10;
            this.timerFinaliza.Tick += new System.EventHandler(this.timerFinaliza_Tick);
            // 
            // timerDerrota
            // 
            this.timerDerrota.Interval = 10;
            this.timerDerrota.Tick += new System.EventHandler(this.timerDerrota_Tick);
            // 
            // timerResetaPosicao
            // 
            this.timerResetaPosicao.Interval = 5000;
            this.timerResetaPosicao.Tick += new System.EventHandler(this.timerResetaPosicao_Tick);
            // 
            // timerJogoCarregado
            // 
            this.timerJogoCarregado.Interval = 12000;
            this.timerJogoCarregado.Tick += new System.EventHandler(this.timerJogoCarregado_Tick);
            // 
            // pbCarregando
            // 
            this.pbCarregando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCarregando.Image = global::N2_Jogo.Properties.Resources.Load;
            this.pbCarregando.Location = new System.Drawing.Point(0, 0);
            this.pbCarregando.Name = "pbCarregando";
            this.pbCarregando.Size = new System.Drawing.Size(1155, 611);
            this.pbCarregando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarregando.TabIndex = 49;
            this.pbCarregando.TabStop = false;
            // 
            // timerSobeDesce
            // 
            this.timerSobeDesce.Tick += new System.EventHandler(this.timerSobeDesce_Tick);
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.lblEspecial.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblEspecial.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecial.ForeColor = System.Drawing.Color.Red;
            this.lblEspecial.Location = new System.Drawing.Point(527, 29);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(80, 18);
            this.lblEspecial.TabIndex = 50;
            this.lblEspecial.Text = "GAMESHARK";
            // 
            // timerEspecial
            // 
            this.timerEspecial.Interval = 5000;
            this.timerEspecial.Tick += new System.EventHandler(this.timerEspecial_Tick);
            // 
            // ucTiroAlien3
            // 
            this.ucTiroAlien3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTiroAlien3.Location = new System.Drawing.Point(-18, 0);
            this.ucTiroAlien3.Name = "ucTiroAlien3";
            this.ucTiroAlien3.Size = new System.Drawing.Size(30, 15);
            this.ucTiroAlien3.TabIndex = 48;
            this.ucTiroAlien3.Visible = false;
            // 
            // ucTiroAlien2
            // 
            this.ucTiroAlien2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTiroAlien2.Location = new System.Drawing.Point(-18, 0);
            this.ucTiroAlien2.Name = "ucTiroAlien2";
            this.ucTiroAlien2.Size = new System.Drawing.Size(30, 15);
            this.ucTiroAlien2.TabIndex = 47;
            this.ucTiroAlien2.Visible = false;
            // 
            // ucTiroAlien1
            // 
            this.ucTiroAlien1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucTiroAlien1.Location = new System.Drawing.Point(-18, 0);
            this.ucTiroAlien1.Name = "ucTiroAlien1";
            this.ucTiroAlien1.Size = new System.Drawing.Size(30, 15);
            this.ucTiroAlien1.TabIndex = 46;
            this.ucTiroAlien1.Visible = false;
            // 
            // ucNaveAlien3
            // 
            this.ucNaveAlien3.Location = new System.Drawing.Point(1083, 429);
            this.ucNaveAlien3.Name = "ucNaveAlien3";
            this.ucNaveAlien3.Size = new System.Drawing.Size(60, 60);
            this.ucNaveAlien3.TabIndex = 45;
            // 
            // ucNaveAlien2
            // 
            this.ucNaveAlien2.Location = new System.Drawing.Point(1083, 278);
            this.ucNaveAlien2.Name = "ucNaveAlien2";
            this.ucNaveAlien2.Size = new System.Drawing.Size(60, 60);
            this.ucNaveAlien2.TabIndex = 44;
            // 
            // ucNaveAlien1
            // 
            this.ucNaveAlien1.Location = new System.Drawing.Point(1083, 124);
            this.ucNaveAlien1.Name = "ucNaveAlien1";
            this.ucNaveAlien1.Size = new System.Drawing.Size(60, 60);
            this.ucNaveAlien1.TabIndex = 43;
            // 
            // frJogoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 611);
            this.Controls.Add(this.lblEspecial);
            this.Controls.Add(this.pbCarregando);
            this.Controls.Add(this.ucTiroAlien3);
            this.Controls.Add(this.ucTiroAlien2);
            this.Controls.Add(this.ucTiroAlien1);
            this.Controls.Add(this.ucNaveAlien3);
            this.Controls.Add(this.ucNaveAlien2);
            this.Controls.Add(this.ucNaveAlien1);
            this.Controls.Add(this.wmpExplosao);
            this.Controls.Add(this.wmpDisparo);
            this.Controls.Add(this.pbTiroJogador);
            this.Controls.Add(this.pbNaveJogador);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frJogoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frJogoPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmpDisparo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpExplosao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiroJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNaveJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerTiroJogador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbTiroJogador;
        private System.Windows.Forms.PictureBox pbNaveJogador;
        private AxWMPLib.AxWindowsMediaPlayer wmpDisparo;
        private AxWMPLib.AxWindowsMediaPlayer wmpExplosao;
        private ucNaveAlien ucNaveAlien1;
        private ucNaveAlien ucNaveAlien2;
        private ucNaveAlien ucNaveAlien3;
       
        private System.Windows.Forms.Timer timerFinaliza;
        private ucTiroAlien ucTiroAlien1;
        private ucTiroAlien ucTiroAlien2;
        private ucTiroAlien ucTiroAlien3;
        private System.Windows.Forms.Timer timerDerrota;
        private System.Windows.Forms.Timer timerResetaPosicao;
        private System.Windows.Forms.Timer timerJogoCarregado;
        private System.Windows.Forms.PictureBox pbCarregando;
        private System.Windows.Forms.Timer timerSobeDesce;
        private System.Windows.Forms.Label lblEspecial;
        private System.Windows.Forms.Timer timerEspecial;
    }
}