using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class GameWorkFlow
    {
        public void Run()
        {
            ConsoleIO io = new ConsoleIO();

            io.Displaymenu();
            int player1 = io.GetInt("Enter implementation for Player 1.");
            io.Displaymenu();
            int player2 = io.GetInt("Enter implementation for Player 2.");




        }
    }
}
