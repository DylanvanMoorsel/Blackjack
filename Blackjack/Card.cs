using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        public string Rank { get; set; }  // bijv. "A", "K", "10"
        public bool IsFaceUp { get; set; } // zichtbaar of verborgen
    }
}