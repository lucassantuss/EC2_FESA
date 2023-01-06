namespace Jogo_N2
{
    partial class frmPlacar
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
            this.lblplacar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioPlacar = new System.Windows.Forms.TextBox();
            this.txtPontuacaoPlacar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblplacar
            // 
            this.lblplacar.AutoSize = true;
            this.lblplacar.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplacar.Location = new System.Drawing.Point(12, 44);
            this.lblplacar.Name = "lblplacar";
            this.lblplacar.Size = new System.Drawing.Size(149, 42);
            this.lblplacar.TabIndex = 0;
            this.lblplacar.Text = "PLACAR:";
            this.lblplacar.Click += new System.EventHandler(this.lblplacar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontuação :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuarioPlacar
            // 
            this.txtUsuarioPlacar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioPlacar.Location = new System.Drawing.Point(12, 189);
            this.txtUsuarioPlacar.Name = "txtUsuarioPlacar";
            this.txtUsuarioPlacar.Size = new System.Drawing.Size(100, 34);
            this.txtUsuarioPlacar.TabIndex = 3;
            this.txtUsuarioPlacar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPontuacaoPlacar
            // 
            this.txtPontuacaoPlacar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontuacaoPlacar.Location = new System.Drawing.Point(160, 189);
            this.txtPontuacaoPlacar.Name = "txtPontuacaoPlacar";
            this.txtPontuacaoPlacar.Size = new System.Drawing.Size(100, 34);
            this.txtPontuacaoPlacar.TabIndex = 4;
            this.txtPontuacaoPlacar.TextChanged += new System.EventHandler(this.txtPontuacaoPlacar_TextChanged);
            // 
            // frmPlacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo_N2.Properties.Resources.plano_fundo_preto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 394);
            this.Controls.Add(this.txtPontuacaoPlacar);
            this.Controls.Add(this.txtUsuarioPlacar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblplacar);
            this.Name = "frmPlacar";
            this.Text = "Placar";
            this.Load += new System.EventHandler(this.frmPlacar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioPlacar;
        private System.Windows.Forms.TextBox txtPontuacaoPlacar;
    }
}