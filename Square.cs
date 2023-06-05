using System;
namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Value:");
            double value = Convert.ToDouble(Console.ReadLine());

            value = value * value;
            Console.WriteLine("Square:" + value);
        }
    }
}