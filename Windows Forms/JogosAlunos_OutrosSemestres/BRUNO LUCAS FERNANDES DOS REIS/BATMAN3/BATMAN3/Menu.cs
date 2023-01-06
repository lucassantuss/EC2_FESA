using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Flash_Jogo;
using jogo_labirintoo;
using BATMAN3;




namespace BATMAN3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(BATMAN3.Properties.Resources.Abertura_da_animao_da_Liga_da_Justia_HD);
            playCrash.Play();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void memoriabat_Click(object sender, EventArgs e)
        {
           
           
        }

        private void corridaflash_Click(object sender, EventArgs e)
        {
            Flash f = new Flash();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void pacwoman_Click(object sender, EventArgs e)
        {
            minigameMulherMaravilha f = new minigameMulherMaravilha();
            f.ShowDialog();
        }

        private void Configuraçoes_Click(object sender, EventArgs e)
        {
            Config f = new Config();
            f.ShowDialog();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            Sobre f = new Sobre();
            f.ShowDialog();
        }

        private void Controles_Click(object sender, EventArgs e)
        {
            comojogar f = new comojogar();
                f.ShowDialog();
        }

        private void ModoHistoria_Click(object sender, EventArgs e)
        {
            Batman f = new Batman();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
