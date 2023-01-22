using System;
using System.Linq;
using System.Xml.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] item = Console.ReadLine().Split(' ');
            for (int i = item.Length - 1; i >= 0; i--)
            {

                Console.Write(item[i] + " ");
               
            }
        }
           


        
    }
}
