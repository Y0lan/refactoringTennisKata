namespace ESGI.DesignPattern.Projet.Calculators
{
    public class EqualScoreCalculator : ITennisScoreCalculator
    {
        public string CalculateScore(Player p1, Player p2)
        {
            var score = p1.GetScore() switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
            return score;
        }

        public static ITennisScoreCalculator Create()
        {
            return new EqualScoreCalculator();
        }
        
    }
}
