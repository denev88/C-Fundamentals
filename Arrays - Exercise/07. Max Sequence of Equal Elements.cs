using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxElement = 0;
            int currentElement = 1;
            int element = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {



                if (input[i] == input[i + 1])
                {
                    currentElement++;
                }
                else
                {
                    currentElement = 1;
                }

                if (currentElement > maxElement)
                {
                    maxElement = currentElement;

                    element = input[i];
                }
  
              
            }
            for (int j = 0; j < maxElement; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}

