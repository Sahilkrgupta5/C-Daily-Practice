using System;
namespace CalculatorIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Value:");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operation:");
            string op = Console.ReadLine();

            Console.Write("Enter Second Value:");
            double s = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                f = f + s;
                Console.WriteLine("Result:" + f);
            }
            else if (op == "-")
            {
                f = f - s;
                Console.WriteLine("Result:" + f);
            }
            else if (op == "*")
            {
                f = f * s;
                Console.WriteLine("Result:" + f);
            }
            else if(op=="/")
            {
                f = f / s;
                Console.WriteLine("Result:" + f);
            }
            else if(op=="%")
            {
                f = f % s;
                Console.WriteLine("Result:" + f);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Kays");
            }
        }
    }
}