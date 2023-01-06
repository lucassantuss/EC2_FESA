using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_Jogo
{
    public partial class frTelaConfig : Form
    {
        public frTelaConfig()
        {
            InitializeComponent();
            if (frTelaInicial.musica)
                lblControlaMusica.Text = "Ligadas";
            else
                lblControlaMusica.Text = "Desligadas";

            if (frTelaInicial.efeitos)
                lblControlaEfeitos.Text = "Ligadas";
            else
                lblControlaEfeitos.Text = "Desligadas";

            lblControlaDificuldade.Text = frTelaInicial.modo;
        }

        private void lblControlaMusica_Click(object sender, EventArgs e)
        {
            if(lblControlaMusica.Text == "Ligadas")
            {
                lblControlaMusica.Text = "Desligadas";
                frTelaInicial.musica = false;
    }
            else
            {
                lblControlaMusica.Text = "Ligadas";
                frTelaInicial.musica = true;
            }
        }

        private void lblControlaEfeitos_Click(object sender, EventArgs e)
        {
            if (lblControlaEfeitos.Text == "Ligadas")
            {
                lblControlaEfeitos.Text = "Desligadas";
                frTelaInicial.efeitos = false;
            }
            else
            {
                lblControlaEfeitos.Text = "Ligadas";
                frTelaInicial.efeitos = true;
            }
        }

        private void lblControlaDificuldade_Click(object sender, EventArgs e)
        {
            if (lblControlaDificuldade.Text == "Fácil")
            {
                lblControlaDificuldade.Text = "Médio";
                frTelaInicial.modo = "Médio";
            }
            else if (lblControlaDificuldade.Text == "Médio")
            {
                lblControlaDificuldade.Text = "Difícil";
                frTelaInicial.modo = "Difícil";
            }
            else if(lblControlaDificuldade.Text == "Difícil")
            { 
                lblControlaDificuldade.Text = "Fácil";
                frTelaInicial.modo = "Fácil";
            } 
        }
    }
}
