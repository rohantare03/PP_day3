namespace Line_Comparison
{
    internal class Program
    {
        public double FindLength()
        {
            Console.WriteLine("Enter the coordinates of (x1,y1)");
            float x1 = Convert.ToInt32(Console.ReadLine());
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of (x2,y2)");
            float x2 = Convert.ToInt32(Console.ReadLine());
            float y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return length;
        }

        public static void Main(string[] args)
        {
            Program Length = new Program();
            double length1 = Length.FindLength();
            double length2 = Length.FindLength();
            
            if (length1 == length2)
            {
                Console.WriteLine("Line-1 is equal to Line-2");
            }
            else
            {
                Console.WriteLine("Line-1 is not equal to Line-2");
            }

        }
    
    }
}
