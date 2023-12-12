//Square Root of a Number Without sqrt Method
using System;
class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter the Value = ");
		int squ = Convert.ToInt32(Console.ReadLine());
		
		int root=1;
		
		for(int i=0;i<=squ;i++)
		{
			root=(squ/root+root)/2;
		}
		Console.WriteLine("Root of Squre = "+root);
	}
}