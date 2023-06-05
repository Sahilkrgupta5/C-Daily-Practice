using System;
namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Value:");
            double value = Convert.ToDouble(Console.ReadLine());

            value = value * value * value;
            Console.WriteLine("Cube:" + value);
        }
    }
}