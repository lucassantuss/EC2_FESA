using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.IO;

namespace Jogo
{
    public partial class Form1 : Form
    {
        private SoundPlayer player = new SoundPlayer();
        public FolderBrowserDialog folderDialog = new FolderBrowserDialog();

        public string diretorio;
        public TextWriter arquivo;

        static int dano_ataque1 = 2;
        static int contador = 5; 
        static int contador_aux = 0;
        static int dano_caterpie = 2;
        static int velocidade_caterpie = 6;
        static int vida_caterpie = 6;
        static int vida_caterpieaux1, vida_caterpieaux2, vida_caterpieaux3;
        static int round = 1;
        static int contagem_regressiva = 5;
        static string maior_round, maior_round2, maior_round3;
        static int vida_aliado = 5;
        static int vida_aliadop1, vida_aliadop2, vida_aliadop3, vida_aliadop4, vida_aliadop5,
            vida_aliadop6;
       

        public Form1()
        {
            InitializeComponent();

            pbAbra1.MouseDown += pbAbra1_MouseDown;
            pbChar1.MouseDown += pbChar1_MouseDown;
            pbPika1.MouseDown += pbPika1_MouseDown;
            pbGas1.MouseDown += pbGas1_MouseDown;
            pbLugia1.MouseDown += pbLugia1_MouseDown;

            pb1.AllowDrop = true;
            pb1.DragEnter += pb1_DragEnter;
            pb1.DragDrop += pb1_DragDrop;

            pb2.AllowDrop = true;
            pb2.DragEnter += pb2_DragEnter;
            pb2.DragDrop += pb2_DragDrop;

            pb3.AllowDrop = true;
            pb3.DragEnter += pb3_DragEnter;
            pb3.DragDrop += pb3_DragDrop;

            pb4.AllowDrop = true;
            pb4.DragEnter += pb4_DragEnter;
            pb4.DragDrop += pb4_DragDrop;

            pb5.AllowDrop = true;
            pb5.DragEnter += pb5_DragEnter;
            pb5.DragDrop += pb5_DragDrop;

            pb6.AllowDrop = true;
            pb6.DragEnter += pb6_DragEnter;
            pb6.DragDrop += pb6_DragDrop;


            vida_caterpieaux1 = vida_caterpieaux2 = vida_caterpieaux3 = vida_caterpie;

            vida_aliadop1 = vida_aliadop2 = vida_aliadop3 = vida_aliadop4 = vida_aliadop5 =
            vida_aliadop6 = vida_aliado;
        }

        /********************************* MÉTODOS - INICIO ******************************/
        private void AumentaEnergia()
        {
            
            if (pbEnergia.Value <= 98)
                pbEnergia.Value += 2;

            if (pbEnergia.Value == 100)
                timerEnergia.Stop();    
        }

        private void gameOver()
        {
            timerInimigos.Stop();
            timerAtaque.Stop();
            timerEnergia.Stop();

            Salva Salv = new Salva(round.ToString());
            Salv.ShowDialog();
        }

        private void proxRound()
        {
            vida_caterpieaux1 = vida_caterpieaux2 = vida_caterpieaux3 = vida_caterpie;
                round += 1;
                contador_aux = 0;
                lbRound.Text = "Round " + round.ToString();
                maior_round = lbRound.Text;
                contador += 2;
                lbContador.Text = contador.ToString();

                timerAtaque.Stop();
                timerInimigos.Stop();
                timerEnergia.Stop();

                imgCaterpie1.Left = imgCaterpie2.Left = imgCaterpie3.Left = 888;

                dano_caterpie += 2;
                vida_caterpie += 1;
                velocidade_caterpie += 1;

                if (pbAtq1.Visible == true)
                    pbAtq1.Visible = false;

                if (pbAtq2.Visible == true)
                    pbAtq2.Visible = false;

            if (pbAtqFraco3.Visible == true)
                pbAtqFraco3.Visible = false;

            if (pbAtq4.Visible == true)
                pbAtq4.Visible = false;

            if (pbAtq5.Visible == true)
                pbAtq5.Visible = false;

            if (pbAtq6.Visible == true)
                pbAtq6.Visible = false;

            if (lbEvoluir1.Visible == true)
                lbEvoluir1.Visible = false;

            if (lbEvoluir2.Visible == true)
                lbEvoluir2.Visible = false;

            if (lbEvoluir3.Visible == true)
                lbEvoluir3.Visible = false;

            if (lbEvoluir4.Visible == true)
                lbEvoluir4.Visible = false;

            if (lbEvoluir5.Visible == true)
                lbEvoluir5.Visible = false;

            if (lbEvoluir6.Visible == true)
                lbEvoluir6.Visible = false;

            timerContagemregressiva.Start();        
        }

