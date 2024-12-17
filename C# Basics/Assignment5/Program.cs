namespace Assignment5
{
    internal class Program
    {
        public static int FindTotal(int m, int p, int c)
        {
            return m + c + p;
        }

        public static float FindPercentage(int m, int p, int c)
        {
            return (m + p + c / 3);
        }

        public static void Main(String[] args)
        {

            Console.WriteLine("Enter Roll Number :  ");
            String RollNo = Console.ReadLine();

            Console.WriteLine("Enter Name :  ");
            String StName = Console.ReadLine();

            Console.WriteLine("Enter Marks of Maths : ");
            int MathsMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Chemistry : ");
            int ChemistryMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Physics : ");
            int PhysicsMarks = int.Parse(Console.ReadLine());

            int TotalSum = FindTotal(MathsMarks, ChemistryMarks, PhysicsMarks);

            float percentage = FindPercentage(MathsMarks, ChemistryMarks, PhysicsMarks);

            String division = null;

            switch (percentage)
            {
                case >= 90:
                    division = "First Class";
                    break;
                case >= 80:
                    division = "Second Class";
                    break;
                case >= 70:
                    division = "Third Class";
                    break;

            }

            Console.WriteLine("*************************");


            Console.WriteLine($"Roll number : {RollNo}");
            Console.WriteLine($"Name  : {StName}");
            Console.WriteLine($"Marks in Maths: {MathsMarks}");
            Console.WriteLine($"Marks in Chemistry : {ChemistryMarks}");
            Console.WriteLine($"Marks in Physics : {PhysicsMarks}");
            Console.WriteLine($"Total Marks : {TotalSum}");
            Console.WriteLine($"Percentage : {percentage}");
            Console.WriteLine($"Division : {division}");
        }
    }
}
