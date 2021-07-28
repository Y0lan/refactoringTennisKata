using System.Security.Cryptography;

namespace ESGI.DesignPattern.Projet.Rules
{
    public class GreaterThanEqual4Calculator : ITennisScoreCalculator
    {
        public string CalculateScore(Player p1, Player p2)
        {
            var scoreDifferenceBetweenPlayers = p1.GetScore() - p2.GetScore();
            var score = scoreDifferenceBetweenPlayers switch
            {
                1 => "Advantage " + p1.GetName(),
                -1 => "Advantage " + p2.GetName(),
                _ => "Win for " + getWinnerByScore(p1, p2)
            };
            return score;
        }

        private string getWinnerByScore(Player p1, Player p2)
        {
            var scoreDifferenceBetweenPlayers = p1.GetScore() - p2.GetScore();
            return scoreDifferenceBetweenPlayers >= 2 ? p1.GetName() : p2.GetName();
        }

        public static ITennisScoreCalculator create()
        {
            return new GreaterThanEqual4Calculator();
        }
    }
}