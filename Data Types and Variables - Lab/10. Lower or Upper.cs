using System;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

          // if (Char.IsLower(firstChar))
          // {
          //     Console.WriteLine("lower-case");
          // }
          // else if (Char.IsUpper(firstChar))
          // {
          //     Console.WriteLine("upper-case");
          // }

            if(firstChar >= 65 && firstChar <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
    }
}
