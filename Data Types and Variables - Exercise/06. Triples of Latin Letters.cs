using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());

            // for (char i = 'a'; i <'a'+ n; i++)
            // {
            //     for (char j = 'a'; j < 'a'+ n; j++)
            //     {
            //         for (char k = 'a'; k < 'a'+ n; k++)
            //         {
            //
            //             Console.WriteLine($"{i}{j}{k}");
            //            
            //         }
            //
            //     }

            for (int i = 1; i < 1 + n; i++)
            {
                for (int j = 2; j < 2 + n; j++)
                {
                    for (int k = 3; k < 3 + n; k++)
                    {

                        Console.WriteLine($"{i}{j}{k}");

                    }

                }

            }
        }
    }
}
