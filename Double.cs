using System;
namespace Double
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Value:");
            int value = Convert.ToInt32(Console.ReadLine());

            value = value * 2;
            Console.WriteLine("Result:" + value);
        }
    }
}