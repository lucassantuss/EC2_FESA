namespace Jogo_N2
{
    partial class frmJogo
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
            this.picVermelho = new System.Windows.Forms.PictureBox();
            this.picAzul = new System.Windows.Forms.PictureBox();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.picAmarelo = new System.Windows.Forms.PictureBox();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picVermelho
            // 
            this.picVermelho.BackColor = System.Drawing.Color.DarkRed;
            this.picVermelho.Location = new System.Drawing.Point(32, 92);
            this.picVermelho.Name = "picVermelho";
            this.picVermelho.Size = new System.Drawing.Size(150, 130);
            this.picVermelho.TabIndex = 0;
            this.picVermelho.TabStop = false;
            this.picVermelho.Tag = "R";
            this.picVermelho.Click += new System.EventHandler(this.clique);
            // 
            // picAzul
            // 
            this.picAzul.BackColor = System.Drawing.Color.DarkBlue;
            this.picAzul.Location = new System.Drawing.Point(32, 228);
            this.picAzul.Name = "picAzul";
            this.picAzul.Size = new System.Drawing.Size(150, 125);
            this.picAzul.TabIndex = 1;
            this.picAzul.TabStop = false;
            this.picAzul.Tag = "B";
            this.picAzul.Click += new System.EventHandler(this.clique);
            // 
            // picVerde
            // 
            this.picVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.picVerde.Location = new System.Drawing.Point(188, 92);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(156, 130);
            this.picVerde.TabIndex = 2;
            this.picVerde.TabStop = false;
            this.picVerde.Tag = "G";
            this.picVerde.Click += new System.EventHandler(this.clique);
            // 
            // picAmarelo
            // 
            this.picAmarelo.BackColor = System.Drawing.Color.Gold;
            this.picAmarelo.Location = new System.Drawing.Point(188, 228);
            this.picAmarelo.Name = "picAmarelo";
            this.picAmarelo.Size = new System.Drawing.Size(156, 125);
            this.picAmarelo.TabIndex = 3;
            this.picAmarelo.TabStop = false;
            this.picAmarelo.Tag = "Y";
            this.picAmarelo.Click += new System.EventHandler(this.clique);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPontuacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPontuacao.Location = new System.Drawing.Point(12, 384);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(172, 38);
            this.lblPontuacao.TabIndex = 4;
            this.lblPontuacao.Text = "Pontuaçao:";
            this.lblPontuacao.Click += new System.EventHandler(this.clique);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Opções";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.opcoes);
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar!";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.opcoes);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.opcoes);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.picAmarelo);
            this.Controls.Add(this.picVerde);
            this.Controls.Add(this.picAzul);
            this.Controls.Add(this.picVermelho);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genius!";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picVermelho;
        private System.Windows.Forms.PictureBox picAzul;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.PictureBox picAmarelo;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}