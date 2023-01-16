using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           decimal pounds = decimal.Parse(Console.ReadLine());
            decimal usd = pounds * (decimal)(1.31);
            Console.WriteLine($"{usd:f3}");
        }
    }
}
