using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class ConsoleIO
    {
        public int GetIntUser(string message)
        {
            bool running = true;
            int input = 0;
            while (running)
            {
                Console.WriteLine(message);
                if(int.TryParse(Console.ReadLine(), out input))
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Error inavlid input");
                }
            }
            return input;
        }

        public void DisplayMenu()
        {
            Console.WriteLine(@"1. Random Picker
2.Console Picker
3.Always Rock
4.Always Paper
5.Always Scissors

Enter choice: ");
        }

    }
}
