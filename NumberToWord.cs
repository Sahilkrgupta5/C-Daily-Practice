//Program to convert Number to Word
using System;
class Program
{
        static void Main(string[] args)
        {

            Console.Write("Enter the digit = ");
            int digit = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            string num = "";
            while(digit > 0)
            {
                int rem = digit % 10;
                rev = (rev * 10)+rem;
                digit = digit/10;
            }

            while(rev> 0)
            {
                int revRep = rev % 10;
                rev = rev / 10;

                switch (revRep)
                {
                    case 0:
                        num+= "Zero";
                        break;

                    case 1:
                        num+= "One";
                        break;

                    case 2:
                        num+= "Two";
                        break;

                    case 3:
                        num+= "Three";
                        break;

                    case 4:
                        num+= "Four";
                        break;

                    case 5:
                        num+= "Five";
                        break;

                    case 6:
                        num+= "Six";
                        break;

                    case 7:
                        num+= "Seven";
                        break;

                    case 8:
                        num+= "Eight";
                        break;

                    case 9:
                        num+= "Nine";
                        break;

                    case 10:
                        num+= "Ten";
                        break;

                    default:
                        num = "Please enter only number";
                        break;
                }
                num += " ";
            }
            Console.WriteLine(num);
        }
}
