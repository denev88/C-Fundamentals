using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = RectangleArea();
            Console.WriteLine(area);
        }

        private static int RectangleArea()
        {
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = weight * height;
            return area;
        }
    }
}
