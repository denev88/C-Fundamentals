using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int result = ReturnSum(number, number2);
            Subtract(result, number3);
           
        }

        private static void Subtract(int result, int number3) => 
            Console.WriteLine(result - number3);
        

        private static int ReturnSum(int number, int number2) => number + number2;
       
       
    }
}
