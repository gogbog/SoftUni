using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double crap1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double crap2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (crap1 <= crap2)
                Console.WriteLine("({0}, {1})", x1, y1);
            else
                Console.WriteLine("({0}, {1})", x2, y2);
        }
    }
}