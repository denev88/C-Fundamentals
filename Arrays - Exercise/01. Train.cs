using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;

            for (int index = 0; index < wagons.Length; index ++)
            {
                 wagons[index] = int.Parse(Console.ReadLine());
                sum += wagons[index];

            }
            foreach (var item in wagons)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}


             //
             //   int numbersOfWagons = int.Parse(Console.ReadLine());
             //   int[] wagons = new int[numbersOfWagons];
             //   int count = 0;
             //   for (int indexOfWagons = 0; indexOfWagons < wagons.Length; indexOfWagons++)
             //   {
             //       wagons[indexOfWagons] = int.Parse(Console.ReadLine());
             //       count += wagons[indexOfWagons];
             //   }
             //   foreach (int wagon in wagons)
             //   {
             //       Console.Write($"{wagon} ");
             //   }
             //   Console.WriteLine();
             //   Console.WriteLine(count);