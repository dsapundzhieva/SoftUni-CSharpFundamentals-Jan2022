using System;

namespace _04_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minLenghtOfPassword = 6;
            const int maxLenghtOfPassword = 10;
            const int minDigitCount = 2;
            string password = Console.ReadLine();

            bool isPasswordValid = ValidatePassword(password, minLenghtOfPassword, maxLenghtOfPassword, minDigitCount);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
           

        }


        static bool ValidatePassword(string password, int minLength, int maxLength, int minDigitCount)
        {
            bool isPasswordValid = true;

            if (!ValidatePasswordLength(password, minLength, maxLength))
            {
                Console.WriteLine($"Password must be between {minLength} and {maxLength} characters");
                isPasswordValid = false;
            }
            if (!ValidatePasswordIsAlphaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }
           if (!ValidatePasswordDigitsMinCount(password, minDigitCount))
            {
                Console.WriteLine($"Password must have at least {minDigitCount} digits");
                isPasswordValid = false;
            }

            return isPasswordValid;

        }
        static bool ValidatePasswordLength(string password, int minLength, int maxLength)
        {
            int coundDigits = 0;

            foreach (char ch in password)
            {
                coundDigits++;
            }
            return coundDigits >= minLength && coundDigits <= maxLength;
        }

        static bool ValidatePasswordIsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidatePasswordDigitsMinCount(string password, int minDigitCount)
        {
            int digitCount = 0;

            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCount++;
                }
            }

            return digitCount >= minDigitCount;
        }
    }
}
