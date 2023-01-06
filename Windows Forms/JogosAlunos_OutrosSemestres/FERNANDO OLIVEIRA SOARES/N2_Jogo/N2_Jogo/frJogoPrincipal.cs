using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_Jogo
{
    public partial class frJogoPrincipal : Form
    {
        public static int pontuacao = 0;
        public static int navesDestruidas = 0;
        public static bool podeSubir = true;
        public static bool podeDescer = true;

        public frJogoPrincipal()
        {
            InitializeComponent();
            Text = frTelaLogin.nomeUsuario;
            wmpDisparo.Ctlcontrols.stop();
            wmpExplosao.Ctlcontrols.stop();
            pbTiroJogador.Visible = false;
            timerJogoCarregado.Start();
            RegulaTimerPorDificuldade();
            timerDerrota.Start();
            timerFinaliza.Start();
            timerResetaPosicao.Start();
            timerSobeDesce.Start();
            lblEspecial.Visible = false;
        }

        /// <summary>
        /// Ajusta o intervalo do timer com base na dificuldade selecionada
        /// </summary>
        private void RegulaTimerPorDificuldade()
        {
            if (frTelaInicial.modo == "Fácil")
                timerResetaPosicao.Interval = 5000;
            else if (frTelaInicial.modo == "Médio")
                timerResetaPosicao.Interval = 4000;
            else if (frTelaInicial.modo == "Difícil")
                timerResetaPosicao.Interval = 2000;
        }

        string especial = "";

        private void frJogoPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            especial += Convert.ToChar(e.KeyValue);
            if(especial.ToUpper().Contains("GAMESHARK"))
            {
                lblEspecial.Visible = true;
                especial = "";
                timerDerrota.Stop();
                timerEspecial.Start();
            }

            if (e.KeyCode == Keys.N && pbNaveJogador.Top > 10)
                pbNaveJogador.Top = pbNaveJogador.Top - 20;
            else if (e.KeyCode == Keys.M && (pbNaveJogador.Top + pbNaveJogador.Height < Height - 50))
                pbNaveJogador.Top = pbNaveJogador.Top + 20;

            if (e.KeyCode == Keys.X && pbTiroJogador.Visible == false)
            {
                pbTiroJogador.Left = pbNaveJogador.Left + pbNaveJogador.Width + 6;
                pbTiroJogador.Top = pbNaveJogador.Top + (pbNaveJogador.Height / 2) - (pbTiroJogador.Height / 2);
                pbTiroJogador.Visible = true;
                if (frTelaInicial.efeitos)
                    wmpDisparo.Ctlcontrols.play();
                timerTiroJogador.Start();
            }
        }

        /// <summary>
        /// Testa se o tiro do jogador atingiu alguma das naves dos aliens
        /// </summary>
        private void TestaNaveAlien()
        {
            foreach (Control c in Controls)
                if (c is ucNaveAlien)
                    if (c.Visible && (pbTiroJogador.Left + pbTiroJogador.Width) >= c.Left && pbTiroJogador.Top <= c.Top && (pbTiroJogador.Top - pbTiroJogador.Height) >= (c.Top - c.Height))
                    {
                        navesDestruidas++;
                        TestaDificuldade();
                        if (frTelaInicial.efeitos)
                            wmpExplosao.Ctlcontrols.play();
                        c.Visible = false;
                        pbTiroJogador.Visible = false;
                        timerTiroJogador.Stop();
                    }
        }

        private void timerTiroJogador_Tick_1(object sender, EventArgs e)
        {
            pbTiroJogador.Left += 10;
            TestaNaveAlien();
            if (pbTiroJogador.Left > Width)
                pbTiroJogador.Visible = false;
        }

        private void TestaDificuldade()
        {
            if (frTelaInicial.modo == "Fácil")
                pontuacao += 100;
            else if (frTelaInicial.modo == "Médio")
                pontuacao += 150;
            else if (frTelaInicial.modo == "Difícil")
                pontuacao += 200;
        }

        private void timerFinaliza_Tick(object sender, EventArgs e)
        {
            if (navesDestruidas == 3)
            {
                timerFinaliza.Stop();
                timerDerrota.Stop();
                frPontuacao pontuacao = new frPontuacao();
                pontuacao.ShowDialog();
                Close();
            }
        }

        /// <summary>
        /// Testa se algum dos tiros disparados pelas naves aliens atingiu a nave do jogador
        /// </summary>
        private void TestaTiroAlien()
        {
            foreach(Control c in Controls)
                if(c is ucTiroAlien)
                    if(c.Visible && c.Left < (pbNaveJogador.Left + pbNaveJogador.Width) && c.Top <= pbNaveJogador.Top && (c.Top - c.Height) >= (pbNaveJogador.Top - pbNaveJogador.Height))
                    {
                        timerResetaPosicao.Stop();
                        timerDerrota.Stop();
                        timerFinaliza.Stop();
                        frPontuacao pontuacao = new frPontuacao();
                        pontuacao.ShowDialog();
                        Close();
                    }
        }

        private void timerDerrota_Tick(object sender, EventArgs e)
        {
            TestaTiroAlien();
        }

        private void timerResetaPosicao_Tick(object sender, EventArgs e)
        {
            if (ucNaveAlien1.Visible)
                ucTiroAlien1.Location = ucNaveAlien1.Location;
            else
                ucTiroAlien1.Visible = false;

            if(ucNaveAlien2.Visible)
                ucTiroAlien2.Location = ucNaveAlien2.Location;
            else
                ucTiroAlien2.Visible = false;

            if (ucNaveAlien3.Visible)
                ucTiroAlien3.Location = ucNaveAlien3.Location;
            else
                ucTiroAlien3.Visible = false;
        }

        private void timerJogoCarregado_Tick(object sender, EventArgs e)
        {
            pbCarregando.Visible = false;
            pbCarregando.SendToBack();
            foreach (Control c in Controls)
                if (c is ucNaveAlien)
                    (c as ucNaveAlien).IniciaNaveAlien();

            foreach (Control c in Controls)
                if (c is ucTiroAlien)
                    (c as ucTiroAlien).IniciaTiroAlien();

            timerJogoCarregado.Stop();
        }

        private void timerSobeDesce_Tick(object sender, EventArgs e)
        {

            if (ucNaveAlien1.Top > (Top + 60))
                podeSubir = false;
            else
                podeSubir = true;


            if ((ucNaveAlien3.Top + ucNaveAlien3.Height) < (Top - Height - 60))
                podeDescer = false;
            else
                podeDescer = true;
        }

        private void timerEspecial_Tick(object sender, EventArgs e)
        {
            timerEspecial.Stop();
            lblEspecial.Visible = false;
            timerDerrota.Start();
        }
    }
}
