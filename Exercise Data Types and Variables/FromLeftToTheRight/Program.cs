using System;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                string[] splitInput = input.Split(" ");

                long firstNum = long.Parse(splitInput[0]);
                long secondNum = long.Parse(splitInput[1]);

                if (firstNum > secondNum)
                {
                    long sum = 0;
                    for (int k = 0; k < splitInput[0].Length; k++)
                    {
                        sum += Math.Abs(firstNum % 10);
                        firstNum = (firstNum / 10);
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    long sum = 0;
                    for (int l = 0; l < splitInput[1].Length; l++)
                    {
                        sum += Math.Abs(secondNum % 10);
                        secondNum = (secondNum / 10);
                    }
                    Console.WriteLine(sum);
                }
            }
           
        }
    }
}
