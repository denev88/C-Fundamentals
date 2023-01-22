using System;
using System.Linq;
namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // int n = int.Parse(Console.ReadLine());
          // int[] numbers = new int[n];
          //
          // for (int i = 0; i < n; i++)
          // {
          //     int currentNumber = int.Parse(Console.ReadLine());
          //     numbers[i] = currentNumber;
          //
          // }
          //
          //  for (int i = numbers.Length - 1; i >= 0; i--)
          // {
          //     Console.WriteLine($"{numbers[i]} " );
          // }

            int n = int.Parse(Console.ReadLine());
            int[] ints= new int[n];

            for (int i = ints.Length - 1; i >= 0; i--)
            {
                int currentNumbers = int.Parse(Console.ReadLine());
                ints[i] = currentNumbers;
                
            }
            Console.WriteLine(string.Join(' ',ints));
        }
    }
}
