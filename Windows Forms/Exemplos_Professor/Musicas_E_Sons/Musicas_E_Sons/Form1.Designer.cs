
namespace Musicas_E_Sons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mpEfeitosSonoros = new AxWMPLib.AxWindowsMediaPlayer();
            this.imgControleSom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpEfeitosSonoros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgControleSom)).BeginInit();
            this.SuspendLayout();
            // 
            // mp1
            // 
            this.mp1.Enabled = true;
            this.mp1.Location = new System.Drawing.Point(782, 15);
            this.mp1.Margin = new System.Windows.Forms.Padding(6);
            this.mp1.Name = "mp1";
            this.mp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp1.OcxState")));
            this.mp1.Size = new System.Drawing.Size(359, 78);
            this.mp1.TabIndex = 0;
            this.mp1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Iniciar música";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pausar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(405, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Parar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tiro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mpEfeitosSonoros
            // 
            this.mpEfeitosSonoros.Enabled = true;
            this.mpEfeitosSonoros.Location = new System.Drawing.Point(782, 105);
            this.mpEfeitosSonoros.Margin = new System.Windows.Forms.Padding(6);
            this.mpEfeitosSonoros.Name = "mpEfeitosSonoros";
            this.mpEfeitosSonoros.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mpEfeitosSonoros.OcxState")));
            this.mpEfeitosSonoros.Size = new System.Drawing.Size(474, 93);
            this.mpEfeitosSonoros.TabIndex = 5;
            this.mpEfeitosSonoros.Visible = false;
            // 
            // imgControleSom
            // 
            this.imgControleSom.Location = new System.Drawing.Point(622, 24);
            this.imgControleSom.Name = "imgControleSom";
            this.imgControleSom.Size = new System.Drawing.Size(113, 101);
            this.imgControleSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgControleSom.TabIndex = 6;
            this.imgControleSom.TabStop = false;
            this.imgControleSom.Click += new System.EventHandler(this.imgControleSom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 353);
            this.Controls.Add(this.imgControleSom);
            this.Controls.Add(this.mpEfeitosSonoros);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mp1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpEfeitosSonoros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgControleSom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private AxWMPLib.AxWindowsMediaPlayer mpEfeitosSonoros;
        private System.Windows.Forms.PictureBox imgControleSom;
    }
}