        private void chamaAtaque1()
        {
          
            if (pb1.Image == pbChar1.Image || pb1.Image == pbCharm.Image || pb1.Image == pbCharizard.Image)
            {
                pbAtq1.Image = pbBolaFogo.Image;
                if(pb1.Image == pbCharm.Image)
                {
                    pbAtq1.Height = 80;
                    pbAtq1.Width = 80;
                }
                if (pb1.Image == pbCharizard.Image)
                {
                    pbAtq1.Height = 120;
                    pbAtq1.Width = 120;
                }
            }
                

            if (pb1.Image == pbGas1.Image || pb1.Image == pbHaunter.Image || pb1.Image == pbGengar.Image)
            {
                pbAtq1.Image = pbBolaEnergiaNegra.Image;
                if (pb1.Image == pbHaunter.Image)
                {
                    pbAtq1.Height = 80;
                    pbAtq1.Width = 80;
                }
                if (pb1.Image == pbGengar.Image)
                {
                    pbAtq1.Height = 120;
                    pbAtq1.Width = 120;
                }
            }

            if (pb1.Image == pbPika1.Image || pb1.Image == pbRaichu.Image)
            {
                pbAtq1.Image = pbBoladeEnergia.Image;
                if (pb1.Image == pbRaichu.Image)
                {
                    pbAtq1.Height = 95;
                    pbAtq1.Width = 95;
                }
            }

            if (pb1.Image == pbAbra1.Image || pb1.Image == pbKadabra.Image || pb1.Image == pbAlakazam.Image)
            {
                pbAtq1.Image = pbBolaSyc.Image;
                if (pb1.Image == pbKadabra.Image)
                {
                    pbAtq1.Height = 80;
                    pbAtq1.Width = 80;
                }
                if (pb1.Image == pbAlakazam.Image)
                {
                    pbAtq1.Height = 120;
                    pbAtq1.Width = 120;
                }
            }

            if (pb1.Image == pbLugia1.Image)
                pbAtq1.Image = pbBolaLuz.Image;
               
                
            if (pb1.Image != null && imgCaterpie1.Left <= 820 && imgCaterpie1.Visible == true)
            {
                pbAtq1.Visible = true;
                pbAtq1.Left += 10;

                if (pbAtq1.Left >= imgCaterpie1.Left - imgCaterpie1.Width)
                {
                    pbAtq1.Visible = false;
                    vida_caterpieaux1 -= dano_ataque1;
                    pbAtq1.Left = pb1.Left + pbAtq1.Width;
                    pbAtq1.Top = pb1.Top + 10;
                   
                    if (vida_caterpieaux1 <= 0)
                    {
                        contador_aux += 1;
                        lbContadoraux.Text = contador_aux.ToString();
                        imgCaterpie1.Visible = false;
                        imgCaterpie1.Left = 888;
                        vida_caterpieaux1 = vida_caterpie;
                    }
                }
            }

            else
            {
                pbAtq1.Visible = false;
                pbAtq1.Left = pb1.Left + pbAtq1.Width;
                pbAtq1.Top = pb1.Top + 10;
            }
            imgCaterpie1.Visible = true;
        }

        private void chamaAtaque2()
        {
            if (pb2.Image == pbChar1.Image || pb2.Image == pbCharm.Image || pb2.Image == pbCharizard.Image)
            {
                pbAtq2.Image = pbBolaFogo.Image;
                if (pb2.Image == pbCharm.Image)
                {
                    pbAtq2.Height = 80;
                    pbAtq2.Width = 80;
                }
                if (pb2.Image == pbCharizard.Image)
                {
                    pbAtq2.Height = 120;
                    pbAtq2.Width = 120;
                }
            }

            if (pb2.Image == pbGas1.Image || pb2.Image == pbHaunter.Image || pb2.Image == pbGengar.Image)
            {
                pbAtq2.Image = pbBolaEnergiaNegra.Image;
                if (pb2.Image == pbHaunter.Image)
                {
                    pbAtq2.Height = 80;
                    pbAtq2.Width = 80;
                }
                if (pb2.Image == pbGengar.Image)
                {
                    pbAtq2.Height = 120;
                    pbAtq2.Width = 120;
                }
            }

            if (pb2.Image == pbPika1.Image || pb2.Image == pbRaichu.Image)
            {
                pbAtq2.Image = pbBoladeEnergia.Image;
                if (pb2.Image == pbRaichu.Image)
                {
                    pbAtq2.Height = 95;
                    pbAtq2.Width = 95;
                }
            }

            if (pb2.Image == pbAbra1.Image || pb2.Image == pbKadabra.Image || pb2.Image == pbAlakazam.Image)
            {
                pbAtq2.Image = pbBolaSyc.Image;
                if (pb2.Image == pbKadabra.Image)
                {
                    pbAtq2.Height = 80;
                    pbAtq2.Width = 80;
                }
                if (pb2.Image == pbAlakazam.Image)
                {
                    pbAtq2.Height = 120;
                    pbAtq2.Width = 120;
                }
            }

            if (pb2.Image == pbLugia1.Image)
                pbAtq2.Image = pbBolaLuz.Image;

            if (pb2.Image != null && imgCaterpie2.Left <= 820 && imgCaterpie2.Visible == true)
            {
                pbAtq2.Visible = true;
                pbAtq2.Left += 10;
                if (pbAtq2.Left >= imgCaterpie2.Left - imgCaterpie2.Width)
                {
                    pbAtq2.Visible = false;
                    pbAtq2.Left = pb2.Left + pbAtq2.Width;
                    pbAtq2.Top = pb2.Top + 10;
                    vida_caterpieaux2 -= dano_ataque1;
                    if (vida_caterpieaux2 <= 0)
                    {
                        contador_aux += 1;
                        lbContadoraux.Text = contador_aux.ToString();
                        imgCaterpie2.Visible = false;
                       
                        imgCaterpie2.Left = 888;
                        
                        vida_caterpieaux2 = vida_caterpie;
                    }
                }
            }
            else
            {
                pbAtq2.Visible = false;
                pbAtq2.Left = pb2.Left + pbAtq2.Width;
                pbAtq2.Top = pb2.Top + 10;
            }
            imgCaterpie2.Visible = true;
        }

