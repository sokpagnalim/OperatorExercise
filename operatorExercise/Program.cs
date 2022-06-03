using System;

namespace operatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;//declaration &initialization
            int b = 4;

            int quotient; // declared
            int remainder;

            var sum = a + b;
            Console.WriteLine($"a+b = {sum}");
            Console.WriteLine($"a-b = {a - b}");
            var product = a * b;
            Console.WriteLine($"a x b = {product}");
            quotient = a / b;
            Console.WriteLine($"a / b = {quotient}");

           
            remainder = a % b;
            Console.WriteLine($"a / b = {quotient} with a remainder of {remainder}");
            Console.WriteLine();

            Console.WriteLine("What is the radius of your circle?");
             var radius = double.Parse(Console.ReadLine());
            var area=Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of circle with {radius} is {area}");
         
           
        }
    }
}
