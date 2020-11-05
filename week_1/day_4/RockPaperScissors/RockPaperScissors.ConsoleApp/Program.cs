using RockPaperScissors.Library;
using System;

namespace RockPaperScissors.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            GameManager GameManager = new GameManager();

            while(response != "n" || response != "N") {
                Console.WriteLine();
                Console.WriteLine("Enter your choice: (r, p, s)\n");
                string choice = Console.ReadLine();
                Match match = GameManager.RunGame(choice);

                Console.WriteLine($"Your Choice: {match._userChoice} AI Choice: {match._aiChoice} Result: {match._result}");
                GameManager.PrintMatchHistory();
            }
            
        }
    }
}
