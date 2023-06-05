using System;
namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Value:");
            int f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Value:");
            int s = Convert.ToInt32(Console.ReadLine());

            int sub = f - s;
            Console.WriteLine("Subtraction of Value:" + sub);
        }
    }
}