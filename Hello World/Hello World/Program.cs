using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------");
            Console.WriteLine("I'm thinking of a number between 1 - 10 (inclusive), what is it?");

            var random = new Random();
            int randomNumber = random.Next(1, 11);

            string userGuess = Console.ReadLine();
            while (userGuess != Convert.ToString(randomNumber))
            {
                int t;
                if(!int.TryParse(userGuess, out t))
                    Console.WriteLine("That's not even a number! Try again.");
                else
                {
                    if(t >= 1 && t <= 10)
                        Console.WriteLine("No, that's not it - guess again!");
                    else
                        Console.WriteLine("It's between 1 and 10 (inclusive) you numpty! Try again.");
                }

                userGuess = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Well done, you got it!");
            Console.ReadLine();
        }
    }
}
