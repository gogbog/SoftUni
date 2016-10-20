using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._3.Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split().Select(int.Parse).ToArray();


            

            Point point1 = new Point();
            point1.X = first[0];
            point1.Y = first[1];

            Point point2 = new Point();
            point2.X = second[0];
            point2.Y = second[1];

            Circle circle1 = new Circle();
            circle1.center(point1);
            circle1.Radius = first[2];

            Circle circle2 = new Circle();
            circle2.center(point2);
            circle2.Radius = second[2];

            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            int a = Math.Abs(c2.horizontal - c1.horizontal);
            int b = Math.Abs(c2.vertical - c1.vertical);

            double distance = Math.Sqrt(a * a + b * b);

            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }
            return false;
        }
    }

    class Circle
    {

        public int Radius { get; set; }
        public int horizontal = 0;
        public int vertical = 0;

        public void center(Point haha)
        {
            horizontal = haha.X;
            vertical = haha.Y;
        }
        
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }



}
