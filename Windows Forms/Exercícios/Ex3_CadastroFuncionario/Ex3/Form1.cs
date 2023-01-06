using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex3
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbSexo, "Selecione um sexo");
            }
            if (cbCidade.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbCidade, "Selecione uma cidade");
            }
            if (txtData.Value < DateTime.Now)
            {
                errorProvider1.SetError(txtData, "Digite uma data válida e inferior ao dia de hoje");
            }
            if (txtNome.Text == "")
            {
                errorProvider1.SetError(txtNome, "Digite um nome");
            }
            if (nudCod.Value <= 0)
            {
                errorProvider1.SetError(nudCod, "Digite um código válido e maior que zero");
            }
        }

        private void checkCasa_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkCasa.Checked == true)
            {
                listEletro.Enabled = true;
            }
            else
            {
                listEletro.Enabled = false;
            }
        }
    }
}
