using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine();
        }



    }
}
