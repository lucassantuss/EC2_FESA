namespace Jogao_N2
{
    partial class FrmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            this.config = new System.Windows.Forms.Label();
            this.dificuldade = new System.Windows.Forms.Label();
            this.lblFacil = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.lblDificil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMusicOn = new System.Windows.Forms.Label();
            this.lblMusicOff = new System.Windows.Forms.Label();
            this.lblSFXOff = new System.Windows.Forms.Label();
            this.lblSFXOn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // config
            // 
            this.config.AutoSize = true;
            this.config.BackColor = System.Drawing.Color.Transparent;
            this.config.Font = new System.Drawing.Font("Abduction2002", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.config.ForeColor = System.Drawing.Color.DarkRed;
            this.config.Location = new System.Drawing.Point(10, 28);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(543, 74);
            this.config.TabIndex = 0;
            this.config.Text = "CONFIGURAÇÕES";
            // 
            // dificuldade
            // 
            this.dificuldade.AutoSize = true;
            this.dificuldade.BackColor = System.Drawing.Color.Transparent;
            this.dificuldade.Font = new System.Drawing.Font("Abduction2002", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dificuldade.ForeColor = System.Drawing.Color.Black;
            this.dificuldade.Location = new System.Drawing.Point(13, 125);
            this.dificuldade.Name = "dificuldade";
            this.dificuldade.Size = new System.Drawing.Size(340, 56);
            this.dificuldade.TabIndex = 1;
            this.dificuldade.Text = "DIFICULDADE";
            this.dificuldade.Click += new System.EventHandler(this.dificuldade_Click);
            // 
            // lblFacil
            // 
            this.lblFacil.AutoSize = true;
            this.lblFacil.BackColor = System.Drawing.Color.Transparent;
            this.lblFacil.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFacil.Location = new System.Drawing.Point(17, 198);
            this.lblFacil.Name = "lblFacil";
            this.lblFacil.Size = new System.Drawing.Size(101, 34);
            this.lblFacil.TabIndex = 2;
            this.lblFacil.Text = "FACIL";
            this.lblFacil.Click += new System.EventHandler(this.lblFacil_Click);
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.BackColor = System.Drawing.Color.Transparent;
            this.lblMedio.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMedio.Location = new System.Drawing.Point(145, 198);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(110, 34);
            this.lblMedio.TabIndex = 3;
            this.lblMedio.Text = "MÉDIO";
            this.lblMedio.Click += new System.EventHandler(this.lblMedio_Click);
            // 
            // lblDificil
            // 
            this.lblDificil.AutoSize = true;
            this.lblDificil.BackColor = System.Drawing.Color.Transparent;
            this.lblDificil.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificil.Location = new System.Drawing.Point(282, 198);
            this.lblDificil.Name = "lblDificil";
            this.lblDificil.Size = new System.Drawing.Size(129, 34);
            this.lblDificil.TabIndex = 4;
            this.lblDificil.Text = "DIFICIL";
            this.lblDificil.Click += new System.EventHandler(this.lblDificil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Abduction2002", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "MUSICA";
            // 
            // lblMusicOn
            // 
            this.lblMusicOn.AutoSize = true;
            this.lblMusicOn.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicOn.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMusicOn.Location = new System.Drawing.Point(17, 321);
            this.lblMusicOn.Name = "lblMusicOn";
            this.lblMusicOn.Size = new System.Drawing.Size(51, 34);
            this.lblMusicOn.TabIndex = 6;
            this.lblMusicOn.Text = "ON";
            this.lblMusicOn.Click += new System.EventHandler(this.lblMusicOn_Click);
            // 
            // lblMusicOff
            // 
            this.lblMusicOff.AutoSize = true;
            this.lblMusicOff.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicOff.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMusicOff.Location = new System.Drawing.Point(103, 321);
            this.lblMusicOff.Name = "lblMusicOff";
            this.lblMusicOff.Size = new System.Drawing.Size(69, 34);
            this.lblMusicOff.TabIndex = 7;
            this.lblMusicOff.Text = "OFF";
            this.lblMusicOff.Click += new System.EventHandler(this.lblMusicOff_Click);
            // 
            // lblSFXOff
            // 
            this.lblSFXOff.AutoSize = true;
            this.lblSFXOff.BackColor = System.Drawing.Color.Transparent;
            this.lblSFXOff.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFXOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSFXOff.Location = new System.Drawing.Point(107, 441);
            this.lblSFXOff.Name = "lblSFXOff";
            this.lblSFXOff.Size = new System.Drawing.Size(69, 34);
            this.lblSFXOff.TabIndex = 10;
            this.lblSFXOff.Text = "OFF";
            this.lblSFXOff.Click += new System.EventHandler(this.lblSFXOff_Click);
            // 
            // lblSFXOn
            // 
            this.lblSFXOn.AutoSize = true;
            this.lblSFXOn.BackColor = System.Drawing.Color.Transparent;
            this.lblSFXOn.Font = new System.Drawing.Font("Abduction2002", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFXOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSFXOn.Location = new System.Drawing.Point(21, 441);
            this.lblSFXOn.Name = "lblSFXOn";
            this.lblSFXOn.Size = new System.Drawing.Size(51, 34);
            this.lblSFXOn.TabIndex = 9;
            this.lblSFXOn.Text = "ON";
            this.lblSFXOn.Click += new System.EventHandler(this.lblSFXOn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Abduction2002", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(467, 56);
            this.label9.TabIndex = 8;
            this.label9.Text = "EFEITOS SONOROS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(692, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSFXOff);
            this.Controls.Add(this.lblSFXOn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMusicOff);
            this.Controls.Add(this.lblMusicOn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDificil);
            this.Controls.Add(this.lblMedio);
            this.Controls.Add(this.lblFacil);
            this.Controls.Add(this.dificuldade);
            this.Controls.Add(this.config);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfiguracoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label config;
        private System.Windows.Forms.Label dificuldade;
        private System.Windows.Forms.Label lblFacil;
        private System.Windows.Forms.Label lblMedio;
        private System.Windows.Forms.Label lblDificil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMusicOn;
        private System.Windows.Forms.Label lblMusicOff;
        private System.Windows.Forms.Label lblSFXOff;
        private System.Windows.Forms.Label lblSFXOn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}