        private void chamaAtaqueFraco3()
        {
            if (pb3.Image == pbChar1.Image || pb3.Image == pbCharm.Image || pb3.Image == pbCharizard.Image)
            {
                pbAtqFraco3.Image = pbBolaFogo.Image;
                if (pb3.Image == pbCharm.Image)
                {
                    pbAtqFraco3.Height = 80;
                    pbAtqFraco3.Width = 80;
                }
                if (pb3.Image == pbCharizard.Image)
                {
                    pbAtqFraco3.Height = 120;
                    pbAtqFraco3.Width = 120;
                }
            }


            if (pb3.Image == pbGas1.Image || pb3.Image == pbHaunter.Image || pb3.Image == pbGengar.Image)
            {
                pbAtqFraco3.Image = pbBolaEnergiaNegra.Image;
                if (pb3.Image == pbHaunter.Image)
                {
                    pbAtqFraco3.Height = 80;
                    pbAtqFraco3.Width = 80;
                }
                if (pb3.Image == pbGengar.Image)
                {
                    pbAtqFraco3.Height = 120;
                    pbAtqFraco3.Width = 120;
                }
            }

            if (pb3.Image == pbPika1.Image || pb3.Image == pbRaichu.Image)
            {
                pbAtqFraco3.Image = pbBoladeEnergia.Image;
                if (pb3.Image == pbRaichu.Image)
                {
                    pbAtqFraco3.Height = 95;
                    pbAtqFraco3.Width = 95;
                }
            }

            if (pb3.Image == pbAbra1.Image || pb3.Image == pbKadabra.Image || pb3.Image == pbAlakazam.Image)
            {
                pbAtqFraco3.Image = pbBolaSyc.Image;
                if (pb3.Image == pbKadabra.Image)
                {
                    pbAtqFraco3.Height = 80;
                    pbAtqFraco3.Width = 80;
                }
                if (pb3.Image == pbAlakazam.Image)
                {
                    pbAtqFraco3.Height = 120;
                    pbAtqFraco3.Width = 120;
                }
            }

            if (pb3.Image == pbLugia1.Image)
                pbAtqFraco3.Image = pbBolaLuz.Image;

            if (pb3.Image != null && imgCaterpie3.Left <= 820 && imgCaterpie3.Visible == true)
            {
                pbAtqFraco3.Visible = true;
                pbAtqFraco3.Left += 10;
                if (pbAtqFraco3.Left >= imgCaterpie3.Left - imgCaterpie3.Width)
                {
                    pbAtqFraco3.Visible = false;
                    pbAtqFraco3.Left = pb3.Left + pbAtqFraco3.Width;
                    pbAtqFraco3.Top = pb3.Top + 10;
                    vida_caterpieaux3 -= dano_ataque1;
                    if (vida_caterpieaux3 <= 0)
                    {
                        contador_aux += 1;
                        lbContadoraux.Text = contador_aux.ToString();
                        imgCaterpie3.Visible = false;
                        imgCaterpie3.Left = 888;
                        vida_caterpieaux3 = vida_caterpie;
                    }
                }
            }
            else
            {
                pbAtqFraco3.Visible = false;
                pbAtqFraco3.Left = pb3.Left + pbAtqFraco3.Width;
                pbAtqFraco3.Top = pb3.Top + 10;
            }
            imgCaterpie3.Visible = true;
        }

        private void chamaAtaque4()
        {

            if (pb4.Image == pbChar1.Image || pb4.Image == pbCharm.Image || pb4.Image == pbCharizard.Image)
            {
                pbAtq4.Image = pbBolaFogo.Image;
                if (pb4.Image == pbCharm.Image)
                {
                    pbAtq4.Height = 80;
                    pbAtq4.Width = 80;
                }
                if (pb4.Image == pbCharizard.Image)
                {
                    pbAtq4.Height = 120;
                    pbAtq4.Width = 120;
                }
            }


            if (pb4.Image == pbGas1.Image || pb4.Image == pbHaunter.Image || pb4.Image == pbGengar.Image)
            {
                pbAtq4.Image = pbBolaEnergiaNegra.Image;
                if (pb4.Image == pbHaunter.Image)
                {
                    pbAtq4.Height = 80;
                    pbAtq4.Width = 80;
                }
                if (pb4.Image == pbGengar.Image)
                {
                    pbAtq4.Height = 120;
                    pbAtq4.Width = 120;
                }
            }

            if (pb4.Image == pbPika1.Image || pb4.Image == pbRaichu.Image)
            {
                pbAtq4.Image = pbBoladeEnergia.Image;
                if (pb4.Image == pbRaichu.Image)
                {
                    pbAtq4.Height = 95;
                    pbAtq4.Width = 95;
                }
            }

            if (pb4.Image == pbAbra1.Image || pb4.Image == pbKadabra.Image || pb4.Image == pbAlakazam.Image)
            {
                pbAtq4.Image = pbBolaSyc.Image;
                if (pb4.Image == pbKadabra.Image)
                {
                    pbAtq4.Height = 80;
                    pbAtq4.Width = 80;
                }
                if (pb4.Image == pbAlakazam.Image)
                {
                    pbAtq4.Height = 120;
                    pbAtq4.Width = 120;
                }
            }

            if (pb4.Image == pbLugia1.Image)
                pbAtq4.Image = pbBolaLuz.Image;


            if (pb4.Image != null && imgCaterpie1.Left <= 820 && imgCaterpie1.Visible == true)
            {
                pbAtq4.Visible = true;
                pbAtq4.Left += 10;

                if (pbAtq4.Left >= imgCaterpie1.Left - imgCaterpie1.Width)
                {
                    pbAtq4.Visible = false;
                    vida_caterpieaux1 -= dano_ataque1;
                    pbAtq4.Left = pb4.Left + pbAtq4.Width;
                    pbAtq4.Top = pb4.Top + 10;

                    if (vida_caterpieaux1 <= 0)
                    {
                        contador_aux += 1;
                        lbContadoraux.Text = contador_aux.ToString();
                        imgCaterpie1.Visible = false;
                        imgCaterpie1.Left = 888;
                        vida_caterpieaux1 = vida_caterpie;
                    }
                }
            }

            else
            {
                pbAtq4.Visible = false;
                pbAtq4.Left = pb4.Left + pbAtq4.Width;
                pbAtq4.Top = pb4.Top + 10;
            }
            imgCaterpie1.Visible = true;
        }

