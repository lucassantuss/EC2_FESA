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

namespace Ex1
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        #region Enunciado
        /* 1-) Crie um cadastro de clientes que possua os seguintes campos:
         * 
         * código do cliente  (inteiro)
         * nome do cliente  (string)
         * data de nascimento  (datetime)
         * 
         * Coloque um botão que ao ser pressionado irá validar os dados.
         * 
         * todos os campos são obrigatórios
         * A data de nascimento não pode ser superior a data atual 
         */
        #endregion

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;
                codigo = int.Parse(txtCodigo.Text);

                string nome = txtNome.Text;

                if (nome == null || nome == "")
                {
                    MessageBox.Show("Digite um nome válido!!");
                    txtNome.Focus();
                }
                else
                {
                    try
                    {
                        DateTime DataNascimento = dataNasc.Value;

                        if (DataNascimento == DateTime.Now || DataNascimento >= DateTime.Today)
                        {
                            MessageBox.Show("Digite uma data válida e inferior ao dia de hoje!!");
                            dataNasc.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Dados válidados com sucesso!!" +
                                $"\n\nCódigo: {codigo}" +
                                $"\nNome: {nome}" +
                                $"\nData de Nascimento: {dataNasc.Value.ToShortDateString()}");

                            string conteudo = txtCodigo.Text + Environment.NewLine +
                                txtNome.Text + Environment.NewLine +
                                dataNasc.Value.ToShortDateString();

                            File.WriteAllText("dados.txt", conteudo);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Digite uma data válida e inferior ao dia de hoje!!");
                        dataNasc.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Digite um código inteiro!!");
                txtCodigo.Focus();
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt");

                txtCodigo.Text = linhas[0];
                txtNome.Text = linhas[1];
                dataNasc.Value = Convert.ToDateTime(linhas[2]);
            }
        }
    }
}