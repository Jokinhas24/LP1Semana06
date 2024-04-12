using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        public readonly string Name;
        private float highScore { get; set; }
        private int playedGames { get; set; }
        private int wonGames { get; set; }

        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
        public float WinRate
        {
            get
            {
                if (wonGames == 0)
                {
                    return 0;
                }
                else
                {
                    return (wonGames/(float)playedGames);
                }
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
        public Player(string name)
        {
            Name = name;
            this.highScore = 0;
            this.playedGames = 0;
            this.wonGames = 0;
        }
    
    }
}