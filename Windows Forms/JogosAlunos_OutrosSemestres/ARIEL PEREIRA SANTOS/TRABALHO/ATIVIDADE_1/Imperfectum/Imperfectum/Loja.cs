using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Imperfectum
{
    public partial class Loja : Form
    {
        private Jogador jogador;
        private NPC vendedor;
        public Loja(Jogador player, NPC seller)
        {
            jogador = player;
            vendedor = seller;
            InitializeComponent();
            lblSellerBag.Text = vendedor.Nome;
            lblGold.Text = jogador.Gold.ToString();
            Atualiza();
            if(jogador.Bag.Count>0)
                cbPlayer.SelectedIndex = 0;
            if(vendedor.Bag.Count>0)
                cbSeller.SelectedIndex = 0;
        }
        private void Atualiza()
        {
            cbPlayer.DataSource = jogador.Bag;
            cbPlayer.DisplayMember = "Nome";
            cbPlayer.ValueMember = "ItemID";
            BagItem show = (BagItem)cbPlayer.SelectedItem;
            if(show!=null)
                rtxtPlayer.Text = show.Nome + " - " + show.Preco + " gold"+Environment.NewLine;
            cbSeller.DataSource = vendedor.Bag;
            cbSeller.DisplayMember = "Nome";
            cbSeller.ValueMember = "ItemID";
            BagItem mostra = (BagItem)cbSeller.SelectedItem;
            if(mostra!=null)
                rtxtSeller.Text = mostra.Nome + " - " + mostra.Preco + " gold" + Environment.NewLine;
            lblSellerBag.Text = vendedor.Nome;
            lblGold.Text = jogador.Gold.ToString();
        }
        private void AtualizaCB()
        {
            List<Item> itens = new List<Item>();
            foreach(BagItem bagItem in jogador.Bag)
            {
                if (bagItem.Quantidade > 0)
                {
                    itens.Add(bagItem.Detalhes);
                }
            }
            if (itens.Count == 0)
            {
                cbPlayer.Visible = false;
                btnVende.Visible = false;
            }
            else
            {
                cbPlayer.DataSource = itens;
                cbPlayer.DisplayMember = "Nome";
                cbPlayer.ValueMember = "ItemID";
                cbPlayer.Visible = true;
                btnVende.Visible = true;
            }
        }
        private void btnFecha_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnVende_Click(object sender, EventArgs e)
        {
            BagItem bagItem = (BagItem)cbPlayer.SelectedItem;
            Item itemBeingSold = Mundo.Itens.Find(x => x.ID.Equals(bagItem.ItemID));
            jogador.RemoveItemFromInventory(itemBeingSold);
            jogador.Gold += itemBeingSold.Preco;
            Atualiza();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            BagItem bagItem = (BagItem)cbSeller.SelectedItem;
            Item itemBeingBought = Mundo.Itens.Find(x => x.ID.Equals(bagItem.ItemID));
            if (jogador.Gold >= itemBeingBought.Preco)
            {
                jogador.AddItemToBag(itemBeingBought);
                jogador.Gold -= itemBeingBought.Preco;
            }
            else
                MessageBox.Show("Gold insuficiente.");
            Atualiza();
        }

        private void cbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void cbSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atualiza();
        }
    }
}
