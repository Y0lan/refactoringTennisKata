using System.Security.Cryptography;
using ESGI.DesignPattern.Projet.Rules;

namespace ESGI.DesignPattern.Projet
{
    public class ScoreNaming : IScoreNaming
    {
        private ITennisScoreCalculator _calculator;

        public ScoreNaming(Player p1, Player p2)
        {
            _calculator = CalculateScoreName(p1, p2);
        }

        public string GetScoreName(Player p1, Player p2)
        {
            return _calculator.CalculateScoreName(p1, p2);
        }

        private ITennisScoreCalculator CalculateScoreName(Player p1, Player p2)
        {
            if (isEquality(p1, p2))
            {
                return new EqualScoreCalculator();
            }

            if (isGreaterThanOrEqualTo4(p1, p2))
            {
                return new GreaterThanEqual4Calculator();
            }

            return new LessThan3Calculator();
        }

        private bool isEquality(Player p1, Player p2)
        {
            return p1.GetScore() == p2.GetScore();
        }

        private bool isGreaterThanOrEqualTo4(Player p1, Player p2)
        {
            return p1.GetScore() >= 4 || p2.GetScore() >= 4;
        }
    }
}