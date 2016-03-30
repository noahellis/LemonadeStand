using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 35;
            Console.WindowWidth = 150;
            Console.SetWindowPosition(0, 0);
            Game startGame = new Game();
            startGame.StartGame();
        }
    }
}
