using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "coffee",  "water", "coke", "snacks"

            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            price = orders(product, quantity, price);
        }

        private static double orders(string product, double quantity, double price)
        {
            if (product == "coffee")
            {
                price = quantity * 1.50;
            }
            else if (product == "water")
            {
                price = quantity * 1.00;
            }
            else if (product == "coke")
            {
                price = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                price = quantity * 2.00;
            }
            Console.WriteLine($"{price:f2}");
            return price;
        }
    }
}
