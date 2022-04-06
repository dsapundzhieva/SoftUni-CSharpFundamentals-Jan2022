using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersFromAlphabetcal = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + numbersFromAlphabetcal; i++)
            {
                for (int k = 97; k < 97 + numbersFromAlphabetcal; k++)
                {
                    for (int l = 97; l < 97 + numbersFromAlphabetcal; l++)
                    {
                        char resultI = (char)(i);
                        char resultK = (char)(k);
                        char resultL = (char)(l);

                        Console.WriteLine($"{resultI}{ resultK}{ resultL}");
                    }
                }
            }

           /* for (int i = 0; i < numbersFromAlphabetcal; i++)
            {
                for (int k = 0; k < numbersFromAlphabetcal; k++)
                {
                    for (int l = 0;  l < numbersFromAlphabetcal;  l++)
                    {
                        char lett1 = (char)('a' + i);
                        char lett2 = (char)('a' + k);
                        char lett3 = (char)('a' + l);

                        Console.WriteLine($"{lett1}{lett2}{lett3}");
                    }
                }
            }*/
        }
    }
}
