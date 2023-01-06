using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PACGIRLARCADE
{
    public partial class Form3 : Form
    {
        int pontosX = 0, pontosO = 0, empates = 0, rodadas = 0;
        bool turno = true, jogo_final = false;
        string[] texto = new string[9];

        public Form3()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btn.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";

            rodadas = 0;
            jogo_final = false;
            for (int i =0; i < 9; i++)
            {
                texto[i] = "";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonIndex = btn.TabIndex;

            if (btn.Text == "" && jogo_final == false)
            {

                if (turno)
                {
                    btn.Text = "X";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(1);
                }
                else
                {
                    btn.Text = "O";
                    texto[buttonIndex] = btn.Text;
                    rodadas++;
                    turno = !turno;
                    Checagem(2);
                }
            }
        }

        void Vencedor (int JogadorGanhador)
        {
            jogo_final = true;

            if(JogadorGanhador == 1)
            {
                pontosX++;
                xPontos.Text = Convert.ToString(pontosX); 
                MessageBox.Show("Jogador X ganhou");
                turno = true;
            }
            else 
            {
                pontosO++;
                oPontos.Text = Convert.ToString(pontosO);
                MessageBox.Show("Jogador O ganhou");
                turno = false;
            }
        }

        void Checagem(int ChecagemJogador)
        {
            string suporte;

            if (ChecagemJogador == 1)
            {
                suporte = "X";
            }
            else
            {
                suporte = "O";
            }

            for (int horizontal = 0; horizontal < 8; horizontal += 3)
            {
                if (suporte == texto[horizontal])
                {
                    if (texto[horizontal] == texto[horizontal + 1] && texto[horizontal] == texto[horizontal + 2])
                    {
                        Vencedor(ChecagemJogador);
                        return;
                    }
                }
            }

            for (int vertical = 0; vertical < 3; vertical++)
            {
                if (suporte == texto[vertical])
                {
                    if (texto[vertical] == texto[vertical + 3] && texto[vertical] == texto[vertical + 6])
                    {
                        Vencedor(ChecagemJogador);
                        return;
                    }
                }
            }

            if (texto[0] == suporte)
            {
                if (texto[0] == texto[4] && texto[0] == texto[8])
                {
                    Vencedor(ChecagemJogador);
                    return;
                }
            }
            if (texto[2] == suporte)
            {
                if (texto[2] == texto[4] && texto[2] == texto[6])
                {
                    Vencedor(ChecagemJogador);
                    return;
                }
            }

            if (rodadas == 9 && jogo_final == false)
            {
                empates++;
                Empate.Text = Convert.ToString(empates);
                MessageBox.Show("Empate!");
                jogo_final = true;
                return;
            }
        }
    }
}
