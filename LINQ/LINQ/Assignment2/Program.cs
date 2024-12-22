using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("apple");
            fruits.Add("orange");
            fruits.Add("banana");
            fruits.Add("kiwi");
            fruits.Add("pineapple");
            fruits.Add("Mango");
            fruits.Add("Cherry");
            fruits.Add("fig");
            
            int Count = fruits.Count();

            Console.WriteLine($"Count of fruits: {Count}");
            
            Console.WriteLine("Length is Greater than 3 : ");
            
            var LetterCount = fruits.Where(fruit => fruit.Length > 3);

            foreach (var s in LetterCount)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Length Between 4 and 7 :");
            
            var SpecificLength = fruits.Where(fruit => fruit.Length >= 4 && fruit.Length <= 7);

            foreach (var s in SpecificLength)
            {
                Console.WriteLine(s);
            }
            
            var Ascendingorder = fruits.OrderBy(fruit => fruit);

            Console.WriteLine("\nAscending order : ");

            foreach (var o in Ascendingorder)
            {
                Console.WriteLine(o);
            }
            
            var Descendingorder = fruits.OrderByDescending(fruit => fruit);
            
            Console.WriteLine("\nDescending order : ");

            foreach (var d in Descendingorder)
            {
                Console.WriteLine(d);
            }
            
            var StartingWithM = fruits.Where(fruit => fruit.StartsWith("M"));

            Console.WriteLine("\nStarting with M : ");

            foreach (var m in StartingWithM)
            {
                Console.WriteLine(m);
            }
            
            var EndsWithErry = fruits.Where(fruit => fruit.EndsWith("erry"));   
            
            Console.WriteLine("\nEnding with Erry : ");

            foreach (var e in EndsWithErry)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}