using System;
namespace CalculatorSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Value:");
            double f=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operation:");
            string op = Console.ReadLine();

            Console.Write("Enter Second Value:");
            double s = Convert.ToDouble(Console.ReadLine());

            switch(op)
            {
                case "+":
                    f = f + s;
                    Console.WriteLine("Result:" + f);
                    break;
                case "-":
                    f = f - s;
                    Console.WriteLine("Result:" + f);
                    break;
                case"*":
                    f = f * s;
                    Console.WriteLine("Result:" + f);
                    break;
                case"/":
                    f = f / s;
                    Console.WriteLine("Result:" + f);
                    break;
                case "%":
                    f = f % s;
                    Console.WriteLine("Result:" + f);
                    break;
                default:
                    Console.WriteLine("Enter Valid Kays");
                    break;
            }
        }
    }
}