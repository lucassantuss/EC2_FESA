using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cobra
{
    public partial class frGameForca : Form
    {
        //Palavras para a forca
        string[] Palavras = { "eduardo", "viotti", "exame", "windows", "termomecanica", "computador", "bimestre", "obtusangulo" };
        string PalavraGerada;
        string palavraEscondida;
        int Tentativas = 0;
        //Toca a música durante o jogo
        SoundPlayer musicaFundo = new SoundPlayer(Properties.Resources.fundoSonoro);

        public frGameForca()
        {
            InitializeComponent();
            lbl_foram.Text = "";
            lbl_palavra.Text = "";
            if (DadosUser.Som)
                musicaFundo.PlayLooping();
        }
        //Gera a palavra para o jogo
        private void btn_gerar_Click(object sender, EventArgs e)
        {
            //Gera um número de 0 a 8 para usar como índice no array Palavras
            Random gerador = new Random();
            int Valor = gerador.Next(0, 8);
            //Atribui o valor da palavra gerada à variável
            PalavraGerada = Palavras[Valor];
            palavraEscondida = "";
            //Mede o tamanho da palavra e gera todos os caracteres como "*"
            for (int i = 0; i < PalavraGerada.Length; i++)
            {
                palavraEscondida = palavraEscondida + "*";
            }
            lbl_palavra.Text = palavraEscondida;
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            //Não deixa iniciar sem digitar uma letra
            if (txt_letra.Text == "")
            {
                MessageBox.Show("Digite uma letra");
            }
            //Não deixa iniciar sem gerar uma palavra
            else if (PalavraGerada == null)
            {
                MessageBox.Show("Gere uma palavra");
            }
            else
            {
                //Permite digitar apenas uma letra por vez
                txt_letra.MaxLength = 1;

                char Letra = Convert.ToChar(txt_letra.Text.ToLower());

                string Texto = "";
                bool existe = false;
                //Verifica se a letra digitada é igual à letra no índice i
                for (int i = 0; i < PalavraGerada.Length; i++)
                {
                    if (PalavraGerada[i] == Letra)
                    {
                        Texto += txt_letra.Text;
                        existe = true;
                    }
                    else
                    {
                        Texto += palavraEscondida[i];
                    }
                }

                if (Texto == PalavraGerada)
                {
                    MessageBox.Show("OAL!! Você acertou!", "PARABENS!!");
                    musicaFundo.Stop();
                    this.Close();
                    return;
                }

                if (existe == false)
                {
                    Tentativas += 1;
                }
                //Elimina as chances caso a pessoa erre
                switch (Tentativas)
                {
                    case 1:
                        pic_vida.Visible = false;
                        break;
                    case 2:
                        pic_vida2.Visible = false;
                        break;
                    case 3:
                        pic_vida3.Visible = false;
                        MessageBox.Show("Você perdeu!");
                        musicaFundo.Stop();
                        this.Close();
                        break;
                    default:
                        break;
                }
                //Reinicia a tela alterando apenas a letra certa
                lbl_foram.Text += $" {txt_letra.Text}";
                txt_letra.Text = "";
                palavraEscondida = Texto;
                lbl_palavra.Text = palavraEscondida;
                existe = false;
            }

            
        }

        private void frGameForca_FormClosing(object sender, FormClosingEventArgs e)
        {
            musicaFundo.Stop();
        }
    }
}
