using System;
using System.Collections.Generic;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // · First number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]
          //
          // · Second number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]
          // 
          // · Third number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]
          // 
          // · Fourth number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]

          int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;
            Console.WriteLine(result);


        }
    }
}
