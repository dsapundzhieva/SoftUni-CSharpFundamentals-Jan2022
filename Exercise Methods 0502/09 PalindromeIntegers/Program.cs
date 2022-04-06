using System;

namespace _09_PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                int number = int.Parse(command);
                Console.WriteLine(ValidateGivenNumberIsPalindrome(number));
            }
        }

        static bool ValidateGivenNumberIsPalindrome(int number)
        {
            string reversed = string.Empty;
            int digit = number;
            bool isPalindrome = false;

            while (digit > 0)
            {
                reversed += digit % 10;
                digit /= 10;
            }

            var reversedToInt = int.Parse(reversed);

            if (number == reversedToInt)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
