using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrEven = new int[n];
            int[] arrOdd = new int[n];
            for (int i = 0; i < n; i++)
            {


               
                    int[] arrCurrent = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).
                        Select(int.Parse).
                        ToArray();
                    if (i % 2== 0)
                    {
                        arrEven[i] = arrCurrent[0];
                        arrOdd[i] = arrCurrent[1];
                    }
                    else
                    {
                        arrOdd[i] = arrCurrent[0];
                        arrEven[i] = arrCurrent[1];
                    }
                    


                
            }
                Console.WriteLine(string.Join(' ', arrEven));
                Console.WriteLine(string.Join(' ', arrOdd));

                    
            
        }
    }
}
