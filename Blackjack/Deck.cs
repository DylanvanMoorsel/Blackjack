using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        // pakt alle soorten kaarten en zet er _ tussen zodat hij de img ervan kan gebruiken
        public Deck()
        {
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card();
                    card.Rank = rank + "_of_" + suit;
                    card.IsFaceUp = true;
                    cards.Add(card);
                }
            }
        }

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