namespace N2_Jogo
{
    partial class frTelaMiniJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTelaMiniJogos));
            this.lblMiniJogoF = new System.Windows.Forms.Label();
            this.lblMiniJogoM = new System.Windows.Forms.Label();
            this.lblMiniJogoW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMiniJogoF
            // 
            this.lblMiniJogoF.AutoSize = true;
            this.lblMiniJogoF.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniJogoF.Location = new System.Drawing.Point(246, 99);
            this.lblMiniJogoF.Name = "lblMiniJogoF";
            this.lblMiniJogoF.Size = new System.Drawing.Size(180, 19);
            this.lblMiniJogoF.TabIndex = 0;
            this.lblMiniJogoF.Text = "Invasão (Mini Jogo)";
            this.lblMiniJogoF.Click += new System.EventHandler(this.lblMiniJogoF_Click);
            // 
            // lblMiniJogoM
            // 
            this.lblMiniJogoM.AutoSize = true;
            this.lblMiniJogoM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniJogoM.Location = new System.Drawing.Point(246, 172);
            this.lblMiniJogoM.Name = "lblMiniJogoM";
            this.lblMiniJogoM.Size = new System.Drawing.Size(180, 19);
            this.lblMiniJogoM.TabIndex = 1;
            this.lblMiniJogoM.Text = "Memória (Mini Jogo)";
            this.lblMiniJogoM.Click += new System.EventHandler(this.lblMiniJogoM_Click);
            // 
            // lblMiniJogoW
            // 
            this.lblMiniJogoW.AutoSize = true;
            this.lblMiniJogoW.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniJogoW.Location = new System.Drawing.Point(246, 241);
            this.lblMiniJogoW.Name = "lblMiniJogoW";
            this.lblMiniJogoW.Size = new System.Drawing.Size(180, 19);
            this.lblMiniJogoW.TabIndex = 2;
            this.lblMiniJogoW.Text = "Jokenpo (Mini Jogo)";
            this.lblMiniJogoW.Click += new System.EventHandler(this.lblMiniJogoW_Click);
            // 
            // frTelaMiniJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lblMiniJogoW);
            this.Controls.Add(this.lblMiniJogoM);
            this.Controls.Add(this.lblMiniJogoF);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frTelaMiniJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+ Jogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiniJogoF;
        private System.Windows.Forms.Label lblMiniJogoM;
        private System.Windows.Forms.Label lblMiniJogoW;
    }
}