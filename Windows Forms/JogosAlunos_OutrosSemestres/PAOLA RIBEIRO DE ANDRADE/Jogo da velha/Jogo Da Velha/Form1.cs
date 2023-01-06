using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_Da_Velha
{
    public partial class Form1 : Form
    {
        int Xpontuacao = 0, Opontuacao = 0, empates = 0, rodadas =0;
        bool turno = true, jogo_final= false;
        string[] texto = new string[9];
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("Naruto OST 1 - Go Go Naruto!_160k.wav");
            MessageBox.Show("Naruto e Jiraya decidiram apostar para ver quem ganha no jogo da velha valendo rámen" + Environment.NewLine +"(Chame um amigo para jogar este jogo)" + Environment.NewLine + Environment.NewLine + "Aperte 'Ok' para uma nova partida");

        }

        /// <summary>
        /// apresenta ao usuário de quem é a vez de jogar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;
            
            if (btn.Text == ""&& jogo_final==false) 
            {
            if (turno) { VezDeQuem.Text = "Jiraya"; }
            if (!turno) { VezDeQuem.Text = "Naruto"; }

                if (turno)
            {
                
                btn.Text = "X";
                texto[buttonIndex] = btn.Text;
                rodadas++;
                turno = !turno;
                checagem(1);
            }
            else
            {
               
                btn.Text = "O";
                texto[buttonIndex] = btn.Text;
                rodadas++;
                turno = !turno;
                checagem(2);
                }
            }
        }

        /// <summary>
        /// //limpa os botões
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clean_Click(object sender, EventArgs e) 
        {
         
            btn.Text="";
            button1.Text = "";
            button2.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            rodadas = 0;
            // define o jogo para a situação inicial
            jogo_final = false;
            //limpa os vetores
            for (int i = 0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        /// <summary>
        /// define qual jogador ganha, define situação para final de jogo, exibe mensagem de vitória
        /// </summary>
        /// <param name="PlayerQueGanhou"></param>
        void Vencedor(int PlayerQueGanhou) 
        {
           
            
            jogo_final = true;
            
            if(PlayerQueGanhou==1)
            {
                MessageBox.Show("Parabéns Naruto, Você ganhou o turno e recebeu uma rodada de rámen"+ Environment.NewLine+ Environment.NewLine + "Aperte 'Ok' para uma nova partida");
                Xpontuacao++;
                turno = true;
                Xpontos.Text = Convert.ToString(Xpontuacao);
            }
            if (PlayerQueGanhou == 2)
            {
                MessageBox.Show("Infelizmente Jiraya venceu, Naruto vai ter que fazer o jutsu sexy ( ͡° ͜ʖ ͡°)" + Environment.NewLine + Environment.NewLine + "Aperte 'Ok' para uma nova partida");
                Opontuacao++;
                turno = false;
                BolinhaPontos.Text = Convert.ToString(Opontuacao);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VezDeQuem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checa as condições de vitória
        /// </summary>
        /// <param name="ChecagemPlayer"></param>
        void checagem(int ChecagemPlayer)
        {
            //checagem de jogo
            string suporte = "";

            if (ChecagemPlayer == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte="O";
            }
            //checa as fileiras da horizontal
            for(int horizontal=0; horizontal< 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if(texto[horizontal]==texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2]) 
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }
            //checa as fileiras da vertical
            for (int vertical = 0; vertical < 3; vertical ++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(ChecagemPlayer);
                        return;
                    }
                }
            }
            //checa as fileiras da diagonais
            if (texto[0] == suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(ChecagemPlayer);

                    return;
                }
            }
            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[0] == texto[6])
                {
                    Vencedor(ChecagemPlayer);
                    return;
                }
            }
            //define quando o jogo empata (veia)
            if (rodadas == 9 && jogo_final == false)
            {
                empates++;
                Empates.Text = Convert.ToString(empates);
                MessageBox.Show("Deu véia, enquanto vocês jogam o pain ta bolando um plano pra atacar a vila" + Environment.NewLine + Environment.NewLine + "Aperte 'Ok' para uma nova partida");
                jogo_final = true;
                return;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
