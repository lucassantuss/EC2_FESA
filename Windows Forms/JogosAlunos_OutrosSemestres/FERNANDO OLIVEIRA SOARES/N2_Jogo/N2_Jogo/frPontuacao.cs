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

namespace N2_Jogo
{
    public partial class frPontuacao : Form
    {
        public frPontuacao()
        {
            InitializeComponent();
            lblUser.Text = frTelaLogin.nomeUsuario;
            lblScore.Text = frJogoPrincipal.pontuacao.ToString();
            frJogoPrincipal.pontuacao = 0;
            
            string conteudo = "";
            conteudo += Environment.NewLine + frTelaLogin.nomeUsuario.PadLeft(10).PadRight(53, '.') + lblScore.Text.ToString();
            File.AppendAllText("recordes.txt",conteudo);
        }
    }
}
