
using System;

namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var area = CalculateRactangleArea(width, height);
            Console.WriteLine(area);
        }

        static int CalculateRactangleArea(int width, int height)
        {
            return width * height;
        }
    }
}
