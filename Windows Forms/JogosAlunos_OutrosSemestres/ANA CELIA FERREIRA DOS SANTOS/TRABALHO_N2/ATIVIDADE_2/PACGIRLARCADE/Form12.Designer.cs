
namespace PACGIRLARCADE
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.canoBaixo = new System.Windows.Forms.PictureBox();
            this.chao = new System.Windows.Forms.PictureBox();
            this.canoCima = new System.Windows.Forms.PictureBox();
            this.fbJogoTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPontos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canoBaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canoCima)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::PACGIRLARCADE.Properties.Resources.flappy;
            this.flappyBird.Location = new System.Drawing.Point(92, 184);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(69, 61);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // canoBaixo
            // 
            this.canoBaixo.Image = global::PACGIRLARCADE.Properties.Resources.canobaixo;
            this.canoBaixo.Location = new System.Drawing.Point(513, -34);
            this.canoBaixo.Name = "canoBaixo";
            this.canoBaixo.Size = new System.Drawing.Size(95, 218);
            this.canoBaixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canoBaixo.TabIndex = 2;
            this.canoBaixo.TabStop = false;
            // 
            // chao
            // 
            this.chao.Image = global::PACGIRLARCADE.Properties.Resources.chao;
            this.chao.Location = new System.Drawing.Point(-7, 586);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(629, 112);
            this.chao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao.TabIndex = 4;
            this.chao.TabStop = false;
            // 
            // canoCima
            // 
            this.canoCima.Image = global::PACGIRLARCADE.Properties.Resources.canocima;
            this.canoCima.Location = new System.Drawing.Point(385, 413);
            this.canoCima.Name = "canoCima";
            this.canoCima.Size = new System.Drawing.Size(95, 177);
            this.canoCima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canoCima.TabIndex = 5;
            this.canoCima.TabStop = false;
            // 
            // fbJogoTimer
            // 
            this.fbJogoTimer.Enabled = true;
            this.fbJogoTimer.Interval = 20;
            this.fbJogoTimer.Tick += new System.EventHandler(this.timerJogo);
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Moccasin;
            this.lblPontos.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontos.Location = new System.Drawing.Point(12, 622);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(170, 35);
            this.lblPontos.TabIndex = 6;
            this.lblPontos.Text = "Pontuação: 0";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(620, 696);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.canoCima);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.canoBaixo);
            this.Controls.Add(this.flappyBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird - Minijogo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canoBaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canoCima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox canoBaixo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox canoCima;
        private System.Windows.Forms.Timer fbJogoTimer;
        private System.Windows.Forms.PictureBox chao;
        private System.Windows.Forms.Label lblPontos;
    }
}