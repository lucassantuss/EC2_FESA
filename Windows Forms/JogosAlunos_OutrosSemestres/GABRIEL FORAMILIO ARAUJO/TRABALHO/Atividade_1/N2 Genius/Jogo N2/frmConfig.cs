using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_N2
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }
        private void btnMusica_Click(object sender, EventArgs e)
        {
            if (Dados_globais.musica)
            {
             
                Dados_globais.musica = false;
                Dados_globais.Fundo.Stop();
            }
            else
            {
                Dados_globais.Fundo.PlayLooping();
                
                Dados_globais.musica = true;
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            if (Dados_globais.musica)
            {
              
                Dados_globais.Fundo.PlayLooping();
            }
            else if (!Dados_globais.musica)
            {
             
                Dados_globais.Fundo.Stop();
            }
        }
    }
}
