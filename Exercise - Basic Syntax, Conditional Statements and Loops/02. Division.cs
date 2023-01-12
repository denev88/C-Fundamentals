using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int division = int.Parse(Console.ReadLine());

            if ( division % 10 == 0) 
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if(division % 7 == 0) 
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (division % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (division % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (division % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
