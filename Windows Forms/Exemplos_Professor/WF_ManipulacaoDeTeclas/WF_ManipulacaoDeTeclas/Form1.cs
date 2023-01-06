using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ManipulacaoDeTeclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imgBotao.ImageLocation = "desliga.png";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.A && e.Control)
                MessageBox.Show("Apertou a letra " + e.KeyCode +  " e o control"); */
            e.SuppressKeyPress = true;
            textBox2.Text += Convert.ToChar(e.KeyValue);
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                textBox3.Focus();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                textBox4.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            if (e.KeyCode == Keys.Left && imgNave.Left > 0)
                imgNave.Left = imgNave.Left - 10;
            else if (e.KeyCode == Keys.Right)
                imgNave.Left = imgNave.Left + 10;
            else if (e.KeyCode == Keys.Up)
                imgNave.Top = imgNave.Top - 10;
            else if (e.KeyCode == Keys.Down && (imgNave.Top + imgNave.Height < Height))
                imgNave.Top = imgNave.Top + 10;


            if (e.KeyCode == Keys.Space && imgBala.Visible == false)
            {
                imgBala.Left = imgNave.Left + imgNave.Width;
                imgBala.Top = imgNave.Top + (imgNave.Height / 2) - (imgBala.Height / 2);
                imgBala.Visible = true;
                timerTiro.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // MessageBox.Show("A tecla " + e.KeyCode + " estava pressionada e foi liberada");
        }

        private void timerTiro_Tick(object sender, EventArgs e)
        {
            imgBala.Left += 10;
            if (imgBala.Left > Width)
            {
                timerTiro.Stop();
                imgBala.Visible = false;
            }
        }

        private void imgBotao_Click(object sender, EventArgs e)
        {
            if (imgBotao.ImageLocation.Contains("desliga.png"))
                imgBotao.ImageLocation = "liga.png";
            else
                imgBotao.ImageLocation = "desliga.png";

        }
    }
}
