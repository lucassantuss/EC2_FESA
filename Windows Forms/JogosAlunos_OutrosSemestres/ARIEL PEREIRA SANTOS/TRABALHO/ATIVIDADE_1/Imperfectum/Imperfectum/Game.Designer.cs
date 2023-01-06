namespace Imperfectum
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblXp = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbArmas = new System.Windows.Forms.ComboBox();
            this.cbPots = new System.Windows.Forms.ComboBox();
            this.btnUsaArma = new System.Windows.Forms.Button();
            this.btnUsaPot = new System.Windows.Forms.Button();
            this.btnNorte = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.rtbMensagens = new System.Windows.Forms.RichTextBox();
            this.rtbLugar = new System.Windows.Forms.RichTextBox();
            this.dgvBag = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbNpc = new System.Windows.Forms.ComboBox();
            this.btnInteragir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbLugar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.pbMonstro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLugar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonstro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Level:";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(623, 22);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(35, 13);
            this.lblVida.TabIndex = 5;
            this.lblVida.Text = "label5";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(682, 22);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(35, 13);
            this.lblGold.TabIndex = 6;
            this.lblGold.Text = "label6";
            // 
            // lblXp
            // 
            this.lblXp.AutoSize = true;
            this.lblXp.Location = new System.Drawing.Point(744, 22);
            this.lblXp.Name = "lblXp";
            this.lblXp.Size = new System.Drawing.Size(35, 13);
            this.lblXp.TabIndex = 7;
            this.lblXp.Text = "label7";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(808, 22);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(35, 13);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecione Ação:";
            // 
            // cbArmas
            // 
            this.cbArmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArmas.FormattingEnabled = true;
            this.cbArmas.Location = new System.Drawing.Point(605, 336);
            this.cbArmas.Name = "cbArmas";
            this.cbArmas.Size = new System.Drawing.Size(121, 21);
            this.cbArmas.TabIndex = 10;
            this.cbArmas.SelectedIndexChanged += new System.EventHandler(this.cbArmas_SelectedIndexChanged);
            // 
            // cbPots
            // 
            this.cbPots.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPots.FormattingEnabled = true;
            this.cbPots.Location = new System.Drawing.Point(605, 363);
            this.cbPots.Name = "cbPots";
            this.cbPots.Size = new System.Drawing.Size(121, 21);
            this.cbPots.TabIndex = 11;
            // 
            // btnUsaArma
            // 
            this.btnUsaArma.Location = new System.Drawing.Point(733, 336);
            this.btnUsaArma.Name = "btnUsaArma";
            this.btnUsaArma.Size = new System.Drawing.Size(75, 23);
            this.btnUsaArma.TabIndex = 12;
            this.btnUsaArma.Text = "Usar";
            this.btnUsaArma.UseVisualStyleBackColor = true;
            this.btnUsaArma.Click += new System.EventHandler(this.btnUsaArma_Click);
            // 
            // btnUsaPot
            // 
            this.btnUsaPot.Location = new System.Drawing.Point(732, 361);
            this.btnUsaPot.Name = "btnUsaPot";
            this.btnUsaPot.Size = new System.Drawing.Size(75, 23);
            this.btnUsaPot.TabIndex = 13;
            this.btnUsaPot.Text = "Usar";
            this.btnUsaPot.UseVisualStyleBackColor = true;
            this.btnUsaPot.Click += new System.EventHandler(this.btnUsaPot_Click);
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(976, 334);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(75, 23);
            this.btnNorte.TabIndex = 14;
            this.btnNorte.Text = "Norte";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.btnNorte_Click);
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(976, 363);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(75, 23);
            this.btnSul.TabIndex = 15;
            this.btnSul.Text = "Sul";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // rtbMensagens
            // 
            this.rtbMensagens.Location = new System.Drawing.Point(605, 55);
            this.rtbMensagens.Name = "rtbMensagens";
            this.rtbMensagens.ReadOnly = true;
            this.rtbMensagens.Size = new System.Drawing.Size(174, 206);
            this.rtbMensagens.TabIndex = 16;
            this.rtbMensagens.Text = "";
            // 
            // rtbLugar
            // 
            this.rtbLugar.Location = new System.Drawing.Point(605, 267);
            this.rtbLugar.Name = "rtbLugar";
            this.rtbLugar.ReadOnly = true;
            this.rtbLugar.Size = new System.Drawing.Size(174, 49);
            this.rtbLugar.TabIndex = 17;
            this.rtbLugar.Text = "";
            // 
            // dgvBag
            // 
            this.dgvBag.AllowUserToAddRows = false;
            this.dgvBag.AllowUserToDeleteRows = false;
            this.dgvBag.AllowUserToResizeRows = false;
            this.dgvBag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBag.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBag.Enabled = false;
            this.dgvBag.Location = new System.Drawing.Point(811, 55);
            this.dgvBag.MultiSelect = false;
            this.dgvBag.Name = "dgvBag";
            this.dgvBag.ReadOnly = true;
            this.dgvBag.RowHeadersVisible = false;
            this.dgvBag.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBag.Size = new System.Drawing.Size(240, 117);
            this.dgvBag.TabIndex = 18;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(811, 178);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(240, 117);
            this.dgvQuests.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(973, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mover-se:";
            // 
            // cbNpc
            // 
            this.cbNpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNpc.FormattingEnabled = true;
            this.cbNpc.Location = new System.Drawing.Point(829, 336);
            this.cbNpc.Name = "cbNpc";
            this.cbNpc.Size = new System.Drawing.Size(121, 21);
            this.cbNpc.TabIndex = 21;
            // 
            // btnInteragir
            // 
            this.btnInteragir.Location = new System.Drawing.Point(853, 363);
            this.btnInteragir.Name = "btnInteragir";
            this.btnInteragir.Size = new System.Drawing.Size(75, 23);
            this.btnInteragir.TabIndex = 22;
            this.btnInteragir.Text = "Interagir";
            this.btnInteragir.UseVisualStyleBackColor = true;
            this.btnInteragir.Click += new System.EventHandler(this.btnInteragir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(826, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "NPCs:";
            // 
            // pbLugar
            // 
            this.pbLugar.Location = new System.Drawing.Point(0, -5);
            this.pbLugar.Name = "pbLugar";
            this.pbLugar.Size = new System.Drawing.Size(596, 406);
            this.pbLugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLugar.TabIndex = 24;
            this.pbLugar.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(883, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar Pontuação";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMute.BackgroundImage")));
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMute.Location = new System.Drawing.Point(1026, 12);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(25, 23);
            this.btnMute.TabIndex = 26;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // pbMonstro
            // 
            this.pbMonstro.BackColor = System.Drawing.Color.Transparent;
            this.pbMonstro.Location = new System.Drawing.Point(12, 232);
            this.pbMonstro.Name = "pbMonstro";
            this.pbMonstro.Size = new System.Drawing.Size(148, 150);
            this.pbMonstro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMonstro.TabIndex = 27;
            this.pbMonstro.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 394);
            this.Controls.Add(this.pbMonstro);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbLugar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInteragir);
            this.Controls.Add(this.cbNpc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvBag);
            this.Controls.Add(this.rtbLugar);
            this.Controls.Add(this.rtbMensagens);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.btnUsaPot);
            this.Controls.Add(this.btnUsaArma);
            this.Controls.Add(this.cbPots);
            this.Controls.Add(this.cbArmas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblXp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1079, 432);
            this.MinimumSize = new System.Drawing.Size(1079, 432);
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLugar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonstro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblXp;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbArmas;
        private System.Windows.Forms.ComboBox cbPots;
        private System.Windows.Forms.Button btnUsaArma;
        private System.Windows.Forms.Button btnUsaPot;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.Button btnSul;
        private System.Windows.Forms.RichTextBox rtbMensagens;
        private System.Windows.Forms.RichTextBox rtbLugar;
        private System.Windows.Forms.DataGridView dgvBag;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNpc;
        private System.Windows.Forms.Button btnInteragir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbLugar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.PictureBox pbMonstro;
    }
}