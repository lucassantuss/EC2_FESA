using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BATMAN3
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(BATMAN3.Properties.Resources.Abertura_da_animao_da_Liga_da_Justia_HD);
            playCrash.Play();
        }

        private void Ligamusica_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(BATMAN3.Properties.Resources.Abertura_da_animao_da_Liga_da_Justia_HD);
            playCrash.Stop();
        }
    }
}
