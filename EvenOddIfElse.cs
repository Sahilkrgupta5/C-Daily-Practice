using System;
namespace EvenOddIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the No. to find Even Or Odd : ");
            int value = Convert.ToInt32(Console.ReadLine());

            if(value%2==0)
            {
                Console.Write("Number is Even = " + value);
            }
            else
            {
                Console.Write("Number is Odd = " + value);
            }
        }
    }
}