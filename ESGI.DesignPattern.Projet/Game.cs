using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    class TennisGame : IGame
    {
        private readonly Player _p1;
        private readonly Player _p2;
        private IScore _score;


        public TennisGame(Player player1, Player player2)
        {
            _p1 = player1;
            _p2 = player2;
        }

        public void WonPoint(Player player)
        {
            var currentPlayerScore = player.GetScore();
            player.SetScore(currentPlayerScore + 1);
        }

        public string GetScore()
        {
            _score = new Score(_p1, _p2);

            return _score.GetScoreName(_p1, _p2);
        }
    }
}