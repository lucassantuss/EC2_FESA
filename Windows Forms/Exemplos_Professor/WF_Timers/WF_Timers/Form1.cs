using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Timers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int n = 0; n <= 50000; n++)
            {
                lblContador.Text = n.ToString();
                Application.DoEvents();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerRelogio.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerRelogio.Stop();
        }

        private void timerRelogio_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            imgTaxi.Left = 0;
            imgUber.Left = 0;
            timerCorrida.Start();
        }

        private void timerCorrida_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();
            imgUber.Left = imgUber.Left + gerador.Next(0, 51);
            imgTaxi.Left = imgTaxi.Left + gerador.Next(0, 51);

            if
                (imgTaxi.Left + imgTaxi.Width >= imgCliente.Left)
            {
                timerCorrida.Stop();
                MessageBox.Show("O taxi foi o vencedor!");
            }
            if (imgUber.Left + imgUber.Width >= imgCliente.Left)
            {
                timerCorrida.Stop();
                MessageBox.Show("O uber foi o vencedor!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                imgNave.Top = imgNave.Top - 10;
            else if (e.KeyCode == Keys.S)
                imgNave.Top = imgNave.Top + 10;
            else if (e.KeyCode == Keys.A)
                imgNave.Left = imgNave.Left - 10;
            else if (e.KeyCode == Keys.D)
                imgNave.Left = imgNave.Left + 10;

            char tecla = char.ToUpper(Convert.ToChar(e.KeyValue));

            if (tecla == 'A' || tecla == 'E' || tecla == 'I' || tecla == 'O' ||
                tecla == 'U')
                e.SuppressKeyPress = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          
        }
    }
}
