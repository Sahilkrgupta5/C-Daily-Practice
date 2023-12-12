//How to Reverse a Number
using System;
class Program
{
	static void Main(string[] args)
	{
		int num,rev=0;
		
		Console.Write("Enter the Number = ");
		num = Convert.ToInt32(Console.ReadLine());
		
		while(num !=0)
		{
			int rem = num%10;
			rev = (rev*10)+rem;
			num = num/10;
		}
		Console.WriteLine("Reverse Number = "+rev);
	}
}