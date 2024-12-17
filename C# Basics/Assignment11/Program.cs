namespace Assignment11
{
    internal class Program
    {
        public static void Display(int[] arr)
        {
            Console.WriteLine("Array Elemets : ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void SumOfAll(int[] arr) { 
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) { 
                sum += arr[i];
            }

            Console.WriteLine($"Sum of the Array is : {sum}");
        }

        public static void FindMaxAndMin(int[] arr) {
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Maximum value is : {max} and Minimum value is {min} \n");
        }

        public static bool isPerfect(int number)
        {
            int sum = 0;
            bool result = false;
            for (int i = 1; i <= (number/2) ; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if ((sum) == number) { 
                result = true;
            }

            return result;
        }


        public static void CheckPerfect(int[] arr) {

            HashSet<int> perfectNumbers = new HashSet<int>();
            HashSet<int> notPerfect = new HashSet<int>();

            foreach (var item in arr) {

                if (isPerfect(item))
                {
                    perfectNumbers.Add(item);
                }
                else
                {
                    notPerfect.Add(item);
                }

            }

            Console.WriteLine("All perfect numbers are : \n");
            foreach (var per in perfectNumbers) {
                Console.Write(per+" ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("All not perfect numbers are : \n");
            foreach (var notper in notPerfect)
            {
                Console.Write(notper+" ");
            }

            Console.WriteLine("\n");
        }

        private static void CheckPrimeNumber(int[] numbers)
        {

            HashSet<int> Primes = new HashSet<int>();
            HashSet<int> nonPrime = new HashSet<int>(); 

            foreach (var item in numbers)
            {
                if (isPrime(item))
                {
                    Primes.Add(item);
                }
                else
                {
                    nonPrime.Add(item);
                }
            }

            Console.WriteLine("Prime numbers : \n");
            foreach (var pitem in nonPrime)
            {
                Console.WriteLine(pitem);
            }

            Console.WriteLine("\n");

            Console.WriteLine("");
        }

        private static bool isPrime(int number)
        {
            bool result = true;
           for(int i = 2; i <= number/2; i++)
            {
                if(number%i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 6, 12, 34, 28, 59, 65, 57, 58, 98, 102};

            int choice = 0;
            do
            {
                Console.WriteLine("******** MENU **********\n" +
                    "1. Show all numbers \n" +
                    "2. Sum of all the numbers \n" +
                    "3. Minimum and Maximum in all the numbers\n" +
                    "4. Find if the number is Perfect number or not\n" +
                    "5. Check Array elements are Prime or not \n" +
                    "0. Exit\n");
                Console.WriteLine("Enter your Input : \n");
                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Display(numbers);
                            break;

                        case 2:

                            SumOfAll(numbers);
                            break;

                        case 3:

                            FindMaxAndMin(numbers);
                            break;

                        case 4:

                            CheckPerfect(numbers);
                            break;
                               
                        case 5:

                            CheckPrimeNumber(numbers);
                            break;
                              
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (choice != 0);
        }

        
    }
}
