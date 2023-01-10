using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 30;

            if(hour > 23) 
            {
                Console.WriteLine($"{hour}:{minute:d3}");

            }

            if (minute > 59)
            {
                hour += 1;
                minute -= 60;

            }
        }
    }
}
