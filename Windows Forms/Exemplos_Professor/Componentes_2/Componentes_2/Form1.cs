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

namespace Componentes_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgTeste.ImageLocation = "216176_divide_icon.png";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imgTeste.ImageLocation = "216463_times_icon.png";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imgTeste.ImageLocation = @"C:\Users\eduardorm\Downloads\2561243_minus_circle_icon.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Escolha uma fotinha";
            openFileDialog1.Filter = "Imagens|*.jpg;*.png;*.gif;*.bmp|Todos os arquivos|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgTeste.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSalvarTexto_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Title = "Escolha o local para salvar";
            saveFileDialog1.Filter = "Arquivos texto|*.txt";
            saveFileDialog1.FileName = "dados.txt";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtAlgo.Text);
            }
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //timerRelogio.Enabled = true;
            timerRelogio.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timerRelogio.Stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            imgCaminhao.Left = 49;
            imgCarro.Left = 49;
            timerDeslocaCarro.Start();
        }

        private void timerDeslocaCarro_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();
            int sorteio = gerador.Next(1, 51);
            imgCarro.Left += sorteio;

            sorteio = gerador.Next(1, 51);
            imgCaminhao.Left += sorteio;
            
            if(imgCaminhao.Left + imgCaminhao.Width >= imgLinhaChegada.Left)
            {
                timerDeslocaCarro.Stop();
                MessageBox.Show("Caminhão ganhou!");
            }

            if (imgCarro.Left + imgCarro.Width >= imgLinhaChegada.Left)
            {
                timerDeslocaCarro.Stop();
                MessageBox.Show("Carro ganhou!");
            }

        }
    }
}
