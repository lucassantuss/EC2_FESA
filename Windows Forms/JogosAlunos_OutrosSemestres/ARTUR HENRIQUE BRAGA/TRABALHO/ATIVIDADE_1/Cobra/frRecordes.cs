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

namespace Cobra
{
    public struct Usuario
    {
        public string Nome;
        public int Score;
    }
    public partial class frRecordes : Form
    {
        public Usuario[] usuarios = new Usuario[100];
        public int qtde = 0;
        public frRecordes()
        {
            InitializeComponent();
            CarregarArquivo();
            ExibirRecordes();
        }
        /// <summary>
        /// Carrega arquivo texto e cria novo usuário
        /// </summary>
        void CarregarArquivo()
        {
            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt");
                foreach (string linha in linhas)
                {
                    string[] dataLine = linha.Split('|');

                    usuarios[qtde] = new Usuario();

                    usuarios[qtde].Nome = dataLine[0];
                    usuarios[qtde].Score = Convert.ToInt32(dataLine[1]);
             
                    qtde++;
                }
            }
        }
        /// <summary>
        /// Organiza os usuários e suas pontuações em forma de ranking
        /// </summary>
        void ExibirRecordes()
        {
            Array.Sort(usuarios, (x, y) => y.Score.CompareTo(x.Score));

            for (int i = 0; i < qtde; i++)
            {
                if(usuarios[i].Score > 0)
                    llbLista.Text += $"\r\n {i + 1}º Lugar      {usuarios[i].Nome} - {usuarios[i].Score}";
            }
        }
    }
}
