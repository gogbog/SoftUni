using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double result = output(side, type);

            Console.WriteLine("{0:F2}", result);
        }

        private static double output(double side, string type)
        {
            switch (type)
            {
                case "face":
                    return Math.Sqrt(2 * side * side);

                case "space":
                    return Math.Sqrt(3 * side * side);
                case "volume":
                    return side * side * side;
                case "area":
                    return 6 * side * side;
            }
            return 1;
        }


    }
}