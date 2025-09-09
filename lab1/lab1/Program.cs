using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number (first): ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number (second): ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            Console.WriteLine($"Sum of {n1} and {n2} is {sum}");
        }
    }
}
