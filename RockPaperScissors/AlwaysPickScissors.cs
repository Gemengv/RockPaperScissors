using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class AlwaysPickScissors: IChoiceGetter
    {
        public RockPaperScissorType GetType()
        {
            return RockPaperScissorType.SCISSORS;
        }
    }
}

