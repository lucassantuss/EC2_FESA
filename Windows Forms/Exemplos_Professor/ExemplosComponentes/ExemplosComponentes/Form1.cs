using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplosComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbDiaSemana.Items.Add("Domingo");
            cbDiaSemana.Items.Add("Segunda");
            cbDiaSemana.Items.Add("Terça");
            cbDiaSemana.Items.Add("Quarta");
            cbDiaSemana.Items.Add("Quinta");
            cbDiaSemana.Items.Add("Sexta");
            cbDiaSemana.Items.Add("Sábado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ckTemCarteiraMotorista.Checked)
                MessageBox.Show("Tem carteira de motorista");
            else
                MessageBox.Show("Não tem carteira de motorista");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbVeiculo.SelectedIndex == -1)
                MessageBox.Show("Não há nada selecionado!");
            else
            {
                MessageBox.Show(cbVeiculo.Text);
                MessageBox.Show(cbVeiculo.Items[cbVeiculo.SelectedIndex].ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbVeiculo.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rbMasculino.Checked == false && rbFeminino.Checked == false)
                MessageBox.Show("Nada está marcado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (rbMasculino.Checked)
                ExibeMsgInformacao("Masculino está marcado");
            else
                ExibeMsgInformacao("Feminino está marcado");

        }


        private void ExibeMsgInformacao(string texto)
        {
            MessageBox.Show(texto, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
