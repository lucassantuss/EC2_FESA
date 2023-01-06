namespace N2_Jogo
{
    partial class frTelaRecordes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frTelaRecordes));
            this.tbRecordes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbRecordes
            // 
            this.tbRecordes.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbRecordes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRecordes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecordes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRecordes.ForeColor = System.Drawing.SystemColors.Control;
            this.tbRecordes.Location = new System.Drawing.Point(0, 0);
            this.tbRecordes.Multiline = true;
            this.tbRecordes.Name = "tbRecordes";
            this.tbRecordes.Size = new System.Drawing.Size(684, 361);
            this.tbRecordes.TabIndex = 0;
            this.tbRecordes.TabStop = false;
            this.tbRecordes.Text = "   Jogador                                           Pontuação";
            // 
            // frTelaRecordes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.tbRecordes);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frTelaRecordes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRecordes;
    }
}