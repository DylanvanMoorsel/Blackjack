namespace Blackjack
{
    internal class WinnaarKeuze
    {
        // vergelijkt de punten en geeft terug wie er wint
        public string BepaalWinnaar(int spelerPunten, int dealerPunten)
        {
            // gelijkspel als beide hetzelfde hebben
            if (spelerPunten == dealerPunten) return "gelijkspel";

            // speler boven 21 = dealer wint automatisch
            if (spelerPunten > 21) return "dealer";

            // dealer boven 21 = speler wint automatisch
            if (dealerPunten > 21) return "speler";


            // wie de meeste punten heeft wint
            if (spelerPunten > dealerPunten) return "speler";
            return "dealer";
        }
    }
}