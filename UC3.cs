using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonOOPS
{
    class UC3
    {
        public static void CompareTo()
        {
            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter co-ordinates (x1, y1): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates (x2, y2): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("The Length of the line is: " + length);

            Console.WriteLine("Enter co-ordinates of line2");
            Console.WriteLine("Enter co-ordinates (a1, b1): ");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates (a2, b2): ");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            double l1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            double l2 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            if (l1.CompareTo(l2) > 0)
            {
                Console.WriteLine("Length of line 1 is greater than length of line 2");
            }
            else if (l2.CompareTo(l2) < 0)
            {
                Console.WriteLine("Length of line 1 is lesser than length of line 2");
            }
            else
            {
                Console.WriteLine("Length of both the lines are equal");
            }
        }
    }
}
