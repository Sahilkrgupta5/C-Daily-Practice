using System;
namespace Swap2Vari
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 45, b = 65;
            Console.WriteLine("Values before Swap______________");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

            a = a + b;//a=110
            b = a - b;//b=45
            a = a - b;//a=65
            Console.WriteLine("Values after Swap_______________");
            Console.WriteLine("a=" + a );
            Console.WriteLine("b=" + b);
        }
    }
}