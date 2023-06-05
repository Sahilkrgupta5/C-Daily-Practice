using System;
namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Value:");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Value:");
            int s = Convert.ToInt32(Console.ReadLine());

            int sum = f + s;
            Console.WriteLine("Sum of Value:" + sum);
        }
    }
}