/* This program was written to practise using methods. The methods defined calculate the area of 2D shapes, which are
 subsequently used within the main method to calculate the area of the floor plan of Teotihuacan. & The cost of building
the floor plan */

using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static double areaOfRectangle(double length, double width)
        {
            return length * width;
        }
        public static double areaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
        public static double areaOfTriangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
        public static void Main(string[] args)
        {
            double areaOfTeotihuacan;
            double priceOfFlooringTeotihuacan;
            // Checks that the methods are working
            Console.WriteLine(areaOfRectangle(4, 5));
            Console.WriteLine(areaOfCircle(4));
            Console.WriteLine(areaOfTriangle(10, 9));

            // floor plan of Teotihuacan (Ancient Mexico)
            areaOfTeotihuacan = areaOfRectangle(1500, 2500) + areaOfTriangle(500, 750) + (areaOfCircle(375) / 2);
            Console.WriteLine(areaOfTeotihuacan);
            priceOfFlooringTeotihuacan = areaOfTeotihuacan * 180;
            priceOfFlooringTeotihuacan = Math.Round(priceOfFlooringTeotihuacan, 2);
            Console.WriteLine($"It would have cost {priceOfFlooringTeotihuacan} Mexican pesos to contruct the floor of Teotihuacan");

        }
    }
}
