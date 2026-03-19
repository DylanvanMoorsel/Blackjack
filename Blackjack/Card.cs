using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        public string Rank { get; set; }  // Haalt de ranks op (Aas of nummer etc)
        public bool IsFaceUp { get; set; } // houdt geheim voor dealer
    }
}