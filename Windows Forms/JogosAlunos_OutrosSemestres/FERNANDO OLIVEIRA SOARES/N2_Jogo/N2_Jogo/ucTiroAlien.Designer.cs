namespace N2_Jogo
{
    partial class ucTiroAlien
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
            this.timerTiroAlien = new System.Windows.Forms.Timer(this.components);
            this.pbTiroAlien = new System.Windows.Forms.PictureBox();
            this.timerEfetuaTiro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTiroAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTiroAlien
            // 
            this.timerTiroAlien.Interval = 10;
            this.timerTiroAlien.Tick += new System.EventHandler(this.timerTiroAlien_Tick);
            // 
            // pbTiroAlien
            // 
            this.pbTiroAlien.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbTiroAlien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTiroAlien.Location = new System.Drawing.Point(0, 0);
            this.pbTiroAlien.Name = "pbTiroAlien";
            this.pbTiroAlien.Size = new System.Drawing.Size(30, 15);
            this.pbTiroAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTiroAlien.TabIndex = 43;
            this.pbTiroAlien.TabStop = false;
            // 
            // timerEfetuaTiro
            // 
            this.timerEfetuaTiro.Interval = 5000;
            this.timerEfetuaTiro.Tick += new System.EventHandler(this.timerEfetuaTiro_Tick);
            // 
            // ucTiroAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbTiroAlien);
            this.DoubleBuffered = true;
            this.Name = "ucTiroAlien";
            this.Size = new System.Drawing.Size(30, 15);
            ((System.ComponentModel.ISupportInitialize)(this.pbTiroAlien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTiroAlien;
        private System.Windows.Forms.Timer timerTiroAlien;
        private System.Windows.Forms.Timer timerEfetuaTiro;
    }
}
