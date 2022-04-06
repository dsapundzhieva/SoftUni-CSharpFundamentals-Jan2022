using System;

namespace RefactorVolumePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volumeResult = (length * width * height) / 3;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volumeResult:f2}");
        }
    }
}
