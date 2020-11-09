using RockPaperScissors.Library;
using System;

namespace RockPaperScissors.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            var GameManager = new GameManager();
            string _filePath = "../../../data.json";

            var file = new JsonSaveFile(_filePath);
            file.Read();
            while (response != "n") {
                Console.WriteLine("Enter your choice: (r, p, s)\n");
                response = Console.ReadLine();
                Match match = GameManager.RunGame(response);

                Console.WriteLine($"Your Choice: {match._userChoice} AI Choice: {match._aiChoice} Result: {match._result}");
                GameManager.PrintMatchHistory();
            }

            file.Write(GameManager);
            
        }
    }
}
