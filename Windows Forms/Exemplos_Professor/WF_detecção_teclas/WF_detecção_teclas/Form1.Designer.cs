
namespace WF_detecção_teclas
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
            this.imgRyu = new System.Windows.Forms.PictureBox();
            this.txtVelocidade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgRyu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVelocidade)).BeginInit();
            this.SuspendLayout();
            // 
            // imgRyu
            // 
            this.imgRyu.Image = global::WF_detecção_teclas.Properties.Resources.float_like_a_butterfly_sting_like_a_bee;
            this.imgRyu.Location = new System.Drawing.Point(57, 53);
            this.imgRyu.Name = "imgRyu";
            this.imgRyu.Size = new System.Drawing.Size(103, 181);
            this.imgRyu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRyu.TabIndex = 0;
            this.imgRyu.TabStop = false;
            this.imgRyu.Tag = "555";
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(1154, 12);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(120, 26);
            this.txtVelocidade.TabIndex = 1;
            this.txtVelocidade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1021, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velocidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 632);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVelocidade);
            this.Controls.Add(this.imgRyu);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgRyu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVelocidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgRyu;
        private System.Windows.Forms.NumericUpDown txtVelocidade;
        private System.Windows.Forms.Label label1;
    }
}

