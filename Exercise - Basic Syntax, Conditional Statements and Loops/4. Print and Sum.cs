﻿using System;

namespace _4._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startSum = int.Parse(Console.ReadLine());
            int endSum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startSum; i <= endSum; i++)
            {
               
                Console.Write($"{i} ");
                sum += i;
                
            }
            Console.WriteLine( );
            Console.WriteLine($"Sum: {sum }");
        }
    }
}
