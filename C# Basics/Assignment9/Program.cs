namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());

            int orgno = number;
            int rev=0;

            while (number > 0) { 
            
                rev = (rev*10)+number%10;
                number /= 10;
            }

            if( orgno == rev)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}
