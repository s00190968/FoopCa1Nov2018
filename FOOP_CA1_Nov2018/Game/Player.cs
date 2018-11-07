//FOOP_CA1_Nov2018
//11.7.2018
//Janessa Aulen, s00190968

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player : IComparable
    {
        public static int highscore = 0;
        public int PlayerID { get; }
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public Player(int playerid, string playername, int score)
        {
            this.PlayerID = playerid;
            this.PlayerName = playername;
            this.Score = score;
        }

        public void increaseScore(int amount)
        {
            Score += amount;
            if (Score > highscore)
            {
                highscore = Score;
            }
        }
        public override string ToString()
        {
            return string.Format("{0, 10} {1,10} {2,10}", PlayerID, PlayerName, Score);
        }

        public int CompareTo(object obj)
        {
            Player other = (Player)obj;

            if (this.Score > other.Score)
            {
                return 1;
            }
            else if (this.Score < other.Score)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
