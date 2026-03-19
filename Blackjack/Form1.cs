using System;
using System.Collections.Generic;
using System.ComponentModel;
// Form1.cs
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            dealer = new Dealer();
            playerHand = dealer.GiveCardsToPlayer();
            dealerHand = dealer.GiveCardsToDealer();

            lblPlayer.Text = "Jouw kaarten: " + playerHand[0].Rank + " en " + playerHand[1].Rank;
            lblDealer.Text = "Dealer kaarten: " + dealerHand[0].Rank + " en [verborgen]";
        }
    }
}