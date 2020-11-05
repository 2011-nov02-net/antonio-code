using System;

namespace RockPaperScissors.Library
{
    public class AI
    {
        public static Choice PickChoice()
        {
            Random n = new Random();
            var c = Enum.GetValues(typeof(Choice));
            return (Choice)c.GetValue(n.Next(c.Length));
        }

        public static Result DecideWinner(Choice playerChoice, Choice AIChoice)
        {
            if (playerChoice == Choice.Paper && AIChoice == Choice.Rock)
            {
                return Result.Win;
            }
            if (playerChoice == Choice.Paper && AIChoice == Choice.Scissor)
            {
                return Result.Lose;
            }
            if (playerChoice == Choice.Scissor && AIChoice == Choice.Rock)
            {
                return Result.Lose;
            }
            if (playerChoice == Choice.Scissor && AIChoice == Choice.Paper)
            {
                return Result.Win;
            }
            if (playerChoice == Choice.Rock && AIChoice == Choice.Paper)
            {
                return Result.Lose;
            }

            if (playerChoice == Choice.Rock && AIChoice == Choice.Scissor)
            {
                return Result.Win;
            }
            return Result.Draw;
        }
    }
}
