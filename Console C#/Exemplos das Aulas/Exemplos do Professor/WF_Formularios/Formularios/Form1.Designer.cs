namespace Formularios
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
      this.btnSobre = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnSobre
      // 
      this.btnSobre.Location = new System.Drawing.Point(529, 23);
      this.btnSobre.Name = "btnSobre";
      this.btnSobre.Size = new System.Drawing.Size(75, 23);
      this.btnSobre.TabIndex = 1;
      this.btnSobre.Text = "Sobre";
      this.btnSobre.UseVisualStyleBackColor = true;
      this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(616, 386);
      this.Controls.Add(this.btnSobre);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSobre;
  }
}

