using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word == "a,o,u,e,i")
                sum += word[i];
            }
            Console.WriteLine(sum);

        }
    }
}
