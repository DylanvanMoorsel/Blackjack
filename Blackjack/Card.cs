using System;

namespace Blackjack
{
    public class Card
    {
        public string Rank { get; set; } // haalt de rank van de kaart op, zoals "2_of_clubs" of "ace_of_spades"
        public bool IsFaceUp { get; set; } // geeft aan of de kaart open ligt (true) of gesloten (false)
    }
}