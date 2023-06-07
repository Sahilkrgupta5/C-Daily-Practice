using System;
namespace MarksheetIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Subject Marks");
            Console.Write("Hindi:");
            int hin = Convert.ToInt32(Console.ReadLine());
            Console.Write("English:");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Math:");
            int mat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Science:");
            int sci = Convert.ToInt32(Console.ReadLine());
            Console.Write("Social Sci:");
            int soc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sanskrit:");
            int san = Convert.ToInt32(Console.ReadLine());

            double total = hin + eng + mat + sci + soc + san;
            Console.WriteLine("Total Marks:" + total);
            total = (total / 600) * 100;
            Console.WriteLine("Percentage:"+total+"%");

            if(total>=60)
            {
                Console.WriteLine("First Division");
            }
            else if (total >= 50)
            {
                Console.WriteLine("Second Division");
            }
            else if(total>=30)
            {
                Console.WriteLine("Third Division");
            }
            else if(total>=40)
            {
                Console.WriteLine("You are Passed");
            }
            else
            {
                Console.WriteLine("Yor are Failed");
            }
        }
    }
}