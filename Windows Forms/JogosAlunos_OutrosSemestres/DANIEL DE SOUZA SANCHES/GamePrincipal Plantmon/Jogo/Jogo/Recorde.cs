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

namespace Jogo
{
    public partial class Recorde : Form
    {
        static string vetor_recordes;
        public Recorde(string texto)
        {
            InitializeComponent();

            lbRecorde1.Text = texto;
        }

        private void recuperaarquivo()
        {
            if (File.Exists("pontuacoes.txt"))
            {
                string[] linhas = File.ReadAllLines("pontuacoes.txt");
                foreach (string linha in linhas)
                {
                    string[] dadosLinha = linha.Split('|');
                    vetor_recordes = dadosLinha[0];
                }
            }
        }

    }
}
