using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ESGI.DesignPattern.Projet
{
    class TennisGame : IGame
    {
        private Player p1;
        private Player p2;
        private IScoreNaming _scoreNaming;


        public TennisGame(Player player1, Player player2)
        {
            p1 = player1;
            p2 = player2;
        }

        public void WonPoint(Player player)
        {
            var currentPlayerScore = player.GetScore();
            player.SetScore(currentPlayerScore + 1);
        }

        public string GetScore()
        {
            _scoreNaming = new ScoreNaming(p1, p2);

            return _scoreNaming.GetScoreName(p1, p2);
        }
    }
}