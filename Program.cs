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

            int secretNum = r.Next(1, 101);

            Console.WriteLine("Guess the secret number: ");
            bool foundNum = false;  
            int userTriesRemaining = 4;
            while((foundNum != true) && (userTriesRemaining != 0)) {
                string userGuess = Console.ReadLine();
                int parsedGuess = int.Parse(userGuess);
                if(parsedGuess == secretNum) {
                    Console.WriteLine("Yep, thats the number");
                    foundNum = true;
                }
                else {
                    userTriesRemaining--;
                    if(parsedGuess > secretNum) {
                        Console.WriteLine("Nah that aint it, your guess was higher than the secret number, you have " + $"{userTriesRemaining}" + " tries left");
                    }
                    else {
                        Console.WriteLine("Nah that aint it, your guess was lower than the secret number, you have " + $"{userTriesRemaining}" + " tries left");
                    }
                }
            }
        }
    }
}
