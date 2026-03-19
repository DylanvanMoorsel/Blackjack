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

            // laat de images van de kaarten zien van de speler
            picPlayer1.Image = System.Drawing.Image.FromFile("Cards/" + playerHand[0].Rank + ".png");
            picPlayer2.Image = System.Drawing.Image.FromFile("Cards/" + playerHand[1].Rank + ".png");

            // laat de images van de kaarten zien van de dealer
            picDealer1.Image = System.Drawing.Image.FromFile("Cards/" + dealerHand[0].Rank + ".png");
            picDealer2.Image = System.Drawing.Image.FromFile("Cards/card_back.png"); // "geheime" kaart
        }
    }
}