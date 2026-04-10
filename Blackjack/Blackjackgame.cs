using System.Collections.Generic;

namespace Blackjack
{
    internal class BlackjackGame
    {
        Dealer dealer = new Dealer();

        public List<string> playerHand = new List<string>();
        public List<string> dealerHand = new List<string>();

        public void Deal()
        {
            playerHand.Clear();
            dealerHand.Clear();

            dealerHand.Add(dealer.DrawCard());
            dealerHand.Add(dealer.DrawCard());
            playerHand.Add(dealer.DrawCard());
            playerHand.Add(dealer.DrawCard());
        }

        public void CheckDealerHand()
        {
            while (GetTotal(dealerHand) < 17)
            {
                dealerHand.Add(dealer.DrawCard());
            }
        }

        public int GetTotal(List<string> hand)
        {
            int totaal = 0;
            foreach (string card in hand)
            {
                totaal += dealer.GetCardValue(card);
            }
            return totaal;
        }
        public string Hit()
        {
            return dealer.DrawCard();
        }
    }
}