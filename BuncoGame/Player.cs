using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuncoGame
{
    public class Player
    {
        public int PlayerNumber { get; set; }
        public int Score { get; set; }
        public string Team { get; set; }
        public int TeamScore { get; set; }

        public Player()
        {
            this.PlayerNumber = PlayerNumber;
        }

        public TurnResult Roll(int round)
        {
            Random randNum = new Random();
            int dieA = randNum.Next(1, 7);
            int dieB = randNum.Next(1, 7);
            int dieC = randNum.Next(1, 7);
            return new TurnResult(round, dieA, dieB, dieC);
        }
    }
}
