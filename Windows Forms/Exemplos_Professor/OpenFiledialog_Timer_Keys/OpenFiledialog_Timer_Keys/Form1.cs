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

namespace OpenFiledialog_Timer_Keys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics c = CreateGraphics();
            //c.DrawLine(new Pen(Color.Red), 10, 10, 100, 100);



            openFileDialog1.Filter = "Imagens|*.jpg;*.bmp;*.png|Todos os arquivos|*.*";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.FileName = "";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Dados.txt";
            saveFileDialog1.Filter = "Arquivos texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.UTF8);
            }
        }

        private void txtTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.F10)
            {
                MessageBox.Show("Ganhou");
            }

            //MessageBox.Show(e.KeyCode.ToString());
            //MessageBox.Show(e.KeyValue.ToString());
            /*if (e.KeyCode == Keys.Enter)
                textBox2.Focus();

            e.SuppressKeyPress = true;
            textBox2.Text += Convert.ToChar(e.KeyValue);*/
        }

        private void txtTeclas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            textBox2.Text += e.KeyChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //timerHora.Enabled = true;
            timerHora.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timerHora.Stop();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timerCarros.Start();
        }

        private void timerCarros_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();
            carro1.Left +=   gerador.Next(0, 30);
            carro2.Left += gerador.Next(0, 30);
            
            if (carro1.Left + carro1.Width >= poste.Left)
            {
                timerCarros.Stop();
                MessageBox.Show("carro 1 ganhou");
            }

            if (carro2.Left + carro2.Width >= poste.Left)
            {
                timerCarros.Stop();
                MessageBox.Show("carro 2 ganhou");
            }
        }
    }
}
