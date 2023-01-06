namespace Imperfectum
{
    partial class Loja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loja));
            this.lblPlayerBag = new System.Windows.Forms.Label();
            this.lblSellerBag = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.cbSeller = new System.Windows.Forms.ComboBox();
            this.btnVende = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.rtxtPlayer = new System.Windows.Forms.RichTextBox();
            this.rtxtSeller = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPlayerBag
            // 
            this.lblPlayerBag.AutoSize = true;
            this.lblPlayerBag.Location = new System.Drawing.Point(16, 14);
            this.lblPlayerBag.Name = "lblPlayerBag";
            this.lblPlayerBag.Size = new System.Drawing.Size(58, 13);
            this.lblPlayerBag.TabIndex = 0;
            this.lblPlayerBag.Text = "Player Bag";
            // 
            // lblSellerBag
            // 
            this.lblSellerBag.AutoSize = true;
            this.lblSellerBag.Location = new System.Drawing.Point(279, 14);
            this.lblSellerBag.Name = "lblSellerBag";
            this.lblSellerBag.Size = new System.Drawing.Size(55, 13);
            this.lblSellerBag.TabIndex = 1;
            this.lblSellerBag.Text = "Seller Bag";
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(446, 158);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 4;
            this.btnFecha.Text = "Fechar";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gold:";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(45, 163);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 6;
            // 
            // cbPlayer
            // 
            this.cbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(16, 30);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(158, 21);
            this.cbPlayer.TabIndex = 7;
            this.cbPlayer.SelectedIndexChanged += new System.EventHandler(this.cbPlayer_SelectedIndexChanged);
            // 
            // cbSeller
            // 
            this.cbSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeller.FormattingEnabled = true;
            this.cbSeller.Location = new System.Drawing.Point(282, 30);
            this.cbSeller.Name = "cbSeller";
            this.cbSeller.Size = new System.Drawing.Size(158, 21);
            this.cbSeller.TabIndex = 8;
            this.cbSeller.SelectedIndexChanged += new System.EventHandler(this.cbSeller_SelectedIndexChanged);
            // 
            // btnVende
            // 
            this.btnVende.Location = new System.Drawing.Point(180, 30);
            this.btnVende.Name = "btnVende";
            this.btnVende.Size = new System.Drawing.Size(75, 23);
            this.btnVende.TabIndex = 9;
            this.btnVende.Text = "Vender";
            this.btnVende.UseVisualStyleBackColor = true;
            this.btnVende.Click += new System.EventHandler(this.btnVende_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(446, 28);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(75, 23);
            this.btnCompra.TabIndex = 10;
            this.btnCompra.Text = "Comprar";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // rtxtPlayer
            // 
            this.rtxtPlayer.Location = new System.Drawing.Point(16, 58);
            this.rtxtPlayer.Name = "rtxtPlayer";
            this.rtxtPlayer.ReadOnly = true;
            this.rtxtPlayer.Size = new System.Drawing.Size(239, 96);
            this.rtxtPlayer.TabIndex = 11;
            this.rtxtPlayer.Text = "";
            // 
            // rtxtSeller
            // 
            this.rtxtSeller.Location = new System.Drawing.Point(282, 58);
            this.rtxtSeller.Name = "rtxtSeller";
            this.rtxtSeller.ReadOnly = true;
            this.rtxtSeller.Size = new System.Drawing.Size(239, 96);
            this.rtxtSeller.TabIndex = 12;
            this.rtxtSeller.Text = "";
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 189);
            this.Controls.Add(this.rtxtSeller);
            this.Controls.Add(this.rtxtPlayer);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnVende);
            this.Controls.Add(this.cbSeller);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.lblSellerBag);
            this.Controls.Add(this.lblPlayerBag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loja";
            this.Text = "Loja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerBag;
        private System.Windows.Forms.Label lblSellerBag;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.ComboBox cbSeller;
        private System.Windows.Forms.Button btnVende;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.RichTextBox rtxtPlayer;
        private System.Windows.Forms.RichTextBox rtxtSeller;
    }
}