using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private string name { get; set; }
        private float highScore { get; set; }
        private int playedGames { get; set; }
        private readonly float WinRate { get; set; }

        public void HighScore(float newScore, float highScore)
        {
            if (newScore > highScore)
            {
                highScore = newScore;
            }
        }
        public void PlayGame(bool win)
        {
            playedGames += 1;
            
        }
    }
}