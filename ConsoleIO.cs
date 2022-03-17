using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class ConsoleIO
    {
        public int GetInt(string input)
        {
            bool isInt = true;
            int checkInput = 0;
            while (isInt)
            {
                if(int.TryParse(Console.ReadLine(), out checkInput))
                 {
                    isInt = false;

                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter integer!");
                }
            }

            return checkInput;
        }
        public void Displaymenu()
        {
            Console.WriteLine(@"1. Random Picker
2. Console Picker
3. Always Rock
4. Always Paper
5. Always Scissors");
        }


    }
}
