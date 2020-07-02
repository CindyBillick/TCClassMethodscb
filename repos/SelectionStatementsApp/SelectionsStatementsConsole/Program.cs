using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text.Encodings.Web;

namespace SelectionsStatementsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var rng = new Random();

            Console.WriteLine("Welcome to the Random Number Guessing Game!! ");
            Console.WriteLine("Please enter an upper bound for the number");
            var upperBound = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input a guess: ");
            var randomNumber = rng.Next(upperBound);

            var userNumber = int.Parse(Console.ReadLine());
            if (userNumber > randomNumber)
            {
                Console.WriteLine("Too High!!!");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Too Low");
            }

            else
            { 
                Console.WriteLine("Just Right! You Win!");
            }


            Console.WriteLine("What is your favorite subject?");
            var userResponse = Console.ReadLine();
             switch (userResponse)
            {
                case "C#":
                    Console.WriteLine("C#: Excellent choice, that is my favorite coding language");
                    break;

                case "Python":
                    Console.WriteLine("Python: Great language but not as good as CR#");
                    break;
                case "Java":
                    Console.WriteLine("Java:Great language but not as good as C#");
                    break;
                case "Ruby":
                    Console.WriteLine("Ruby: Great language but not as good as C#");
                    break;
                case "JavaScript":
                    Console.WriteLine("JavaScript Great language but not as good as C#");
                    break;
                default:
                    Console.WriteLine("We teach coding here...Not sure what you said");
                    break;


            }

        }



    }

}
        
    