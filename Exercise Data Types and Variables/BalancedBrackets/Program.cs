using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int numberOfLines = int.Parse(Console.ReadLine());

            bool isBalanced = true;
            bool isOpened = false;   

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input.Equals("("))
                {
                    if (!isOpened)
                    {
                        isOpened = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (input.Equals(")"))
                {
                    if (isOpened)
                    {
                        isOpened = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            if (isBalanced && !isOpened)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }*/

            int numberOfLines = int.Parse(Console.ReadLine());

            int countOpen = 0;
            int countClose = 0;
            bool isBalanced = true;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input.Equals("("))
                {
                    countOpen++;
                }
                else if (input.Equals(")"))
                {
                    countClose++;
                    if (countOpen - countClose != 0)
                    {
                        isBalanced = false;
                    }
                }

            }

            if (countClose == countOpen && isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


        }
    }
}
