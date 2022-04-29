using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretWord = "pakistan";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguesses = false;

            while (guess != SecretWord && !outofguesses)
            {
                if (guesscount < guesslimit)
                {
                    Console.WriteLine("Enter Guess: ");
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofguesses = true;


                }
            }
                if (outofguesses)
                {
                    Console.WriteLine("You Loose");
                }
                else
                {
                    Console.WriteLine("You Win!");
                }
                    Console.ReadLine();

            
           
        }
    }
}
