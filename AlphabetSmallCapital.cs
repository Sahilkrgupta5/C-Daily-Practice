using System;
namespace AlphabetSmallCapital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Alphabet:");
            char a = Convert.ToChar(Console.ReadLine());
            if(a>=65 && a<=90)
            {
                Console.WriteLine("Alhabet is Capital");
            }
            else
            {
                Console.WriteLine("Alphabet is Small");
            }
        }
    }
}