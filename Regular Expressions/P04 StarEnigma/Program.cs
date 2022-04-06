using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04_StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanet = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string encyptedMessage = Console.ReadLine();

                string decryptedMessage = DecryptMessage(encyptedMessage);

                string patern = @"@(?<planetName>[A-Za-z]+)[^@\-!:>]*?\:(\d+)[^@\-!:>]*?\!(?<attackType>A|D)\![^@\-!:>]*?\-\>\d+";

                MatchCollection matches = Regex.Matches(decryptedMessage, patern);

                foreach (Match item in matches)
                {
                    string planetName = item.Groups["planetName"].Value;
                    string attackType = item.Groups["attackType"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanet.Add(planetName);
                    }
                }
            }

            Printoutput(attackedPlanets, destroyedPlanet);
        }

        static void Printoutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planetName in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planetName}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planetName in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planetName}");
            }
        }

        static string DecryptMessage(string encryptedMessage)
        {
            int decryptedKey = DecryptedKey(encryptedMessage);

            StringBuilder encryptMessage = new StringBuilder();

            foreach (var item in encryptedMessage)
            {
                char currItem = (char)(item - decryptedKey);
                encryptMessage.Append(currItem.ToString());
            }

            return encryptMessage.ToString();

        }

        static int DecryptedKey(string encryptedMessage)
        {
            string patern = @"[star]{1}";

            MatchCollection matches = Regex.Matches(encryptedMessage, patern, RegexOptions.IgnoreCase);

            return matches.Count;
        }
    }
}
