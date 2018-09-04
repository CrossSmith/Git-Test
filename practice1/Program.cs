using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1 {
    class Program {
        static void Main(string[] args) {

            Random num = new Random();

            int correctNum = num.Next(0, 100);

            bool win = false;
            int counter = 0;

            do
            {
                Console.Write("Guess a number between 0 and 100:  ");
                string s = Console.ReadLine();

                int guess = int.Parse(s);

                if (guess > correctNum)
                {
                    Console.WriteLine("Your number is too high. Please try again.");
                    counter++;
                }
                else if (guess < correctNum)
                {
                    Console.WriteLine("Your number is too low. Please try again.");
                    counter++;
                }
                else if (guess == correctNum)
                {
                    Console.WriteLine("That is correct!");
                    Console.WriteLine();
                    Console.Write("It took you ");
                    Console.Write(counter);
                    Console.Write(" tries.");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            //Console.WriteLine("Thank you for playing");


            Console.ReadKey();
        }
    }
}
