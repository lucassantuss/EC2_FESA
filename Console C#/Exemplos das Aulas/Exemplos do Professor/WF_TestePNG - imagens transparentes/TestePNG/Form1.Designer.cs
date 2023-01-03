namespace TestePNG
{
    partial class Form1
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
            this.pbCancel = new System.Windows.Forms.PictureBox();
            this.pbLupa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCancel
            // 
            this.pbCancel.BackColor = System.Drawing.SystemColors.Control;
            this.pbCancel.Image = global::TestePNG.Properties.Resources.if_f_cross_256_282471;
            this.pbCancel.Location = new System.Drawing.Point(125, 60);
            this.pbCancel.Name = "pbCancel";
            this.pbCancel.Size = new System.Drawing.Size(83, 86);
            this.pbCancel.TabIndex = 1;
            this.pbCancel.TabStop = false;
            // 
            // pbLupa
            // 
            this.pbLupa.Image = global::TestePNG.Properties.Resources.if_system_search_118797;
            this.pbLupa.Location = new System.Drawing.Point(0, 0);
            this.pbLupa.Name = "pbLupa";
            this.pbLupa.Size = new System.Drawing.Size(266, 210);
            this.pbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLupa.TabIndex = 0;
            this.pbLupa.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 330);
            this.Controls.Add(this.pbCancel);
            this.Controls.Add(this.pbLupa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLupa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLupa;
        private System.Windows.Forms.PictureBox pbCancel;
    }
}

