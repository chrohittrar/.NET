using System.Diagnostics.CodeAnalysis;

namespace Assignment7
{

    public class Maths
    {

        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }

        public float Addition(float a, float b) 
        { 
            return a + b; 
        }

        public int Addition(params int[] a) {

            int sum= 0;

            if (a.Length <= 0)
            {
                Console.WriteLine("No Input :///");
            }

            else
            {
                foreach (var item in a)
                {
                    sum += item;
                }
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Maths math = new Maths();

            Console.WriteLine(math.Addition(1, 2, 3));
            Console.WriteLine(math.Addition(-2, 3));
            Console.WriteLine(math.Addition(2.3f, 4.2f));

            Maths maths = new Maths();

            Console.WriteLine(maths.Addition(a:19, b:25, c:35));
            Console.WriteLine(maths.Addition(10, 5, 12, 3));

        }
    }
}
