using System;

namespace one
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                    {
                        char edno = (char)('a' + i);
                        char dve = (char)('a' + j);
                        char tri = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", edno, dve, tri);
                    }
        }
    }
}