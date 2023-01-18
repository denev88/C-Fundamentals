using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const int  capacity = 255;
            int nLine = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < nLine; i++)
            {
                int include = int.Parse(Console.ReadLine());

                if(include + sum > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += include;
                }
              
            }
            Console.WriteLine($"{sum}");

        }
    }
}
