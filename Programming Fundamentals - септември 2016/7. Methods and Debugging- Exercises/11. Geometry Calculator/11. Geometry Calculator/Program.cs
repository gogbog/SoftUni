using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double side = 0.0;
            double height = 0.0;

            switch (figure)
            {
                case "triangle":
                    side = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", side * height / 2);
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", side * side);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", width * height);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", radius * radius * Math.PI);
                    break;
            }
        }




    }
}