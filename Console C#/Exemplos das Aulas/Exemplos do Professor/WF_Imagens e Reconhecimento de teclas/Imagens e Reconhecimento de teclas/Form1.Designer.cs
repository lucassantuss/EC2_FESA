namespace Imagens_e_Reconhecimento_de_teclas
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnPorco = new System.Windows.Forms.Button();
            this.btnMultiSuperCampeaoUniversalDaGalaxia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Imagens_e_Reconhecimento_de_teclas.Properties.Resources.congrats;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Selecionar imagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(308, 184);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(438, 163);
            this.txtLog.TabIndex = 3;
            this.txtLog.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtLog.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(308, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(308, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnPorco
            // 
            this.btnPorco.Location = new System.Drawing.Point(12, 286);
            this.btnPorco.Name = "btnPorco";
            this.btnPorco.Size = new System.Drawing.Size(195, 23);
            this.btnPorco.TabIndex = 5;
            this.btnPorco.Text = "Quero sair, sou palmeirense";
            this.btnPorco.UseVisualStyleBackColor = true;
            this.btnPorco.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // btnMultiSuperCampeaoUniversalDaGalaxia
            // 
            this.btnMultiSuperCampeaoUniversalDaGalaxia.Location = new System.Drawing.Point(12, 315);
            this.btnMultiSuperCampeaoUniversalDaGalaxia.Name = "btnMultiSuperCampeaoUniversalDaGalaxia";
            this.btnMultiSuperCampeaoUniversalDaGalaxia.Size = new System.Drawing.Size(195, 23);
            this.btnMultiSuperCampeaoUniversalDaGalaxia.TabIndex = 6;
            this.btnMultiSuperCampeaoUniversalDaGalaxia.Text = "Quero sair, sou corinthiano";
            this.btnMultiSuperCampeaoUniversalDaGalaxia.UseVisualStyleBackColor = true;
            this.btnMultiSuperCampeaoUniversalDaGalaxia.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMultiSuperCampeaoUniversalDaGalaxia);
            this.Controls.Add(this.btnPorco);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnPorco;
        private System.Windows.Forms.Button btnMultiSuperCampeaoUniversalDaGalaxia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

