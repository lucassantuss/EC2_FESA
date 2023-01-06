using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoN2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            CreateFile();
            CarregarListBox();

            mpMusica.settings.playCount = 100;
        }
        int dificuldadeSelect = 1;
        int pontos = 0;
        private void BtnJogar_Click(object sender, EventArgs e)
        {
            if (txtNickName.Text.Trim().Length > 2)
            {
                FrmPlay telaJogar = new FrmPlay();
                telaJogar.Dificuldade = dificuldadeSelect;
                telaJogar.ShowDialog();

                pontos = telaJogar.Pontos;

                FrmGameOver gameOver = new FrmGameOver(pontos);
                gameOver.ShowDialog();

                UparResultado();

                CarregarListBox();
            }
            else
                MessageBox.Show("Assim não da para jogar. Escreva o nick name de pelo menos três letras.");
        }
        private void PicMusica_Click(object sender, EventArgs e)
        {
            picMusica.Visible = false;
            picMusicaX.Visible = true;
            mpMusica.Ctlcontrols.pause();
        }
        private void PicMusicaX_Click(object sender, EventArgs e)
        {
            picMusica.Visible = true;
            picMusicaX.Visible = false;
            mpMusica.Ctlcontrols.play();
        }
        private void PicCheck1_off_Click(object sender, EventArgs e)
        {
            picCheck1.Visible = true;
            picCheck2.Visible = false;
            picCheck3.Visible = false;

            dificuldadeSelect = 1;
        }
        private void PicCheck3_off_Click(object sender, EventArgs e)
        {
            picCheck1.Visible = false;
            picCheck2.Visible = false;
            picCheck3.Visible = true;
            dificuldadeSelect = 3;
        }
        private void PicCheck2_off_Click(object sender, EventArgs e)
        {
            picCheck1.Visible = false;
            picCheck2.Visible = true;
            picCheck3.Visible = false;
            dificuldadeSelect = 2;
        }
        
        
        /// <summary>
        /// Este metodo cria um arquivo txt
        /// </summary>
        static void CreateFile()
        {
            if (!File.Exists("db.txt"))
                File.WriteAllText("db.txt", "nickName|pontos" + Environment.NewLine);
        }


        /// <summary>
        /// Este metodo carrega o arquivo na listBox
        /// </summary>
        public void CarregarListBox()
        {
            lstRank.Items.Clear();
            string[] arquivo = File.ReadAllLines("db.txt");

            foreach (string linha in arquivo)
                if (linha != "nickName|pontos")
                    lstRank.Items.Add(linha.Split('|')[0].PadRight(11, ' ') + "| Pnts: " + linha.Split('|')[1]);
        }


        /// <summary>
        /// Este metodo Upa os resultado no arquivo
        /// </summary>
        public void UparResultado()
        {
            string[] arquivo = File.ReadAllLines("db.txt");

            bool pass = true;

            for (int i = 0; i < arquivo.Length; i++)
                if (arquivo[i].Split('|')[0] == txtNickName.Text.Trim().ToUpper())
                {
                    if(pontos > Convert.ToInt32(arquivo[i].Split('|')[1]))
                        arquivo[i] = txtNickName.Text.Trim().ToUpper() + "|" + pontos.ToString();
                   
                    pass = false;
                }
            

            File.WriteAllText("db.txt", "nickName|pontos" + Environment.NewLine);

            if(pass)
                File.AppendAllText("db.txt", txtNickName.Text.Trim().ToUpper() + "|" + pontos + Environment.NewLine);


            for (int i = 1; i < arquivo.Length; i++)
                File.AppendAllText("db.txt", arquivo[i] + Environment.NewLine);  
        }


        /// <summary>
        /// Este metpdo joga no textBox o jogador selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstRank_Click(object sender, EventArgs e)
        {
            if (lstRank.SelectedItem != null) 
            {
                txtNickName.Text = lstRank.SelectedItem.ToString().Split('|')[0].Trim();
            }
            else
            {
                MessageBox.Show("Seleione um item, por favor.");
            }
           
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            frSobre telasobre = new frSobre();
            telasobre.ShowDialog();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            frAjuda telaajuda = new frAjuda();
            telaajuda.ShowDialog();
        }
    }
}
