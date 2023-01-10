using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());

            if (startNumber <= 10)
            {
                for (int i = startNumber; i <= 10; i++)
                {
                    Console.WriteLine($"{startNumber} * {i} = {n} * {i}");
                }
            }
            else
            {
                Console.WriteLine($"{startNumber} * {n} = {startNumber * n}");
            }
            
           
        }
    }
}
