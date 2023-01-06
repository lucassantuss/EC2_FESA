using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace jogo_labirintoo
{
    public partial class GameOver : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

       

        public GameOver()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = BATMAN3.Properties.Resources.risada_do_coringa1;
            player.Play();

        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            
           
        }

        private void sair_Click(object sender, EventArgs e)
        {
           
        }

        private void game_over_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
