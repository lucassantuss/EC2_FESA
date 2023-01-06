namespace Imperfectum
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnHall = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnConfigs = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHall
            // 
            this.btnHall.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHall.Location = new System.Drawing.Point(127, 249);
            this.btnHall.Name = "btnHall";
            this.btnHall.Size = new System.Drawing.Size(70, 63);
            this.btnHall.TabIndex = 0;
            this.btnHall.Text = "HALL DA FAMA";
            this.btnHall.UseVisualStyleBackColor = true;
            this.btnHall.Click += new System.EventHandler(this.btnHall_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(127, 202);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(70, 41);
            this.btnAjuda.TabIndex = 1;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Location = new System.Drawing.Point(127, 155);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(70, 41);
            this.btnSobre.TabIndex = 2;
            this.btnSobre.Text = "SOBRE";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnConfigs
            // 
            this.btnConfigs.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigs.Location = new System.Drawing.Point(127, 108);
            this.btnConfigs.Name = "btnConfigs";
            this.btnConfigs.Size = new System.Drawing.Size(70, 41);
            this.btnConfigs.TabIndex = 3;
            this.btnConfigs.Text = "CONFIG";
            this.btnConfigs.UseVisualStyleBackColor = true;
            this.btnConfigs.Click += new System.EventHandler(this.btnConfigs_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(108, 30);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(108, 72);
            this.btnJogar.TabIndex = 4;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMute.BackgroundImage")));
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMute.Location = new System.Drawing.Point(12, 12);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(27, 23);
            this.btnMute.TabIndex = 5;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnConfigs);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnHall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 369);
            this.MinimumSize = new System.Drawing.Size(320, 369);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHall;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnConfigs;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnMute;
    }
}