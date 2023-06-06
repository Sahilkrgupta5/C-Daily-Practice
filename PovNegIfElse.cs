using System;
namespace PovNegIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value to check Positive or Negative = ");
            int value=Convert.ToInt32(Console.ReadLine());

            if(value > 0)
            {
                Console.WriteLine("Value is Positive:" + value);
            }
            else if(value < 0)
            {
                Console.WriteLine("Value is Negative:" + value);
            }
            else
            {
                Console.Write("Value is Zero" + value);
            }
        }
    }
}