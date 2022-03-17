using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class RandomPicker: IChoiceGetter
    {
        public RockPaperScissorType GetType()
        {
            Random random = new Random();
            int rand = random.Next(0, 4);

            switch (rand)
            {
                case 1:
                    return RockPaperScissorType.ROCK;
                    break;
                case 2:
                    return RockPaperScissorType.PAPER;
                    break;
                case 3:
                    return RockPaperScissorType.SCISSORS;
                    break;
                default:
                    break;
            }
            return RockPaperScissorType.ROCK;
        }
    }
}
