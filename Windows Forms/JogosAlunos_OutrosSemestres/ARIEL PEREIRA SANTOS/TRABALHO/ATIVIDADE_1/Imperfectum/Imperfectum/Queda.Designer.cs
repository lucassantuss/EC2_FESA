namespace Imperfectum
{
    partial class Queda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queda));
            this.pbChegada = new System.Windows.Forms.PictureBox();
            this.pbFerreiro = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.btnForca = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbChegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFerreiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbChegada
            // 
            this.pbChegada.BackColor = System.Drawing.Color.Transparent;
            this.pbChegada.Location = new System.Drawing.Point(-5, -4);
            this.pbChegada.Name = "pbChegada";
            this.pbChegada.Size = new System.Drawing.Size(36, 300);
            this.pbChegada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChegada.TabIndex = 0;
            this.pbChegada.TabStop = false;
            // 
            // pbFerreiro
            // 
            this.pbFerreiro.BackColor = System.Drawing.Color.Transparent;
            this.pbFerreiro.Location = new System.Drawing.Point(705, 197);
            this.pbFerreiro.Name = "pbFerreiro";
            this.pbFerreiro.Size = new System.Drawing.Size(100, 76);
            this.pbFerreiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFerreiro.TabIndex = 1;
            this.pbFerreiro.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Location = new System.Drawing.Point(705, 12);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 68);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // btnForca
            // 
            this.btnForca.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForca.Location = new System.Drawing.Point(705, 115);
            this.btnForca.Name = "btnForca";
            this.btnForca.Size = new System.Drawing.Size(83, 50);
            this.btnForca.TabIndex = 3;
            this.btnForca.Text = "Fazer Força";
            this.btnForca.UseVisualStyleBackColor = true;
            this.btnForca.Click += new System.EventHandler(this.btnForca_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Queda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.btnForca);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbFerreiro);
            this.Controls.Add(this.pbChegada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Queda";
            this.Text = "Queda";
            ((System.ComponentModel.ISupportInitialize)(this.pbChegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFerreiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbChegada;
        private System.Windows.Forms.PictureBox pbFerreiro;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnForca;
        private System.Windows.Forms.Timer timer1;
    }
}