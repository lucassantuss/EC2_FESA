using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoN2
{
    public partial class FrmPlay : Form
    {
        public FrmPlay()
        {
            InitializeComponent();
            InicioCenarioDef();
        }
        private int contadorPulo = 0;
        

        /// <summary>
        /// Este metodo captura se o usuario esta apertando espace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPlay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && picNarutoCorrendo1.Left == 320 && picNarutoUp.Top == 350 && picNarutoUp.Top > 95)
            {
                tmGravidade.Interval = 70;
                tmNarutoAnimacao.Interval = 30;
                contadorPulo = -84;
            }
            else if (e.KeyCode == Keys.Space && picNarutoCorrendo1.Left == 320 && picNarutoUp.Top > 95)
            {
                tmGravidade.Interval = 70;
                tmNarutoAnimacao.Interval = 30;
                contadorPulo = -42;
            }
        }


        /// <summary>
        /// Este metodo simula a gravidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmGravidade(object sender, EventArgs e)
        {
            if (picNarutoUp.Top != 350)
            {
                picNarutoUp.Top += 7;
                picNarutoGirando1.Top += 7;
                picNarutoGirando2.Top += 7;
            }
        }


        /// <summary>
        /// Este metodo faz a animação do naturo, trocando de imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmNarutoAnimacao(object sender, EventArgs e)
        {
            if (contadorPulo < 0 && picNarutoCorrendo1.Left == 320)
            {
                tmNarutoAnimacao.Interval = 40;
                picNarutoUp.Top -= 7;
                picNarutoGirando1.Top -= 7;
                picNarutoGirando2.Top -= 7;
                contadorPulo += 7;
            }

            if (contadorPulo != 0 && picNarutoUp.Top != 350 && picNarutoCorrendo1.Left == 320)
            {
                tmNarutoAnimacao.Interval = 10;
                picNarutoCorrendo1.Visible = false;
                picNarutoCorrendo2.Visible = false;
                picNarutoUp.Visible = true;

                picNarutoGirando1.Visible = false;
                picNarutoGirando2.Visible = false;
            }
            else if (contadorPulo == 0 && picNarutoUp.Top != 350 && picNarutoCorrendo1.Left == 320)
            {
                tmNarutoAnimacao.Interval = 100;
                picNarutoCorrendo1.Visible = false;
                picNarutoCorrendo2.Visible = false;
                picNarutoUp.Visible = false;
                picNarutoGirando1.Visible = true;
                picNarutoGirando2.Visible = true;

                NarutoAnimacao(picNarutoGirando1, picNarutoGirando2);

            }
            else if (picNarutoUp.Top == 350 && picNarutoCorrendo1.Left == 320)
            {
                tmNarutoAnimacao.Interval = 200;

                picNarutoUp.Visible = false;
                picNarutoCorrendo1.Visible = true;
                picNarutoCorrendo2.Visible = true;

                picNarutoGirando1.Visible = false;
                picNarutoGirando2.Visible = false;

                NarutoAnimacao(picNarutoCorrendo1, picNarutoCorrendo2);
            }
            else if (picNarutoCorrendo1.Left < 320)
            {
                tmNarutoAnimacao.Interval = 80;
                NarutoAnimacao(picNarutoCorrendo1, picNarutoCorrendo2);
                CentralizarNaturo(picNarutoCorrendo1);
                CentralizarNaturo(picNarutoCorrendo2);
            }
        }
        int mover = -3;


        /// <summary>
        /// Este metodo faz a movimentação do cenario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmCenario(object sender, EventArgs e)
        {

            if (picNuvem1.Left >= -1380 * 2)
            {
                picNuvem1.Left += -2;
                picNuvem2.Left += -2;
            }
            else
            {
                picNuvem1.Left = 700;
                picNuvem2.Left = 2080;

                picNuvem1.Left += -2;
                picNuvem2.Left += -2;
            }

            if (picChao1.Left > -83 && picNarutoCorrendo1.Left > 318)
            {
                picChao1.Left += mover;
                picChao2.Left += mover;
                picChao3.Left += mover;
                picChao4.Left += mover;
                picChao5.Left += mover;
                picChao6.Left += mover;
                picChao7.Left += mover;
                picChao8.Left += mover;
                picChao9.Left += mover;
                picChao10.Left += mover;

            }
            else if (picNarutoCorrendo1.Left > 318)
            {
                picChao1.Left = 0;
                picChao2.Left = 82;
                picChao3.Left = 164;
                picChao4.Left = 246;
                picChao5.Left = 328;
                picChao6.Left = 410;
                picChao7.Left = 492;
                picChao8.Left = 574;
                picChao9.Left = 656;
                picChao10.Left = 738;

                picChao1.Left += mover;
                picChao2.Left += mover;
                picChao3.Left += mover;
                picChao4.Left += mover;
                picChao5.Left += mover;
                picChao6.Left += mover;
                picChao7.Left += mover;
                picChao8.Left += mover;
                picChao9.Left += mover;
                picChao10.Left += mover;
            }
            
        }
        int indiceNarutoAndando = 1;


        /// <summary>
        /// Este metodo faz a função de trocar as imagens.
        /// </summary>
        /// <param name="picOne"></param>
        /// <param name="picTwo"></param>
        public void NarutoAnimacao(PictureBox picOne, PictureBox picTwo)
        {
            if (indiceNarutoAndando == 1)
            {
                picOne.Visible = true;
                picTwo.Visible = false;

                indiceNarutoAndando = 2;
            }
            else
            {
                picOne.Visible = false;
                picTwo.Visible = true;

                indiceNarutoAndando = 1;
            }
         
        }


        /// <summary>
        /// Este metodo faz o naruto ir para o centro da tela.
        /// </summary>
        /// <param name="pic"></param>
        public void CentralizarNaturo(PictureBox pic)
        {
            if (pic.Left <= 320)
                pic.Left += 10;

        }


        /// <summary>
        /// Este metodo faz as imagens ir para as posição de inicio.
        /// </summary>
        private void InicioCenarioDef()
        {
            picNarutoUp.Left = 320;
            picNarutoUp.Top = 350;
            picNarutoUp.Visible = false;

            picNarutoCorrendo1.Left = 250;
            picNarutoCorrendo1.Top = 350;
            picNarutoCorrendo1.Visible = false;

            picNarutoCorrendo2.Left = 250;
            picNarutoCorrendo2.Top = 350;
            picNarutoCorrendo2.Visible = false;

            picNarutoGirando1.Left = 320;
            picNarutoGirando1.Top = 350;
            picNarutoGirando1.Visible = false;

            picNarutoGirando2.Left = 320;
            picNarutoGirando2.Top = 350;
            picNarutoGirando2.Visible = false;

            picChao1.Left = 0;
            picChao1.Top = 408;

            picChao2.Left = 82;
            picChao2.Top = 408;

            picChao3.Left = 164;
            picChao3.Top = 408;

            picChao4.Left = 246;
            picChao4.Top = 408;

            picChao5.Left = 328;
            picChao5.Top = 408;

            picChao6.Left = 410;
            picChao6.Top = 408;

            picChao7.Left = 492;
            picChao7.Top = 408;

            picChao8.Left = 574;
            picChao8.Top = 408;

            picChao9.Left = 656;
            picChao9.Top = 408;

            picChao10.Left = 738;
            picChao10.Top = 408;

            picArbusto1.Left = 738;
            picArbusto1.Top = 334;

            picArbusto2.Left = 738;
            picArbusto2.Top = 334;

            picArbusto3.Left = 738;
            picArbusto3.Top = 334;

            picArbusto4.Left = 738;
            picArbusto4.Top = 334;

            picNuvem1.Left = 0;
            picNuvem1.Top = 0;

            picNuvem2.Left = 1380;
            picNuvem2.Top = 0;

            picChocolate1_1.Left = 738;
            picChocolate1_2.Left = 738;

            picChocolate2_1.Left = 738;
            picChocolate2_2.Left = 738;

            picChocolate3_1.Left = 738;
            picChocolate3_2.Left = 738;

            picChocolate4_1.Left = 738;
            picChocolate4_2.Left = 738;

            picChocolate5_1.Left = 738;
            picChocolate5_2.Left = 738;
        }
        private bool[] slot = new bool[10];
        private Random valor = new Random();


        /// <summary>
        /// Este metodo libera os desafios para ser carregado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmDesafio(object sender, EventArgs e)
        {

            if (this.Dificuldade == 1)
            {
                tmDesafio.Interval = 8000;
                slot[valor.Next(4)] = true;
                mover = -3;
            }
            else if (this.Dificuldade == 2)
            {
                tmDesafio.Interval = 5500;
                slot[valor.Next(10)] = true;
                mover = -4;
            }
            else if (this.Dificuldade == 3)
            {
                tmDesafio.Interval = 4500;
                slot[valor.Next(4, 10)] = true;
                mover = -7;
            }
            
            ++this.Pontos;

           
        }
        bool faseNormal = true;
        public int Pontos { get; set; }
        public int Dificuldade { get; set; }


        /// <summary>
        /// Este metodo faz os desafios andarem na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmPercursoDesafio(object sender, EventArgs e)
        {
            if (slot[0])
            {
                picArbusto1.Left += mover;

                if (picArbusto1.Left < -500)
                {
                    slot[0] = false;
                    picArbusto1.Left = 738;
                    ++this.Pontos;
                }

                if (faseNormal && picArbusto1.Location.X > 185 && picArbusto1.Location.X < 380 && picNarutoGirando1.Location.Y > 297)
                    this.Close();
            }
            
            if (slot[1])
            {
                picArbusto2.Left += mover;

                if (picArbusto2.Left < -500)
                {
                    slot[1] = false;
                    picArbusto2.Left = 738;
                    ++this.Pontos;
                }
                if (faseNormal && picArbusto2.Location.X > 185 && picArbusto2.Location.X < 380 && picNarutoGirando1.Location.Y > 297)
                    this.Close();
            }
            if(slot[2])
            {
                picArbusto3.Left += mover;

                if (picArbusto3.Left < -500)
                {
                    slot[2] = false;
                    picArbusto3.Left = 738;
                    ++this.Pontos;
                }
                if (faseNormal && picArbusto3.Location.X > 185 && picArbusto3.Location.X < 380 && picNarutoGirando1.Location.Y > 297)
                    this.Close();
            }
            if(slot[3])
            {
                picArbusto4.Left += mover;

                if (picArbusto4.Left < -500)
                {
                    slot[3] = false;
                    picArbusto4.Left = 738;
                    ++this.Pontos;
                }
                if (faseNormal && picArbusto4.Location.X > 185 && picArbusto4.Location.X < 380 && picNarutoGirando1.Location.Y > 297)
                    this.Close();
            }
            if(slot[4])
            {
                picChocolate1_1.Left += mover;
                picChocolate1_2.Left += mover;

                if (picChocolate1_1.Left < -20)
                {
                    slot[4] = false;
                    picChocolate1_1.Left = 738;
                    picChocolate1_2.Left = 738;
                    ++this.Pontos;
                }

                if (faseNormal && picChocolate1_1.Location.X > 310 && picChocolate1_1.Location.X < 380 && (picNarutoGirando1.Location.Y < 139 || picNarutoGirando1.Location.Y > 202))
                    this.Close();
            }
            if(slot[5])
            {
                picChocolate2_1.Left += mover;
                picChocolate2_2.Left += mover;

                if (picChocolate2_1.Left < -20)
                {
                    slot[5] = false;
                    picChocolate2_1.Left = 738;
                    picChocolate2_2.Left = 738;
                    ++this.Pontos;
                }

                if (faseNormal && picChocolate2_1.Location.X > 310 && picChocolate2_1.Location.X < 380 && (picNarutoGirando1.Location.Y < 160 || picNarutoGirando1.Location.Y > 230))
                    this.Close();
            }
            if(slot[6])
            {
                picChocolate3_1.Left += mover;
                picChocolate3_2.Left += mover;

                if (picChocolate3_1.Left < -20)
                {
                    slot[6] = false;
                    picChocolate3_1.Left = 738;
                    picChocolate3_2.Left = 738;
                    ++this.Pontos;
                }

                if (faseNormal && picChocolate3_1.Location.X > 310 && picChocolate3_1.Location.X < 380 && (picNarutoGirando1.Location.Y < 190 || picNarutoGirando1.Location.Y > 263))
                    this.Close();
            }
            if(slot[7])
            {
                picChocolate4_1.Left += mover;
                picChocolate4_2.Left += mover;

                if (picChocolate4_1.Left < -20)
                {
                    slot[7] = false;
                    picChocolate4_1.Left = 738;
                    picChocolate4_2.Left = 738;
                    ++this.Pontos;
                }

                if (faseNormal && picChocolate4_2.Location.X > 310 && picChocolate4_2.Location.X < 380 && (picNarutoGirando1.Location.Y < 136 || picNarutoGirando1.Location.Y > 227))
                    this.Close();
            }
            if(slot[8])
            {
                picChocolate5_1.Left += mover;
                picChocolate5_2.Left += mover;

                if (picChocolate5_1.Left < -20)
                {
                    slot[8] = false;
                    picChocolate5_1.Left = 738;
                    picChocolate5_2.Left = 738;
                    ++this.Pontos;
                }

                if (faseNormal && picChocolate5_2.Location.X > 310 && picChocolate5_2.Location.X < 380 && (picNarutoGirando1.Location.Y < 104 || picNarutoGirando1.Location.Y > 184))
                    this.Close();
            }
            
            lblPonto.Text = $"Pontuação: {this.Pontos}";
        }


        /// <summary>
        /// Este metodo é o truque. Ele ao clicar no lbl, ele nao deixa o personagem morrer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTruque(object sender, EventArgs e)
        {
            faseNormal = false;
        }
    }
}
