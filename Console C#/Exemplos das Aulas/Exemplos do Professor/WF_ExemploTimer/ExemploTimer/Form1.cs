using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblHora.Text = "";
            //MessageBox.Show("Estou sendo criado");
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timerRelogio.Start();
            timerRelogio.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timerRelogio.Stop();
            timerRelogio.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerContagemRegressiva.Start();
        }

        private void timerContagemRegressiva_Tick(object sender, EventArgs e)
        {
            lblContagem.Text = (Convert.ToInt32(lblContagem.Text) - 1).ToString();
            if (lblContagem.Text == "0")
            {
                timerContagemRegressiva.Stop();
                MessageBox.Show("Tempo acabou!");                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Serei exibido");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void timerCarros_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();
            carro1.Left += gerador.Next(0, 51);
            carro2.Left += gerador.Next(0, 51);

            if (carro1.Left + carro1.Width > ClientRectangle.Width ||
                carro2.Left + carro2.Width > ClientRectangle.Width)
            {
                timerCarros.Stop();
                if (carro1.Left == carro2.Left)
                    MessageBox.Show("Isso é quase impossível, mas eles empataram!");
                else if (carro1.Left + carro1.Width > ClientRectangle.Width)
                    MessageBox.Show("Carro 1 ganhou");
                else
                    MessageBox.Show("Carro 2 ganhou");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            carro1.Left = 0;
            carro2.Left = 0;            
            timerCarros.Start();
        }
    }
}
