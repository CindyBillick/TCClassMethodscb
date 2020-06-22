
using System;

namespace TCClass5Methodscb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, what is your favorite sport?");
            String userSport = Console.ReadLine();

            Console.WriteLine($"Nice, choice {userSport}, why do you enjoy it?");
            string userEnjoys = Console.ReadLine();

            Console.WriteLine($"Do you like to participate in {userSport},or watch?");
            string userLike = Console.ReadLine();

            Console.WriteLine($"How often do you particpate or watch {userSport}?");
            string UserOften = Console.ReadLine();

            Console.WriteLine($"That is very interesting {userName}!");


            Console.WriteLine($"There was a gal named {userName} who loved {userSport}, she loves {userSport} because {userEnjoys} she {userLike} {UserOften}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is { sum}");

            Console.WriteLine("Give me a number to multiply");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to multiply to the first one");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The product is { product}");

        }

        public static int Sum(int num1, int num2)
        {
            int Sum = num1 + num2;

            return Sum;

        }


        public static int Multiply(int x, int y)
        {
            int Product = x * y;

            return Product;

        }


    }
}


        
    