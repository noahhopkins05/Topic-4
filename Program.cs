using System.CodeDom.Compiler;
using System.Collections;
using System.Reflection.Emit;

namespace Topic_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pt 1
            int lowestNumber, highestNumber, generatedNumber, loop;
            int dice1, dice2;
            double num1, num2, lowestNumberDec, highestNumberDec;
            Random generator = new Random();
            
            Console.WriteLine("This is a random number generator.");
            Console.WriteLine("Enter the lowest possible number to generate:");
            lowestNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the highest possible number to generate");
            highestNumber = Int32.Parse(Console.ReadLine());
          

            loop = 9;
            while (loop >= 5)
            {
                generatedNumber = generator.Next(lowestNumber, highestNumber + 1);
                Console.Write(generatedNumber + " ");
                loop = loop - 1;
            }

            //Pt 2

            Console.WriteLine(" ");
            Console.WriteLine("Lets roll some dice.");
            dice1 = generator.Next(1, 7);
            dice2 = generator.Next(1, 7);
            Console.WriteLine("We rolled a " + dice1 + " and a " + dice2);

            // Pt 3

            Console.WriteLine("");
            Console.WriteLine("Lets generate some decimal numbers");
            Console.WriteLine("Enter the lowest possible number to generate");
            lowestNumberDec = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the highest possible number to generate");
            highestNumberDec = Int32.Parse(Console.ReadLine());


            while (loop >= 2)
            {
                num1 = generator.NextDouble();
                Console.Write(num1 + " ");
                loop = loop - 1;

            }

           


        }
    }
}