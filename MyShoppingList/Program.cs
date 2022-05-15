using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        private static object fileLocation;

        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Anti\Samples";
            Console.WriteLine("Sisestage kausta nimi");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisestage faili nimi");
            string fileName = Console.ReadLine();
            
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myshoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exists. ");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\ {fileName}");
            }
            

            
            while (loopActive)
            {
                Console.WriteLine("Would you to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter you wish:");
                    string userWish = Console.ReadLine();
                    //myshoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
        }
    }
}