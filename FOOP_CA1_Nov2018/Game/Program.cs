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
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            Player[] Players = new Player[5];

            Players[0] = player1;
            Players[1] = player2;
            Players[2] = player3;
            Players[3] = player4;
            Players[4] = player5;

            int score = 1, playerNum = 0;
            bool again = true;

            while(again)
            {
                Console.WriteLine("Which player's score do you want to increase? There are players from 0 to 4.");
                while (!int.TryParse(Console.ReadLine(), out playerNum) && (playerNum < 0 || playerNum > 4))
                {
                    Console.WriteLine("Input a number for number of the player whose score you want to increase. There are players from 0 to 4.");
                }
                Console.WriteLine("Input a number for the score of player. Entering 0 for the score ends the program.");
                while (!int.TryParse(Console.ReadLine(), out score))
                {
                    Console.WriteLine("Input a number for the score of player" + playerNum + ".");
                }

                if (score == 0)
                {
                    again = false;
                }
                else
                {
                    again = true;
                }

                Console.WriteLine("You increased the score for player" + playerNum + " by " + score + " points.");

                switch (playerNum)
                {
                    case 0:
                        Players[0].increaseScore(score);
                        break;
                    case 1:
                        Players[1].increaseScore(score);
                        break;
                    case 2:
                        Players[2].increaseScore(score);
                        break;
                    case 3:
                        Players[3].increaseScore(score);
                        break;
                    case 4:
                        Players[4].increaseScore(score);
                        break;
                    default:
                        Console.WriteLine("!!!");
                        break;
                }
                displayScores(Players);
                
            }
            displayPlayersScores(Players);

            Console.WriteLine("\nSorted by score:");
            Array.Sort(Players);
            displayPlayersScores(Players);
            Console.WriteLine("\nHighest score of the game: " + Player.highscore + ".");
        }
        public static void displayScores(Player[] arr)
        {
            Console.WriteLine(string.Format("{0,10} {1,10} {2,10} {3,10} {4,10}", "Player1", "Player2", "Player3", "Player4", "Player5"));
            Console.WriteLine(string.Format("{0,10} {1,10} {2,10} {3,10} {4,10}", arr[0].Score, arr[1].Score, arr[2].Score, arr[3].Score, arr[4].Score));
        }

        public static void displayPlayersScores(Player[] arr)
        {
            Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", "PlayerId", "Player name", "Score"));
            foreach (Player p in arr)
            {
                Console.WriteLine(string.Format("{0,10} {1,10} {2,10}", p.PlayerID, p.PlayerName, p.Score));
            }
        }
    }
}