        private void chamaAtaque5()
        {
            if (pb5.Image == pbChar1.Image || pb5.Image == pbCharm.Image || pb5.Image == pbCharizard.Image)
            {
                pbAtq5.Image = pbBolaFogo.Image;
                if (pb5.Image == pbCharm.Image)
                {
                    pbAtq5.Height = 80;
                    pbAtq5.Width = 80;
                }
                if (pb5.Image == pbCharizard.Image)
                {
                    pbAtq5.Height = 120;
                    pbAtq5.Width = 120;
                }
            }

            if (pb5.Image == pbGas1.Image || pb5.Image == pbHaunter.Image || pb5.Image == pbGengar.Image)
            {
                pbAtq5.Image = pbBolaEnergiaNegra.Image;
                if (pb5.Image == pbHaunter.Image)
                {
                    pbAtq5.Height = 80;
                    pbAtq5.Width = 80;
                }
                if (pb5.Image == pbGengar.Image)
                {
                    pbAtq5.Height = 120;
                    pbAtq5.Width = 120;
                }
            }

            if (pb5.Image == pbPika1.Image || pb5.Image == pbRaichu.Image)
            {
                pbAtq5.Image = pbBoladeEnergia.Image;
                if (pb5.Image == pbRaichu.Image)
                {
                    pbAtq5.Height = 95;
                    pbAtq5.Width = 95;
                }
            }

            if (pb5.Image == pbAbra1.Image || pb5.Image == pbKadabra.Image || pb5.Image == pbAlakazam.Image)
            {
                pbAtq5.Image = pbBolaSyc.Image;
                if (pb5.Image == pbKadabra.Image)
                {
                    pbAtq5.Height = 80;
                    pbAtq5.Width = 80;
                }
                if (pb5.Image == pbAlakazam.Image)
                {
                    pbAtq5.Height = 120;
                    pbAtq5.Width = 120;
                }
            }

            if (pb5.Image == pbLugia1.Image)
                pbAtq5.Image = pbBolaLuz.Image;

            if (pb5.Image != null && imgCaterpie2.Left <= 820 && imgCaterpie2.Visible == true)
            {
                pbAtq5.Visible = true;
                pbAtq5.Left += 10;
                if (pbAtq5.Left >= imgCaterpie2.Left - imgCaterpie2.Width)
                {
                    pbAtq5.Visible = false;
                    pbAtq5.Left = pb5.Left + pbAtq5.Width;
                    pbAtq5.Top = pb5.Top + 10;
                    vida_caterpieaux2 -= dano_ataque1;
                    if (vida_caterpieaux2 <= 0)
                    {
                        contador_aux += 1;
                        lbContadoraux.Text = contador_aux.ToString();
                        imgCaterpie2.Visible = false;

                        imgCaterpie2.Left = 888;

                        vida_caterpieaux2 = vida_caterpie;
                    }
                }
            }
            else
            {
                pbAtq5.Visible = false;
                pbAtq5.Left = pb5.Left + pbAtq5.Width;
                pbAtq5.Top = pb5.Top + 10;
            }
            imgCaterpie2.Visible = true;
        }

        private void chamaAtaque6()
        {
            if (pb6.Image == pbChar1.Image || pb6.Image == pbCharm.Image || pb6.Image == pbCharizard.Image)
            {
                pbAtq6.Image = pbBolaFogo.Image;
                if (pb6.Image == pbCharm.Image)
                {
                    pbAtq6.Height = 80;
                    pbAtq6.Width = 80;
                }
                if (pb6.Image == pbCharizard.Image)
                {
                    pbAtq6.Height = 120;
                    pbAtq6.Width = 120;
                }
            }


            if (pb6.Image == pbGas1.Image || pb6.Image == pbHaunter.Image || pb6.Image == pbGengar.Image)
            {
                pbAtq6.Image = pbBolaEnergiaNegra.Image;
                if (pb6.Image == pbHaunter.Image)
                {
                    pbAtq6.Height = 80;
                    pbAtq6.Width = 80;
                }
                if (pb6.Image == pbGengar.Image)
                {
                    pbAtq6.Height = 120;
                    pbAtq6.Width = 120;
                }
            }

            if (pb6.Image == pbPika1.Image || pb6.Image == pbRaichu.Image)
            {
                pbAtq6.Image = pbBoladeEnergia.Image;
                if (pb6.Image == pbRaichu.Image)
                {
                    pbAtq6.Height = 95;
                    pbAtq6.Width = 95;
                }
            }

            if (pb6.Image == pbAbra1.Image || pb6.Image == pbKadabra.Image || pb6.Image == pbAlakazam.Image)
            {
                pbAtq6.Image = pbBolaSyc.Image;
                if (pb6.Image == pbKadabra.Image)
                {
                    pbAtq6.Height = 80;
                    pbAtq6.Width = 80;
                }
                if (pb6.Image == pbAlakazam.Image)
                {
                    pbAtq6.Height = 120;
                    pbAtq6.Width = 120;
                }
            }

            if (pb6.Image == pbLugia1.Image)
                pbAtq6.Image = pbBolaLuz.Image;

            if (pb6.Image != null && imgCaterpie3.Left <= 820 && imgCaterpie3.Visible == true)
            {
                pbAtq6.Visible = true;
                pbAtq6.Left += 10;
                if (pbAtq6.Left >= imgCaterpie3.Left - imgCaterpie3.Width)
                {
                    pbAtq6.Visible = false;
                    pbAtq6.Left = pb3.Left + pbAtqFraco3.Width;
                    pbAtq6.Top = pb3.Top + 10;
                    vida_caterpieaux3 -= dano_ataque1;
                    if (vida_caterpieaux3 <= 0)
                    {
                        contador_aux += 1;
                        lbContadoraux.Text = contador_aux.ToString();
                        imgCaterpie3.Visible = false;
                        imgCaterpie3.Left = 888;
                        vida_caterpieaux3 = vida_caterpie;
                    }
                }
            }
            else
            {
                pbAtq6.Visible = false;
                pbAtq6.Left = pb6.Left + pbAtqFraco3.Width;
                pbAtq6.Top = pb6.Top + 10;
            }
            imgCaterpie3.Visible = true;
        }


        private void testaEvoluidos()
        {
             if(pb1.Image == pbAlakazam.Image || pb1.Image == pbRaichu.Image || pb1.Image == pbGengar.Image || pb1.Image == pbCharizard.Image)
                lbEvoluir1.Visible = false;
            

            if (pb2.Image == pbAlakazam.Image || pb2.Image == pbRaichu.Image || pb2.Image == pbGengar.Image || pb3.Image == pbCharizard.Image)           
                lbEvoluir2.Visible = false;
            

            if (pb3.Image == pbAlakazam.Image || pb3.Image == pbRaichu.Image || pb3.Image == pbGengar.Image || pb3.Image == pbCharizard.Image)            
                lbEvoluir3.Visible = false;

            if (pb4.Image == pbAlakazam.Image || pb4.Image == pbRaichu.Image || pb4.Image == pbGengar.Image || pb4.Image == pbCharizard.Image)
                lbEvoluir4.Visible = false;

            if (pb5.Image == pbAlakazam.Image || pb5.Image == pbRaichu.Image || pb5.Image == pbGengar.Image || pb5.Image == pbCharizard.Image)
                lbEvoluir5.Visible = false;

            if (pb6.Image == pbAlakazam.Image || pb6.Image == pbRaichu.Image || pb6.Image == pbGengar.Image || pb6.Image == pbCharizard.Image)
                lbEvoluir6.Visible = false;

        }

