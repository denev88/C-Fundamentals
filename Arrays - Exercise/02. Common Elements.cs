﻿using System;
using System.IO;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] arr2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr2.Length; i++) 

            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr2[i] == arr[j])
                    {
                        Console.Write(arr2[i] + " ");
                    }
                }

            }
        }
    }
}
