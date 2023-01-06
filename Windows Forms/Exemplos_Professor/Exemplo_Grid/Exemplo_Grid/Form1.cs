using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Grid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gridProdutos.Columns.Add("colLinha", "Linha");
            gridProdutos.Columns.Add("colCodigo", "Código");
            gridProdutos.Columns.Add("colDescricao", "Descrição do produto");
            gridProdutos.Columns.Add("colPreco", "Preço");

            gridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            gridProdutos.Columns["colLinha"].Width = 85;
            gridProdutos.Columns["colCodigo"].Width = 85;
            gridProdutos.Columns["colPreco"].Width = 85;

            gridProdutos.Columns["colLinha"].ReadOnly = true;
            gridProdutos.Columns["colLinha"].DefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.Gray
            };


            gridProdutos.Rows.Add();
            gridProdutos.Rows.Add();
            gridProdutos.Rows.Add();
            gridProdutos.Rows.Add();


            for (int n = 0; n < gridProdutos.Rows.Count; n++)
            {
                gridProdutos.Rows[n].Cells["colLinha"].Value = (n + 1).ToString();
            }

            gridProdutos.AllowUserToAddRows = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResumo.Text = "";

            double soma = 0;
            for (int n = 0; n < gridProdutos.Rows.Count; n++)
            {
                txtResumo.Text +=
                        gridProdutos.Rows[n].Cells["colCodigo"].Value + " - " +
                        gridProdutos.Rows[n].Cells["colDescricao"].Value + " - " +
                        gridProdutos.Rows[n].Cells["colPreco"].Value + Environment.NewLine;

                soma += Convert.ToDouble(gridProdutos.Rows[n].Cells["colPreco"].Value);
            }

            txtResumo.Text += Environment.NewLine + "TOTAL = " + soma.ToString("0.00");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gridProdutos.Rows.Clear();
        }
    }
}
