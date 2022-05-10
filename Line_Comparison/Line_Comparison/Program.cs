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
            double length = Length.FindLength();
            Console.WriteLine("The length of Two points of line :" + length);

        }
    
    }
}
