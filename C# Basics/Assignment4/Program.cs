namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks of Maths :");
            int MathsMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Chemistry :");
            int ChemistryMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of Physics :");
            int PhysicsMarks = int.Parse(Console.ReadLine());

            int Sum = PhysicsMarks + MathsMarks + ChemistryMarks;

            if (MathsMarks >= 65 && ChemistryMarks >= 55 && PhysicsMarks >= 50 || Sum >= 180)
            {
                Console.WriteLine("Eligible for Admission :))");
            }
            else
            {
                Console.WriteLine("Not Eligible for Admission :// ");
            }
        }
    }
}
