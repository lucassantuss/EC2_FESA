namespace N2_Jogo
{
    partial class ucAlien
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAlien = new System.Windows.Forms.Timer(this.components);
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.timerExplodeAlien = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAlien
            // 
            this.timerAlien.Tick += new System.EventHandler(this.timerAlien_Tick);
            // 
            // pbAlien
            // 
            this.pbAlien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAlien.Location = new System.Drawing.Point(0, 0);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(60, 60);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlien.TabIndex = 0;
            this.pbAlien.TabStop = false;
            this.pbAlien.Click += new System.EventHandler(this.pbAlien_Click);
            // 
            // timerExplodeAlien
            // 
            this.timerExplodeAlien.Interval = 1000;
            this.timerExplodeAlien.Tick += new System.EventHandler(this.timerExplodeAlien_Tick);
            // 
            // ucAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pbAlien);
            this.Name = "ucAlien";
            this.Size = new System.Drawing.Size(60, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.Timer timerAlien;
        private System.Windows.Forms.Timer timerExplodeAlien;
    }
}
