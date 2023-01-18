using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInput = int.Parse(Console.ReadLine());
            int endInput = int.Parse(Console.ReadLine());

            for (int i = startInput; i <= endInput; i++)
            {
                char symbol = (char)i;
                Console.Write($"{symbol} ");
            }
        }
    }
}
