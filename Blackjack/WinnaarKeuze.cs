namespace Blackjack
{
    internal class WinnaarKeuze
    {
        // vergelijkt de punten en geeft terug wie er wint
        public string BepaalWinnaar(int spelerPunten, int dealerPunten)
        {
            // gelijkspel als beide hetzelfde hebben
            if (spelerPunten == dealerPunten) return "Gelijkspel: Inzet terug.";

            // speler boven 21 = dealer wint automatisch
            if (spelerPunten > 21) return "Dealer wint!\nUitbetaling: Dealer houdt de inzet.";

            // dealer boven 21 = speler wint automatisch
            if (dealerPunten > 21) return "Speler wint!\nUitbetaling: Speler krijgt 2x zijn inzet.";

            // wie de meeste punten heeft wint
            if (spelerPunten > dealerPunten) return "Speler wint!\nUitbetaling: Speler krijgt 2x zijn inzet.";
            return "Dealer wint!\nUitbetaling: Dealer houdt de inzet.";
        }
    }
}