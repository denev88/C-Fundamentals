﻿using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();   
            int n = int.Parse(Console.ReadLine());
            string result = _Repeat_String(input, n);
            Console.WriteLine(result);
        }
        

        private static string _Repeat_String(string input, int n)
        {
            string result = " ";
            for (int i = 0; i < n; i++)
            {
                result += input;
            }
            return  result;
        }
    }
}
