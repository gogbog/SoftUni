using System;

namespace one
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Length: ");
            double duljina = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double shirina = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double visochina = double.Parse(Console.ReadLine());
            double obem = (duljina * shirina * visochina) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", obem);
        }
    }
}