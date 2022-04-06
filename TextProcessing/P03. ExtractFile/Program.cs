using System;
using System.Linq;

namespace P03._ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textFile = Console.ReadLine();

            //string fileInfo = textFile.Substring(textFile.LastIndexOf('\\') + 1);

            //int dotIndex = fileInfo.LastIndexOf('.'); 

            //string fileName = fileInfo.Substring(0, dotIndex);
            //string fileExt = fileInfo.Substring(dotIndex + 1);

            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {fileExt}");


            string[] fileInfo = textFile.Split('\\')
                .Last()
                .Split('.');

            string fileName = string.Join(".", fileInfo.Take(fileInfo.Length - 1));

            string fileExt = fileInfo.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExt}");
        }
    }
}
