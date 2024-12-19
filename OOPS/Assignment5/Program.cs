namespace Assignment5
{

    public class Calculator
    {
        private int n1;
        private int n2;

        public Calculator() {
            n1 = 0; n2 = 0;
        }

        public Calculator(int n1, int n2) {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int Number1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public int Number2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public int Add()
        {
            return n1 + n2;
        }

        public int Sub()
        {
            return n1 - n2;
        }

        public int Mul()
        {
            return n1 * n2;
        }

        public int Div()
        {
            return n1 / n2;
        }

    }
        internal class Program
    {
        static void Main(string[] args)
        {
            
            Calculator cal = new Calculator();

            cal.Number1 = 24;
            cal.Number2 = 12;

            Console.WriteLine($"Addition is : {cal.Add()}");
            Console.WriteLine($"Difference is : {cal.Sub()}");
            Console.WriteLine($"Product is : {cal.Mul()}");
            Console.WriteLine($"Division is : {cal.Div()}");







        }
    }
}
