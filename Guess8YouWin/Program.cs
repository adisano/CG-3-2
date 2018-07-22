using System;

namespace Guess8YouWin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 10:");
            string userGuess = Console.ReadLine();

            string winLose = (userGuess == "8") ? "WIN" : "LOSE";

            Console.WriteLine("You " + winLose + "!");
            Console.ReadLine();
        }
    }
}
