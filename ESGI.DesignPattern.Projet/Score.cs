using ESGI.DesignPattern.Projet.Calculators;

namespace ESGI.DesignPattern.Projet
{
    public class Score : IScore
    {
        private readonly ITennisScoreCalculator _calculator;

        public Score(Player p1, Player p2)
        {
            if (isEquality(p1, p2))
            {
                _calculator = EqualScoreCalculator.Create();
            }
            else if (isGreaterThanOrEqualTo4(p1, p2))
            {
                _calculator = GreaterThanEqual4Calculator.Create();
            }
            else
            {
                _calculator = LessThan3Calculator.Create();
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