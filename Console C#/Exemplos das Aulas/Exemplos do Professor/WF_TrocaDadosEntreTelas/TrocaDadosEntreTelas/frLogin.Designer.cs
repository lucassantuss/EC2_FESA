namespace TrocaDadosEntreTelas
{
  partial class frLogin
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
      this.txtLogin = new System.Windows.Forms.TextBox();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(28, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Login";
      // 
      // txtLogin
      // 
      this.txtLogin.Location = new System.Drawing.Point(31, 25);
      this.txtLogin.Name = "txtLogin";
      this.txtLogin.Size = new System.Drawing.Size(100, 20);
      this.txtLogin.TabIndex = 1;
      // 
      // txtSenha
      // 
      this.txtSenha.Location = new System.Drawing.Point(31, 68);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(100, 20);
      this.txtSenha.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(28, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Senha";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::TrocaDadosEntreTelas.Properties.Resources.if_key_1055040;
      this.pictureBox1.Location = new System.Drawing.Point(149, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(100, 98);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(31, 100);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Login";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(261, 135);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtLogin);
      this.Controls.Add(this.label1);
      this.Name = "frLogin";
      this.Text = "frLogin";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtLogin;
    private System.Windows.Forms.TextBox txtSenha;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button button1;
  }
}