        private void geraInimigos()
        {
            Random gerador = new Random();

            imgCaterpie1.Left = imgCaterpie1.Left - gerador.Next(0, velocidade_caterpie);
            if (imgCaterpie1.Left + 2 <= 150)
            {
                pbVida.Value -= dano_caterpie;
                if (pbVida.Value <= 10)
                {
                    lbGameOver.Visible = true;
                    gameOver();
                }
                imgCaterpie1.Visible = false;
                imgCaterpie1.Left = 888;
                imgCaterpie1.Visible = true;
                contador_aux += 1;
                if (contador_aux == contador)
                    proxRound();
            }

            if (imgCaterpie1.Left - pb1.Width <= pb1.Left && pb1.Image != null)
            {
               
                vida_aliadop1 -= dano_caterpie;
                if (vida_aliadop1 <= 0)
                {        
                    pb1.Image = null;
                    lbMorreu.Left = pb1.Left;
                    lbMorreu.Top = pb1.Top;
                    lbMorreu.Visible = true;
                    timerMorreu.Start();
                    vida_aliadop1 = vida_aliado;
                    if(lbEvoluir1.Visible == true)
                        lbEvoluir1.Visible = false;  
                }
            }

            if (imgCaterpie1.Left - pb4.Width <= pb4.Left && pb4.Image != null)
            {

                vida_aliadop4 -= dano_caterpie;
                if (vida_aliadop4 <= 0)
                {
                    pb4.Image = null;
                    lbMorreu.Left = pb4.Left;
                    lbMorreu.Top = pb4.Top;
                    lbMorreu.Visible = true;
                    timerMorreu.Start();
                    vida_aliadop4 = vida_aliado;
                    if (lbEvoluir4.Visible == true)
                        lbEvoluir4.Visible = false;
                }
            }


            imgCaterpie2.Left = imgCaterpie2.Left - gerador.Next(0, velocidade_caterpie);
            if (imgCaterpie2.Left + 2 <= 150)
            {
                pbVida.Value -= dano_caterpie;
                if (pbVida.Value <= 10)
                {
                    lbGameOver.Visible = true;
                    gameOver();
                }
                imgCaterpie2.Visible = false;
                imgCaterpie2.Left = 888;
                imgCaterpie2.Visible = true;
                contador_aux += 1;
                if (contador_aux == contador)
                    proxRound();
            }

            if (imgCaterpie2.Left - pb2.Width <= pb2.Left && pb2.Image != null)
            {
                vida_aliadop2 -= dano_caterpie;
                if (vida_aliadop2 <= 0)
                {
                    pb2.Image = null;
                    lbMorreu.Left = pb2.Left;
                    lbMorreu.Top = pb2.Top;
                    lbMorreu.Visible = true;
                    timerMorreu.Start();
                    vida_aliadop2 = vida_aliado;
                    if (lbEvoluir2.Visible == true)
                        lbEvoluir2.Visible = false;
                }
            }

            if (imgCaterpie2.Left - pb5.Width <= pb5.Left && pb5.Image != null)
            {
                vida_aliadop5 -= dano_caterpie;
                if (vida_aliadop5 <= 0)
                {
                    pb5.Image = null;
                    lbMorreu.Left = pb5.Left;
                    lbMorreu.Top = pb5.Top;
                    lbMorreu.Visible = true;
                    timerMorreu.Start();
                    vida_aliadop5 = vida_aliado;
                    if (lbEvoluir5.Visible == true)
                        lbEvoluir5.Visible = false;
                }
            }


            imgCaterpie3.Left = imgCaterpie3.Left - gerador.Next(0, velocidade_caterpie);
            if (imgCaterpie3.Left + 2 <= 150)
            {
                pbVida.Value -= dano_caterpie;
                if (pbVida.Value <= 10)
                {
                    lbGameOver.Visible = true;
                    gameOver();
                }
                imgCaterpie3.Visible = false;
                imgCaterpie3.Left = 888;
                imgCaterpie3.Visible = true;
                contador_aux += 1;
                if (contador_aux == contador)
                    proxRound();
            }

            if (imgCaterpie3.Left - pb3.Width <= pb3.Left && pb3.Image != null)
            {
                vida_aliadop3 -= dano_caterpie;
                if (vida_aliadop3 <= 0)
                {
                    pb3.Image = null;
                    lbMorreu.Left = pb3.Left;
                    lbMorreu.Top = pb3.Top;
                    lbMorreu.Visible = true;
                    timerMorreu.Start();
                    vida_aliadop3 = vida_aliado;
                    if (lbEvoluir3.Visible == true)
                        lbEvoluir3.Visible = false;
                }
            }

            if (imgCaterpie3.Left - pb6.Width <= pb6.Left && pb6.Image != null)
            {
                vida_aliadop3 -= dano_caterpie;
                if (vida_aliadop3 <= 0)
                {
                    pb6.Image = null;
                    lbMorreu.Left = pb6.Left;
                    lbMorreu.Top = pb6.Top;
                    lbMorreu.Visible = true;
                    timerMorreu.Start();
                    vida_aliadop6 = vida_aliado;
                    if (lbEvoluir6.Visible == true)
                        lbEvoluir6.Visible = false;
                }
            }
        }

