namespace Assignment1
{

    class Example 
    {
        public int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Example emp = new Example();

            Console.WriteLine(emp.Multiplication(1, 2, 3));
            Console.WriteLine(emp.Multiplication(a: 12, b:4, c:1));


        }
    }
}
