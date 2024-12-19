namespace Assignment6
{

    public class Student 
    {
        private int id;
        private float percentage;

        public Student(int id, float percentage)
        {
            Id = id;
            Percentage = percentage;
        }

        public int Id
            { get { return id; } set { id = value; } }
        public float Percentage 
            { get { return percentage; } set { percentage = value; } }

        public string GetGrades()
        {
            String grade = null;

            if (percentage >= 90)
                grade = "Excellent";
            else if (percentage >= 80 && percentage <= 89)
                grade = "Very Good";
            else if (percentage >= 70 && percentage <= 79)
                grade = "Good";
            else if (percentage >= 60 && percentage <= 69)
                grade = "Average";
            else if (percentage >= 40 && percentage <= 59)
                grade = "Pass";
            else
                grade = "Fail";

            return grade;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student Id and Percentage : ");
            int ID = int.Parse(Console.ReadLine());
            float Per = float.Parse(Console.ReadLine());
            
            Student st = new Student(ID, Per);

            Console.WriteLine($"Student id : {st.Id} => Result is : {st.GetGrades()}");
          
        }
    }
}
