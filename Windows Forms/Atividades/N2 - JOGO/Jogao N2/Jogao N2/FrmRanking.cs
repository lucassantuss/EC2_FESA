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
    public partial class FrmRanking : Form
    {
        public FrmRanking()
        {
            InitializeComponent();

            if (File.Exists("Ranking.txt"))
            {
                string[] linhas = File.ReadAllLines("Ranking.txt");
                foreach (string linha in linhas)
                {
                    string[] dados = linha.Split('|');

                    lbRanking.Items.Add(
                        "Nome: " + dados[0] +
                        "  -  Pontuação: " + dados[1] +
                        "  -  Dificuldade: " + dados[2] +
                        "  -  Data: " + dados[3]);
                }
            }
        }

        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            FrmInicial.inicial.Show();
            this.Close();
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {

        }
    }
}