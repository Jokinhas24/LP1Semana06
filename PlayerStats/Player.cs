using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private readonly string name;
        private float highScore { get; set; }
        private int playedGames { get; set; }
        private int wonGames { get; set; }
        private readonly float WinRate;

        public void HighScore(float newScore, float highScore)
        {
            if (newScore > highScore)
            {
                highScore = newScore;
            }
        }
        public readonly float WinRate()
        {
            if (playedGames > 0)
            {
                return (float)(playedGames / wonGames);
            }
            else
            {
                return string ("This Player hasn't played any games");
            }
        }
        public void PlayGame(bool win)
        {
            playedGames += 1;
            if (win == true)
            {
                wonGames += 1;
            }

        }
        Player(string name)
        {
            this.name = name;
            this.highScore = 0;
            this.playedGames = 0;
            this.wonGames = 0;
        }
    
    }
}