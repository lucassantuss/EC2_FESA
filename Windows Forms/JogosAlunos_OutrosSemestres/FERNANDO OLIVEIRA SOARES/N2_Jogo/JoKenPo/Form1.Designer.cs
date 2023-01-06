
namespace JoKenPo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPapel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImgJogador = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImgPC = new System.Windows.Forms.PictureBox();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.ImgResultado = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgJogador)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::JoKenPo.Properties.Resources.Papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(218, 249);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(200, 200);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImgJogador);
            this.groupBox1.Location = new System.Drawing.Point(22, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JOGADOR";
            // 
            // ImgJogador
            // 
            this.ImgJogador.Location = new System.Drawing.Point(6, 31);
            this.ImgJogador.Name = "ImgJogador";
            this.ImgJogador.Size = new System.Drawing.Size(188, 154);
            this.ImgJogador.TabIndex = 0;
            this.ImgJogador.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImgPC);
            this.groupBox2.Location = new System.Drawing.Point(425, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 200);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC";
            // 
            // ImgPC
            // 
            this.ImgPC.Location = new System.Drawing.Point(6, 31);
            this.ImgPC.Name = "ImgPC";
            this.ImgPC.Size = new System.Drawing.Size(188, 154);
            this.ImgPC.TabIndex = 0;
            this.ImgPC.TabStop = false;
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::JoKenPo.Properties.Resources.Pedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(12, 249);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(200, 200);
            this.btnPedra.TabIndex = 5;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::JoKenPo.Properties.Resources.Tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(425, 249);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(200, 200);
            this.btnTesoura.TabIndex = 6;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // ImgResultado
            // 
            this.ImgResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgResultado.Location = new System.Drawing.Point(250, 82);
            this.ImgResultado.Name = "ImgResultado";
            this.ImgResultado.Size = new System.Drawing.Size(150, 99);
            this.ImgResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgResultado.TabIndex = 0;
            this.ImgResultado.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(637, 461);
            this.Controls.Add(this.ImgResultado);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPapel);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MINI JOGO JOKENPO";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgJogador)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ImgJogador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ImgPC;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.PictureBox ImgResultado;
    }
}

