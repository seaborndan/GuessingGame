using System;
using System.Linq;
using System.Collections.Generic;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number: ");
            string userGuess = Console.ReadLine();
            int parsedGuess = int.Parse(userGuess);
            Console.WriteLine(parsedGuess);
        }
    }
}
