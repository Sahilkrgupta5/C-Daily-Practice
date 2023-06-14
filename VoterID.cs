using System;
namespace VoterID
{
    class Program
    {
        static void Main(string[] args)
        {
            string na;
            int age;
            Console.Write("Enter Your Nationality:");
            na = Console.ReadLine();
            if(na.ToLower()=="indian")
            {
                Console.Write("Enter the Age:");
                age = Convert.ToInt32(Console.ReadLine());
                if(age>=18)
                {
                    Console.Write("You are eligible for Vote");
                }
                else
                {
                    Console.Write("You are under Age");
                }
            }
            else
            {
                Console.Write("You are not Indian");
            }

        }
    }
}