using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddSum = 0;
            int evenSum = 0;

          foreach (int i in number)
            {
                if(i % 2 == 0) 
                {
                    oddSum += i;
                }
                else
                {
                    evenSum += i;
                }
            }
          int totalSum = oddSum - evenSum;
            Console.WriteLine(totalSum);
        }
    }
}
