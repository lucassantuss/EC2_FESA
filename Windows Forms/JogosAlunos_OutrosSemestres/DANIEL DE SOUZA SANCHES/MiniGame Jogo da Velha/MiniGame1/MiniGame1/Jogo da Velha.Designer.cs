namespace MiniGame1
{
    partial class MiniGame1
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
            this.JogadorX = new System.Windows.Forms.Label();
            this.JogadorO = new System.Windows.Forms.Label();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.Placar2 = new System.Windows.Forms.TextBox();
            this.Placar1 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.lbRodada = new System.Windows.Forms.Label();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JogadorX
            // 
            this.JogadorX.AutoSize = true;
            this.JogadorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogadorX.Location = new System.Drawing.Point(456, 100);
            this.JogadorX.Name = "JogadorX";
            this.JogadorX.Size = new System.Drawing.Size(127, 29);
            this.JogadorX.TabIndex = 0;
            this.JogadorX.Text = "JogadorX";
            this.JogadorX.Click += new System.EventHandler(this.label1_Click);
            // 
            // JogadorO
            // 
            this.JogadorO.AutoSize = true;
            this.JogadorO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JogadorO.Location = new System.Drawing.Point(450, 239);
            this.JogadorO.Name = "JogadorO";
            this.JogadorO.Size = new System.Drawing.Size(129, 29);
            this.JogadorO.TabIndex = 1;
            this.JogadorO.Text = "JogadorO";
            this.JogadorO.Click += new System.EventHandler(this.Jogador2_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(257, 107);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(80, 80);
            this.bt2.TabIndex = 20;
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(343, 107);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(80, 80);
            this.bt3.TabIndex = 21;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(171, 193);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(80, 80);
            this.bt4.TabIndex = 22;
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(257, 193);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(80, 80);
            this.bt5.TabIndex = 23;
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(343, 193);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(80, 80);
            this.bt6.TabIndex = 24;
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(171, 279);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(80, 80);
            this.bt7.TabIndex = 25;
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(257, 279);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(80, 80);
            this.bt8.TabIndex = 26;
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(343, 279);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(80, 80);
            this.bt9.TabIndex = 27;
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // Placar2
            // 
            this.Placar2.Location = new System.Drawing.Point(461, 279);
            this.Placar2.Multiline = true;
            this.Placar2.Name = "Placar2";
            this.Placar2.ReadOnly = true;
            this.Placar2.Size = new System.Drawing.Size(118, 49);
            this.Placar2.TabIndex = 28;
            this.Placar2.TextChanged += new System.EventHandler(this.Placar2_TextChanged);
            // 
            // Placar1
            // 
            this.Placar1.Location = new System.Drawing.Point(461, 132);
            this.Placar1.Multiline = true;
            this.Placar1.Name = "Placar1";
            this.Placar1.ReadOnly = true;
            this.Placar1.Size = new System.Drawing.Size(118, 49);
            this.Placar1.TabIndex = 29;
            this.Placar1.TextChanged += new System.EventHandler(this.Placar1_TextChanged);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(128, 20);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(345, 55);
            this.Titulo.TabIndex = 30;
            this.Titulo.Text = "Jogo da Velha";
            // 
            // lbRodada
            // 
            this.lbRodada.AutoSize = true;
            this.lbRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRodada.Location = new System.Drawing.Point(7, 77);
            this.lbRodada.Name = "lbRodada";
            this.lbRodada.Size = new System.Drawing.Size(104, 29);
            this.lbRodada.TabIndex = 31;
            this.lbRodada.Text = "Rodada";
            // 
            // txtPartida
            // 
            this.txtPartida.Location = new System.Drawing.Point(12, 109);
            this.txtPartida.Multiline = true;
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.ReadOnly = true;
            this.txtPartida.Size = new System.Drawing.Size(118, 49);
            this.txtPartida.TabIndex = 32;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(171, 107);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(80, 80);
            this.bt1.TabIndex = 33;
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(308, 378);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(180, 52);
            this.btLimpar.TabIndex = 34;
            this.btLimpar.Text = "Finalizar Rodada";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(98, 378);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(180, 52);
            this.btFinalizar.TabIndex = 35;
            this.btFinalizar.Text = "Finalizar Partida";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // MiniGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(604, 442);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txtPartida);
            this.Controls.Add(this.lbRodada);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Placar1);
            this.Controls.Add(this.Placar2);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.JogadorO);
            this.Controls.Add(this.JogadorX);
            this.Name = "MiniGame1";
            this.Text = "Jogo da velha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JogadorX;
        private System.Windows.Forms.Label JogadorO;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.TextBox Placar2;
        private System.Windows.Forms.TextBox Placar1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label lbRodada;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFinalizar;
    }
}

