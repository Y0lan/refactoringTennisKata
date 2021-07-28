namespace ESGI.DesignPattern.Projet.Rules
{
    public class LessThan3Calculator : ITennisScoreCalculator
    {
        public string CalculateScoreName(Player p1, Player p2)
        {
            return GetScoreName(p1.GetScore()) + "-" + GetScoreName(p2.GetScore());
        }

        private static string GetScoreName(int score)
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
    }
}