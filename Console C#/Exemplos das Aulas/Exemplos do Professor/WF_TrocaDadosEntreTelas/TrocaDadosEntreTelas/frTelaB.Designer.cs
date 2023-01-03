namespace TrocaDadosEntreTelas
{
  partial class frTelaB
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
      this.txtNome = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(78, 40);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Digite seu nome:";
      // 
      // txtNome
      // 
      this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtNome.Location = new System.Drawing.Point(81, 56);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(100, 20);
      this.txtNome.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(112, 226);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(132, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Fechar a Tela";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frTelaB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(355, 270);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.label1);
      this.Name = "frTelaB";
      this.Text = "frTelaB";
      this.Load += new System.EventHandler(this.frTelaB_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    public System.Windows.Forms.TextBox txtNome;
  }
}