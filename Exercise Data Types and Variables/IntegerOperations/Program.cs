using System;

namespace IntegerOperations
{
    class Program
    {


        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());


            int addFirstToSecond = numberOne + numberTwo;
            int devideWithThird = addFirstToSecond / numberThree;
            int multiplyWithFour = devideWithThird * numberFour;

            Console.WriteLine(multiplyWithFour);
        }
    }
}
