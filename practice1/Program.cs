using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1 {
    class Program {
        static void Main(string[] args) {

            Random num = new Random();
            
            Console.WriteLine("Please choose two numbers as boundaires.");
            Console.Write("Choose your first number: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Choose your second number: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            int correctNum = num.Next(x, y);

            bool win = false;
            int counter = 0;

            do
            {
                Console.Write("Guess a number between ");
                Console.Write(x);
                Console.Write(" and ");
                Console.Write(y);
                Console.Write(".  ");
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