        private void LojaEnergia()
        {
            lbTeste.Text = pbEnergia.Value.ToString();

            if (pbEnergia.Value < 10)
            {
                btnAbra.Enabled = false;
                btnPika.Enabled = false;
                btnGas.Enabled = false;
                pbAbra1.Enabled = false;
                pbPika1.Enabled = false;
                pbGas1.Enabled = false;
            }

            if (pbEnergia.Value < 12)
            {
                btnChar.Enabled = false;
                pbChar1.Enabled = false;
            }
                

            if (pbEnergia.Value >= 10)
            {
                btnAbra.Enabled = true;
                btnPika.Enabled = true;
                btnGas.Enabled = true;
                pbAbra1.Enabled = true;
                pbPika1.Enabled = true;
                pbGas1.Enabled = true;
            }

            if (pbEnergia.Value >= 12)
            {
                btnChar.Enabled = true;
                pbChar1.Enabled = true;
            }
                

            if (pbEnergia.Value >= 50 && pb1.Image != null)
            {
                lbEvoluir1.Left = pb1.Left;
                lbEvoluir1.Top = pb1.Top;
                lbEvoluir1.Visible = true;
            }

            if (pbEnergia.Value >= 50 && pb2.Image != null)
            {
                lbEvoluir2.Left = pb2.Left;
                lbEvoluir2.Top = pb2.Top;
                lbEvoluir2.Visible = true;
            }

            if (pbEnergia.Value >= 50 && pb3.Image != null)
            {
                lbEvoluir3.Left = pb3.Left;
                lbEvoluir3.Top = pb3.Top;
                lbEvoluir3.Visible = true;
            }

            if (pbEnergia.Value >= 50 && pb4.Image != null)
            {
                lbEvoluir4.Left = pb4.Left;
                lbEvoluir4.Top = pb4.Top;
                lbEvoluir4.Visible = true;
            }

            if (pbEnergia.Value >= 50 && pb5.Image != null)
            {
                lbEvoluir5.Left = pb5.Left;
                lbEvoluir5.Top = pb5.Top;
                lbEvoluir5.Visible = true;
            }

            if (pbEnergia.Value >= 50 && pb6.Image != null)
            {
                lbEvoluir6.Left = pb6.Left;
                lbEvoluir6.Top = pb6.Top;
                lbEvoluir6.Visible = true;
            }

            if (pbEnergia.Value < 50)
                lbEvoluir1.Visible = false;
            
            if (pbEnergia.Value < 50)
                lbEvoluir2.Visible = false;

            if (pbEnergia.Value < 50)
                lbEvoluir3.Visible = false;

            if (pbEnergia.Value < 50)
                lbEvoluir4.Visible = false;

            if (pbEnergia.Value < 50)
                lbEvoluir5.Visible = false;

            if (pbEnergia.Value < 50)
                lbEvoluir6.Visible = false;

        }
        /********************************** MÉTODOS - FIM *********************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            pbVida.Value = 100;

            try
            {
                this.player.SoundLocation = @"C:\Users\danie\OneDrive\Desktop\Trab Algoritmos - Jogo Pokemon\Sprites\songs\PokemonSongWav.wav";
                this.player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error playing sound");
            }

            lbContador.Text = contador.ToString();
            lbContadoraux.Text = contador_aux.ToString();
            timerInimigos.Start();
            timerEnergia.Start();
            timerAtaque.Start();
            maior_round = lbRound.Text;

        }

        /************************************ TIMERs - INICIO *****************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            geraInimigos();
        }

        private void timerEnergia_Tick(object sender, EventArgs e)
        {
            AumentaEnergia();
            LojaEnergia();
            testaEvoluidos();

            if (pb1.Image == pbLugia1.Image)
                lbEvoluir1.Visible = false;

            if (pb2.Image == pbLugia1.Image)
                lbEvoluir2.Visible = false;

            if (pb3.Image == pbLugia1.Image)
                lbEvoluir3.Visible = false;

            if (pb4.Image == pbLugia1.Image)
                lbEvoluir4.Visible = false;

            if (pb5.Image == pbLugia1.Image)
                lbEvoluir5.Visible = false;

            if (pb6.Image == pbLugia1.Image)
                lbEvoluir6.Visible = false;

            if (pbVida.Value <= 10)
                lbGameOver.Visible = true;
            
        }

        private void timerMorreu_Tick(object sender, EventArgs e)
        {
            lbMorreu.Visible = false;
        }

        private void timerContagemregressiva_Tick(object sender, EventArgs e)
        {
            lbRegressivo.Visible = true;
            lbRegressivo.Text = contagem_regressiva.ToString();
            contagem_regressiva -= 1;

           
            if (contagem_regressiva == -1)
            {
                contagem_regressiva = 5;
                timerContagemregressiva.Stop();
                lbRegressivo.Visible = false;
                timerEnergia.Start();
                timerInimigos.Start();
                timerAtaque.Start();
            }
        }

        private void timerAtaque_Tick(object sender, EventArgs e)
        {
            if (timerEnergia.Enabled == false && pbEnergia.Value < 100)
                timerEnergia.Start();
 
            chamaAtaque1();
            chamaAtaque2();
            chamaAtaqueFraco3();
            chamaAtaque4();
            chamaAtaque5();
            chamaAtaque6();

            if (contador_aux >= contador)
                proxRound();
        }

        /*********************************** TIMERs - FIM *******************************/

        /********************************** EVENTS - INICIO ******************************/
        private void pbAbra1_MouseEnter(object sender, EventArgs e)
        {
            pbAbra1.BringToFront();
        }

        private void pbAbra1_MouseLeave(object sender, EventArgs e)
        {
            btnAbra.BringToFront();
        }

        private void pbChar1_MouseEnter_1(object sender, EventArgs e)
        {
            pbChar1.BringToFront();
        }

        private void pbChar1_MouseLeave(object sender, EventArgs e)
        {
            btnChar.BringToFront();
        }

        private void btnChar_MouseEnter_1(object sender, EventArgs e)
        {
            pbChar1.BringToFront();
        }

        private void btnChar_MouseLeave_1(object sender, EventArgs e)
        {
            btnChar.Visible = true;
        }

        private void pbPika1_MouseEnter(object sender, EventArgs e)
        {
            pbPika1.BringToFront();
        }

        private void pbPika1_MouseLeave(object sender, EventArgs e)
        {
            btnPika.BringToFront();
        }

        private void pbGas1_MouseEnter(object sender, EventArgs e)
        {
            pbGas1.BringToFront();
        }

        private void pbGas1_MouseLeave(object sender, EventArgs e)
        {
            btnGas.BringToFront();
        }

