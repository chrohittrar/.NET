namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i*j} ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
