using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class AlwaysPickPaper:IChoiceGetter
    {
        public RockPaperScissorType GetType()
        {
            return RockPaperScissorType.PAPER;
        }


    }

}
