using System;
using System.Linq;
using System.Collections.Generic;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int secretNum = r.Next(1, 100);

            Console.WriteLine("Guess the secret number: ");
            bool foundNum = false;  
            int userTries = 0;
            int userTriesRemaining = 4;
            while((foundNum != true) && (userTriesRemaining != 0)) {
                string userGuess = Console.ReadLine();
                int parsedGuess = int.Parse(userGuess);
                if(parsedGuess == secretNum) {
                    Console.WriteLine("Yep, thats the number");
                    foundNum = true;
                }
                else {
                userTries++;
                Console.WriteLine("Nah that aint it, that was attempt # " + $"{userTries}");
                userTriesRemaining--;
                }
                
            }
        }
    }
}
