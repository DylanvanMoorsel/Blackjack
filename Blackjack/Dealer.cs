using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Dealer
    {
        private Deck deck;

        public Dealer()
        {
            // Bij het aanmaken van de dealer wordt het deck direct geschud
            deck = new Deck();
            deck.Shuffle();
        }

        // Pak 2 kaarten voor de speler (beide open)
        public List<Card> GiveCardsToPlayer()
        {
            List<Card> hand = new List<Card>();

            hand.Add(deck.DealCard());
            hand.Add(deck.DealCard());

            return hand;
        }

        // Pak 2 kaarten voor de dealer (1 open, 1 dicht)
        public List<Card> GiveCardsToDealer()
        {
            List<Card> hand = new List<Card>();
            hand.Add(deck.DealCard());
            hand.Add(deck.DealCard());
            return hand;
        }
    }
}