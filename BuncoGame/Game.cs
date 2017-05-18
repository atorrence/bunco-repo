using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuncoGame
{
    public class Game
    {
        //start game
        public int Round { get; set; }
        public bool IsWinner;
        public List<Player> Players { get; set; } = new List<Player>();
        int team1and3Score = 0;
        int team2and4Score = 0;
        int team1and3Wins = 0;
        int team2and4Wins = 0;

        
        public void StartGame()
        {
            Round = 1;
            for (int i = 1; i <= 4; i++)
            {
                Players.Add(new Player()
                {
                    PlayerNumber = i
                });
            }

        }
        //Change the round number and start the new round
        public void UpdateRound()
        {
            Round = 2;
            if (Round <= 6)
            {
                Game g = new Game();
                for (int i = 1; i <= 4; i++)
                {
                    Players.Add(new Player()
                    {
                        PlayerNumber = i
                    });
                }
                g.PlayGame();
            }
            else
            {
                Console.WriteLine("stop");
            }
        }
        public void PlayGame()
        {
            IsWinner = false;
            Console.WriteLine($"Round {Round}. You are rolling for {Round}s");
            if (!IsWinner)
            {
                for (int i = 0; ; i++)
                {
                    int turnScore = 0;
                    TurnResult turnResult;
                    Player currentPlayer = Players[i];
                    do
                    {
                        turnResult = currentPlayer.Roll(Round);
                        Console.WriteLine($"{currentPlayer.PlayerNumber} scored a {turnResult.Score}");
                        turnScore += turnResult.Score;

                        //slow down the display
                        //Thread.Sleep(500);
                    }
                    while (turnResult.Score > 0);
                    //update team score
                    if (currentPlayer.PlayerNumber == 1 || currentPlayer.PlayerNumber == 3)
                    {
                        team1and3Score += turnScore;
                        Console.WriteLine($"Your team has {team1and3Score} points");
                        if (team1and3Score >= 21)
                        {
                            IsWinner = true;
                            Console.WriteLine("You win!");
                            team1and3Wins += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            break;

                        }
                    }
                    else
                    {
                        team2and4Score += turnScore;
                        Console.WriteLine($"Your team has {team2and4Score} points");
                        if (team2and4Score >= 21)
                        {
                            IsWinner = true;
                            Console.WriteLine("You win!");
                            team2and4Wins += 1;
                            Console.WriteLine();
                            Console.WriteLine();
                            break;

                        }
                    }
                    //rotate from player 4 to player 1
                    if (i == 3)
                    {
                        i = -1;
                    }
                }
            }

        }
    }
}