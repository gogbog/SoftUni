using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;
        int third = 0;
        for (int i = 0; i < n; i++)
        {
            third = first + second;
            first = second;
            second = third;
        }
        if (n == 0)
            Console.WriteLine("1");
        else
            Console.WriteLine(third);
    }
}