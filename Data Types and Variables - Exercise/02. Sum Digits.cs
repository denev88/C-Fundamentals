using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int nNum = int.Parse(Console.ReadLine());

            int sum = 0;
            while (nNum != 0)
            {
               sum += nNum % 10;
                nNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