        private void pb2_MouseLeave(object sender, EventArgs e)
        {
            pb2.BorderStyle = BorderStyle.None;
        }

        private void pb1_MouseLeave(object sender, EventArgs e)
        {
            pb1.BorderStyle = BorderStyle.None;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (pb2.Image != null && lbEvoluir2.Visible == true)
            {
                if (pb2.Image == pbKadabra.Image && lbEvoluir2.Visible == true)
                {
                    pb2.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb2.Image == pbCharm.Image && lbEvoluir2.Visible == true)
                {
                    this.pb2.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb2.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb2.Image == pbHaunter.Image && lbEvoluir2.Visible == true)
                {
                    pb2.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb2.Image == pbAbra1.Image)
                    pb2.Image = pbKadabra.Image;
                if (pb2.Image == pbChar1.Image)
                    pb2.Image = pbCharm.Image;
                if (pb2.Image == pbPika1.Image)
                    pb2.Image = pbRaichu.Image;
                if (pb2.Image == pbGas1.Image)
                    pb2.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir2.Visible = false;
            }
        }

        private void pbAbra1_MouseDown(object sender, MouseEventArgs e)
        {
            var imgAbra = pbAbra1.Image;
            if (imgAbra == null) return;
            if (DoDragDrop(imgAbra, DragDropEffects.Move) == DragDropEffects.Move)
                pbEnergia.Value = pbEnergia.Value - 10;

        }

        private void pbChar1_MouseDown(object sender, MouseEventArgs e)
        {
            var imgChar = pbChar1.Image;
            if (imgChar == null) return;
            if (DoDragDrop(imgChar, DragDropEffects.Move) == DragDropEffects.Move)
                pbEnergia.Value = pbEnergia.Value - 12;

        }

        private void pbPika1_MouseDown(object sender, MouseEventArgs e)
        {
            var imgPika = pbPika1.Image;
            if (imgPika == null) return;
            if (DoDragDrop(imgPika, DragDropEffects.Move) == DragDropEffects.Move)
                pbEnergia.Value = pbEnergia.Value - 10;

        }

        private void pbGas1_MouseDown(object sender, MouseEventArgs e)
        {
            var imgGas = pbGas1.Image;
            if (imgGas == null) return;
            if (DoDragDrop(imgGas, DragDropEffects.Move) == DragDropEffects.Move)
                pbEnergia.Value = pbEnergia.Value - 10;
        }

        private void pbLugia1_MouseDown(object sender, MouseEventArgs e)
        {
            var imgLug= pbLugia1.Image;
            if (imgLug == null) return;
            if (DoDragDrop(imgLug, DragDropEffects.Move) == DragDropEffects.Move);
                
        }

        private void pb1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            pb1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb1_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pb1.Image = bmp;

            pbAtq1.Left = pb1.Left + pbAtq1.Width;
            pbAtq1.Top = pb1.Top + 10;
        }

        private void pb2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            pb2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb2_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pb2.Image = bmp;

