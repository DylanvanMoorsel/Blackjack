namespace Blackjack
{
    internal class FeedbackSysteem
    {
        public int score = 0;
        public int strafpunten = 0;

        // controleert of de dealer de juiste keuze heeft gemaakt
        public string ValideerKeuze(bool dealerGekozenHit, int dealerPunten)
        {
            if (dealerGekozenHit && dealerPunten < 17)
            {
                score += 1;
                return "Correcte keuze! +1 punt";
            }
            else if (!dealerGekozenHit && dealerPunten >= 17)
            {
                score += 1;
                return "Correcte keuze! +1 punt";
            }
            else
            {
                score -= 1;
                strafpunten += 1;
                return "Foute keuze! -1 punt";
            }
        }

        // controleert of de dealer nog verder mag
        public bool MagVerderSpelen()
        {
            return strafpunten < 2;
        }

        // geeft de eindevaluatie terug
        public string GeefEvaluatie(int dealerPunten)
        {
            string evaluatie = "Score: " + score + "\n\n";
            // als er 2 strafpunten zijn, is het spel gestopt
            if (strafpunten >= 2)
                evaluatie += "Je hebt 2 foute keuzes gemaakt. Spel gestopt.";
            // als de dealer boven 21 gaat, is dat ook een fout
            else if (dealerPunten > 21)
                evaluatie += "Verbeterpunt: Je bent boven 21 gegaan.";
            //  als de dealer onder 17 blijft, is dat ook een fout
            else if (dealerPunten < 17)
                evaluatie += "Verbeterpunt: Je had nog een kaart moeten trekken.";
            // als er geen fouten zijn, is het een goed resultaat
            else
                evaluatie += "Goed gedaan! Je hebt correct gespeeld.";

            return evaluatie;
        }
    }
}