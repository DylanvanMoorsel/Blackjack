using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        // maakt een nieuw spel aan
        BlackjackGame game = new BlackjackGame();

        public Form1()
        {
            InitializeComponent();
        }

        // shuffle knop
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            game = new BlackjackGame();
            MessageBox.Show("Deck is geschud!");
        }

        // start knop
        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spel gestart!");
        }

        // deal knop: deelt kaarten aan speler en dealer
        private void btnDelen_Click(object sender, EventArgs e)
        {
            game.Deal();
            game.CheckDealerHand();

            picDealer1.Image = Image.FromFile("Cards/" + game.dealerHand[0] + ".png");
            picDealer2.Image = Image.FromFile("Cards/" + game.dealerHand[1] + ".png");
            picPlayer1.Image = Image.FromFile("Cards/" + game.playerHand[0] + ".png");
            picPlayer2.Image = Image.FromFile("Cards/" + game.playerHand[1] + ".png");
        }

        // hit knop: trekt extra kaart en toont die op het scherm
        private void btnHit_Click(object sender, EventArgs e)
        {
            string newCard = game.Hit();
            game.playerHand.Add(newCard);
            picPlayer3.Image = Image.FromFile("Cards/" + newCard + ".png");
            picPlayer3.Visible = true;
            MessageBox.Show("Totaal: " + game.GetTotal(game.playerHand));
        }

        // stand knop: stopt en bepaalt winnaar
        private void btnStand_Click(object sender, EventArgs e)
        {
            BepaalWinnaar();
        }

        // vergelijkt de punten en vraagt dealer wie wint
        private void BepaalWinnaar()
        {
            int spelerPunten = game.GetTotal(game.playerHand);
            int dealerPunten = game.GetTotal(game.dealerHand);

            if (spelerPunten == dealerPunten)
            {
                MessageBox.Show("Gelijkspel!");
                return;
            }

            string bericht = "Speler: " + spelerPunten + "\nDealer: " + dealerPunten + "\n\nJa = Speler wint\nNee = Dealer wint";
            DialogResult keus = MessageBox.Show(bericht, "Wie wint?", MessageBoxButtons.YesNo);

            if (keus == DialogResult.Yes)
            {
                MessageBox.Show("Speler wint!");
                BerekenUitbetaling(true);
            }
            else
            {
                MessageBox.Show("Dealer wint!");
                BerekenUitbetaling(false);
            }
        }

        // berekent de uitbetaling
        private void BerekenUitbetaling(bool spelerWint)
        {
            if (spelerWint)
            {
                MessageBox.Show("Uitbetaling: Speler krijgt 2x zijn inzet.");
            }
            else
            {
                MessageBox.Show("Uitbetaling: Dealer houdt de inzet.");
            }
        }
    }
}