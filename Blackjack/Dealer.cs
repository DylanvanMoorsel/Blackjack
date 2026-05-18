using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Dealer
    {
        private Deck deck = new Deck();
        private Random random = new Random();

        // trekt een willekeurige kaart uit het deck
        public string DrawCard()
        {
            int index = random.Next(deck.Cards.Count);
            string card = deck.Cards[index];
            deck.Cards.RemoveAt(index);
            return card;
        }

        // geeft de waarde van een kaart terug
        public int GetCardValue(string card)
        {
            string rank = card.Split('_')[0];

            if (rank == "jack" || rank == "queen" || rank == "king") return 10;
            if (rank == "ace") return 11;
            return int.Parse(rank);
        }
    }
}