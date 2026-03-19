using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "Harten", "Ruiten", "Klaveren", "Schoppen" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card();
                    card.Rank = rank + " " + suit;
                    card.IsFaceUp = true;
                    cards.Add(card);
                }
            }
        }
        // schudt de kaarten door alle kaarten 1 van te pakken
        public void Shuffle()
        {
            Random random = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int j = random.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }
        // dealt de kaarten 2 zichtbare voor speler + 1 zichtbare 1 "onzichtbare" voor Dealer
        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                throw new BlackjackException();
            }

            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }
    }
}