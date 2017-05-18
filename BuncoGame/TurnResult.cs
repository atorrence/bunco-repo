using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuncoGame
{
    public class TurnResult
    {
        //public string Result { get; set; }
        public int Score { get; private set; }
        public TurnResult(int round, int dieA, int dieB, int dieC)
        {
            if (dieA == round && dieB == round && dieC == round)
            {
                //Bunco = win
                Score = 21;
                //break from round
            }
            //if any of these events happen, player will roll again
            else if (dieA == dieB && dieA == dieC)
            {
                //Binky
                Score = 5;
            }
            else if (dieA == round && dieB == round)
            {
                Score = 2;
            }
            else if (dieA == round && dieC == round)
            {
                Score = 2;
            }
            else if (dieB == round && dieC == round)
            {
                Score = 2;
            }
            else if (dieA == round || dieB == round || dieC == round)
            {
                Score = 1;
            }


        }

    }
}
