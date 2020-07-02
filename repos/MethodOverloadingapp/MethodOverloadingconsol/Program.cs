using System;
using System.ComponentModel;

namespace MethodOverloadingconsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number");
            var userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give me a number");
            var userNumber2 = int.Parse(Console.ReadLine());


            var num = Add(userNumber, userNumber);

            Console.WriteLine(num);
            Console.WriteLine();

            Console.WriteLine("Please give me a number");
            var userDecimal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please give me a number");
            var userDecimal2 = decimal.Parse(Console.ReadLine());

            var dec = Add(userDecimal, userDecimal2);

            Console.WriteLine($"{ dec} this is from the decimal overload of the Add method!");
            Console.WriteLine();
        }

        public static int Add(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }


        public static decimal Add(decimal num1, decimal num2)
        {

            var result = num1 + num2;
            return result;

        }
    }
}
