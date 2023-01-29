using System;
using System.Linq;
using System.Transactions;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int j = 0; j < rotation; j++)
            {
                int currNumber = number[0];

                for (int i = 0; i < number.Length - 1; i++)
                {
                    number[i] = number[i + 1];
                }
                number[number.Length - 1] = currNumber;
            }
           
            Console.WriteLine(String.Join(' ', number));
        }


    }

}
            
     