using System;
namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            year = year % 4;
            if (year == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("It is not a Leap Year");
            }
        }
    }
}