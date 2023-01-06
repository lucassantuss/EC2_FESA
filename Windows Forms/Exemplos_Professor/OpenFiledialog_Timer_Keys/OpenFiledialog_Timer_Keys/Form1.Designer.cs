namespace OpenFiledialog_Timer_Keys
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Salvar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTeclas = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.poste = new System.Windows.Forms.PictureBox();
            this.carro2 = new System.Windows.Forms.PictureBox();
            this.carro1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerCarros = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecionar foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Selecione uma imagem";
            // 
            // Salvar
            // 
            this.Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.Location = new System.Drawing.Point(22, 212);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(172, 43);
            this.Salvar.TabIndex = 2;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 32);
            this.textBox1.TabIndex = 3;
            // 
            // txtTeclas
            // 
            this.txtTeclas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeclas.Location = new System.Drawing.Point(33, 335);
            this.txtTeclas.Name = "txtTeclas";
            this.txtTeclas.Size = new System.Drawing.Size(469, 32);
            this.txtTeclas.TabIndex = 4;
            this.txtTeclas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTeclas_KeyDown);
            this.txtTeclas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeclas_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(530, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(469, 32);
            this.textBox2.TabIndex = 5;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(435, 25);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(92, 31);
            this.lbHora.TabIndex = 6;
            this.lbHora.Text = "label1";
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Desligar relógio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(441, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ligar relógio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(22, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "Iniciar corrida";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // poste
            // 
            this.poste.Image = global::OpenFiledialog_Timer_Keys.Properties.Resources.poste;
            this.poste.Location = new System.Drawing.Point(1158, 335);
            this.poste.Name = "poste";
            this.poste.Size = new System.Drawing.Size(67, 291);
            this.poste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poste.TabIndex = 12;
            this.poste.TabStop = false;
            // 
            // carro2
            // 
            this.carro2.Image = global::OpenFiledialog_Timer_Keys.Properties.Resources.fusca;
            this.carro2.Location = new System.Drawing.Point(33, 552);
            this.carro2.Name = "carro2";
            this.carro2.Size = new System.Drawing.Size(102, 74);
            this.carro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carro2.TabIndex = 10;
            this.carro2.TabStop = false;
            this.carro2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // carro1
            // 
            this.carro1.Image = global::OpenFiledialog_Timer_Keys.Properties.Resources.vaiDeRe;
            this.carro1.Location = new System.Drawing.Point(33, 465);
            this.carro1.Name = "carro1";
            this.carro1.Size = new System.Drawing.Size(102, 74);
            this.carro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carro1.TabIndex = 9;
            this.carro1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timerCarros
            // 
            this.timerCarros.Interval = 300;
            this.timerCarros.Tick += new System.EventHandler(this.timerCarros_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 638);
            this.Controls.Add(this.poste);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.carro2);
            this.Controls.Add(this.carro1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTeclas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTeclas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox carro1;
        private System.Windows.Forms.PictureBox carro2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox poste;
        private System.Windows.Forms.Timer timerCarros;
    }
}

