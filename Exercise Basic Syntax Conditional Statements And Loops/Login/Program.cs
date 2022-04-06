using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            short attempts = 1;
            string correctPass = "";
            string password = Console.ReadLine();

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char usrnameChar = username[i];
                correctPass += usrnameChar.ToString();
            }

            if (correctPass.Equals(password))
            {
                Console.WriteLine($"User {username} logged in.");
            }

            while (!correctPass.Equals(password))
            {
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                attempts++;

                if (correctPass.Equals(password))
                {
                    Console.WriteLine($"User {username} logged in.");
                }
                else if (attempts == 4 && !correctPass.Equals(password))
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
        }
    }
}

