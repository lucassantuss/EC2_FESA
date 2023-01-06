namespace Imperfectum
{
    partial class Ajuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajuda));
            this.rtxtHist = new System.Windows.Forms.RichTextBox();
            this.rtxtComoJogar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtHist
            // 
            this.rtxtHist.Location = new System.Drawing.Point(12, 28);
            this.rtxtHist.Name = "rtxtHist";
            this.rtxtHist.ReadOnly = true;
            this.rtxtHist.Size = new System.Drawing.Size(452, 148);
            this.rtxtHist.TabIndex = 0;
            this.rtxtHist.Text = "";
            // 
            // rtxtComoJogar
            // 
            this.rtxtComoJogar.Location = new System.Drawing.Point(12, 200);
            this.rtxtComoJogar.Name = "rtxtComoJogar";
            this.rtxtComoJogar.ReadOnly = true;
            this.rtxtComoJogar.Size = new System.Drawing.Size(453, 81);
            this.rtxtComoJogar.TabIndex = 1;
            this.rtxtComoJogar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "História";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Como jogar";
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtComoJogar);
            this.Controls.Add(this.rtxtHist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(493, 331);
            this.Name = "Ajuda";
            this.Text = "Ajuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtHist;
        private System.Windows.Forms.RichTextBox rtxtComoJogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}