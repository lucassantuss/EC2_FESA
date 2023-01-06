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

namespace Jogo
{
    public partial class Salva : Form
    {
        static string conteudo;
        static string status_som;
        static decimal guarda_dificuldade;
        static string guarda_dificuldadestr;

        public Salva(string texto)
        {
            InitializeComponent();
            conteudo += "ROUND" + "|" + texto;
            status_som = "ligado";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            guarda_dificuldade = numericUpDown1.Value;
            if (numericUpDown1.Value == 1)
                guarda_dificuldadestr = "Fácil";
            if (numericUpDown1.Value == 2)
                guarda_dificuldadestr = "Médio";
            if (numericUpDown1.Value == 3)
                guarda_dificuldadestr = "Vc tá loko";

            txtNome.Text.Trim();
            conteudo += "|" + txtNome.Text + "|" + status_som + "|" + guarda_dificuldadestr + Environment.NewLine;
            File.AppendAllText("pontuacoes.txt", conteudo);
            MessageBox.Show("Usuario gravado com sucesso!");

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbSoundOn_Click(object sender, EventArgs e)
        {
            pbSoundOn.Visible = false;
            pbSoundOff.BringToFront();
            pbSoundOff.Visible = true;
            status_som = "desligado";
        }

        private void Salva_Load(object sender, EventArgs e)
        {

        }

        private void pbSoundOff_Click(object sender, EventArgs e)
        {
            pbSoundOn.Visible = true;
            pbSoundOn.BringToFront();
            pbSoundOff.Visible = false;
            status_som = "ligado";
        }
    }
}