            pbAtq2.Left = pb2.Left + pbAtq2.Width;
            pbAtq2.Top = pb2.Top + 10;

      
        }

        private void pb3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }

        private void pb3_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pb3.Image = bmp;

            pbAtqFraco3.Left = pb3.Left + pbAtqFraco3.Width;
            pbAtqFraco3.Top = pb3.Top + 10;

        }

        private void pb3_Click(object sender, EventArgs e)
        {
            if (pb3.Image != null && lbEvoluir3.Visible == true)
            {
                if (pb3.Image == pbKadabra.Image && lbEvoluir3.Visible == true)
                {
                    pb3.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb3.Image == pbCharm.Image && lbEvoluir3.Visible == true)
                {
                    this.pb3.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb3.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb3.Image == pbHaunter.Image && lbEvoluir3.Visible == true)
                {
                    pb3.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb3.Image == pbAbra1.Image)
                    pb3.Image = pbKadabra.Image;
                if (pb3.Image == pbChar1.Image)
                    pb3.Image = pbCharm.Image;
                if (pb3.Image == pbPika1.Image)
                    pb3.Image = pbRaichu.Image;
                if (pb3.Image == pbGas1.Image)
                    pb3.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir3.Visible = false;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (pb1.Image != null && lbEvoluir1.Visible == true)
            {
                if (pb1.Image == pbKadabra.Image && lbEvoluir1.Visible == true)
                {
                    pb1.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb1.Image == pbCharm.Image && lbEvoluir1.Visible == true)
                {
                    this.pb1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb1.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb1.Image == pbHaunter.Image && lbEvoluir1.Visible == true)
                {
                    pb1.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb1.Image == pbAbra1.Image)
                    pb1.Image = pbKadabra.Image;
                if (pb1.Image == pbChar1.Image)
                    pb1.Image = pbCharm.Image;
                if (pb1.Image == pbPika1.Image)
                    pb1.Image = pbRaichu.Image;
                if (pb1.Image == pbGas1.Image)
                    pb1.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir1.Visible = false;
            }
        }

        private void btnChar_MouseLeave(object sender, EventArgs e)
        {
            btnChar.Visible = true;
        }

        private void pb3_DragEnter_1(object sender, DragEventArgs e)
        {
            pb3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb3_MouseLeave(object sender, EventArgs e)
        {
            pb3.BorderStyle = BorderStyle.None;
        }

        private void btnChar_MouseEnter(object sender, EventArgs e)
        {
            pbChar1.BringToFront();
        }

        private void btnPika_MouseLeave(object sender, EventArgs e)
        {
            btnPika.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (pb5.Image != null && lbEvoluir5.Visible == true)
            {
                if (pb5.Image == pbKadabra.Image && lbEvoluir5.Visible == true)
                {
                    pb5.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb5.Image == pbCharm.Image && lbEvoluir5.Visible == true)
                {
                    this.pb5.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb5.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb5.Image == pbHaunter.Image && lbEvoluir5.Visible == true)
                {
                    pb5.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb5.Image == pbAbra1.Image)
                    pb5.Image = pbKadabra.Image;
                if (pb5.Image == pbChar1.Image)
                    pb5.Image = pbCharm.Image;
                if (pb5.Image == pbPika1.Image)
                    pb5.Image = pbRaichu.Image;
                if (pb5.Image == pbGas1.Image)
                    pb5.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir5.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Salva Salv = new Salva(round.ToString());
            Salv.ShowDialog();
        }

        private void pb4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            pb4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb4_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pb4.Image = bmp;

            pbAtq4.Left = pb4.Left + pbAtq4.Width;
            pbAtq4.Top = pb4.Top + 10;
        }

        private void pb4_MouseLeave(object sender, EventArgs e)
        {
            pb4.BorderStyle = BorderStyle.None;
        }

        private void pb5_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            pb5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb5_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pb5.Image = bmp;

            pbAtq5.Left = pb5.Left + pbAtq5.Width;
            pbAtq5.Top = pb5.Top + 10;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            if (pb4.Image != null && lbEvoluir4.Visible == true)
            {
                if (pb4.Image == pbKadabra.Image && lbEvoluir4.Visible == true)
                {
                    pb4.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb4.Image == pbCharm.Image && lbEvoluir4.Visible == true)
                {
                    this.pb4.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb4.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb4.Image == pbHaunter.Image && lbEvoluir4.Visible == true)
                {
                    pb4.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb4.Image == pbAbra1.Image)
                    pb4.Image = pbKadabra.Image;
                if (pb4.Image == pbChar1.Image)
                    pb4.Image = pbCharm.Image;
                if (pb4.Image == pbPika1.Image)
                    pb4.Image = pbRaichu.Image;
                if (pb4.Image == pbGas1.Image)
                    pb4.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir1.Visible = false;
            }
        }

        private void pb5_MouseLeave(object sender, EventArgs e)
        {
            pb5.BorderStyle = BorderStyle.None;
        }

        string somaLetras;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            somaLetras += Convert.ToChar(e.KeyValue);
            if(somaLetras.ToUpper().Contains("IDDQD"))
            {
                MessageBox.Show("Lugia liberado!");
                somaLetras = "";
                btnLugia.Visible = true;
                pbLugia1.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Recorde Rec = new Recorde(maior_round);
            Rec.ShowDialog();
        }

        private void btnSalvatxt_Click(object sender, EventArgs e)
        {
            Salva Salv = new Salva(round.ToString());
            Salv.ShowDialog();
        }

        private void btnRecordes_Click(object sender, EventArgs e)
        {
            Recorde Rec = new Recorde(maior_round);
            Rec.ShowDialog();
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            if (pb6.Image != null && lbEvoluir6.Visible == true)
            {
                if (pb6.Image == pbKadabra.Image && lbEvoluir6.Visible == true)
                {
                    pb6.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb6.Image == pbCharm.Image && lbEvoluir6.Visible == true)
                {
                    this.pb6.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb6.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb6.Image == pbHaunter.Image && lbEvoluir6.Visible == true)
                {
                    pb6.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb6.Image == pbAbra1.Image)
                    pb6.Image = pbKadabra.Image;
                if (pb6.Image == pbChar1.Image)
                    pb6.Image = pbCharm.Image;
                if (pb6.Image == pbPika1.Image)
                    pb6.Image = pbRaichu.Image;
                if (pb6.Image == pbGas1.Image)
                    pb6.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir6.Visible = false;
            }
        }

        private void pb6_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pb6.Image = bmp;

            pbAtq6.Left = pb6.Left + pbAtq6.Width;
            pbAtq6.Top = pb6.Top + 10;
        }

        private void pb6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
            pb6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pb6_MouseLeave(object sender, EventArgs e)
        {
            pb6.BorderStyle = BorderStyle.None;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pbLugia1.BringToFront();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnAbra.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pbAbra1.BringToFront();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            btnAbra.BringToFront();
        }

        private void pbLugia1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (pb5.Image != null && lbEvoluir5.Visible == true)
            {
                if (pb5.Image == pbKadabra.Image && lbEvoluir5.Visible == true)
                {
                    pb5.Image = pbAlakazam.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb5.Image == pbCharm.Image && lbEvoluir5.Visible == true)
                {
                    this.pb5.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb5.Image = pbCharizard.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb5.Image == pbHaunter.Image && lbEvoluir5.Visible == true)
                {
                    pb5.Image = pbGengar.Image;
                    pbEnergia.Value -= 40;
                    return;
                }
                if (pb5.Image == pbAbra1.Image)
                    pb5.Image = pbKadabra.Image;
                if (pb5.Image == pbChar1.Image)
                    pb5.Image = pbCharm.Image;
                if (pb5.Image == pbPika1.Image)
                    pb5.Image = pbRaichu.Image;
                if (pb5.Image == pbGas1.Image)
                    pb5.Image = pbHaunter.Image;

                pbEnergia.Value -= 40;
                lbEvoluir6.Visible = false;
            }
        }

        private void btnPika_MouseEnter(object sender, EventArgs e)
        {
            pbPika1.BringToFront();
        }


        private void btnGas_MouseLeave(object sender, EventArgs e)
        {
            btnGas.Visible = true;
        }
  

        private void btnGas_MouseEnter(object sender, EventArgs e)
        {
            pbGas1.BringToFront();
        }

        private void pbSoundOn_Click(object sender, EventArgs e)
        {
            player.Stop();
            pbSoundOn.Visible = false;
            pbSoundOff.Visible = true;
            pbSoundOff.BringToFront();
        }

        private void pbSoundOff_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
            pbSoundOn.Visible = true;
            pbSoundOff.Visible = false;
            pbSoundOn.BringToFront();
        }

        private void pbHowtoplay_Click(object sender, EventArgs e)
        {
            Howtoplay Htplay = new Howtoplay();
            Htplay.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sobre FormSobre = new Sobre();
            FormSobre.ShowDialog();
        }

        private void btnAbra_MouseLeave_1(object sender, EventArgs e)
        {
            btnAbra.Visible = true;
        }

        private void btnAbra_MouseEnter_1(object sender, EventArgs e)
        {
            pbAbra1.BringToFront();
        }
        /****************************** EVENTS - FIM *************************************/
    }
}

