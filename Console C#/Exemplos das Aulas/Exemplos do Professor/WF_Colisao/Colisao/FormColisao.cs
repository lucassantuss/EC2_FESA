using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormColisao : Form
    {
        public FormColisao()
        {
            InitializeComponent();
        }       

        private bool Colisao(PictureBox parede, int x, int y)
        {
            var retanguloMouse = new Rectangle(
              x, y, 12, 22);
            //Cursor.Size.Width,
            //Cursor.Size.Height);


            var retanguloParede = new Rectangle(
              parede.Left,
              parede.Top,
              parede.Width,
              parede.Height);

            bool isCollision = retanguloParede.IntersectsWith(retanguloMouse);
            return isCollision;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            int mouseX = MousePosition.X;
            int mouseY = MousePosition.Y;

            //ajusta o x e y para a posição atual da tela
            int x = mouseX - this.Location.X - 8; // 8px é a borda da tela
            int y = mouseY - this.Location.Y - 30; // 30px é o título da janela
            bool resultado = false;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    resultado = Colisao((c as PictureBox), x, y);
                    if (resultado)
                        break;
                }
            }

            if (resultado)            
                Text = "colidiu em " + DateTime.Now.ToLongTimeString() + " x: " + x + "  y: " + y;            
            else
                Text = "NÃO colidiu em " + DateTime.Now.ToLongTimeString() + " x: " + x + "  y: " + y;
        }
    }
}