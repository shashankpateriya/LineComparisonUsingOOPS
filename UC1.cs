using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonOOPS
{
    class UC1
    {
        public static void SingleLine()
        {
            Console.WriteLine("Enter co-ordinates (x1, y1): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates (x2, y2): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("The Length of the line is: " + length);

        }
    }
}
