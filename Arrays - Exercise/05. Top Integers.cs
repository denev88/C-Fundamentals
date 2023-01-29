using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                bool iSCurrNumIsBigger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int currNum1 = arr[j];

                   
                    if(currNum1 >= currNum)
                    {
                        iSCurrNumIsBigger = false;
                        break;
                    }

                }
                if(iSCurrNumIsBigger)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}
