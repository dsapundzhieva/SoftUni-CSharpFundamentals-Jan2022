using System;

namespace _13_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double q1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            double q2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());

            GetLongestLineOfCoordinateSystem(x1, y1, x2, y2, q1, z1, q2, z2);    

        }

        static void GetLongestLineOfCoordinateSystem(double x1, double y1, double x2, double y2, double q1, double z1, double q2, double z2)
        {

            double firstX1Y1 = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secondX2Y2 = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            double firstQ1Z1 = Math.Sqrt(Math.Pow(q1, 2) + Math.Pow(z1, 2));
            double secondQ2Z2 = Math.Sqrt(Math.Pow(q2, 2) + Math.Pow(z2, 2));

            if (firstX1Y1 + secondX2Y2 >= firstQ1Z1 + secondQ2Z2)
            {
                if (firstX1Y1 < secondX2Y2)
                {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (firstQ1Z1 < secondQ2Z2)
                {
                    Console.WriteLine($"({q1}, {z1})({q2}, {z2})");
                }
                else
                {
                    Console.WriteLine($"({q2}, {z2})({q1}, {z1})");
                }
            }
        }
    }
}
