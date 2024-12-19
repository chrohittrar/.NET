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

        public static void SumOfAll(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum of the Array is : {sum}");
        }

        public static void FindMaxAndMin(int[] arr)
        {
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
            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if ((sum) == number)
            {
                result = true;
            }

            return result;
        }


        public static void CheckPerfect(int[] arr)
        {

            HashSet<int> perfectNumbers = new HashSet<int>();
            HashSet<int> notPerfect = new HashSet<int>();

            foreach (var item in arr)
            {

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
            foreach (var per in perfectNumbers)
            {
                Console.Write(per + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("All not perfect numbers are : \n");
            foreach (var notper in notPerfect)
            {
                Console.Write(notper + " ");
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
            foreach (var pitem in Primes)
            {
                Console.WriteLine(pitem);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Non Primes are : ");
            foreach (var npitem in nonPrime)
            {
                Console.WriteLine(npitem);
            }

            Console.WriteLine("\n");

        }

        private static bool isPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void FindFrequency(int[] numbers)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            Console.WriteLine("Frequency of the elements in the array is :\n");
            foreach (KeyValuePair<int, int> freq in frequency)
            {
                Console.WriteLine($"{freq.Key} : {freq.Value}");
            }
        }

        private static void FindSecondSmallest(int[] numbers)
        {

        }


        static void Main(string[] args)
        {
            int[] numbers = { 6, 2, 34, 3, 59, 65, 59, 58, 5, 102 };

            int choice = 0;
            do
            {
                Console.WriteLine("******** MENU **********\n" +
                    "1. Show all numbers \n" +
                    "2. Sum of all the numbers \n" +
                    "3. Minimum and Maximum in all the numbers\n" +
                    "4. Find if the number is Perfect number or not\n" +
                    "5. Check Array elements are Prime or not \n" +
                    "6. Find Frequency\n" +
                    "7. Find the second smallest element\n" +
                    "8. Find the second Largest Element\n" +
                    "9. Sort the array is Ascending Order\n" +
                    "10.Sort the array in descending Order\n" +
                    "11.Reverse the array\n" +
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

                        case 6:

                            FindFrequency(numbers);
                            break;

                        case 7:

                            FindSecondSmallest(numbers);
                            break;

                        case 8:


                            break;

                        case 9:


                            break;

                        case 10:


                            break;

                        case 11:


                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (choice != 0);
        }

        
    }
}




















