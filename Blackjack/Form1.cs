using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
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

        // deal knop: deelt kaarten en laat speler automatisch trekken
        private void btnDelen_Click(object sender, EventArgs e)
        {
            game.Deal();
            game.CheckPlayerHand();

            // laat kaarten zien
            picDealer1.Image = Image.FromFile("Cards/" + game.dealerHand[0] + ".png");
            picDealer2.Image = Image.FromFile("Cards/" + game.dealerHand[1] + ".png");
            picPlayer1.Image = Image.FromFile("Cards/" + game.playerHand[0] + ".png");
            picPlayer2.Image = Image.FromFile("Cards/" + game.playerHand[1] + ".png");

            // toon extra kaart van speler als die er is
            if (game.playerHand.Count > 2)
            {
                picPlayer3.Image = Image.FromFile("Cards/" + game.playerHand[2] + ".png");
                picPlayer3.Visible = true;
            }

            // dealer krijgt keuze om te hitten of standen
            DealerKeuze();
        }

        // dealer kiest hit of stand
        private void DealerKeuze()
        {
            int dealerPunten = game.GetTotal(game.dealerHand);
            int spelerPunten = game.GetTotal(game.playerHand);

            string bericht = "Dealer punten: " + dealerPunten + "\nSpeler punten: " + spelerPunten + "\n\nWil je een extra kaart?\nJa = Hit\nNee = Stand";
            DialogResult keus = MessageBox.Show(bericht, "Hit of Stand?", MessageBoxButtons.YesNo);

            if (keus == DialogResult.Yes)
            {
                // dealer trekt extra kaart
                string newCard = game.Hit();
                game.dealerHand.Add(newCard);
                picDealer3.Image = Image.FromFile("Cards/" + newCard + ".png");
                picDealer3.Visible = true;

                // dealer krijgt opnieuw de keuze
                DealerKeuze();
            }
            else
            {
                // dealer stopt en winnaar wordt bepaald
                BepaalWinnaar();
            }
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