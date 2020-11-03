using System;

namespace NumbersInSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAreaOfCircle(2.5));
        }

        static double CalculateAreaOfCircle(double r)
        {
            return Math.PI*(r*r);
        }
    }
}
