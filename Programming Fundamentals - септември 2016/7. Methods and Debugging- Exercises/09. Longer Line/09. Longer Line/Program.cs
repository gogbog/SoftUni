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

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double point1 = radius(x1, y1);
            double point2 = radius(x2, y2);
            double point3 = radius(x3, y3);
            double point4 = radius(x4, y4);


            var lineLenght1 = CheckLenght(x1, y1, x2, y2);
            var lineLenght2 = CheckLenght(x3, y3, x4, y4);

            if (lineLenght1 >= lineLenght2)
            {
                if (point1 <= point2)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
            }
            else
            {
                if (point3 <= point4)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
            }

        }

        private static double CheckLenght(double x1, double y1, double x2, double y2)
        {
            double Lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return Lenght;
        }

        private static double radius(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}