namespace Assignment3
{
    public class Box 
    {
        int length;
        int height;
        int width;

        public Box()
        {
            height = 0; width = 0; length = 0;
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public Box(Box box) 
        { 
            this.height = box.height;
            this.width = box.width;
            this.length = box.length;
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Length 
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }   
            set { width = value; }
        }

        public int CalVolume()
        {
            return length * height * width;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Box b1 = new Box();

            Console.WriteLine($"Volume is : {b1.CalVolume()}");

            Box b2 = new Box(3,4,5);

            Console.WriteLine($"Volume is : {b2.CalVolume()}");

            Box b3 = new Box(b2);

            Console.WriteLine($"Volume is : {b3.CalVolume()}");

        }
    }
}
