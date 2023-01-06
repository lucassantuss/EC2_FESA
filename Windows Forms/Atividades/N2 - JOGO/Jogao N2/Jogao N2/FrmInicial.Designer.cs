namespace Jogao_N2
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.imgNovoJogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgComoJogar = new System.Windows.Forms.PictureBox();
            this.imgRanking = new System.Windows.Forms.PictureBox();
            this.imgSobre = new System.Windows.Forms.PictureBox();
            this.imgConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgNovoJogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgComoJogar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNovoJogo
            // 
            this.imgNovoJogo.BackColor = System.Drawing.Color.Transparent;
            this.imgNovoJogo.Image = ((System.Drawing.Image)(resources.GetObject("imgNovoJogo.Image")));
            this.imgNovoJogo.Location = new System.Drawing.Point(74, 12);
            this.imgNovoJogo.Name = "imgNovoJogo";
            this.imgNovoJogo.Size = new System.Drawing.Size(262, 57);
            this.imgNovoJogo.TabIndex = 6;
            this.imgNovoJogo.TabStop = false;
            this.imgNovoJogo.Click += new System.EventHandler(this.imgNovoJogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.imgRanking);
            this.panel1.Controls.Add(this.imgComoJogar);
            this.panel1.Controls.Add(this.imgNovoJogo);
            this.panel1.Location = new System.Drawing.Point(192, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 220);
            this.panel1.TabIndex = 7;
            // 
            // imgComoJogar
            // 
            this.imgComoJogar.BackColor = System.Drawing.Color.Transparent;
            this.imgComoJogar.Image = ((System.Drawing.Image)(resources.GetObject("imgComoJogar.Image")));
            this.imgComoJogar.Location = new System.Drawing.Point(49, 82);
            this.imgComoJogar.Name = "imgComoJogar";
            this.imgComoJogar.Size = new System.Drawing.Size(304, 57);
            this.imgComoJogar.TabIndex = 7;
            this.imgComoJogar.TabStop = false;
            this.imgComoJogar.Click += new System.EventHandler(this.imgComoJogar_Click);
            // 
            // imgRanking
            // 
            this.imgRanking.BackColor = System.Drawing.Color.Transparent;
            this.imgRanking.Image = ((System.Drawing.Image)(resources.GetObject("imgRanking.Image")));
            this.imgRanking.Location = new System.Drawing.Point(109, 144);
            this.imgRanking.Name = "imgRanking";
            this.imgRanking.Size = new System.Drawing.Size(201, 57);
            this.imgRanking.TabIndex = 8;
            this.imgRanking.TabStop = false;
            this.imgRanking.Click += new System.EventHandler(this.imgRanking_Click);
            // 
            // imgSobre
            // 
            this.imgSobre.BackColor = System.Drawing.Color.Transparent;
            this.imgSobre.Image = ((System.Drawing.Image)(resources.GetObject("imgSobre.Image")));
            this.imgSobre.Location = new System.Drawing.Point(703, 506);
            this.imgSobre.Name = "imgSobre";
            this.imgSobre.Size = new System.Drawing.Size(57, 57);
            this.imgSobre.TabIndex = 8;
            this.imgSobre.TabStop = false;
            this.imgSobre.Click += new System.EventHandler(this.imgSobre_Click);
            // 
            // imgConfig
            // 
            this.imgConfig.BackColor = System.Drawing.Color.Transparent;
            this.imgConfig.Image = ((System.Drawing.Image)(resources.GetObject("imgConfig.Image")));
            this.imgConfig.Location = new System.Drawing.Point(26, 506);
            this.imgConfig.Name = "imgConfig";
            this.imgConfig.Size = new System.Drawing.Size(57, 57);
            this.imgConfig.TabIndex = 9;
            this.imgConfig.TabStop = false;
            this.imgConfig.Click += new System.EventHandler(this.imgConfig_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.imgConfig);
            this.Controls.Add(this.imgSobre);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Last Corinthians Warriors";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgNovoJogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgComoJogar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgNovoJogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgRanking;
        private System.Windows.Forms.PictureBox imgComoJogar;
        private System.Windows.Forms.PictureBox imgSobre;
        private System.Windows.Forms.PictureBox imgConfig;
    }
}

