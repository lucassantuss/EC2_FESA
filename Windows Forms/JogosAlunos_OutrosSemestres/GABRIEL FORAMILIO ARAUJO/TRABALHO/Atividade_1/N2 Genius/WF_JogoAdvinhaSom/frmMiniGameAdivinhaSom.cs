using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_JogoAdvinhaSom
{
    public partial class frmMiniGameAdivinhaSom : Form
    {
        public frmMiniGameAdivinhaSom()
        {
            InitializeComponent();

            imgMusic1.ImageLocation = "play.png";
            imgMusic3.ImageLocation = "play.png";
            imgMusic2.ImageLocation = "play.png";
            imgMusic4.ImageLocation = "play.png";

            txtAV.CharacterCasing = CharacterCasing.Upper;
            txtHP.CharacterCasing = CharacterCasing.Upper;
            txtSW.CharacterCasing = CharacterCasing.Upper;
            txtTS.CharacterCasing = CharacterCasing.Upper;

            
        }

        


        private void imgMusic1_Click(object sender, EventArgs e)
        {
            if (imgMusic1.ImageLocation == "play.png")
            {
                imgMusic1.ImageLocation = "stop.png";
                mp1.URL = "Star Wars The Imperial March.mp3";
                mp1.Ctlcontrols.play();
            }
            else
            {
                imgMusic1.ImageLocation = "play.png";
                mp1.Ctlcontrols.stop();
            }
        }

        private void imgMusic2_Click(object sender, EventArgs e)
        {
            if (imgMusic2.ImageLocation == "play.png")
            {
                imgMusic2.ImageLocation = "stop.png";
                mp2.URL = "Amigo Estou Aqui.mp3";
                mp2.Ctlcontrols.play();
            }
            else
            {
                imgMusic2.ImageLocation = "play.png";
                mp2.Ctlcontrols.stop();
            }
        }

        private void imgMusic3_Click(object sender, EventArgs e)
        {
            if (imgMusic3.ImageLocation == "play.png")
            {
                imgMusic3.ImageLocation = "stop.png";
                mp3.URL = "Harry Potter.mp3";
                mp3.Ctlcontrols.play();
            }
            else
            {
                imgMusic3.ImageLocation = "play.png";
                mp3.Ctlcontrols.stop();
            }
        }

        private void imgMusic4_Click(object sender, EventArgs e)
        {
            if (imgMusic4.ImageLocation == "play.png")
            {
                imgMusic4.ImageLocation = "stop.png";
                mp4.URL = "Os Vingadores.mp3";
                mp4.Ctlcontrols.play();
            }
            else
            {
                imgMusic4.ImageLocation = "play.png";
                mp4.Ctlcontrols.stop();
            }
        }

        private void txtSW_TextChanged(object sender, EventArgs e)
        {
            if (txtSW.Text == "STAR WARS")
            {
                MessageBox.Show("Parabéns!");
                pbPoster.Visible = Enabled;
                pbPoster.ImageLocation = "Star wars.jpg";
            }
                
        }

        private void txtTS_TextChanged(object sender, EventArgs e)
        {
            if (txtTS.Text == "TOY STORY")
            {
                MessageBox.Show("Parabéns!");
                pbPoster.Visible = Enabled;
                pbPoster.ImageLocation = "Toy Story.jpg";
            }
        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {
            if (txtHP.Text == "HARRY POTTER")
            {
                MessageBox.Show("Parabéns!");
                pbPoster.Visible = Enabled;
                pbPoster.ImageLocation = "Harry Potter.jpg";
            }
        }

        private void txtAV_TextChanged(object sender, EventArgs e)
        {
            if (txtAV.Text == "VINGADORES")
            {
                MessageBox.Show("Parabéns!");
                pbPoster.Visible = Enabled;
                pbPoster.ImageLocation = "Vingadores.jpg";
                FimJogo();
            }
        }

        private void FimJogo()
        {
            if(txtSW.Text == "STAR WARS" && txtTS.Text == "TOY STORY" && 
                txtHP.Text == "HARRY POTTER" && txtAV.Text == "VINGADORES")
            {
                DialogResult msg = MessageBox.Show("Deseja continuar o jogo?", "Caixa de pergunta", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    txtAV.Clear();
                    txtHP.Clear();
                    txtSW.Clear();
                    txtTS.Clear();
                }
                else if (msg == DialogResult.No)
                {
                    MessageBox.Show("Obrigado por jogar");
                    Application.Exit();
                }
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobreMinigame s1 = new frmSobreMinigame();
            s1.Show();
        }
    }
}
