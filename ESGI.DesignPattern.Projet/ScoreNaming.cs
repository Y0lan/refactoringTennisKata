using System.Security.Cryptography;
using ESGI.DesignPattern.Projet.Rules;

namespace ESGI.DesignPattern.Projet
{
    public class ScoreNaming : IScoreNamer
    {
        private ITennisScoreCalculator _calculator;

        public string GetScoreName(Player p1, Player p2)
        {
            return _calculator.CalculateScoreName(p1, p2);
        }

        public ITennisScoreCalculator GetRulesCalculator(Player p1, Player p2)
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

        public bool isEquality(Player p1, Player p2)
        {
            return p1.GetScore() == p2.GetScore();
        }

        public bool isGreaterThanOrEqualTo4(Player p1, Player p2)
        {
            return p1.GetScore() >= 4 || p2.GetScore() >= 4;
        }
    }
}