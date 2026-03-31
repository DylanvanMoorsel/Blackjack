using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Dealer dealer;
        private List<Card> playerHand;
        private List<Card> dealerHand;

        public Form1()
        {
            InitializeComponent();
        }

        // shuffle knop
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            dealer = new Dealer();
            MessageBox.Show("Deck is geschud!");
        }

        // start knop
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dealer == null)
            {
                MessageBox.Show("Shuffle eerst!");
                return;
            }
            MessageBox.Show("Spel gestart!");
        }

        // deal knop
        private void btnDelen_Click(object sender, EventArgs e)
        {
            if (dealer == null)
            {
                MessageBox.Show("Shuffle eerst!");
                return;
            }

            playerHand = dealer.GiveCardsToPlayer();
            dealerHand = dealer.GiveCardsToDealer();

            picPlayer1.Image = System.Drawing.Image.FromFile("Cards/" + playerHand[0].Rank + ".png");
            picPlayer2.Image = System.Drawing.Image.FromFile("Cards/" + playerHand[1].Rank + ".png");
            picDealer1.Image = System.Drawing.Image.FromFile("Cards/" + dealerHand[0].Rank + ".png");
            picDealer2.Image = System.Drawing.Image.FromFile("Cards/card_back.png");
        }
    }
}