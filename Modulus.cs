using System;
namespace Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Value:");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second Value:");
            double s = Convert.ToDouble(Console.ReadLine());

            f = f % s;
            Console.WriteLine("Remainder:" + f);
        }
    }
}