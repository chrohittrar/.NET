using System;
using System.Linq;

namespace Assignment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] number = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };

            int TotalEle = number.Count();

            Console.WriteLine($"Total Count is : {TotalEle}");

            int TotalCount = number.Count(n => n > 40);

            Console.WriteLine($"Total Count is : {TotalCount}");

            int CountBetween = number.Count(n => n > 10 && n < 60);

            Console.WriteLine($"Count between 10 and 60 is : {CountBetween}");

            var OrderAsc = number.OrderBy(n => n);

            Console.WriteLine("In Ascending Order ");
            foreach (var n in OrderAsc)
            {
                Console.WriteLine(n);
            }
            
            var DescOrder = number.OrderByDescending(n => n);
            
            Console.WriteLine("In Descending Order ");
                    
            foreach (var n in DescOrder)
            {
                Console.WriteLine(n);
            }
            
        }
    }
}