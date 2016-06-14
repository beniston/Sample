using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find the Square value");
            double a, b;
            Console.WriteLine("Enter the value to find the square value");
            if (double.TryParse(Console.ReadLine(), out a)) {
            b  = a * a;
            Console.WriteLine("Square value for " + a + " is :"  + b); 
        } else {
            }
        }
    }
}
