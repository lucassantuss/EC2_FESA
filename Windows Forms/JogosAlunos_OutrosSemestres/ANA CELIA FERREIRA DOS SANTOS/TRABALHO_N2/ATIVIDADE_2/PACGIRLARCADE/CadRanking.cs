using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PACGIRLARCADE
{
    public partial class CadRanking : System.Windows.Forms.Form
    {
        public CadRanking()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtLogar.Text == "")
            {
                MessageBox.Show("ERRO!!!!!!! Nome não pode ser nulo!!");
            }
            else
            {
                string nomelogin = txtLogar.Text + Environment.NewLine;

                File.AppendAllText("ranking.txt", nomelogin);
                Application.DoEvents();
                this.Hide();
            }
        }
    }
}
