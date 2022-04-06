using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message =string.Empty;
            for (int i = 0; i < n; i++)
            {
                string currentDigit = Console.ReadLine();
                int digitiLenght = currentDigit.Length;
                int mainDigit = currentDigit[0] - '0';
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 0)
                {
                    message += (char)(mainDigit + 32);
                    continue;
                }
                else if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitiLenght - 1;
                message += (char)(letterIndex + 97);
            }
            Console.WriteLine(message);
        }
    }
}
