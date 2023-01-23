using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] arr2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
                double sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {

                    sum += arr1[i];

                    if (i == arr1.Length - 1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }
                }
            }

        }
    }
}
