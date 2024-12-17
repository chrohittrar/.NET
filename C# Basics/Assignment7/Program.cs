namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number : ");
            int Number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Number} x {i} = {Number * i}");
            }
        }
    }
}