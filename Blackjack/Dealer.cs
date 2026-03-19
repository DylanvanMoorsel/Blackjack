using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Dealer
    {
        private Deck deck;

        public Dealer()
        {
            deck = new Deck();
            deck.Shuffle();
        }

        public List<Card> GiveCardsToPlayer()
        {
            List<Card> hand = new List<Card>();
            Card card1 = deck.DealCard();
            Card card2 = deck.DealCard();
            card1.IsFaceUp = true;
            card2.IsFaceUp = true;
            hand.Add(card1);
            hand.Add(card2);
            return hand;
        }

        // geeft de kaarten aan dealer
        public List<Card> GiveCardsToDealer()
        {
            List<Card> hand = new List<Card>();
            Card card1 = deck.DealCard();
            Card card2 = deck.DealCard();

            card1.IsFaceUp = true;
            card2.IsFaceUp = false;

            hand.Add(card1);
            hand.Add(card2);

            return hand;
        }
    }
}