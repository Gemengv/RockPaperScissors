using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public enum RockPaperScissorType
    {
        ROCK = 1,
        PAPER = 2,
        SCISSORS =3

    }
    internal interface IChoiceGetter
    {
        public RockPaperScissorType GetType();
        
    }
}
