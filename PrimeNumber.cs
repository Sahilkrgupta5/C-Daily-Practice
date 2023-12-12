//Prime Numbers
using System;
class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter the Number = ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		int prime=0;
		
		for(int i=1;i<=num;i++)
		{
			if(num%i==0)
			{
				prime++;
			}
		}
		if(prime==2)
		{
			Console.WriteLine("Number is Prime");
		}
	}
}