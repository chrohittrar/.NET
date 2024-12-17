using System;
using System.Collections.Generic;

namespace Assignment10
{
    internal class Program
    {
        public static void PrintDuplicatesOnce(string[] arr)
        {
            HashSet<string> seen = new HashSet<string>();
            HashSet<string> duplicates = new HashSet<string>();

            foreach (var name in arr)
            {
                if (seen.Contains(name))
                {
                    duplicates.Add(name); // Add to duplicates if already seen
                }
                else
                {
                    seen.Add(name); // Add to seen
                } 
            }

            foreach (var seen1 in seen)
            {
                Console.WriteLine(seen1); // Print each duplicate only once
            }
        }

        static void Main(string[] args)
        {
            string[] name = { "Rohit", "Shreya", "Aastha", "Amandeep", "Shreya" };

            PrintDuplicatesOnce(name);
        }
    }
}
