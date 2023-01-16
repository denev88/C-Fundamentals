using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int sumOfDigit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sumOfDigit; i++)
            {
                int sum = 0;
                int currentNumber = i;
               while(currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /=  10;
                   
                }
                if (i == 5 || i == 7 || i == 11 || i == 14)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }



            }

        }
    }
}
