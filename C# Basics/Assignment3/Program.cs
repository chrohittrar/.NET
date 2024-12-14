namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var name in args)
            {
                Console.WriteLine($"Welcome {name}");
            }
        }
    }
}
