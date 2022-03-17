using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class GameWorkFlow
    {

        public void Run()
        {
            int player1Input;
            int player2Input;

            IChoiceGetter player1;
            IChoiceGetter player2;

            ConsoleIO io = new ConsoleIO();
            io.DisplayMenu();
            player1Input = io.GetIntUser("Enter implementation for player 1.");
            io.DisplayMenu();
            player2Input = io.GetIntUser("Enter implementation for player 2.");

            player1 = ChoiceGetter(player1Input);
            player2 = ChoiceGetter(player2Input);

            getResults(player1.GetType(), player2.GetType());

        }

        internal IChoiceGetter ChoiceGetter(int num)
        {
            switch (num)
            {
                case 1:
                    return new RandomPicker();
                    break;
       
                case 3:
                    return new AlwaysPickRock();
                    break;
                case 4:
                    return new AlwaysPickPaper();
                    break;
                case 5:
                    return new AlwaysPickScissors();
                    break;

            }
            return null;
        }

        public void getResults(RockPaperScissorType player1Choice , RockPaperScissorType player2Choice)
        {
            if(player1Choice == player2Choice)
            {
                Console.WriteLine("Tie");
            }
            else if((player1Choice == RockPaperScissorType.ROCK && player2Choice == RockPaperScissorType.PAPER) 
                || (player1Choice == RockPaperScissorType.PAPER && player2Choice == RockPaperScissorType.SCISSORS) 
                || (player1Choice == RockPaperScissorType.SCISSORS && player2Choice == RockPaperScissorType.ROCK))
            {
                Console.WriteLine("Player 2 Wins");
            }
            else
            {
                Console.WriteLine("Player 1 Wins");
            }

        }


    }
}
