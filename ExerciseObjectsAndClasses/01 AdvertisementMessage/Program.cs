using System;
using System.Collections.Generic;

namespace _01_AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            List<string> phrasesList = GetRandomizedList(phrases);
            List<string> eventsList = GetRandomizedList(events);
            List<string> authorsList = GetRandomizedList(authors);
            List<string> cityList = GetRandomizedList(cities);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrasesList[i].ToString()} {eventsList[i].ToString()} {authorsList[i].ToString()} – {cityList[i].ToString()}.");
            }
        }

        static List<string> GetRandomizedList(string[] array)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();

                int rndIndex = random.Next(i, array.Length);

                string currentElement = array[i];
                array[i] = array[rndIndex];
                array[rndIndex] = currentElement;

                list.Add(array[i]);
            }

            return list;
        }
    }
}
