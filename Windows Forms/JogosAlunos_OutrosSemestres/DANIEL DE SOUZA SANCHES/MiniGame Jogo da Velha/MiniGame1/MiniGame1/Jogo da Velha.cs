using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame1
{
    public partial class MiniGame1 : Form
    {
        static int rodadas = 0, Pontos1, Pontos2, partidas = 1;
        static bool finalizado = false, velha = false;
        static string Marcador = "";
        static int[,] MatrizFinal = new int[3, 3];
     




        public MiniGame1()
        {
            InitializeComponent();
            Placar1.Text = Convert.ToString(Pontos1);
            Placar2.Text = Convert.ToString(Pontos2);
            txtPartida.Text = Convert.ToString(partidas);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jogador2_Click(object sender, EventArgs e)
        {

           
        }

        static void Marca()
        {
     
          

            if (rodadas == 0)
            {
                Marcador = "X";
                rodadas = 1;
            }

            else
            {
                Marcador = "O";
                rodadas = 0;
            }

           

        }

        static void ChecaVencedor()
        {
           
            ChecaHorizontal();
            ChecaVertical();
            ChecaDiagonal();
            ChecaVelha();
       
        }           

        static void ChecaVelha()
        {
            int checandovelha = 0;

            for (int a = 0; a <= 2; a++)
            {
                for (int b = 0; b <= 2; b++)
                {
                    if (MatrizFinal[a, b] != 0)
                    {
                        checandovelha++;

                    }
                    if (checandovelha == 9)
                    {
                        MessageBox.Show("EMPATE, VOCÊS SÃO MUITO RUIM, NINGUEM LEVA OS PONTOS");
                        ZeraMatriz();

                   
                    }
                }
            }



        }
 


     

        static void ChecaVertical()
        {

            for (int c = 0; c <= 2; c++)
            {

                if (MatrizFinal[c, 1] == MatrizFinal[c, 0] && MatrizFinal[c, 1] == MatrizFinal[c, 2] && MatrizFinal[c, 1] != 0)
                {

                    if (MatrizFinal[c, 1] == 1)
                    {
                        MessageBox.Show("JogadorX Ganhou");
                        Pontos1++;
                        ZeraMatriz();
                        

                    }
                    else
                    {
                        MessageBox.Show("JogadorO Ganhou");
                        Pontos2++;
                        ZeraMatriz();
                       

                    }
                  

                }
            }
           
        }

        static void ChecaHorizontal()
        {

            for (int c = 0; c <= 2; c++)
            {

                if (MatrizFinal[1, c] == MatrizFinal[0, c] && MatrizFinal[1, c] == MatrizFinal[2, c] && MatrizFinal[1, c] != 0)
                {

                    if (MatrizFinal[1, c] == 1)
                    {
                        Pontos1++;
                        MessageBox.Show("JogadorX Ganhou");
                        ZeraMatriz();
                        
                    }
                    else
                    {
                        MessageBox.Show("JogadorO Ganhou");
                        Pontos2++;
                        ZeraMatriz();
                        
                    }
                  

                }
            }
         
        }

        static void ChecaDiagonal()
        {
            if (MatrizFinal[0, 0] == MatrizFinal[1, 1] && MatrizFinal[2, 2] == MatrizFinal[1, 1] && MatrizFinal[1, 1] != 0 || MatrizFinal[2, 0] == MatrizFinal[1, 1] && MatrizFinal[0, 2] == MatrizFinal[1, 1] && MatrizFinal[1, 1] != 0)
            {
                if (MatrizFinal[0, 0] == 1 && MatrizFinal[2,2] == 1 || MatrizFinal[0,2] == 1 && MatrizFinal[2,0]== 1)
                {
                    Pontos1++;
                    MessageBox.Show("JogadorX Ganhou");
                    ZeraMatriz();
                }
                else
                {
                    MessageBox.Show("JogadorO Ganhou");
                    Pontos2++;
                    ZeraMatriz();
                }

            }
        }

        


        static void ZeraMatriz()
        {
            finalizado = true; 

            for (int a = 0; a <= 2; a++)
            {
                for (int b = 0; b <= 2; b++)
                {
                    MatrizFinal[a, b] = 0;

                }
            }
         
        }
        
        private void bt2_Click(object sender, EventArgs e)
        {
            if(bt2.Text == "" && finalizado == false)
            {
                Marca();
                bt2.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[1, 0] = 1;
                }
                else
                {
                    MatrizFinal[1, 0] = 2;
                }
                ChecaVencedor();
                Placar1.Text = Convert.ToString(Pontos1);
                Placar2.Text = Convert.ToString(Pontos2);

            }
         
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (bt1.Text == "" && finalizado == false)
            {
                
                Marca();
                bt1.Text = Marcador;

                if (Marcador == "X")
                {
                    MatrizFinal[0, 0] = 1;
                }
                else
                {
                    MatrizFinal[0, 0] = 2;
                }
                ChecaVencedor();
           
            }
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (bt3.Text == "" && finalizado == false)
            {
                Marca();
                bt3.Text = Marcador;
                if(Marcador == "X")
                {
                    MatrizFinal[2, 0] = 1;
                }
                else
                {
                    MatrizFinal[2, 0] = 2;
                }
                ChecaVencedor();
            
            }
        }

        private void Placar1_TextChanged(object sender, EventArgs e)
        {

           
            

        }

        private void Placar2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (bt4.Text == "" && finalizado == false)
            {
                Marca();
                bt4.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[0, 1] = 1;
                }
                else
                {
                    MatrizFinal[0, 1] = 2;
                }
               
                ChecaVencedor();
            
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (bt5.Text == "" && finalizado == false)
            {
                Marca();
                bt5.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[1, 1] = 1;
                }
                else
                {
                    MatrizFinal[1, 1] = 2;
                }
                ChecaVencedor();
       
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (bt6.Text == "" && finalizado == false)
            {
                Marca();
                bt6.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[2, 1] = 1;
                }
                else
                {
                    MatrizFinal[2, 1] = 2;
                }
                ChecaVencedor();
          
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            ZeraMatriz();
            partidas++;
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            Placar1.Text = "0";
            Placar2.Text = "0";
            txtPartida.Text = "0";
            finalizado = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ZeraMatriz();
            partidas++;
            bt1.Text = "";
            bt2.Text = "";
            bt3.Text = "";
            bt4.Text = "";
            bt5.Text = "";
            bt6.Text = "";
            bt7.Text = "";
            bt8.Text = "";
            bt9.Text = "";
            Placar1.Text = Convert.ToString(Pontos1);
            Placar2.Text = Convert.ToString(Pontos2);
            txtPartida.Text = Convert.ToString(partidas);
            finalizado = false;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (bt7.Text == "" && finalizado == false)
            {
                Marca();
                bt7.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[0, 2] = 1;
                }
                else
                {
                    MatrizFinal[0, 2] = 2;
                }
                ChecaVencedor();
           

            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (bt8.Text == "" && finalizado == false)
            {
                Marca();
                bt8.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[1, 2] = 1;
                }
                else
                {
                    MatrizFinal[1, 2] = 2;
                }
                ChecaVencedor();
         
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (bt9.Text == "" && finalizado == false)
            {
                Marca();
                bt9.Text = Marcador;
                if (Marcador == "X")
                {
                    MatrizFinal[2, 2] = 1;
                }
                else
                {
                    MatrizFinal[2, 2] = 2;
                }
                ChecaVencedor();
           
            }
        }


    }
}
