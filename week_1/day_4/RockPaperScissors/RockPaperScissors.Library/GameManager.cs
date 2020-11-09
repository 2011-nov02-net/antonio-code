using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class GameManager
    {
        private List<Match> _matchHistory = new List<Match>();

        public Match RunGame(string _playerChoice)
        {
            Choice aiChoice = AI.PickChoice();
            Choice playerChoice = PlayerChoice(_playerChoice);
            Result result = AI.DecideWinner(playerChoice, aiChoice);

            Match match = new Match(playerChoice, aiChoice, result);
            AddMatch(match);

            return match;
        }

        public void AddMatch(Match completedMatch)
        {
            _matchHistory.Add(completedMatch);
        }

        public void PrintMatchHistory()
        {
            Console.WriteLine("History: ");
            int wins = 0, loses = 0, draws = 0;
            foreach(var m in _matchHistory)
            {
                //Console.WriteLine($"Your Choice: {m._userChoice} AI Choice: {m._aiChoice} Result: {m._result}");
                switch (m._result)
                {
                    case Result.Win:
                        wins++;
                        break;
                    case Result.Lose:
                        loses++;
                        break;
                    case Result.Draw:
                        draws++;
                        break;
                }
            }
            Console.WriteLine($"Wins: {wins}\n  Loses: {loses}\n  Draw {draws}\n");
        }


        public Choice PlayerChoice(string choice)
        {
            switch (choice)
            {
                case "r":
                    return Choice.Rock;
                case "p":
                    return Choice.Paper;
                case "s":
                    return Choice.Scissor;
                default:
                    break;
            }
            return Choice.Paper;
        }

        public List<Match> GetMatches()
        {
            return _matchHistory;
        }
    }
}
