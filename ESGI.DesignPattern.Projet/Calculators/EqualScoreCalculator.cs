namespace ESGI.DesignPattern.Projet.Rules
{
    public class EqualScore : ITennisScoreCalculator
    {
        public string CalculateScoreName(Player p1, Player p2)
        {
            var scoreName = p1.GetScore() switch
            {
                0 => "Love-All",
                1 => "Fifteen-All",
                2 => "Thirty-All",
                _ => "Deuce"
            };
            return scoreName;
        }
    }
}
