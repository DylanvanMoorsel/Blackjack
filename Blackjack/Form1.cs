using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        BlackjackGame game = new BlackjackGame();
        FeedbackSysteem feedbackSysteem = new FeedbackSysteem();
        WinnaarKeuze winnaarKeuze = new WinnaarKeuze();

        public Form1()
        {
            InitializeComponent();
        }

        //shuffle
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            game = new BlackjackGame();
            feedbackSysteem = new FeedbackSysteem();
            MessageBox.Show("Deck is geschud!");
        }
        //start
        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spel gestart!");
        }
        //delen
        private void btnDelen_Click(object sender, EventArgs e)
        {
            game.Deal();
            game.CheckPlayerHand();

            // kaarten laten zien
            picDealer1.Image = Image.FromFile("Cards/" + game.dealerHand[0] + ".png");
            picDealer2.Image = Image.FromFile("Cards/" + game.dealerHand[1] + ".png");
            picPlayer1.Image = Image.FromFile("Cards/" + game.playerHand[0] + ".png");
            picPlayer2.Image = Image.FromFile("Cards/" + game.playerHand[1] + ".png");

            if (game.playerHand.Count > 2)
            {
                picPlayer3.Image = Image.FromFile("Cards/" + game.playerHand[2] + ".png");
                picPlayer3.Visible = true;
            }

            DealerKeuze();
        }

        private void DealerKeuze()
        {
            int dealerPunten = game.GetTotal(game.dealerHand);
            int spelerPunten = game.GetTotal(game.playerHand);

            // popup voor hit of stand
            string bericht = "Dealer punten: " + dealerPunten + "\nSpeler punten: " + spelerPunten + "\n\nWil je een extra kaart?\nJa = Hit\nNee = Stand";
            DialogResult keus = MessageBox.Show(bericht, "Hit of Stand?", MessageBoxButtons.YesNo);
            //dialog is voor ja of nee knoppen, ja = hit, nee = stand
            if (keus == DialogResult.Yes)
            {
                string feedback = feedbackSysteem.ValideerKeuze(true, dealerPunten);
                MessageBox.Show(feedback);
                // controleer of de dealer nog verder mag spelen
                if (!feedbackSysteem.MagVerderSpelen())
                {
                    MessageBox.Show(feedbackSysteem.GeefEvaluatie(dealerPunten), "Spel gestopt");
                    return;
                }

                // nieuwe kaart trekken
                string newCard = game.Hit();
                game.dealerHand.Add(newCard);
                picDealer3.Image = Image.FromFile("Cards/" + newCard + ".png");
                picDealer3.Visible = true;

                DealerKeuze();
            }
            else
            {// controleer of de dealer de juiste keuze heeft gemaakt
                string feedback = feedbackSysteem.ValideerKeuze(false, dealerPunten);
                MessageBox.Show(feedback);
                // controleer of de dealer nog verder mag spelen
                if (!feedbackSysteem.MagVerderSpelen())
                {
                    MessageBox.Show(feedbackSysteem.GeefEvaluatie(dealerPunten), "Spel gestopt");
                    return;
                }

                // evaluatie tonen
                MessageBox.Show(feedbackSysteem.GeefEvaluatie(dealerPunten), "Evaluatie");
                // bepaal winnaar
                string resultaat = winnaarKeuze.BepaalWinnaar(spelerPunten, dealerPunten);
                MessageBox.Show(resultaat);
            }
        }
    }
}