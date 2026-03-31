using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            // maakt alle kaarten aan
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card card = new Card();
                    // Hier plakken we de naam aan elkaar, bijv: "2_of_clubs"
                    card.Rank = rank + "_of_" + suit;
                    card.IsFaceUp = true;
                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            // schudt het deck
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
            // geeft de bovenste kaart en haalt hem uit de lijst
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }
    }
}