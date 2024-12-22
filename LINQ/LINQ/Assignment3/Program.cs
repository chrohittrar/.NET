using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> student = new List<Student>
            {
                new Student { no = 123, name = "Arun", language = "C#", age = 23, city = "Pune" },
                new Student { no = 124, name = "Akshay", language = "C#", age = 20, city = "Pune" },
                new Student { no = 125, name = "Rama", language = "C#", age = 22, city = "Nashik" },
                new Student { no = 126, name = "Riya", language = "C#", age = 25, city = "Nagar" },
                new Student { no = 127, name = "Amar", language = "java", age = 20, city = "Pune" },
                new Student { no = 128, name = "Vidya", language = "Vb", age = 22, city = "Nashik" },
                new Student { no = 129, name = "Prajakta", language = "java", age = 25, city = "Nagar" }
            };
            
            var PuneCity = student.Where(s => s.city == "Pune");

            foreach (var s in PuneCity)
            {
                Console.WriteLine(s.name);
            }
            
            double avg = student.Average(s => s.age);

            Console.WriteLine($"Average age: {avg}");
            
            int FindMax = student.Max(s => s.age);

            Console.WriteLine($"Max age: {FindMax}");

        }
    }
}