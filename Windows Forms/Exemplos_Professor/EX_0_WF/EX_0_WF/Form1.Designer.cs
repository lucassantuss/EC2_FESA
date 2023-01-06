
namespace EX_0_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.NumericUpDown();
            this.txtValor2 = new System.Windows.Forms.NumericUpDown();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgDivide = new System.Windows.Forms.PictureBox();
            this.imgMultiplica = new System.Windows.Forms.PictureBox();
            this.imgSubtrai = new System.Windows.Forms.PictureBox();
            this.imgSoma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMultiplica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSubtrai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSoma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2";
            // 
            // txtValor1
            // 
            this.txtValor1.DecimalPlaces = 3;
            this.txtValor1.Location = new System.Drawing.Point(155, 28);
            this.txtValor1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(152, 31);
            this.txtValor1.TabIndex = 2;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor1.ThousandsSeparator = true;
            // 
            // txtValor2
            // 
            this.txtValor2.DecimalPlaces = 3;
            this.txtValor2.Location = new System.Drawing.Point(155, 89);
            this.txtValor2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(152, 31);
            this.txtValor2.TabIndex = 3;
            this.txtValor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor2.ThousandsSeparator = true;
            // 
            // txtResultado
            // 
            this.txtResultado.DecimalPlaces = 3;
            this.txtResultado.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtResultado.Location = new System.Drawing.Point(155, 232);
            this.txtResultado.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(152, 31);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EX_0_WF.Properties.Resources._4115235_exit_logout_sign_out_icon;
            this.pictureBox1.Location = new System.Drawing.Point(304, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgDivide
            // 
            this.imgDivide.Image = global::EX_0_WF.Properties.Resources._216176_divide_icon;
            this.imgDivide.Location = new System.Drawing.Point(283, 146);
            this.imgDivide.Name = "imgDivide";
            this.imgDivide.Size = new System.Drawing.Size(63, 58);
            this.imgDivide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDivide.TabIndex = 9;
            this.imgDivide.TabStop = false;
            this.imgDivide.Click += new System.EventHandler(this.imgDivide_Click);
            // 
            // imgMultiplica
            // 
            this.imgMultiplica.Image = global::EX_0_WF.Properties.Resources._216463_times_icon;
            this.imgMultiplica.Location = new System.Drawing.Point(199, 146);
            this.imgMultiplica.Name = "imgMultiplica";
            this.imgMultiplica.Size = new System.Drawing.Size(63, 58);
            this.imgMultiplica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMultiplica.TabIndex = 8;
            this.imgMultiplica.TabStop = false;
            this.imgMultiplica.Click += new System.EventHandler(this.imgMultiplica_Click);
            // 
            // imgSubtrai
            // 
            this.imgSubtrai.Image = global::EX_0_WF.Properties.Resources._2561243_minus_circle_icon;
            this.imgSubtrai.Location = new System.Drawing.Point(116, 146);
            this.imgSubtrai.Name = "imgSubtrai";
            this.imgSubtrai.Size = new System.Drawing.Size(63, 58);
            this.imgSubtrai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSubtrai.TabIndex = 7;
            this.imgSubtrai.TabStop = false;
            this.imgSubtrai.Click += new System.EventHandler(this.imgSubtrai_Click);
            // 
            // imgSoma
            // 
            this.imgSoma.Image = global::EX_0_WF.Properties.Resources._1814113_add_more_plus_icon;
            this.imgSoma.Location = new System.Drawing.Point(29, 146);
            this.imgSoma.Name = "imgSoma";
            this.imgSoma.Size = new System.Drawing.Size(63, 58);
            this.imgSoma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSoma.TabIndex = 6;
            this.imgSoma.TabStop = false;
            this.imgSoma.Click += new System.EventHandler(this.imgSoma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgDivide);
            this.Controls.Add(this.imgMultiplica);
            this.Controls.Add(this.imgSubtrai);
            this.Controls.Add(this.imgSoma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de pobre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDivide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMultiplica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSubtrai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSoma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtValor1;
        private System.Windows.Forms.NumericUpDown txtValor2;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgSoma;
        private System.Windows.Forms.PictureBox imgSubtrai;
        private System.Windows.Forms.PictureBox imgMultiplica;
        private System.Windows.Forms.PictureBox imgDivide;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

