using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine("what is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var areaofCircle = CalculateArea(radius); 
            Console.WriteLine ($"The area of a circle with radius of {radius} is {areaofCircle}");
        }

        public static double CalculateArea(double radius)

        {
            return Math.PI * (radius * radius);

        }


    }

}