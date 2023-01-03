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

namespace Imagens_e_Reconhecimento_de_teclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Tudo|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(openFileDialog1.FileName);
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            txtLog.Text += "KeyDown: keycode=" + e.KeyCode +
                "  Keydata=" + e.KeyData + " KeyValue=" + e.KeyValue +
                "  Shift=" + e.Shift + "  Control=" + e.Control +
                " Alt=" + e.Alt + Environment.NewLine;

            /*
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl((Control)sender, true, true, true, true);
                //textBox2.Focus(); */
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            txtLog.Text += "KeyUp: keycode=" + e.KeyCode +
                "  Keydata=" + e.KeyData + " KeyValue=" + e.KeyValue +
                "  Shift=" + e.Shift + "  Control=" + e.Control +
                " Alt=" + e.Alt + Environment.NewLine;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.SelectNextControl((Control)sender, true, true, true, true);
            //textBox2.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                MessageBox.Show("Tentando fechar a tela... não pode!");
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back)
                textBox3.Text += (char)e.KeyValue;
            e.SuppressKeyPress = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sabia!");
            Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random gerador = new Random();
            btnPorco.Top = gerador.Next(0, Height - btnPorco.Height);
            btnPorco.Left = gerador.Next(0, Width - btnPorco.Width);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.LightBlue;
            (sender as Control).BackColor = Color.LightBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.White;
            (sender as Control).BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "dados.txt";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Arquivos texto|*.txt";
            saveFileDialog1.InitialDirectory = "c:\\";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtLog.Text);
                //MessageBox.Show(saveFileDialog1.FileName);
            }
        }
    }
}
