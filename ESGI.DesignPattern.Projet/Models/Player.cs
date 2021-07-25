using System;

namespace ESGI.DesignPattern.Projet
{
    public class Player
    {
        private int _score;
        private string _name;

        public Player(int score)
        {
            _score = score;
        }

        public int GetScore()
        {
            return _score;
        }

        public void SetScore(int newScore)
        {
            _score = newScore;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            _name = newName;
        }

        public void AddPoint()
        {
            var newScore = _score + 1;
            SetScore(newScore);
        }
    }
}