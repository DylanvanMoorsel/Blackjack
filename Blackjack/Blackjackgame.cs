using System.Collections.Generic;

namespace Blackjack
{
    internal class BlackjackGame
    {
        Dealer dealer = new Dealer();

        public List<string> playerHand = new List<string>();
        public List<string> dealerHand = new List<string>();

        // deelt kaarten aan speler en dealer
        public void Deal()
        {
            playerHand.Clear();
            dealerHand.Clear();

            dealerHand.Add(dealer.DrawCard());
            dealerHand.Add(dealer.DrawCard());
            playerHand.Add(dealer.DrawCard());
            playerHand.Add(dealer.DrawCard());
        }

        // trekt een extra kaart
        public string Hit()
        {
            return dealer.DrawCard();
        }

        // speler trekt automatisch kaarten tot 17 of meer
        public void CheckPlayerHand()
        {
            while (GetTotal(playerHand) < 17)
            {
                playerHand.Add(dealer.DrawCard());
            }
        }

        // berekent het totaal van een hand
        public int GetTotal(List<string> hand)
        {
            int totaal = 0;
            foreach (string card in hand)
            {
                totaal += dealer.GetCardValue(card);
            }
            return totaal;
        }
    }
}