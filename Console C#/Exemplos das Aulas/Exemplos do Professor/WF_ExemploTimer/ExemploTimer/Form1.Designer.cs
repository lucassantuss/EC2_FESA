namespace ExemploTimer
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
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timerContagemRegressiva = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.lblContagem = new System.Windows.Forms.Label();
            this.carro1 = new System.Windows.Forms.PictureBox();
            this.carro2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timerCarros = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro2)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRelogio
            // 
            this.timerRelogio.Interval = 1000;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(108, 27);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(76, 25);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Liga o relógio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Desliga relógio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerContagemRegressiva
            // 
            this.timerContagemRegressiva.Interval = 1000;
            this.timerContagemRegressiva.Tick += new System.EventHandler(this.timerContagemRegressiva_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Liga a contagem regressiva";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblContagem
            // 
            this.lblContagem.AutoSize = true;
            this.lblContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContagem.Location = new System.Drawing.Point(328, 9);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Size = new System.Drawing.Size(38, 25);
            this.lblContagem.TabIndex = 4;
            this.lblContagem.Text = "30";
            // 
            // carro1
            // 
            this.carro1.Image = global::ExemploTimer.Properties.Resources.carro1;
            this.carro1.Location = new System.Drawing.Point(40, 146);
            this.carro1.Name = "carro1";
            this.carro1.Size = new System.Drawing.Size(100, 50);
            this.carro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carro1.TabIndex = 6;
            this.carro1.TabStop = false;
            // 
            // carro2
            // 
            this.carro2.Image = global::ExemploTimer.Properties.Resources.carro2;
            this.carro2.Location = new System.Drawing.Point(40, 202);
            this.carro2.Name = "carro2";
            this.carro2.Size = new System.Drawing.Size(100, 50);
            this.carro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carro2.TabIndex = 7;
            this.carro2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dar a largada!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // timerCarros
            // 
            this.timerCarros.Tick += new System.EventHandler(this.timerCarros_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 314);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.carro2);
            this.Controls.Add(this.carro1);
            this.Controls.Add(this.lblContagem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerContagemRegressiva;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblContagem;
        private System.Windows.Forms.PictureBox carro1;
        private System.Windows.Forms.PictureBox carro2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerCarros;
    }
}

