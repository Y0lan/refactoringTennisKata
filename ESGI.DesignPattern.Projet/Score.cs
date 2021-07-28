using System.Security.Cryptography;
using ESGI.DesignPattern.Projet.Rules;

namespace ESGI.DesignPattern.Projet
{
    public class Score : IScore
    {
        private ITennisScoreCalculator _calculator;

        public Score(Player p1, Player p2)
        {
            if (isEquality(p1, p2))
            {
                _calculator = EqualScoreCalculator.create();
            }
            else if (isGreaterThanOrEqualTo4(p1, p2))
            {
                _calculator = GreaterThanEqual4Calculator.create();
            }
            else
            {
                _calculator = LessThan3Calculator.create();
            }
        }

        public string GetScoreName(Player p1, Player p2)
        {
            return _calculator.CalculateScore(p1, p2);
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