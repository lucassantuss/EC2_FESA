using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PACGIRLARCADE
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        DataTable tabela = new DataTable();
        private void Form7_Load(object sender, EventArgs e)
        {
            tabela.Columns.Add("Nível", typeof(string));
            tabela.Columns.Add("Pontuação", typeof(int));
            tabela.Columns.Add("Nome", typeof(string));

            dataGridView1.DataSource = tabela;

            string[] linhas = File.ReadAllLines(@"ranking.txt");
            string[] valor;


            for (int i = 0; i < linhas.Length; i++)
            {
                valor = linhas[i].ToString().Split('|');
                string[] row = new string[valor.Length];

                for (int j = 0; j < valor.Length; j++)
                {
                    row[j] = valor[j].Trim();
                }
                tabela.Rows.Add(row);
            }
        }
    }
}
