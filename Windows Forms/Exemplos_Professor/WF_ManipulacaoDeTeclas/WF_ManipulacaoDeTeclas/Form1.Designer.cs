namespace WF_ManipulacaoDeTeclas
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.timerTiro = new System.Windows.Forms.Timer(this.components);
            this.imgNave = new System.Windows.Forms.PictureBox();
            this.imgBala = new System.Windows.Forms.PictureBox();
            this.imgBotao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBotao)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 32);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(345, 32);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(345, 32);
            this.textBox4.TabIndex = 5;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // timerTiro
            // 
            this.timerTiro.Interval = 10;
            this.timerTiro.Tick += new System.EventHandler(this.timerTiro_Tick);
            // 
            // imgNave
            // 
            this.imgNave.Image = global::WF_ManipulacaoDeTeclas.Properties.Resources.nave;
            this.imgNave.Location = new System.Drawing.Point(25, 280);
            this.imgNave.Name = "imgNave";
            this.imgNave.Size = new System.Drawing.Size(223, 150);
            this.imgNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNave.TabIndex = 6;
            this.imgNave.TabStop = false;
            // 
            // imgBala
            // 
            this.imgBala.Image = global::WF_ManipulacaoDeTeclas.Properties.Resources.bala;
            this.imgBala.Location = new System.Drawing.Point(254, 342);
            this.imgBala.Name = "imgBala";
            this.imgBala.Size = new System.Drawing.Size(44, 24);
            this.imgBala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBala.TabIndex = 7;
            this.imgBala.TabStop = false;
            this.imgBala.Visible = false;
            // 
            // imgBotao
            // 
            this.imgBotao.Location = new System.Drawing.Point(538, 65);
            this.imgBotao.Name = "imgBotao";
            this.imgBotao.Size = new System.Drawing.Size(223, 150);
            this.imgBotao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBotao.TabIndex = 8;
            this.imgBotao.TabStop = false;
            this.imgBotao.Click += new System.EventHandler(this.imgBotao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 540);
            this.Controls.Add(this.imgBotao);
            this.Controls.Add(this.imgBala);
            this.Controls.Add(this.imgNave);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBotao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Timer timerTiro;
        private System.Windows.Forms.PictureBox imgNave;
        private System.Windows.Forms.PictureBox imgBala;
        private System.Windows.Forms.PictureBox imgBotao;
    }
}

