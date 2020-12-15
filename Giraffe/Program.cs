using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe", guess = "";
            int guessCount=0;
            int guessLimit = 3;
            bool isLimit = false;


            while(guess!=secretWord && !isLimit)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    isLimit = true;
                }
            }

            if (isLimit)
            {
                Console.WriteLine("Out of guesses.");
            }
            else
            {
                Console.WriteLine("Right Guess!");
            }
                Console.ReadLine();
        }
    }
}

