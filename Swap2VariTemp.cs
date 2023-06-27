using System;
namespace Swap2VariTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, temp;
            Console.WriteLine("Values before Swap_____________");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after Swap______________");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}