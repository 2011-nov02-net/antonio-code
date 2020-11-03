using System;

namespace AcronymGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of words separated by spaces:");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            
            string acronym ="";

            for (int i = 0; i < words.Length; i++)
            {
                acronym += words[i][0];
            }

            Console.WriteLine(acronym.ToUpper());
        }
    }
}
