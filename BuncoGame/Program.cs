using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuncoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bunco Game");
            Console.WriteLine();

            Game g = new Game();
            
            g.StartGame();
            g.PlayGame();

            //Game g2 = new Game();
            //g2.UpdateRound();

        }
    }
}
