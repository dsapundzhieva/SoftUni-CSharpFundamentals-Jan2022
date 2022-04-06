using System;

namespace Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                char[] word = input.ToCharArray();
                Array.Reverse(word);
                string reversed = new string(word);

                Console.WriteLine($"{input} = {reversed}");
            }
        }
    }
}
