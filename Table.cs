using System;
namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value:");
            int a=Convert.ToInt32(Console.ReadLine());
            int i = 1,table=0;

            while(i<=10)
            {
                table=a* i;
                Console.WriteLine(a + "*" + i + "=" + table);
                i++;
            }
        }
    }
}