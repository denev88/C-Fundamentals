using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double totalCourses = (double)person / capacity;
            Console.WriteLine(Math.Ceiling(totalCourses));
        }
    }
}
