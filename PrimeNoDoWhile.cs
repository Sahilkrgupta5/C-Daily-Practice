using System;
namespace PrimeNoDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value to check Prime = ");
            int value = Convert.ToInt32(Console.ReadLine());
            int i=1,prime=0;

            do
            {
                if (value%i == 0)
                {
                    prime++;
                }
                i++;
            } while (i<=value);
            if(prime==2)
            {
                Console.WriteLine("No. is Prime = " + value);
            }
            else if(prime==1)
            {
                Console.WriteLine("No. is Prime = " + value);
            }
            else
            {
                Console.WriteLine("No. is Non Prime = " + value);
            }
        }
    }
}