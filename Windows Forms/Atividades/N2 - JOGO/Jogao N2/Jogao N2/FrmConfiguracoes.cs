using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogao_N2
{
    public partial class FrmConfiguracoes : Form
    {
        public static string[] configtext = new string[] { "Facil", "MusicaOn", "SFXOn" };
        static public void GeraConfig()
        {
            File.WriteAllLines("Configuracoes.txt", configtext);
            FrmConfiguracoes.LerConfig();
        }

        private void MudaCor(string[] config)
        {
            if (FrmInicial.dificuldade == "Facil")
            {
                lblFacil.ForeColor = Color.Yellow;
                lblMedio.ForeColor = Color.Black;
                lblDificil.ForeColor = Color.Black;
            }
            else if (FrmInicial.dificuldade == "Medio")
            {
                lblMedio.ForeColor = Color.Yellow;
                lblFacil.ForeColor = Color.Black;
                lblDificil.ForeColor = Color.Black;
            }
            else if (FrmInicial.dificuldade == "Dificil")
            {
                lblDificil.ForeColor = Color.Yellow;
                lblFacil.ForeColor = Color.Black;
                lblMedio.ForeColor = Color.Black;
            }
            if (config[1] == "MusicaOn")
            {
                lblMusicOn.ForeColor = Color.Yellow;
                lblMusicOff.ForeColor = Color.Black;
            }
            else if (config[1] == "MusicaOff")
            {
                lblMusicOff.ForeColor = Color.Yellow;
                lblMusicOn.ForeColor = Color.Black;
            }
            if (config[2] == "SFXOn")
            {
                lblSFXOn.ForeColor = Color.Yellow;
                lblSFXOff.ForeColor = Color.Black;
            }
            else if (config[2] == "SFXOff")
            {
                lblSFXOff.ForeColor = Color.Yellow;
                lblSFXOn.ForeColor = Color.Black;
            }
        }

        static public string[] LerConfig()
        {
            string erro = "Arquivo de configurações inválido. Geraremos um novo";
            string[] config = File.ReadAllLines("Configuracoes.txt");
            FrmInicial.dificuldade = config[0];
            if (FrmInicial.dificuldade != "Facil" && FrmInicial.dificuldade != "Medio" && FrmInicial.dificuldade != "Dificil")
            {
                MessageBox.Show(erro);
                FrmConfiguracoes.GeraConfig();
            }
            if (config[1] == "MusicaOn")
            {
                FrmInicial.musicaon = true;
                if(!FrmInicial.tocando)
                {
                    FrmInicial.musicmenu.PlayLooping();
                    FrmInicial.tocando = true;
                }
            }
            else if (config[1] == "MusicaOff")
            {
                FrmInicial.musicaon = false;
                FrmInicial.musicmenu.Stop();
                FrmInicial.tocando = false;
            }
            else
            {
                MessageBox.Show(erro);
                FrmConfiguracoes.GeraConfig();
            }
            if (config[2] == "SFXOn")
            {
                FrmInicial.sfxon = true;
            }
            else if (config[2] == "SFXOff")
            {
                FrmInicial.sfxon = false;
            }
            else
            {
                MessageBox.Show(erro);
                FrmConfiguracoes.GeraConfig();
            }
            return config;
        }

        public FrmConfiguracoes()
        {
            InitializeComponent();
        }


        private void dificuldade_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {

            if (File.Exists("Configuracoes.txt"))
            {
                string[] configuracao = LerConfig();
                MudaCor(configuracao);
            }
            else
            {
                GeraConfig();
                MudaCor(File.ReadAllLines("Configuracoes.txt"));
            }
        }

        private void lblFacil_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[0] = "Facil";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void lblMedio_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[0] = "Medio";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void lblDificil_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[0] = "Dificil";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void lblMusicOn_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[1] = "MusicaOn";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void lblMusicOff_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[1] = "MusicaOff";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void lblSFXOn_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[2] = "SFXOn";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void lblSFXOff_Click(object sender, EventArgs e)
        {
            string[] newconfig = configtext;
            newconfig[2] = "SFXOff";
            File.WriteAllLines("Configuracoes.txt", newconfig);
            string[] configuracao = LerConfig();
            MudaCor(configuracao);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicial.inicial.Show();
        }
    }
}
