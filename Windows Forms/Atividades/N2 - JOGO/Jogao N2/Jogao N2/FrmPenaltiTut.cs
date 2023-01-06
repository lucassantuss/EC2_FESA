using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2
{
    public partial class FrmPenaltiTut : Form
    {
        public FrmPenaltiTut()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void FormPenalteTut_Load(object sender, EventArgs e)
        {

        }

        private void FormPenalteTut_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FrmPenalti Penalti = new FrmPenalti();
                Penalti.Show();
                this.Close();
            }
        }
    }
}
