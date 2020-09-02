using System;

namespace NumberGuessingGame// this is a project i found on youtube https://www.youtube.com/watch?v=IhqdPDPV_g8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winningNumber = r.Next(1, 100);

            bool win = false;

            do
            {
                Console.Write("guess a number between 1 and 100.            ");
                string yourGuess = Console.ReadLine();

                int guessNumber = int.Parse(yourGuess);

                if (guessNumber > winningNumber)
                {
                    Console.WriteLine("Too high...Guess lower");
                }
                else if(guessNumber < winningNumber)
                {
                    Console.WriteLine("Too low....guess higher");
                }
                else if ( guessNumber == winningNumber)
                {
                    Console.WriteLine("Great Job! You win!");
                    win = true;
                }

                Console.WriteLine("");
            } while (win == false);

            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
