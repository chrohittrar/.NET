namespace Assignment2
{
    class Date
    {
        int DD;
        int MM;
        int YY;
        
        public Date()
        { }

        public Date(int D, int M, int Y)
        {
            DD = D;
            MM = M;
            YY = Y;
        }

        public Date(int D, int Y)
        {
            DD = D;
            MM = 12;
            YY = Y;
        }

        public int Day
        {
            get { return DD; }
            set { DD = value; }
        }

        public int Month
        {
            get { return MM; }
            set { MM = value; }
        }

        public int Year
        {
            get { return YY; }
            set { YY = value; }
        }

        public void ShowDate()
        {
            Console.WriteLine($"{DD}/{MM}/{YY}");
        }
    }


        internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();

            d.Day = 19;
            d.Month = 12;
            d.Year = 2024;

            d.ShowDate();

            Date d1 = new Date(31, 7 , 2002);
            d1.ShowDate();
        }
    }
}
