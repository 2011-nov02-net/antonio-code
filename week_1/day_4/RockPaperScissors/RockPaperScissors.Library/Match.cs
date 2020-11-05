using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class Match
    {
        public Choice _userChoice { get; }
        public Choice _aiChoice { get; }
        public Result _result { get; }

        public Match(Choice userChoice, Choice aiChoice, Result result)
        {
            _userChoice = userChoice;
            _aiChoice = aiChoice;
            _result = result;
        }
    }
}
