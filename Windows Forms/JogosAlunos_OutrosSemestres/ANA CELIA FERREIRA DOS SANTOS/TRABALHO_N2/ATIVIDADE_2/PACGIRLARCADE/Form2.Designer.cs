
namespace PACGIRLARCADE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pboxSairMenu = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnMiniJogos = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSairMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxSairMenu
            // 
            this.pboxSairMenu.BackColor = System.Drawing.Color.Transparent;
            this.pboxSairMenu.Image = global::PACGIRLARCADE.Properties.Resources.sair;
            this.pboxSairMenu.Location = new System.Drawing.Point(658, 1);
            this.pboxSairMenu.Name = "pboxSairMenu";
            this.pboxSairMenu.Size = new System.Drawing.Size(41, 38);
            this.pboxSairMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSairMenu.TabIndex = 1;
            this.pboxSairMenu.TabStop = false;
            this.pboxSairMenu.Click += new System.EventHandler(this.pboxSairMenu_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(12, 259);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(239, 50);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(460, 259);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(239, 50);
            this.btnRanking.TabIndex = 3;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnMiniJogos
            // 
            this.btnMiniJogos.Location = new System.Drawing.Point(6, 459);
            this.btnMiniJogos.Name = "btnMiniJogos";
            this.btnMiniJogos.Size = new System.Drawing.Size(239, 50);
            this.btnMiniJogos.TabIndex = 4;
            this.btnMiniJogos.Text = "Mini-Jogos";
            this.btnMiniJogos.UseVisualStyleBackColor = true;
            this.btnMiniJogos.Click += new System.EventHandler(this.btnMiniJogos_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(460, 459);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(239, 50);
            this.btnSobre.TabIndex = 5;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PACGIRLARCADE.Properties.Resources.pacgirl_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(61, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PACGIRLARCADE.Properties.Resources.fundomenus;
            this.ClientSize = new System.Drawing.Size(711, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnMiniJogos);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pboxSairMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pboxSairMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxSairMenu;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnMiniJogos;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}