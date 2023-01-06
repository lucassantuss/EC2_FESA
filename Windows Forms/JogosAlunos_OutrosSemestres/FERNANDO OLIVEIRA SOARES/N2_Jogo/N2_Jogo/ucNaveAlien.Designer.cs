namespace N2_Jogo
{
    partial class ucNaveAlien
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
            this.pbNaveAlien = new System.Windows.Forms.PictureBox();
            this.timerMovNaveALien = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNaveAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNaveAlien
            // 
            this.pbNaveAlien.BackColor = System.Drawing.SystemColors.ControlText;
            this.pbNaveAlien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNaveAlien.Location = new System.Drawing.Point(0, 0);
            this.pbNaveAlien.Name = "pbNaveAlien";
            this.pbNaveAlien.Size = new System.Drawing.Size(60, 60);
            this.pbNaveAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNaveAlien.TabIndex = 44;
            this.pbNaveAlien.TabStop = false;
            // 
            // timerMovNaveALien
            // 
            this.timerMovNaveALien.Tick += new System.EventHandler(this.timerMovNaveALien_Tick);
            // 
            // ucNaveAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbNaveAlien);
            this.DoubleBuffered = true;
            this.Name = "ucNaveAlien";
            this.Size = new System.Drawing.Size(60, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pbNaveAlien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNaveAlien;
        private System.Windows.Forms.Timer timerMovNaveALien;
    }
}
