namespace ESGI.DesignPattern.Projet.Calculators
{
    public class LessThan3Calculator : ITennisScoreCalculator
    {
        public string CalculateScore(Player p1, Player p2)
        {
            return GetScore(p1.GetScore()) + "-" + GetScore(p2.GetScore());
        }

        private static string GetScore(int score)
        {
            return score switch
            {
                0 => "Love",
                1 => "Fifteen",
                2 => "Thirty",
                3 => "Forty",
                _ => ""
            };
        }

        public static ITennisScoreCalculator Create()
        {
            return new LessThan3Calculator();
        }
    }
}