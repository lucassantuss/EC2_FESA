
namespace Componentes_2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtAlgo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarTexto = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerRelogio = new System.Windows.Forms.Timer(this.components);
            this.lblRelogio = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.imgLinhaChegada = new System.Windows.Forms.PictureBox();
            this.imgCaminhao = new System.Windows.Forms.PictureBox();
            this.imgCarro = new System.Windows.Forms.PictureBox();
            this.imgTeste = new System.Windows.Forms.PictureBox();
            this.timerDeslocaCarro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLinhaChegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaminhao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "divide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Times";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "menos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(472, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 73);
            this.button4.TabIndex = 4;
            this.button4.Text = "Escolher arquivo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtAlgo
            // 
            this.txtAlgo.Location = new System.Drawing.Point(649, 63);
            this.txtAlgo.Name = "txtAlgo";
            this.txtAlgo.Size = new System.Drawing.Size(197, 31);
            this.txtAlgo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite algo";
            // 
            // btnSalvarTexto
            // 
            this.btnSalvarTexto.Location = new System.Drawing.Point(868, 63);
            this.btnSalvarTexto.Name = "btnSalvarTexto";
            this.btnSalvarTexto.Size = new System.Drawing.Size(85, 31);
            this.btnSalvarTexto.TabIndex = 7;
            this.btnSalvarTexto.Text = "Salvar";
            this.btnSalvarTexto.UseVisualStyleBackColor = true;
            this.btnSalvarTexto.Click += new System.EventHandler(this.btnSalvarTexto_Click);
            // 
            // timerRelogio
            // 
            this.timerRelogio.Interval = 1;
            this.timerRelogio.Tick += new System.EventHandler(this.timerRelogio_Tick);
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Location = new System.Drawing.Point(1016, 6);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(76, 23);
            this.lblRelogio.TabIndex = 8;
            this.lblRelogio.Text = "label2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1007, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ligar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1098, 63);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 31);
            this.button6.TabIndex = 10;
            this.button6.Text = "Desligar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(49, 468);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 73);
            this.button7.TabIndex = 13;
            this.button7.Text = "Iniciar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // imgLinhaChegada
            // 
            this.imgLinhaChegada.Image = global::Componentes_2.Properties.Resources._172465_flag_finish_goal_icon;
            this.imgLinhaChegada.Location = new System.Drawing.Point(1132, 109);
            this.imgLinhaChegada.Name = "imgLinhaChegada";
            this.imgLinhaChegada.Size = new System.Drawing.Size(99, 108);
            this.imgLinhaChegada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLinhaChegada.TabIndex = 14;
            this.imgLinhaChegada.TabStop = false;
            // 
            // imgCaminhao
            // 
            this.imgCaminhao.Image = global::Componentes_2.Properties.Resources._7952195_delivery_truck_shipping_courier_cargo_icon;
            this.imgCaminhao.Location = new System.Drawing.Point(49, 342);
            this.imgCaminhao.Name = "imgCaminhao";
            this.imgCaminhao.Size = new System.Drawing.Size(118, 108);
            this.imgCaminhao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCaminhao.TabIndex = 12;
            this.imgCaminhao.TabStop = false;
            // 
            // imgCarro
            // 
            this.imgCarro.Image = global::Componentes_2.Properties.Resources._1034356_deliver_auto_car_transport_transportation_icon;
            this.imgCarro.Location = new System.Drawing.Point(49, 212);
            this.imgCarro.Name = "imgCarro";
            this.imgCarro.Size = new System.Drawing.Size(118, 108);
            this.imgCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCarro.TabIndex = 11;
            this.imgCarro.TabStop = false;
            // 
            // imgTeste
            // 
            this.imgTeste.Image = global::Componentes_2.Properties.Resources._4115235_exit_logout_sign_out_icon;
            this.imgTeste.Location = new System.Drawing.Point(22, 12);
            this.imgTeste.Name = "imgTeste";
            this.imgTeste.Size = new System.Drawing.Size(289, 168);
            this.imgTeste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTeste.TabIndex = 0;
            this.imgTeste.TabStop = false;
            // 
            // timerDeslocaCarro
            // 
            this.timerDeslocaCarro.Interval = 50;
            this.timerDeslocaCarro.Tick += new System.EventHandler(this.timerDeslocaCarro_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 576);
            this.Controls.Add(this.imgLinhaChegada);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.imgCaminhao);
            this.Controls.Add(this.imgCarro);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.btnSalvarTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlgo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgTeste);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgLinhaChegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCaminhao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTeste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtAlgo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarTexto;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerRelogio;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox imgCarro;
        private System.Windows.Forms.PictureBox imgCaminhao;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox imgLinhaChegada;
        private System.Windows.Forms.Timer timerDeslocaCarro;
    }
}

