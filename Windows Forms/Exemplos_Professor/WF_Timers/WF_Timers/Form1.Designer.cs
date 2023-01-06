
namespace WF_Timers
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
            this.lblContador = new System.Windows.Forms.Label();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timerCorrida = new System.Windows.Forms.Timer(this.components);
            this.imgNave = new System.Windows.Forms.PictureBox();
            this.imgCliente = new System.Windows.Forms.PictureBox();
            this.imgTaxi = new System.Windows.Forms.PictureBox();
            this.imgUber = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Contagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(1087, 45);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(29, 31);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "0";
            // 
            // timerRelogio
            // 
            this.timerRelogio.Interval = 1;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(542, 35);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 31);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Liga Relógio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "Desliga Relógio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 187);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 70);
            this.button4.TabIndex = 8;
            this.button4.Text = "Largada!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timerCorrida
            // 
            this.timerCorrida.Interval = 200;
            this.timerCorrida.Tick += new System.EventHandler(this.timerCorrida_Tick);
            // 
            // imgNave
            // 
            this.imgNave.Image = global::WF_Timers.Properties.Resources.iconfinder_blimp_vintage_air_airship_aviation_zeppelin_sky_4047349;
            this.imgNave.Location = new System.Drawing.Point(300, 120);
            this.imgNave.Name = "imgNave";
            this.imgNave.Size = new System.Drawing.Size(161, 108);
            this.imgNave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNave.TabIndex = 9;
            this.imgNave.TabStop = false;
            // 
            // imgCliente
            // 
            this.imgCliente.Image = global::WF_Timers.Properties.Resources.iconfinder_Picture4_32895591;
            this.imgCliente.Location = new System.Drawing.Point(1202, 153);
            this.imgCliente.Name = "imgCliente";
            this.imgCliente.Size = new System.Drawing.Size(190, 351);
            this.imgCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCliente.TabIndex = 7;
            this.imgCliente.TabStop = false;
            // 
            // imgTaxi
            // 
            this.imgTaxi.Image = global::WF_Timers.Properties.Resources.iconfinder_TAXI_cab_transportation_automobile_car_vehicle_5452472;
            this.imgTaxi.Location = new System.Drawing.Point(28, 380);
            this.imgTaxi.Name = "imgTaxi";
            this.imgTaxi.Size = new System.Drawing.Size(188, 108);
            this.imgTaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTaxi.TabIndex = 6;
            this.imgTaxi.TabStop = false;
            // 
            // imgUber
            // 
            this.imgUber.Image = global::WF_Timers.Properties.Resources.iconfinder_advantage_deliver_1034356;
            this.imgUber.Location = new System.Drawing.Point(28, 266);
            this.imgUber.Name = "imgUber";
            this.imgUber.Size = new System.Drawing.Size(188, 108);
            this.imgUber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUber.TabIndex = 5;
            this.imgUber.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 38);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite um texto, as vogais não aparecerão!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imgNave);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.imgCliente);
            this.Controls.Add(this.imgTaxi);
            this.Controls.Add(this.imgUber);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imgNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox imgUber;
        private System.Windows.Forms.PictureBox imgTaxi;
        private System.Windows.Forms.PictureBox imgCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timerCorrida;
        private System.Windows.Forms.PictureBox imgNave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

