using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_detecção_teclas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                imgRyu.Top = (int)(imgRyu.Top - txtVelocidade.Value);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.S)
            { 
                imgRyu.Top = (int)(imgRyu.Top + txtVelocidade.Value);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.A)
            { 
                imgRyu.Left = (int)(imgRyu.Left - txtVelocidade.Value);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.D)
            { 
                imgRyu.Left = (int)(imgRyu.Left + txtVelocidade.Value);
                e.SuppressKeyPress = true;
            }


        }

        private void imgRyu_Click(object sender, EventArgs e)
        {

        }
    }
}
